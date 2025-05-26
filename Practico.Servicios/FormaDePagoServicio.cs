using Practico.Datos;
using Practico.Entidades;
using Practico.Utilidades;

namespace Practico.Servicios
{
    public class FormaDePagoServicio
    {
        private readonly FormaDePagoRepositorio _FormaDePagoRepositorio = null!;
        public FormaDePagoServicio()
        {
            try
            {
                _FormaDePagoRepositorio = new FormaDePagoRepositorio(ConstantesDelSistema.umbralCache);

            }
            catch (Exception )
            {

                throw;
            }
        }

        public void Borrar(int FormaDePagoId)
        {
            _FormaDePagoRepositorio.Borrar(FormaDePagoId);
        }

        public bool Existe(FormaDePago formaDePago)
        {
            return _FormaDePagoRepositorio.Existe(formaDePago);
        }

       

        public List<FormaDePago> GetLista()
        {
            return _FormaDePagoRepositorio.GetLista();
        }

        public void Guardar(FormaDePago formaDePago)
        {
            if (formaDePago.FormaDePagoId == 0) // Accediendo correctamente a la propiedad a través de la instancia
            {
                _FormaDePagoRepositorio.Agregar(formaDePago);
            }
            else
            {
                _FormaDePagoRepositorio.Editar(formaDePago);
            }
        }
    }
}

