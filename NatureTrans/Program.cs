
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

            // Fetch LoginForm from ServiceProvider and run the application
            var inventoryForm = ServiceProvider.GetRequiredService<InventoryForm>();
            var loginForm = ServiceProvider.GetRequiredService<LoginForm>();
            Application.Run(inventoryForm);
        }
        private static void ConfigureServices(ServiceCollection services)
        {
            services.AddSingleton<NTContext>(); // lifetime of NTContext is singleton

            // Register your services here
            services.AddTransient<LoginService>();
            services.AddTransient<RegistrationService>();
            services.AddTransient<InventoryService>();

            // Register your forms
            services.AddTransient<orderForm>();
            services.AddTransient<InventoryForm>();
            services.AddTransient<Workspace>();
            services.AddTransient<RegistrationForm>();
            services.AddTransient<LoginForm>();
            services.AddTransient<UpdateInventoryForm>();
            services.AddTransient<CategoryForm>();

        }

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();
    }
}
