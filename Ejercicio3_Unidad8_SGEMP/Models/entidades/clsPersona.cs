using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Ejercicio3_Unidad8_SGEMP.Models.entidades
{
    public class clsPersona
    {
        #region constructores
        public clsPersona(string nombre, string apellidos, string direccion, string telefono)
        {
            Nombre = nombre;
            Apellidos = apellidos;
            Telefono = telefono;
            Direccion = direccion;
        }
        //Constructor de copia
        public clsPersona(clsPersona persona)
        {
            Nombre = persona.Nombre;
            Apellidos = persona.Apellidos;
            Direccion = persona.Direccion;
            Telefono = persona.Telefono;
        }
        public clsPersona()
        {
            Nombre = "";
            Apellidos = "";
            Direccion = "";
            Telefono = "";
        }
        #endregion

        #region propiedades auto-implementadas

        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        #endregion
    }


}

