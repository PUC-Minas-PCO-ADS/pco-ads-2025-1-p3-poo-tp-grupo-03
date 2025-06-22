using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeEnergia.Repositories
{
    internal interface IRepositorio<T>
    {
        void Adicionar(T obj);
        T BuscarPorId(int id);
        List<T> ListarTodos();
        void SalvarArquivo();
        void CarregarArquivo();
    }
}
