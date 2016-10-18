<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MDISisFarmacia
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CONSULTASToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LISTARCLIENTEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CONTARCLIENTEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CONSULTASToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(429, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CONSULTASToolStripMenuItem
        '
        Me.CONSULTASToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LISTARCLIENTEToolStripMenuItem, Me.CONTARCLIENTEToolStripMenuItem})
        Me.CONSULTASToolStripMenuItem.Name = "CONSULTASToolStripMenuItem"
        Me.CONSULTASToolStripMenuItem.Size = New System.Drawing.Size(84, 20)
        Me.CONSULTASToolStripMenuItem.Text = "CONSULTAS"
        '
        'LISTARCLIENTEToolStripMenuItem
        '
        Me.LISTARCLIENTEToolStripMenuItem.Name = "LISTARCLIENTEToolStripMenuItem"
        Me.LISTARCLIENTEToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.LISTARCLIENTEToolStripMenuItem.Text = "LISTAR CLIENTE"
        '
        'CONTARCLIENTEToolStripMenuItem
        '
        Me.CONTARCLIENTEToolStripMenuItem.Name = "CONTARCLIENTEToolStripMenuItem"
        Me.CONTARCLIENTEToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.CONTARCLIENTEToolStripMenuItem.Text = "CONTAR CLIENTE"
        '
        'MDISisFarmacia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(429, 293)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MDISisFarmacia"
        Me.Text = "MDISisFarmacia"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents CONSULTASToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LISTARCLIENTEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CONTARCLIENTEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
