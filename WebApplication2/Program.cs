using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using WebRender;

namespace WebApplication2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //CreateWebHostBuilder(args).Build().Run();


            Website website = new Website();
            website.add(new Header("Sofaspesialisten"));
            website.add(new Menu((new Link("Hjem", "index.html")), new Link("Om oss", "om_oss.html")));
            website.add(new Article("article22.txt");
            Element footerElement1 = new Element("mob: 12345678");
            Element footerElement2 = new Element("adr: Siste Reis 45a");
            Footer footer = new Footer();
            footer.add(footerElement1);
            footer.add(footerElement2);
            website.add(new Footer());
            website.launch();
        }
    }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
     
}
