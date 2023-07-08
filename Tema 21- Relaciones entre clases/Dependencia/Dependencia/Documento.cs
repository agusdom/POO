using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependencia
{
    internal class Documento
    {
        private String texto = "";

        public string Texto { get => texto;}

        public Documento(String txt)
        {
            texto = txt;
        }


    }
}
