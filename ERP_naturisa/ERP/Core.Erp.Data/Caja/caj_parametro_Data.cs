using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Caja;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Data.Caja
{
    public class caj_parametro_Data
    {
        string mensaje = "";
        public caj_parametro_Info Get_Info_Parametro(int IdEmpresa) 
        {
           caj_parametro_Info info = new caj_parametro_Info();
             EntitiesCaja context = new EntitiesCaja();
            try
            {
                var x = from q in context.caj_parametro where q.IdEmpresa==IdEmpresa select q;
                foreach (var item in x)
                {
                    info.IdEmpresa = item.IdEmpresa;
                    info.IdTipoCbteCble_MoviCaja_Egr = item.IdTipoCbteCble_MoviCaja_Egr;
                    info.IdTipoCbteCble_MoviCaja_Egr_Anu = item.IdTipoCbteCble_MoviCaja_Egr_Anu;
                    info.IdTipoCbteCble_MoviCaja_Ing = item.IdTipoCbteCble_MoviCaja_Ing;
                    info.IdTipoCbteCble_MoviCaja_Ing_Anu = item.IdTipoCbteCble_MoviCaja_Ing_Anu;
                    info.IdTipo_movi_ing_x_reposicion = item.IdTipo_movi_ing_x_reposicion;
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
                throw new Exception(ex.ToString());
            }
        }

        public Boolean ModificarDB(caj_parametro_Info info, List<caj_Caja_Movimiento_Tipo_x_CtaCble_Info> LstTipoxCta)
        {
            try
            {
                using (EntitiesCaja context = new EntitiesCaja())
                {
                    EntitiesCaja param = new EntitiesCaja();
                    var selectBaParam = (from C in param.caj_parametro 
                                         where C.IdEmpresa == info.IdEmpresa 
                                         select C).Count();

                    if (selectBaParam == 0)
                    {
                        var addressG = new caj_parametro();
                        addressG.IdEmpresa = info.IdEmpresa;
                        addressG.Fecha_Transac = info.Fecha_Transac;
                        addressG.IdUsuario = info.IdUsuario;
                        addressG.IdTipoCbteCble_MoviCaja_Egr = info.IdTipoCbteCble_MoviCaja_Egr;
                        addressG.IdTipoCbteCble_MoviCaja_Ing = info.IdTipoCbteCble_MoviCaja_Ing;
                        addressG.IdTipoCbteCble_MoviCaja_Ing_Anu = info.IdTipoCbteCble_MoviCaja_Ing_Anu;
                        addressG.IdTipoCbteCble_MoviCaja_Egr_Anu = info.IdTipoCbteCble_MoviCaja_Egr_Anu;
                        addressG.IdTipo_movi_ing_x_reposicion = info.IdTipo_movi_ing_x_reposicion;
                        context.caj_parametro.Add(addressG);
                        context.SaveChanges();
                    }
                    else
                    {
                        var contact = context.caj_parametro.FirstOrDefault(para => para.IdEmpresa == info.IdEmpresa);
                        if (contact != null)
                        {
                            contact.IdTipoCbteCble_MoviCaja_Egr = info.IdTipoCbteCble_MoviCaja_Egr;
                            contact.IdTipoCbteCble_MoviCaja_Ing = info.IdTipoCbteCble_MoviCaja_Ing;
                            contact.IdTipoCbteCble_MoviCaja_Ing_Anu = info.IdTipoCbteCble_MoviCaja_Ing_Anu;
                            contact.IdTipoCbteCble_MoviCaja_Egr_Anu = info.IdTipoCbteCble_MoviCaja_Egr_Anu;
                            contact.IdTipo_movi_ing_x_reposicion = info.IdTipo_movi_ing_x_reposicion;
                            contact.FechaUltMod = info.FechaUltMod;
                            contact.IdUsuarioUltMod = info.IdUsuarioUltMod;
                            context.SaveChanges();
                        }
                    }

                    //graba las cuentas por tipo de movimiento de caja 

                    caj_Caja_Movimiento_Tipo_x_CtaCble_Data data = new caj_Caja_Movimiento_Tipo_x_CtaCble_Data();

                    data.GrabarDB(LstTipoxCta);

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
                throw new Exception(ex.ToString());
            }
        }
    }
}
