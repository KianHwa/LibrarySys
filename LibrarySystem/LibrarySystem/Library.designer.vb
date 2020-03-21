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
Imports LibrarySystem

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
  Partial Private Sub InsertMember(instance As Member)
    End Sub
  Partial Private Sub UpdateMember(instance As Member)
    End Sub
  Partial Private Sub DeleteMember(instance As Member)
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
	
	Public ReadOnly Property Members() As System.Data.Linq.Table(Of Member)
		Get
			Return Me.GetTable(Of Member)
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
	
	Private _memberID As String
	
	Private _ISBN As String
	
	Private _borrowDate As System.Nullable(Of Date)
	
	Private _returnDate As System.Nullable(Of Date)
	
	Private _status As String
	
	Private _Book As EntityRef(Of Book)
	
	Private _Member As EntityRef(Of Member)
	
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
    Partial Private Sub OnmemberIDChanging(value As String)
    End Sub
    Partial Private Sub OnmemberIDChanged()
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
		Me._Member = CType(Nothing, EntityRef(Of Member))
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
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_memberID", DbType:="VarChar(50) NOT NULL", CanBeNull:=false, IsPrimaryKey:=true)>  _
	Public Property memberID() As String
		Get
			Return Me._memberID
		End Get
		Set
			If (String.Equals(Me._memberID, value) = false) Then
				If Me._Member.HasLoadedOrAssignedValue Then
					Throw New System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException()
				End If
				Me.OnmemberIDChanging(value)
				Me.SendPropertyChanging
				Me._memberID = value
				Me.SendPropertyChanged("memberID")
				Me.OnmemberIDChanged
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
	
	<Global.System.Data.Linq.Mapping.AssociationAttribute(Name:="Member_Borrow", Storage:="_Member", ThisKey:="memberID", OtherKey:="memberID", IsForeignKey:=true)>  _
	Public Property Member() As Member
		Get
			Return Me._Member.Entity
		End Get
		Set
			Dim previousValue As Member = Me._Member.Entity
			If ((Object.Equals(previousValue, value) = false)  _
						OrElse (Me._Member.HasLoadedOrAssignedValue = false)) Then
				Me.SendPropertyChanging
				If ((previousValue Is Nothing)  _
							= false) Then
					Me._Member.Entity = Nothing
					previousValue.Borrows.Remove(Me)
				End If
				Me._Member.Entity = value
				If ((value Is Nothing)  _
							= false) Then
					value.Borrows.Add(Me)
					Me._memberID = value.memberID
				Else
					Me._memberID = CType(Nothing, String)
				End If
				Me.SendPropertyChanged("Member")
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

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.Member")>  _
Partial Public Class Member
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _memberID As String
	
	Private _memberName As String
	
	Private _Borrows As EntitySet(Of Borrow)
	
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnmemberIDChanging(value As String)
    End Sub
    Partial Private Sub OnmemberIDChanged()
    End Sub
    Partial Private Sub OnmemberNameChanging(value As String)
    End Sub
    Partial Private Sub OnmemberNameChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		Me._Borrows = New EntitySet(Of Borrow)(AddressOf Me.attach_Borrows, AddressOf Me.detach_Borrows)
		OnCreated
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_memberID", DbType:="VarChar(50) NOT NULL", CanBeNull:=false, IsPrimaryKey:=true)>  _
	Public Property memberID() As String
		Get
			Return Me._memberID
		End Get
		Set
			If (String.Equals(Me._memberID, value) = false) Then
				Me.OnmemberIDChanging(value)
				Me.SendPropertyChanging
				Me._memberID = value
				Me.SendPropertyChanged("memberID")
				Me.OnmemberIDChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_memberName", DbType:="VarChar(50)")>  _
	Public Property memberName() As String
		Get
			Return Me._memberName
		End Get
		Set
			If (String.Equals(Me._memberName, value) = false) Then
				Me.OnmemberNameChanging(value)
				Me.SendPropertyChanging
				Me._memberName = value
				Me.SendPropertyChanged("memberName")
				Me.OnmemberNameChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.AssociationAttribute(Name:="Member_Borrow", Storage:="_Borrows", ThisKey:="memberID", OtherKey:="memberID")>  _
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
		entity.Member = Me
	End Sub
	
	Private Sub detach_Borrows(ByVal entity As Borrow)
		Me.SendPropertyChanging
		entity.Member = Nothing
	End Sub
End Class
