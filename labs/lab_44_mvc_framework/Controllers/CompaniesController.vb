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
    Public Class CompaniesController
        Inherits System.Web.Mvc.Controller

        Private db As New UsersEntities

        ' GET: Companies
        Function Index() As ActionResult
            Return View(db.Companies.ToList())
        End Function

        ' GET: Companies/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim company As Company = db.Companies.Find(id)
            If IsNothing(company) Then
                Return HttpNotFound()
            End If
            Return View(company)
        End Function

        ' GET: Companies/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: Companies/Create
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="CompanyID,CompanyName")> ByVal company As Company) As ActionResult
            If ModelState.IsValid Then
                db.Companies.Add(company)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(company)
        End Function

        ' GET: Companies/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim company As Company = db.Companies.Find(id)
            If IsNothing(company) Then
                Return HttpNotFound()
            End If
            Return View(company)
        End Function

        ' POST: Companies/Edit/5
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="CompanyID,CompanyName")> ByVal company As Company) As ActionResult
            If ModelState.IsValid Then
                db.Entry(company).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(company)
        End Function

        ' GET: Companies/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim company As Company = db.Companies.Find(id)
            If IsNothing(company) Then
                Return HttpNotFound()
            End If
            Return View(company)
        End Function

        ' POST: Companies/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim company As Company = db.Companies.Find(id)
            db.Companies.Remove(company)
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
