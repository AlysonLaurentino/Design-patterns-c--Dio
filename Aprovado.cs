using System;
namespace Design_Patterns
{
    public class Aprovado : EstadoDeUmOrcamento
    {
         public void AplicaDescontoExtra(Orcamento orcamento) 
    {
        orcamento.Valor -= orcamento.Valor * 0.02;
    }

    public void Aprova(Orcamento orcamento) 
    {
    
        throw new Exception("Orçamento já está em estado de aprovação");
    }

    public void Reprova(Orcamento orcamento) 
    {
        throw new Exception("Orçamento está em estado de aprovação e não pode ser reprovado");
    }

    public void Finaliza(Orcamento orcamento) 
    {
        orcamento.EstadoAtual = new Finalizado();
    }

    }
}