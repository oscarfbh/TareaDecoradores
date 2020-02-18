using ConsoleAppPatronDecorador.Entidades;
using ConsoleAppPatronDecorador.Interfaces;

namespace ConsoleAppPatronDecorador
{
    public abstract class GuardadoCxPDecorador : IGuardadoCxP
    {
        protected IGuardadoCxP _guardadoCxP;
        protected string _mensaje = "";

        public GuardadoCxPDecorador(IGuardadoCxP guardadoCxP)
        {
            _guardadoCxP = guardadoCxP;
        }

        public string GuardarCxP()
        {
            return string.Format("{0}\n{1}",
                   _guardadoCxP.GuardarCxP(), _mensaje);
        }

        public EntidadCxP ObtenerCxP()
        {
            return _guardadoCxP.ObtenerCxP();
        }
    }
}
