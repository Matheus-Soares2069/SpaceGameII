using System;
using System.Collections.Generic;
using System.Text;

namespace Arvore
{
    class MinhaArvore
    {
        public MinhaArvore(MinhaArvore esquerda, int dados, MinhaArvore direita)
        {
            Esquerda = esquerda;
            Dados = dados;
            Direita = direita;
        }

        public MinhaArvore Esquerda{get; set;}
        public int Dados { get; set; }
        public MinhaArvore Direita { get; set; }
    }
}
