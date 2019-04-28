using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Routing_yapisini_anlama
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //Mvc nedir? Nasil kullanılır?
            //mvc-nedir-nasil-kullanilir
            //...../makale/goster/mvc-nedir-nasil-kullanilir

            //Blog sitesi örneği url ler otomatik yazı eklenince eklemis oluyor.
            routes.MapRoute(
            name: "Makale",
            url: "Makale/Goster/{makaleadi}",
            defaults: new { controller = "Makale", action = "Goster", makaleadi = UrlParameter.Optional }
        );


            routes.MapRoute(
             name: "iletisim",
             url: "iletisim",
             defaults: new { controller = "Home", action = "Contact" }
         );


            routes.MapRoute(
             name: "Hakkimizda",
             url: "Hakkimizda",
             defaults: new { controller = "Home", action = "About" }
         );


            routes.MapRoute(
              name: "Anasayfa",
              url: "Anasayfa",
              defaults: new { controller = "Home", action = "Index" }
          );

            routes.MapRoute(
               name: "Default_2",
               url: "{controller}/Document/{document_no}",
               defaults: new { controller = "Home", action = "Document", document_no = UrlParameter.Optional }
           );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
