using ConsoleAppPatronDecorador.Decoradores;
using ConsoleAppPatronDecorador.Entidades;
using ConsoleAppPatronDecorador.Interfaces;
using System;

namespace ConsoleAppPatronDecorador
{
    class Program
    {
        static void Main(string[] args)
        {
            EntidadCxP cxP = new EntidadCxP() { Id = "IdCxP", Naturaleza = "Natural", Importe = 25000 };
            IGuardadoCxP guardadoCxP = new GuardadoCxP(cxP);
            GuardarHistorialCxP guardarHistorialCxP = new GuardarHistorialCxP(guardadoCxP);
            EnviarCorreoCxP enviarCorreoCxP = new EnviarCorreoCxP(guardadoCxP);
            EnviarCorreoCxP guardarHistorialEnviarCorreoCxP = new EnviarCorreoCxP(new GuardarHistorialCxP(guardadoCxP));

            Console.WriteLine("Decorador Guardar Historial al guardar CxP:");
            Console.WriteLine(guardarHistorialCxP.GuardarCxP());
            Console.WriteLine();

            Console.WriteLine("Decorador Enviar correo al guardar CxP:");
            Console.WriteLine(enviarCorreoCxP.GuardarCxP());
            Console.WriteLine();

            Console.WriteLine("Decoradores combinados al guardar CxP:");
            Console.WriteLine(guardarHistorialEnviarCorreoCxP.GuardarCxP());
            Console.WriteLine();
        }
    }
}
