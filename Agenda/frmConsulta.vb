Imports System.Text

Public Class frmConsulta
    Private intId As Integer
    Public ReadOnly Property Codigo As Integer
        Get
            Return intId
        End Get
    End Property

    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        'Ce=ria classe
        Dim obj As New CAD_CLIENTE

        'Cria Tabela
        Dim Table As DataTable = Nothing

        'Cria Parametros
        Dim strNome As String = Nothing
        Dim strCEP As String = Nothing

        Dim strSQL As New StringBuilder


        Try
            If txtCEP.TextLength > 0 Then
                strCEP = txtCEP.Text
            End If
            If txtNome.TextLength > 0 Then
                strNome = txtNome.Text
            End If

            If strCEP IsNot Nothing Then
                obj.AddParam("@cep", strCEP)
            End If
            If strNome IsNot Nothing Then
                obj.AddParam("@nome", strNome)
            End If

            'Cria o select

            If strCEP IsNot Nothing And strNome Is Nothing Then
                strSQL.Append("SELECT * FROM CAD_CLIENTE WHERE ID IS NOT NULL")
                strSQL.Append("AND CEP LIKE '%@cep%'")
            End If
            If strNome IsNot Nothing And strCEP Is Nothing Then
                strSQL.Append("SELECT * FROM CAD_CLIENTE WHERE ID IS NOT NULL")
                strSQL.Append("AND NOME LIKE '%@nome%'")
            End If
            If strNome IsNot Nothing And strCEP Is Nothing Then
                strSQL.Append("SELECT * FROM CAD_CLIENTE WHERE ID IS NOT NULL")
                strSQL.Append("AND CEP LIKE '%@cep%' AND NOME LIKE '%@nome%'")
            End If

        Catch ex As Exception
            MessageBox.Show("Ocorreu um erro:" & vbNewLine & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            obj = Nothing

        End Try
    End Sub
End Class