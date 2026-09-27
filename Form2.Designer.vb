<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        DataGridView1 = New DataGridView()
        Nama = New DataGridViewTextBoxColumn()
        NIM = New DataGridViewTextBoxColumn()
        Ujian = New DataGridViewTextBoxColumn()
        Hadir = New DataGridViewTextBoxColumn()
        Tugas = New DataGridViewTextBoxColumn()
        Kuis = New DataGridViewTextBoxColumn()
        NilaiAkhir = New DataGridViewTextBoxColumn()
        Status = New DataGridViewTextBoxColumn()
        Label1 = New Label()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Nama, NIM, Ujian, Hadir, Tugas, Kuis, NilaiAkhir, Status})
        DataGridView1.Location = New Point(0, 205)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(800, 244)
        DataGridView1.TabIndex = 0
        ' 
        ' Nama
        ' 
        Nama.HeaderText = "Nama Mahasiswa"
        Nama.MinimumWidth = 6
        Nama.Name = "Nama"
        Nama.Width = 125
        ' 
        ' NIM
        ' 
        NIM.HeaderText = "NIM"
        NIM.MinimumWidth = 6
        NIM.Name = "NIM"
        NIM.Width = 125
        ' 
        ' Ujian
        ' 
        Ujian.HeaderText = "Nilai Ujian"
        Ujian.MinimumWidth = 6
        Ujian.Name = "Ujian"
        Ujian.Width = 125
        ' 
        ' Hadir
        ' 
        Hadir.HeaderText = "Nilai Kehadiran"
        Hadir.MinimumWidth = 6
        Hadir.Name = "Hadir"
        Hadir.Width = 125
        ' 
        ' Tugas
        ' 
        Tugas.HeaderText = "Nilai Tugas"
        Tugas.MinimumWidth = 6
        Tugas.Name = "Tugas"
        Tugas.Width = 125
        ' 
        ' Kuis
        ' 
        Kuis.HeaderText = "Nilai Kuis"
        Kuis.MinimumWidth = 6
        Kuis.Name = "Kuis"
        Kuis.Width = 125
        ' 
        ' NilaiAkhir
        ' 
        NilaiAkhir.HeaderText = "Nilai Akhir"
        NilaiAkhir.MinimumWidth = 6
        NilaiAkhir.Name = "NilaiAkhir"
        NilaiAkhir.Width = 125
        ' 
        ' Status
        ' 
        Status.HeaderText = "Status"
        Status.MinimumWidth = 6
        Status.Name = "Status"
        Status.Width = 125
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(294, 105)
        Label1.Name = "Label1"
        Label1.Size = New Size(192, 20)
        Label1.TabIndex = 1
        Label1.Text = "Status Kelulusan Mahasiswa"
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(800, 450)
        Controls.Add(Label1)
        Controls.Add(DataGridView1)
        Name = "Form2"
        Text = "Form2"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Nama As DataGridViewTextBoxColumn
    Friend WithEvents NIM As DataGridViewTextBoxColumn
    Friend WithEvents Ujian As DataGridViewTextBoxColumn
    Friend WithEvents Hadir As DataGridViewTextBoxColumn
    Friend WithEvents Tugas As DataGridViewTextBoxColumn
    Friend WithEvents Kuis As DataGridViewTextBoxColumn
    Friend WithEvents NilaiAkhir As DataGridViewTextBoxColumn
    Friend WithEvents Status As DataGridViewTextBoxColumn
End Class
