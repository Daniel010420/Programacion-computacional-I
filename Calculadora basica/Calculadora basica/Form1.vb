Public Class Form1
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        'Dim es una palabra reservada para declarar una variable
        Dim num1, num2 As Double 'Declaro las variables en linea separadas por comas del mismo tipo

        If txtnum1.Text = "" Then
            MsgBox("Por favor llene el primer campo")
        Else num1 = txtnum1.Text
        End If

        If txtnum2.Text = "" Then
            MsgBox("Por favor llene el segundo campo")
        Else num2 = txtnum2.Text
        End If





        If optSuma.Checked Then 'If -> si de condicion
            lblrespuesta.Text = num1 + num2 'realizamos la suma
        End If

        If optResta.Checked Then
            lblrespuesta.Text = num1 - num2 'realizamos la resta
        End If

        If optMultiplicar.Checked Then
            lblrespuesta.Text = num1 * num2 'realizamos la multiplicacion
        End If

        If optDividir.Checked Then
            lblrespuesta.Text = num1 / num2 'realizamos la division
        End If


        If optPorcentaje.Checked Then
            lblrespuesta.Text = num1 * num2 / 100
        End If

        If optPotencia.Checked Then
            lblrespuesta.Text = num1 ^ num2
        End If


        If optResiduo.Checked Then
            lblrespuesta.Text = num1 Mod num2
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        txtnum1.Text = ""
        txtnum2.Text = ""
        lblrespuesta.Text = "?"
    End Sub
End Class
