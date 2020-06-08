Public Class CollectorDetails
    Private Sub Collector_TBBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Collector_TBBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Collector_TBBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PG_DatabaseDataSet)

    End Sub


    '    Create functionalities For a user To be able To ADD New Records To the database, Delete
    'And Update Existing Records(using appropriate user interfaces).(Question 2c)
    Private Sub CollectorDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Collector_ID As String = Me.Tag
        Try
            Me.Collector_TBTableAdapter.FillBy_Collector_ID(Me.PG_DatabaseDataSet.Collector_TB,
CType(Collector_ID, Integer))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    'End of Answer to Question 2c (Go to CollectorsForms.vb File for remaining answer)
End Class