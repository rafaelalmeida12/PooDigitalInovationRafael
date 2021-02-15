using POODigitalInovationRafael.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POODigitalInovationRafael.Models
{
    public class SerieRepositorio : IRepositorio<Serie>
    {
        private List<Serie> listaSerie = new List<Serie>();
        public void Adicionar(Serie obj)
        {
            listaSerie.Add(obj);
        }

        public void Atualizar(int Id, Serie entidade)
        {
            listaSerie[Id] = entidade;
        }

        public Serie BuscarPorId(int Id)
        {
            return listaSerie[Id];
        }

        public void Excluir(int Id)
        {
            listaSerie[Id].Excluir();
        }

        public List<Serie> Lista()
        {
            return listaSerie;
        }

        public int ProximoId()
        {
            return listaSerie.Count;
        }
    }
}
