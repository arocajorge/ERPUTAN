using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Core.Erp.Info.General;
using Core.Erp.Data.General;


namespace Core.Erp.Data.General
{
   public class tb_sis_Impuesto_x_ctacble_Data
    {

        string mensaje = "";


        public List<tb_sis_Impuesto_x_ctacble_Info> Get_List_impuesto(int IdEmpresa)
        {
            try
            {
                List<tb_sis_Impuesto_x_ctacble_Info> lst = new List<tb_sis_Impuesto_x_ctacble_Info>();

                EntitiesGeneral oEnti = new EntitiesGeneral();

                var bancos = from q in oEnti.tb_sis_Impuesto_x_ctacble
                             where q.IdEmpresa_cta == IdEmpresa
                             select q;
                foreach (var item in bancos)
                {
                    tb_sis_Impuesto_x_ctacble_Info info = new tb_sis_Impuesto_x_ctacble_Info();

                    info.IdCod_Impuesto = item.IdCod_Impuesto;
                    info.IdCtaCble = item.IdCtaCble;
                    info.IdEmpresa_cta = item.IdEmpresa_cta;
                    info.observacion = item.observacion;

                    lst.Add(info);
                }
                return lst;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public tb_sis_Impuesto_x_ctacble_Info Get_Info_impuesto(int IdEmpresa, string IdCod_Impuesto)
        {
            try
            {
                tb_sis_Impuesto_x_ctacble_Info info = new tb_sis_Impuesto_x_ctacble_Info();

                EntitiesGeneral oEnti = new EntitiesGeneral();

                var bancos = from q in oEnti.tb_sis_Impuesto_x_ctacble
                             where q.IdCod_Impuesto == IdCod_Impuesto
                             && q.IdEmpresa_cta==IdEmpresa
                             select q;
                foreach (var item in bancos)
                {

                    info.IdCod_Impuesto = item.IdCod_Impuesto;
                    info.IdCtaCble = item.IdCtaCble;
                    info.IdEmpresa_cta = item.IdEmpresa_cta;
                    info.observacion = item.observacion;
                }
                return info;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }


        public Boolean GrabarDB(tb_sis_Impuesto_x_ctacble_Info Info, ref string msg)
        {
            try
            {
                Boolean resultado = false;
                using (EntitiesGeneral context = new EntitiesGeneral())
                {
                    var address = new tb_sis_Impuesto_x_ctacble();

                    
                    address.IdCod_Impuesto = Info.IdCod_Impuesto;
                    address.IdCtaCble = Info.IdCtaCble;
                    address.IdEmpresa_cta = Info.IdEmpresa_cta;
                    address.observacion = "";

                    context.tb_sis_Impuesto_x_ctacble.Add(address);
                    context.SaveChanges();
                    msg = "Se ha procedido grabar el Banco #: " + address.IdCod_Impuesto.ToString() + " exitosamente.";
                    resultado = true;
                }
                return resultado;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }


        public Boolean DeleteDB(int IdEmpresa, string IdCod_Impuesto)
        {
            try
            {
                Boolean resultado = false;

                using (EntitiesGeneral context = new EntitiesGeneral())
                {
                    var contact = context.tb_sis_Impuesto_x_ctacble.FirstOrDefault(obj => obj.IdEmpresa_cta == IdEmpresa && obj.IdCod_Impuesto == IdCod_Impuesto);
                    if (contact != null)
                    {
                        context.tb_sis_Impuesto_x_ctacble.Remove(contact);
                        context.SaveChanges();
                        context.Dispose();
                    }
                }
                
                return resultado;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public Boolean ActualizarDB(tb_sis_Impuesto_x_ctacble_Info Info, ref string msg)
        {
            try
            {
                bool resultado = false;
                using (EntitiesGeneral context = new EntitiesGeneral())
                {
                    var address = context.tb_sis_Impuesto_x_ctacble.FirstOrDefault(v => v.IdCod_Impuesto == Info.IdCod_Impuesto && v.IdEmpresa_cta==Info.IdEmpresa_cta);
                    if (address != null)
                    {

                        address.IdCtaCble = Info.IdCtaCble;
                        address.IdEmpresa_cta = Info.IdEmpresa_cta;
                        address.observacion = Info.observacion;


                        context.SaveChanges();
                        msg = "Se ha modificado el Banco #: " + address.IdCod_Impuesto.ToString() + " exitosamente.";
                        resultado = true;
                    }
                }
                return resultado;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        

    }
}
