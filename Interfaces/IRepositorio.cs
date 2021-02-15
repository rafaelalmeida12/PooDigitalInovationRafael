using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POODigitalInovationRafael.Interfaces
{
    public interface IRepositorio<T> where T : class
    {
        List<T> Lista();
        T BuscarPorId(int Id);
        void Adicionar(T entidade);
        void Excluir(int Id);
        void Atualizar(int Id, T entidade);
        int ProximoId();
    }
}
