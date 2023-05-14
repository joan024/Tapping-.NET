Public Class Constants

    'CONSTANTS COMPARTITS
    Public Shared IDUSUARI As String = ""
    Public Shared bbdd As New ClasseBBDD
    Public Shared IDLOCAL As String = ""
    Public Shared PACK As String = ""
    Public Shared IDTAPA As String = ""
    Public Shared IDLOCALTAPA As String = ""
    'COLUMNES
    Public Shared NOMTAPA As String = ""
    Public Shared NOMLOCAL As String = ""
    ' TAULES
    Public Const TAULAUSUARI As String = "usuari"
    Public Const TAULAADMIN As String = "administrador"
    Public Const TAULAEMPRESA As String = "empresa"
    Public Const TAULACONSUMIDOR As String = "consumidor"
    Public Const TAULANOTICIA As String = "noticia"
    Public Const TAULAPREGUNTAFREQUENT As String = "preguntafrequent"
    Public Const TAULACATEGORIA As String = "categoria"
    Public Const TAULAVALORACIO As String = "valoracio"
    Public Const TAULAXAT As String = "xat"
    Public Const TAULALINEAXAT As String = "lineaxat"
    Public Const TAULAFOTO As String = "foto"
    Public Const TAULATAPA As String = "tapa"
    Public Const TAULACATEGORIATAPA As String = "categoria_tapa"
    Public Const TAULADESCOMPTE As String = "descompte"
    Public Const TAULALOCAL As String = "local"
    Public Const TAULALOCALTAPA As String = "local_tapa"


    ' MYSQL CONNECTION
    Public Const SERVER As String = "server=192.168.1.150"
    Public Const USER As String = "user id=tapping"
    Public Const PASSWORD As String = "password=JuMaJoJo!!25231"
    Public Const DATABASE As String = "database=tappingDB"
    Public Const PORT As String = "port=25230"

    'RUTA FOTOS I ARXIUS
    Public Const ARXIUS As String = "C:\TappingFotos\local\"
    Public Const FOTOS As String = "C:\TappingFotos\"
    Public Const EXTENSIOARXIU As String = ".txt"

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

    'QUERY TAPA I LOCAL
    Public Const QUERYTAPA As String = "select tapa.nom,local_tapa.personalitzacio, local_tapa.preu" _
                                        & " from tapa" _
                                        & " join local_tapa on" _
                                        & " tapa.id = local_tapa.id_tapa" _
                                        & " where local_tapa.id_local = "

    Public Const QUERYLOCAL As String = "select local.nom,local.direccio, local.telefon, local.descripcio, local.web" _
                                        & " from local" _
                                        & " where id_usuari = "
End Class
