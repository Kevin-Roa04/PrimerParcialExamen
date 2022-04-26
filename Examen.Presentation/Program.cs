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

            builder.RegisterType<BinaryObjetoRepository>().As<IObjetoModel>();
            builder.RegisterType<ObjetoServices>().As<IObjetoServices>();

            var container = builder.Build();

            Application.Run(new Form1(container.Resolve<IObjetoServices>()));
        }
    }
}