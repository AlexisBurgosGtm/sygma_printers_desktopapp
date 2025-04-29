
Imports System.Data.SqlClient

Module GeneralModule

    Public cn As SqlConnection
    Public strSqlConectionString As String

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





End Module
