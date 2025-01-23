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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        dtp = New DateTimePicker()
        TextBox4 = New TextBox()
        TextBox5 = New TextBox()
        TextBox6 = New TextBox()
        TextBox7 = New TextBox()
        btsimpan = New Button()
        btupdate = New Button()
        btdelete = New Button()
        btexit = New Button()
        dg = New DataGridView()
        btpasien = New Button()
        btdokter = New Button()
        CType(dg, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(36, 36)
        Label1.Name = "Label1"
        Label1.Size = New Size(63, 15)
        Label1.TabIndex = 0
        Label1.Text = "No Periksa"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(36, 71)
        Label2.Name = "Label2"
        Label2.Size = New Size(88, 15)
        Label2.TabIndex = 1
        Label2.Text = "Tanggal Periksa"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(36, 106)
        Label3.Name = "Label3"
        Label3.Size = New Size(60, 15)
        Label3.TabIndex = 2
        Label3.Text = "No Pasien"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(36, 141)
        Label4.Name = "Label4"
        Label4.Size = New Size(76, 15)
        Label4.TabIndex = 3
        Label4.Text = "Nama Pasien"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(398, 141)
        Label5.Name = "Label5"
        Label5.Size = New Size(35, 15)
        Label5.TabIndex = 7
        Label5.Text = "Biaya"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(398, 106)
        Label6.Name = "Label6"
        Label6.Size = New Size(51, 15)
        Label6.TabIndex = 6
        Label6.Text = "Spesialis"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(398, 71)
        Label7.Name = "Label7"
        Label7.Size = New Size(77, 15)
        Label7.TabIndex = 5
        Label7.Text = "Nama Dokter"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(398, 36)
        Label8.Name = "Label8"
        Label8.Size = New Size(61, 15)
        Label8.TabIndex = 4
        Label8.Text = "No Dokter"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(152, 33)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(105, 23)
        TextBox1.TabIndex = 8
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(152, 103)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(105, 23)
        TextBox2.TabIndex = 9
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(152, 138)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(200, 23)
        TextBox3.TabIndex = 10
        ' 
        ' dtp
        ' 
        dtp.Location = New Point(152, 68)
        dtp.Name = "dtp"
        dtp.Size = New Size(200, 23)
        dtp.TabIndex = 11
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(519, 33)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(105, 23)
        TextBox4.TabIndex = 12
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(519, 68)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(200, 23)
        TextBox5.TabIndex = 13
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(519, 103)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(105, 23)
        TextBox6.TabIndex = 14
        ' 
        ' TextBox7
        ' 
        TextBox7.Location = New Point(519, 138)
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(105, 23)
        TextBox7.TabIndex = 15
        ' 
        ' btsimpan
        ' 
        btsimpan.Location = New Point(121, 188)
        btsimpan.Name = "btsimpan"
        btsimpan.Size = New Size(100, 31)
        btsimpan.TabIndex = 16
        btsimpan.Text = "SAVE"
        btsimpan.UseVisualStyleBackColor = True
        ' 
        ' btupdate
        ' 
        btupdate.Location = New Point(263, 188)
        btupdate.Name = "btupdate"
        btupdate.Size = New Size(100, 31)
        btupdate.TabIndex = 17
        btupdate.Text = "UPDATE"
        btupdate.UseVisualStyleBackColor = True
        ' 
        ' btdelete
        ' 
        btdelete.Location = New Point(407, 188)
        btdelete.Name = "btdelete"
        btdelete.Size = New Size(100, 31)
        btdelete.TabIndex = 18
        btdelete.Text = "DELETE"
        btdelete.UseVisualStyleBackColor = True
        ' 
        ' btexit
        ' 
        btexit.Location = New Point(551, 188)
        btexit.Name = "btexit"
        btexit.Size = New Size(100, 31)
        btexit.TabIndex = 19
        btexit.Text = "EXIT"
        btexit.UseVisualStyleBackColor = True
        ' 
        ' dg
        ' 
        dg.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dg.Location = New Point(36, 237)
        dg.Name = "dg"
        dg.Size = New Size(683, 250)
        dg.TabIndex = 20
        ' 
        ' btpasien
        ' 
        btpasien.Location = New Point(263, 103)
        btpasien.Name = "btpasien"
        btpasien.Size = New Size(47, 23)
        btpasien.TabIndex = 21
        btpasien.Text = "Find"
        btpasien.UseVisualStyleBackColor = True
        ' 
        ' btdokter
        ' 
        btdokter.Location = New Point(630, 32)
        btdokter.Name = "btdokter"
        btdokter.Size = New Size(47, 23)
        btdokter.TabIndex = 22
        btdokter.Text = "Find"
        btdokter.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(760, 499)
        Controls.Add(btdokter)
        Controls.Add(btpasien)
        Controls.Add(dg)
        Controls.Add(btexit)
        Controls.Add(btdelete)
        Controls.Add(btupdate)
        Controls.Add(btsimpan)
        Controls.Add(TextBox7)
        Controls.Add(TextBox6)
        Controls.Add(TextBox5)
        Controls.Add(TextBox4)
        Controls.Add(dtp)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label5)
        Controls.Add(Label6)
        Controls.Add(Label7)
        Controls.Add(Label8)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Pengobatan"
        CType(dg, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents dtp As DateTimePicker
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents btsimpan As Button
    Friend WithEvents btupdate As Button
    Friend WithEvents btdelete As Button
    Friend WithEvents btexit As Button
    Friend WithEvents dg As DataGridView
    Friend WithEvents btpasien As Button
    Friend WithEvents btdokter As Button

End Class
