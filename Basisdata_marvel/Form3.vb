Public Class Form3
    Sub tampildata()
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "select * from dokter"
        mda.SelectCommand = perintah
        ds.Tables.Clear()
        mda.Fill(ds, "dokter")
        dgv.DataSource = ds.Tables("dokter")
        kon.Close()
    End Sub

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tampildata()
    End Sub

    ' Menampilkan data dokter Pada Form Periksa

    Public Event DataSelected(value1 As String, value2 As String, value3 As String)
    Private Sub dgv_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv.CellDoubleClick
        Try
            Dim i As Integer = dgv.CurrentRow.Index
            With dgv.Rows.Item(i)
                ' Raise the event to pass data back to the main form
                RaiseEvent DataSelected(.Cells(0).Value.ToString(), .Cells(1).Value.ToString(), .Cells(4).Value.ToString())
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
        mda.Fill(datas, "dokter")
        dgv.DataSource = datas.Tables("dokter")
        kon.Close()
    End Sub

    ' pencarian data dokter 
    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        tampiluser("select * from dokter where namadokter like '%" &
                   TextBox1.Text & "%' or nodokter like '%" & TextBox1.Text & "%'")
    End Sub
End Class