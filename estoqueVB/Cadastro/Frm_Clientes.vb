Imports Npgsql

Public Class Frm_Clientes
    Private Sub Frm_Clientes_Load(sender As Object, e As EventArgs) Handles Me.Load
        conectar = New NpgsqlConnection
        conectar.ConnectionString = caminho
    End Sub

    Private Sub btn_limpar_Click(sender As Object, e As EventArgs) Handles btn_limpar.Click
        txt_codigo.Text = String.Empty
        txt_cpf.Text = String.Empty
        txt_endereco.Text = String.Empty
        txt_nome.Text = String.Empty
        txt_telefone.Text = String.Empty
    End Sub

    Private Sub txt_nome_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_nome.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            txt_email.Focus()
        End If
    End Sub
End Class