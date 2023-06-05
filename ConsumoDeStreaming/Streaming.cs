using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumoDeStreaming
{
    public class Streaming
    {
        string cuenta;
        int edad;
        string pais;
        string productoVisto; // Nombre del producto
        string tipoDeProducto; // Serie o Película
        int anioEstreno; 
        string genero; // Género de la serie o película
        string director; // Director de la serie o película
        string clasificacion;
        double duracion; // Duración en minutos
        double minutosVistos;

        public Streaming(string cuenta, int edad, string pais, string productoVisto, string tipoDeProducto, int añoDeEstreno, string genero, string director, string clasificacion, double duracion, double minutosVistos)
        {
            this.cuenta = cuenta;
            this.edad = edad;
            this.pais = pais;
            this.productoVisto = productoVisto;
            this.tipoDeProducto = tipoDeProducto;
            this.anioEstreno = añoDeEstreno;
            this.genero = genero;
            this.director = director;
            this.clasificacion = clasificacion;
            this.duracion = duracion;
            this.minutosVistos = minutosVistos;
        }

        public string Cuenta { get => cuenta; set => cuenta = value; }
        public int Edad { get => edad; set => edad = value; }
        public string Pais { get => pais; set => pais = value; }
        public string ProductoVisto { get => productoVisto; set => productoVisto = value; }
        public string TipoDeProducto { get => tipoDeProducto; set => tipoDeProducto = value; }
        public int AnioEstreno { get => anioEstreno; set => anioEstreno = value; }
        public string Genero { get => genero; set => genero = value; }
        public string Director { get => director; set => director = value; }
        public string Clasificacion { get => clasificacion; set => clasificacion = value; }
        public double Duracion { get => duracion; set => duracion = value; }
        public double MinutosVistos { get => minutosVistos; set => minutosVistos = value; }

        public double PorcentajeVisto()
        {
            return minutosVistos / duracion * 100;
        }
    }
}
