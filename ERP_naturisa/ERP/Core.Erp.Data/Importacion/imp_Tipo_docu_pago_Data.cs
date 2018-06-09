using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Importacion;
using Core.Erp.Data.General;
using Core.Erp.Info.General;


namespace Core.Erp.Data.Importacion
{
    public class imp_Tipo_docu_pago_Data
    {
        string mensaje = "";
        public List<imp_Tipo_docu_pago_Info> Get_List_Tipo_docu_pago()
        {
                List<imp_Tipo_docu_pago_Info> lista=new List<imp_Tipo_docu_pago_Info>();
                EntitiesImportacion imp = new EntitiesImportacion();
            try
            {
                var select = from q in imp.imp_Tipo_docu_pago select q;
                foreach (var item in select)
                {
                    imp_Tipo_docu_pago_Info info=new imp_Tipo_docu_pago_Info();
                    info.CodDocu_Pago = item.CodDocu_Pago;
                    info.Descripcion=item.Descripcion;
                    info.PideBanco = item.PideBanco;
                    info.PideProveedor = item.PideProveedor;

                    lista.Add(info);
                }
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

        public Boolean GuardarDB(imp_Tipo_docu_pago_Info info, ref string msg)
        {
            try
            {
                using (EntitiesImportacion context = new EntitiesImportacion())
                {
                    EntitiesImportacion imp = new EntitiesImportacion();

                    decimal cont = 0;
                    try
                    {
                        cont = (from C in imp.imp_Tipo_docu_pago
                                where C.CodDocu_Pago == info.CodDocu_Pago
                                select C).Count();
                    }
                    catch (Exception)
                    {
                    }
                    if (cont > 0) { msg = "Codigo Ya asignado"; return false; }
                    var addressG = new imp_Tipo_docu_pago();
                    addressG.CodDocu_Pago = info.CodDocu_Pago;
                    addressG.Descripcion = info.Descripcion;
                    addressG.PideBanco = info.PideBanco;
                    addressG.PideProveedor = info.PideProveedor;

                    context.imp_Tipo_docu_pago.Add(addressG);
                    context.SaveChanges();

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
                msg = ex.Message;
                throw new Exception(ex.ToString());
            }

        }
        
        public Boolean ModificarDB(imp_Tipo_docu_pago_Info info, ref string msg)
        {
            try
            {
                using (EntitiesImportacion context = new EntitiesImportacion())
                {
                    var addressG = context.imp_Tipo_docu_pago.FirstOrDefault(cot => cot.CodDocu_Pago == info.CodDocu_Pago);
                    if (addressG != null)
                    {
                        addressG.Descripcion = info.Descripcion;
                        addressG.PideBanco = info.PideBanco;
                        addressG.PideProveedor = info.PideProveedor;
                        context.SaveChanges();
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

                msg = ex.Message;
                throw new Exception(ex.ToString());
            }
        }
    }
}
