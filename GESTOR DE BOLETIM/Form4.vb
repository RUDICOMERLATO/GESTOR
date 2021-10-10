Imports System.Data.OleDb

Public Class form4
    Private Sub btsalvar_Click(sender As Object, e As EventArgs) Handles btsalvar.Click
        If validarform() Then
            salvarusuario()

        End If
    End Sub

    Private Function validarform() As Boolean
        Dim result As Boolean
        If txtnome.Text = "" Then
            MsgBox("informe o nome de login do Usuário.", vbExclamation, sistema)
            txtnome.Focus()
            result = False
        ElseIf txtsenha.Text = "" Then
            MsgBox("informe o senha de login do Usuário.", vbExclamation, sistema)
            txtsenha.Focus()
            result = False
        ElseIf txtacess.Text = "" Then
            MsgBox("informe tipo de acesso.", vbExclamation, sistema)
            txtacess.Focus()
            result = False
        Else
            result = True
        End If
        Return result
    End Function
    Private Sub salvarusuario()


        Dim sql = ""
        If CLng(0 & lblid.Text) = 0 Then
            sql = "INSERT INTO usuarios (NOME, SENHA, ACESSO) VALUES (@NOME, @SENHA, @ACESSO)"
        Else
            sql = ("UPDATE usuarios SET NOME=@NOME, SENHA=@SENHA, ACESSO=@ACESSO ")

        End If

        Using cn = New OleDbConnection(conn)
            cn.Open()
            Using cmd = New OleDbCommand(sql, cn)
                'cmd.Parameters.AddWithValue("@código", lblid.Text)
                cmd.Parameters.AddWithValue("@NOME", txtnome.Text)
                cmd.Parameters.AddWithValue("@SENHA", txtsenha.Text)
                cmd.Parameters.AddWithValue("@ACESSO", txtacess.Text)
                MsgBox("falha: ", vbExclamation, sistema)
                cmd.ExecuteNonQuery()
            End Using
        End Using




    End Sub
End Class