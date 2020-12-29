using System;

namespace Design_Patterns
{
    class Program
    {
        static void Main(string[] args)
        {

             Item item1 = new Item("Pedreiro"); 
             Orcamento reforma = new Orcamento(500.0);

             

        reforma.AplicaDescontoExtra();
        Console.WriteLine(reforma.Valor); 
        reforma.Aprova(); 

        reforma.AplicaDescontoExtra();
        Console.WriteLine(reforma.Valor); 

        reforma.Finaliza();
        }
    }
}
