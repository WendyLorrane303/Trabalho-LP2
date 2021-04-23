using System;
using System.Collections.Generic;
using System.Text;

namespace Loja_do_Herry
{
    class itens 
    {
        public string Nome;
        public string Categoria;
        public string Descrição;
        public int Dollar;

        public itens(string nome, string categoria, string descrição, int dollar)
        {
            this.Nome = nome;
            this.Categoria = categoria;
            this.Descrição = descrição;
            this.Dollar = dollar; 
        }

        public void imprimirItem()
        {
            Console.WriteLine("nome: {0}",this.Nome);
            Console.WriteLine("categoria: {0}",this.Categoria);
            Console.WriteLine("descrição: {0}",this.Descrição);
            Console.WriteLine("dollar: {0}",this.Dollar);
            Console.WriteLine("================================");
        }
    }
}
