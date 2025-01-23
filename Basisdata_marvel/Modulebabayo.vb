Imports MySql.Data.MySqlClient

Module Modulebabayo
    Public strkon As String = "server=localhost; userid=root; database=2321023_rs"
    Public kon As New MySqlConnection(strkon)
    Public perintah As New MySqlCommand
    Public cek As MySqlDataReader
    Public mda As New MySqlDataAdapter
    Public ds As New DataSet
End Module
