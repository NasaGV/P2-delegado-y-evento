using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_parcial2_POO.clase
{
    public class ConstructorMinecraft
    {
        public delegate void BloqueConstruidoEventHandler(string tipoBloque);

        public event BloqueConstruidoEventHandler BloqueConstruido;

        public int BloquesConstruidos { get; private set; }

        public ConstructorMinecraft()
        {
            BloquesConstruidos = 0; 
        }

        public void ConstruirBloque(string tipoBloque)
        {
            BloqueConstruido?.Invoke(tipoBloque);
            BloquesConstruidos++; // Incrementar el contador de bloques construidos
        }

        public void DestruirBloque()
        {
            if (BloquesConstruidos > 0)
            {
                BloquesConstruidos--; // Decrementar el contador de bloques construidos solo si hay bloques para destruir
            }
        }
    }
}
