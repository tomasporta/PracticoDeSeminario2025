using Practico.Entidades;

namespace Practico.Windows
{
    public partial class FrmFormasDePagoAE : Form
    {
        private FormaDePago? formaDePago;

        public FrmFormasDePagoAE()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (formaDePago is not null)
            {
                txtDescripcion.Text = formaDePago.Descripcion;
            }
        }

        public FormaDePago? GetFormaDePago()
        {
            return formaDePago;
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void bOK_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (formaDePago is null)
                {
                    formaDePago = new FormaDePago();
                }

                formaDePago.Descripcion = txtDescripcion.Text.Trim();
                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();

            if (string.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                valido = false;
                errorProvider1.SetError(txtDescripcion, "La descripción es obligatoria");
            }

            return valido;
        }

        public void SetFormaDePago(FormaDePago forma)
        {
            formaDePago = forma;
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //no se como sacarlo sin que me rompa el diseño
        }
    }
}
