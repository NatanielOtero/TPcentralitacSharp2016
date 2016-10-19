using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public abstract  class Llamada
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
        public abstract float CostoLlamada
        {
            get;

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

        protected virtual string mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Duracion :" + this._duracion);
            sb.AppendLine("Origen :" + this._nroOrigen);
            sb.AppendLine("Destino :" + this._nroDestino);

            return sb.ToString();
        }
        public static bool operator ==(Llamada uno, Llamada dos)
        {
            if (uno.Equals(dos) && uno._nroDestino == dos._nroDestino && uno._nroOrigen == dos._nroOrigen)
                return true;
            return false;
            
        }
        public static bool operator !=(Llamada uno, Llamada dos)
        {
            return !(uno == dos);
        }

        public static int OrdenarPorDuracion(Llamada uno, Llamada dos)
        {
            return uno._duracion.CompareTo(dos._duracion);
        }
    }
}
