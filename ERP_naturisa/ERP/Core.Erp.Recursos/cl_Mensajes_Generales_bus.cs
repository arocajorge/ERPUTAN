using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Recursos
{
    public sealed class  cl_Mensajes_Generales_bus
    {

        /// <summary>
        /// 
        /// </summary>

#region Declaracion_clase_basic
        static readonly cl_Mensajes_Generales_bus instance = new cl_Mensajes_Generales_bus();
        static cl_Mensajes_Generales_bus() { }
        cl_Mensajes_Generales_bus() { }


        public static cl_Mensajes_Generales_bus Instance
        {
            get { return instance; }
        }


#endregion 
 
  


        

        /// <summary>
        /// Mensaje antes de guardar
        /// </summary>
        public string Msg_Guardar_despues
        {

            get 
            {
                return Core.Erp.Recursos.Resource_Msg.msg_guardar;
            }
        }


        

        

    }



    
    


}
