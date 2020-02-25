Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc
Imports lab_44_mvc_framework.lab_44_mvc_framework

Namespace Controllers
    Public Class UsersController
        Inherits System.Web.Mvc.Controller

        Private db As New UsersEntities

        ' GET: Users
        Function Index() As ActionResult
            Dim users = db.Users.Include(Function(u) u.Category).Include(Function(u) u.Company)
            Return View(users.ToList())
        End Function

        ' GET: Users/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim user As User = db.Users.Find(id)
            If IsNothing(user) Then
                Return HttpNotFound()
            End If
            Return View(user)
        End Function

        ' GET: Users/Create
        Function Create() As ActionResult
            ViewBag.CategoryID = New SelectList(db.Categories, "CategoryID", "CategoryName")
            ViewBag.CompanyID = New SelectList(db.Companies, "CompanyID", "CompanyName")
            Return View()
        End Function

        ' POST: Users/Create
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="UserID,CategoryID,UserName,DateOfBirth,isValid,CompanyID")> ByVal user As User) As ActionResult
            If ModelState.IsValid Then
                db.Users.Add(user)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.CategoryID = New SelectList(db.Categories, "CategoryID", "CategoryName", user.CategoryID)
            ViewBag.CompanyID = New SelectList(db.Companies, "CompanyID", "CompanyName", user.CompanyID)
            Return View(user)
        End Function

        ' GET: Users/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim user As User = db.Users.Find(id)
            If IsNothing(user) Then
                Return HttpNotFound()
            End If
            ViewBag.CategoryID = New SelectList(db.Categories, "CategoryID", "CategoryName", user.CategoryID)
            ViewBag.CompanyID = New SelectList(db.Companies, "CompanyID", "CompanyName", user.CompanyID)
            Return View(user)
        End Function

        ' POST: Users/Edit/5
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="UserID,CategoryID,UserName,DateOfBirth,isValid,CompanyID")> ByVal user As User) As ActionResult
            If ModelState.IsValid Then
                db.Entry(user).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.CategoryID = New SelectList(db.Categories, "CategoryID", "CategoryName", user.CategoryID)
            ViewBag.CompanyID = New SelectList(db.Companies, "CompanyID", "CompanyName", user.CompanyID)
            Return View(user)
        End Function

        ' GET: Users/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim user As User = db.Users.Find(id)
            If IsNothing(user) Then
                Return HttpNotFound()
            End If
            Return View(user)
        End Function

        ' POST: Users/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim user As User = db.Users.Find(id)
            db.Users.Remove(user)
            db.SaveChanges()
            Return RedirectToAction("Index")
        End Function

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing) Then
                db.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub
    End Class
End Namespace
