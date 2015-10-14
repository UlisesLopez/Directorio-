using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Directorio.modelo
{
    class ModeloDirectorio
    {
        //nombre de directorio
        private string directorio;

        public ModeloDirectorio(string nombreDirectorio)
        {
            directorio = nombreDirectorio;
        }

        public string[] CargarArchivos()
        {
            return Directory.GetFiles(directorio);//regresa todos los archivos 
        }
    }//fin de la clase
}
