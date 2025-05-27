using Bombones2025.Windows.Helpers; 
using Practico.Entidades;
using Practico.Servicios; 

namespace Practico.Windows
{
    public partial class FrmFormaDePago : Form
    {
        private readonly FormaDePagoServicio _servicio;

        public FrmFormaDePago()
        {
            InitializeComponent();
            _servicio = new FormaDePagoServicio(); 
        }

        private void FrmFormaDePago_Load(object sender, EventArgs e)
        {
            CargarDatosEnGrilla();
        }

        private void tsbActualizar_Click(object sender, EventArgs e)
        {
            CargarDatosEnGrilla();
        }

        private void tsbBorrar_Click(object sender, EventArgs e)
        {
            if (dgvFormasDePago.SelectedRows.Count == 0)
                return;

            var fila = dgvFormasDePago.SelectedRows[0];
            var forma = (FormaDePago)fila.Tag!;

            DialogResult dr = MessageBox.Show($"¿Seguro que querés eliminar la forma '{forma.Descripcion}'?",
                "Confirmar borrado", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dr == DialogResult.Yes)
            {
                try
                {
                    _servicio.Borrar(forma.FormaDePagoId);
                    CargarDatosEnGrilla();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al borrar: " + ex.Message);
                }
            }
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (dgvFormasDePago.SelectedRows.Count == 0)
                return;

            var fila = dgvFormasDePago.SelectedRows[0];
            var forma = (FormaDePago)fila.Tag!;

            string nuevaDescripcion = Microsoft.VisualBasic.Interaction.InputBox(
                "Editar descripción:", "Editar Forma de Pago", forma.Descripcion);

            if (!string.IsNullOrWhiteSpace(nuevaDescripcion))
            {
                forma.Descripcion = nuevaDescripcion;

                try
                {
                    _servicio.Guardar(forma);
                    CargarDatosEnGrilla();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al editar: " + ex.Message);
                }
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            string descripcion = Microsoft.VisualBasic.Interaction.InputBox(
                "Ingrese la descripción de la nueva forma de pago:", "Agregar Forma de Pago", "");

            if (!string.IsNullOrWhiteSpace(descripcion))
            {
                try
                {
                    var nuevaForma = new FormaDePago
                    {
                        Descripcion = descripcion
                    };

                    _servicio.Guardar(nuevaForma);
                    CargarDatosEnGrilla();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al agregar: " + ex.Message);
                }
            }
        }

        private void CargarDatosEnGrilla()
        {
            GridHelper.LimpiarGrilla(dgvFormasDePago);

            List<FormaDePago> lista;

            try
            {
                lista = _servicio.GetLista();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message);
                return;
            }

            foreach (var forma in lista)
            {
                var r = GridHelper.ConstruirFila(dgvFormasDePago);
                GridHelper.SetearFila(r, forma);
                GridHelper.AgregarFila(r, dgvFormasDePago);
            }
        }
    }
}
