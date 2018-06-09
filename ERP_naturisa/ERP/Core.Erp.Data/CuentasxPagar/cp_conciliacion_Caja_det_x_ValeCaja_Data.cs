using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Info.General;
using Core.Erp.Data.General;
using Core.Erp.Info.Caja;
namespace Core.Erp.Data.CuentasxPagar
{
   public class cp_conciliacion_Caja_det_x_ValeCaja_Data
    {
       string mensaje = "";

       public int Get_Secuencia_det(int IdEmpresa, decimal IdConciliacion_Caja)
       {
           try
           {
               int Id;
               EntitiesCuentasxPagar ECXP = new EntitiesCuentasxPagar();


               var select_ = (from t in ECXP.cp_conciliacion_Caja_det_x_ValeCaja
                              where t.IdEmpresa == IdEmpresa && t.IdConciliacion_Caja == IdConciliacion_Caja
                              select t);

               if (select_.Count() <= 0)
                   Id = 1;
               else
               {
                   Id = Convert.ToInt32(select_.Max(q => q.Secuencia)) + 1;
               }
               return Id;

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
            
       public Boolean GrabarDB(List<cp_conciliacion_Caja_det_x_ValeCaja_Info> lista, ref string mensaje)
        {
            try
            {
                foreach (var item in lista)
                {
                   
                    using (EntitiesCuentasxPagar context = new EntitiesCuentasxPagar())
                    {

                        var lst = from q in context.cp_conciliacion_Caja_det_x_ValeCaja
                                  where q.IdEmpresa_movcaja == item.IdEmpresa_movcaja
                                  && q.IdTipocbte_movcaja == item.IdTipocbte_movcaja
                                  && q.IdCbteCble_movcaja == item.IdCbteCble_movcaja
                                  && q.IdConciliacion_Caja == item.IdConciliacion_Caja
                                  select q;

                        if (lst.Count() == 0)
                        {

                            var lst_2 = from q in context.cp_conciliacion_Caja_det_x_ValeCaja
                                      where q.IdEmpresa == item.IdEmpresa
                                      && q.IdConciliacion_Caja == item.IdConciliacion_Caja
                                      && q.Secuencia == item.Secuencia
                                      select q;

                            if (lst_2.Count() == 0)
                            {
                                cp_conciliacion_Caja_det_x_ValeCaja address = new cp_conciliacion_Caja_det_x_ValeCaja();

                                address.IdEmpresa = item.IdEmpresa;
                                address.IdConciliacion_Caja = item.IdConciliacion_Caja;
                                address.Secuencia = item.Secuencia;
                                address.IdEmpresa_movcaja = item.IdEmpresa_movcaja;
                                address.IdCbteCble_movcaja = item.IdCbteCble_movcaja;
                                address.IdTipocbte_movcaja = item.IdTipocbte_movcaja;
                                address.IdCtaCble = item.IdCtaCble;
                                address.IdPunto_cargo = item.IdPunto_cargo == 0 ? null : item.IdPunto_cargo;
                                address.IdPunto_cargo_grupo = item.IdPunto_cargo_grupo == 0 ? null : item.IdPunto_cargo_grupo;
                                address.IdCentroCosto = item.IdCentroCosto == "" ? null : item.IdCentroCosto;
                                address.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo == "" ? null : item.IdCentroCosto_sub_centro_costo;

                                context.cp_conciliacion_Caja_det_x_ValeCaja.Add(address);
                                context.SaveChanges();
                            }
                        }
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
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

       public Boolean GrabarDB(cp_conciliacion_Caja_det_x_ValeCaja_Info info, ref string mensaje)
        {
            try
            {
                using (EntitiesCuentasxPagar context = new EntitiesCuentasxPagar())
                {
                    EntitiesCuentasxPagar EDB = new EntitiesCuentasxPagar();
                    cp_conciliacion_Caja_det_x_ValeCaja address = new cp_conciliacion_Caja_det_x_ValeCaja();
                    address.IdEmpresa = info.IdEmpresa;
                    address.IdConciliacion_Caja = info.IdConciliacion_Caja;
                    address.Secuencia = info.Secuencia;
                    address.IdEmpresa_movcaja = info.IdEmpresa_movcaja;
                    address.IdCbteCble_movcaja = info.IdCbteCble_movcaja;
                    address.IdTipocbte_movcaja = info.IdTipocbte_movcaja;
                    address.IdCtaCble = info.IdCtaCble;
                    address.IdPunto_cargo = info.IdPunto_cargo;
                    address.IdPunto_cargo_grupo = info.IdPunto_cargo_grupo;
                    address.IdCentroCosto = info.IdCentroCosto;
                    address.IdCentroCosto_sub_centro_costo = info.IdCentroCosto_sub_centro_costo;
                    context.cp_conciliacion_Caja_det_x_ValeCaja.Add(address);
                    context.SaveChanges();
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

       public List<caj_Caja_Movimiento_Info> Get_List_Conciliacion_Caja_Det_ValeCaja(int IdEmpresa, decimal IdConciliacion_caja)
       {
           try
           {
               List<caj_Caja_Movimiento_Info> lM = new List<caj_Caja_Movimiento_Info>();
               using (EntitiesCuentasxPagar Base = new EntitiesCuentasxPagar())
               {
                   var select_ = from T in Base.vwcp_conciliacion_Caja_det_x_ValeCaja
                                 where T.IdEmpresa == IdEmpresa && T.IdConciliacion_Caja == IdConciliacion_caja
                                 select T;

                   foreach (var item in select_)
                   {
                       caj_Caja_Movimiento_Info dat = new caj_Caja_Movimiento_Info();

                       dat.IdEmpresa = item.IdEmpresa;
                       dat.IdConciliacionCaja = item.IdConciliacion_Caja;
                       dat.secuencial = item.Secuencia;
                       dat.IdEmpresa_movcaja = item.IdEmpresa_movcaja;
                       dat.IdCbteCble_movcaja = item.IdCbteCble_movcaja;
                       dat.IdTipocbte_movcaja = item.IdTipocbte_movcaja;
                       dat.IdCtaCble = item.IdCtaCble;
                       dat.IdEmpresa_movcaja = item.IdEmpresa_movcaja;
                       dat.IdCbteCble_movcaja = item.IdCbteCble_movcaja;
                       dat.IdTipocbte_movcaja = item.IdTipocbte_movcaja;
                       dat.cm_Signo = item.cm_Signo;
                       dat.cm_beneficiario = item.cm_beneficiario;
                       dat.cm_valor = item.cr_Valor;
                       dat.IdTipoMovi = item.IdTipoMovi;
                       dat.cm_observacion = item.cm_observacion;
                       dat.IdCaja = item.IdCaja;
                       dat.cm_fecha = item.cm_fecha;
                       dat.IdUsuario_Aprueba = item.IdUsuario_Aprueba;                       
                       dat.Estado = item.Estado;
                       dat.IdTipoFlujo = item.IdTipoFlujo;
                       dat.IdPersona = item.IdPersona;
                       dat.IdTipo_Persona = item.IdTipo_Persona;
                       dat.IdBeneficiario = item.IdBeneficiario;
                       dat.IdEntidad = item.IdEntidad;
                       dat.IdCentroCosto = item.IdCentroCosto;
                       dat.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;
                       dat.nom_TipoMovi = item.nom_TipoMovi;
                       dat.nom_Caja = item.nom_Caja;
                       dat.IdCtaCble_ValeCaja = item.IdCtaCble_ValeCaja;
                       dat.IdPunto_cargo = item.IdPunto_cargo;
                       dat.IdPunto_cargo_grupo = item.IdPunto_cargo_grupo;
                       dat.IdCentroCosto = item.IdCentroCosto;
                       dat.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;
                       lM.Add(dat);
                   }
               }
               return (lM);
           }
           catch (Exception ex)
           {
               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               mensaje = ex.InnerException + " " + ex.Message;
               throw new Exception(ex.InnerException.ToString());
           }
       }

       public Boolean ModificarDB(cp_conciliacion_Caja_det_x_ValeCaja_Info info)
       {
           try
           {
               using (EntitiesCuentasxPagar Context = new EntitiesCuentasxPagar())
               {
                   cp_conciliacion_Caja_det_x_ValeCaja Entity = Context.cp_conciliacion_Caja_det_x_ValeCaja.FirstOrDefault(q => q.IdEmpresa_movcaja == info.IdEmpresa && q.IdCbteCble_movcaja == info.IdCbteCble_movcaja && q.IdTipocbte_movcaja == info.IdTipocbte_movcaja);
                   if (Entity!=null)
                   {
                       Entity.IdPunto_cargo = info.IdPunto_cargo == 0 ? null : info.IdPunto_cargo;
                       Entity.IdPunto_cargo_grupo = info.IdPunto_cargo_grupo == 0 ? null : info.IdPunto_cargo_grupo;
                       Entity.IdCentroCosto = info.IdCentroCosto == "" ? null : info.IdCentroCosto;
                       Entity.IdCentroCosto_sub_centro_costo = info.IdCentroCosto_sub_centro_costo == "" ? null : info.IdCentroCosto_sub_centro_costo;
                       Context.SaveChanges();
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
               throw new Exception(ex.InnerException.ToString());
           }
       }

    }
}
