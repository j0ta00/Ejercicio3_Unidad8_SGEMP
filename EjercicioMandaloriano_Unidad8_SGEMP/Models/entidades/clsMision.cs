using System.Xml.Linq;

namespace EjercicioMandaloriano_Unidad8_SGEMP.Models.entidades
{
    public class clsMision
    {
        #region atributos privados
        private string titulo;
        private string descripcion;
        #endregion

        public clsMision(string titulo, string descripcion)
        {
            this.titulo = titulo;
            this.descripcion = descripcion;
        }
        public string Titulo { get => titulo; set => titulo = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
    }
}
