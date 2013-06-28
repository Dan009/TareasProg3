using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace edu.itla.csharp.practica1.libreria{
    public struct DocumentoIdentidad{
        public DocumentoIdentidad(Enum tipo,string numerodocumento){
            long cedula = 0;
            if(tipo.ToString() == "Cedula" && numerodocumento.Length == 11){
                try{
                    cedula = Convert.ToInt64(numerodocumento);
                    Console.WriteLine("Muy bien ahora es valida");
                    string mensaje = validarCedula(cedula,numerodocumento)?"La cedula digitada es valida":"La cedula digitada es ilegal";
                    Console.WriteLine(mensaje);
                    Console.ReadKey();

                }catch (Exception ex){
                    Console.WriteLine(ex);
                    Console.WriteLine("El N. del documento no debe contener letras");
                    
                }
            }
            else {
                Console.WriteLine("El tamaño del N. de la cedula debe ser 11");

            }
        }

        private Boolean validarCedula(long numero, string numerodocumento) {
            bool verificacion = false;
            bool alternar = false;
            int sumapares = 0;
            int sumaimpares = 0;
            string sumatotal = "";
            int total = 0;
            short[] numerospares = new short[5];
            short[] numerosimpares = new short[6];
            char[] letras = numerodocumento.ToCharArray();

            for (int i = 0;i <= 9; i++){
                if (alternar){
                    //Consigue y suma e multiplica por dos los numeros en la posiciones pares
                    sumapares += (Convert.ToInt16(letras[i].ToString()) * 2);
                    alternar = false;

                }
                else{
                    //Consigue los numeros en la posiciones impares
                    sumaimpares += Convert.ToInt16(letras[i].ToString());
                    alternar = true;

                }
            }
            
            sumatotal = Convert.ToString(sumapares+sumaimpares);
            sumatotal.ToCharArray().ToString();
            //resta el identificador a la suma de todos los numeros restantes
            total = sumapares - Convert.ToInt32(sumatotal[sumatotal.Length - 1].ToString());
            verificacion = (total == Convert.ToInt16(letras[letras.Length - 1].ToString())) ? true : false;

            return verificacion;
        }
    }
}
