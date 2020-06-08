Public Class ArtistsDetails
    Private Sub Artist_TBBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Artist_TBBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Artist_TBBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PG_DatabaseDataSet)

    End Sub

    Private Sub ArtistsDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Artist_ID As String = Me.Tag
        Try
            Me.Artist_TBTableAdapter.FillBy_Artist_ID(Me.PG_DatabaseDataSet.Artist_TB,
CType(Artist_ID, Integer))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class