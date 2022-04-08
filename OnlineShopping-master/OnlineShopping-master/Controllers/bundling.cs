// Bundling_single HTTP request
//281 ms ----------> individual file combine, into single request
//style bundle -------> path of the files
//

using System.Web;  
using System.Web.Optimization;  
  
namespace BundlingSample  
{  
    public class BundleConfig  
    {  
        public static void RegisterBundles(BundleCollection bundles) {  
  
            bundles.Add(new StyleBundle("~/Content/css").Include(  
                "~/Content/bootstrap.css",  
                "~/Content/site.css",  
                "~/Content/bootstrap-responsive.css"));  
        }  
    }  
}  

//Registering the bundle into the application
//registering into bundleconfig 
// registering bundle module in the Application for all style and script bundles.

using System.Web.Mvc;  
using System.Web.Optimization;  
using System.Web.Routing;  
  
namespace BundlingSample   
{  
    public class MvcApplication: System.Web.HttpApplication  
    {  
        protected void Application_Start() {  
            AreaRegistration.RegisterAllAreas();  
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);  
            RouteConfig.RegisterRoutes(RouteTable.Routes);  
            BundleConfig.RegisterBundles(BundleTable.Bundles);  
        }  
    }  
}  




// load time for bundle 
//create a bundle for the script, which is called Script bundle


bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(  
"~/Scripts/bootstrap.js"));  




// Defining the version is possible 

bundles.Add(new ScriptBundle("~/bundles/jquery").Include(  
"~/Scripts/jquery-{version}.js"));  



//bundling result 
//loading resources from CDN 
//RESOURCE REQUEST fails in debug mode

bundles.UseCdn = true;  
bundles.Add(new ScriptBundle("~/bundles/jquery","https://cdnjs.cloudflare.com/ajax/libs/jquery/3.1.0/jquery.js"));


//retrieve jQuery resource locally


@Scripts.Render("~/bundles/jquery") <  
    script type = "text/javascript" >  
    if (typeof jQuery == 'undefined')  
    {  
        var script = document.createElement('script');  
        script.src = '@Url.Content("~/Scripts/jquery-1.10.2.js")';  
        script.type = 'text/javascript';  
        document.getElementsByTagName("head")[0].appendChild(script);  
    } <  
    /script>  














