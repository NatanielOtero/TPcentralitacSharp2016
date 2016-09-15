using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Llamada
    {
        protected float _duracion;
        protected string _nroDestino;
        protected string _nroOrigen;

        public Llamada(string origen, string destino, float duracion)
        {
            this._nroOrigen = origen;
            this._nroDestino = destino;
            this._duracion = duracion;
        }

        public float Duracion
        {
            get
            {
                return this._duracion;
            }            
        }

        public string NroDestino
        {
            get
            {
                return this._nroDestino;
            }            
        }

        public string NroOrigen
        {
            get
            {
                return this._nroOrigen;
            }
            
        }

        public void mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Duracion :{0}" + this._duracion);
            sb.AppendLine("Origen :{1}" + this._nroOrigen);
            sb.AppendLine("Destino :{2}" + this._nroDestino);

            Console.Write(sb);
        }

        public int OrdenarPorDuracion(Llamada uno, Llamada dos)
        {
            return uno._duracion.CompareTo(dos._duracion);
        }
    }
}
