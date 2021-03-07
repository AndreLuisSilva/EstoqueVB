Public Class Frm_Tela_Principal
    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click
        Frm_Clientes.ShowDialog()
        Dispose()
    End Sub
End Class