using Core.Erp.Info.CuentasxPagar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Data.CuentasxPagar
{
    public class cp_orden_giro_pagos_sri_Data
    {
        string mensaje = "";
        public Boolean GuardarDB(cp_orden_giro_pagos_sri_Info Info)
        {
            try
            {
                List<cp_orden_giro_pagos_sri_Info> Lst = new List<cp_orden_giro_pagos_sri_Info>();
                using (EntitiesCuentasxPagar Context = new EntitiesCuentasxPagar())
                {
                    var Address = new cp_orden_giro_pagos_sri();
                    Address.IdEmpresa = Convert.ToInt32(Info.IdEmpresa);
                    Address.IdCbteCble_Ogiro = Convert.ToDecimal(Info.IdCbteCble_Ogiro);
                    Address.IdTipoCbte_Ogiro = Convert.ToInt32(Info.IdTipoCbte_Ogiro);
                    Address.codigo_pago_sri = Info.codigo_pago_sri;
                    Address.formas_pago_sri = Info.formas_pago_sri;

                    Context.cp_orden_giro_pagos_sri.Add(Address);
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
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public List<cp_orden_giro_pagos_sri_Info> Get_List_orden_giro_pagos_sri()
        {
            try
            {
                List<cp_orden_giro_pagos_sri_Info> Lst = new List<cp_orden_giro_pagos_sri_Info>();
                EntitiesCuentasxPagar oEnti = new EntitiesCuentasxPagar();
                var Query = from q in oEnti.cp_orden_giro_pagos_sri
                            select q;
                foreach (var item in Query)
                {
                    cp_orden_giro_pagos_sri_Info Obj = new cp_orden_giro_pagos_sri_Info();
                    Obj.IdEmpresa = item.IdEmpresa;
                    Obj.IdCbteCble_Ogiro = item.IdCbteCble_Ogiro;
                    Obj.IdTipoCbte_Ogiro = item.IdTipoCbte_Ogiro;
                    Obj.codigo_pago_sri = item.codigo_pago_sri;
                    Obj.formas_pago_sri = item.formas_pago_sri;
                    Lst.Add(Obj);
                }
                return Lst;
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

        public List<cp_orden_giro_pagos_sri_Info> Get_List_orden_giro_pagos_sri(int IdEmpresa=0,decimal IdCbteCble_Ogiro=0,int IdTipoCbte_Ogiro=0)
        {
            try
            {
                using(EntitiesCuentasxPagar enty=new EntitiesCuentasxPagar())
                {
                    string query = "select null as IdEmpresa,null as IdCbteCble_Ogiro,null as IdTipoCbte_Ogiro,a.codigo_pago_sri,a.formas_pago_sri from cp_pagos_sri a";

                    if(IdCbteCble_Ogiro > 0)
                    {
                        var pagosTodos= enty.Database.SqlQuery<cp_orden_giro_pagos_sri_Info>(query).ToList();
                        var pagosAplicado = enty.Database.SqlQuery<cp_orden_giro_pagos_sri_Info>("select * from cp_orden_giro_pagos_sri where IdEmpresa=" + IdEmpresa + " and IdCbteCble_Ogiro=" + IdCbteCble_Ogiro + " and IdTipoCbte_Ogiro=" + IdTipoCbte_Ogiro).ToList();

                        List<cp_orden_giro_pagos_sri_Info> lst = new List<cp_orden_giro_pagos_sri_Info>();
                        foreach (var item in pagosTodos)
                        {
                            item.IdEmpresa = IdEmpresa;
                            item.IdCbteCble_Ogiro = IdCbteCble_Ogiro;
                            item.IdTipoCbte_Ogiro = IdTipoCbte_Ogiro;

                            foreach (var item2 in pagosAplicado)
                            {
                                if (item.codigo_pago_sri == item2.codigo_pago_sri)
                                    item.check = true;

                            }
                        }
                        return pagosTodos;
                    }
                    else
                    {
                        return enty.Database.SqlQuery<cp_orden_giro_pagos_sri_Info>(query).ToList();
                    }
                }
            
            
            
            
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

        public bool EliminarDB(int IdEmpresa, Decimal IdCbteCble_Ogiro, int IdTipoCbte_Ogiro)
        {
            try
            {
                using (EntitiesCuentasxPagar enti = new EntitiesCuentasxPagar())
                {
                    enti.Database.ExecuteSqlCommand("delete cp_orden_giro_pagos_sri where IdEmpresa=" + IdEmpresa + " and IdCbteCble_Ogiro =" + IdCbteCble_Ogiro + " and IdTipoCbte_Ogiro=" + IdTipoCbte_Ogiro);
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

        public cp_orden_giro_pagos_sri_Data(){}
    }
}
