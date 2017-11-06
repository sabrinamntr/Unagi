using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unagi.Estrutura;
namespace Unagi
{
    class AlbumMusical : Midia, ICatalogo
    {
        Lista Album = new Lista();  //add as musicas desse album na lista(criar metodo)


        string artista;

        private int anoDeLancamento;
        public int AnoDeLancamento { get => anoDeLancamento; set => anoDeLancamento = value; }
        public string Artista { get => artista; set => artista = value; }

        public override void Alterar()
        {
            throw new NotImplementedException();
        }

        public override void Consultar(int id)
        {
            throw new NotImplementedException();
        }

        public override void Excluir()
        {
            throw new NotImplementedException();
        }

        public override void Incluir()
        {
            throw new NotImplementedException();
        }
    }
}
