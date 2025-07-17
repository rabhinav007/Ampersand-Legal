Imports System.Web.Mvc

Namespace Controllers
    Public Class BlogsController
        Inherits Controller

        ' GET: Blogs
        Function Index() As ActionResult
            Return View()
        End Function
    End Class
End Namespace