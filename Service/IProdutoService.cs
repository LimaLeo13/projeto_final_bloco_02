using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using farmacia.Model;

namespace E_commerceFarmacia.Service
{
    public interface IProdutoService
    {
        Task<IEnumerable<Produto>> GetAll();
        Task<Produto?> GetById(long id);
        Task<IEnumerable<Produto>> GetByNome(string nome);
        Task<Produto?> Create(Produto produto);
        Task<Produto?> Update(Produto produto);
        Task Delete(Produto produto);
    }


}
