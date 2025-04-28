Public Class inicio



    Private Sub inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load





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

        Me.cmbMes.SelectedValue = Today.Month
        Me.cmbAnio.Text = Today.Year.ToString



        Call CargarGrid()


    End Sub


    Private Sub CargarGrid()


    End Sub


End Class