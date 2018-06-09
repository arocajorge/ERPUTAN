using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
          
namespace Core.Erp.Info.General
{
   public class tb_persona_direccion_Info
    {
        public decimal IdPersona { get; set; }
        public int IdDireccion { get; set; }
        public int prioridad { get; set; }
        public string Direccion { get; set; }
        public string referencia { get; set; }
        public bool estado { get; set; }
        public string calle { get; set; }
        public string cod_postal { get; set; }
        public string Ciudad { get; set; }
        public int IdTipoDireccion { get; set; }

        public tb_persona_direccion_Info()
        {

        }

       

        //public tb_persona_direccion_Info
        //    (decimal _IdPersona, int _IdDireccion, int _prioridad, string _Direccion
        //    , string _referencia, bool _estado)
        //{
        //    estado = _estado;
        //    referencia = _referencia;
        //    Direccion = _Direccion;
        //    prioridad = _prioridad;
        //    IdDireccion = _IdDireccion;
        //    IdPersona = _IdPersona;


        //}


    }
}
