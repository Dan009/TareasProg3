using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace edu.itla.csharp.practica1.libreria{
    class Presentacion{
        private int seleccionado;
     
        public void menu(){
            Controlador controlador = new Controlador();
            Console.WriteLine();
            Console.WriteLine("+-----Bienvenido al Verificador de Documentos de Identidad-----+");
            Console.WriteLine();
            Console.WriteLine("Escoja el tipo de documento que desea verificar");
            Console.WriteLine("1. Cedula");
            Console.WriteLine("2. Pasaporte");
            Console.WriteLine("3. Licencia");
            Console.WriteLine("4. Otro");
            Console.WriteLine("5. Salir");
            Console.Write("Digite el documento deseado: ");
            seleccionado = Convert.ToInt32(Console.ReadLine());
            controlador.verificarOpcion(seleccionado, new Presentacion());

        }
    }
}
