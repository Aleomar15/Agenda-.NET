Public Class frmCadCliente
#Region "Variaveis"
    Private Enum Opcao As Integer
        Cancelar = 0
        Incluir = 1
        Editar = 2
        Consultar = 3
    End Enum
    Private intOpcao As Opcao


#End Region
#Region "Subrotinas"
    ''' <summary>
    ''' Subtina para ativar e desativar os componentes do formulário
    ''' </summary>
    ''' <param name="Status">True: Ativa componentes. False: Desativa componentes</param>
    Private Sub AtivaDesativa(ByVal Status As Boolean)
        If Status = False Then
            txtId.Enabled = Status
            btnPesquisar.Enabled = Status
        End If
        txtNome.Enabled = Status
        txtCEP.Enabled = Status
        btnCorreio.Enabled = Status
        txtEndereco.Enabled = Status
        txtBairro.Enabled = Status
        txtUF.Enabled = Status
        txtNumero.Enabled = Status
        txtComplemento.Enabled = Status
        txtTel1.Enabled = Status
        txtTel2.Enabled = Status


    End Sub
    ''' <summary>
    ''' Subrotina para cancelar qualquer tipo de operação em execução
    ''' </summary>
    Private Sub CancelaOperacao()
        If intOpcao = Opcao.Incluir And txtNome.TextLength > 0 Then
            If MessageBox.Show("Você tem certeza que deseja cancelar a inclusão", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.No Then
                Exit Sub
            End If
        ElseIf intOpcao = Opcao.Editar And txtId.Enabled = False Then
            If MessageBox.Show("Você tem certeza que deseja cancelar a edição", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.No Then
                Exit Sub
            End If
        End If

        'Seta tipo operação
        intOpcao = Opcao.Cancelar

        'Limpa componentes
        txtId.Clear()
        txtNome.Clear()
        txtCEP.Clear()
        txtEndereco.Clear()
        txtNumero.Clear()
        txtBairro.Clear()
        txtUF.Clear()
        txtComplemento.Clear()
        txtTel1.Clear()
        txtTel2.Clear()


        'Chamar sub rotina para desativar componentes
        AtivaDesativa(False)

        'Configura barra de ferramentas
        tsbIncluir.Enabled = True
        tsbEditar.Enabled = True
        tsbPesquisar.Enabled = True
        tsbSave.Enabled = False
        tsbCancelar.Enabled = False


    End Sub
#End Region
    Private Sub tsbIncluir_Click(sender As Object, e As EventArgs) Handles tsbIncluir.Click
        'Seta tipo de operãção
        intOpcao = Opcao.Incluir

        'Chama subrotina para ativar os componentes
        AtivaDesativa(True)

        'Desativa os botões de controle
        tsbIncluir.Enabled = False
        tsbEditar.Enabled = False
        tsbPesquisar.Enabled = False

        'Ativa os botões de controle
        tsbSave.Enabled = True
        tsbCancelar.Enabled = True

        'Seta focus
        txtNome.Focus()
    End Sub

    Private Sub tsbPesquisar_Click(sender As Object, e As EventArgs) Handles tsbPesquisar.Click
        'Seta tipo de operãção
        intOpcao = Opcao.Consultar 'é o pesquisar


        'Desativa os botões de controle
        tsbIncluir.Enabled = False
        tsbEditar.Enabled = False
        tsbPesquisar.Enabled = False

        'Ativa os botões de controle
        tsbCancelar.Enabled = True
        txtId.Enabled = True
        btnPesquisar.Enabled = True


        'Seta focus
        txtId.Focus()
    End Sub

    Private Sub tsbEditar_Click(sender As Object, e As EventArgs) Handles tsbEditar.Click
        'Seta tipo de operãção
        intOpcao = Opcao.Editar


        'Desativa os botões de controle
        tsbIncluir.Enabled = False
        tsbEditar.Enabled = False
        tsbPesquisar.Enabled = False

        'Ativa os botões de controle
        tsbCancelar.Enabled = True
        txtId.Enabled = True
        btnPesquisar.Enabled = True


        'Seta focus
        txtId.Focus()
    End Sub

    Private Sub tsbCancelar_Click(sender As Object, e As EventArgs) Handles tsbCancelar.Click
        'Chama subrotina para cancelar
        CancelaOperacao()
    End Sub

    Private Sub tsbExit_Click(sender As Object, e As EventArgs) Handles tsbExit.Click
        Me.Close()

    End Sub

    Private Sub frmCadCliente_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If intOpcao = Opcao.Incluir And txtNome.TextLength > 0 Then
            If MessageBox.Show("Você tem certeza que deseja cancelar a inclusão", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.No Then
                e.Cancel = True
            End If
        ElseIf intOpcao = Opcao.Editar And txtId.Enabled = False Then
            If MessageBox.Show("Você tem certeza que deseja cancelar a edição", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.No Then
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub frmCadCliente_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If tsbIncluir.Enabled = True And e.KeyCode = Keys.F2 Then
            tsbIncluir_Click(Nothing, Nothing)
        ElseIf tsbPesquisar.Enabled = True And e.KeyCode = Keys.F3 Then
            tsbPesquisar_Click(Nothing, Nothing)
        ElseIf tsbEditar.Enabled = True And e.KeyCode = Keys.F4 Then
            tsbEditar_Click(Nothing, Nothing)
        ElseIf tsbSave.Enabled = True And e.KeyCode = Keys.F5 Then
            tsbSave_Click(Nothing, Nothing)
        ElseIf tsbCancelar.Enabled = True And e.KeyCode = Keys.Escape Then
            tsbCancelar_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub tsbSave_Click(sender As Object, e As EventArgs) Handles tsbSave.Click
        'Declaração de classe
        Dim obj As New CAD_CLIENTE

        Try
            'Preenche dados
            If txtId.TextLength > 0 Then obj.ID = Convert.ToInt32(txtId.Text)
            obj.NOME = txtNome.Text

        Catch ex As Exception
            MessageBox.Show("Ocorreu um erro:" & vbNewLine & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            obj = Nothing
        End Try
    End Sub
End Class