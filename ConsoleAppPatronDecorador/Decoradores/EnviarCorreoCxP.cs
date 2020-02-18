using ConsoleAppPatronDecorador.Entidades;
using ConsoleAppPatronDecorador.Interfaces;

namespace ConsoleAppPatronDecorador.Decoradores
{
    public class EnviarCorreoCxP : GuardadoCxPDecorador
    {
        public EnviarCorreoCxP(IGuardadoCxP guardadoCxP) : base(guardadoCxP)
        {
            _mensaje = EnviarCorreo(guardadoCxP.ObtenerCxP());
        }

        private string EnviarCorreo(EntidadCxP cxP)
        {
            return string.Format("Se envió correo por la CxP  {0} - {1} ${2}", cxP.Id, cxP.Naturaleza, cxP.Importe);

        }
    }
}
