/*CLASE: ro_Rdep_Detalle_Bus
 *CREADO POR: ALBERTO MENA
 *FECHA: 05-06-2015
 *DERECHOS RESERVADOS - INNOVATECORP
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.Roles;
using Core.Erp.Data.Roles;
using Core.Erp.Business.General;


namespace Core.Erp.Business.Roles
{
    public class ro_Rdep_Detalle_Bus
    {
        ro_Rdep_Detalle_Data oData = new ro_Rdep_Detalle_Data();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";

        public List<ro_Rdep_Detalle_Info> GetListPorId(int idEmpresa, decimal idEmpleado, int anioFiscal, ref string msg)
        {
            try
            {
                return oData.GetListPorId(idEmpresa, idEmpleado,anioFiscal,ref msg);
            }
            catch (Exception ex)
            {
                oLog.Log_Error(ex.ToString());
                mensaje = msg = "Error .." + ex.Message;
                return new List<ro_Rdep_Detalle_Info>();
            }
        }


        public Boolean GuardarBD(ro_Rdep_Detalle_Info info, ref string msg)
        {
            try
            {
                Boolean valorRetornar = false;

                //MODIFICAR
                if (oData.GetExiste(info, ref msg))
                {

                    info.UsuarioModifica = param.IdUsuario;
                    info.FechaModifica = param.Fecha_Transac;

                    valorRetornar = oData.ModificarBD(info, ref msg);
                }
                else
                {//GRABAR
                   
                    info.UsuarioIngresa = param.IdUsuario;
                    info.FechaModifica = param.Fecha_Transac;
                    info.UsuarioModifica = param.IdUsuario;
                    info.FechaModifica = param.Fecha_Transac;

                    valorRetornar = oData.ModificarBD(info, ref msg);
                }

                return valorRetornar;
            }
            catch (Exception ex)
            {
                oLog.Log_Error(ex.ToString());
                mensaje = msg = "Error .." + ex.Message;
                return false;
            }
        }



        public Boolean EliminarBD(int idEmpresa, decimal idEmpleado, int anioFiscal, ref string msg)
        {
            try
            {
                return oData.EliminarBD(idEmpresa, idEmpleado, anioFiscal, ref msg);
            }
            catch (Exception ex)
            {
                oLog.Log_Error(ex.ToString());
                mensaje = msg = "Error .." + ex.Message;
                return false;
            }
        }




    }
}
