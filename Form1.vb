Public Class Form1
    Private Function HitungNilaiAkhir() As Integer
        Dim valUjian, valHadir, valTugas, valKuis As Integer

        Integer.TryParse(TextBox3.Text, valUjian)
        Integer.TryParse(TextBox4.Text, valHadir)
        Integer.TryParse(TextBox5.Text, valTugas)
        Integer.TryParse(TextBox6.Text, valKuis)

        Return (valUjian + valHadir + valTugas + valKuis) / 4
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If String.IsNullOrWhiteSpace(TextBox1.Text) OrElse String.IsNullOrWhiteSpace(TextBox2.Text) Then
            MessageBox.Show("Minimal Nama Sama NIM Diisi Lah !", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim nilaiAkhir As Integer = HitungNilaiAkhir()
        Dim status As String = If(nilaiAkhir >= 60, "LULUS", "TIDAK LULUS")

        If Form2.IsDisposed OrElse Form2 Is Nothing Then
            Form2 = New Form2()
        End If

        Form2.TambahData(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text, TextBox6.Text, nilaiAkhir, status)
        Form2.Show()

        ResetForm()
    End Sub

    Private Sub ResetForm()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox1.Focus()
    End Sub

End Class
