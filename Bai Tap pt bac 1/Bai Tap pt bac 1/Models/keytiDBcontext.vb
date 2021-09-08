Imports System
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity
Imports System.Linq

Partial Public Class keytiDBcontext
    Inherits DbContext

    Public Sub New()
        MyBase.New("name=keytiDBcontext")
    End Sub

    Public Overridable Property Accounts As DbSet(Of Account)

    Protected Overrides Sub OnModelCreating(ByVal modelBuilder As DbModelBuilder)
        modelBuilder.Entity(Of Account)() _
            .Property(Function(e) e.Password) _
            .IsUnicode(False)
    End Sub
End Class
