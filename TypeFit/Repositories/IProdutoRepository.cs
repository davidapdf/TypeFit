using System.Collections.Generic;
using System.Threading.Tasks;
using TypeFit.Models;
using TypeFit.Repositories;

namespace TypeFit
{
    public interface IProdutoRepository
    {
        Task SaveProdutos(List<ProdutosInicializer> produtos);
        Task<IList<Produto>> GetProdutos();
    }
}