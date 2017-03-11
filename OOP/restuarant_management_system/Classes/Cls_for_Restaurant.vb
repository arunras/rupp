Public Class Cls_for_Restaurant

End Class

Public Class ClsPerson
    Dim _id As Integer
    Dim _name As String
    Dim _sex As String

    Dim _address As String
    Dim _email As String
    Dim _phone As String
    Public Property Email() As String
        Get
            Return _email
        End Get
        Set(ByVal value As String)
            _email = value
        End Set
    End Property
    Public Property ID() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property
    Public Property Name() As String
        Get
            Return _name
        End Get
        Set(ByVal value As String)
            _name = value
        End Set
    End Property
    Public Property Gender() As String
        Get
            Return _sex
        End Get
        Set(ByVal value As String)
            _sex = value
        End Set
    End Property
   
    Public Property Address() As String
        Get
            Return _address
        End Get
        Set(ByVal value As String)
            _address = value
        End Set
    End Property
    Public Property Phone() As String
        Get
            Return _phone
        End Get
        Set(ByVal value As String)
            _phone = value
        End Set
    End Property
End Class

Public Class clsEmployee
    Inherits ClsPerson
    Dim _birthdate As Date
    Dim _start_work_date As Date
    Dim _stop_work_date As Date
    Dim _position As String
    Public Property Birthdate() As Date
        Get
            Return _birthdate
        End Get
        Set(ByVal value As Date)
            _birthdate = value
        End Set
    End Property
    Public Property Position() As String
        Get
            Return _position
        End Get
        Set(ByVal value As String)
            _position = value
        End Set
    End Property

    Public Property StartWorkDate() As Date
        Get
            Return _start_work_date

        End Get
        Set(ByVal value As Date)
            _start_work_date = value
        End Set
    End Property
    Public Property StopWorkDate() As Date
        Get
            Return _stop_work_date
        End Get
        Set(ByVal value As Date)
            _stop_work_date = value
        End Set
    End Property

End Class

Public Class clsSupplier
    Inherits ClsPerson
    Dim _company As String
    Public Property Company() As String
        Get
            Return _company
        End Get
        Set(ByVal value As String)
            _company = value
        End Set
    End Property
End Class