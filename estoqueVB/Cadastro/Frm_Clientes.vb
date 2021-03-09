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
        txt_email.Text = String.Empty
    End Sub

    Private Sub txt_nome_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_nome.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            txt_email.Focus()
        End If
    End Sub

    Private Sub btn_voltar_Click(sender As Object, e As EventArgs) Handles btn_voltar.Click
        Frm_Tela_Principal.Show()
        Me.Hide()
    End Sub

    Private Sub txt_cpf_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_cpf.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            txt_nome.Focus()
        End If
    End Sub

    Private Sub txt_email_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_email.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            txt_endereco.Focus()
        End If
    End Sub

    Private Sub txt_endereco_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_endereco.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            txt_telefone.Focus()
        End If
    End Sub

    Private Sub txt_telefone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_telefone.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            cb_sexo.Focus()
        End If
    End Sub

    Private Sub cb_sexo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cb_sexo.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            rd_A.Focus()
        End If
    End Sub

    Private Sub rd_A_KeyPress(sender As Object, e As KeyPressEventArgs) Handles rd_A.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            rd_B.Focus()
        End If
    End Sub

    Private Sub rd_B_KeyPress(sender As Object, e As KeyPressEventArgs) Handles rd_B.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            rd_AB.Focus()
        End If
    End Sub

    Private Sub rd_AB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles rd_AB.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            rd_O.Focus()
        End If
    End Sub

    Private Sub rd_O_KeyPress(sender As Object, e As KeyPressEventArgs) Handles rd_O.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            rd_outro.Focus()
        End If
    End Sub

    Private Sub rd_outro_KeyPress(sender As Object, e As KeyPressEventArgs) Handles rd_outro.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            chk_positivo.Focus()
        End If
    End Sub

    Private Sub chk_positivo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles chk_positivo.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            chk_negativo.Focus()
        End If
    End Sub

    Private Sub txt_cpf_Validated(sender As Object, e As EventArgs) Handles txt_cpf.Validated
        If txt_cpf.Text = String.Empty Then
            Label9.Text = "Preencha o campo CPF"
            txt_cpf.Focus()
        End If

        strsql = "select * from clientes where cpf = "
        strsql += "'" & txt_cpf.Text & "'"
        conectar.Open()
        da = New NpgsqlDataAdapter(strsql, conectar)
        conectar.Close()
        local = New DataSet
        da.Fill(local, "clientes")
        resultado = local.Tables("clientes").Rows.Count

        If resultado > 0 Then
            linha = local.Tables("clientes").Rows(0)
            txt_nome.Text = linha("nome")
            txt_email.Text = linha("email")
            txt_endereco.Text = linha("endereco")
            txt_nome.Text = linha("nome")
            txt_telefone.Text = linha("telefone")

        End If

    End Sub
End Class