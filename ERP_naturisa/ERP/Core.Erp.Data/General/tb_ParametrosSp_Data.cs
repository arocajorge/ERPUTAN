using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Data.General
{
    public class tb_ParametrosSp_Data
    {

        string mensaje = "";
        public List<tb_ParametrosSp_Info> ConsultarParametrosSP(string SP_Name ) 
        {
            try
            {
                List<tb_ParametrosSp_Info> lista = new List<tb_ParametrosSp_Info>();
                EntitiesGeneral oen = new EntitiesGeneral();
                string Query =  " Use DBERP "+
                                " select "+
			                    " 'Parameter_name'	= name, "+
			                    " 'Type'				= type_name(user_type_id), "+
			                    " 'Length'			= max_length, "+
			                    " 'Param_order'		= parameter_id "+
                                " from sys.all_parameters where object_id =  OBJECT_ID('"+SP_Name+"') ";

                var Consulta = oen.Database.SqlQuery<tb_ParametrosSp_Info>(Query);

                lista = Consulta.ToList();

                return lista;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }
    }
}
