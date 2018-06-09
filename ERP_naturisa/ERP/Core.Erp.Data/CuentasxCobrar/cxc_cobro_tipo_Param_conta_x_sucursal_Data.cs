using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.CuentasxCobrar;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Data.CuentasxCobrar
{

    public class cxc_cobro_tipo_Param_conta_x_sucursal_Data
    {
        string mensaje = "";
        public List<cxc_cobro_tipo_Param_conta_x_sucursal_Info> Get_List_cobro_tipo_Param_conta_x_sucursal(int IdEmpresa, int IdSucursal)
        {
            try
            {
                List<cxc_cobro_tipo_Param_conta_x_sucursal_Info> lM = new List<cxc_cobro_tipo_Param_conta_x_sucursal_Info>();
                EntitiesCuentas_x_Cobrar db = new EntitiesCuentas_x_Cobrar();

                var select_ = from T in db.cxc_cobro_tipo_Param_conta_x_sucursal
                                where T.IdEmpresa == IdEmpresa && T.IdSucursal==IdSucursal 
                              select T;


                foreach (var item in select_)
                {
                    cxc_cobro_tipo_Param_conta_x_sucursal_Info dat = new cxc_cobro_tipo_Param_conta_x_sucursal_Info();

                    dat.IdCobro_tipo = item.IdCobro_tipo;                    
                    dat.IdCtaCble = item.IdCtaCble;
                    dat.IdEmpresa = item.IdEmpresa;
                    dat.IdSucursal = item.IdSucursal;
                    dat.IdCtaCble_Anticipo = item.IdCtaCble_Anticipo;
                    
                    lM.Add(dat);
                }
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

        public List<cxc_cobro_tipo_Param_conta_x_sucursal_Info> Get_List_cobro_tipo_Param_conta_x_sucursal(int IdEmpresa)
        {
            try
            {
                List<cxc_cobro_tipo_Param_conta_x_sucursal_Info> lM = new List<cxc_cobro_tipo_Param_conta_x_sucursal_Info>();
                EntitiesCuentas_x_Cobrar db = new EntitiesCuentas_x_Cobrar();

                var select_ = from T in db.cxc_cobro_tipo_Param_conta_x_sucursal
                              where T.IdEmpresa == IdEmpresa 
                              select T;


                foreach (var item in select_)
                {
                    cxc_cobro_tipo_Param_conta_x_sucursal_Info dat = new cxc_cobro_tipo_Param_conta_x_sucursal_Info();

                    dat.IdCobro_tipo = item.IdCobro_tipo;                    
                    dat.IdCtaCble = item.IdCtaCble;
                    dat.IdEmpresa = item.IdEmpresa;
                    dat.IdSucursal = item.IdSucursal;
                    dat.IdCtaCble_Anticipo = item.IdCtaCble_Anticipo;

                    lM.Add(dat);
                }
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

        public cxc_cobro_tipo_Param_conta_x_sucursal_Info Get_Info_cobro_tipo_Param_conta_x_sucursal(int IdEmpresa, int IdSucursal, string IdCobro_tipo)
        {
            try
            {
                cxc_cobro_tipo_Param_conta_x_sucursal_Info info = new cxc_cobro_tipo_Param_conta_x_sucursal_Info();
                EntitiesCuentas_x_Cobrar context = new EntitiesCuentas_x_Cobrar();
                var x = from q in context.cxc_cobro_tipo_Param_conta_x_sucursal where q.IdEmpresa == IdEmpresa && q.IdSucursal == IdSucursal && q.IdCobro_tipo == IdCobro_tipo select q;
                foreach (var item in x)
                {
                    info.IdCobro_tipo = item.IdCobro_tipo;
                    info.IdCtaCble = item.IdCtaCble;                    
                    info.IdEmpresa = item.IdEmpresa;
                    info.IdSucursal = item.IdSucursal;
                    info.IdCtaCble_Anticipo = item.IdCtaCble_Anticipo;
                }
                return info;
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

        public List<cxc_cobro_tipo_Param_conta_x_sucursal_Info> Get_List_cobro_tipo_Param_conta_x_sucursal(int IdEmpresa, string IdCobro_tipo)
        {
            try
            {
                List<cxc_cobro_tipo_Param_conta_x_sucursal_Info> lista = new List<cxc_cobro_tipo_Param_conta_x_sucursal_Info>();
                EntitiesCuentas_x_Cobrar context = new EntitiesCuentas_x_Cobrar();
                var x = from q in context.vwcxc_cobro_tipo_Param_conta_x_sucursal where q.IdEmpresa == IdEmpresa && q.IdCobro_tipo == IdCobro_tipo select q;
                foreach (var item in x)
                {
                    cxc_cobro_tipo_Param_conta_x_sucursal_Info info = new cxc_cobro_tipo_Param_conta_x_sucursal_Info();

                    info.IdCobro_tipo = item.IdCobro_tipo;
                    info.IdCtaCble = item.IdCtaCble;                    
                    info.IdEmpresa = item.IdEmpresa;
                    info.IdSucursal = item.IdSucursal;
                    info.Sucursal = item.Sucursal;
                    info.IdCtaCble_Anticipo = item.IdCtaCble_Anticipo;
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
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public Boolean GuardarDB(List<cxc_cobro_tipo_Param_conta_x_sucursal_Info> lista, int idempresa)
        {
            bool resul = true;
            try
            {
                using (EntitiesCuentas_x_Cobrar oEnt = new EntitiesCuentas_x_Cobrar() )
                {
                    string query = "delete cxc_cobro_tipo_Param_conta_x_sucursal where IdEmpresa =  " + idempresa;
                    oEnt.Database.ExecuteSqlCommand(query);

                    foreach (var item in lista)
                    {
                        cxc_cobro_tipo_Param_conta_x_sucursal info = new cxc_cobro_tipo_Param_conta_x_sucursal();
                        info.IdCobro_tipo = item.IdCobro_tipo;
                        info.IdCtaCble = item.IdCtaCble;
                        info.IdEmpresa = item.IdEmpresa;
                        info.IdSucursal = item.IdSucursal;
                        info.IdCtaCble_Anticipo = item.IdCtaCble_Anticipo;
                        oEnt.cxc_cobro_tipo_Param_conta_x_sucursal.Add(info);
                    }
                    oEnt.SaveChanges();
                }
                return resul;
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
        
        public Boolean GuardarDB(List<cxc_cobro_tipo_Param_conta_x_sucursal_Info> lista)
        {
            try
            {
                try
                {
                    List<cxc_cobro_tipo_Param_conta_x_sucursal_Info> listaAux = new List<cxc_cobro_tipo_Param_conta_x_sucursal_Info>();
                    int x = 0;
                    foreach (var item in lista)
                    {
                        if (x == 0) { listaAux = Get_List_cobro_tipo_Param_conta_x_sucursal(item.IdEmpresa, item.IdCobro_tipo); x = 1; };
                    }

                    using (EntitiesCuentas_x_Cobrar context = new EntitiesCuentas_x_Cobrar())
                    {
                        foreach (var item in listaAux)
                        {
                            var contact = context.cxc_cobro_tipo_Param_conta_x_sucursal.First(cot => cot.IdEmpresa == item.IdEmpresa && cot.IdSucursal == item.IdSucursal && cot.IdCobro_tipo == item.IdCobro_tipo);
                            context.cxc_cobro_tipo_Param_conta_x_sucursal.Remove(contact);
                            context.SaveChanges();
                        }
                    }
                }
                catch (Exception ex)
                {
                    string arreglo = ToString();
                    tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                    tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                        "", "", "", "", DateTime.Now);
                    oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                    mensaje = ex.InnerException + " " + ex.Message;
                }

                using (EntitiesCuentas_x_Cobrar context = new EntitiesCuentas_x_Cobrar())
                {
                   
                    
                    foreach (var item in lista)
                    {

                        EntitiesCuentas_x_Cobrar CxC = new EntitiesCuentas_x_Cobrar();
                        //var contactG = cxc_cobro_tipo_Param_conta_x_sucursal.Createcxc_cobro_tipo_Param_conta_x_sucursal(0, 0,"","");
                        //var addressG = new cxc_cobro_tipo_Param_conta_x_sucursal();
                        cxc_cobro_tipo_Param_conta_x_sucursal addressG = new cxc_cobro_tipo_Param_conta_x_sucursal();

                        addressG.IdCobro_tipo = item.IdCobro_tipo;

                        if (item.IdCtaCble == "")
                        {
                            addressG.IdCtaCble = null;
                        }
                        else
                        {
                            addressG.IdCtaCble= item.IdCtaCble;

                        }

                        if (item.IdCtaCble_Anticipo == "")
                        {
                            addressG.IdCtaCble_Anticipo = null;
                        }
                        else
                        {
                            addressG.IdCtaCble_Anticipo = item.IdCtaCble_Anticipo;

                        } 
                        addressG.IdEmpresa = item.IdEmpresa;
                        addressG.IdSucursal = item.IdSucursal;
                        //contactG = addressG;
                        //CxC.cxc_cobro_tipo_Param_conta_x_sucursal.Add(contactG);
                        //CxC.SaveChanges();
                        context.cxc_cobro_tipo_Param_conta_x_sucursal.Add(addressG);
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
    }
}
