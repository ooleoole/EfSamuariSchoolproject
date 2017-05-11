using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.FileProviders;

namespace SamuraiWEB.Middleware
{
    public static class ApplicationBuilderExtension
    {


        public static IApplicationBuilder UseTypeScripts(this IApplicationBuilder app, string root)
        {
            var path = Path.Combine(root, "wwwroot/Scripts");
            var provider = new PhysicalFileProvider(path);
            var options = new StaticFileOptions
            {
                RequestPath = "/Scripts",
                FileProvider = provider
            };
            app.UseStaticFiles(options);

            return app;
        }
    }
}
