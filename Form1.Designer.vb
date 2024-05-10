<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.mnu1 = New System.Windows.Forms.MenuStrip()
        Me.DadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CarregarDadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OperaçõesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CortarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopiarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ColarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelecionarTudoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LimparTudoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DragDropToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lsb2 = New System.Windows.Forms.ListBox()
        Me.lsb1 = New System.Windows.Forms.ListBox()
        Me.btnCarregaXML = New System.Windows.Forms.Button()
        Me.txtMsg = New System.Windows.Forms.TextBox()
        Me.mnu1.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnu1
        '
        Me.mnu1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DadosToolStripMenuItem, Me.OperaçõesToolStripMenuItem})
        Me.mnu1.Location = New System.Drawing.Point(0, 0)
        Me.mnu1.Name = "mnu1"
        Me.mnu1.Size = New System.Drawing.Size(1454, 24)
        Me.mnu1.TabIndex = 1
        Me.mnu1.Text = "mnu1"
        '
        'DadosToolStripMenuItem
        '
        Me.DadosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CarregarDadosToolStripMenuItem})
        Me.DadosToolStripMenuItem.Name = "DadosToolStripMenuItem"
        Me.DadosToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.DadosToolStripMenuItem.Text = "Dados"
        '
        'CarregarDadosToolStripMenuItem
        '
        Me.CarregarDadosToolStripMenuItem.Name = "CarregarDadosToolStripMenuItem"
        Me.CarregarDadosToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.CarregarDadosToolStripMenuItem.Text = "Carregar Dados"
        '
        'OperaçõesToolStripMenuItem
        '
        Me.OperaçõesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CortarToolStripMenuItem, Me.CopiarToolStripMenuItem, Me.ColarToolStripMenuItem, Me.SelecionarTudoToolStripMenuItem, Me.LimparTudoToolStripMenuItem, Me.DragDropToolStripMenuItem})
        Me.OperaçõesToolStripMenuItem.Name = "OperaçõesToolStripMenuItem"
        Me.OperaçõesToolStripMenuItem.Size = New System.Drawing.Size(75, 20)
        Me.OperaçõesToolStripMenuItem.Text = "Operações"
        '
        'CortarToolStripMenuItem

        '
        Me.CortarToolStripMenuItem.Name = "CortarToolStripMenuItem"
        Me.CortarToolStripMenuItem.ShortcutKeyDisplayString = "CTRL+X"
        Me.CortarToolStripMenuItem.Size = New System.Drawing.Size(210, 22)
        Me.CortarToolStripMenuItem.Text = "Cortar"
        Me.CortarToolStripMenuItem.ToolTipText = "Cortar Texto"
        '
        'CopiarToolStripMenuItem
        '
        Me.CopiarToolStripMenuItem.Name = "CopiarToolStripMenuItem"
        Me.CopiarToolStripMenuItem.ShortcutKeyDisplayString = "CTRL+C"
        Me.CopiarToolStripMenuItem.Size = New System.Drawing.Size(210, 22)
        Me.CopiarToolStripMenuItem.Text = "Copiar"
        '
        'ColarToolStripMenuItem
        '
        Me.ColarToolStripMenuItem.Name = "ColarToolStripMenuItem"
        Me.ColarToolStripMenuItem.ShortcutKeyDisplayString = "CTRL+V"
        Me.ColarToolStripMenuItem.Size = New System.Drawing.Size(210, 22)
        Me.ColarToolStripMenuItem.Text = "Colar"
        '
        'SelecionarTudoToolStripMenuItem
        '
        Me.SelecionarTudoToolStripMenuItem.Name = "SelecionarTudoToolStripMenuItem"
        Me.SelecionarTudoToolStripMenuItem.ShortcutKeyDisplayString = "CTRL+A"
        Me.SelecionarTudoToolStripMenuItem.Size = New System.Drawing.Size(210, 22)
        Me.SelecionarTudoToolStripMenuItem.Text = "Selecionar Tudo"
        '
        'LimparTudoToolStripMenuItem
        '
        Me.LimparTudoToolStripMenuItem.Name = "LimparTudoToolStripMenuItem"
        Me.LimparTudoToolStripMenuItem.ShortcutKeyDisplayString = "CTRL+DEL"
        Me.LimparTudoToolStripMenuItem.Size = New System.Drawing.Size(210, 22)
        Me.LimparTudoToolStripMenuItem.Text = "Limpar Tudo"
        '
        'DragDropToolStripMenuItem
        '
        Me.DragDropToolStripMenuItem.Name = "DragDropToolStripMenuItem"
        Me.DragDropToolStripMenuItem.Size = New System.Drawing.Size(210, 22)
        Me.DragDropToolStripMenuItem.Text = "Drag-and-Drop"
        '
        'lsb2
        '
        Me.lsb2.AllowDrop = True
        Me.lsb2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lsb2.FormattingEnabled = True
        Me.lsb2.ItemHeight = 20
        Me.lsb2.Location = New System.Drawing.Point(735, 44)
        Me.lsb2.Name = "lsb2"
        Me.lsb2.Size = New System.Drawing.Size(663, 304)
        Me.lsb2.TabIndex = 7
        '
        'lsb1
        '
        Me.lsb1.AllowDrop = True
        Me.lsb1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lsb1.ForeColor = System.Drawing.Color.Blue
        Me.lsb1.FormattingEnabled = True
        Me.lsb1.ItemHeight = 20
        Me.lsb1.Location = New System.Drawing.Point(52, 44)
        Me.lsb1.Name = "lsb1"
        Me.lsb1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lsb1.Size = New System.Drawing.Size(663, 304)
        Me.lsb1.TabIndex = 6
        '
        'btnCarregaXML
        '
        Me.btnCarregaXML.Location = New System.Drawing.Point(1323, 362)
        Me.btnCarregaXML.Name = "btnCarregaXML"
        Me.btnCarregaXML.Size = New System.Drawing.Size(75, 23)
        Me.btnCarregaXML.TabIndex = 9
        Me.btnCarregaXML.Text = "Gerar txt"
        Me.btnCarregaXML.UseVisualStyleBackColor = True
        '
        'txtMsg
        '
        Me.txtMsg.Location = New System.Drawing.Point(52, 365)
        Me.txtMsg.Name = "txtMsg"
        Me.txtMsg.Size = New System.Drawing.Size(663, 20)
        Me.txtMsg.TabIndex = 10
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1454, 450)
        Me.Controls.Add(Me.txtMsg)
        Me.Controls.Add(Me.btnCarregaXML)
        Me.Controls.Add(Me.lsb2)
        Me.Controls.Add(Me.lsb1)
        Me.Controls.Add(Me.mnu1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.mnu1.ResumeLayout(False)
        Me.mnu1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mnu1 As MenuStrip
    Friend WithEvents DadosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CarregarDadosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OperaçõesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CortarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopiarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ColarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SelecionarTudoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LimparTudoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DragDropToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lsb2 As ListBox
    Friend WithEvents lsb1 As ListBox
    Friend WithEvents btnCarregaXML As Button
    Protected WithEvents txtMsg As TextBox
End Class
