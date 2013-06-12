Imports System.Configuration
Imports System.Data.Common

Public Class SQLAccess

    Private Shared _connection As IDbConnection

    Public Shared Property Connection As IDbConnection
        Get
            If (_connection Is Nothing OrElse _connection.State <> ConnectionState.Open) Then
                Dim settings As ConnectionStringSettings = ConfigurationManager.ConnectionStrings("cnxBDD")
                _connection = DbProviderFactories.GetFactory(settings.ProviderName).CreateConnection()
                _connection.ConnectionString = settings.ConnectionString
                _connection.Open()
            End If
            Return _connection
        End Get
        Private Set(ByVal value As IDbConnection)
            _connection = value
        End Set
    End Property

    Shared Sub seDeconnecter()
        If (_connection Is Nothing OrElse _connection.State <> ConnectionState.Closed) Then
            _connection.Close()
            _connection = Nothing
        End If
    End Sub

    Public Shared Function creerCommande(ByVal requete As String, Optional ByVal type As CommandType = CommandType.Text) As IDbCommand
        creerCommande = Connection.CreateCommand()
        creerCommande.CommandText = requete
        creerCommande.CommandType = type
    End Function
    Public Shared Sub initialiserParametre(ByVal cmd As IDbCommand,
                                           ByVal nom As String,
                                           ByVal valeur As Object,
                                           Optional ByVal type As DbType = DbType.String)
        Dim param As IDbDataParameter = cmd.CreateParameter()
        param.ParameterName = nom
        If valeur IsNot Nothing Then
            param.Value = valeur
        Else
            param.Value = DBNull.Value
        End If
        param.DbType = type

        cmd.Parameters.Add(param)
    End Sub

End Class
