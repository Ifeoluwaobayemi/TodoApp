using Microsoft.Extensions.DependencyInjection;
using TodoApp.Repository;

namespace TodoApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            //regiser DB context
            var services = new ServiceCollection();
            services.AddDbContext<TodoDbContext>();
            services.AddScoped<ITodoRepository, TodoRepository>();
            services.AddScoped<TodoApp>();
            var serviceProvider = services.BuildServiceProvider();
            var form = serviceProvider.GetRequiredService<TodoApp>();
            Application.Run(form);
        }
    }
}