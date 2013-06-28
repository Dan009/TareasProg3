using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace edu.itla.csharp.practica1.libreria{
    enum TipoDocumento{
        Cedula,
        Pasaporte,
        Licencia,
        Otros

    }

    class Controlador{
        private string numerodocumento = "";

        public void verificarOpcion(int seleccionado, Presentacion presentacion){
            switch (seleccionado){
                case 1:
                    Console.WriteLine();
                    Console.Write("Digite el numero del documento: ");
                    numerodocumento = Console.ReadLine();
                    Console.WriteLine("Este paso no fue necesario xD usaremos un estandar");
                    new DocumentoIdentidad(TipoDocumento.Cedula,"03900010129");
                break;

                case 2:
                Console.WriteLine("El documento seleccionado es: " + TipoDocumento.Pasaporte);
                break;

                case 3:
                Console.WriteLine("El documento seleccionado es: " + TipoDocumento.Licencia);
                break;

                case 4:
                Console.WriteLine("El documento seleccionado es: " + TipoDocumento.Otros);
                break;

                case 5: Environment.Exit(Environment.ExitCode);
                break;

                default: 
                Console.WriteLine("El documento seleccionado es invalido");
                Console.ReadKey();
                presentacion.menu();
                break;
            }
            Console.ReadKey();
        }
    }
}
