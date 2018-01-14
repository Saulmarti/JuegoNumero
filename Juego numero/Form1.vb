Public Class Form1
    Dim randomValue As Integer
    Dim numero As Integer
    Dim contador As Integer



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonNumero.Click

        randomValue = Int(1 + Rnd() * 100)
        ButtonNumero.Enabled = False

        contador = 0

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox_TextChanged(sender As Object, e As EventArgs) Handles TextBoxNumero.TextChanged

    End Sub

    Private Sub TextBox1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBoxNumero.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                Calculo()
                contador = contador + 1
        End Select
    End Sub

    Private Sub Calculo()

        numero = TextBoxNumero.Text

        If (numero = randomValue) Then
            ListBoxNumero.Items.Add("Numero correcto: " + numero.ToString)
            ListBoxNumero.Items.Add("Numero de intentos: " + contador.ToString)
        ElseIf (numero > randomValue) Then
            ListBoxNumero.Items.Add("El numero es menor de " + numero.ToString)
        ElseIf (numero < randomValue) Then
            ListBoxNumero.Items.Add("El numero es mayor de " + numero.ToString)
        End If

        TextBoxNumero.Text = ""
    End Sub

    Private Sub Limpiar_Click(sender As Object, e As EventArgs) Handles Limpiar.Click
        TextBoxNumero.Text = ""
        ListBoxNumero.Items.Clear()
        ButtonNumero.Enabled = True
    End Sub

    Private Sub Salir_Click(sender As Object, e As EventArgs) Handles Salir.Click
        Application.Exit()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize()
    End Sub

End Class
