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
    Private Sub Pesq()

    End Sub
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
        txtCidade.Enabled = Status


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
        txtCidade.Clear()

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

        Dim strSQL As New Text.StringBuilder

        Try
            'Preenche dados
            If txtId.TextLength > 0 Then obj.ID = Convert.ToInt32(txtId.Text)
            obj.NOME = txtNome.Text
            obj.CEP = txtCEP.Text
            obj.ENDERECO = txtEndereco.Text
            obj.BAIRRO = txtBairro.Text
            obj.UF = txtUF.Text
            obj.NUMERO = txtNumero.Text
            obj.COMPLEMENTO = txtComplemento.Text
            obj.TEL1 = txtTel1.Text
            obj.TEL2 = txtTel2.Text
            obj.CIDADE = txtCidade.Text

            'Adiciona parametros
            obj.AddParam("@nome", obj.NOME)
            obj.AddParam("@cep", obj.CEP)
            obj.AddParam("@endereco", obj.ENDERECO)
            obj.AddParam("@bairro", obj.BAIRRO)
            obj.AddParam("@uf", obj.UF)
            obj.AddParam("@numero", obj.NUMERO)
            obj.AddParam("@complemento", obj.COMPLEMENTO)
            obj.AddParam("@tel1", obj.TEL1)
            obj.AddParam("@tel2", obj.TEL2)
            obj.AddParam("@cidade", obj.CIDADE)
            'Seleciona opção
            Select Case intOpcao
                Case Opcao.Incluir 'inclui novo cliente
                    strSQL.Append("INSERT INTO CAD_CLIENTE (NOME, CEP, ENDERECO, BAIRRO, UF, NUMERO, COMPLEMENTO, TEL1, TEL2, CIDADE) VALUES (")
                    strSQL.Append("@nome,")
                    strSQL.Append("@cep,")
                    strSQL.Append("@endereco,")
                    strSQL.Append("@bairro,")
                    strSQL.Append("@uf,")
                    strSQL.Append("@numero,")
                    strSQL.Append("@complemento,")
                    strSQL.Append("@tel1,")
                    strSQL.Append("@tel2,")
                    strSQL.Append("@cidade)")
                    'Inclui no banco
                    If obj.ExecutaQuery(strSQL.ToString) = True Then
                        If MessageBox.Show("Cliente incluindo com sucesso!" & vbNewLine & "Deseja incluir outro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                            'Setar operação como cancelar
                            intOpcao = Opcao.Cancelar

                            'Chama a subrotina para cancelar
                            CancelaOperacao()

                            'Chama subrotina para Incluir
                            tsbIncluir_Click(Nothing, Nothing)
                        Else
                            'Setar operação como cancelar
                            intOpcao = Opcao.Cancelar

                            'Chama a subrotina para cancelar
                            CancelaOperacao()
                        End If
                    Else
                        MessageBox.Show("Problema ao gravar dados, tente novamente mais tarde!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If

                Case Opcao.Editar 'Alterar o cliente
                    obj.AddParam("@id", obj.ID)

                    'Monto o comando de update
                    strSQL.Append("UPDATE CAD_CLIENTE SET")
                    strSQL.Append("nome = @nome,")
                    strSQL.Append("cep = @ecp,")
                    strSQL.Append("endereco = @endereco,")
                    strSQL.Append("bairro = @bairro,")
                    strSQL.Append("uf = @uf,")
                    strSQL.Append("numero = @numero,")
                    strSQL.Append("complemento = @complemento,")
                    strSQL.Append("tel1 = @tel1,")
                    strSQL.Append("tel2 = @tel2,")
                    strSQL.Append("cidade = @cidade,")
                    strSQL.Append("WHERE id = @id")

                    'Atualiza o registro
                    If obj.ExecutaQuery(strSQL.ToString) = True Then
                        If MessageBox.Show("Cliente alteraado com sucesso!" & vbNewLine & "Deseja alterar outro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                            'Setar operação como cancelar
                            intOpcao = Opcao.Cancelar

                            'Chama a subrotina para cancelar
                            CancelaOperacao()

                            'Chama subrotina para Alterar
                            tsbEditar_Click(Nothing, Nothing)
                        Else
                            'Setar operação como cancelar
                            intOpcao = Opcao.Cancelar

                            'Chama a subrotina para cancelar
                            CancelaOperacao()
                        End If
                    Else
                        MessageBox.Show("Problema ao gravar dados, tente novamente mais tarde!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
            End Select



        Catch ex As Exception
            MessageBox.Show("Ocorreu um erro:" & vbNewLine & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            obj = Nothing
        End Try
    End Sub

    Private Sub txtId_KeyDown(sender As Object, e As KeyEventArgs) Handles txtId.KeyDown
        If txtId.TextLength > 0 And e.KeyCode = Keys.Enter Then
            'Cria a classe
            Dim obj As New CAD_CLIENTE
            Dim strSQL As New Text.StringBuilder

            Try
                'Adiciono parametro
                obj.AddParam("@id", txtId.Text)

                'Monta um Select
                strSQL.Append("SELECT * FROM CAD_CLIENTE WHERE id = @id")

                'Executa
                If obj.ExecutaQueryReader(strSQL.ToString) = True Then
                    'Preenche informações do cliente
                    txtNome.Text = obj.NOME
                    txtCEP.Text = obj.CEP
                    txtEndereco.Text = obj.ENDERECO
                    txtBairro.Text = obj.BAIRRO
                    txtUF.Text = obj.UF
                    txtNumero.Text = obj.NUMERO
                    txtComplemento.Text = obj.COMPLEMENTO
                    txtTel1.Text = obj.TEL1
                    txtTel2.Text = obj.TEL2
                    txtCidade.Text = obj.CIDADE


                    If intOpcao = Opcao.Editar Then
                        txtId.Enabled = False
                        btnPesquisar.Enabled = False
                        tsbSave.Enabled = True
                        AtivaDesativa(True)

                    End If

                Else
                    MessageBox.Show("ID cliente não cadastrado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Catch ex As Exception
                MessageBox.Show("Ocorreu um erro:" & vbNewLine & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                obj = Nothing
            End Try
        ElseIf txtId.TextLength = 0 And e.KeyCode = Keys.Enter Then
            'Chama subrotina para abrir o formulario de pesquisa
            Pesq()
        End If
    End Sub

    Private Sub btnPesquisar_Click(sender As Object, e As EventArgs) Handles btnPesquisar.Click
        'Chama subrotina para abrir o formulario de pesquisa
        Pesq()
    End Sub

    Private Sub btnCorreio_Click(sender As Object, e As EventArgs) Handles btnCorreio.Click
        Try
            If txtCEP.TextLength > 0 Then
                Dim Correio As New WSCorreios.AtendeClienteClient
                Dim Resposta = Correio.consultaCEP(txtCEP.Text, "user", "senha") 'deve colocar a senha e usuario

                txtEndereco.Text = Resposta.end
                txtBairro.Text = Resposta.bairro
                txtUF.Text = Resposta.uf
                txtComplemento.Text = Resposta.complemento2
                txtCidade.Text = Resposta.cidade


            End If



        Catch ex As Exception
            MessageBox.Show("Ocorreu um erro:" & vbNewLine & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmCadCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class