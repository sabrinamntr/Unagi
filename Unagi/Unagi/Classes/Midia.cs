using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Unagi
{
    public abstract class Midia
    {
        private int id;
        string descricao;

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Descricao
        {
            get
            {
                return descricao;
            }

            set
            {
                descricao = value;
            }
        }

        public abstract void Incluir();

        public abstract void Alterar();

        public abstract void Excluir();

        public abstract void Consultar(int id);
    }
}

