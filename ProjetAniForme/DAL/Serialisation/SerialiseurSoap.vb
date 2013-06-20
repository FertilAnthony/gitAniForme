Imports System.Runtime.Serialization.Formatters.Soap

Public Class SerialiseurSoap
    Inherits Serialiseur

    Public Sub New()
        Me._formatter = New SoapFormatter()
    End Sub

End Class
