
Imports System.Data.SqlClient
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraSplashScreen

Module GeneralModule

    Public cn As SqlConnection
    Public strSqlConectionString As String


    Public GlobalEmpNit As String = ""


    Public GlobalPathReportes As String = Application.StartupPath + "/"


    Public Sub cargar_conexion()
        Try
            Dim fic As String = Application.StartupPath + "\CONECTION.txt"
            Dim sr As New System.IO.StreamReader(fic)


            Dim server = sr.ReadLine()
            Dim dbs = sr.ReadLine()
            Dim user = sr.ReadLine()
            Dim pass = sr.ReadLine()
            sr.Close()

            strSqlConectionString = "Data Source=" & server & ";Initial Catalog=" & dbs & ";User ID=" & user & ";Password=" & pass & ";MultipleActiveResultSets=True"

            cn = New SqlConnection(strSqlConectionString)

        Catch ex As Exception
            MessageBox.Show("No existe CONECTION.TXT, consulte a servicio técnico")
            End
        End Try
    End Sub





    Public SelectedEmbarque As String = ""


    'REPORTE DE EMBARQUES PRODUCTOS
    Public Function rptEmbarqueProductos(ByVal codembarque As String) As Boolean
        Dim r As Boolean
        Dim tbl As New DS_General.tblRptPickingDataTable

        SelectedEmbarque = codembarque

        Dim pedidos As Double
        pedidos = getTotalesPicking(codembarque, "CONTEO")


        Using cn As New SqlConnection(strSqlConectionString)
            Try


                If cn.State <> ConnectionState.Open Then
                    cn.Open()
                End If

                'CARGA DE TOTAL DOCUMENTOS


                'CARGA DE DATOS DEL PICKING
                Dim sql As String


                sql = "SELECT  DOCPRODUCTOS.CODPROD, 
                                DOCPRODUCTOS.DESPROD, 
                                SUM(DOCPRODUCTOS.TOTALUNIDADES) AS TOTALUNIDADES, 
                                SUM(DOCPRODUCTOS.TOTALCOSTO) AS TOTALCOSTO, 
                                SUM(DOCPRODUCTOS.TOTALPRECIO) AS TOTALPRECIO, 
                                DOCUMENTOS.CODEMBARQUE, 
                                PRODUCTOS.UXC, 
                                EMPLEADOS.NOMEMPLEADO AS REPARTIDOR, 
                                EMBARQUES.DESCRIPCION AS DESEMBARQUE,
                                (SUM(DOCPRODUCTOS.TOTALUNIDADES) / PRODUCTOS.UXC) AS FACTOR
                    FROM  DOCUMENTOS LEFT OUTER JOIN
                         EMPLEADOS RIGHT OUTER JOIN
								EMBARQUES ON EMPLEADOS.CODEMPLEADO = EMBARQUES.CODEMPLEADO 
								AND EMPLEADOS.EMPNIT = EMBARQUES.EMPNIT ON DOCUMENTOS.EMPNIT = EMBARQUES.EMPNIT 
								AND DOCUMENTOS.CODEMBARQUE = EMBARQUES.CODEMBARQUE 
						LEFT OUTER JOIN
							PRODUCTOS 
						RIGHT OUTER JOIN
							DOCPRODUCTOS 
							ON PRODUCTOS.CODPROD = DOCPRODUCTOS.CODPROD
							ON DOCUMENTOS.CORRELATIVO = DOCPRODUCTOS.CORRELATIVO 
							AND DOCUMENTOS.CODDOC = DOCPRODUCTOS.CODDOC 
							AND DOCUMENTOS.MES = DOCPRODUCTOS.MES 
							AND DOCUMENTOS.ANIO = DOCPRODUCTOS.ANIO 
							AND DOCUMENTOS.EMPNIT = DOCPRODUCTOS.EMPNIT 
						LEFT OUTER JOIN
							TIPODOCUMENTOS 
							ON DOCUMENTOS.CODDOC = TIPODOCUMENTOS.CODDOC 
							AND DOCUMENTOS.EMPNIT = TIPODOCUMENTOS.EMPNIT
				GROUP BY DOCPRODUCTOS.CODPROD, DOCPRODUCTOS.DESPROD, DOCUMENTOS.CODEMBARQUE, 
						DOCUMENTOS.EMPNIT, PRODUCTOS.UXC, TIPODOCUMENTOS.TIPODOC, 
						EMPLEADOS.NOMEMPLEADO, DOCUMENTOS.STATUS, 
                         EMBARQUES.DESCRIPCION
				HAVING (TIPODOCUMENTOS.TIPODOC IN ('FAC', 'FCP', 'FEC', 'FEF', 'FES', 'FPC')) AND (DOCUMENTOS.STATUS <> 'A') 
				AND (DOCUMENTOS.EMPNIT = @E) AND (DOCUMENTOS.CODEMBARQUE = @C)
