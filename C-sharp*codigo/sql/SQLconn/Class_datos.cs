using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLconn
{
    internal class Class_datos
    {
        internal int codigo, edad;
        internal string nombre, apellido, direccion, deparmento;



        public String p_nombre
        {
            set {
                
                nombre = value;
            }
        }




        public String p_apellido
        {
            set
            {

                apellido = value;
            }
        }
        public String p_direccion
        {
            set
            {

                direccion = value;
            }
        }
        public String p_deparmento
        {
            set
            {

                deparmento = value;
            }
        }
        public int p_codigo
        {
            set
            {
                codigo = value;
            }
        }
        public int p_edad
        {
            set
            {
                edad = value;
            }
        }



    }
}
