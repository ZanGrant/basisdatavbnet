Public Class Form2
    Sub tampildata()
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "select * from pasien"
        mda.SelectCommand = perintah
        ds.Tables.Clear()
        mda.Fill(ds, "pasien")
        dgv.DataSource = ds.Tables("pasien")
        kon.Close()
    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tampildata()
    End Sub

    ' Menampilkan data Pasien Pada Form Periksa

    Public Event DataSelected(value1 As String, value2 As String)
    Private Sub dgv_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv.CellDoubleClick
        Try
            Dim i As Integer = dgv.CurrentRow.Index
            With dgv.Rows.Item(i)
                ' Raise the event to pass data back to the main form
                RaiseEvent DataSelected(.Cells(0).Value.ToString(), .Cells(1).Value.ToString())
                Me.Close() ' Close the subform after selection
            End With
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

    Sub tampiluser(ByVal sql As String)
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = sql
        mda.SelectCommand = perintah
        Dim datas As New DataSet
        mda.Fill(datas, "pasien")
        dgv.DataSource = datas.Tables("pasien")
        kon.Close()
    End Sub

    ' pencarian data pasien 
    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        tampiluser("select * from pasien where namapasien like '%" &
                   TextBox1.Text & "%' or nopasien like '%" & TextBox1.Text & "%'")
    End Sub
End Class