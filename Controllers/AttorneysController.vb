Imports System.Web.Mvc

Namespace Controllers
    Public Class AttorneysController
        Inherits Controller

        ' GET: Attorneys
        Function Index() As ActionResult
            Return View()
        End Function
    End Class
End Namespace