Imports System.Runtime.Serialization.Formatters.Binary

Public Class SerialiseurBinaire
    Inherits Serialiseur

    Public Sub New()
        Me._formatter = New BinaryFormatter()
    End Sub

End Class
