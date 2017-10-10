using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace C3D_Combiner.clases
{
    class carpeta
    {
        public String nombre,path;        
        public ArrayList archivos;

        public carpeta(String nombre)
        {
            this.nombre = nombre;
            this.archivos = new ArrayList();
        }

        public void setPath(String path)
        {
            this.path = path;
        }
        public void agregarArchivo(String nombre)
        {
            this.archivos.Add(nombre);
            
        }

        public void quitarArchivo(String nombre)
        {
            this.archivos.Remove(nombre);        
        }

    }
}
