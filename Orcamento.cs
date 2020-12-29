using System;
using System.Collections.Generic;

namespace Design_Patterns
{
    public class Orcamento
    {

    public IList <Item> itens { get; set; }

     public double Valor { get; set; }
    public EstadoDeUmOrcamento EstadoAtual { get; set; } 


    public Orcamento(double valor) 
    {
        this.Valor=valor;
        this.EstadoAtual = new EmAprovacao();
        this.itens = new List<Item>();
    }

    public void adicionaItem (Item item){
        
        itens.Add(item);
    }

    public void AplicaDescontoExtra() 
    {
        EstadoAtual.AplicaDescontoExtra(this);
    }

    public void Aprova() 
    {
        EstadoAtual.Aprova(this);
    }

    public void Reprova() 
    {
        EstadoAtual.Reprova(this);
    }

    public void Finaliza() 
    {
        EstadoAtual.Finaliza(this);
    }
        
    }
}