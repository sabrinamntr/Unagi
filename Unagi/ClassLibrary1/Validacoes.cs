using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca
{
    static class Validacoes
    {

    }

    namespace Estrutura
    {
        public class NodoLista
        {
            public object Dado { get; set; }
            public NodoLista Proximo { get; set; }
            /// <summary>
            /// Construtor sem parâmetros
            /// </summary>
            public NodoLista()
            {
                Dado = null;
                Proximo = null;
            }
        }
        public class Lista
        {

            NodoLista primeiro = null; // ponteiro para o primeiro elemento da lista
            int qtde = 0;
            /// <summary>
            /// Método para inserir um valor na lista
            /// </summary>
            /// <param name="anterior">o NodoLista que será o anterior ao NodoLista inserido.
            /// Se o novo NodoLista for o primeiro, passe null</param>
            /// <param name="valor">o valor a ser inserido</param>
            private void InserirNaPosicao(NodoLista anterior, object obj)
            {
                NodoLista novo = new NodoLista();
                novo.Dado = obj;
                if (anterior == null)
                {
                    if (qtde == 0)
                        primeiro = novo;
                    else
                    {
                        novo.Proximo = primeiro;
                        primeiro = novo;
                    }
                }
                else
                {
                    novo.Proximo = anterior.Proximo;
                    anterior.Proximo = novo;
                }
                qtde++;
            }
            /// <summary>
            /// Insere um valor no início da lista
            /// </summary>
            /// <param name="valor"></param>
            public void InserirNoInicio(object obj)
            {
                InserirNaPosicao(null, obj);
            }
            /// <summary>
            /// Insere um valor no final da lista
            /// </summary>
            /// <param name="valor"></param>
            public void InserirNoFim(object obj)
            {
                if (qtde == 0)
                    InserirNoInicio(obj);
                else
                {
                    NodoLista aux = primeiro;
                    while (aux.Proximo != null)
                        aux = aux.Proximo;
                    InserirNaPosicao(aux, obj);
                }
            }
            /// <summary>
            /// Insere em uma posição, iniciando do 0
            /// </summary>
            /// <param name="obj">valor</param>
            /// <param name="posicao">posicao iniciando do 1</param>
            public void InserirNaPosicao(object obj, int posicao)
            {
                if (posicao > qtde || posicao < 0)
                    throw new Exception("Não é possível inserir.");
                if (posicao == 0)
                    InserirNoInicio(obj);
                else
                {
                    //descobre qual é o NodoLista anterior ao que será incluído
                    NodoLista aux = primeiro;
                    for (int i = 1; i < posicao; i++)
                        aux = aux.Proximo;
                    InserirNaPosicao(aux, obj);
                }
            }
            /// <summary>
            /// Remove um elemento da lista com base em sua posição, que inicia
            /// do zero
            /// </summary>
            /// <param name="posicao">posição</param>
            public void RemoverDaPosicao(int posicao)
            {
                if (posicao >= qtde || posicao < 0 || qtde == 0)
                    throw new Exception("Não é possível remover.");
                if (posicao == 0)
                    primeiro = primeiro.Proximo;
                else
                {
                    //descobre qual é o NodoLista anterior que será excluido
                    NodoLista aux = primeiro;
                    for (int i = 1; i < posicao; i++)
                        aux = aux.Proximo;
                    aux.Proximo = aux.Proximo.Proximo;
                }
                qtde--;
            }
        }
    }
}
