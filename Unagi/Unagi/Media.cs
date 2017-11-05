using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Unagi
{
    class Media
    {
        public bool checkIfExists(string path)
        {
            return File.Exists(path);            
        }
        public void addMidia()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            string path = Path.GetFullPath(ofd.FileName);            

        }
        public void Salva(string dado)
        {
            if (!File.Exists("Midia.txt"))
            {
                File.Create("Midia.txt");
            }
            File.WriteAllText("Midia.txt",dado);
        }
    }
}

