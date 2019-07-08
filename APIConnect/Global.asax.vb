Imports System.Web.Http
Imports System.Web.Optimization
Imports Newtonsoft.Json.Converters

Public Class WebApiApplication
    Inherits System.Web.HttpApplication

    Protected Sub Application_Start()
        AreaRegistration.RegisterAllAreas()
        GlobalConfiguration.Configure(AddressOf WebApiConfig.Register)
        FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters)
        RouteConfig.RegisterRoutes(RouteTable.Routes)
        BundleConfig.RegisterBundles(BundleTable.Bundles)
        'System.Threading.Thread.CurrentThread.CurrentUICulture = New 

        'Dim json = GlobalConfiguration.Configuration.Formatters.JsonFormatter
        'json.UseDataContractJsonSerializer = True
    End Sub
End Class
