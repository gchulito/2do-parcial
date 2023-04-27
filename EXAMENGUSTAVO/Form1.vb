Public Class Form1



    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Public Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim VALOR1 As Integer
        Dim VALOR2 As Integer



        Dim SUMAMATERIAP As Integer
        VALOR1 = TextBox2.Text
        VALOR2 = TextBox4.Text
        SUMAMATERIAP = VALOR1 + VALOR2

        Label9.Text = SUMAMATERIAP & " PESOS MX "
        Label14.Text = TextBox1.Text & ", " & TextBox3.Text

        Dim VALOR3 As Integer
        Dim VALOR4 As Integer
        Dim VALOR5 As Integer
        Dim VALOR6 As Integer


        Dim SUMAMO As Integer
        VALOR3 = TextBox5.Text
        VALOR4 = TextBox6.Text
        VALOR5 = TextBox7.Text
        VALOR6 = TextBox8.Text
        SUMAMO = VALOR3 + VALOR4 + VALOR5 + VALOR6


        Label10.Text = SUMAMO & " PESOS MX "

        Dim VALOR7 As Integer
        Dim VALOR8 As Integer
        Dim VALOR9 As Integer
        Dim VALOR10 As Integer


        Dim SUMACIF As Integer
        VALOR3 = TextBox9.Text
        VALOR4 = TextBox10.Text
        VALOR5 = TextBox11.Text
        VALOR6 = TextBox12.Text
        SUMACIF = VALOR7 + VALOR8 + VALOR9 + VALOR10


        Label11.Text = SUMAMO & " PESOS MX "

        Dim TOTAL As Integer

        TOTAL = SUMACIF + SUMAMATERIAP + SUMAMO

        Label24.Text = TOTAL & " PESOS MX "


        Dim COSTOU As Integer
        Dim PIEZAS As Integer

        PIEZAS = TextBox13.Text

        COSTOU = TOTAL / PIEZAS

        Label26.Text = COSTOU & " PESOS MX "
        Label30.Text = COSTOU + (COSTOU * 0.6) & " PESOS MX "

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub Label15_Click(sender As Object, e As EventArgs) Handles Label15.Click

    End Sub

    Private Sub Label19_Click(sender As Object, e As EventArgs) Handles Label19.Click

    End Sub

    Private Sub Label25_Click(sender As Object, e As EventArgs) Handles Label25.Click

    End Sub

    Private Sub Label29_Click(sender As Object, e As EventArgs) Handles Label29.Click

    End Sub
End Class
