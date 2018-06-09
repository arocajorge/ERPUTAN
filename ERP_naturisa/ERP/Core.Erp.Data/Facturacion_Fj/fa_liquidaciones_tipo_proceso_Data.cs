using Core.Erp.Data.General;
using Core.Erp.Info.Facturacion_FJ;
using Core.Erp.Info.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Data.Facturacion_Fj
{
    public class fa_liquidaciones_tipo_proceso_Data
    {
        public List<fa_liquidaciones_tipo_proceso_Info> Get_List_Liqui_Tipo_Proceso(ref string mensaje)
        {
            try
            {
                List<fa_liquidaciones_tipo_proceso_Info> Lista = new List<fa_liquidaciones_tipo_proceso_Info>();

                using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
                {
                    var select = from q in Context.fa_liquidaciones_tipo_proceso
                                 select q;

                    foreach (var item in select)
                    {
                        fa_liquidaciones_tipo_proceso_Info contact = new fa_liquidaciones_tipo_proceso_Info();

                        contact.IdTipo_Proceso = item.IdTipo_Proceso;
                        contact.nom_IdTipo_Proceso_x_Liqui = item.nom_IdTipo_Proceso_x_Liqui;
                        contact.IdProducto_Liqui_x_defecto = item.IdProducto_Liqui_x_defecto; 
                        Lista.Add(contact);
                    }
                }
                return Lista;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }


        public bool GuardarDB(fa_liquidaciones_tipo_proceso_Info Info, ref string mensaje)
        {
            try
            {
                using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
                {
                    fa_liquidaciones_tipo_proceso contact = new fa_liquidaciones_tipo_proceso();

                    contact.IdProducto_Liqui_x_defecto = Info.IdProducto_Liqui_x_defecto;
                    contact.IdTipo_Proceso = Info.IdTipo_Proceso;
                    contact.nom_IdTipo_Proceso_x_Liqui = Info.nom_IdTipo_Proceso_x_Liqui;
                    Context.fa_liquidaciones_tipo_proceso.Add(contact);
                    Context.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public bool ModificiarDB(fa_liquidaciones_tipo_proceso_Info Info, ref string mensaje)
        {
            try
            {
                using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
                {
                    fa_liquidaciones_tipo_proceso contact = Context.fa_liquidaciones_tipo_proceso.FirstOrDefault(v => v.IdTipo_Proceso == Info.IdTipo_Proceso);

                    if (contact != null)
                    {
                        contact.IdProducto_Liqui_x_defecto = Info.IdProducto_Liqui_x_defecto;
                        contact.IdTipo_Proceso = Info.IdTipo_Proceso;
                        contact.nom_IdTipo_Proceso_x_Liqui = Info.nom_IdTipo_Proceso_x_Liqui;
                        Context.SaveChanges();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public Boolean TipoProcesoExiste(string IdTipoProceso, ref string mensaje)
        {
            try
            {
                Boolean Existe = false;
                Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ();

                var select = from A in Context.fa_liquidaciones_tipo_proceso
                             where A.IdTipo_Proceso == IdTipoProceso 
                             select A;

                foreach (var item in select)
                {
                    Existe = true;
                }
                return Existe;
            }
            catch (Exception ex)
            {
                string array = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje );
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }
    }
}
