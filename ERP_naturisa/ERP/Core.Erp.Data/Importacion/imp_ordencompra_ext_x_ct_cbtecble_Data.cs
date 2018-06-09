using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Importacion;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.Importacion
{
    public class imp_ordencompra_ext_x_ct_cbtecble_Data
    {
        string mensaje = "";
        public Boolean GuardarDB(imp_ordencompra_ext_x_ct_cbtecble_Info Info, ref string mensaje)
        {
            try
            {
                using(EntitiesImportacion Context = new EntitiesImportacion())
                {
                    var Address = new imp_ordencompra_ext_x_ct_cbtecble();
                    Address.imp_IdEmpresa = Info.imp_IdEmpresa;
                    Address.imp_IdSucusal = Info.imp_IdSucusal;
                    Address.imp_IdOrdenCompraExt = Info.imp_IdOrdenCompraExt;
                    Address.ct_IdEmpresa = Info.ct_IdEmpresa;
                    Address.ct_IdTipoCbte = Info.ct_IdTipoCbte;
                    Address.ct_IdCbteCble = Info.ct_IdCbteCble;
                    Address.TipoReg = Info.TipoReg;
                    Context.imp_ordencompra_ext_x_ct_cbtecble.Add(Address);
                    Context.SaveChanges();
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

        public Boolean GuardarDB(List<imp_ordencompra_ext_x_ct_cbtecble_Info> lst, ref string mensaje)
        {
            try
            {

                foreach (var item in lst)
                {
                    GuardarDB(item, ref mensaje);
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
                throw new Exception(ex.InnerException.ToString());
            }
        }
         
        public Boolean ModificarDB(imp_ordencompra_ext_x_ct_cbtecble_Info info)
        {
            try
            {
                using (EntitiesImportacion context = new EntitiesImportacion())
                {
                    var contact = context.imp_ordencompra_ext_x_ct_cbtecble.FirstOrDefault(minfo => minfo.ct_IdEmpresa == info.ct_IdEmpresa && minfo.ct_IdCbteCble == info.ct_IdCbteCble && minfo.ct_IdTipoCbte == info.ct_IdTipoCbte);
                    if(contact!=null)
                    {
                        contact.imp_IdEmpresa = info.imp_IdEmpresa;
                        contact.imp_IdOrdenCompraExt = info.imp_IdOrdenCompraExt;
                        contact.imp_IdSucusal = info.imp_IdSucusal;
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
                throw new Exception(ex.ToString());
            }
        }

        public Boolean EliminarDB(int ct_IdEmpresa,decimal ct_IdCbteCble, int ct_IdTipoCbte)
        {
            try
            {
                using (EntitiesImportacion context = new EntitiesImportacion())
                {
                    var contact = context.imp_ordencompra_ext_x_ct_cbtecble.FirstOrDefault(minfo => minfo.ct_IdEmpresa == ct_IdEmpresa && minfo.ct_IdCbteCble == ct_IdCbteCble && minfo.ct_IdTipoCbte == ct_IdTipoCbte);
                    if(contact!=null)
                    {
                         context.imp_ordencompra_ext_x_ct_cbtecble.Remove(contact);
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
                throw new Exception(ex.ToString());
            }
        }

        public imp_ordencompra_ext_x_ct_cbtecble_Info Get_Info_ordencompra_ext_x_ct_cbtecble(int IdEmpres, int IdSucursal, decimal IdOrdeCompr, string TipoReg = "")
        {
            EntitiesImportacion oEnti = new EntitiesImportacion();
            imp_ordencompra_ext_x_ct_cbtecble_Info Info = new imp_ordencompra_ext_x_ct_cbtecble_Info();
            try
            {
                if (TipoReg != "")
                {
                    var Item = oEnti.Database.SqlQuery<imp_ordencompra_ext_x_ct_cbtecble_Info>
                        ("select  top (1)* from  imp_ordencompra_ext_x_ct_cbtecble where imp_IdOrdenCompraExt = " + IdOrdeCompr
                        + " and imp_idEmpresa =  " + IdEmpres + " and imp_idsucusal =" + IdSucursal + " order by ct_IdCbteCble desc");
                    imp_ordencompra_ext_x_ct_cbtecble_Info Objeto = (imp_ordencompra_ext_x_ct_cbtecble_Info)Item.First();
                    return Objeto;
                }
                else
                {
                    var Item = oEnti.Database.SqlQuery<imp_ordencompra_ext_x_ct_cbtecble_Info>
                            ("select  top (1)* from  imp_ordencompra_ext_x_ct_cbtecble where imp_IdOrdenCompraExt = " + IdOrdeCompr
                            + " and imp_idEmpresa =  " + IdEmpres + " and imp_idsucusal =" + IdSucursal + "and TipoReg =" + TipoReg + " order by ct_IdCbteCble desc");
                    imp_ordencompra_ext_x_ct_cbtecble_Info Objeto = (imp_ordencompra_ext_x_ct_cbtecble_Info)Item.First();
                    return Objeto;
                }

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

        public imp_ordencompra_ext_x_ct_cbtecble_Info Get_Info_ordencompra_ext_x_ct_cbtecble(int ct_IdEmpresa, int ct_IdTipoCbte, decimal ct_IdCbteCble, ref string mensaje)
        {
            EntitiesImportacion oEnti = new EntitiesImportacion();
            imp_ordencompra_ext_x_ct_cbtecble_Info Info = new imp_ordencompra_ext_x_ct_cbtecble_Info();
            try
            {
                string query = "select  top (1)* from  imp_ordencompra_ext_x_ct_cbtecble  c " +
                        " where c.ct_IdEmpresa =" + ct_IdEmpresa +
                        " and c.ct_IdTipoCbte = " + ct_IdTipoCbte +
                        " and c.ct_IdCbteCble = " + ct_IdCbteCble + " order by ct_IdCbteCble desc";
                var Item = oEnti.Database.SqlQuery<imp_ordencompra_ext_x_ct_cbtecble_Info>
                    (query);
                
                imp_ordencompra_ext_x_ct_cbtecble_Info Objeto = (imp_ordencompra_ext_x_ct_cbtecble_Info)Item.First();
                mensaje = "Consulta Correcta";
                return Objeto;

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

        public List<imp_ordencompra_ext_x_ct_cbtecble_Info> Get_List_ordencompra_ext_x_ct_cbtecble(int IdEmpresa, int IdSucursal, decimal IdOrdenCompraExt)
    {
            List<imp_ordencompra_ext_x_ct_cbtecble_Info> Lst = new List<imp_ordencompra_ext_x_ct_cbtecble_Info>();
            EntitiesImportacion oEnti = new EntitiesImportacion();
        try
        {
            var Query = from q in oEnti.imp_ordencompra_ext_x_ct_cbtecble
                        where q.imp_IdEmpresa== IdEmpresa && q.imp_IdSucusal == IdSucursal && q.imp_IdOrdenCompraExt == IdOrdenCompraExt
                        select q;
            foreach (var item in Query)
            {
                imp_ordencompra_ext_x_ct_cbtecble_Info Obj = new imp_ordencompra_ext_x_ct_cbtecble_Info();
                Obj.imp_IdEmpresa = item.imp_IdEmpresa;
                Obj.imp_IdSucusal = item.imp_IdSucusal;
                Obj.imp_IdOrdenCompraExt = item.imp_IdOrdenCompraExt;
                Obj.ct_IdEmpresa = item.ct_IdEmpresa;
                Obj.ct_IdTipoCbte = item.ct_IdTipoCbte;
                Obj.ct_IdCbteCble = item.ct_IdCbteCble;
                Obj.TipoReg = item.TipoReg;
                Lst.Add(Obj);
            }
            return Lst;
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

        public List<imp_ordencompra_ext_x_ct_cbtecble_Info> Get_List_ordencompra_ext_x_ct_cbtecble(int ct_IdEmpresa, int ct_IdTipoCbte, decimal ct_IdCbteCble, ref string mensaje)
        {
               List<imp_ordencompra_ext_x_ct_cbtecble_Info> Lst = new List<imp_ordencompra_ext_x_ct_cbtecble_Info>();
            EntitiesImportacion oEnti = new EntitiesImportacion();
        try
        {
            var Query = from q in oEnti.imp_ordencompra_ext_x_ct_cbtecble
                        where q.ct_IdEmpresa== ct_IdEmpresa
                        && q.ct_IdTipoCbte == ct_IdTipoCbte 
                        && q.ct_IdCbteCble == ct_IdCbteCble
                        select q;
            foreach (var item in Query)
            {
                imp_ordencompra_ext_x_ct_cbtecble_Info Obj = new imp_ordencompra_ext_x_ct_cbtecble_Info();
                Obj.imp_IdEmpresa = item.imp_IdEmpresa;
                Obj.imp_IdSucusal = item.imp_IdSucusal;
                Obj.imp_IdOrdenCompraExt = item.imp_IdOrdenCompraExt;
                Obj.ct_IdEmpresa = item.ct_IdEmpresa;
                Obj.ct_IdTipoCbte = item.ct_IdTipoCbte;
                Obj.ct_IdCbteCble = item.ct_IdCbteCble;
                Obj.TipoReg = item.TipoReg;
                Lst.Add(Obj);
            }
            return Lst;
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
