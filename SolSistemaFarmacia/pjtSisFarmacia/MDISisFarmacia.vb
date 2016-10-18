Public Class MDISisFarmacia

    Private Sub LISTARCLIENTEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LISTARCLIENTEToolStripMenuItem.Click

        FrmListarCliente.ShowDialog()
       
    End Sub

    Private Sub CONTARCLIENTEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CONTARCLIENTEToolStripMenuItem.Click
        FrmListarCantidadClientes.ShowDialog()
    End Sub
End Class