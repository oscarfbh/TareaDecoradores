using ConsoleAppPatronDecorador.Entidades;
using ConsoleAppPatronDecorador.Interfaces;

namespace ConsoleAppPatronDecorador.Decoradores
{
    public class GuardarHistorialCxP : GuardadoCxPDecorador
    {
        public GuardarHistorialCxP(IGuardadoCxP guardadoCxP) : base(guardadoCxP)
        {
            _mensaje = GuardarHistorial(guardadoCxP.ObtenerCxP());
        }

        private string GuardarHistorial(EntidadCxP cxP)
        {
            return string.Format("Historial guardado para la CxP  {0} - {1} ${2}", cxP.Id, cxP.Naturaleza, cxP.Importe);

        }
    }
}
