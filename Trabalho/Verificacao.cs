using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Classes
{
    public class Verificacao
    {
        public string Verifica_triangulo(float a, float b, float c)
        {
            //||
            string confirma = string.Empty;
            if (a == b && a == c)
            {
                confirma = "Esse triângulo é equilátero";
            }
            else
            {
                confirma = "Esse triângulo não é equilátero";
            }
            return confirma;
        }
    }
}
