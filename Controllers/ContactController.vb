Imports System.Web.Mvc
Imports System.Net.Mail

Public Class ContactController
    Inherits Controller

    ' GET: Contact
    Public Function Index() As ActionResult
        'Return Redirect("https://forms.gle/y4MG2unYiPpjJpWK9")
        Return View()

    End Function
End Class