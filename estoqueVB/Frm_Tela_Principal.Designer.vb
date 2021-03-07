<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Tela_Principal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Tela_Principal))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.cmd_cadastro = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FaturasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuáriosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmd_consulta = New System.Windows.Forms.ToolStripMenuItem()
        Me.GeralToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EspecifícaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmd_relatorios = New System.Windows.Forms.ToolStripMenuItem()
        Me.GeralToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RelatórioEspecToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmd_ajuda = New System.Windows.Forms.ToolStripMenuItem()
        Me.SairToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackgroundImage = CType(resources.GetObject("MenuStrip1.BackgroundImage"), System.Drawing.Image)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmd_cadastro, Me.cmd_consulta, Me.cmd_relatorios, Me.cmd_ajuda})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'cmd_cadastro
        '
        Me.cmd_cadastro.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClientesToolStripMenuItem, Me.FaturasToolStripMenuItem, Me.RegistrosToolStripMenuItem, Me.UsuáriosToolStripMenuItem})
        Me.cmd_cadastro.Image = CType(resources.GetObject("cmd_cadastro.Image"), System.Drawing.Image)
        Me.cmd_cadastro.Name = "cmd_cadastro"
        Me.cmd_cadastro.Size = New System.Drawing.Size(82, 20)
        Me.cmd_cadastro.Text = "Cadastro"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ClientesToolStripMenuItem.Text = "Clientes"
        '
        'FaturasToolStripMenuItem
        '
        Me.FaturasToolStripMenuItem.Name = "FaturasToolStripMenuItem"
        Me.FaturasToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.FaturasToolStripMenuItem.Text = "Faturas"
        '
        'RegistrosToolStripMenuItem
        '
        Me.RegistrosToolStripMenuItem.Name = "RegistrosToolStripMenuItem"
        Me.RegistrosToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.RegistrosToolStripMenuItem.Text = "Registros"
        '
        'UsuáriosToolStripMenuItem
        '
        Me.UsuáriosToolStripMenuItem.Name = "UsuáriosToolStripMenuItem"
        Me.UsuáriosToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.UsuáriosToolStripMenuItem.Text = "Usuários"
        '
        'cmd_consulta
        '
        Me.cmd_consulta.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GeralToolStripMenuItem, Me.EspecifícaToolStripMenuItem})
        Me.cmd_consulta.Image = CType(resources.GetObject("cmd_consulta.Image"), System.Drawing.Image)
        Me.cmd_consulta.Name = "cmd_consulta"
        Me.cmd_consulta.Size = New System.Drawing.Size(82, 20)
        Me.cmd_consulta.Text = "Consulta"
        '
        'GeralToolStripMenuItem
        '
        Me.GeralToolStripMenuItem.Name = "GeralToolStripMenuItem"
        Me.GeralToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.GeralToolStripMenuItem.Text = "Consulta Geral"
        '
        'EspecifícaToolStripMenuItem
        '
        Me.EspecifícaToolStripMenuItem.Name = "EspecifícaToolStripMenuItem"
        Me.EspecifícaToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.EspecifícaToolStripMenuItem.Text = "Consulta Específica"
        '
        'cmd_relatorios
        '
        Me.cmd_relatorios.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GeralToolStripMenuItem1, Me.RelatórioEspecToolStripMenuItem})
        Me.cmd_relatorios.Image = Global.estoqueVB.My.Resources.Resources.edit
        Me.cmd_relatorios.Name = "cmd_relatorios"
        Me.cmd_relatorios.Size = New System.Drawing.Size(87, 20)
        Me.cmd_relatorios.Text = "Relatórios"
        '
        'GeralToolStripMenuItem1
        '
        Me.GeralToolStripMenuItem1.Name = "GeralToolStripMenuItem1"
        Me.GeralToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.GeralToolStripMenuItem1.Text = "Relatório Geral"
        '
        'RelatórioEspecToolStripMenuItem
        '
        Me.RelatórioEspecToolStripMenuItem.Name = "RelatórioEspecToolStripMenuItem"
        Me.RelatórioEspecToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.RelatórioEspecToolStripMenuItem.Text = "Relatório Específico"
        '
        'cmd_ajuda
        '
        Me.cmd_ajuda.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.SairToolStripMenuItem})
        Me.cmd_ajuda.Image = Global.estoqueVB.My.Resources.Resources.help
        Me.cmd_ajuda.Name = "cmd_ajuda"
        Me.cmd_ajuda.Size = New System.Drawing.Size(66, 20)
        Me.cmd_ajuda.Text = "Ajuda"
        '
        'SairToolStripMenuItem
        '
        Me.SairToolStripMenuItem.Name = "SairToolStripMenuItem"
        Me.SairToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SairToolStripMenuItem.Text = "Sair"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.ToolStripMenuItem1.Text = "Ajuda"
        '
        'Frm_Tela_Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Frm_Tela_Principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents cmd_cadastro As ToolStripMenuItem
    Friend WithEvents cmd_consulta As ToolStripMenuItem
    Friend WithEvents cmd_relatorios As ToolStripMenuItem
    Friend WithEvents cmd_ajuda As ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FaturasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegistrosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UsuáriosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GeralToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EspecifícaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GeralToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents RelatórioEspecToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SairToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
End Class
