Public Class FrmListarCliente

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim obj As New ABDSisFarmcia.ClsCliente
        DataGridView1.DataSource = obj.LISTAR_CLIENTE_CONSULTA1.tables(0)
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class
