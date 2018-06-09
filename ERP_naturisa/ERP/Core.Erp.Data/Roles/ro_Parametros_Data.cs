

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Roles;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.Roles
{
    public class ro_Parametros_Data
    {
        string mensaje = "";
        public List<ro_Parametros_Info> Get_List_Parametros(int IdEmpresa)
        {
            List<ro_Parametros_Info> listado = new List<ro_Parametros_Info>();
            try
            {
                using (EntitiesRoles db = new EntitiesRoles()) { 
                    var datos=(from a in db.ro_Parametros
                                   where a.IdEmpresa==IdEmpresa
                                   select a);

                    foreach (var item in datos)
                    {
                        ro_Parametros_Info info = new ro_Parametros_Info();
                        
                        info.IdTipoCbte_AsientoSueldoXPagar = Convert.ToInt32(item.IdTipoCbte_AsientoSueldoXPagar);
                       
                        info.IdTipo_mov_Ingreso = item.IdTipo_mov_Ingreso;
                        info.IdTipo_mov_Egreso = item.IdTipo_mov_Egreso;
                        info.Dias_considerado_ultimo_pago_quincela_Liq = item.Dias_considerado_ultimo_pago_quincela_Liq; listado.Add(info);
                        info.IdTipoFlujoOP_PagoTerceros = item.IdTipoFlujoOP_PagoTerceros;
                        info.IdBancoOP_PagoTerceros = item.IdBancoOP_PagoTerceros;
                        info.IdFormaOP_PagoTerceros = item.IdFormaOP_PagoTerceros;
                        info.IdTipoOP_PagoTerceros = item.IdTipoOP_PagoTerceros;
                        info.GeneraraOP_PagoTerceros = item.GeneraraOP_PagoTerceros;




                        info.GeneraOP_PagoPrestamos = item.GeneraOP_PagoPrestamos;
                        info.IdBancoOP_PagoPrestamos = item.IdBancoOP_PagoPrestamos;
                        info.IdFormaOP_PagoPrestamos = item.IdFormaOP_PagoPrestamos;
                        info.IdTipoFlujoOP_PagoPrestamos = item.IdTipoFlujoOP_PagoPrestamos;
                        info.IdTipoOP_PagoPrestamos = item.IdTipoOP_PagoPrestamos;



                        info.GeneraOP_ActaFiniquito = item.GeneraOP_ActaFiniquito;
                        info.IdBancoOP_ActaFiniquito = item.IdBancoOP_ActaFiniquito;
                        info.IdFormaPagoOP_ActaFiniquito = item.IdFormaPagoOP_ActaFiniquito;
                        info.IdTipoFlujoOP_ActaFiniquito = item.IdTipoFlujoOP_ActaFiniquito;
                        info.IdTipoOP_ActaFiniquito = item.IdTipoOP_ActaFiniquito;







                        info.DescuentaIESS_LiquidacionVacaciones = item.DescuentaIESS_LiquidacionVacaciones;
                        info.GeneraOP_LiquidacionVacaciones = item.GeneraOP_LiquidacionVacaciones;
                        info.IdBancoOP_LiquidacionVacaciones = item.IdBancoOP_LiquidacionVacaciones;
                        info.IdFormaOP_LiquidacionVacaciones = item.IdFormaOP_LiquidacionVacaciones;
                        info.IdTipoFlujoOP_LiquidacionVacaciones = item.IdTipoFlujoOP_LiquidacionVacaciones;
                        info.IdTipoOP_LiquidacionVacaciones = item.IdTipoOP_LiquidacionVacaciones;
                        info.cta_contable_IESS_Vacaciones = item.cta_contable_IESS_Vacaciones;


                        info.IdNomina_Tipo_Para_Desc_Automat = item.IdNomina_Tipo_Para_Desc_Automat;
                        info.IdNominatipoLiq_Para_Desc_Automat = item.IdNominatipoLiq_Para_Desc_Automat;
                    }



                
                }

                return listado;
            }
            catch (Exception ex)
            {
                string array = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }

        }

        public ro_Parametros_Info Get_Parametros(int IdEmpresa)
        {
            ro_Parametros_Info info = new ro_Parametros_Info();
            try
            {
                using (EntitiesRoles db = new EntitiesRoles())
                {
                    var datos = (from a in db.ro_Parametros
                                 where a.IdEmpresa == IdEmpresa
                                 select a);

                    foreach (var item in datos)
                    {
       
                        info.IdTipoCbte_AsientoSueldoXPagar = Convert.ToInt32(item.IdTipoCbte_AsientoSueldoXPagar);
                       

                        info.IdTipo_mov_Ingreso = item.IdTipo_mov_Ingreso;
                        info.IdTipo_mov_Egreso = item.IdTipo_mov_Egreso;
                        info.Dias_considerado_ultimo_pago_quincela_Liq = item.Dias_considerado_ultimo_pago_quincela_Liq;


                        info.IdTipoFlujoOP_PagoTerceros = item.IdTipoFlujoOP_PagoTerceros;
                        info.IdBancoOP_PagoTerceros = item.IdBancoOP_PagoTerceros;
                        info.IdTipoOP_PagoTerceros = item.IdTipoOP_PagoTerceros;
                        info.IdFormaOP_PagoTerceros = item.IdFormaOP_PagoTerceros;
                        info.GeneraraOP_PagoTerceros = item.GeneraraOP_PagoTerceros;




                        info.GeneraOP_PagoPrestamos = item.GeneraOP_PagoPrestamos;
                        info.IdBancoOP_PagoPrestamos = item.IdBancoOP_PagoPrestamos;
                        info.IdFormaOP_PagoPrestamos = item.IdFormaOP_PagoPrestamos;
                        info.IdTipoFlujoOP_PagoPrestamos = item.IdTipoFlujoOP_PagoPrestamos;
                        info.IdTipoOP_PagoPrestamos = item.IdTipoOP_PagoPrestamos;


                        info.GeneraOP_ActaFiniquito = item.GeneraOP_ActaFiniquito;
                        info.IdBancoOP_ActaFiniquito = item.IdBancoOP_ActaFiniquito;
                        info.IdFormaPagoOP_ActaFiniquito = item.IdFormaPagoOP_ActaFiniquito;
                        info.IdTipoFlujoOP_ActaFiniquito = item.IdTipoFlujoOP_ActaFiniquito;
                        info.IdTipoOP_ActaFiniquito = item.IdTipoOP_ActaFiniquito;


                        info.DescuentaIESS_LiquidacionVacaciones = item.DescuentaIESS_LiquidacionVacaciones;
                        info.GeneraOP_LiquidacionVacaciones = item.GeneraOP_LiquidacionVacaciones;
                        info.IdBancoOP_LiquidacionVacaciones = item.IdBancoOP_LiquidacionVacaciones;
                        info.IdFormaOP_LiquidacionVacaciones = item.IdFormaOP_LiquidacionVacaciones;
                        info.IdTipoFlujoOP_LiquidacionVacaciones = item.IdTipoFlujoOP_LiquidacionVacaciones;
                        info.IdTipoOP_LiquidacionVacaciones = item.IdTipoOP_LiquidacionVacaciones;
                        info.cta_contable_IESS_Vacaciones = item.cta_contable_IESS_Vacaciones;




                        info.IdNomina_Tipo_Para_Desc_Automat = item.IdNomina_Tipo_Para_Desc_Automat;
                        info.IdNominatipoLiq_Para_Desc_Automat = item.IdNominatipoLiq_Para_Desc_Automat;

                    }



                }

                return info;
            }
            catch (Exception ex)
            {
                string array = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }

        }
      
        public Boolean grabarSBasico(int idempresa, double Sbasico)
        {
            try
            {
                using (EntitiesRoles context = new EntitiesRoles())
                {
                    var contact = context.ro_Parametros.First(A => A.IdEmpresa == idempresa);
                    context.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                string array = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public Boolean GrabarBD(ro_Parametros_Info info, ref string msg)
        {
            try
            {
                using (EntitiesRoles db = new EntitiesRoles())
                {
                    var contact = (from a in db.ro_Parametros
                                       where a.IdEmpresa==info.IdEmpresa
                                       select a).FirstOrDefault();
                    if (contact != null)
                    {
                       
                        contact.IdTipoCbte_AsientoSueldoXPagar = info.IdTipoCbte_AsientoSueldoXPagar;

                       
                        contact.IdTipo_mov_Ingreso = info.IdTipo_mov_Ingreso;
                        contact.IdTipo_mov_Egreso = info.IdTipo_mov_Egreso;
                        contact.Dias_considerado_ultimo_pago_quincela_Liq = info.Dias_considerado_ultimo_pago_quincela_Liq;



                        contact.IdTipoFlujoOP_PagoTerceros = info.IdTipoFlujoOP_PagoTerceros;
                        contact.IdBancoOP_PagoTerceros = info.IdBancoOP_PagoTerceros;
                        contact.IdFormaOP_PagoTerceros = info.IdFormaOP_PagoTerceros;
                        contact.IdTipoOP_PagoTerceros = info.IdTipoOP_PagoTerceros;
                        contact.GeneraraOP_PagoTerceros = info.GeneraraOP_PagoTerceros;




                        contact.GeneraOP_PagoPrestamos = info.GeneraOP_PagoPrestamos;
                        contact.IdBancoOP_PagoPrestamos = info.IdBancoOP_PagoPrestamos;
                        contact.IdFormaOP_PagoPrestamos = info.IdFormaOP_PagoPrestamos;
                        contact.IdTipoFlujoOP_PagoPrestamos = info.IdTipoFlujoOP_PagoPrestamos;
                        contact.IdTipoOP_PagoPrestamos = info.IdTipoOP_PagoPrestamos;



                        contact.DescuentaIESS_LiquidacionVacaciones = info.DescuentaIESS_LiquidacionVacaciones;
                        contact.GeneraOP_LiquidacionVacaciones = info.GeneraOP_LiquidacionVacaciones;
                        contact.IdBancoOP_LiquidacionVacaciones = info.IdBancoOP_LiquidacionVacaciones;
                        contact.IdFormaOP_LiquidacionVacaciones = info.IdFormaOP_LiquidacionVacaciones;
                        contact.IdTipoFlujoOP_LiquidacionVacaciones = info.IdTipoFlujoOP_LiquidacionVacaciones;
                        contact.IdTipoOP_LiquidacionVacaciones = info.IdTipoOP_LiquidacionVacaciones;
                        contact.cta_contable_IESS_Vacaciones = info.cta_contable_IESS_Vacaciones;

                        contact.GeneraOP_ActaFiniquito = info.GeneraOP_ActaFiniquito;
                        contact.IdBancoOP_ActaFiniquito = info.IdBancoOP_ActaFiniquito;
                        contact.IdFormaPagoOP_ActaFiniquito = info.IdFormaPagoOP_ActaFiniquito;
                        contact.IdTipoFlujoOP_ActaFiniquito = info.IdTipoFlujoOP_ActaFiniquito;
                        contact.IdTipoOP_ActaFiniquito = info.IdTipoOP_ActaFiniquito;


                        contact.IdNomina_Tipo_Para_Desc_Automat = info.IdNomina_Tipo_Para_Desc_Automat;
                        contact.IdNominatipoLiq_Para_Desc_Automat = info.IdNominatipoLiq_Para_Desc_Automat;
                        db.SaveChanges();
                    }

                    else
                    {
                        ro_Parametros add = new ro_Parametros();
                        add.IdEmpresa = info.IdEmpresa;
                        
                        add.IdTipoCbte_AsientoSueldoXPagar = info.IdTipoCbte_AsientoSueldoXPagar;

                        
                        add.IdTipo_mov_Ingreso = info.IdTipo_mov_Ingreso;
                        add.IdTipo_mov_Egreso = info.IdTipo_mov_Egreso;
                        add.Dias_considerado_ultimo_pago_quincela_Liq = info.Dias_considerado_ultimo_pago_quincela_Liq;


                        add.IdTipoFlujoOP_PagoTerceros = info.IdTipoFlujoOP_PagoTerceros;
                        add.IdBancoOP_PagoTerceros = info.IdBancoOP_PagoTerceros;
                        add.IdFormaOP_PagoTerceros = info.IdFormaOP_PagoTerceros;
                        add.IdFormaOP_PagoTerceros = info.IdFormaOP_PagoTerceros;
                        add.GeneraraOP_PagoTerceros = info.GeneraraOP_PagoTerceros;




                        add.GeneraOP_PagoPrestamos = info.GeneraOP_PagoPrestamos;
                        add.IdBancoOP_PagoPrestamos = info.IdBancoOP_PagoPrestamos;
                        add.IdFormaOP_PagoPrestamos = info.IdFormaOP_PagoPrestamos;
                        add.IdTipoFlujoOP_PagoPrestamos = info.IdTipoFlujoOP_PagoPrestamos;
                        add.IdTipoOP_PagoPrestamos = info.IdTipoOP_PagoPrestamos;

                        add.DescuentaIESS_LiquidacionVacaciones = info.DescuentaIESS_LiquidacionVacaciones;
                        add.GeneraOP_LiquidacionVacaciones = info.GeneraOP_LiquidacionVacaciones;
                        add.IdBancoOP_LiquidacionVacaciones = info.IdBancoOP_LiquidacionVacaciones;
                        add.IdFormaOP_LiquidacionVacaciones = info.IdFormaOP_LiquidacionVacaciones;
                        add.IdTipoFlujoOP_LiquidacionVacaciones = info.IdTipoFlujoOP_LiquidacionVacaciones;
                        add.IdTipoOP_LiquidacionVacaciones = info.IdTipoOP_LiquidacionVacaciones;
                        add.cta_contable_IESS_Vacaciones = info.cta_contable_IESS_Vacaciones; 


                        add.IdNomina_Tipo_Para_Desc_Automat = info.IdNomina_Tipo_Para_Desc_Automat;
                        add.IdNominatipoLiq_Para_Desc_Automat = info.IdNominatipoLiq_Para_Desc_Automat;


                        db.ro_Parametros.Add(add);
                        db.SaveChanges();

                    }






                }
                return true;
            }
            catch (Exception ex)
            {
                string array = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }
    }
}
