using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Data.Contabilidad
{

    public class ct_Cbtecble_det_Data
    {
        string mensaje = "";

         public List<ct_Cbtecble_det_Info> Get_list_Cbtecble_det(int IdEmpresa,ref string MensajeError)
        {
            try
            {
                List<ct_Cbtecble_det_Info> lM = new List<ct_Cbtecble_det_Info>();
                EntitiesDBConta OECbtecble_det = new EntitiesDBConta();
                var selectCbtecble_det = from C in OECbtecble_det.ct_cbtecble_det
                                         where C.IdEmpresa == IdEmpresa 
                                       select C;

                foreach (ct_cbtecble_det item in selectCbtecble_det)
                {
                    ct_Cbtecble_det_Info Cbt = new ct_Cbtecble_det_Info();
                    Cbt.IdEmpresa = item.IdEmpresa;
                    Cbt.IdTipoCbte = item.IdTipoCbte;
                    Cbt.IdCbteCble = item.IdCbteCble;
                    Cbt.secuencia = item.secuencia;
                    Cbt.IdCtaCble = item.IdCtaCble;
                    Cbt.IdCentroCosto = item.IdCentroCosto;
                    Cbt.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;
                    Cbt.dc_Valor = item.dc_Valor;
                    Cbt.dc_Observacion = item.dc_Observacion;
                    Cbt.IdPunto_cargo = item.IdPunto_cargo;
                    Cbt.dc_para_conciliar = (item.dc_para_conciliar == null) ? false : Convert.ToBoolean(item.dc_para_conciliar);

                    lM.Add(Cbt);
                }

                return (lM);
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);

                MensajeError = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                throw new Exception(ex.ToString());
            }


        }

         public List<ct_Cbtecble_det_Info> Get_list_Cbtecble_det(int IdEmpresa, int IdTipoCbte, decimal IdCbteCble,ref string MensajeError)
        {
            try
            {
                List<ct_Cbtecble_det_Info> lM = new List<ct_Cbtecble_det_Info>();
                EntitiesDBConta OECbtecble_det = new EntitiesDBConta();
                var selectCbtecble_det = from C in OECbtecble_det.ct_cbtecble_det
                                         join Cc in OECbtecble_det.ct_centro_costo on new { C.IdEmpresa, C.IdCentroCosto } equals new { Cc.IdEmpresa, Cc.IdCentroCosto } into cen
                                         from subquerry in cen.DefaultIfEmpty()
                                         join Ct in OECbtecble_det.ct_plancta on new { C.IdEmpresa, C.IdCtaCble } equals new { Ct.IdEmpresa, Ct.IdCtaCble }
                                         where C.IdEmpresa == IdEmpresa && C.IdCbteCble == IdCbteCble && C.IdTipoCbte == IdTipoCbte
                                         select new
                                         {
                                             C.IdEmpresa,
                                             C.IdTipoCbte,
                                             C.IdCbteCble,
                                             C.secuencia,
                                             C.IdCtaCble,
                                             C.IdCentroCosto,
                                             C.IdCentroCosto_sub_centro_costo,
                                             C.dc_Valor,
                                             C.dc_Observacion,
                                             subquerry.Centro_costo,
                                             Ct.pc_Cuenta,
                                             C.IdPunto_cargo,
                                             C.IdPunto_cargo_grupo,
                                             C.dc_para_conciliar 

                                         };

                foreach (var item in selectCbtecble_det)
                {
                    ct_Cbtecble_det_Info Cbt = new ct_Cbtecble_det_Info();
                    Cbt.IdEmpresa = item.IdEmpresa;
                    Cbt.IdTipoCbte = item.IdTipoCbte;
                    Cbt.IdCbteCble = item.IdCbteCble;
                    Cbt.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;
                    Cbt.IdCtaCble = item.IdCtaCble;
                    Cbt.secuencia = item.secuencia;
                    Cbt.IdCentroCosto = item.IdCentroCosto;
                    Cbt.dc_Valor = item.dc_Valor;
                    Cbt.dc_Observacion = item.dc_Observacion;
                    Cbt.NomCtaCble =item.pc_Cuenta ;
                    Cbt.NomCentroCosto=(item.Centro_costo!=null)? item.Centro_costo : "" ;
                    Cbt.IdPunto_cargo = item.IdPunto_cargo;
                    Cbt.IdPunto_cargo_grupo = item.IdPunto_cargo_grupo;
                    Cbt.IdRegistro = item.IdCentroCosto_sub_centro_costo == null ? null : item.IdCentroCosto + "-" + item.IdCentroCosto_sub_centro_costo;
                    Cbt.dc_para_conciliar = (item.dc_para_conciliar == null) ? false : Convert.ToBoolean(item.dc_para_conciliar);
                    lM.Add(Cbt);
                }

                return (lM);
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);

                MensajeError = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }


        }

         public Boolean ModificarDB(ct_Cbtecble_det_Info _CbteCbleInfo,ref string MensajeError)
         {
             try
             {
                 bool respuesta = true;

                 using (EntitiesDBConta context = new EntitiesDBConta())
                 {
                     var contact = context.ct_cbtecble_det.FirstOrDefault(tbCbteCble => tbCbteCble.IdEmpresa == _CbteCbleInfo.IdEmpresa 
                         && tbCbteCble.IdTipoCbte==_CbteCbleInfo.IdTipoCbte 
                         &&  tbCbteCble.IdCbteCble == _CbteCbleInfo.IdCbteCble 
                         && tbCbteCble.secuencia==_CbteCbleInfo.secuencia);

                     if (contact != null)
                     {
                         contact.IdCentroCosto = _CbteCbleInfo.IdCentroCosto;
                         contact.IdCentroCosto_sub_centro_costo = _CbteCbleInfo.IdCentroCosto_sub_centro_costo;
                         contact.IdPunto_cargo_grupo = _CbteCbleInfo.IdPunto_cargo_grupo;
                         contact.IdPunto_cargo = _CbteCbleInfo.IdPunto_cargo;
                         contact.IdCtaCble = _CbteCbleInfo.IdCtaCble;
                         contact.dc_Observacion = _CbteCbleInfo.dc_Observacion;
                         contact.dc_para_conciliar = _CbteCbleInfo.dc_para_conciliar;
                         contact.dc_Valor = _CbteCbleInfo.dc_Valor;
                         context.SaveChanges();
                     }
                     else
                     {
                         respuesta = false;// no actualizo por q no hay el registro q modificar
                     }

                 }
                 return respuesta;
             }
             catch (Exception ex)
             {
                 string arreglo = ToString();
                 tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                 tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                     "", "", "", "", DateTime.Now);
                 oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                 mensaje = ex.ToString();
                 throw new Exception(ex.ToString());
             }
         }

         public Boolean ModificarDB_conciliado(ct_Cbtecble_det_Info _CbteCbleInfo, ref string MensajeError)
         {
             try
             {
                 using (EntitiesDBConta context = new EntitiesDBConta())
                 {
                     var contact = context.ct_cbtecble_det.FirstOrDefault(tbCbteCble => tbCbteCble.IdEmpresa == _CbteCbleInfo.IdEmpresa
                         && tbCbteCble.IdTipoCbte == _CbteCbleInfo.IdTipoCbte
                         && tbCbteCble.IdCbteCble == _CbteCbleInfo.IdCbteCble
                         && tbCbteCble.secuencia == _CbteCbleInfo.secuencia);

                     if (contact != null)
                     {
                         contact.IdCentroCosto = _CbteCbleInfo.IdCentroCosto;
                         contact.IdCentroCosto_sub_centro_costo = _CbteCbleInfo.IdCentroCosto_sub_centro_costo;
                         contact.IdPunto_cargo_grupo = _CbteCbleInfo.IdPunto_cargo_grupo;
                         contact.IdPunto_cargo = _CbteCbleInfo.IdPunto_cargo;
                         contact.dc_Observacion = _CbteCbleInfo.dc_Observacion;
                         contact.dc_para_conciliar = _CbteCbleInfo.dc_para_conciliar;
                         contact.dc_Valor = _CbteCbleInfo.dc_Valor;
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
                 mensaje = ex.ToString();
                 throw new Exception(ex.ToString());
             }
         }
        
         public Boolean GrabarDB(ct_Cbtecble_det_Info _CbteCbleInfo,ref string MensajeError)
         {
             try
             {
                 using (EntitiesDBConta contexto = new EntitiesDBConta())
                 {
                     var lst = from q in contexto.ct_cbtecble_det
                               where q.IdEmpresa == _CbteCbleInfo.IdEmpresa
                               && q.IdTipoCbte == _CbteCbleInfo.IdTipoCbte
                               && q.IdCbteCble == _CbteCbleInfo.IdCbteCble
                               && q.secuencia == _CbteCbleInfo.secuencia
                               select q;

                     if (lst.Count()== 0)
                     {
                         var address_tabla = new ct_cbtecble_det();
                         address_tabla.IdEmpresa = _CbteCbleInfo.IdEmpresa;
                         address_tabla.IdTipoCbte = _CbteCbleInfo.IdTipoCbte;
                         address_tabla.IdCbteCble = _CbteCbleInfo.IdCbteCble;
                         address_tabla.IdCtaCble = _CbteCbleInfo.IdCtaCble;
                         address_tabla.IdCentroCosto = (String.IsNullOrEmpty(_CbteCbleInfo.IdCentroCosto)) ? null : _CbteCbleInfo.IdCentroCosto;
                         address_tabla.IdCentroCosto_sub_centro_costo = (String.IsNullOrEmpty(_CbteCbleInfo.IdCentroCosto_sub_centro_costo)) ? null : _CbteCbleInfo.IdCentroCosto_sub_centro_costo;
                         address_tabla.secuencia = _CbteCbleInfo.secuencia;
                         address_tabla.dc_Valor = _CbteCbleInfo.dc_Valor;
                         address_tabla.dc_Observacion = (_CbteCbleInfo.dc_Observacion == null) ? "" : _CbteCbleInfo.dc_Observacion;
                         address_tabla.IdPunto_cargo = _CbteCbleInfo.IdPunto_cargo;
                         address_tabla.IdPunto_cargo_grupo = _CbteCbleInfo.IdPunto_cargo_grupo;
                         address_tabla.dc_para_conciliar = _CbteCbleInfo.dc_para_conciliar;

                         contexto.ct_cbtecble_det.Add(address_tabla);

                         contexto.SaveChanges();
                         contexto.Dispose();
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

         public Boolean GrabarDB(List<ct_Cbtecble_det_Info> lista,ref string MensajeError)
         {
             try
             {
                 foreach (var item in lista)
                 {
                     if (!GrabarDB(item, ref MensajeError)) 
                         return false;
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

         public Boolean EliminarDB(ct_Cbtecble_det_Info _CbteCbleInfo,ref string MensajeError)
         {
             try
             {
                 using (EntitiesDBConta context = new EntitiesDBConta())
                 {
                     var contact = context.ct_cbtecble_det.FirstOrDefault(tbCbteCble => tbCbteCble.IdEmpresa == _CbteCbleInfo.IdEmpresa && tbCbteCble.IdTipoCbte==_CbteCbleInfo.IdTipoCbte && tbCbteCble.IdCbteCble == _CbteCbleInfo.IdCbteCble);
                     if (contact != null)
                     {
                         context.ct_cbtecble_det.Remove(contact);
                         context.SaveChanges();
                         context.Dispose();
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

         public Boolean EliminarDB_cbte_en_conciliacion(List<ct_Cbtecble_det_Info> lm, ref string MensajeError)
         {
             try
             {
                 if (lm.Count == 0)
                     return true;


                 string comando = "DELETE ct_Cbtecble_det WHERE IdEmpresa = " + lm.First().IdEmpresa + " and IdTipoCbte = " + lm.First().IdTipoCbte + " and IdCbteCble = " + lm.First().IdCbteCble + " and secuencia not in ("+lm.First().secuencia;
                 int cont = 0;
                 foreach (var item in lm)
                 {
                     if (cont == 0)
                     {
                         comando += ","+item.secuencia.ToString();
                     }
                     cont++;
                 }
                 comando += ")";

                 using (EntitiesDBConta Contex = new EntitiesDBConta())
                 {
                     Contex.Database.ExecuteSqlCommand(comando);
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

         public Boolean EliminarDB(List<ct_Cbtecble_det_Info> lm, ref string MensajeError)
         {
             try
             {

                 foreach (var item in lm)
                 {
                     EliminarDB(item, ref MensajeError);
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

         public void Get_SaldoContableMesAnterior(int idempresa, string IdCtaCble, DateTime Fecha, ref decimal  Saldo,ref string MensajeError)
         {
             try
             {
                     EntitiesDBConta db = new EntitiesDBConta();
                     var select_ = from A in db.ct_cbtecble
                                   join B in db.ct_cbtecble_det on new { A.IdEmpresa, A.IdCbteCble, A.IdTipoCbte } equals new { B.IdEmpresa, B.IdCbteCble, B.IdTipoCbte }
                                   where
                                        A.IdEmpresa == idempresa
                                        && B.IdCtaCble == IdCtaCble
                                        && A.cb_Fecha < Fecha
                                   group B by new  { B.IdEmpresa}
                                   into grupvalor
                                   select new { grupvalor.Key, total = grupvalor.Sum(p => p.dc_Valor ) };
                               

                     foreach (var item in select_)
                     {
                         Saldo=Convert.ToDecimal(item.total); 
                 
                     }
             }
             catch (Exception ex)
             {
                 string arreglo = ToString();
                 tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                 tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                     "", "", "", "", DateTime.Now);
                 oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                 mensaje = ex.ToString();
                 throw new Exception(ex.ToString());
             }
         }

         public List<vwct_cbtecble_Con_Saldo_Info> Get_list_Cbtecble_Con_Saldo(int IdEmpresa, DateTime FechaIni, DateTime FechaFin,ref string MensajeError)
         {
             try
             {
                 List<vwct_cbtecble_Con_Saldo_Info> lM = new List<vwct_cbtecble_Con_Saldo_Info>();
                 EntitiesDBConta OECbtecble_det = new EntitiesDBConta();
                 var select_ = from c in OECbtecble_det.vwct_cbtecble_Con_Saldo
                              join cc in OECbtecble_det.ct_cbtecble
                                        on new { c.IdEmpresa, c.IdCbteCble, c.IdTipoCbte } equals new { cc.IdEmpresa, cc.IdCbteCble, cc.IdTipoCbte }
                              join cte in OECbtecble_det.ct_cbtecble_tipo
                                        on new { c.IdEmpresa, c.IdTipoCbte } equals new { cte.IdEmpresa, cte.IdTipoCbte }
                              join ct in OECbtecble_det.ct_cbtecble_tipo
                                        on new { cte.IdTipoCbte } equals new { ct.IdTipoCbte }
                               where c.IdEmpresa == IdEmpresa && c.SaldoDiario > 0 && cc.cb_Fecha > FechaIni && cc.cb_Fecha <FechaFin
                              select new
                              {
                                  c.IdEmpresa,
                                  c.IdTipoCbte,
                                  c.IdCbteCble,
                                  c.dc_Valor,
                                  c.MontoOG,
                                  c.SaldoDiario,
                                  c.Detalle,
                                  cc.cb_Observacion,
                                  ct.tc_TipoCbte,
                                  cc.cb_Fecha 
                              };

                 foreach (var item in select_)
                 {
                     vwct_cbtecble_Con_Saldo_Info dato = new vwct_cbtecble_Con_Saldo_Info();
                     dato.Detalle = item.Detalle;
                     dato.IdCbteCble = item.IdCbteCble;
                     dato.IdEmpresa = item.IdEmpresa;
                     dato.IdTipoCbte = item.IdTipoCbte;
                     dato.MontoOG = item.MontoOG;
                     dato.Observacion = item.cb_Observacion;
                     dato.SaldoDiario = item.SaldoDiario;
                     dato.TipoCbte = item.tc_TipoCbte;
                     dato.ValorDiario = item.dc_Valor;
                     dato.Fecha = item.cb_Fecha;
                     dato.chek = false;
                     

                     lM.Add(dato);
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
                 mensaje = ex.ToString();
                 throw new Exception(ex.ToString());
             }
         }

        public List<vwct_cbtecble_Con_Saldo_Info> Get_list_ObtenerCbtecble_OG_otrosPagos(int IdEmpresa, decimal IdCbteCble, int IdTipoCbte,ref string MensajeError)
         {
             List<vwct_cbtecble_Con_Saldo_Info> lM = new List<vwct_cbtecble_Con_Saldo_Info>();
             try
             {
                 
                 EntitiesDBConta OECbtecble_det = new EntitiesDBConta();
                 var select_ = from c in OECbtecble_det.vwct_cbtecble_Con_Saldo
                               join cc in OECbtecble_det.ct_cbtecble
                                         on new { c.IdEmpresa, c.IdCbteCble, c.IdTipoCbte } equals new { cc.IdEmpresa, cc.IdCbteCble, cc.IdTipoCbte }
                               join cte in OECbtecble_det.ct_cbtecble_tipo
                                         on new { c.IdEmpresa, c.IdTipoCbte } equals new { cte.IdEmpresa, cte.IdTipoCbte }
                               where c.IdEmpresa == IdEmpresa && c.IdTipoCbte == IdTipoCbte && c.IdCbteCble == IdCbteCble
                               select new
                               {
                                   c.IdEmpresa,
                                   c.IdTipoCbte,
                                   c.IdCbteCble,
                                   c.dc_Valor,
                                   c.MontoOG,
                                   c.SaldoDiario,
                                   c.Detalle,
                                   cc.cb_Observacion,
                                   cte.tc_TipoCbte,
                                   cc.cb_Fecha
                               };

                 foreach (var item in select_)
                 {
                     vwct_cbtecble_Con_Saldo_Info dato = new vwct_cbtecble_Con_Saldo_Info();
                     dato.Detalle = item.Detalle;
                     dato.IdCbteCble = item.IdCbteCble;
                     dato.IdEmpresa = item.IdEmpresa;
                     dato.IdTipoCbte = item.IdTipoCbte;
                     dato.MontoOG = item.MontoOG;
                     dato.Observacion = item.cb_Observacion;
                     dato.SaldoDiario = item.SaldoDiario;
                     dato.TipoCbte = item.tc_TipoCbte;
                     dato.ValorDiario = item.dc_Valor;
                     dato.Fecha = item.cb_Fecha;
                     dato.chek = true;
                     

                     lM.Add(dato);
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
                 mensaje = ex.ToString();
                 lM = new List<vwct_cbtecble_Con_Saldo_Info>();
                 throw new Exception(ex.ToString());
             }
         }       
        
        public ct_Cbtecble_det_Data() 
         {
         
         }

        public List<ct_Cbtecble_det_Info> Get_list_CbteCble_x_cp_Conciliacion_caja(int IdEmpresa, decimal IdConciliacion_caja)
        {
            try
            {
                List<ct_Cbtecble_det_Info> Lista = new List<ct_Cbtecble_det_Info>();

                using (EntitiesDBConta Context = new EntitiesDBConta())
                {
                    var lst = from q in Context.vwct_cbtecble_x_cp_Conciliacion_caja
                              where IdEmpresa == q.IdEmpresa && 
                              IdConciliacion_caja == q.IdConciliacion_Caja
                              select q;
                    foreach (var item in lst)
                    {
                        ct_Cbtecble_det_Info info = new ct_Cbtecble_det_Info();
                        info.IdEmpresa_conci = item.IdEmpresa;
                        info.IdConciliacion_Caja = item.IdConciliacion_Caja;
                        info.tipo = item.tc_TipoCbte;
                        info.IdEmpresa = item.IdEmpresa_cbte;
                        info.IdTipoCbte = item.IdTipoCbte;
                        info.IdCbteCble = item.IdCbteCble;
                        info.secuencia = item.secuencia;
                        info.IdCtaCble = item.IdCtaCble;
                        info.NomCtaCble = item.nom_Cuenta;
                        info.IdCentroCosto = item.IdCentroCosto;
                        info.NomCentroCosto = item.nom_Centro_costo;
                        info.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;
                        info.NomSubCentroCosto = item.nom_Centro_costo_sub_centro_costo;
                        info.dc_Valor_D = item.Debe;
                        info.dc_Valor_H = item.Haber;
                        info.dc_Observacion = item.dc_Observacion;
                        info.IdPunto_cargo = item.IdPunto_cargo;
                        info.IdPunto_cargo_grupo = item.IdPunto_cargo_grupo;
                        info.nom_punto_cargo_grupo = item.nom_punto_cargo_grupo;
                        info.nom_punto_cargo = item.nom_punto_cargo;                        
                        Lista.Add(info);
                    }
                }

                return Lista;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }
    }
}
