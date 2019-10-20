using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TypeFit.Models;

namespace TypeFit.Repositories
{
    public interface IPedidoRepository
    {
        Task<Pedido> GetPedido();
        Task AddItem(string codigo);
        Task<UpdateQuantidadeResponse> UpdateQuantidade(ItemPedido itemPedido);
        Task<Pedido> UpdateCadastro(Cadastro cadastro);
    }
    public class PedidoRepository
    {
    }
}
