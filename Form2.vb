Public Class Form2

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If DataGridView1.Columns.Count = 0 Then
            DataGridView1.Columns.Add("Nama", "Nama Mahasiswa")
            DataGridView1.Columns.Add("NIM", "NIM")
            DataGridView1.Columns.Add("Ujian", "Nilai Ujian")
            DataGridView1.Columns.Add("Hadir", "Nilai Kehadiran")
            DataGridView1.Columns.Add("Tugas", "Nilai Tugas")
            DataGridView1.Columns.Add("Kuis", "Nilai Kuis")
            DataGridView1.Columns.Add("NilaiAkhir", "Nilai Akhir")
            DataGridView1.Columns.Add("Status", "Status")
        End If
    End Sub

    Public Sub TambahData(nama As String, nim As Integer, ujian As Integer, hadir As Integer, tugas As Integer, kuis As Integer, nilaiAkhir As Integer, status As String)
        DataGridView1.Rows.Add(nama, nim, ujian, hadir, tugas, kuis, nilaiAkhir, status)
    End Sub


End Class