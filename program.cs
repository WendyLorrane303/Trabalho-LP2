using System;

namespace Loja_do_Herry
{
    class Program
    {
        static void Main(string[] args)
        {
            itens varinha = new itens("varinha de sabugueiro","Varinhas"," A Varinha das Varinhas",10);
            itens livro = new itens("Livro magico","Livros"," Livro de feitiços",20);
            itens Vassoura = new itens("vassoura Nimbus 2000","Vassouras"," Vassouras de Corrida ",50);

            varinha.imprimirItem();
            livro.imprimirItem();
            Vassoura.imprimirItem();

            personagem Herry = new personagem("Herry Potter", "Grifinória", "Presentir oque vai acontecer");
            personagem Tom = new personagem("Tom Riddle","Sonserina", "Enganar as Pessoas");
            personagem Cedrico = new personagem("Cedrico Diggory.","Lufa Lufa", "Feitiços");
            personagem Mandy  = new personagem("Mandy Brocklehurst", "Corvinal", "Ser Rapida");
            
            Herry.compraritem(varinha);
            Herry.compraritem(Vassoura);
     
            Tom.compraritem(livro);
        
            Cedrico.compraritem(varinha);
            Cedrico.compraritem(livro);
           
            Mandy.compraritem(Vassoura);
           
            Herry.Implimirpersonagem();
            Tom.Implimirpersonagem();
            Cedrico.Implimirpersonagem();
            Mandy.Implimirpersonagem();

            Console.ReadKey();
        }
       
    }
}
