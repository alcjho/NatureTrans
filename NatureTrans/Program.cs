
using Microsoft.Extensions.DependencyInjection;
using NatureTrans.Data;
using NatureTrans.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace NatureTrans
{
    
    internal static class Program
    {
        public static IServiceProvider ServiceProvider { get; set; }

        [STAThread]
        static void Main()
        {
            AllocConsole();

            Application.SetHighDpiMode(HighDpiMode.SystemAware);

            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection); // Ensure this is called before building the ServiceProvider
            ServiceProvider = serviceCollection.BuildServiceProvider();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var importForm = ServiceProvider.GetRequiredService<ImportDataForm>();

            // Fetch LoginForm from ServiceProvider and run the application
            var loginForm = ServiceProvider.GetRequiredService<LoginForm>();
            Application.Run(importForm);
        }
        private static void ConfigureServices(ServiceCollection services)
        {

            services.AddTransient<NTContext>(); // lifetime of NTContext is singleton

            // Register your services here
            services.AddScoped<LoginService>();
            services.AddScoped<RegistrationService>();
            services.AddScoped<InventoryService>();
            services.AddScoped<OrderService>();
            services.AddScoped<RecipeService>();
            services.AddScoped<ProductionService>();

            // Register your forms
            services.AddScoped<orderForm>();
            services.AddScoped<InventoryForm>();
            services.AddScoped<Workspace>();
            services.AddScoped<RegistrationForm>();
            services.AddScoped<LoginForm>();
            services.AddScoped<UpdateInventoryForm>();
            services.AddScoped<CategoryForm>();
            services.AddScoped<NewCommand>();
            services.AddScoped<RecipeForm>();
            services.AddScoped<FindRecipeForm>();
            services.AddTransient<ProductionForm>();
            services.AddScoped<ImportDataForm>();
        }

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();
    }
}
