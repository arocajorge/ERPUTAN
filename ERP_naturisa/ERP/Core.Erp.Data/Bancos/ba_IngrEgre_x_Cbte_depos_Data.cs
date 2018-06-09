using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Bancos;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Data.Bancos
{
    public class ba_IngrEgre_x_Cbte_depos_Data
    {
        string mensaje = "";

        public List<ba_IngrEgre_x_Cbte_depos_Info> Get_List_IngrEgre_x_Cbte_depos(int IdEmpresa, string TipoIngEgr, decimal IdCbteCble, int IdTipoCbte)
        {
            try
            {
                List<ba_IngrEgre_x_Cbte_depos_Info> lM = new List<ba_IngrEgre_x_Cbte_depos_Info>();
                EntitiesBanco db = new EntitiesBanco();

                //var select_ = from T in db.ba_IngrEgre_x_Cbte_depos
                //              where T.IdEmpresa == IdEmpresa && T.IdCbteCble == IdCbteCble && T.IdTipoCbte == IdTipoCbte && T.TipoIngEgr == TipoIngEgr
                //              select T;

                //foreach (var item in select_)
                //{
                //    ba_IngrEgre_x_Cbte_depos_Info dat = new ba_IngrEgre_x_Cbte_depos_Info();
                //    dat.IdEmpresa = item.IdEmpresa;
                //    dat.TipoIngEgr = item.TipoIngEgr;
                //    dat.IdSucursal = item.IdSucursal;
                //    dat.IdCobro = item.IdCobro;
                //    dat.IdTipoCbte = item.IdTipoCbte;
                //    dat.IdCbteCble = item.IdCbteCble;
                //    dat.IdUsuario = item.IdUsuario;
                //    dat.estado = item.estado;

                //    lM.Add(dat);
                //}
                return (lM);
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public Boolean GrabarDB(ba_IngrEgre_x_Cbte_depos_Info info)
        {
            try
            {
                using (EntitiesBanco context = new EntitiesBanco())
                {
                    EntitiesBanco EDB = new EntitiesBanco();

                    //var address = new ba_IngrEgre_x_Cbte_depos();
                    
                    //address.IdEmpresa = info.IdEmpresa;
                    //address.TipoIngEgr = info.TipoIngEgr;
                    //address.IdSucursal = info.IdSucursal;
                    //address.IdCobro = info.IdCobro;
                    //address.IdTipoCbte = info.IdTipoCbte;
                    //address.IdCbteCble = info.IdCbteCble;
                    //address.Fecha_Transac = info.Fecha_Transac;
                    //address.IdUsuario = info.IdUsuario;
                    //address.ip = info.ip;
                    //address.nom_pc = info.nom_pc;
                    //address.estado = "A";             

                    ////contact = address;

                    //context.ba_IngrEgre_x_Cbte_depos.Add(address);
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
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public Boolean GrabarDB(List<ba_IngrEgre_x_Cbte_depos_Info> lista)
        {
            try
            {
               foreach (var item in lista)
                {
                    GrabarDB(item);
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
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public Boolean EliminarCobrosDepositados(int IdEmpresa, decimal IdCbteCble, int IdTipocbte, string TipoIngEgr)
        {
            Boolean resultado = false;
            try
            {
                EntitiesBanco context = new EntitiesBanco();
                //var select_ = from t in context.ba_IngrEgre_x_Cbte_depos
                //              where t.IdEmpresa == IdEmpresa && t.IdCbteCble == IdCbteCble && t.IdTipoCbte == IdTipocbte && t.TipoIngEgr == TipoIngEgr
                //              select t;
                //foreach (var item in select_)
                //{
                //    context = new EntitiesBanco();
                //    var contact = context.ba_IngrEgre_x_Cbte_depos.FirstOrDefault(minfo => minfo.IdEmpresa == item.IdEmpresa && minfo.IdCbteCble == item.IdCbteCble && minfo.IdTipoCbte == item.IdTipoCbte);
                //    if (contact != null)
                //    {
                //        context.ba_IngrEgre_x_Cbte_depos.Remove(contact);
                //        context.SaveChanges();
                //        context.Dispose();
                //        resultado = true;
                //    }
                //}
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

        public ba_IngrEgre_x_Cbte_depos_Data()
        {
            
        }
    }
}
