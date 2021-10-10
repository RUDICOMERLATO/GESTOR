Imports System.Data.OleDb

Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btentrar.Click
        If Not validarUsuario() Then
            MsgBox("Usuario ou Senha inválidos .", vbExclamation, sistema)
        Else

            Form4.Show()
            Me.Close()
        End If

    End Sub

    Private Function validarUsuario() As Boolean
        Dim sql = "select* from usuarios where NOME=@NOME AND SENHA=@SENHA"
        Dim result = False

        Try
            Using cn = New OleDbConnection(conn)
                cn.Open()
                Using cmd = New OleDbCommand(sql, cn)
                    cmd.Parameters.AddWithValue("@NOME", Me.txtlogin.Text)
                    cmd.Parameters.AddWithValue("@SENHA", Me.txtsenha.Text)

                    Using dr = cmd.ExecuteReader

                        If dr.HasRows Then
                            If dr.Read() Then
                                pidusuario = dr("código")
                                pnomeusuario = dr("NOME")
                                padministrador = IIf(dr("SENHA") = "s", True, False)
                                result = True
                            End If
                        End If
                    End Using

                End Using
            End Using
        Catch ex As Exception
            MsgBox("falha: " & ex.Message, vbExclamation, sistema)

        End Try
        Return result

    End Function


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'If MessageBox.Show("Deseja mesmo sair?", My.Application.Info.Title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
        Me.Close()
        'End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
