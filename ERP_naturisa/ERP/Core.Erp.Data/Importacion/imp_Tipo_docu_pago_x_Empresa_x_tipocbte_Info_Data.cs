using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Importacion;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Data.Importacion
{
    public class imp_Tipo_docu_pago_x_Empresa_x_tipocbte_Info_Data
    {
        string mensaje = "";
        public List<imp_Tipo_docu_pago_x_Empresa_x_tipocbte_Info> Get_List_Tipo_docu_pago_x_Empresa_x_tipocbte(int IdEmpresa) 
        {
                List<imp_Tipo_docu_pago_x_Empresa_x_tipocbte_Info> lst = new List<imp_Tipo_docu_pago_x_Empresa_x_tipocbte_Info>();
                EntitiesImportacion Imp = new EntitiesImportacion();
            try
            {
                var Consulta = from q in Imp.imp_Tipo_docu_pago_x_Empresa_x_tipocbte
                               where q.IdEmpresa == IdEmpresa
                               select q;

                foreach (var item in Consulta)
                {
                    imp_Tipo_docu_pago_x_Empresa_x_tipocbte_Info obj = new imp_Tipo_docu_pago_x_Empresa_x_tipocbte_Info();
                    obj.IdTipoCbte = Convert.ToInt32((item.IdTipoCbte == null) ? 0 : item.IdTipoCbte);
                    obj.CodDocu_Pago = item.CodDocu_Pago;
                    obj.IdTipoCbte_Anul = Convert.ToInt32((item.IdTipoCbte_Anul == null) ? 0 : item.IdTipoCbte_Anul);
                    lst.Add(obj);
                }
                return lst;
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

        public Boolean ModificarDB(List<imp_Tipo_docu_pago_x_Empresa_x_tipocbte_Info> Lst) 
        {
            try
            {
                foreach (var item in Lst)
                {
                    using (EntitiesImportacion Context = new EntitiesImportacion())
                    {
                        var contact = Context.imp_Tipo_docu_pago_x_Empresa_x_tipocbte.FirstOrDefault(var => var.IdEmpresa == item.IdEmpresa && var.CodDocu_Pago == item.CodDocu_Pago);
                        if (contact != null)
                        {
                            contact.IdTipoCbte = item.IdTipoCbte;
                            contact.IdTipoCbte_Anul = item.IdTipoCbte_Anul;
                        }
                    }
                }
                return true;
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
