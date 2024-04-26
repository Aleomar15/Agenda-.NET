Imports System.Data.OleDb

Public Class CAD_CLIENTE
#Region "Propriedades"
    Public Property ID As Integer
    Public Property NOME As String
    Public Property CEP As String
    Public Property BAIRRO As String
    Public Property ENDERECO As String
    Public Property COMPLEMENTO As String
    Public Property UF As String
    Public Property TEL1 As String
    Public Property TEL2 As String
    Public Property NUMERO As String
    Public Property CIDADE As String

#End Region
#Region "variaveis"
    Private DBCon As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Agenda.accdb;Persist Security Info=False;") 'conexão com o db
    Private DBCmd As OleDb.OleDbCommand 'variavel de comando onde será executado o SQL
    Private DBDa As OleDb.OleDbDataAdapter 'recebe os dados
    Private objDR As OleDb.OleDbDataReader 'le os dados
    Private Paramns As New List(Of OleDb.OleDbParameter) 'listas de parametros
#End Region
#Region "Funções e Subrotinas"
    ''' <summary>
    ''' Função para consulta e retorno dos dados nas propiedades
    ''' </summary>
    ''' <param name="Query">passa o comando SQL</param>
    ''' <returns></returns>
    Public Function ExecutaQueryReader(ByVal Query As String) As Boolean
        Dim blnOK As Boolean = False

        Try
            'Abre a conexão do banco
            DBCon.Open()

            'Cria comando
            DBCmd = New OleDb.OleDbCommand(Query, DBCon)

            'Adciona os parametros no comando
            Paramns.ForEach(Sub(p) DBCmd.Parameters.Add(p))

            'Limpar lista de parametros
            Paramns.Clear()

            'Executa
            objDR = DBCmd.ExecuteReader

            'Preencher propiedades
            While objDR.Read()
                If Not IsDBNull(objDR("NOME")) Then
                    Me.NOME = objDR("NOME").ToString
                End If
                If Not IsDBNull(objDR("ID")) Then
                    Me.NOME = objDR("ID").ToString
                End If
                If Not IsDBNull(objDR("ENDERECO")) Then
                    Me.NOME = objDR("ENDERECO").ToString
                End If
                If Not IsDBNull(objDR("CEP")) Then
                    Me.NOME = objDR("CEP").ToString
                End If
                If Not IsDBNull(objDR("NUMERO")) Then
                    Me.NOME = objDR("NUMERO").ToString
                End If
                If Not IsDBNull(objDR("BAIRRO")) Then
                    Me.NOME = objDR("BAIRRO").ToString
                End If
                If Not IsDBNull(objDR("COMPLEMENTO")) Then
                    Me.NOME = objDR("COMPLEMENTO").ToString
                End If
                If Not IsDBNull(objDR("UF")) Then
                    Me.NOME = objDR("UF").ToString
                End If
                If Not IsDBNull(objDR("TEL1")) Then
                    Me.NOME = objDR("TEL1").ToString
                End If
                If Not IsDBNull(objDR("TEL2")) Then
                    Me.NOME = objDR("TEL2").ToString
                End If
                If Not IsDBNull(objDR("CIDADE")) Then
                    Me.NOME = objDR("CIDADE").ToString
                End If
                blnOK = True

            End While
        Catch ex As Exception
            Throw ex
        Finally
            If DBCon.State = ConnectionState.Open Then
                DBCon.Close()
            End If
        End Try

        Return blnOK

    End Function
    ''' <summary>
    ''' Função para executar Insert, Update e Delete
    ''' </summary>
    ''' <param name="sql">passa o camendo SQL</param>
    ''' <returns></returns>
    Public Function ExecutaQuery(ByVal sql As String) As Boolean
        Dim blnOK As Boolean = False

        Try
            'Abre a conexão do banco
            DBCon.Open()

            'Cria comando
            DBCmd = New OleDb.OleDbCommand(sql, DBCon)

            'Adciona os parametros no comando
            Paramns.ForEach(Sub(p) DBCmd.Parameters.Add(p))

            'Limpar lista de parametros
            Paramns.Clear()

            'Executa
            blnOK = DBCmd.ExecuteNonQuery



        Catch ex As Exception
            Throw ex
        Finally
            If DBCon.State = ConnectionState.Open Then
                DBCon.Close()
            End If
        End Try

        Return blnOK
    End Function
    ''' <summary>
    ''' Função para execuatar Select com retorno de mais um Resultado
    ''' </summary>
    ''' <param name="sql">Passa o comando SQL</param>
    ''' <returns></returns>
    Public Function ExecutaQueryDataTable(ByVal sql As String) As DataTable
        Dim dt As New DataTable


        Try
            'Abre a conexão do banco
            DBCon.Open()

            'Cria comando
            DBCmd = New OleDb.OleDbCommand(sql, DBCon)

            'Adciona os parametros no comando
            Paramns.ForEach(Sub(p) DBCmd.Parameters.Add(p))

            'Limpar lista de parametros
            Paramns.Clear()

            'Executa
            DBDa = New OleDb.OleDbDataAdapter(DBCmd)

            DBDa.Fill(dt)


        Catch ex As Exception
            Throw ex
        Finally
            If DBCon.State = ConnectionState.Open Then
                DBCon.Close()
            End If
        End Try

        Return dt
    End Function
    Public Sub AddParam(ByVal Nome As String, ByVal valor As Object)
        Dim Novo As New OleDb.OleDbParameter(Nome, valor)
        Paramns.Add(Novo)

    End Sub
#End Region
End Class
