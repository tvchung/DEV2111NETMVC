using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Lesson02_2_ControllerDemo
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //https://localhost:44399/product/
            routes.MapRoute(
                name: "Product",
                url: "product",
                defaults: new { Controller = "Product", Action = "Index" }
            );

            //https://localhost:44399/product/productdetail
            routes.MapRoute(
                name: "Product Detail",
                url: "product/productdetail",
                defaults: new { Controller = "Product", Action = "ProductDetail" }
            );

            //https://localhost:44399/product-create
            routes.MapRoute(
              name: "Product-create-id",
              url: "product-create",
              defaults: new { Controller = "Product", Action = "Create" }
          );

            //https://localhost:44399/product-create-11

            routes.MapRoute(
                name: "Product-create",
                url: "product-create-{id}",
                defaults: new { Controller = "Product", Action = "Edit",id=UrlParameter.Optional }
            );

          
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
