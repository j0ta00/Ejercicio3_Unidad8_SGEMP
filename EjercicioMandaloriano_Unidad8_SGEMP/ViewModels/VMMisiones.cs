using Ejercicio3_Unidad8_SGEMP.Capa_DAL;
using EjercicioMandaloriano_Unidad8_SGEMP.Models.entidades;

namespace EjercicioMandaloriano_Unidad8_SGEMP.ViewModels { 

    public class VMMisiones
    {
        public List<clsMision> getListadoSinDescripcion()
        {
            return MisionesDAL.getListadoSinDescripcion();
        }
        public String getDescripcionMision(String tituloMision)
        {

            return MisionesDAL.getDescripcionMision(tituloMision);
        }

    }
}
