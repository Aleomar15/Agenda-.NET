<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsulta
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCEP = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgvDados = New System.Windows.Forms.DataGridView()
        Me.colId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNome = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCEP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEndereco = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNumero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colBairro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colUF = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colComplemento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTel1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTel2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtCEP)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtNome)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(775, 78)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtrar por:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nome:"
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(62, 31)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(437, 22)
        Me.txtNome.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(512, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "CEP:"
        '
        'txtCEP
        '
        Me.txtCEP.Location = New System.Drawing.Point(567, 31)
        Me.txtCEP.Name = "txtCEP"
        Me.txtCEP.Size = New System.Drawing.Size(100, 22)
        Me.txtCEP.TabIndex = 3
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.dgvDados)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 88)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(775, 350)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'dgvDados
        '
        Me.dgvDados.AllowUserToAddRows = False
        Me.dgvDados.AllowUserToDeleteRows = False
        Me.dgvDados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colId, Me.colNome, Me.colCEP, Me.colEndereco, Me.colNumero, Me.colBairro, Me.colUF, Me.colComplemento, Me.colTel1, Me.colTel2})
        Me.dgvDados.Location = New System.Drawing.Point(-1, 9)
        Me.dgvDados.Name = "dgvDados"
        Me.dgvDados.ReadOnly = True
        Me.dgvDados.RowHeadersWidth = 51
        Me.dgvDados.RowTemplate.Height = 24
        Me.dgvDados.Size = New System.Drawing.Size(776, 341)
        Me.dgvDados.TabIndex = 0
        '
        'colId
        '
        Me.colId.DataPropertyName = "ID"
        Me.colId.HeaderText = "Id"
        Me.colId.MinimumWidth = 6
        Me.colId.Name = "colId"
        Me.colId.ReadOnly = True
        Me.colId.Width = 125
        '
        'colNome
        '
        Me.colNome.DataPropertyName = "NOME"
        Me.colNome.HeaderText = "Nome"
        Me.colNome.MinimumWidth = 6
        Me.colNome.Name = "colNome"
        Me.colNome.ReadOnly = True
        Me.colNome.Width = 125
        '
        'colCEP
        '
        Me.colCEP.DataPropertyName = "CEP"
        Me.colCEP.HeaderText = "CEP"
        Me.colCEP.MinimumWidth = 6
        Me.colCEP.Name = "colCEP"
        Me.colCEP.ReadOnly = True
        Me.colCEP.Width = 125
        '
        'colEndereco
        '
        Me.colEndereco.DataPropertyName = "ENDERECO"
        Me.colEndereco.HeaderText = "Endereço"
        Me.colEndereco.MinimumWidth = 6
        Me.colEndereco.Name = "colEndereco"
        Me.colEndereco.ReadOnly = True
        Me.colEndereco.Width = 125
        '
        'colNumero
        '
        Me.colNumero.DataPropertyName = "NUMERO"
        Me.colNumero.HeaderText = "Numero"
        Me.colNumero.MinimumWidth = 6
        Me.colNumero.Name = "colNumero"
        Me.colNumero.ReadOnly = True
        Me.colNumero.Width = 125
        '
        'colBairro
        '
        Me.colBairro.DataPropertyName = "BAIRRO"
        Me.colBairro.HeaderText = "Bairro"
        Me.colBairro.MinimumWidth = 6
        Me.colBairro.Name = "colBairro"
        Me.colBairro.ReadOnly = True
        Me.colBairro.Width = 125
        '
        'colUF
        '
        Me.colUF.DataPropertyName = "UF"
        Me.colUF.HeaderText = "UF"
        Me.colUF.MinimumWidth = 6
        Me.colUF.Name = "colUF"
        Me.colUF.ReadOnly = True
        Me.colUF.Width = 125
        '
        'colComplemento
        '
        Me.colComplemento.DataPropertyName = "COMPLEMENTO"
        Me.colComplemento.HeaderText = "Complemento"
        Me.colComplemento.MinimumWidth = 6
        Me.colComplemento.Name = "colComplemento"
        Me.colComplemento.ReadOnly = True
        Me.colComplemento.Width = 125
        '
        'colTel1
        '
        Me.colTel1.DataPropertyName = "TEL1"
        Me.colTel1.HeaderText = "Telefone"
        Me.colTel1.MinimumWidth = 6
        Me.colTel1.Name = "colTel1"
        Me.colTel1.ReadOnly = True
        Me.colTel1.Width = 125
        '
        'colTel2
        '
        Me.colTel2.DataPropertyName = "TEL2"
        Me.colTel2.HeaderText = "Telefone2"
        Me.colTel2.MinimumWidth = 6
        Me.colTel2.Name = "colTel2"
        Me.colTel2.ReadOnly = True
        Me.colTel2.Width = 125
        '
        'frmConsulta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmConsulta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgvDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtCEP As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNome As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dgvDados As DataGridView
    Friend WithEvents colId As DataGridViewTextBoxColumn
    Friend WithEvents colNome As DataGridViewTextBoxColumn
    Friend WithEvents colCEP As DataGridViewTextBoxColumn
    Friend WithEvents colEndereco As DataGridViewTextBoxColumn
    Friend WithEvents colNumero As DataGridViewTextBoxColumn
    Friend WithEvents colBairro As DataGridViewTextBoxColumn
    Friend WithEvents colUF As DataGridViewTextBoxColumn
    Friend WithEvents colComplemento As DataGridViewTextBoxColumn
    Friend WithEvents colTel1 As DataGridViewTextBoxColumn
    Friend WithEvents colTel2 As DataGridViewTextBoxColumn
End Class
