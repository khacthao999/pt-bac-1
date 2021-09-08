Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

<Table("Account")>
Partial Public Class Account
    <Key>
    <Column("Account")>
    <StringLength(50)>
    Public Property Account1 As String

    <StringLength(50)>
    Public Property Password As String
End Class
