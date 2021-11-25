using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inmobiliaria.Presentacion;

namespace Inmobiliaria
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
            Application.Run(new FrmInicio());
        }
        private static void DespliegueControladoDeErroresOtroshilos(object sender, UnhandledExceptionEventArgs args)
        {
            Exception excepcion = (Exception)args.ExceptionObject;
            //MessageBox.Show($"Ha ocurrido un error:{e.Message}{System.Environment.NewLine}Origen del error:{e.Source}");
            var frmError = new FrmError(excepcion);
            frmError.ShowDialog();
        }
        private static void DespliegueControladoDeErroresHiloPrincipal(object sender, ThreadExceptionEventArgs e)
        {
            //MessageBox.Show($"Ha ocurrido un error:{e.Exception.Message}{System.Environment.NewLine}Origen del error:{e.Exception.Source}");
            var frmError = new FrmError(e.Exception);
            frmError.ShowDialog();

        }
    }
}