ORDER BY DOCPRODUCTOS.CODPROD"

                Dim cmd As New SqlCommand(sql, cn)
                cmd.Parameters.AddWithValue("@E", GlobalEmpNit)
                cmd.Parameters.AddWithValue("@C", codembarque)

                Dim dr As SqlDataReader = cmd.ExecuteReader
                Do While dr.Read
                    Dim uxc As Double = Double.Parse(dr(6))
                    Dim totalunidades As Double = Double.Parse(dr(2))
                    Dim caj As Double = totalunidades / uxc ' fardos totales con decimales // divide total unidades entre cajas
                    Dim cajas As Double = Math.Truncate(caj) 'obtiene el entero de la division anterior para tener los fardos
                    Dim unidades As Double = caj - cajas 'quito las cajas para obtener las unidades restantes
                    Dim u As Double = unidades * uxc
                    Dim un As Double = Math.Round(u)   ' Math.Ceiling(u) 'redondea hacia arriba 'CInt(Math.Ceiling(unidades * Double.Parse(dr(6))))

                    tbl.Rows.Add(New Object() {
                        dr(0), 'CODPROD
                        dr(1), 'DESPROD
                        dr(2), 'TOTALUNIDADES
                        dr(3), 'TOTALCOSTO
                        dr(4), 'TOTALPRECIO
                        dr(5), 'CODEMBARQUE
                        dr(6), 'UXC
                        cajas, 'CAJAS
                        un, 'UNIDADES
                        dr(7), 'DES-EMBARQUE
                        dr(8), 'REPARTIDOR
                        pedidos, 'TOTAL PEDIDOS / DOCUMENTOS
                        CType(dr("FACTOR"), Double) 'FACTOR
                    })
                Loop


                r = True
            Catch ex As Exception
                tbl = Nothing
                r = False
                MsgBox(ex.ToString)
            End Try
        End Using


        SplashScreenManager.ShowForm(inicio, GeneralWaitForm.GetType, True, True, ParentFormState.Locked)
        Dim report As New XtraReport
        Dim Adapter As New SqlDataAdapter
        report = New rpt_productos

        Try
            report.LoadLayout(GlobalPathReportes + "EMBARQUE_PRODUCTOS.repx")
        Catch ex As Exception
            report.SaveLayout(GlobalPathReportes + "EMBARQUE_PRODUCTOS.repx")
            report.LoadLayout(GlobalPathReportes + "EMBARQUE_PRODUCTOS.repx")
        End Try

        report.DataSource = tbl
        report.DataAdapter = Adapter
        report.DataMember = "tblRptPicking"

        Dim tool As ReportPrintTool = New ReportPrintTool(report)

        report.CreateDocument()

        SplashScreenManager.CloseForm()

        report.ShowPreview

        Return r

    End Function



    Public Function rptEmbarqueDocumentos(ByVal codembarque As String) As Boolean
        Dim r As Boolean
        Dim tbl As New DS_General.tblEmbarqueDocumentosDataTable

        Dim pedidos As Double
        pedidos = getTotalesPicking(codembarque, "CONTEO")

        Using cnh As New SqlConnection(strSqlConectionString)
            Try

                If cnh.State <> ConnectionState.Open Then
                    cnh.Open()
                End If


                Dim sql As String
                sql = "SELECT 
                        EMBARQUES.FECHA, 
                        DOCUMENTOS.CODDOC, 
                        DOCUMENTOS.CORRELATIVO, 
                        DOCUMENTOS.DOC_NIT AS NIT, 
                        CONCAT(CLIENTES.NEGOCIO, ' - ', DOCUMENTOS.DOC_NOMCLIE) AS NOMCLIENTE, 
                        DOCUMENTOS.DOC_DIRCLIE AS DIRCLIENTE, 
                        CLIENTES.EMAIL AS EMAIL, 
                        DOCUMENTOS.TOTALCOSTO, 
                        DOCUMENTOS.TOTALPRECIO AS TOTALVENTA, 
                        DOCUMENTOS.OBS, 
                        DOCUMENTOS.CODEMBARQUE, 
                        @PEDIDOS AS CONTEO, 
                        EMBARQUES.DESCRIPCION AS DESEMBARQUE, 
                        EMPLEADOS.NOMEMPLEADO AS NOMVEN
                    FROM  EMBARQUES RIGHT OUTER JOIN
                         CLIENTES RIGHT OUTER JOIN
                         EMPLEADOS RIGHT OUTER JOIN
                         DOCUMENTOS ON EMPLEADOS.CODEMPLEADO = DOCUMENTOS.CODEMP 
						 AND EMPLEADOS.EMPNIT = DOCUMENTOS.EMPNIT ON CLIENTES.CODCLIENTE = DOCUMENTOS.DOC_NIT 
						 AND CLIENTES.EMPNIT = DOCUMENTOS.EMPNIT ON EMBARQUES.CODEMBARQUE = DOCUMENTOS.CODEMBARQUE 
						 AND EMBARQUES.EMPNIT = DOCUMENTOS.EMPNIT LEFT OUTER JOIN
                         TIPODOCUMENTOS ON DOCUMENTOS.CODDOC = TIPODOCUMENTOS.CODDOC 
						 AND DOCUMENTOS.EMPNIT = TIPODOCUMENTOS.EMPNIT
                        WHERE (TIPODOCUMENTOS.TIPODOC IN ('FAC', 'FCP', 'FEC', 'FEF', 'FES', 'FPC')) 
                            AND (DOCUMENTOS.EMPNIT = @E) AND (DOCUMENTOS.STATUS <> 'A')
                        GROUP BY EMBARQUES.FECHA, DOCUMENTOS.CODDOC, DOCUMENTOS.CORRELATIVO, 
						DOCUMENTOS.DOC_NIT, DOCUMENTOS.DOC_NOMCLIE, CLIENTES.EMAIL, DOCUMENTOS.TOTALCOSTO, DOCUMENTOS.TOTALPRECIO, CLIENTES.NEGOCIO,
                         DOCUMENTOS.OBS, DOCUMENTOS.CODEMBARQUE, EMBARQUES.DESCRIPCION, DOCUMENTOS.DOC_DIRCLIE, EMPLEADOS.NOMEMPLEADO
                        HAVING (DOCUMENTOS.CODEMBARQUE = @C)"

                Dim cmd As New SqlCommand(sql, cnh)
                cmd.Parameters.AddWithValue("@E", GlobalEmpNit)
                cmd.Parameters.AddWithValue("@C", codembarque)
                cmd.Parameters.AddWithValue("@PEDIDOS", pedidos)
                Dim da As New SqlDataAdapter
                da.SelectCommand = cmd
                da.Fill(tbl)




                SplashScreenManager.ShowForm(inicio, GeneralWaitForm.GetType, True, True, ParentFormState.Locked)
                Dim report As New XtraReport
                Dim Adapter As New SqlDataAdapter
                report = New rpt_documentos

                Try
                    report.LoadLayout(GlobalPathReportes + "EMBARQUE_DOCUMENTOS.repx")
                Catch ex As Exception
                    report.SaveLayout(GlobalPathReportes + "EMBARQUE_DOCUMENTOS.repx")
                    report.LoadLayout(GlobalPathReportes + "EMBARQUE_DOCUMENTOS.repx")
                End Try

                report.DataSource = tbl
                report.DataAdapter = Adapter
                report.DataMember = "tblEmbarqueDocumentos"

                Dim tool As ReportPrintTool = New ReportPrintTool(report)

                report.CreateDocument()

                SplashScreenManager.CloseForm()

                report.ShowPreview


                r = True


            Catch ex As Exception
                MsgBox("ERROR: " & ex.ToString)
                r = False
            End Try
        End Using

        Return r

    End Function


    Public Function getTotalesPicking(ByVal codembarque As String, ByVal Resultado As String) As Double

        Dim conteo, suma As Double

        Using cn As New SqlConnection(strSqlConectionString)
            Try
                If cn.State <> ConnectionState.Open Then
                    cn.Open()
                End If

                Dim cm As New SqlCommand("SELECT  COUNT(DOCUMENTOS.CODDOC) AS TOTALDOCUMENTOS, SUM(DOCUMENTOS.TOTALPRECIO) AS TOTALVENTA
                    FROM  DOCUMENTOS LEFT OUTER JOIN
                         TIPODOCUMENTOS ON DOCUMENTOS.CODDOC = TIPODOCUMENTOS.CODDOC AND DOCUMENTOS.EMPNIT = TIPODOCUMENTOS.EMPNIT
                    WHERE (DOCUMENTOS.EMPNIT = @E) AND (TIPODOCUMENTOS.TIPODOC IN ('FAC', 'FCP', 'FEC', 'FEF', 'FES', 'FPC')) 
                        AND (DOCUMENTOS.STATUS <> 'A') AND (DOCUMENTOS.CODEMBARQUE = @C)", cn)
                cm.Parameters.AddWithValue("@E", GlobalEmpNit)
                cm.Parameters.AddWithValue("@C", codembarque)
                Dim d As SqlDataReader = cm.ExecuteReader
                d.Read()
                If d.HasRows = True Then
                    conteo = Double.Parse(d(0))
                    suma = Double.Parse(d(1))
                Else
                    conteo = 0
                    suma = 0
                End If
            Catch ex As Exception
                conteo = 0
                suma = 0

            End Try

        End Using

        If Resultado = "CONTEO" Then
            Return conteo
        End If
        If Resultado = "SUMA" Then
            Return suma
        End If

    End Function



    Public Function rptEmbarqueBoletas(ByVal codembarque As String) As Boolean
        Dim r As Boolean
        Dim tbl As New DS_General.tblEmbarquesBoletasDataTable

        Using cnh As New SqlConnection(strSqlConectionString)
            Try


                If cnh.State <> ConnectionState.Open Then
                    cnh.Open()
                End If


                Dim qry As String = ""
                qry = "SELECT DOCUMENTOS.FECHA, DOCUMENTOS.CODDOC, DOCUMENTOS.CORRELATIVO, CLIENTES.NIT, DOCUMENTOS.DOC_NOMCLIE AS NOMCLIENTE, 
                  CASE WHEN DOCUMENTOS.DOC_DIRCLIE = 'CIUDAD' THEN CLIENTES.DIRECCION ELSE DOCUMENTOS.DOC_DIRCLIE END AS DIRCLIENTE, ISNULL(CLIENTES.EMAIL, 'SN') AS EMAIL, DOCUMENTOS.TOTALPRECIO AS TOTALVENTA, 
                  ISNULL(DOCUMENTOS.OBS, '') AS OBS, DOCUMENTOS.CODEMBARQUE, ISNULL(CLIENTES.LATITUD, '0') AS LAT, ISNULL(CLIENTES.LONGITUD, '0') AS LONG, ISNULL(EMPLEADOS.NOMEMPLEADO, 'SN') AS DESREP, 
                  ISNULL(EMPLEADOS.NOMEMPLEADO, 'SN') AS NOMVEN, DOCPRODUCTOS.CODPROD, ISNULL(DOCPRODUCTOS.DESPROD, 'SN') AS DESPROD, DOCPRODUCTOS.CODMEDIDA, DOCPRODUCTOS.CANTIDAD, 
                  DOCPRODUCTOS.PRECIO, DOCPRODUCTOS.TOTALPRECIO, PRODUCTOS.UXC, DOCPRODUCTOS.TOTALUNIDADES, ISNULL(CLIENTES.CODCLIENTE, '0') AS CODCLIENTE, ISNULL(CLIENTES.REFERENCIA, '') AS REFERENCIA, 
                  ISNULL(CLIENTES.NEGOCIO, 'SN') AS NEGOCIO, EMPLEADOS.TELEFONO AS TELVENDEDOR, ISNULL(DOCUMENTOS.CONCRE, 'CON') AS TIPOPAGO, ISNULL(CLIENTES.TELEFONO, 'SN') AS TELCLIE
FROM     EMPLEADOS RIGHT OUTER JOIN
                  EMBARQUES ON EMPLEADOS.CODEMPLEADO = EMBARQUES.CODEMPLEADO AND EMPLEADOS.EMPNIT = EMBARQUES.EMPNIT RIGHT OUTER JOIN
                  CLIENTES RIGHT OUTER JOIN
                  DOCUMENTOS ON CLIENTES.CODCLIENTE = DOCUMENTOS.CODCLIENTE AND CLIENTES.EMPNIT = DOCUMENTOS.EMPNIT ON EMBARQUES.CODEMBARQUE = DOCUMENTOS.CODEMBARQUE AND 
                  EMBARQUES.EMPNIT = DOCUMENTOS.EMPNIT LEFT OUTER JOIN
                  PRODUCTOS RIGHT OUTER JOIN
                  DOCPRODUCTOS ON PRODUCTOS.CODPROD = DOCPRODUCTOS.CODPROD ON DOCUMENTOS.CORRELATIVO = DOCPRODUCTOS.CORRELATIVO AND DOCUMENTOS.CODDOC = DOCPRODUCTOS.CODDOC AND 
                  DOCUMENTOS.MES = DOCPRODUCTOS.MES AND DOCUMENTOS.EMPNIT = DOCPRODUCTOS.EMPNIT AND DOCUMENTOS.ANIO = DOCPRODUCTOS.ANIO LEFT OUTER JOIN
                  TIPODOCUMENTOS ON DOCUMENTOS.CODDOC = TIPODOCUMENTOS.CODDOC AND DOCUMENTOS.EMPNIT = TIPODOCUMENTOS.EMPNIT
WHERE  (TIPODOCUMENTOS.TIPODOC IN ('FAC', 'FCP', 'FEC', 'FEF', 'FES', 'FPC')) AND (DOCUMENTOS.STATUS <> 'A') AND (DOCUMENTOS.EMPNIT = @E) AND (DOCUMENTOS.CODEMBARQUE = @C)"

                Dim cmd As New SqlCommand(qry, cnh)
                cmd.Parameters.AddWithValue("@E", GlobalEmpNit)
                cmd.Parameters.AddWithValue("@C", codembarque)

                Dim dr As SqlDataReader = cmd.ExecuteReader
                Do While dr.Read
                    Dim cajas As Integer = CInt(Fix(Double.Parse(dr(21)) / Double.Parse(dr(20))))
                    Dim unidades As Integer = CInt(((Double.Parse(dr(21)) / Double.Parse(dr(20))) - cajas) * Integer.Parse(dr(20)))
                    tbl.Rows.Add(New Object() {
                                dr(0),'fecha
                                dr(1),'coddoc
                                dr(2),'correlativo
                                dr(3),'nit
                                dr(4),'nomcliente
                                dr(5),'dircliente
                                dr(6),'email
                                dr(7),'totalventa
                                dr(8),'obs
                                dr(9),'codembarque
                                dr(10),'lat
                                dr(11),'long
                                dr(12),'desrep
                                dr(13),'nomven
                                dr(14),'codprod
                                dr(15),'desprod
                                dr(16),'codmedida
                                dr(17),'cantidad
                                dr(18),'precio
                                dr(19), 'totalprecio     
                                dr(20), 'uxc
                                dr(21), 'total unidades     
                                cajas,'Embarque cajas
                                unidades, 'Embarque unidades
                                dr(23), 'REFERENCIA
                                dr(24), 'NEGOCIO
                    Integer.Parse(dr(22)), 'CODCLIENTE            
                                dr(25), 'TEL VENDEDOR
                                dr(26),  'TIPO PAGO (CONTADO O CREDITO)
                                dr(27)   'TELEFONO CLIENTE
                    })
                Loop

                SplashScreenManager.ShowForm(inicio, GeneralWaitForm.GetType, True, True, ParentFormState.Locked)
                Dim report As New XtraReport
                Dim Adapter As New SqlDataAdapter
                report = New rpt_boletas

                Try
                    report.LoadLayout(GlobalPathReportes + "EMBARQUE_BOLETAS.repx")
                Catch ex As Exception
                    report.SaveLayout(GlobalPathReportes + "EMBARQUE_BOLETAS.repx")
                    report.LoadLayout(GlobalPathReportes + "EMBARQUE_BOLETAS.repx")
                End Try

                report.DataSource = tbl
                report.DataAdapter = Adapter
                report.DataMember = "tblEmbarquesBoletas"

                Dim tool As ReportPrintTool = New ReportPrintTool(report)

                report.CreateDocument()

                SplashScreenManager.CloseForm()

                report.ShowPreview


                r = True
            Catch ex As Exception
                MsgBox(ex.ToString)
                r = False
            End Try
        End Using

        Return r

    End Function

    Public Function rptEmbarqueBoletasTicket(ByVal codembarque As String) As Boolean
        Dim r As Boolean
        Dim tbl As New DS_General.tblEmbarquesBoletasDataTable

        Using cnh As New SqlConnection(strSqlConectionString)
            Try


                If cnh.State <> ConnectionState.Open Then
                    cnh.Open()
                End If


                Dim qry As String = ""
                qry = "SELECT DOCUMENTOS.FECHA, DOCUMENTOS.CODDOC, DOCUMENTOS.CORRELATIVO, CLIENTES.NIT, DOCUMENTOS.DOC_NOMCLIE AS NOMCLIENTE, 
                  CASE WHEN DOCUMENTOS.DOC_DIRCLIE = 'CIUDAD' THEN CLIENTES.DIRECCION ELSE DOCUMENTOS.DOC_DIRCLIE END AS DIRCLIENTE, ISNULL(CLIENTES.EMAIL, 'SN') AS EMAIL, DOCUMENTOS.TOTALPRECIO AS TOTALVENTA, 
                  ISNULL(DOCUMENTOS.OBS, '') AS OBS, DOCUMENTOS.CODEMBARQUE, ISNULL(CLIENTES.LATITUD, '0') AS LAT, ISNULL(CLIENTES.LONGITUD, '0') AS LONG, ISNULL(EMPLEADOS.NOMEMPLEADO, 'SN') AS DESREP, 
                  ISNULL(EMPLEADOS.NOMEMPLEADO, 'SN') AS NOMVEN, DOCPRODUCTOS.CODPROD, ISNULL(DOCPRODUCTOS.DESPROD, 'SN') AS DESPROD, DOCPRODUCTOS.CODMEDIDA, DOCPRODUCTOS.CANTIDAD, 
                  DOCPRODUCTOS.PRECIO, DOCPRODUCTOS.TOTALPRECIO, PRODUCTOS.UXC, DOCPRODUCTOS.TOTALUNIDADES, ISNULL(CLIENTES.CODCLIENTE, '0') AS CODCLIENTE, ISNULL(CLIENTES.REFERENCIA, '') AS REFERENCIA, 
                  ISNULL(CLIENTES.NEGOCIO, 'SN') AS NEGOCIO, EMPLEADOS.TELEFONO AS TELVENDEDOR, ISNULL(DOCUMENTOS.CONCRE, 'CON') AS TIPOPAGO, ISNULL(CLIENTES.TELEFONO, 'SN') AS TELCLIE
FROM     EMPLEADOS RIGHT OUTER JOIN
                  EMBARQUES ON EMPLEADOS.CODEMPLEADO = EMBARQUES.CODEMPLEADO AND EMPLEADOS.EMPNIT = EMBARQUES.EMPNIT RIGHT OUTER JOIN
                  CLIENTES RIGHT OUTER JOIN
                  DOCUMENTOS ON CLIENTES.CODCLIENTE = DOCUMENTOS.CODCLIENTE AND CLIENTES.EMPNIT = DOCUMENTOS.EMPNIT ON EMBARQUES.CODEMBARQUE = DOCUMENTOS.CODEMBARQUE AND 
                  EMBARQUES.EMPNIT = DOCUMENTOS.EMPNIT LEFT OUTER JOIN
                  PRODUCTOS RIGHT OUTER JOIN
                  DOCPRODUCTOS ON PRODUCTOS.CODPROD = DOCPRODUCTOS.CODPROD ON DOCUMENTOS.CORRELATIVO = DOCPRODUCTOS.CORRELATIVO AND DOCUMENTOS.CODDOC = DOCPRODUCTOS.CODDOC AND 
                  DOCUMENTOS.MES = DOCPRODUCTOS.MES AND DOCUMENTOS.EMPNIT = DOCPRODUCTOS.EMPNIT AND DOCUMENTOS.ANIO = DOCPRODUCTOS.ANIO LEFT OUTER JOIN
                  TIPODOCUMENTOS ON DOCUMENTOS.CODDOC = TIPODOCUMENTOS.CODDOC AND DOCUMENTOS.EMPNIT = TIPODOCUMENTOS.EMPNIT
WHERE  (TIPODOCUMENTOS.TIPODOC IN ('FAC', 'FCP', 'FEC', 'FEF', 'FES', 'FPC')) AND (DOCUMENTOS.STATUS <> 'A') AND (DOCUMENTOS.EMPNIT = @E) AND (DOCUMENTOS.CODEMBARQUE = @C)"

                Dim cmd As New SqlCommand(qry, cnh)
                cmd.Parameters.AddWithValue("@E", GlobalEmpNit)
                cmd.Parameters.AddWithValue("@C", codembarque)

                Dim dr As SqlDataReader = cmd.ExecuteReader
                Do While dr.Read
                    Dim cajas As Integer = CInt(Fix(Double.Parse(dr(21)) / Double.Parse(dr(20))))
                    Dim unidades As Integer = CInt(((Double.Parse(dr(21)) / Double.Parse(dr(20))) - cajas) * Integer.Parse(dr(20)))
                    tbl.Rows.Add(New Object() {
                                dr(0),'fecha
                                dr(1),'coddoc
                                dr(2),'correlativo
                                dr(3),'nit
                                dr(4),'nomcliente
                                dr(5),'dircliente
                                dr(6),'email
                                dr(7),'totalventa
                                dr(8),'obs
                                dr(9),'codembarque
                                dr(10),'lat
                                dr(11),'long
                                dr(12),'desrep
                                dr(13),'nomven
                                dr(14),'codprod
                                dr(15),'desprod
                                dr(16),'codmedida
                                dr(17),'cantidad
                                dr(18),'precio
                                dr(19), 'totalprecio     
                                dr(20), 'uxc
                                dr(21), 'total unidades     
                                cajas,'Embarque cajas
                                unidades, 'Embarque unidades
                                dr(23), 'REFERENCIA
                                dr(24), 'NEGOCIO
                    Integer.Parse(dr(22)), 'CODCLIENTE            
                                dr(25), 'TEL VENDEDOR
                                dr(26),  'TIPO PAGO (CONTADO O CREDITO)
                                dr(27)   'TELEFONO CLIENTE
                    })
                Loop

                SplashScreenManager.ShowForm(inicio, GeneralWaitForm.GetType, True, True, ParentFormState.Locked)
                Dim report As New XtraReport
                Dim Adapter As New SqlDataAdapter
                report = New rpt_ticket

                Try
                    report.LoadLayout(GlobalPathReportes + "EMBARQUE_TICKETS.repx")
                Catch ex As Exception
                    report.SaveLayout(GlobalPathReportes + "EMBARQUE_TICKETS.repx")
                    report.LoadLayout(GlobalPathReportes + "EMBARQUE_TICKETS.repx")
                End Try

                report.DataSource = tbl
                report.DataAdapter = Adapter
                report.DataMember = "tblEmbarquesBoletas"

                Dim tool As ReportPrintTool = New ReportPrintTool(report)

                report.CreateDocument()

                SplashScreenManager.CloseForm()

                report.ShowPreview


                r = True
            Catch ex As Exception
                MsgBox(ex.ToString)
                r = False
            End Try
        End Using

        Return r

    End Function



End Module
