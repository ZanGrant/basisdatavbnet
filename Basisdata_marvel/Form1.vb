Public Class Form1

    Sub tampildata()
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "select * from periksa"
        mda.SelectCommand = perintah
        ds.Tables.Clear()
        mda.Fill(ds, "periksa")
        dg.DataSource = ds.Tables("periksa")
        kon.Close()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tampildata()
    End Sub

    ' tombol simpan 
    Private Sub btsimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btsimpan.Click
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "insert into periksa values('" & TextBox1.Text &
            "','" & Format(dtp.Value, "yyyy-MM-dd") & "','" & TextBox2.Text & "','" &
            TextBox4.Text & "','" & TextBox7.Text & "')"
        perintah.ExecuteNonQuery()
        kon.Close()
        tampildata()
    End Sub

    ' tombol update
    Private Sub btupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btupdate.Click
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "UPDATE periksa SET tglperiksa='" &
            Format(dtp.Value, "yyyy-MM-dd") & "',nopasien='" & TextBox2.Text & "',nodokter='" &
            TextBox4.Text & "',biaya='" & TextBox7.Text & "' WHERE noperiksa='" &
            TextBox1.Text & "'"
        perintah.ExecuteNonQuery()
        kon.Close()
        tampildata()
        MsgBox("Data Berhasil Disimpan...", MsgBoxStyle.Information, "Konfirmasi")
    End Sub

    ' tombol delete
    Private Sub btdelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btdelete.Click
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "delete from periksa where noperiksa='" &
            TextBox1.Text & "'"
        perintah.ExecuteNonQuery()
        kon.Close()
        MsgBox("Data Terpilih Sudah Terhapus", MsgBoxStyle.Information, "Pesan")
        tampildata()
    End Sub


    ' Menampilkan data pada textbox untuk editing
    Private Sub dg_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dg.CellContentClick
        TextBox1.Enabled = False
        Try
            Dim i As Integer
            i = dg.CurrentRow.Index
            With dg.Rows.Item(i)
                btsimpan.Enabled = False
                btdelete.Enabled = True
                TextBox1.Text = .Cells(0).Value
                dtp.Text = .Cells(1).Value
                TextBox2.Text = .Cells(2).Value
                TextBox3.Text = .Cells(3).Value
                TextBox4.Text = .Cells(4).Value
                TextBox5.Text = .Cells(5).Value
                TextBox6.Text = .Cells(6).Value
                TextBox7.Text = .Cells(7).Value
            End With
        Catch ex As Exception
        End Try
    End Sub

    ' tombol ke subform pencarian data (pasien)
    Private pasienFormInstance As Form2

    Private Sub OpenPasienForm()
        ' Memastikan form pasien sudah terbuka
        If pasienFormInstance Is Nothing OrElse pasienFormInstance.IsDisposed Then
            pasienFormInstance = New Form2()
            pasienFormInstance.Show()
        Else
            pasienFormInstance.BringToFront() ' Membawa form yang sudah ada ke depan
        End If

        AddHandler pasienFormInstance.DataSelected, AddressOf DataPasienSelected
    End Sub

    Private Sub DataPasienSelected(value1 As String, value2 As String)
        TextBox2.Text = value1
        TextBox3.Text = value2
    End Sub

    Private Sub btpasien_Click(sender As Object, e As EventArgs) Handles btpasien.Click
        OpenPasienForm()
    End Sub

    ' tombol ke subform pencarian data (dokter)
    Private dokterFormInstance As Form3

    Private Sub OpenDokterForm()
        ' Memastikan form dokter sudah terbuka
        If dokterFormInstance Is Nothing OrElse dokterFormInstance.IsDisposed Then
            dokterFormInstance = New Form3()
            dokterFormInstance.Show()
        Else
            dokterFormInstance.BringToFront() ' Membawa form yang sudah ada ke depan
        End If

        AddHandler dokterFormInstance.DataSelected, AddressOf DataDokterSelected
    End Sub

    Private Sub DataDokterSelected(value1 As String, value2 As String, value3 As String)
        TextBox4.Text = value1
        TextBox5.Text = value2
        TextBox6.Text = value3
    End Sub

    Private Sub btdokter_Click(sender As Object, e As EventArgs) Handles btdokter.Click
        OpenDokterForm()
    End Sub

End Class
