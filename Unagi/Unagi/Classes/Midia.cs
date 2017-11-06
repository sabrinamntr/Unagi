using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Unagi
{
    abstract class Midia
    {
        int id;
        string descricao;        

        public abstract void Incluir();

        public abstract void Alterar();

        public abstract void Excluir();

        public abstract void Consultar(int id);
    }
}

