using System;
using System.Collections.Generic;
using System.Text;

namespace Loja_do_Herry
{
    class personagem
    {
        public string Nome;
        public string Casa;
        public string Habilidade;
        public int Dolla;
        public List<itens> inventario;

        public personagem(string nome, string casa, string habilidade)
        {
            this.Nome = nome;
            this.Casa = casa;
            this.Habilidade = habilidade;
            this.Dolla = 200;
            this.inventario = new List<itens>();


        }

        public void Implimirpersonagem()
        {
            Console.WriteLine("nome: {0}", this.Nome);
            Console.WriteLine("Casa: {0}", this.Casa);
            Console.WriteLine("habilidade: {0}", this.Habilidade);
            Console.WriteLine("dolla:{0}", this.Dolla);
            Console.Write("inventario: [");
            foreach (var item in inventario)
            {
                Console.WriteLine("{0}\t", item.Nome);
            }
            Console.WriteLine("]");
            Console.WriteLine("================================");
        }

        public void pegaritem(itens itens)
        {
            this.inventario.Add(itens);
        }
        public void compraritem(itens itens)
        {
            if (this.Dolla > itens.Dollar)
            {
                this.Dolla = this.Dolla - itens.Dollar;
                this.pegaritem(itens);

            }
            else
            {
                Console.WriteLine("Bruxo Sem Dolla");
            }
        }    
    }
}
    
