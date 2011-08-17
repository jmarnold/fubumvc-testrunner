using System;
using System.Web.Routing;
using Bottles;
using FubuMVC.Core;
using FubuMVC.StructureMap;

namespace FubuMVC.HelloJasmine
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            FubuApplication
                .For(new FubuRegistry(x => x.IncludeDiagnostics(true)))
                .StructureMapObjectFactory()
                .Bootstrap(RouteTable.Routes);

            PackageRegistry.AssertNoFailures();
        }
    }
}