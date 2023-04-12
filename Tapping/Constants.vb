Public Class Constants
    ' TAULES
    Public Const TAULAUSUARI As String = "usuari"
    Public Const TAULAADMIN As String = "administrador"
    Public Const TAULAEMPRESA As String = "empresa"
    Public Const TAULACONSUMIDOR As String = "consumidor"

    ' MYSQL CONNECTION
    Public Const SERVER As String = "localhost"
    Public Const USER As String = "root"
    Public Const DATABASE As String = "tapping"
    Public Const PORT As String = "3306"

    ' QUERY'S INICI SESSIO
    Public Const QUERYADMIN As String = "select usuari.correu,usuari.contrasenya, administrador.dni, administrador.cognom" _
                                   & " from usuari" _
                                   & " join administrador" _
                                   & " on usuari.id = administrador.id_usuari" _
                                   & " where administrador.id_usuari = "

    Public Const QUERYEMPRESA As String = "Select usuari.correu,usuari.contrasenya, empresa.nif" _
                                    & " from usuari" _
                                    & " join empresa" _
                                    & " on usuari.id = empresa.id_usuari" _
                                    & " where empresa.id_usuari = "

    Public Const QUERYCONSUMIDOR As String = "select usuari.correu,usuari.contrasenya, consumidor.cognom" _
                                        & " from usuari" _
                                        & " join consumidor on" _
                                        & " usuari.id = consumidor.id_usuari" _
                                        & " where consumidor.id_usuari = "

End Class
