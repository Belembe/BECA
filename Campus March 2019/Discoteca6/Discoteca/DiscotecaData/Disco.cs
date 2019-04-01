using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscotecaData
{
    public class Disco
    {

        int idDisco;
        Cantante cantante;
        string estilo, discografia, titulo;
        int publicacion;
        List<Pista> pistas = new List<Pista>();

        public int IdDisco { get => idDisco; set => idDisco = value; }
        public string Estilo { get => estilo; set => estilo = value; }
        public string Discografia { get => discografia; set => discografia = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public int Publicacion { get => publicacion; set => publicacion = value; }
        public List<Pista> Pistas { get => pistas; set => pistas = value; }
        public Cantante Cantante { get => cantante; set => cantante = value; }

        public Disco(int idDisco, Cantante cantante, string estilo, string discografia, string titulo, int publicacion, List<Pista> pistas)
        {
            this.idDisco = idDisco;
            this.Cantante = cantante;
            this.estilo = estilo;
            this.discografia = discografia;
            this.titulo = titulo;
            this.publicacion = publicacion;
            this.pistas = pistas;



            Database.dtsDiscoteca.PistaDataTable table = new Database.dtsDiscoteca.PistaDataTable();
            table.Rows.Add(idDisco, cantante, estilo, discografia, titulo, publicacion, pistas);

        }



        public Disco()
        {

        }
    }
}
