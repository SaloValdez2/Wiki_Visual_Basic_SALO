<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmListarCantidadClientes
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
        Me.Data_cantidad_cliente = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.Data_cantidad_cliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Data_cantidad_cliente
        '
        Me.Data_cantidad_cliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Data_cantidad_cliente.Location = New System.Drawing.Point(24, 68)
        Me.Data_cantidad_cliente.Name = "Data_cantidad_cliente"
        Me.Data_cantidad_cliente.Size = New System.Drawing.Size(398, 198)
        Me.Data_cantidad_cliente.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(335, 30)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "LISTAR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FrmListarCantidadClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(490, 318)
        Me.Controls.Add(Me.Data_cantidad_cliente)
        Me.Controls.Add(Me.Button1)
        Me.Name = "FrmListarCantidadClientes"
        Me.Text = "FrmListarCantidadClientes"
        CType(Me.Data_cantidad_cliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Data_cantidad_cliente As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
