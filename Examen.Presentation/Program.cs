using Autofac;
using Examen.AppCore.IServices;
using Examen.AppCore.Services;
using Examen.Domain.Interfaces;
using Examen.Infraestructure.Repository;
using Examen.Presentation.Formularios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen.Presentation
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var builder = new ContainerBuilder();

            builder.RegisterType<BinaryHistoricalWeatherRepository>().As<IHistoricalWeatherModel>();
            builder.RegisterType<HistoricalWeatherServices>().As<IHistorticalWeatherServices>();

            builder.RegisterType<HttpHistoricalWeatherClient>().As<IHttpHistoricalWeatherClient>();
            builder.RegisterType<HttpHistoricalWeatherServices>().As<IHttpHistoricalWeatherServices>();

            builder.RegisterType<HttpOpenWeatherClient>().As<IHttpOpenWeatherClient>();
            builder.RegisterType<HttpOpenWeatherServices>().As<IHttpOpenWeatherServices>();

            var container = builder.Build();

            Application.Run(new Form1(container.Resolve<IHistorticalWeatherServices>(), container.Resolve<IHttpHistoricalWeatherServices>(), container.Resolve<IHttpOpenWeatherServices>()));
        }
    }
}
