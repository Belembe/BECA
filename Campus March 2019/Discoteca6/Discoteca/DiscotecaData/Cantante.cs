using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscotecaData
{
    public class Cantante
    {
        int idCantante;
        string nombre, nacionalidad;
        List<Disco> discos = new List<Disco>();

        public int IdCantante { get => idCantante; set => idCantante = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Nacionalidad { get => nacionalidad; set => nacionalidad = value; }
        public List<Disco> Discos { get => discos; set => discos = value; }

        public Cantante(int idCantante, string nombre, string nacionalidad, List<Disco> discos)
        {
            this.idCantante = idCantante;
            this.nombre = nombre;
            this.nacionalidad = nacionalidad;
            this.discos = discos;



            Database.dtsDiscoteca.PistaDataTable table = new Database.dtsDiscoteca.PistaDataTable();
            table.Rows.Add(idCantante,nombre,nacionalidad,discos);
        }

        public Cantante()
        {

        }


    }
}
