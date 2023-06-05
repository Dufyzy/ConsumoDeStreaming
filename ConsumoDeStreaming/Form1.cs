using System.Windows.Forms;


namespace ConsumoDeStreaming
{

    public partial class Form1 : Form
    {

        string linea;
        string[] arreglo = new string[11];
        char[] separador = { ',' };
        ClaseManejadora cm;


        public Form1()
        {
            InitializeComponent();
        }

        private void btnArchivo_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileD.ShowDialog() == DialogResult.OK)
                {
                    label1.Text = "Ruta: ";
                    lblRuta.Text = openFileD.FileName;
                    lblCreacion.Text = "Fecha de creacion: " + File.GetCreationTime(lblRuta.Text).ToString();
                    lblAcceso.Text = "Ultima fecha de acceso: " + File.GetLastAccessTime(lblRuta.Text).ToString();
                    lblModificacion.Text = "Ultima modificaciones del archivo: " + File.GetLastWriteTime(lblRuta.Text).ToString();
                    StreamReader sr = new StreamReader(lblRuta.Text);
                    cm = new ClaseManejadora();
                    int i = 0;
                    dgv1.Rows.Clear();


                    while ((linea = sr.ReadLine()) != null)
                    {
                        arreglo = linea.Split(separador);
                        dgv1.Rows.Add(arreglo);
                        cm.AgregarStreaming(new Streaming(arreglo[0], int.Parse(arreglo[1]), arreglo[2], arreglo[3], arreglo[4], int.Parse(arreglo[5]), arreglo[6], arreglo[7], arreglo[8], double.Parse(arreglo[9]), double.Parse(arreglo[10])));
                        dgv1.Rows[i].Cells[11].Value = cm.ListaStreaming[i].PorcentajeVisto().ToString("0.00");

                        i++;
                    }

                    sr.Close();
                    btnForm2.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnForm2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(cm);
            form2.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gracias por utilizar el programa\r\nHecho por:\r\nLopez Verdugo Fernando\r\nMiranda Camberos Exon", "CREDITOS");
            this.Close();
        }
    }
}