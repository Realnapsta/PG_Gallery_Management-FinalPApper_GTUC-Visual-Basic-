Public Class ArtistDetails
    Private Sub Artist_TBBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Artist_TBBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Artist_TBBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PG_DatabaseDataSet)

    End Sub

    Private Sub ArtistDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PG_DatabaseDataSet.Artist_TB' table. You can move, or remove it, as needed.
        'Me.Artist_TBTableAdapter.Fill(Me.PG_DatabaseDataSet.Artist_TB)


        Dim Artist_ID As String = Me.Tag
        Try
            Me.Artist_TBTableAdapter.FillBy_ID(Me.PG_DatabaseDataSet.Artist_TB,
            CType(Artist_ID, Integer))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class