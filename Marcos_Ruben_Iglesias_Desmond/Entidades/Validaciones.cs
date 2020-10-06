using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Validaciones
    {
        

        /// <summary>
        ///  Verifica que solo sean letras o espacios
        /// </summary>
        /// <param name="auxString">  </param>
        /// <returns> TRUE si solo hay letras y espacios, FALSE si hay caracteres fuera de rangos </returns>
        public static bool only_Chars_and_Space(string auxString)
        {
            bool okey = true;

            foreach (char item in auxString)
            {
                if( !( 'A' <= item && item <= 'z' ) || (( 'Z' < item && item < 'a' )  &&  item != ' ') )
                {
                    okey = false;
                    break;
                }
            }
            return okey;
        }




        /// <summary>
        /// Verifica que solo sea un numero entero o flotante.
        /// </summary>
        /// <param name="auxInt"></param>
        /// <returns> retorta TRUE si solo se encontraron numeros , sino retorna FALSE </returns>
        public static bool only_numer(string auxInt)
        {
            bool okey = true;
            bool flag = true;
            int contador = 0;

            foreach (char item in auxInt)
            {
                if (item == '.'  )// Verifico que solo exista un punto
                {
                    contador++;

                    if (contador !=0)
                    {
                        okey = false;
                        break;
                    }
                }
                else if ( flag && (item == '+' || item == '-') )//Verifico que solo existan '+' y '-' al pricipio
                {
                    flag = false;
                }
                else if ( ('0' > item && item > '9') )//Verifico que de no estar en este rango no son numeros
                {
                    okey = false;
                    break;
                }
                flag = false;
            }
            return okey;
        }

    }
}
