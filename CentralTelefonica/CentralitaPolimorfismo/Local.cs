using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Local:Llamada
    {
        protected float _costo;

        public Local(Llamada unaLlamada, float costo): this(unaLlamada.NroOrigen, unaLlamada.Duracion, unaLlamada.NroDestino, costo)
          
        {
            
        }

        public Local(string origen, float duracion, string destino, float costo):base(origen,destino,duracion)
        {
            this._costo = costo;
        }
        public override float CostoLlamada
        {
            get
            {
                return this.CalcularCosto();
            }
        }
        

        private float CalcularCosto()
        {
            return (this._costo * this.Duracion);

        }

        protected override string mostrar()
        {
            StringBuilder sb;
            sb = new StringBuilder();
            sb.AppendLine("LLamada Local");
            sb.AppendLine(base.mostrar());                           
            sb.AppendLine("Costo : " + this.CostoLlamada);
            return sb.ToString();
            
            
        }
        public override bool Equals(object obj)
        {
            return (obj is Local);
        }
        public override string ToString()
        {
            return this.mostrar();
        }
    }
}
