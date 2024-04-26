using Proyecto_parcial2_POO.clase;

namespace Proyecto_parcial2_POO
{
    public partial class Form1 : Form
    {
        private ConstructorMinecraft constructor;

        public Form1()
        {
            InitializeComponent();
            constructor = new ConstructorMinecraft();
            constructor.BloqueConstruido += MetodoManejadorBloqueConstruido;
            ActualizarContadorBloques();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            constructor.ConstruirBloque("Tierra");
            ActualizarContadorBloques(); 
        }

        private void ActualizarContadorBloques()
        {
            
            label1.Text = $"Bloques construidos: {constructor.BloquesConstruidos}";
        }

        private void MetodoManejadorBloqueConstruido(string tipoBloque)
        {
            
            label2.Text = $"Se ha construido un bloque de {tipoBloque} en Minecraft.";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            constructor.DestruirBloque();
            ActualizarContadorBloques();
        }
    }

}
