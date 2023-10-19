using BankomatSimulazione.Controllers;
using BankomatSimulazione.Repository;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace BankomatSimulazione
{
    class Program
    {
        static void Main(string[] args)
        {
            var services = new ServiceCollection();
            ConfigureServices(services);
            services
                .AddSingleton<Start, Start>()
                .BuildServiceProvider()
                .GetService<Start>()
                .Execute();
                
        }

        public static void ConfigureServices(IServiceCollection services)
        {

            //services.AddSingleton<Start, Start>();
            services.AddScoped<Context, Context>();
            services.AddSingleton<BancaController, BancaController>();
            services.AddScoped<IDbRepository, DbRepository>();
            services.AddScoped<Scelta, Scelta>();
        }
    }

    public class Start
    {
        private readonly BancaController _controller;
        private readonly Scelta _scelta;

        public Start(BancaController ctrl, Scelta scelta)
        {
            _controller = ctrl;
            _scelta = scelta;
        }

        public void Execute()
        {
            Console.WriteLine("**************************************************");
            Console.WriteLine("*              Bankomat Simulator               *");
            Console.WriteLine("**************************************************");

            _controller.GetBanche();
            //_controller.GetUtenti();
            int a = _scelta.Menu();
            _controller.LoginAsync(a);
            Console.ReadLine();
        }
    }
}
