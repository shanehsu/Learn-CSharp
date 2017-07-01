using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection; // 雖然所有 ASP.NET Core 專案都有使用
                                                // 還是特別註明，這個是 MVC 必要的

namespace Intro {
    public class Startup {
        // （加入 MVC）非必要
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration) {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services) {
            // （加入 MVC）1. 加入 MVC 支援
            // （加入 MVC）這邊處裡的是 Dependency Injection
            services.AddMvc();    
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env) {
            if (env.IsDevelopment()) {
                app.UseDeveloperExceptionPage();
            }

            // （加入 MVC）2. 在 app 中使用 MVC
            // （加入 MVC）這邊處裡的是 Request Pipeline
            app.UseMvc(routes => {
                routes.MapRoute(name: "default", template: "{controller=HelloWorld}/{action=Index}");
            });
        }
    }
}
