Public Class Form1
    Dim num1, num2, result As Double
    Dim op, valor1, valor2, linha As String
    Dim indice As Integer

    Private Sub calcula()
        num1 = Val(valor1)
        num2 = Val(valor2)
        Select Case op
            Case "+"
                result = num1 + num2
            Case "-"
                result = num1 - num2
            Case "*"
                result = num1 * num2
            Case "/"
                result = num1 / num2
        End Select
        TextBox1.Text = result
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        linha = TextBox1.Text
        Dim quantidade = Len(linha)
        op = ""
        Dim contador = 0

        While op = ""
            If ((linha(contador) = "+") Or (linha(contador) = "-") Or (linha(contador) = "*") Or (linha(contador) = "/")) Then
                op = linha(contador)
                indice = contador
            Else
                valor1 = valor1 + linha(contador)
            End If
            contador = contador + 1
        End While
        indice = indice + 1
        For contador = indice To quantidade - 1
            valor2 = valor2 + linha(contador)
        Next
        calcula()
    End Sub


    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        adicionadisplay("0")
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        adicionadisplay("1")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        adicionadisplay("2")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        adicionadisplay("3")
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        TextBox1.Text = "0"
        valor1 = ""
        valor2 = ""
        result = 0
        num1 = 0
        num2 = 0
        op = ""

    End Sub
    Private Sub adicionadisplay(ByVal valor As String)
        If TextBox1.Text = "0" Then
            TextBox1.Text = ""
        End If
        TextBox1.Text = TextBox1.Text + valor
    End Sub


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        adicionadisplay("4")
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        adicionadisplay("9")
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        adicionadisplay(".")
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        adicionadisplay("-")
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        adicionadisplay("/")
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        adicionadisplay("*")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        adicionadisplay("5")
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        adicionadisplay("6")
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        adicionadisplay("+")
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        adicionadisplay("7")
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        adicionadisplay("8")
    End Sub
End Class
