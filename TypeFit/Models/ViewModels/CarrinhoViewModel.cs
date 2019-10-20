using System.Collections.Generic;
using System.Linq;
using TypeFit.Models;

namespace TypeFit.Repositories
{
    public class CarrinhoViewModel
    {
        public CarrinhoViewModel(IList<ItemPedido> itens)
        {
            Itens = itens;
        }

        public IList<ItemPedido> Itens { get; }

        public decimal Total => Itens.Sum(i => i.Preco);
    }
}