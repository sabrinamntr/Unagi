using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unagi.Estrutura;

namespace Unagi
{
    public partial class frLista : Form
    {
        public frLista()
        {
            InitializeComponent();
        }
        public frLista(Lista L)
        {
            InitializeComponent();
            setLista(L);
        }
        public void setLista(Lista L)
        {
            listaMidia.Columns.Add("ID", 50);
            listaMidia.Columns.Add("Descrição", 50);
            foreach (Midia M in L)
            {
                ListViewItem itm;
                string[] arr = { M.Id.ToString(), M.Descricao };
                itm = new ListViewItem(arr);

            }
        }
        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
