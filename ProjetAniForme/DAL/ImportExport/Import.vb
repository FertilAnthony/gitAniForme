Imports System.IO
Imports BO
Imports System.Xml.Serialization
Imports System.Xml

Public Class Import

    Shared Function importerBaremes(ByVal fichier As String) As Bareme()
        ' Declare an object variable of the type to be deserialized.
        'Dim b As Bareme()
        Dim x As New XmlSerializer(GetType(Bareme))

        ' A FileStream is needed to read the XML document.
        'Dim fs As New FileStream(fichier, FileMode.Open)
        'Dim reader As New XmlTextReader(fs)

        ' Use the Deserialize method to restore the object's state.
        'b = CType(x.Deserialize(reader), Bareme())

        'Return b


        Dim objStreamReader As New StreamReader(fichier)
        Dim p2 As Bareme()
        p2 = CType(x.Deserialize(objStreamReader), Bareme())
        objStreamReader.Close()

        Return p2

    End Function


End Class
