Imports System.Data.SqlClient

Public Class ArtistsForms

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
    Private Sub Collector_TBBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Artist_TBBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PG_DatabaseDataSet)

    End Sub

    Private Sub NavigateRecords()


        Artist_IDTextBox.Text = ds.Tables("Artist_TB").Rows(inc).Item(1)
        FullNameTextBox.Text = ds.Tables("Artist_TB").Rows(inc).Item(2)
        GenderTextBox.Text = ds.Tables("Artist_TB").Rows(inc).Item(3)
        PhoneNumberTextBox.Text = ds.Tables("Artist_TB").Rows(inc).Item(4)
        AddressTextBox.Text = ds.Tables("Artist_TB").Rows(inc).Item(5)
        EmailTextBox.Text = ds.Tables("Artist_TB").Rows(inc).Item(6)

        maxrows = ds.Tables("Artist_TB").Rows.Count
    End Sub

    Private Sub Artist_TBBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Artist_TBBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Artist_TBBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PG_DatabaseDataSet)

    End Sub

    Private Sub ArtistsForms_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    'Create functionalities for a user to be able to ADD new Records to the database, Delete
    'And Update Existing Records(using appropriate user interfaces).
    'Beginning of the Answers for Question 2b
    Private Sub Add_Artist_Click(sender As Object, e As EventArgs) Handles Add_Artist.Click

        Dim insertquery As String = "INSERT INTO Artist_TB(FullName, Gender, PhoneNumber, Address, Email)VALUES('" + FullNameTextBox.Text + "','" + GenderTextBox.Text + "','" + PhoneNumberTextBox.Text + "','" + AddressTextBox.Text + "','" + EmailTextBox.Text + " ')"

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

    Private Sub Update_Artist_Click(sender As Object, e As EventArgs) Handles Update_Artist.Click
        Dim cb As New SqlCommandBuilder(da)
        Try
            ds.Tables("Artist_TB").Rows(inc).Item(1) = Artist_IDTextBox.Text
            ds.Tables("Artist_TB").Rows(inc).Item(2) = FullNameTextBox.Text
            ds.Tables("Artist_TB").Rows(inc).Item(3) = GenderTextBox.Text
            ds.Tables("Artist_TB").Rows(inc).Item(4) = PhoneNumberTextBox.Text
            ds.Tables("Artist_TB").Rows(inc).Item(5) = AddressTextBox.Text
            ds.Tables("Artist_TB").Rows(inc).Item(6) = EmailTextBox.Text

            da.Update(ds, "Artist_TB")
            MsgBox("Records successfuly saved", MsgBoxStyle.OkOnly, )
        Catch exp As Exception
            MessageBox.Show(exp.ToString)
        End Try
    End Sub

    Private Sub Delete_Artist_Click(sender As Object, e As EventArgs) Handles Delete_Artist.Click
        Try
            If MessageBox.Show("Do you really want to Delete this Record?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then
                MsgBox("Operation Cancelled")
                Exit Sub
            Else
                Dim cb As New SqlCommandBuilder(da)
                ds.Tables(“Artist_TB").Rows(inc).Delete()
                maxrows = maxrows - 1
                inc = 0
                NavigateRecords()
                da.Update(ds, “Artist_TB")

            End If
        Catch exp As Exception
            MessageBox.Show(exp.ToString)
        End Try
    End Sub

    Private Sub FillBy_IDToolStripButton_Click(sender As Object, e As EventArgs) Handles FillBy_IDToolStripButton.Click
        Try
            Me.Artist_TBTableAdapter.FillBy_ID(Me.PG_DatabaseDataSet.Artist_TB, CType(Artist_IDToolStripTextBox.Text, Integer))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    'End of Answers for Question 2b in this form (Check CollectorsForm.vb form for Remaining Answers)
End Class