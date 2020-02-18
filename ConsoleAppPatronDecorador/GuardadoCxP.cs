using ConsoleAppPatronDecorador.Entidades;
using ConsoleAppPatronDecorador.Interfaces;

namespace ConsoleAppPatronDecorador
{
    public class GuardadoCxP : IGuardadoCxP
    {
        private readonly EntidadCxP _cxP;

        public GuardadoCxP(EntidadCxP cxP)
        {
            _cxP = cxP;
        }
        public string GuardarCxP()
        {
            return string.Format("Se guardó la CxP {0} - {1}, ${2}", _cxP.Id, _cxP.Naturaleza, _cxP.Importe);
        }

        public EntidadCxP ObtenerCxP()
        {
            return _cxP;
        }
    }
}
