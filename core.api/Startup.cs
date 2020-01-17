using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using core.data;
using core.logic.ApiModel.PersonModel;
using Microsoft.AspNet.OData.Builder;
using Microsoft.AspNet.OData.Extensions;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OData.Edm;

namespace core.api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // https on heroku docker - https://jincod.github.io/2018/11/17/ensure-https-for-aspnetcore-on-heroku/
            services.AddHttpsRedirection(options => { options.HttpsPort = 443; });
            services.Configure<ForwardedHeadersOptions>(options =>
            {
                options.KnownNetworks.Clear();
                options.KnownProxies.Clear();
                options.ForwardedHeaders =
                    ForwardedHeaders.XForwardedFor | ForwardedHeaders.XForwardedProto;
            });

            services.AddControllers(mvcOption => mvcOption.EnableEndpointRouting = false);

            services.AddAuthentication("Bearer")
                .AddJwtBearer("Bearer", options =>
                {
                    options.Authority = "http://localhost:5000";
                    //options.Authority = "https://virtualcollege-identity.herokuapp.com/";
                    options.RequireHttpsMetadata = false;
                    options.Audience = "api1";
                });

            services.AddCors(options =>
            {
                options.AddDefaultPolicy(builder =>
                {
                    builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
                });
            });

            //services.AddDbContext<VirtualCollegeContext>(options =>
            //            options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            services.AddDbContext<VirtualCollegeContext>(options =>
            {
                var connectionString = Environment.GetEnvironmentVariable("HEROKU_POSTGRES");
                if (connectionString != null)
                {
                    options.UseNpgsql(connectionString);
                }
                else throw new Exception("Database variable not set");
            });

            services.AddOData();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            if (env.IsProduction())
            {
                app
                    .UseForwardedHeaders()
                    .UseHttpsRedirection();
            }

            app.UseCors();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseMvc(routeBuilder =>
            {
                routeBuilder.EnableDependencyInjection();
                routeBuilder.Expand().Select().OrderBy().Filter();
                routeBuilder.MapODataServiceRoute("api", "odata", GetEdmModel());
            });

            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapControllers();
            //});
        }

        private IEdmModel GetEdmModel()
        {
            var builder = new ODataConventionModelBuilder();
            builder.EntitySet<PersonModel>("People");
            builder.EntitySet<AddressModel>("Address");

            //builder.EntitySet<data.Model.Person.Person>("People");
            //builder.EntitySet<data.Model.Person.Contact>("Contact");
            //builder.EntitySet<data.Model.Address.Address>("Address");;
            return builder.GetEdmModel();
        }
    }
}
