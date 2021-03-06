﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using BeestjeOpJeFeestje.Data;
using BeestjeOpJeFeestje.Models;
using BeestjeOpJeFeestje.Models.CustomValidation;
using BeestjeOpJeFeestje.Models.Repositories;
using Microsoft.AspNetCore.Mvc.DataAnnotations;

namespace BeestjeOpJeFeestje
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;

            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
	        services.AddControllersWithViews();

	        services.AddScoped<IRepository<Animal>, AnimalDbRepository>();
	        services.AddScoped<IRepository<Accessories>, AccessoriesDBRepository>();
	        services.AddScoped<IRepository<Booking>, BookingDBRepository>();
	        services.AddScoped<IRepository<BookingProcess>, BookingProcessDBRepository>();
	        services.AddScoped<IRepository<ClientInfo>, ClientInfoDBRepository>();

	        services.AddDbContext<BeestjeOpJeFeestjeContext>(options =>
		        options.UseSqlServer(Configuration.GetConnectionString("BeestjeOpJeFeestjeContext")));

	        services.AddSingleton<IValidationAttributeAdapterProvider, DateIsNoteBookedAttributeAdapterProvider>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();
            
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
