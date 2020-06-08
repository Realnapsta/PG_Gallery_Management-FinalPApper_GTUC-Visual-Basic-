Public Class Arts
    '    Create a Class For the Art In Case one And create member variables For any four(4)
    'properties. (Question 1a)
    'it will be in you own interest to 
    'change Or add some characters to the variables declared, that Is Art_ID, Type, Length,Width,Descrription And DateCommissioning
    Public Art_ID As Integer
    Public Type As String
    Public Length As Double
    Public Width As Double
    Public Description As String
    Public DateOfCommisioning As Date

    'End of Question 1a



    '    Create a Property procedure To write values into And read values from Each Of the
    'member variables created In (a) above. Be mindful To Implements all necessary
    'validations.(Question 1b)

    'it will be in you own interest to 
    'change Or add some characters to the variables declared, that Is Art_ID, Type, Length,Width,Descrription And DateCommissioning
    Public Property Return_Type() As String
        Get
            Return Type
        End Get
        Set(ByVal value As String)
            If value IsNot Nothing Then
                Type = value
            Else
                Type = ""
            End If
        End Set
    End Property

    Public Property GetLength() As Double
        Get
            Return Length
        End Get
        Set(value As Double)
            If value > 0 Then
                Length = value
            Else
                Length = 0
            End If
        End Set
    End Property

    Public Property GetWidth() As Double
        Get
            Return Width
        End Get
        Set(value As Double)
            If value > 0 Then
                Width = value
            Else
                Width = 0
            End If
        End Set
    End Property

    Public Property GetDescription() As String
        Get
            Return Description
        End Get
        Set(ByVal value As String)
            If value IsNot Nothing Then
                Description = value

            Else
                Description = ""
            End If

        End Set
    End Property
    'End of Question 1b

    '    Create a Method To calculate the Age Of the painting Using the CommissioningDate And
    'the current Date. 
    'it will be in you own interest to 
    'change Or add some characters to the Method name declared that is CalculateAge
    Public Function CalculateAge(birthday As DateTime) As Integer
        Dim todaysDate = DateTime.Today
        Dim ageCalculated = todaysDate.Year - birthday.Year
        If birthday > todaysDate.AddYears(-ageCalculated) Then
            ageCalculated = ageCalculated - 1
        End If
        Return ageCalculated
    End Function
    'End of Question 1c

End Class
