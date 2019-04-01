using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscotecaData
{
    public class Pista
    {
        int idPista;
        string titulo;
        Disco disco;
        bool videoclip;
        int duracion;

        public int IdPista { get => idPista; set => idPista = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public Disco Disco { get => disco; set => disco = value; }
        public bool Videoclip { get => videoclip; set => videoclip = value; }
        public int Duracion { get => duracion; set => duracion = value; }

        public Pista(int idPista, string titulo, Disco disco, bool videoclip, int duracion)
        {
            this.idPista = idPista;
            this.titulo = titulo;
            this.disco = disco;
            this.videoclip = videoclip;
            this.duracion = duracion;

            //Manera de relacionar las tablas nuestras con la pista.
            //Aunque se ponga filas, es un solo registro.
            
            Database.dtsDiscoteca.PistaDataTable table = new Database.dtsDiscoteca.PistaDataTable();
            table.Rows.Add(idPista, titulo, disco, videoclip, duracion);

        }

        public Pista()
        {

        }

        

    }
}
