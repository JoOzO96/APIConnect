﻿Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web.Http

Public Module WebApiConfig
    Public Sub Register(ByVal config As HttpConfiguration)
        ' Serviços e configuração da API da Web

        ' Rotas da API da Web
        config.MapHttpAttributeRoutes()
        config.Formatters.JsonFormatter.SupportedMediaTypes.Add(New Net.Http.Headers.MediaTypeHeaderValue("text/html"))
        config.Routes.MapHttpRoute(
            name:="DefaultApi",
            routeTemplate:="api/{controller}/{id}",
            defaults:=New With {.id = RouteParameter.Optional}
        )
    End Sub
End Module
