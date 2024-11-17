using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SubastaMaestra.Data.Implements;
using SubastaMaestra.Data.Interfaces;
using SubastaMaestra.Data;
using SubastaMaestra.Models.Utils;

using SubastaMaestra.Models.DTOs.Auction;
using SubastaMaestra.Models.DTOs.User;
namespace SubastaMaestra_Escritorio
{
    internal static class Program
    {


        public static IServiceProvider ServiceProvider { get; private set; }
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();


            var host = CreateHostBuilder().Build();
            ServiceProvider = host.Services;

            Application.Run(ServiceProvider.GetRequiredService<Login>());

        }

        static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()

                .ConfigureServices((context, services) =>
                {
                    // Agrega la conexión a la base de datos
                    var connectionString = "Data Source=.;Initial Catalog=SubastaMaestra;Integrated Security=True;TrustServerCertificate=True;";

                    services.AddDbContext<SubastaContext>(options =>
                        options.UseSqlServer(connectionString));

                    services.AddTransient<IProductRepository, ProductRepository>();
                    services.AddTransient<IAuctionRepository, AuctionRepository>();
                    services.AddTransient<IBidRepository, BidRepository>();
                    services.AddTransient<IUserRepository, UserRepository>();
                    services.AddAutoMapper(typeof(AutoMapperProfiles));
                    services.AddTransient<AuctionHandlerService>();
                    services.AddTransient<AuctionDTO>();
                    services.AddTransient<ISaleRepository, SaleRepository>();
                    services.AddTransient<INotificationRepository, NotificacionRepository>();
                    services.AddTransient<IUserRepository, UserRepository>();
                    services.AddTransient<UserCreateDTO>();
                    services.AddTransient<LoginRequestDTO>();
                    services.AddTransient<AuctionUpdateDTO>();


                    services.AddTransient<Home>();
                    services.AddTransient<SubastaAbiertas>();
                    services.AddTransient<Menu>();
                    services.AddTransient<ListaProductos>();
                    services.AddTransient<FiltroSubasta>();
                    services.AddTransient<Editar>();
                    services.AddTransient<CrearSubastaForm>();
                    services.AddTransient<ListaDeOferentes>();
                    services.AddTransient<InformeGanancias>();
                    services.AddTransient<InformeProductosVendidos>();
                    services.AddTransient<InformeProductosSinOferta>();
                    services.AddTransient<AprobacionDeProductos>();
                    services.AddTransient<Register>();
                    services.AddTransient<Login>();
                });

    }
    }
}