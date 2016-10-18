Public Class FrmListarCantidadClientes

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim obj As New ABDSisFarmcia.ClsCliente
        Data_cantidad_cliente.DataSource = obj.LISTAR_CLIENTE_CONSULTA2.Tables(0)
    End Sub
End Class