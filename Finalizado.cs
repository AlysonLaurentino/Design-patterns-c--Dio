using System;
namespace Design_Patterns
{
    public class Finalizado : EstadoDeUmOrcamento
    {

          public void AplicaDescontoExtra(Orcamento orcamento) 
    {
         throw new Exception ("Orçamentos finalizados não recebem desconto extra!");
    }

     public void Aprova(Orcamento orcamento) 
    {
    
        throw new Exception("Orçamento já está Finalizado");
    }

    public void Reprova(Orcamento orcamento) 
    {
        throw new Exception("Orçamento já está Finalizado");
    }

    public void Finaliza(Orcamento orcamento) 
    {
        throw new Exception("Orçamento já está Finalizado");
    }
        
    }
}