


Imports System.Data.SqlClient


Public Class inicio


    Dim selected_codembarque As String = ""


    Private Sub inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Try
            Call cargar_conexion()
        Catch ex As Exception

        End Try


        Call cargar_empresas()
        Call cargar_meses()


        Me.cmbMes.SelectedValue = Today.Month
        Me.cmbAnio.Text = Today.Year.ToString

        Me.cmbActivo.Text = "NO"

        Call CargarGrid()



    End Sub


    Private Sub cargar_empresas()


        Dim tbl As New DS_General.tblEmpresasDataTable

        Try
            Using cn As New SqlConnection(strSqlConectionString)
                If cn.State <> ConnectionState.Open Then
                    cn.Open()
                End If

                Dim cmd As New SqlCommand("SELECT EMPNIT, NOMBRE AS EMPRESA FROM EMPRESAS", cn)

                Dim da As New SqlDataAdapter
                da.SelectCommand = cmd
                da.Fill(tbl)


            End Using
        Catch ex As Exception
            tbl = Nothing
        End Try


        With Me.cmbEmpresas
            .DataSource = tbl
            .DisplayMember = "EMPRESA"
            .ValueMember = "EMPNIT"
        End With

        GlobalEmpNit = Me.cmbEmpresas.SelectedValue

    End Sub


    Private Sub cargar_meses()

        Dim tblMeses As New DataTable
        With tblMeses.Columns
            .Add("CODMES", GetType(String))
            .Add("DESMES", GetType(String))
        End With


        With tblMeses.Rows
            .Add(New Object() {1, "ENERO"})
            .Add(New Object() {2, "FEBRERO"})
            .Add(New Object() {3, "MARZO"})
            .Add(New Object() {4, "ABRIL"})
            .Add(New Object() {5, "MAYO"})
            .Add(New Object() {6, "JUNIO"})
            .Add(New Object() {7, "JULIO"})
            .Add(New Object() {8, "AGOSTO"})
            .Add(New Object() {9, "SEPTIEMBRE"})
            .Add(New Object() {10, "OCTUBRE"})
            .Add(New Object() {11, "NOVIEMBRE"})
            .Add(New Object() {12, "DICIEMBRE"})
        End With


        With Me.cmbMes
            .DataSource = tblMeses
            .ValueMember = "CODMES"
            .DisplayMember = "DESMES"
        End With
    End Sub






    Private Sub CargarGrid()



        Try

            Dim empnit As String = Me.cmbEmpresas.SelectedValue.ToString
            Dim mes As Integer = CType(Me.cmbMes.SelectedValue, Integer)
            Dim anio As Integer = CType(Me.cmbAnio.Text, Integer)
            Dim st As String = Me.cmbActivo.Text



            Dim tbl As New DS_General.tblEmbarquesDataTable

            Try
                Using cn As New SqlConnection(strSqlConectionString)
                    If cn.State <> ConnectionState.Open Then
                        cn.Open()
                    End If

                    Dim cmd As New SqlCommand("SELECT EMBARQUES.CODEMBARQUE, 
                            EMBARQUES.DESCRIPCION, 
                            EMBARQUES.CODEMPLEADO AS CODREPARTIDOR, 
                            EMPLEADOS.NOMEMPLEADO, 
                            EMBARQUES.FECHA
                            FROM     EMBARQUES LEFT OUTER JOIN
                                              EMPLEADOS ON EMBARQUES.CODEMPLEADO = EMPLEADOS.CODEMPLEADO
                            WHERE  (EMBARQUES.EMPNIT = @E) 
                            AND (EMBARQUES.MES = @M) 
                            AND (EMBARQUES.ANIO = @A)
                            AND (EMBARQUES.FINALIZADO = @ST)", cn)
                    cmd.Parameters.AddWithValue("@E", empnit)
                    cmd.Parameters.AddWithValue("@ST", st)
                    cmd.Parameters.AddWithValue("@M", mes)
                    cmd.Parameters.AddWithValue("@A", anio)

                    Dim da As New SqlDataAdapter
                    da.SelectCommand = cmd
                    da.Fill(tbl)


                End Using
            Catch ex As Exception
                tbl = Nothing
                MsgBox(ex.ToString)
            End Try


            Me.gridEmbarques.DataSource = tbl

        Catch ex As Exception

        End Try






    End Sub

    Private Sub cmbEmpresas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbEmpresas.SelectedIndexChanged
        GlobalEmpNit = Me.cmbEmpresas.SelectedValue.ToString
        Call CargarGrid()
    End Sub

    Private Sub cmbMes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMes.SelectedIndexChanged
        Call CargarGrid()

    End Sub

    Private Sub cmbAnio_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbAnio.SelectedIndexChanged
        Call CargarGrid()

    End Sub

    Private Sub cmbActivo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbActivo.SelectedIndexChanged
        Call CargarGrid()

    End Sub



    Dim drw As DataRow

    Private Sub GridViewEmbarques_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridViewEmbarques.FocusedRowChanged

        drw = Nothing

        Try

            drw = Me.GridViewEmbarques.GetFocusedDataRow


            Me.lbEmbarque.Text = drw.Item(0).ToString
            selected_codembarque = drw.Item(0).ToString

        Catch ex As Exception


            Me.lbEmbarque.Text = "-"
        End Try

    End Sub

    Private Sub btnRptProductos_Click(sender As Object, e As EventArgs) Handles btnRptProductos.Click

        GlobalEmpNit = Me.cmbEmpresas.SelectedValue.ToString

        Call rptEmbarqueProductos(selected_codembarque)

    End Sub

    Private Sub btnRptDocumentos_Click(sender As Object, e As EventArgs) Handles btnRptDocumentos.Click

        GlobalEmpNit = Me.cmbEmpresas.SelectedValue.ToString

        Call rptEmbarqueDocumentos(selected_codembarque)

    End Sub

    Private Sub btnRptBoletas_Click(sender As Object, e As EventArgs) Handles btnRptBoletas.Click
        GlobalEmpNit = Me.cmbEmpresas.SelectedValue.ToString
        Call rptEmbarqueBoletas(selected_codembarque)

    End Sub

    Private Sub btnRptTickets_Click(sender As Object, e As EventArgs) Handles btnRptTickets.Click

        GlobalEmpNit = Me.cmbEmpresas.SelectedValue.ToString
        Call rptEmbarqueBoletasTicket(selected_codembarque)



    End Sub



End Class