﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.Linq
Imports System.Data.Linq.Mapping
Imports System.Linq
Imports System.Linq.Expressions
Imports System.Reflection


<Global.System.Data.Linq.Mapping.DatabaseAttribute(Name:="Library")>  _
Partial Public Class LibraryDataContext
	Inherits System.Data.Linq.DataContext
	
	Private Shared mappingSource As System.Data.Linq.Mapping.MappingSource = New AttributeMappingSource()
	
  #Region "Extensibility Method Definitions"
  Partial Private Sub OnCreated()
  End Sub
  Partial Private Sub InsertBook(instance As Book)
    End Sub
  Partial Private Sub UpdateBook(instance As Book)
    End Sub
  Partial Private Sub DeleteBook(instance As Book)
    End Sub
  Partial Private Sub InsertBorrow(instance As Borrow)
    End Sub
  Partial Private Sub UpdateBorrow(instance As Borrow)
    End Sub
  Partial Private Sub DeleteBorrow(instance As Borrow)
    End Sub
  Partial Private Sub InsertUser(instance As User)
    End Sub
  Partial Private Sub UpdateUser(instance As User)
    End Sub
  Partial Private Sub DeleteUser(instance As User)
    End Sub
  #End Region
	
	Public Sub New()
		MyBase.New(Global.LibrarySystem.My.MySettings.Default.LibraryConnectionString, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As String)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As System.Data.IDbConnection)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As String, ByVal mappingSource As System.Data.Linq.Mapping.MappingSource)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As System.Data.IDbConnection, ByVal mappingSource As System.Data.Linq.Mapping.MappingSource)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public ReadOnly Property Books() As System.Data.Linq.Table(Of Book)
		Get
			Return Me.GetTable(Of Book)
		End Get
	End Property
	
	Public ReadOnly Property Borrows() As System.Data.Linq.Table(Of Borrow)
		Get
			Return Me.GetTable(Of Borrow)
		End Get
	End Property
	
	Public ReadOnly Property Users() As System.Data.Linq.Table(Of User)
		Get
			Return Me.GetTable(Of User)
		End Get
	End Property
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.Book")>  _
Partial Public Class Book
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _ISBN As String
	
	Private _bookName As String
	
	Private _bookDesc As String
	
	Private _author As String
	
	Private _type As String
	
	Private _Borrows As EntitySet(Of Borrow)
	
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnISBNChanging(value As String)
    End Sub
    Partial Private Sub OnISBNChanged()
    End Sub
    Partial Private Sub OnbookNameChanging(value As String)
    End Sub
    Partial Private Sub OnbookNameChanged()
    End Sub
    Partial Private Sub OnbookDescChanging(value As String)
    End Sub
    Partial Private Sub OnbookDescChanged()
    End Sub
    Partial Private Sub OnauthorChanging(value As String)
    End Sub
    Partial Private Sub OnauthorChanged()
    End Sub
    Partial Private Sub OntypeChanging(value As String)
    End Sub
    Partial Private Sub OntypeChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		Me._Borrows = New EntitySet(Of Borrow)(AddressOf Me.attach_Borrows, AddressOf Me.detach_Borrows)
		OnCreated
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ISBN", DbType:="VarChar(20) NOT NULL", CanBeNull:=false, IsPrimaryKey:=true)>  _
	Public Property ISBN() As String
		Get
			Return Me._ISBN
		End Get
		Set
			If (String.Equals(Me._ISBN, value) = false) Then
				Me.OnISBNChanging(value)
				Me.SendPropertyChanging
				Me._ISBN = value
				Me.SendPropertyChanged("ISBN")
				Me.OnISBNChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_bookName", DbType:="VarChar(50) NOT NULL", CanBeNull:=false)>  _
	Public Property bookName() As String
		Get
			Return Me._bookName
		End Get
		Set
			If (String.Equals(Me._bookName, value) = false) Then
				Me.OnbookNameChanging(value)
				Me.SendPropertyChanging
				Me._bookName = value
				Me.SendPropertyChanged("bookName")
				Me.OnbookNameChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_bookDesc", DbType:="VarChar(100)")>  _
	Public Property bookDesc() As String
		Get
			Return Me._bookDesc
		End Get
		Set
			If (String.Equals(Me._bookDesc, value) = false) Then
				Me.OnbookDescChanging(value)
				Me.SendPropertyChanging
				Me._bookDesc = value
				Me.SendPropertyChanged("bookDesc")
				Me.OnbookDescChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_author", DbType:="VarChar(50)")>  _
	Public Property author() As String
		Get
			Return Me._author
		End Get
		Set
			If (String.Equals(Me._author, value) = false) Then
				Me.OnauthorChanging(value)
				Me.SendPropertyChanging
				Me._author = value
				Me.SendPropertyChanged("author")
				Me.OnauthorChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_type", DbType:="VarChar(50)")>  _
	Public Property type() As String
		Get
			Return Me._type
		End Get
		Set
			If (String.Equals(Me._type, value) = false) Then
				Me.OntypeChanging(value)
				Me.SendPropertyChanging
				Me._type = value
				Me.SendPropertyChanged("type")
				Me.OntypeChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.AssociationAttribute(Name:="Book_Borrow", Storage:="_Borrows", ThisKey:="ISBN", OtherKey:="ISBN")>  _
	Public Property Borrows() As EntitySet(Of Borrow)
		Get
			Return Me._Borrows
		End Get
		Set
			Me._Borrows.Assign(value)
		End Set
	End Property
	
	Public Event PropertyChanging As PropertyChangingEventHandler Implements System.ComponentModel.INotifyPropertyChanging.PropertyChanging
	
	Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
	
	Protected Overridable Sub SendPropertyChanging()
		If ((Me.PropertyChangingEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
		End If
	End Sub
	
	Protected Overridable Sub SendPropertyChanged(ByVal propertyName As [String])
		If ((Me.PropertyChangedEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End If
	End Sub
	
	Private Sub attach_Borrows(ByVal entity As Borrow)
		Me.SendPropertyChanging
		entity.Book = Me
	End Sub
	
	Private Sub detach_Borrows(ByVal entity As Borrow)
		Me.SendPropertyChanging
		entity.Book = Nothing
	End Sub
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.Borrow")>  _
Partial Public Class Borrow
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _borrowID As Integer
	
	Private _UserID As String
	
	Private _ISBN As String
	
	Private _borrowDate As System.Nullable(Of Date)
	
	Private _returnDate As System.Nullable(Of Date)
	
	Private _status As String
	
	Private _Book As EntityRef(Of Book)
	
	Private _User As EntityRef(Of User)
	
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnborrowIDChanging(value As Integer)
    End Sub
    Partial Private Sub OnborrowIDChanged()
    End Sub
    Partial Private Sub OnUserIDChanging(value As String)
    End Sub
    Partial Private Sub OnUserIDChanged()
    End Sub
    Partial Private Sub OnISBNChanging(value As String)
    End Sub
    Partial Private Sub OnISBNChanged()
    End Sub
    Partial Private Sub OnborrowDateChanging(value As System.Nullable(Of Date))
    End Sub
    Partial Private Sub OnborrowDateChanged()
    End Sub
    Partial Private Sub OnreturnDateChanging(value As System.Nullable(Of Date))
    End Sub
    Partial Private Sub OnreturnDateChanged()
    End Sub
    Partial Private Sub OnstatusChanging(value As String)
    End Sub
    Partial Private Sub OnstatusChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		Me._Book = CType(Nothing, EntityRef(Of Book))
		Me._User = CType(Nothing, EntityRef(Of User))
		OnCreated
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_borrowID", AutoSync:=AutoSync.OnInsert, DbType:="Int NOT NULL IDENTITY", IsPrimaryKey:=true, IsDbGenerated:=true)>  _
	Public Property borrowID() As Integer
		Get
			Return Me._borrowID
		End Get
		Set
			If ((Me._borrowID = value)  _
						= false) Then
				Me.OnborrowIDChanging(value)
				Me.SendPropertyChanging
				Me._borrowID = value
				Me.SendPropertyChanged("borrowID")
				Me.OnborrowIDChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_UserID", DbType:="VarChar(50) NOT NULL", CanBeNull:=false, IsPrimaryKey:=true)>  _
	Public Property UserID() As String
		Get
			Return Me._UserID
		End Get
		Set
			If (String.Equals(Me._UserID, value) = false) Then
				If Me._User.HasLoadedOrAssignedValue Then
					Throw New System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException()
				End If
				Me.OnUserIDChanging(value)
				Me.SendPropertyChanging
				Me._UserID = value
				Me.SendPropertyChanged("UserID")
				Me.OnUserIDChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ISBN", DbType:="VarChar(20) NOT NULL", CanBeNull:=false, IsPrimaryKey:=true)>  _
	Public Property ISBN() As String
		Get
			Return Me._ISBN
		End Get
		Set
			If (String.Equals(Me._ISBN, value) = false) Then
				If Me._Book.HasLoadedOrAssignedValue Then
					Throw New System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException()
				End If
				Me.OnISBNChanging(value)
				Me.SendPropertyChanging
				Me._ISBN = value
				Me.SendPropertyChanged("ISBN")
				Me.OnISBNChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_borrowDate", DbType:="Date")>  _
	Public Property borrowDate() As System.Nullable(Of Date)
		Get
			Return Me._borrowDate
		End Get
		Set
			If (Me._borrowDate.Equals(value) = false) Then
				Me.OnborrowDateChanging(value)
				Me.SendPropertyChanging
				Me._borrowDate = value
				Me.SendPropertyChanged("borrowDate")
				Me.OnborrowDateChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_returnDate", DbType:="Date")>  _
	Public Property returnDate() As System.Nullable(Of Date)
		Get
			Return Me._returnDate
		End Get
		Set
			If (Me._returnDate.Equals(value) = false) Then
				Me.OnreturnDateChanging(value)
				Me.SendPropertyChanging
				Me._returnDate = value
				Me.SendPropertyChanged("returnDate")
				Me.OnreturnDateChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_status", DbType:="VarChar(20)")>  _
	Public Property status() As String
		Get
			Return Me._status
		End Get
		Set
			If (String.Equals(Me._status, value) = false) Then
				Me.OnstatusChanging(value)
				Me.SendPropertyChanging
				Me._status = value
				Me.SendPropertyChanged("status")
				Me.OnstatusChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.AssociationAttribute(Name:="Book_Borrow", Storage:="_Book", ThisKey:="ISBN", OtherKey:="ISBN", IsForeignKey:=true)>  _
	Public Property Book() As Book
		Get
			Return Me._Book.Entity
		End Get
		Set
			Dim previousValue As Book = Me._Book.Entity
			If ((Object.Equals(previousValue, value) = false)  _
						OrElse (Me._Book.HasLoadedOrAssignedValue = false)) Then
				Me.SendPropertyChanging
				If ((previousValue Is Nothing)  _
							= false) Then
					Me._Book.Entity = Nothing
					previousValue.Borrows.Remove(Me)
				End If
				Me._Book.Entity = value
				If ((value Is Nothing)  _
							= false) Then
					value.Borrows.Add(Me)
					Me._ISBN = value.ISBN
				Else
					Me._ISBN = CType(Nothing, String)
				End If
				Me.SendPropertyChanged("Book")
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.AssociationAttribute(Name:="User_Borrow", Storage:="_User", ThisKey:="UserID", OtherKey:="UserID", IsForeignKey:=true)>  _
	Public Property User() As User
		Get
			Return Me._User.Entity
		End Get
		Set
			Dim previousValue As User = Me._User.Entity
			If ((Object.Equals(previousValue, value) = false)  _
						OrElse (Me._User.HasLoadedOrAssignedValue = false)) Then
				Me.SendPropertyChanging
				If ((previousValue Is Nothing)  _
							= false) Then
					Me._User.Entity = Nothing
					previousValue.Borrows.Remove(Me)
				End If
				Me._User.Entity = value
				If ((value Is Nothing)  _
							= false) Then
					value.Borrows.Add(Me)
					Me._UserID = value.UserID
				Else
					Me._UserID = CType(Nothing, String)
				End If
				Me.SendPropertyChanged("User")
			End If
		End Set
	End Property
	
	Public Event PropertyChanging As PropertyChangingEventHandler Implements System.ComponentModel.INotifyPropertyChanging.PropertyChanging
	
	Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
	
	Protected Overridable Sub SendPropertyChanging()
		If ((Me.PropertyChangingEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
		End If
	End Sub
	
	Protected Overridable Sub SendPropertyChanged(ByVal propertyName As [String])
		If ((Me.PropertyChangedEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End If
	End Sub
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.[User]")>  _
Partial Public Class User
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _UserID As String
	
	Private _Name As String
	
	Private _Password As String
	
	Private _Ic As String
	
	Private _Email As String
	
	Private _Address As String
	
	Private _Gender As String
	
	Private _Status As String
	
	Private _DateofBirth As System.Nullable(Of Date)
	
	Private _ReturnedBook As String
	
	Private _BookBorrowing As String
	
	Private _Borrows As EntitySet(Of Borrow)
	
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnUserIDChanging(value As String)
    End Sub
    Partial Private Sub OnUserIDChanged()
    End Sub
    Partial Private Sub OnNameChanging(value As String)
    End Sub
    Partial Private Sub OnNameChanged()
    End Sub
    Partial Private Sub OnPasswordChanging(value As String)
    End Sub
    Partial Private Sub OnPasswordChanged()
    End Sub
    Partial Private Sub OnIcChanging(value As String)
    End Sub
    Partial Private Sub OnIcChanged()
    End Sub
    Partial Private Sub OnEmailChanging(value As String)
    End Sub
    Partial Private Sub OnEmailChanged()
    End Sub
    Partial Private Sub OnAddressChanging(value As String)
    End Sub
    Partial Private Sub OnAddressChanged()
    End Sub
    Partial Private Sub OnGenderChanging(value As String)
    End Sub
    Partial Private Sub OnGenderChanged()
    End Sub
    Partial Private Sub OnStatusChanging(value As String)
    End Sub
    Partial Private Sub OnStatusChanged()
    End Sub
    Partial Private Sub OnDateofBirthChanging(value As System.Nullable(Of Date))
    End Sub
    Partial Private Sub OnDateofBirthChanged()
    End Sub
    Partial Private Sub OnReturnedBookChanging(value As String)
    End Sub
    Partial Private Sub OnReturnedBookChanged()
    End Sub
    Partial Private Sub OnBookBorrowingChanging(value As String)
    End Sub
    Partial Private Sub OnBookBorrowingChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		Me._Borrows = New EntitySet(Of Borrow)(AddressOf Me.attach_Borrows, AddressOf Me.detach_Borrows)
		OnCreated
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_UserID", DbType:="VarChar(50) NOT NULL", CanBeNull:=false, IsPrimaryKey:=true)>  _
	Public Property UserID() As String
		Get
			Return Me._UserID
		End Get
		Set
			If (String.Equals(Me._UserID, value) = false) Then
				Me.OnUserIDChanging(value)
				Me.SendPropertyChanging
				Me._UserID = value
				Me.SendPropertyChanged("UserID")
				Me.OnUserIDChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Name", DbType:="VarChar(30)")>  _
	Public Property Name() As String
		Get
			Return Me._Name
		End Get
		Set
			If (String.Equals(Me._Name, value) = false) Then
				Me.OnNameChanging(value)
				Me.SendPropertyChanging
				Me._Name = value
				Me.SendPropertyChanged("Name")
				Me.OnNameChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Password", DbType:="VarChar(20)")>  _
	Public Property Password() As String
		Get
			Return Me._Password
		End Get
		Set
			If (String.Equals(Me._Password, value) = false) Then
				Me.OnPasswordChanging(value)
				Me.SendPropertyChanging
				Me._Password = value
				Me.SendPropertyChanged("Password")
				Me.OnPasswordChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Ic", DbType:="VarChar(14)")>  _
	Public Property Ic() As String
		Get
			Return Me._Ic
		End Get
		Set
			If (String.Equals(Me._Ic, value) = false) Then
				Me.OnIcChanging(value)
				Me.SendPropertyChanging
				Me._Ic = value
				Me.SendPropertyChanged("Ic")
				Me.OnIcChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Email", DbType:="VarChar(30)")>  _
	Public Property Email() As String
		Get
			Return Me._Email
		End Get
		Set
			If (String.Equals(Me._Email, value) = false) Then
				Me.OnEmailChanging(value)
				Me.SendPropertyChanging
				Me._Email = value
				Me.SendPropertyChanged("Email")
				Me.OnEmailChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Address", DbType:="VarChar(50)")>  _
	Public Property Address() As String
		Get
			Return Me._Address
		End Get
		Set
			If (String.Equals(Me._Address, value) = false) Then
				Me.OnAddressChanging(value)
				Me.SendPropertyChanging
				Me._Address = value
				Me.SendPropertyChanged("Address")
				Me.OnAddressChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Gender", DbType:="VarChar(6)")>  _
	Public Property Gender() As String
		Get
			Return Me._Gender
		End Get
		Set
			If (String.Equals(Me._Gender, value) = false) Then
				Me.OnGenderChanging(value)
				Me.SendPropertyChanging
				Me._Gender = value
				Me.SendPropertyChanged("Gender")
				Me.OnGenderChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Status", DbType:="VarChar(10)")>  _
	Public Property Status() As String
		Get
			Return Me._Status
		End Get
		Set
			If (String.Equals(Me._Status, value) = false) Then
				Me.OnStatusChanging(value)
				Me.SendPropertyChanging
				Me._Status = value
				Me.SendPropertyChanged("Status")
				Me.OnStatusChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_DateofBirth", DbType:="Date")>  _
	Public Property DateofBirth() As System.Nullable(Of Date)
		Get
			Return Me._DateofBirth
		End Get
		Set
			If (Me._DateofBirth.Equals(value) = false) Then
				Me.OnDateofBirthChanging(value)
				Me.SendPropertyChanging
				Me._DateofBirth = value
				Me.SendPropertyChanged("DateofBirth")
				Me.OnDateofBirthChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ReturnedBook", DbType:="VarChar(50)")>  _
	Public Property ReturnedBook() As String
		Get
			Return Me._ReturnedBook
		End Get
		Set
			If (String.Equals(Me._ReturnedBook, value) = false) Then
				Me.OnReturnedBookChanging(value)
				Me.SendPropertyChanging
				Me._ReturnedBook = value
				Me.SendPropertyChanged("ReturnedBook")
				Me.OnReturnedBookChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_BookBorrowing", DbType:="VarChar(50)")>  _
	Public Property BookBorrowing() As String
		Get
			Return Me._BookBorrowing
		End Get
		Set
			If (String.Equals(Me._BookBorrowing, value) = false) Then
				Me.OnBookBorrowingChanging(value)
				Me.SendPropertyChanging
				Me._BookBorrowing = value
				Me.SendPropertyChanged("BookBorrowing")
				Me.OnBookBorrowingChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.AssociationAttribute(Name:="User_Borrow", Storage:="_Borrows", ThisKey:="UserID", OtherKey:="UserID")>  _
	Public Property Borrows() As EntitySet(Of Borrow)
		Get
			Return Me._Borrows
		End Get
		Set
			Me._Borrows.Assign(value)
		End Set
	End Property
	
	Public Event PropertyChanging As PropertyChangingEventHandler Implements System.ComponentModel.INotifyPropertyChanging.PropertyChanging
	
	Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
	
	Protected Overridable Sub SendPropertyChanging()
		If ((Me.PropertyChangingEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
		End If
	End Sub
	
	Protected Overridable Sub SendPropertyChanged(ByVal propertyName As [String])
		If ((Me.PropertyChangedEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End If
	End Sub
	
	Private Sub attach_Borrows(ByVal entity As Borrow)
		Me.SendPropertyChanging
		entity.User = Me
	End Sub
	
	Private Sub detach_Borrows(ByVal entity As Borrow)
		Me.SendPropertyChanging
		entity.User = Nothing
	End Sub
End Class
