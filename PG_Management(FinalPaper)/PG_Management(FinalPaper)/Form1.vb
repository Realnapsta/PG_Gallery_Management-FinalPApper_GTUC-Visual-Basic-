
Imports System.Data.SqlClient
Imports System.Data
Public Class Form1

    Dim myconnection As New SqlClient.SqlConnection
    Dim ds As New DataSet
    Dim da As New SqlDataAdapter
    Dim sql As String
    Dim conString As String
    Dim inc As Integer
    Dim maxrows As Integer
    Dim dsNewRow As DataRow
    Dim cmd As SqlCommand

    'Connection String hardcoded into the App
    Dim connectionString As String = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=PG_Database;Integrated Security=True"
    'End of Connection String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Function GetDrivedclass() As Integer

        Dim DerivedObject As New Art_Inheritance
        Return 2
    End Function


    '    In the Click Event of a button that lies on Form1, create an instance of the Class created
    'in (a). (Question 1d, 1e and 1f)
    'it will be in your own interest to change the variables declared such as NewArt
    Private Sub Object_Instance_Click(sender As Object, e As EventArgs) Handles Object_Instance.Click

        Dim NewArt As New Arts 'this line of code is the answer to Question 1d

        'the five lines of code below is the ans to question 1e
        NewArt.Return_Type = Art_Type_TextBox.Text
        NewArt.GetLength = Art_Length_TextBox.Text
        NewArt.GetWidth = Art_Width_TextBox.Text
        NewArt.GetDescription = Art_Description_TextBox.Text

        NewArt.CalculateAge(Art_DateCommisioned.Value) 'if you changed the name if the method in Question 1c, then u must replace the "CalculateAge" with the name u chose

        'The Code below id the Answer for Question 1f
        'you change the variable "NewArt" remember to change them here as well
        MsgBox(NewArt.Return_Type & "," & NewArt.GetLength & "," & NewArt.GetWidth & "," & NewArt.GetDescription & "," & NewArt.CalculateAge(Art_DateCommisioned.Value))
    End Sub
    'End of Question 1d
    Private Sub AddArtist_Click(sender As Object, e As EventArgs) Handles AddArtist.Click


        Dim insertquery As String = "INSERT INTO Artist_TB(FullName, Gender, PhoneNumber, Address, Email)VALUES('" + Artist_FullName_TextBox.Text + "','" + Artist_Gender_TextBox.Text + "','" + Artist_PhoneNumber_TextBox.Text + "','" + Artist_Address_TextBox.Text + "','" + Artist_Email_TextBox.Text + " ')"

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

    Private Sub Add_Collector_Click(sender As Object, e As EventArgs) Handles Add_Collector.Click

        Dim insertquery As String = "INSERT INTO Collector_TB(FullName, Location, Email, Phone)VALUES('" + Collector_FullName_TextBox.Text + "','" + Collector_Location_TextBox.Text + "','" + Collector_Email_TextBox.Text + "','" + Collector_PhoneNumber_TextBox.Text + " ')"

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

    Private Sub Add_Art_Click(sender As Object, e As EventArgs) Handles Add_Art.Click
        Dim insertquery As String = "INSERT INTO Art_TB(Type, Length, Width, Description, DateOfCommisioning)VALUES('" + Art_Type_TextBox.Text + "','" + Art_Length_TextBox.Text + "','" + Art_Width_TextBox.Text + "','" + Art_Description_TextBox.Text + "','" + Art_DateCommisioned.Value + " ')"

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
End Class
