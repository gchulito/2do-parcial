Imports System.ComponentModel
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button

Public Class Form1


    Private Sub Form1(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim f As Integer
        For f = 0 To 255
            ComboBox1.Items.Add(f)
            ComboBox2.Items.Add(f)
            ComboBox3.Items.Add(f)
        Next
        ComboBox1.SelectedIndex = 0
        ComboBox2.SelectedIndex = 0
        ComboBox3.SelectedIndex = 0
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim rojo As Integer = ComboBox1.Text
        Dim verde As Integer = ComboBox2.Text
        Dim azul As Integer = ComboBox3.Text
        Label4.BackColor = Color.FromArgb(rojo, verde, azul)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Text = ""
        If CheckBox1.Checked = True Then
            Text = Text + "(pantalon)"

            PictureBox1.Image = System.Drawing.Image.FromFile("C:\Users\USUARIO\Desktop\PANTALON.png")
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage

        End If
        If CheckBox2.Checked = True Then
            Text = Text + "(palyera)"
            PictureBox1.Image = System.Drawing.Image.FromFile("C:\Users\USUARIO\Desktop\PLAYERA.png")
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        End If
        If CheckBox3.Checked = True Then
            Text = Text + "(short)"
            PictureBox1.Image = System.Drawing.Image.FromFile("C:\Users\USUARIO\Desktop\short.JPG")
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click


        If CheckBox4.Checked = True Then
            PictureBox1.ClientSize = New Size(500, 500)

        End If
        If CheckBox5.Checked = True Then
            PictureBox1.ClientSize = New Size(1000, 1000)
        End If
        If CheckBox6.Checked = True Then
            PictureBox1.ClientSize = New Size(700, 700)
        End If
    End Sub



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub CheckBox5_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox5.CheckedChanged

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub
End Class
