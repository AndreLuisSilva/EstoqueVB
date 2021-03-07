<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Clientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Clientes))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_codigo = New System.Windows.Forms.TextBox()
        Me.txt_nome = New System.Windows.Forms.TextBox()
        Me.txt_cpf = New System.Windows.Forms.TextBox()
        Me.txt_endereco = New System.Windows.Forms.TextBox()
        Me.txt_telefone = New System.Windows.Forms.TextBox()
        Me.btn_editar = New System.Windows.Forms.Button()
        Me.btn_deletar = New System.Windows.Forms.Button()
        Me.btn_voltar = New System.Windows.Forms.Button()
        Me.btn_salvar = New System.Windows.Forms.Button()
        Me.btn_limpar = New System.Windows.Forms.Button()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.rd_A = New System.Windows.Forms.RadioButton()
        Me.rd_B = New System.Windows.Forms.RadioButton()
        Me.rd_AB = New System.Windows.Forms.RadioButton()
        Me.rd_O = New System.Windows.Forms.RadioButton()
        Me.chk_positivo = New System.Windows.Forms.CheckBox()
        Me.chk_negativo = New System.Windows.Forms.CheckBox()
        Me.rd_outro = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(30, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(264, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "CPF"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(8, 149)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Endereço"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Control
        Me.Label4.Location = New System.Drawing.Point(20, 199)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 18)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Telefone"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.Control
        Me.Label5.Location = New System.Drawing.Point(36, 62)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 18)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Nome"
        '
        'txt_codigo
        '
        Me.txt_codigo.Location = New System.Drawing.Point(92, 25)
        Me.txt_codigo.Name = "txt_codigo"
        Me.txt_codigo.Size = New System.Drawing.Size(166, 20)
        Me.txt_codigo.TabIndex = 5
        '
        'txt_nome
        '
        Me.txt_nome.Location = New System.Drawing.Point(91, 62)
        Me.txt_nome.Name = "txt_nome"
        Me.txt_nome.Size = New System.Drawing.Size(396, 20)
        Me.txt_nome.TabIndex = 6
        '
        'txt_cpf
        '
        Me.txt_cpf.Location = New System.Drawing.Point(302, 24)
        Me.txt_cpf.Name = "txt_cpf"
        Me.txt_cpf.Size = New System.Drawing.Size(186, 20)
        Me.txt_cpf.TabIndex = 7
        '
        'txt_endereco
        '
        Me.txt_endereco.Location = New System.Drawing.Point(91, 139)
        Me.txt_endereco.Multiline = True
        Me.txt_endereco.Name = "txt_endereco"
        Me.txt_endereco.Size = New System.Drawing.Size(396, 40)
        Me.txt_endereco.TabIndex = 8
        '
        'txt_telefone
        '
        Me.txt_telefone.Location = New System.Drawing.Point(91, 199)
        Me.txt_telefone.Name = "txt_telefone"
        Me.txt_telefone.Size = New System.Drawing.Size(166, 20)
        Me.txt_telefone.TabIndex = 9
        '
        'btn_editar
        '
        Me.btn_editar.BackColor = System.Drawing.Color.Transparent
        Me.btn_editar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_editar.FlatAppearance.BorderSize = 0
        Me.btn_editar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow
        Me.btn_editar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btn_editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_editar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_editar.ForeColor = System.Drawing.Color.Yellow
        Me.btn_editar.Image = CType(resources.GetObject("btn_editar.Image"), System.Drawing.Image)
        Me.btn_editar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_editar.Location = New System.Drawing.Point(116, 291)
        Me.btn_editar.Name = "btn_editar"
        Me.btn_editar.Size = New System.Drawing.Size(75, 60)
        Me.btn_editar.TabIndex = 11
        Me.btn_editar.Text = "Editar"
        Me.btn_editar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_editar.UseVisualStyleBackColor = False
        '
        'btn_deletar
        '
        Me.btn_deletar.BackColor = System.Drawing.Color.Transparent
        Me.btn_deletar.FlatAppearance.BorderSize = 0
        Me.btn_deletar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btn_deletar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btn_deletar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_deletar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_deletar.ForeColor = System.Drawing.Color.Red
        Me.btn_deletar.Image = CType(resources.GetObject("btn_deletar.Image"), System.Drawing.Image)
        Me.btn_deletar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_deletar.Location = New System.Drawing.Point(208, 291)
        Me.btn_deletar.Name = "btn_deletar"
        Me.btn_deletar.Size = New System.Drawing.Size(75, 60)
        Me.btn_deletar.TabIndex = 12
        Me.btn_deletar.Text = "Deletar"
        Me.btn_deletar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_deletar.UseVisualStyleBackColor = False
        '
        'btn_voltar
        '
        Me.btn_voltar.BackColor = System.Drawing.Color.Transparent
        Me.btn_voltar.FlatAppearance.BorderSize = 0
        Me.btn_voltar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange
        Me.btn_voltar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btn_voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_voltar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_voltar.ForeColor = System.Drawing.Color.Orange
        Me.btn_voltar.Image = CType(resources.GetObject("btn_voltar.Image"), System.Drawing.Image)
        Me.btn_voltar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_voltar.Location = New System.Drawing.Point(399, 291)
        Me.btn_voltar.Name = "btn_voltar"
        Me.btn_voltar.Size = New System.Drawing.Size(75, 60)
        Me.btn_voltar.TabIndex = 13
        Me.btn_voltar.Text = "Voltar"
        Me.btn_voltar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_voltar.UseVisualStyleBackColor = False
        '
        'btn_salvar
        '
        Me.btn_salvar.BackColor = System.Drawing.Color.Transparent
        Me.btn_salvar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_salvar.FlatAppearance.BorderSize = 0
        Me.btn_salvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
        Me.btn_salvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btn_salvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_salvar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_salvar.ForeColor = System.Drawing.Color.Lime
        Me.btn_salvar.Image = CType(resources.GetObject("btn_salvar.Image"), System.Drawing.Image)
        Me.btn_salvar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_salvar.Location = New System.Drawing.Point(23, 291)
        Me.btn_salvar.Name = "btn_salvar"
        Me.btn_salvar.Size = New System.Drawing.Size(75, 60)
        Me.btn_salvar.TabIndex = 14
        Me.btn_salvar.Text = "Salvar"
        Me.btn_salvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_salvar.UseVisualStyleBackColor = False
        '
        'btn_limpar
        '
        Me.btn_limpar.BackColor = System.Drawing.Color.Transparent
        Me.btn_limpar.FlatAppearance.BorderSize = 0
        Me.btn_limpar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btn_limpar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btn_limpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_limpar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_limpar.ForeColor = System.Drawing.Color.White
        Me.btn_limpar.Image = CType(resources.GetObject("btn_limpar.Image"), System.Drawing.Image)
        Me.btn_limpar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_limpar.Location = New System.Drawing.Point(307, 291)
        Me.btn_limpar.Name = "btn_limpar"
        Me.btn_limpar.Size = New System.Drawing.Size(61, 60)
        Me.btn_limpar.TabIndex = 15
        Me.btn_limpar.Text = "Limpar"
        Me.btn_limpar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_limpar.UseVisualStyleBackColor = False
        '
        'txt_email
        '
        Me.txt_email.Location = New System.Drawing.Point(91, 101)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(396, 20)
        Me.txt_email.TabIndex = 17
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.Control
        Me.Label6.Location = New System.Drawing.Point(36, 101)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 18)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Email"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.Control
        Me.Label7.Location = New System.Drawing.Point(263, 199)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 18)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Sexo"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(307, 200)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(180, 21)
        Me.ComboBox1.TabIndex = 19
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.Control
        Me.Label8.Location = New System.Drawing.Point(8, 237)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(111, 18)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Tipo Sanguíneo"
        '
        'rd_A
        '
        Me.rd_A.AutoSize = True
        Me.rd_A.BackColor = System.Drawing.Color.Transparent
        Me.rd_A.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rd_A.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.rd_A.Location = New System.Drawing.Point(125, 239)
        Me.rd_A.Name = "rd_A"
        Me.rd_A.Size = New System.Drawing.Size(35, 20)
        Me.rd_A.TabIndex = 21
        Me.rd_A.TabStop = True
        Me.rd_A.Text = "A"
        Me.rd_A.UseVisualStyleBackColor = False
        '
        'rd_B
        '
        Me.rd_B.AutoSize = True
        Me.rd_B.BackColor = System.Drawing.Color.Transparent
        Me.rd_B.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rd_B.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.rd_B.Location = New System.Drawing.Point(181, 239)
        Me.rd_B.Name = "rd_B"
        Me.rd_B.Size = New System.Drawing.Size(35, 20)
        Me.rd_B.TabIndex = 22
        Me.rd_B.TabStop = True
        Me.rd_B.Text = "B"
        Me.rd_B.UseVisualStyleBackColor = False
        '
        'rd_AB
        '
        Me.rd_AB.AutoSize = True
        Me.rd_AB.BackColor = System.Drawing.Color.Transparent
        Me.rd_AB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rd_AB.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.rd_AB.Location = New System.Drawing.Point(239, 240)
        Me.rd_AB.Name = "rd_AB"
        Me.rd_AB.Size = New System.Drawing.Size(44, 20)
        Me.rd_AB.TabIndex = 23
        Me.rd_AB.TabStop = True
        Me.rd_AB.Text = "AB"
        Me.rd_AB.UseVisualStyleBackColor = False
        '
        'rd_O
        '
        Me.rd_O.AutoSize = True
        Me.rd_O.BackColor = System.Drawing.Color.Transparent
        Me.rd_O.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rd_O.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.rd_O.Location = New System.Drawing.Point(301, 240)
        Me.rd_O.Name = "rd_O"
        Me.rd_O.Size = New System.Drawing.Size(36, 20)
        Me.rd_O.TabIndex = 24
        Me.rd_O.TabStop = True
        Me.rd_O.Text = "O"
        Me.rd_O.UseVisualStyleBackColor = False
        '
        'chk_positivo
        '
        Me.chk_positivo.AutoSize = True
        Me.chk_positivo.BackColor = System.Drawing.Color.Transparent
        Me.chk_positivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_positivo.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.chk_positivo.Location = New System.Drawing.Point(418, 231)
        Me.chk_positivo.Name = "chk_positivo"
        Me.chk_positivo.Size = New System.Drawing.Size(75, 20)
        Me.chk_positivo.TabIndex = 25
        Me.chk_positivo.Text = "Positivo"
        Me.chk_positivo.UseVisualStyleBackColor = False
        '
        'chk_negativo
        '
        Me.chk_negativo.AutoSize = True
        Me.chk_negativo.BackColor = System.Drawing.Color.Transparent
        Me.chk_negativo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_negativo.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.chk_negativo.Location = New System.Drawing.Point(418, 254)
        Me.chk_negativo.Name = "chk_negativo"
        Me.chk_negativo.Size = New System.Drawing.Size(82, 20)
        Me.chk_negativo.TabIndex = 26
        Me.chk_negativo.Text = "Negativo"
        Me.chk_negativo.UseVisualStyleBackColor = False
        '
        'rd_outro
        '
        Me.rd_outro.AutoSize = True
        Me.rd_outro.BackColor = System.Drawing.Color.Transparent
        Me.rd_outro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rd_outro.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.rd_outro.Location = New System.Drawing.Point(352, 240)
        Me.rd_outro.Name = "rd_outro"
        Me.rd_outro.Size = New System.Drawing.Size(58, 20)
        Me.rd_outro.TabIndex = 27
        Me.rd_outro.TabStop = True
        Me.rd_outro.Text = "Outro"
        Me.rd_outro.UseVisualStyleBackColor = False
        '
        'Frm_Clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(510, 353)
        Me.Controls.Add(Me.rd_outro)
        Me.Controls.Add(Me.chk_negativo)
        Me.Controls.Add(Me.chk_positivo)
        Me.Controls.Add(Me.rd_O)
        Me.Controls.Add(Me.rd_AB)
        Me.Controls.Add(Me.rd_B)
        Me.Controls.Add(Me.rd_A)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txt_email)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btn_limpar)
        Me.Controls.Add(Me.btn_salvar)
        Me.Controls.Add(Me.btn_voltar)
        Me.Controls.Add(Me.btn_deletar)
        Me.Controls.Add(Me.btn_editar)
        Me.Controls.Add(Me.txt_telefone)
        Me.Controls.Add(Me.txt_endereco)
        Me.Controls.Add(Me.txt_cpf)
        Me.Controls.Add(Me.txt_nome)
        Me.Controls.Add(Me.txt_codigo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Frm_Clientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Clientes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_codigo As TextBox
    Friend WithEvents txt_nome As TextBox
    Friend WithEvents txt_cpf As TextBox
    Friend WithEvents txt_endereco As TextBox
    Friend WithEvents txt_telefone As TextBox
    Friend WithEvents btn_editar As Button
    Friend WithEvents btn_deletar As Button
    Friend WithEvents btn_voltar As Button
    Friend WithEvents btn_salvar As Button
    Friend WithEvents btn_limpar As Button
    Friend WithEvents txt_email As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents rd_A As RadioButton
    Friend WithEvents rd_B As RadioButton
    Friend WithEvents rd_AB As RadioButton
    Friend WithEvents rd_O As RadioButton
    Friend WithEvents chk_positivo As CheckBox
    Friend WithEvents chk_negativo As CheckBox
    Friend WithEvents rd_outro As RadioButton
End Class
