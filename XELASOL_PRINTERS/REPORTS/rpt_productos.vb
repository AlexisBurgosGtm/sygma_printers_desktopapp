

Public Class rpt_productos



    Private Sub rpt_productos_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles MyBase.BeforePrint


        Call CargarResumen()


    End Sub

    Private Sub rpt_productos_AfterPrint(sender As Object, e As EventArgs) Handles MyBase.AfterPrint


        Call CargarResumen()


    End Sub


    Private Sub CargarResumen()


        'REPORTE RESUMEN VENDEDORES
        Try

            Dim Adapter As New SqlClient.SqlDataAdapter
            Dim repE As New rpt_sub_resumen_vendedores
            repE.DataSource = tbl_resumen_vendedor(GlobalEmpNit, GlobalSelectedCodembarque)
            repE.DataAdapter = Adapter
            repE.DataMember = "tbl_resumen_vendedor"
            repE.CreateDocument()

            Me.XrSubreportResumen.ReportSource = repE

        Catch ex As Exception

        End Try


    End Sub


End Class