﻿using System;
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
            throw new System.NotImplementedException();
        }

        public Local(string origen, float duracion, string destino, float costo):base(origen,destino,duracion)
        {
            this._costo = costo;
        }
        public float CostoLlamada
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

        public void Mostrar()
        {
            StringBuilder sb;
            sb = new StringBuilder();
            base.mostrar();
            sb.AppendLine("Llamada Local");
            sb.AppendLine("Costo" + this.CostoLlamada);
            Console.Write(sb);
            
            
        }
    }
}