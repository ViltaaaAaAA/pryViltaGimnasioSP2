namespace pryViltaGimnasioSP2
{
    public partial class FrmInscripcion : Form
    {
        // Constantes del negocio
        private const decimal PRECIO_MUSCULACION = 15000m;
        private const decimal PRECIO_FUNCIONAL = 18000m;
        private const decimal PRECIO_NATACION = 22000m;
        private const decimal PRECIO_CASILLERO = 3000m;
        private const int EDAD_MINIMA = 14;
        private const decimal DESCUENTO_EFECTIVO = 0.10m;
        private const decimal RECARGO_3_CUOTAS = 0.10m;
        private const decimal RECARGO_6_CUOTAS = 0.20m;

        // Estructura SOCIO
        public struct SOCIO
        {
            public string nombre;
            public int edad;
            public string categoria;
            public string plan;
            public string horario;
            public int meses;
            public string formaPago;
            public decimal total;
            public decimal valorCuota;
        }
        public FrmInscripcion()
        {
            InitializeComponent();

        }

        private void FrmInscripcion_Load(object sender, EventArgs e)
        {

        }
    }
}




