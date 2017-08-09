Imports MySql.Data.MySqlClient
Imports MySql.Data

Module Module1

    Public con As MySqlConnection = New MySqlConnection("data source = localhost; database = attpay_db; user id = root; password = erwin")
    Public ds As DataSet = New DataSet
    Public da As MySqlDataAdapter = New MySqlDataAdapter
    Public cmd As MySqlCommand = New MySqlCommand
    Public cmd2 As MySqlCommand = New MySqlCommand
    Public cmd3 As MySqlCommand = New MySqlCommand
    Public cmd4 As MySqlCommand = New MySqlCommand
    Public dr As MySqlDataReader
    Public dr2 As MySqlDataReader
    Public dr3 As MySqlDataReader
    Public dr4 As MySqlDataReader
    Public count As Integer
    Public query, query2, query3, query4 As String


End Module
