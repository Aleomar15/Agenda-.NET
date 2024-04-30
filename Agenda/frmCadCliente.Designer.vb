<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCadCliente
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCadCliente))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtCidade = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtUF = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtTel2 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.txtComplemento = New System.Windows.Forms.TextBox()
        Me.txtTel1 = New System.Windows.Forms.TextBox()
        Me.txtBairro = New System.Windows.Forms.TextBox()
        Me.txtEndereco = New System.Windows.Forms.TextBox()
        Me.txtCEP = New System.Windows.Forms.TextBox()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCorreio = New System.Windows.Forms.Button()
        Me.btnPesquisar = New System.Windows.Forms.Button()
        Me.tsbIncluir = New System.Windows.Forms.ToolStripButton()
        Me.tsbPesquisar = New System.Windows.Forms.ToolStripButton()
        Me.tsbEditar = New System.Windows.Forms.ToolStripButton()
        Me.tsbSave = New System.Windows.Forms.ToolStripButton()
        Me.tsbRemover = New System.Windows.Forms.ToolStripButton()
        Me.tsbCancelar = New System.Windows.Forms.ToolStripButton()
        Me.tsbExit = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbIncluir, Me.tsbPesquisar, Me.tsbEditar, Me.ToolStripSeparator1, Me.tsbSave, Me.tsbRemover, Me.tsbCancelar, Me.ToolStripSeparator2, Me.tsbExit})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(800, 31)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 31)
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 31)
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 458)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 13, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(800, 26)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(531, 20)
        Me.ToolStripStatusLabel1.Text = "[F2] - Incluir | [F3] - Cocelarnsiltar | [F4] - Editar | [F5] - Gravar | [ESC] - " &
    "Cancelar"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtCidade)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.btnCorreio)
        Me.GroupBox1.Controls.Add(Me.txtUF)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.btnPesquisar)
        Me.GroupBox1.Controls.Add(Me.txtTel2)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtNumero)
        Me.GroupBox1.Controls.Add(Me.txtComplemento)
        Me.GroupBox1.Controls.Add(Me.txtTel1)
        Me.GroupBox1.Controls.Add(Me.txtBairro)
        Me.GroupBox1.Controls.Add(Me.txtEndereco)
        Me.GroupBox1.Controls.Add(Me.txtCEP)
        Me.GroupBox1.Controls.Add(Me.txtNome)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtId)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 39)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(775, 393)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'txtCidade
        '
        Me.txtCidade.Enabled = False
        Me.txtCidade.Location = New System.Drawing.Point(92, 182)
        Me.txtCidade.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtCidade.Name = "txtCidade"
        Me.txtCidade.Size = New System.Drawing.Size(677, 22)
        Me.txtCidade.TabIndex = 13
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(21, 185)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(51, 16)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "Cidade"
        '
        'txtUF
        '
        Me.txtUF.Enabled = False
        Me.txtUF.Location = New System.Drawing.Point(92, 214)
        Me.txtUF.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtUF.Name = "txtUF"
        Me.txtUF.Size = New System.Drawing.Size(100, 22)
        Me.txtUF.TabIndex = 15
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(51, 220)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(25, 16)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "UF"
        '
        'txtTel2
        '
        Me.txtTel2.Enabled = False
        Me.txtTel2.Location = New System.Drawing.Point(92, 340)
        Me.txtTel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtTel2.Name = "txtTel2"
        Me.txtTel2.Size = New System.Drawing.Size(100, 22)
        Me.txtTel2.TabIndex = 23
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(21, 344)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(71, 16)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Telefone 2"
        '
        'txtNumero
        '
        Me.txtNumero.Enabled = False
        Me.txtNumero.Location = New System.Drawing.Point(92, 248)
        Me.txtNumero.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(100, 22)
        Me.txtNumero.TabIndex = 17
        '
        'txtComplemento
        '
        Me.txtComplemento.Enabled = False
        Me.txtComplemento.Location = New System.Drawing.Point(92, 280)
        Me.txtComplemento.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtComplemento.Name = "txtComplemento"
        Me.txtComplemento.Size = New System.Drawing.Size(677, 22)
        Me.txtComplemento.TabIndex = 19
        '
        'txtTel1
        '
        Me.txtTel1.Enabled = False
        Me.txtTel1.Location = New System.Drawing.Point(92, 309)
        Me.txtTel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtTel1.Name = "txtTel1"
        Me.txtTel1.Size = New System.Drawing.Size(100, 22)
        Me.txtTel1.TabIndex = 21
        '
        'txtBairro
        '
        Me.txtBairro.Enabled = False
        Me.txtBairro.Location = New System.Drawing.Point(92, 156)
        Me.txtBairro.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtBairro.Name = "txtBairro"
        Me.txtBairro.Size = New System.Drawing.Size(677, 22)
        Me.txtBairro.TabIndex = 11
        '
        'txtEndereco
        '
        Me.txtEndereco.Enabled = False
        Me.txtEndereco.Location = New System.Drawing.Point(92, 128)
        Me.txtEndereco.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtEndereco.Name = "txtEndereco"
        Me.txtEndereco.Size = New System.Drawing.Size(677, 22)
        Me.txtEndereco.TabIndex = 9
        '
        'txtCEP
        '
        Me.txtCEP.Enabled = False
        Me.txtCEP.Location = New System.Drawing.Point(92, 100)
        Me.txtCEP.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtCEP.Name = "txtCEP"
        Me.txtCEP.Size = New System.Drawing.Size(100, 22)
        Me.txtCEP.TabIndex = 6
        '
        'txtNome
        '
        Me.txtNome.Enabled = False
        Me.txtNome.Location = New System.Drawing.Point(92, 71)
        Me.txtNome.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(677, 22)
        Me.txtNome.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(21, 312)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 16)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Telefone 1"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(-3, 284)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(91, 16)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Complemento"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(21, 255)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 16)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Numero"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(21, 159)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 16)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Bairro"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(21, 130)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 16)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Endereço"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "CEP"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nome"
        '
        'txtId
        '
        Me.txtId.Enabled = False
        Me.txtId.Location = New System.Drawing.Point(92, 43)
        Me.txtId.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(100, 22)
        Me.txtId.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Id"
        '
        'btnCorreio
        '
        Me.btnCorreio.Enabled = False
        Me.btnCorreio.Image = Global.Agenda.My.Resources.Resources._2931184_normal_regular_zoom_glass_magnifier_icon1
        Me.btnCorreio.Location = New System.Drawing.Point(197, 98)
        Me.btnCorreio.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCorreio.Name = "btnCorreio"
        Me.btnCorreio.Size = New System.Drawing.Size(32, 25)
        Me.btnCorreio.TabIndex = 7
        Me.btnCorreio.UseVisualStyleBackColor = True
        '
        'btnPesquisar
        '
        Me.btnPesquisar.Enabled = False
        Me.btnPesquisar.Image = Global.Agenda.My.Resources.Resources._2931184_normal_regular_zoom_glass_magnifier_icon1
        Me.btnPesquisar.Location = New System.Drawing.Point(197, 43)
        Me.btnPesquisar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnPesquisar.Name = "btnPesquisar"
        Me.btnPesquisar.Size = New System.Drawing.Size(32, 23)
        Me.btnPesquisar.TabIndex = 2
        Me.btnPesquisar.UseVisualStyleBackColor = True
        '
        'tsbIncluir
        '
        Me.tsbIncluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbIncluir.Image = Global.Agenda.My.Resources.Resources._2931155_add_attach_create_maximize_new_icon
        Me.tsbIncluir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbIncluir.Name = "tsbIncluir"
        Me.tsbIncluir.Size = New System.Drawing.Size(29, 28)
        Me.tsbIncluir.Text = "Incluir"
        '
        'tsbPesquisar
        '
        Me.tsbPesquisar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbPesquisar.Image = Global.Agenda.My.Resources.Resources._2931184_normal_regular_zoom_glass_magnifier_icon
        Me.tsbPesquisar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbPesquisar.Name = "tsbPesquisar"
        Me.tsbPesquisar.Size = New System.Drawing.Size(29, 28)
        Me.tsbPesquisar.Text = "Pesquisar"
        '
        'tsbEditar
        '
        Me.tsbEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbEditar.Image = Global.Agenda.My.Resources.Resources._2931178_change_edit_pencil_creative_design_icon
        Me.tsbEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbEditar.Name = "tsbEditar"
        Me.tsbEditar.Size = New System.Drawing.Size(29, 28)
        Me.tsbEditar.Text = "Editar"
        '
        'tsbSave
        '
        Me.tsbSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbSave.Enabled = False
        Me.tsbSave.Image = Global.Agenda.My.Resources.Resources.SaveIcon
        Me.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbSave.Name = "tsbSave"
        Me.tsbSave.Size = New System.Drawing.Size(29, 28)
        Me.tsbSave.Text = "Salvar"
        '
        'tsbRemover
        '
        Me.tsbRemover.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbRemover.Enabled = False
        Me.tsbRemover.Image = Global.Agenda.My.Resources.Resources._2931168_bin_delete_remove_trash_garbage_icon
        Me.tsbRemover.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbRemover.Name = "tsbRemover"
        Me.tsbRemover.Size = New System.Drawing.Size(29, 28)
        Me.tsbRemover.Text = "Remover"
        '
        'tsbCancelar
        '
        Me.tsbCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbCancelar.Enabled = False
        Me.tsbCancelar.Image = Global.Agenda.My.Resources.Resources._2931151_close_delete_exit_remove_x_icon
        Me.tsbCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbCancelar.Name = "tsbCancelar"
        Me.tsbCancelar.Size = New System.Drawing.Size(29, 28)
        Me.tsbCancelar.Text = "Cancelar"
        '
        'tsbExit
        '
        Me.tsbExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbExit.Image = Global.Agenda.My.Resources.Resources._2931187_door_enter_exit_in_leave_icon
        Me.tsbExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbExit.Name = "tsbExit"
        Me.tsbExit.Size = New System.Drawing.Size(29, 28)
        Me.tsbExit.Text = "Sair"
        '
        'frmCadCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 484)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.Name = "frmCadCliente"
        Me.Text = "Cadastro Cliente"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents tsbIncluir As ToolStripButton
    Friend WithEvents tsbPesquisar As ToolStripButton
    Friend WithEvents tsbEditar As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents tsbSave As ToolStripButton
    Friend WithEvents tsbCancelar As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents tsbExit As ToolStripButton
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtId As TextBox
    Friend WithEvents txtNumero As TextBox
    Friend WithEvents txtComplemento As TextBox
    Friend WithEvents txtTel1 As TextBox
    Friend WithEvents txtBairro As TextBox
    Friend WithEvents txtEndereco As TextBox
    Friend WithEvents txtCEP As TextBox
    Friend WithEvents txtNome As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtTel2 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents btnPesquisar As Button
    Friend WithEvents txtUF As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents btnCorreio As Button
    Friend WithEvents txtCidade As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents tsbRemover As ToolStripButton
End Class
