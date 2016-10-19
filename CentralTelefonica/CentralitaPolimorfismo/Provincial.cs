using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Provincial:Llamada
    {
        protected Franja _franjaHoraria;

        public Provincial(Franja miFranja, Llamada unaLlamada): this(unaLlamada.NroOrigen, unaLlamada.Duracion, unaLlamada.NroDestino, miFranja)            
        {
            

        }

        public Provincial(string origen, float duracion, string destino, Franja miFranja) : base(origen, destino, duracion)
           
        {
            this._franjaHoraria = miFranja;
            
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
            float costo = 0;

            switch (this._franjaHoraria)
            {
                case Franja.Franja_1:
                    costo = 0.99f;
                    break;

                case Franja.Franja_2:
                    costo = 1.25f;
                    break;

                case Franja.Franja_3:
                    costo = 0.66f;
                    break;
            }
            return (costo * this._duracion);
        }

        protected override string mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Llamada Provincial");
            sb.AppendLine(base.mostrar());
            sb.AppendLine("Franja Horaria: " + this._franjaHoraria);
            sb.AppendLine("Costo: " + this.CostoLlamada);
            return sb.ToString();
        }
        public override string ToString()
        {
            return this.mostrar();
        }
        public override bool Equals(object obj)
        {
            return (obj is Provincial);
        }
        
    }
}
