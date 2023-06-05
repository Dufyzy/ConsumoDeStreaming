using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsumoDeStreaming
{

    public partial class Form2 : Form
    {
        int starters = 0, watchers = 0, completers = 0;                                         //Tipo de usuarios
        int terminaPelicula = 0, terminaSerie = 0, noTerminaPelicula = 0, noTerminaSerie = 0;   //Para determinar si termina o no el producto
        int pelicula = 0, serie = 0;                                                            //Para determinar porcentaje de consumo entre pelicula o serie
        ClaseManejadora cm = new ClaseManejadora();

        public Form2(ClaseManejadora cm)
        {
            InitializeComponent();
            this.cm = cm;
            Usuarios();
        }


        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            Usuarios();
        }
        private void btnTermina_Click(object sender, EventArgs e)
        {
            terminaPelicula = 0;
            terminaSerie = 0;
            noTerminaPelicula = 0;
            noTerminaSerie = 0;

            for (int i = 0; i < cm.ListaStreaming.Count; i++)
            {
                //Tipo de producto y si lo termino o no
                if (cm.ListaStreaming[i].TipoDeProducto == "PELICULA")
                {
                    if (cm.ListaStreaming[i].PorcentajeVisto() == 100)
                    {
                        terminaPelicula++;
                    }
                    else
                    {
                        noTerminaPelicula++;
                    }
                }
                else
                {
                    if (cm.ListaStreaming[i].PorcentajeVisto() == 100)
                    {
                        terminaSerie++;
                    }
                    else
                    {
                        noTerminaSerie++;
                    }
                }
            }
            Dictionary<string, int> datosEtiquetas = new Dictionary<string, int>();
            datosEtiquetas.Add("Termina Pelicula", terminaPelicula);
            datosEtiquetas.Add("Termina Serie", terminaSerie);
            datosEtiquetas.Add("No termina Pelicula", noTerminaPelicula);
            datosEtiquetas.Add("No termina Serie", noTerminaSerie);

            Dibujar(datosEtiquetas, panel1);
        }
        private void btnConsumo_Click(object sender, EventArgs e)
        {
            pelicula = 0;
            serie = 0;
            for (int i = 0; i < cm.ListaStreaming.Count; i++)
            {
                //Tipo de producto
                if (cm.ListaStreaming[i].TipoDeProducto == "PELICULA")
                {
                    pelicula++;
                }
                else
                {
                    serie++;
                }
            }
            Dictionary<string, int> datosEtiquetas = new Dictionary<string, int>();
            datosEtiquetas.Add("Pelicula", pelicula);
            datosEtiquetas.Add("Serie", serie);
            Dibujar(datosEtiquetas, panel1);
        }
        private void btnGenero_Click(object sender, EventArgs e)
        {
            Dictionary<string, int> contador = new Dictionary<string, int>();

            for (int i = 0; i < cm.ListaStreaming.Count; i++)
            {
                if (contador.ContainsKey(cm.ListaStreaming[i].Genero))
                {
                    contador[cm.ListaStreaming[i].Genero]++;
                }
                else
                {
                    contador.Add(cm.ListaStreaming[i].Genero, 1);
                }
            }
            Dibujar(contador, panel1);


            //PorcentajeCondumoGenero();
        }
        private void btnEstreno_Click(object sender, EventArgs e)
        {
            Dictionary<string, int> contador = new Dictionary<string, int>();

            for (int i = 0; i < cm.ListaStreaming.Count; i++)
            {
                if (contador.ContainsKey(cm.ListaStreaming[i].AnioEstreno.ToString()))
                {
                    contador[cm.ListaStreaming[i].AnioEstreno.ToString()]++;
                }
                else
                {
                    contador.Add(cm.ListaStreaming[i].AnioEstreno.ToString(), 1);
                }
            }
            Dibujar(contador, panel1);
        }
        private void btnPais_Click(object sender, EventArgs e)
        {
            Dictionary<string, int> contador = new Dictionary<string, int>();

            for (int i = 0; i < cm.ListaStreaming.Count; i++)
            {
                if (contador.ContainsKey(cm.ListaStreaming[i].Pais))
                {
                    contador[cm.ListaStreaming[i].Pais]++;
                }
                else
                {
                    contador.Add(cm.ListaStreaming[i].Pais, 1);
                }
            }
            Dibujar(contador, panel1);
        }
        private void btnTopPeliculas_Click(object sender, EventArgs e)
        {
            Dictionary<string, int> contador = new Dictionary<string, int>();

            for (int i = 0; i < cm.ListaStreaming.Count; i++)
            {
                if (cm.ListaStreaming[i].TipoDeProducto == "PELICULA")
                {
                    if (contador.ContainsKey(cm.ListaStreaming[i].ProductoVisto))
                    {
                        contador[cm.ListaStreaming[i].ProductoVisto]++;
                    }
                    else
                    {
                        contador.Add(cm.ListaStreaming[i].ProductoVisto, 1);
                    }
                }
            }
            Dibujar(contador, panel1);
        }
        private void btnTopSeries_Click(object sender, EventArgs e)
        {
            Dictionary<string, int> contador = new Dictionary<string, int>();
            for (int i = 0; i < cm.ListaStreaming.Count; i++)
            {
                if (cm.ListaStreaming[i].TipoDeProducto == "SERIE")
                {
                    if (contador.ContainsKey(cm.ListaStreaming[i].ProductoVisto))
                    {
                        contador[cm.ListaStreaming[i].ProductoVisto]++;
                    }
                    else
                    {
                        contador.Add(cm.ListaStreaming[i].ProductoVisto, 1);
                    }
                }
            }
            Dibujar(contador, panel1);
        }

        private void Dibujar(Dictionary<string, int> datosEtiquetas, Panel panel)
        {
            Bitmap bitmap = new Bitmap(panel.Width, panel.Height);
            Graphics g = Graphics.FromImage(bitmap);

            int ancho = 500;
            int alto = 300;
            double maxValor = datosEtiquetas.Values.Max();

            int anchoBarra = ancho / datosEtiquetas.Count;
            int x = 50;

            foreach (var var in datosEtiquetas)
            {
                string etiqueta = var.Key;
                int dato = var.Value;

                int altoBarra = (int)((double)dato / maxValor * alto);
                Rectangle barRect = new Rectangle(x, alto - altoBarra + 50, anchoBarra, altoBarra);

                Color col = GetRandomColor();
                using (SolidBrush brush = new SolidBrush(col))
                {
                    g.FillRectangle(brush, barRect);
                }
                g.DrawRectangle(Pens.Black, barRect);

                double porcentaje = (double)dato / datosEtiquetas.Values.Sum() * 100;

                string porcentajeText = string.Format("{0:F2}%", porcentaje);
                SizeF textSize = g.MeasureString(porcentajeText, Font);
                PointF textLocation = new PointF(barRect.X + (barRect.Width - textSize.Width) / 2, barRect.Y + (barRect.Height - textSize.Height) / 2);
                g.DrawString(porcentajeText, Font, Brushes.Black, textLocation);

                Rectangle textRect = new Rectangle(x, alto + 50, anchoBarra, 20); // Rectángulo para el texto
                g.DrawString(etiqueta, Font, Brushes.Black, textRect, new StringFormat { Alignment = StringAlignment.Center });

                x += anchoBarra + 10;
            }

            panel.BackgroundImage = bitmap;
        }

        private void Usuarios()
        {
            int starters = 0;
            int watchers = 0;
            int completers = 0;

            for (int i = 0; i < cm.ListaStreaming.Count; i++)
            {
                // Tipo de usuario
                double porcentajeVisto = cm.ListaStreaming[i].PorcentajeVisto();
                if (porcentajeVisto <= 10)
                {
                    starters++;
                }
                else if (porcentajeVisto < 90)
                {
                    watchers++;
                }
                else if (porcentajeVisto <= 100)
                {
                    completers++;
                }
            }

            Dictionary<string, int> datosEtiquetas = new Dictionary<string, int>();
            datosEtiquetas.Add("Starters", starters);
            datosEtiquetas.Add("Watchers", watchers);
            datosEtiquetas.Add("Completers", completers);

            Dibujar(datosEtiquetas, panel1);
        }



        private Color GetRandomColor()
        {
            Random randomGen = new Random();
            return Color.FromArgb(randomGen.Next(0, 255), randomGen.Next(0, 255), randomGen.Next(0, 255));
        }


    }
}

