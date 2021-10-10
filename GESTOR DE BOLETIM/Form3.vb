Public Class Form3


    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        If Len(TextBox4.Text) = 2 Or Len(TextBox4.Text) = 2 Then
            TextBox4.Text = TextBox4.Text & " X "
            TextBox4.SelectionStart = Len(TextBox4.Text) + 1
        End If
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        If ComboBox2.Text = "EXTERNO" Then
            'CAPAFORM.CB8.Value = "PET METALIZADO"
            ComboBox6.Text = "MONO"
            TextBox8.Text = "0,5"


        Else
            'CAPAFORM.CB9.Text() = "N/A"
            ComboBox6.Text = "N/A"
            TextBox8.Text = "N/A"
            ComboBox16.Text = "     N/A"
        End If
    End Sub
    Private Sub GroupBox1_DoubleClick(sender As Object, e As EventArgs) Handles GroupBox1.DoubleClick
        GroupBox1.Height = 15
        GroupBox1.Width = 134
        GroupBox1.Left = 798

    End Sub
    Private Sub GroupBox1_Click(sender As Object, e As EventArgs) Handles GroupBox1.Click
        GroupBox1.Height = 203
        GroupBox1.Width = 932
        GroupBox1.Left = 3
    End Sub
    Private Sub GroupBox2_DoubleClick(sender As Object, e As EventArgs) Handles GroupBox2.DoubleClick
        GroupBox2.Height = 20
        GroupBox2.Width = 146
        GroupBox2.Left = 798

    End Sub
    Private Sub GroupBox2_Click(sender As Object, e As EventArgs) Handles GroupBox2.Click
        GroupBox2.Height = 203
        GroupBox2.Width = 932
        GroupBox2.Left = 3
    End Sub
    Private Sub GroupBox3_DoubleClick(sender As Object, e As EventArgs) Handles GroupBox3.DoubleClick
        GroupBox3.Height = 20
        GroupBox3.Width = 146
        GroupBox3.Left = 798

    End Sub
    Private Sub GroupBox3_Click(sender As Object, e As EventArgs) Handles GroupBox3.Click
        GroupBox3.Height = 203
        GroupBox3.Width = 932
        GroupBox3.Left = 3
    End Sub
    Private Sub GroupBox4_DoubleClick(sender As Object, e As EventArgs) Handles GroupBox4.DoubleClick
        GroupBox4.Height = 20
        GroupBox4.Width = 146
        GroupBox4.Left = 798

    End Sub
    Private Sub GroupBox4_Click(sender As Object, e As EventArgs) Handles GroupBox4.Click
        Dim Senha, resposta As Integer
        If GroupBox4.Left = "798" Then
            Senha = "12"

            resposta = InputBox("Digite a senha para continuar?")
            'If resposta = InputBox() = "" Then 'Cancel button messasge
            '    MsgBox("Closing application")
            '    Exit Sub
            'End If
            'If resposta = Senha Then
            '    GroupBox4.Height = 203
            '    GroupBox4.Width = 932
            '    GroupBox4.Left = 3

            'Else

            '    MsgBox("Usuario Não tem Acesso a Edição de Dados !", vbCritical, "ACESSO")

            '    Exit Sub 'não continuar a macro

            'End If

        End If
    End Sub







    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        If Label1.Text = "Maximizar" Then
            Label1.Top = 10
            ListView2.Top = 117
            ListView2.Height = 126
            System.Threading.Thread.Sleep(100)

            Label1.Top = 5
            ListView2.Top = 55
            ListView2.Height = 198
            System.Threading.Thread.Sleep(100)

            Label1.Top = 3
            ListView2.Top = 20
            ListView2.Height = 253
            Label1.Text = "Minimizar"
            Label1.BackColor = Color.LightGreen
            Button1.Visible = False
        Else


            ListView2.Top = 100
            ListView2.Height = 160

            System.Threading.Thread.Sleep(100)

            ListView2.Top = 155
            ListView2.Height = 115

            System.Threading.Thread.Sleep(100)
            Label1.Top = 235
            ListView2.Top = 251
            ListView2.Height = 21
            Label1.BackColor = Color.DarkSalmon
            Label1.Text = "Maximizar"
            Button1.Visible = True
        End If
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        If Label2.Text = "Maximizar" Then
            Label2.Top = 10
            ListView3.Top = 117
            ListView3.Height = 126
            System.Threading.Thread.Sleep(100)

            Label2.Top = 5
            ListView3.Top = 55
            ListView3.Height = 198
            System.Threading.Thread.Sleep(100)

            Label2.Top = 3
            ListView3.Top = 20
            ListView3.Height = 253
            Label2.Text = "Minimizar"
            Label2.BackColor = Color.LightGreen
            Button3.Visible = False
        Else


            ListView3.Top = 100
            ListView3.Height = 160

            System.Threading.Thread.Sleep(100)

            ListView3.Top = 155
            ListView3.Height = 115

            System.Threading.Thread.Sleep(100)
            Label2.Top = 235
            ListView3.Top = 251
            ListView3.Height = 21
            Label2.BackColor = Color.DarkSalmon
            Label2.Text = "Maximizar"
            Button3.Visible = True
        End If
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        If Label3.Text = "Maximizar" Then
            Label3.Top = 10
            ListView4.Top = 117
            ListView4.Height = 126
            System.Threading.Thread.Sleep(100)

            Label3.Top = 5
            ListView4.Top = 55
            ListView4.Height = 198
            System.Threading.Thread.Sleep(100)

            Label3.Top = 3
            ListView4.Top = 20
            ListView4.Height = 253
            Label3.Text = "Minimizar"
            Label3.BackColor = Color.LightGreen
            Button3.Visible = False
        Else


            ListView4.Top = 100
            ListView4.Height = 160

            System.Threading.Thread.Sleep(100)

            ListView4.Top = 155
            ListView4.Height = 115

            System.Threading.Thread.Sleep(100)
            Label3.Top = 235
            ListView4.Top = 251
            ListView4.Height = 21
            Label3.BackColor = Color.DarkSalmon
            Label3.Text = "Maximizar"
            Button3.Visible = True
        End If
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        If Label4.Text = "Maximizar" Then
            Label4.Top = 10
            ListView5.Top = 117
            ListView5.Height = 126
            System.Threading.Thread.Sleep(100)

            Label4.Top = 5
            ListView5.Top = 55
            ListView5.Height = 198
            System.Threading.Thread.Sleep(100)

            Label4.Top = 3
            ListView5.Top = 20
            ListView5.Height = 253
            Label4.Text = "Minimizar"
            Label4.BackColor = Color.LightGreen
            Button3.Visible = False
        Else


            ListView5.Top = 100
            ListView5.Height = 160

            System.Threading.Thread.Sleep(100)

            ListView5.Top = 155
            ListView5.Height = 115

            System.Threading.Thread.Sleep(100)
            Label4.Top = 235
            ListView5.Top = 251
            ListView5.Height = 21
            Label4.BackColor = Color.DarkSalmon
            Label4.Text = "Maximizar"
            Button3.Visible = True
        End If
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        MsgBox("Usuario Não tem Acesso a Edição de Dados !", vbInformation, "EDIÇÃO REFILE")
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        MsgBox("Usuario Não tem Acesso a Edição de Dados !", vbInformation, "EDIÇÃO CORTE E SOLDA")
    End Sub

    Private Sub TextBox42_TextChanged(sender As Object, e As EventArgs) Handles TextBox42.TextChanged
        If Len(TextBox42.Text) = 1 Or Len(TextBox42.Text) = 1 Then
            TextBox42.Text = TextBox42.Text & "."
            TextBox42.SelectionStart = Len(TextBox42.Text) + 1
        End If
    End Sub

    Private Sub TextBox41_TextChanged(sender As Object, e As EventArgs) Handles TextBox41.TextChanged
        If Len(TextBox41.Text) = 1 Or Len(TextBox41.Text) = 1 Then
            TextBox41.Text = TextBox41.Text & "."
            TextBox41.SelectionStart = Len(TextBox41.Text) + 1
        End If
    End Sub


    Private Sub ComboBox17_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox17.SelectedIndexChanged
        If ComboBox17.SelectedIndex = 1 Then
            TabPage2.BackColor = Color.DarkSeaGreen
            TextBox22.BackColor = Color.DarkSeaGreen
        ElseIf ComboBox17.SelectedIndex = 2 Then
            TabPage2.BackColor = Color.Khaki
            TextBox22.BackColor = Color.Khaki
        Else
            TabPage2.BackColor = Color.PowderBlue
            TextBox22.BackColor = Color.PowderBlue
        End If
    End Sub

    Private Sub ComboBox19_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox19.SelectedIndexChanged
        If ComboBox19.SelectedIndex = 1 Then
            TabPage3.BackColor = Color.DarkSeaGreen
            TextBox34.BackColor = Color.DarkSeaGreen
        Else
            TabPage3.BackColor = Color.PowderBlue
            TextBox34.BackColor = Color.PowderBlue
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim data As String
        data = DateAndTime.Now
        lbldata.Text = data
    End Sub
End Class