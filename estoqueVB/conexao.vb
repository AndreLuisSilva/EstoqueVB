Imports npgsql
Module conexao
    Public conectar As NpgsqlConnection
    Public command As NpgsqlCommand
    Public dt As DataSet
    Public local As DataSet
    Public da As NpgsqlDataAdapter
    Public strsql As String
    Public resultado As Integer
    Public linha As DataRow
    Public caminho As String = "Server=localhost;Port=5432;UserId=postgres;Password=knop123;Database=SISTEMA_ESTOQUE_VBNET"
    Public vnivel As String
    Public count As Integer
End Module
