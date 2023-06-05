using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumoDeStreaming
{
    public class ClaseManejadora
    {
        List<Streaming> listaStreaming = new List<Streaming>();

        public ClaseManejadora() { }

        public void AgregarStreaming(Streaming streaming)
        {
            listaStreaming.Add(streaming);
        }

        public List<Streaming> ListaStreaming { get => listaStreaming; set => listaStreaming = value; }

    }
}
