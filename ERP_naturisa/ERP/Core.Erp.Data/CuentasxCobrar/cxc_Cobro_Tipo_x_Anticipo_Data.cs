using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.CuentasxCobrar;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.CuentasxCobrar
{
    public class cxc_Cobro_Tipo_x_Anticipo_Data
    {
        string mensaje = "";

        public List<cxc_Cobro_Tipo_x_Anticipo_Info> Get_List_Cobro_Tipo_x_Anticipo(int IdEmpresa)
        {
            try
            {
                List<cxc_Cobro_Tipo_x_Anticipo_Info> lst = new List<cxc_Cobro_Tipo_x_Anticipo_Info>();
                cxc_Cobro_Tipo_x_Anticipo_Info Info;
                EntitiesCuentas_x_Cobrar context = new EntitiesCuentas_x_Cobrar();
                var address = from q in context.cxc_cobro_tipo_x_anticipo
                              where q.IdEmpresa == IdEmpresa
                              orderby q.posicion
                              select q;

                foreach (var item in address)
                {
                    Info = new cxc_Cobro_Tipo_x_Anticipo_Info();
                    Info.IdEmpresa = item.IdEmpresa;
                    Info.IdCobro_tipo = item.IdCobro_tipo;
                    Info.posicion = (int)item.posicion;
                    
                    lst.Add(Info);
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
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }
        
        public Boolean GuardarDB(List<cxc_Cobro_Tipo_x_Anticipo_Info> lst)
        {
            try
            {

                EntitiesCuentas_x_Cobrar context = new EntitiesCuentas_x_Cobrar();


                foreach (var Info in lst)
                {
                    if (ValidarSiExiste(Info.IdCobro_tipo, Info.IdEmpresa))
                    {
                        var address = new cxc_cobro_tipo_x_anticipo();
                        address.IdEmpresa = Info.IdEmpresa;
                        address.IdCobro_tipo = Info.IdCobro_tipo;
                        address.posicion = (int)Info.posicion;
                        context.cxc_cobro_tipo_x_anticipo.Add(address);
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
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }
        
        public Boolean ModificarDB(cxc_Cobro_Tipo_x_Anticipo_Info Info)
        {
            try
            {
                Boolean res = false;
                EntitiesCuentas_x_Cobrar context = new EntitiesCuentas_x_Cobrar();
                var address = context.cxc_cobro_tipo_x_anticipo.FirstOrDefault(var => var.IdCobro_tipo == Info.IdCobro_tipo && var.IdEmpresa == Info.IdEmpresa);
                if (address != null)
                {
                    address.posicion = (int)Info.posicion;
                    context.SaveChanges();
                    res = true;
                }
                return res;
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
        
        public Boolean GuardarDB(cxc_Cobro_Tipo_x_Anticipo_Info Info)
        {
            try
            {

                EntitiesCuentas_x_Cobrar context = new EntitiesCuentas_x_Cobrar();
                var address = new cxc_cobro_tipo_x_anticipo();
                address.IdEmpresa = Info.IdEmpresa;
                address.IdCobro_tipo = Info.IdCobro_tipo;
                address.posicion = (int)Info.posicion;
                context.cxc_cobro_tipo_x_anticipo.Add(address);
                context.SaveChanges();
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
        
        public Boolean ValidarSiExiste(string IdCobro_tipo, int IdEmpresa)
        {
            bool ret = false;
            try
            {
                EntitiesCuentas_x_Cobrar context = new EntitiesCuentas_x_Cobrar();
                var address = from q in context.cxc_cobro_tipo_x_anticipo
                              where q.IdCobro_tipo == IdCobro_tipo && q.IdEmpresa == IdEmpresa
                              select q;

                if (address.ToList().Count > 0)
                {
                    ret = false;
                }
                else
                {
                    ret = true;
                }

                return ret;
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
        
        public Boolean EliminarDB(cxc_Cobro_Tipo_x_Anticipo_Info Info)
        {
            try
            {
                Boolean res = false;
                EntitiesCuentas_x_Cobrar context = new EntitiesCuentas_x_Cobrar();
                var address = context.cxc_cobro_tipo_x_anticipo.FirstOrDefault(var => var.IdEmpresa == Info.IdEmpresa && var.IdCobro_tipo == Info.IdCobro_tipo);
                if (address != null)
                {
                    context.cxc_cobro_tipo_x_anticipo.Remove(address);
                    context.SaveChanges();
                    res = true;
                }
                return res;
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
        
        public Boolean EliminarDB(int IdEmpresa)
        {
            try
            {
               using (EntitiesCuentas_x_Cobrar Entity = new EntitiesCuentas_x_Cobrar())
                {
                    int numeroElimindo = Entity.Database.ExecuteSqlCommand("delete cxc_cobro_tipo_x_anticipo where IdEmpresa = " + IdEmpresa);
                }
                return true;
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
