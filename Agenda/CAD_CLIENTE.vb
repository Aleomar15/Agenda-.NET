Imports System.Data.OleDb

Public Class CAD_CLIENTE
#Region "Propriedades"
    Public Property ID As Integer
    Public Property NOME As String
    Public Property CEP As String
    Public Property BAIRRO As String
    Public Property COMPLEMENTO As String
    Public Property UF As String
    Public Property TEL1 As String
    Public Property TEL2 As String
    Public Property NUMERO As String

#End Region
#Region "Funções e Subrotinas"
#Region "variaveis"
    Private DBCon As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source= AGENDA.ACCDB;Persist Security Info=False;")
#End Region
#End Region
End Class
