Imports Npgsql

Public Class Frm_Login

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        Timer1.Start()
        ProgressBar1.Show()

    End Sub

    Public Sub validaLogin()

        If txt_senha.Text = String.Empty Or txt_login.Text = String.Empty Then
            lbl_info.Text = "Campo Login ou senha vazio, por favor insira uma valor valído!"
            txt_login.Focus()
            Exit Sub
        End If

        strsql = "select * from login where usuario = "
        strsql += "'" & txt_login.Text & "' and senha = "
        strsql += "'" & txt_senha.Text & "'"
        conectar.Open()
        da = New NpgsqlDataAdapter(strsql, conectar)
        local = New DataSet
        conectar.Close()
        da.Fill(local, "login")
        resultado = local.Tables("login").Rows.Count

        If resultado > 0 Then
            linha = local.Tables("login").Rows(0)
            vnivel = linha("nivel_usuario")
            btn_login.Enabled = True
            btn_login.Focus()
        ElseIf resultado = 0 Then
            btn_login.Enabled = False
            btn_sair.Focus()
            lbl_info.Text = "Login ou senha incorretos, por favor informe algum valor valído!"
        End If

    End Sub

    Private Sub btn_sair_Click(sender As Object, e As EventArgs) Handles btn_sair.Click
        If MsgBox("Deseja sair?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            End
        Else
            Exit Sub
        End If
    End Sub

    Private Sub Frm_Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'login com o banco
        conectar = New NpgsqlConnection
        conectar.ConnectionString = caminho
    End Sub

    Private Sub txt_login_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_login.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            txt_senha.Focus()
        End If
    End Sub

    Private Sub txt_senha_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_senha.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            validaLogin()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        validaLogin()
        btn_login.Enabled = True
        ProgressBar1.Increment(5)
        If ProgressBar1.Value = ProgressBar1.Maximum Then
                Timer1.Stop()
            'MsgBox("Bem Vindo")
            Frm_Tela_Principal.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub txt_senha_KeyUp(sender As Object, e As KeyEventArgs) Handles txt_senha.KeyUp
        strsql = "select * from login where usuario = "
        strsql += "'" & txt_login.Text & "' and senha = "
        strsql += "'" & txt_senha.Text & "'"
        conectar.Open()
        da = New NpgsqlDataAdapter(strsql, conectar)
        local = New DataSet
        conectar.Close()
        da.Fill(local, "login")
        resultado = local.Tables("login").Rows.Count

        If resultado > 0 Then
            linha = local.Tables("login").Rows(0)
            vnivel = linha("nivel_usuario")
            btn_login.Enabled = True
            btn_login.Focus()
        ElseIf resultado = 0 Then
            btn_login.Enabled = False
        End If
    End Sub
End Class
