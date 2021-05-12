Public Class Form1
    Private dtInicial As Date
    Private calc As TimeSpan

    Private Sub BTN_INICIAR_Click(sender As Object, e As EventArgs) Handles BTN_INICIAR.Click
        dtInicial = Now.AddMinutes(Convert.ToInt32(TXT_TEMPO.Text))
        tmTempo.Enabled = True
    End Sub

    Private Sub tmTempo_Tick(sender As Object, e As EventArgs) Handles tmTempo.Tick
        calc = dtInicial - Now
        lbl_tempo.Text = Format(Convert.ToDateTime(calc.Duration.ToString), "mm:ss")
    End Sub

    Private Sub lbl_tempo_Click(sender As Object, e As EventArgs) Handles lbl_tempo.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        limpar()
        calc = dtInicial - dtInicial
        lbl_tempo.Text = Format(Convert.ToDateTime(calc.Duration.ToString), "mm:ss")

    End Sub
End Class
