using EjercicioMandaloriano_Unidad8_SGEMP.Models.entidades;

namespace Ejercicio3_Unidad8_SGEMP.Capa_DAL
{
    public class MisionesDAL
    {
        private static List<clsMision> listadoMisionesConDescripcion = new List<clsMision>();

        public static List<clsMision> getListadoSinDescripcion()
        {
            if (listadoMisionesConDescripcion.Count == 0)
            {
                listadoMisionesConDescripcion.Add(new clsMision("Rescate de Baby Yoda", "Debes hacerte con Grogu y llevárselo a Luke SkyWalker para su entrenamiento.\r\nRecompensa: 5000 créditos\r\n"));
                listadoMisionesConDescripcion.Add(new clsMision("Recuperar armadura Beskar", "La armadura de Bershka ha sido robada. Debes encontrarla.\r\nREcompensa: 2000 créditos\r\nEl Beskar fue utilizado en gran medida por los mandalorianos como parte de su iniciativa colectiva para el avance tecnológico. Se vieron obligados durante muchos años a enfrentarse a los Jedi en luchas de poder, pero no pudieron explicar cómo los Jedi usaron la Fuerza para frustrarlos. El Beskar ayudó a la causa, e incluso a defenderse de un golpe indirecto de un sable de luz. \r\n"));
                listadoMisionesConDescripcion.Add(new clsMision("Planeta Sorgon", "Debes llevar a un niño de vuelta a su planeta natal “Sorgon”.\r\nRecompensa: 500 créditos.\r\n"));
                listadoMisionesConDescripcion.Add(new clsMision("Renacuajos", "Debes llevar a una Dama Rana y sus huevos de Tatooine a la luna del estuario Trask, donde su esposo fertilizará los huevos.\r\nRecompensa: 500 créditos\r\n"));
            }
            List<clsMision> listadoMisiones = listadoMisionesConDescripcion.Select(mision => new clsMision(mision.Titulo,"")).ToList();//lambda que usa el método select este método actua similar a los selects de toda la vida de sql pero con listas es decir te coge los elementos
                                                                                                                                       //de una lista y tu operas con ellos, en este caso seleccionamos cada mision de la lista y construimos un nuevo objetos clsMision pero sin descripcion para la lista
                                                                                                                                       // nueva que vamos a tener sin descripciones, luego ponemos .ToList para convertis el flujo al lista y asignarlo a esa nueva lista de misiones sin descripcion, si no lo entiendes dile
                                                                                                                                       //que el autor es @juanjomz_ alias MR.LAMBDA
            return listadoMisiones;
        }
        public static String getDescripcionMision(String tituloMision)
        {
            return listadoMisionesConDescripcion.Find(mision => mision.Titulo.Equals(tituloMision)).Descripcion;//lambda que usa el método Find el cual encuentra un elemento de la lista que cumpla con la condición que pongas en este caso que el titulo de la mision
                                                                                                           //sea igual al del titulo que le pasamos por parámetros, de esta forma como la lista no contiene dos elementos con el mismo título el método find devolverá aquel elemento
                                                                                                           //que cumpla con esa condición, luego ponemos .Titulo para obtener el atributo título de dicho elemento que nos entrega el método Find, ya que lo que nos interesa es solo la cadena
                                                                                                         
        }

    }
}
