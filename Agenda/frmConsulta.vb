Imports System.Text

Public Class frmConsulta
    Private intId As Integer
    Public ReadOnly Property Codigo As Integer
        Get
            Return intId
        End Get
    End Property

    Public Property AbertoCliente As Boolean = False

    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        'Cria classe
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
                strSQL.Append("SELECT * FROM CAD_CLIENTE WHERE ID IS NOT NULL ")
                strSQL.Append("AND CEP LIKE '%' & @cep & '%'")
            End If

            If strNome IsNot Nothing And strCEP Is Nothing Then
                strSQL.Append("SELECT * FROM CAD_CLIENTE WHERE ID IS NOT NULL ")
                strSQL.Append("AND NOME LIKE '%' & @nome & '%'")
            End If

            If strNome IsNot Nothing And strCEP IsNot Nothing Then
                strSQL.Append("SELECT * FROM CAD_CLIENTE WHERE ID IS NOT NULL ")
                strSQL.Append("AND CEP LIKE '%' & @cep & '%' ")
                strSQL.Append("AND NOME LIKE '%' & @nome & '%'")
            End If
            If strNome IsNot Nothing And strCEP Is Nothing Then
                strSQL.Append("SELECT * FROM CAD_CLIENTE")
            End If

            'Execulta a consulta
            Table = obj.ExecutaQueryDataTable(strSQL.ToString)

            'Seta Table no DataGridView
            dgvDados.AutoGenerateColumns = False
            dgvDados.DataSource = Table
            dgvDados.Refresh()

            'Verificação de dados
            If dgvDados.RowCount = 0 Then
                MessageBox.Show("Nenhum registro encontrado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("Ocorreu um erro:" & vbNewLine & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            obj = Nothing

        End Try
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub dgvDados_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvDados.KeyDown
        If AbertoCliente = True And dgvDados.RowCount > 0 And e.KeyCode = Keys.Enter Then
            intId = dgvDados.CurrentRow.Cells("colId").Value
            Me.Close()
        End If
    End Sub

    Private Sub dgvDados_DoubleClick(sender As Object, e As EventArgs) Handles dgvDados.DoubleClick
        If AbertoCliente = True And dgvDados.RowCount > 0 Then
            intId = dgvDados.CurrentRow.Cells("colId").Value
            Me.Close()
        End If
    End Sub
End Class