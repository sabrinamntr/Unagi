using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unagi.Formularios;
using Unagi.Estrutura;
using Unagi.Metodos;

namespace Unagi
{
    static class Program
    {
        #region Globais
        public static Estrutura.Lista tMidias = new Estrutura.Lista();

        #endregion
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frPrincipal());
        }
    }
}
