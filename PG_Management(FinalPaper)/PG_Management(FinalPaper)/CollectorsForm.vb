Imports System.Data.SqlClient

Public Class CollectorsForm
    Dim myconnection As New SqlClient.SqlConnection
    Dim ds As New DataSet
    Dim da As New SqlDataAdapter
    Dim sql As String
    Dim conString As String
    Dim inc As Integer
    Dim maxrows As Integer
    Dim dsNewRow As DataRow
    Dim cmd As SqlCommand

    Dim connectionString As String = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=PG_Database;Integrated Security=True"
    Private Sub NavigateRecords()


        Collector_IDTextBox.Text = ds.Tables("Collector_TB").Rows(inc).Item(1)
        FullNameTextBox.Text = ds.Tables("Collector_TB").Rows(inc).Item(2)
        LocationTextBox.Text = ds.Tables("Collector_TB").Rows(inc).Item(3)
        EmailTextBox.Text = ds.Tables("Collector_TB").Rows(inc).Item(4)
        PhoneTextBox.Text = ds.Tables("Collector_TB").Rows(inc).Item(5)


        maxrows = ds.Tables("Collector_TB").Rows.Count
    End Sub
    Private Sub Collector_TBBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Collector_TBBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Collector_TBBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PG_DatabaseDataSet)

    End Sub

    Private Sub CollectorsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PG_DatabaseDataSet.Collector_TB' table. You can move, or remove it, as needed.
        Me.Collector_TBTableAdapter.Fill(Me.PG_DatabaseDataSet.Collector_TB)

    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorDeleteItem.Click

    End Sub

    'Create functionalities for a user to be able to ADD new Records to the database, Delete
    'And Update Existing Records(using appropriate user interfaces).
    'Beginning of the Answers for Question 2b
    Private Sub Add_Collector_Click(sender As Object, e As EventArgs) Handles Add_Collector.Click

        Dim insertquery As String = "INSERT INTO Collector_TB(FullName, Gender, Location, Email, PhoneNumber)VALUES('" + FullNameTextBox.Text + "','" + LocationTextBox.Text + "','" + EmailTextBox.Text + "','" + PhoneTextBox.Text + "','" + " ')"

        cmd = myconnection.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = insertquery
        myconnection.ConnectionString = connectionString
        Try
            myconnection.Open()
            cmd.ExecuteNonQuery()
            MessageBox.Show("New Record added to the Database")
            myconnection.Close()
        Catch EXP As Exception
            MessageBox.Show(EXP.ToString)
        End Try
    End Sub

    Private Sub Update_Collector_Click(sender As Object, e As EventArgs) Handles Update_Collector.Click
        Dim cb As New SqlCommandBuilder(da)
        Try
            ds.Tables("Collector_TB").Rows(inc).Item(1) = Collector_IDTextBox.Text
            ds.Tables("Collector_TB").Rows(inc).Item(2) = FullNameTextBox.Text
            ds.Tables("Collector_TB").Rows(inc).Item(3) = LocationTextBox.Text
            ds.Tables("Collector_TB").Rows(inc).Item(4) = EmailTextBox.Text
            ds.Tables("Collector_TB").Rows(inc).Item(5) = PhoneTextBox.Text

            da.Update(ds, "Collector_TB")
            MsgBox("Records successfuly saved", MsgBoxStyle.OkOnly, )
        Catch exp As Exception
            MessageBox.Show(exp.ToString)
        End Try
    End Sub

    Private Sub Delete_Collector_Click(sender As Object, e As EventArgs) Handles Delete_Collector.Click
        Try
            If MessageBox.Show("Do you really want to Delete this Record?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then
                MsgBox("Operation Cancelled")
                Exit Sub
            Else
                Dim cb As New SqlCommandBuilder(da)
                ds.Tables(“Collector_TB").Rows(inc).Delete()
                maxrows = maxrows - 1
                inc = 0
                NavigateRecords()
                da.Update(ds, “Collector_TB")

            End If
        Catch exp As Exception
            MessageBox.Show(exp.ToString)
        End Try
    End Sub
    'End of Answers for Question 2b in this form (Check ArtistsForm.vb form for Remaining Answers)




    '    Create functionalities For a user To be able To ADD New Records To the database, Delete
    'And Update Existing Records(using appropriate user interfaces).(Question 2c)
    Private Sub FillBy_IDToolStripButton_Click(sender As Object, e As EventArgs) Handles FillBy_IDToolStripButton.Click
        Try
            Me.Collector_TBTableAdapter.FillBy_ID(Me.PG_DatabaseDataSet.Collector_TB, CType(Collector_IDToolStripTextBox.Text, Integer))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
    'End of Answer to Question 2c (Go to CollectorsDetails.vb File for remaining answer)

End Class