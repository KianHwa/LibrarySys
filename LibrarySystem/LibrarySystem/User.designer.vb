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


<Global.System.Data.Linq.Mapping.DatabaseAttribute(Name:="User")>  _
Partial Public Class UserDataContext
	Inherits System.Data.Linq.DataContext
	
	Private Shared mappingSource As System.Data.Linq.Mapping.MappingSource = New AttributeMappingSource()
	
  #Region "Extensibility Method Definitions"
  Partial Private Sub OnCreated()
  End Sub
  Partial Private Sub InsertUser(instance As User)
    End Sub
  Partial Private Sub UpdateUser(instance As User)
    End Sub
  Partial Private Sub DeleteUser(instance As User)
    End Sub
  #End Region
	
	Public Sub New()
		MyBase.New(Global.LibrarySystem.My.MySettings.Default.UserConnectionString, mappingSource)
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
	
	Public ReadOnly Property Users() As System.Data.Linq.Table(Of User)
		Get
			Return Me.GetTable(Of User)
		End Get
	End Property
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.[User]")>  _
Partial Public Class User
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _UserId As String
	
	Private _Name As String
	
	Private _Password As String
	
	Private _Ic As String
	
	Private _Email As String
	
	Private _Address As String
	
	Private _Gender As String
	
	Private _Occupation As String
	
	Private _DateOfBirth As Date
	
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnUserIdChanging(value As String)
    End Sub
    Partial Private Sub OnUserIdChanged()
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
    Partial Private Sub OnOccupationChanging(value As String)
    End Sub
    Partial Private Sub OnOccupationChanged()
    End Sub
    Partial Private Sub OnDateOfBirthChanging(value As Date)
    End Sub
    Partial Private Sub OnDateOfBirthChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		OnCreated
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_UserId", DbType:="VarChar(10) NOT NULL", CanBeNull:=false, IsPrimaryKey:=true)>  _
	Public Property UserId() As String
		Get
			Return Me._UserId
		End Get
		Set
			If (String.Equals(Me._UserId, value) = false) Then
				Me.OnUserIdChanging(value)
				Me.SendPropertyChanging
				Me._UserId = value
				Me.SendPropertyChanged("UserId")
				Me.OnUserIdChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Name", DbType:="VarChar(30) NOT NULL", CanBeNull:=false)>  _
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
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Password", DbType:="VarChar(20) NOT NULL", CanBeNull:=false)>  _
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
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Ic", DbType:="VarChar(20) NOT NULL", CanBeNull:=false)>  _
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
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Email", DbType:="VarChar(30) NOT NULL", CanBeNull:=false)>  _
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
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Address", DbType:="VarChar(50) NOT NULL", CanBeNull:=false)>  _
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
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Gender", DbType:="VarChar(6) NOT NULL", CanBeNull:=false)>  _
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
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Occupation", DbType:="VarChar(10) NOT NULL", CanBeNull:=false)>  _
	Public Property Occupation() As String
		Get
			Return Me._Occupation
		End Get
		Set
			If (String.Equals(Me._Occupation, value) = false) Then
				Me.OnOccupationChanging(value)
				Me.SendPropertyChanging
				Me._Occupation = value
				Me.SendPropertyChanged("Occupation")
				Me.OnOccupationChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_DateOfBirth", DbType:="Date NOT NULL")>  _
	Public Property DateOfBirth() As Date
		Get
			Return Me._DateOfBirth
		End Get
		Set
			If ((Me._DateOfBirth = value)  _
						= false) Then
				Me.OnDateOfBirthChanging(value)
				Me.SendPropertyChanging
				Me._DateOfBirth = value
				Me.SendPropertyChanged("DateOfBirth")
				Me.OnDateOfBirthChanged
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