<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        TextBox5 = New TextBox()
        TextBox6 = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Button1 = New Button()
        Label7 = New Label()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(84, 138)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(226, 27)
        TextBox1.TabIndex = 0
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(390, 138)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(224, 27)
        TextBox2.TabIndex = 1
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(84, 202)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(226, 27)
        TextBox3.TabIndex = 2
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(390, 202)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(224, 27)
        TextBox4.TabIndex = 3
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(84, 264)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(226, 27)
        TextBox5.TabIndex = 4
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(390, 264)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(224, 27)
        TextBox6.TabIndex = 5
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(84, 115)
        Label1.Name = "Label1"
        Label1.Size = New Size(49, 20)
        Label1.TabIndex = 6
        Label1.Text = "Nama"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(390, 115)
        Label2.Name = "Label2"
        Label2.Size = New Size(37, 20)
        Label2.TabIndex = 7
        Label2.Text = "NIM"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(84, 179)
        Label3.Name = "Label3"
        Label3.Size = New Size(78, 20)
        Label3.TabIndex = 8
        Label3.Text = "Nilai Ujian"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(390, 179)
        Label4.Name = "Label4"
        Label4.Size = New Size(111, 20)
        Label4.TabIndex = 9
        Label4.Text = "Nilai Kehadiran"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(84, 241)
        Label5.Name = "Label5"
        Label5.Size = New Size(83, 20)
        Label5.TabIndex = 10
        Label5.Text = "Nilai Tugas"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(390, 241)
        Label6.Name = "Label6"
        Label6.Size = New Size(71, 20)
        Label6.TabIndex = 11
        Label6.Text = "Nilai Kuis"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(290, 342)
        Button1.Name = "Button1"
        Button1.Size = New Size(128, 29)
        Button1.TabIndex = 12
        Button1.Text = "Cek Kelulusan"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(290, 44)
        Label7.Name = "Label7"
        Label7.Size = New Size(137, 20)
        Label7.TabIndex = 13
        Label7.Text = "DATA MAHASISWA"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(736, 450)
        Controls.Add(Label7)
        Controls.Add(Button1)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(TextBox6)
        Controls.Add(TextBox5)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label7 As Label

End Class
