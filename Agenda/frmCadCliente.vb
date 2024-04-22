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
End Class