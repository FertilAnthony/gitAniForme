Imports BO
Imports System.IO
Imports System.Xml.Serialization

Public Class Export

    Shared Sub exporterBaremes(ByVal list As List(Of Bareme), ByVal fichier As String)
        'Serialize object to a text file.
        Dim objStreamWriter As New StreamWriter(fichier)
        Dim x As New XmlSerializer(list.GetType)
        x.Serialize(objStreamWriter, list)
        objStreamWriter.Close()
    End Sub



End Class
