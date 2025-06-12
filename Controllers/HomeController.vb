Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Function Index() As ActionResult
        Return View()
    End Function

    Function About() As ActionResult
        ViewData("Message") = "Your application description page."

        Return View()
    End Function

    Function Contact() As ActionResult
        Return View()
    End Function

    Function Practice() As ActionResult
        Return View()
    End Function
    Function Attorneys() As ActionResult
        Return View()
    End Function
End Class
