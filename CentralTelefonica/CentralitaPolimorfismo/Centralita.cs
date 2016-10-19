using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Centralita
    {
        private List<Llamada> _listaDeLLamadas;
        protected string _razonSocial;

        
        public Centralita()
        {
            this._listaDeLLamadas = new List<Llamada>(); 
        }

        public Centralita(string nombreEmpresa):this()
        {
            this._razonSocial = nombreEmpresa;
        }

        public float GananciaPorLocal
        {
            get
            {
                return this.CalcularGanancia(TipoLlamada.Local);
            }
            
        }

        public float GananciaPorProvincial
        {
            get
            {
                return this.CalcularGanancia(TipoLlamada.Provincial);
            }

        }

        public float GananciaTotal
        {
            get
            {
                return this.CalcularGanancia(TipoLlamada.Todas);
            }
            
        }

        public List<Llamada> Llamadas
        {
            get
            {
                return this._listaDeLLamadas;
            }
            
        }

        private float CalcularGanancia(TipoLlamada tipo)
        {

            float retorno = 0;
            float retorno2 = 0;

            switch (tipo)
            {
                case TipoLlamada.Local:

                    Local local;

                    foreach (var item in _listaDeLLamadas)
                    {
                        if (item.GetType() == typeof(Local))
                        {
                            local = (Local)item;
                            retorno = retorno + local.CostoLlamada;
                        }
                    }

                    break;

                case TipoLlamada.Provincial:

                    Provincial provincial;

                    foreach (var item in _listaDeLLamadas)
                    {
                        if (item.GetType() == typeof(Provincial))
                        {
                            provincial = (Provincial)item;
                            retorno = retorno + provincial.CostoLlamada;
                        }
                    }

                    break;

                case TipoLlamada.Todas:

                    Local local1;
                    Provincial provincial1;

                    foreach (var item in _listaDeLLamadas)
                    {
                        if (item.GetType() == typeof(Local))
                        {
                            local1 = (Local)item;
                            retorno = retorno + local1.CostoLlamada;
                        }
                        if (item.GetType() == typeof(Provincial))
                        {
                            provincial1 = (Provincial)item;
                            retorno2 = retorno2 + provincial1.CostoLlamada;
                        }
                    }


                    return retorno + retorno2;



            }

            return retorno;

        }
        //DEPETRICATED BY TOSTRING OVERRIDE
        /*public void Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Empresa: " + this._razonSocial);
            sb.AppendLine("Ganancia Total: " + this.GananciaTotal);
            sb.AppendLine("Ganancia Local: " + this.GananciaPorLocal);
            sb.AppendLine("Ganancia Provincial: " + this.GananciaPorProvincial);

            foreach (var item in _listaDeLLamadas)
            {
                Provincial provincial;
                Local local;

                if (item.GetType() == typeof(Local))
                {
                    local = (Local)item;
                    Console.Write(local.ToString());
                }
                if (item.GetType() == typeof(Provincial))
                {
                    provincial = (Provincial)item;
                    Console.Write(provincial.ToString());

                }
            }
        }*/
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Empresa: " + this._razonSocial);
            sb.AppendLine("Ganancia Total: " + this.GananciaTotal);
            sb.AppendLine("Ganancia Local: " + this.GananciaPorLocal);
            sb.AppendLine("Ganancia Provincial: " + this.GananciaPorProvincial);

            foreach (var item in _listaDeLLamadas)
            {
                Provincial provincial;
                Local local;

                if (item.GetType() == typeof(Local))
                {
                    local = (Local)item;
                    sb.AppendLine(local.ToString());
                }
                if (item.GetType() == typeof(Provincial))
                {
                    provincial = (Provincial)item;
                    sb.AppendLine(provincial.ToString());

                }
            }
            return sb.ToString();
        }

        public void OrdenarLlamadas()
        {
            this._listaDeLLamadas.Sort(Llamada.OrdenarPorDuracion);
        }
        private void AgregarLlamadas(Llamada nuevaLlamada)
        {
            this.Llamadas.Add(nuevaLlamada);
        }
        public static bool operator ==(Centralita central,Llamada llama)
        {
            foreach (Llamada item in central.Llamadas)
            {
                if (item == llama)
                    return true;
                
            }
            return false;
            /*if (central.Llamadas.Contains(llama))
                return true;
            return false;*/
        }
        public static bool operator !=(Centralita central, Llamada llama)
        {
            return !(central == llama);
        }
        public static Centralita operator +(Centralita central, Llamada llama)
        {
            Centralita aux = central;
            int i;
            for ( i= 0; i < central.Llamadas.Count;i++)
            {
                if (central.Llamadas[i] == llama)
                {
                    Console.WriteLine("Llamada ya existente " + llama.ToString());
                    return central;
                }
               
            }
            aux.Llamadas.Add(llama);
            return aux;
            

        }

        
    }
}
