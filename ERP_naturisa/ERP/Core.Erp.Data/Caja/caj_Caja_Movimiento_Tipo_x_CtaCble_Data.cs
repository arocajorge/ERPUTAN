using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Caja;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.Caja
{
    public class caj_Caja_Movimiento_Tipo_x_CtaCble_Data
    {
        string mensaje = "";

        public List<caj_Caja_Movimiento_Tipo_x_CtaCble_Info> Get_List(int idEmpresa)
        {
            try
            {
                List<caj_Caja_Movimiento_Tipo_x_CtaCble_Info> Lista = new List<caj_Caja_Movimiento_Tipo_x_CtaCble_Info>();

                using (EntitiesCaja Context = new EntitiesCaja())
                {
                    Lista = (from q in Context.caj_Caja_Movimiento_Tipo_x_CtaCble
                             where q.IdEmpresa == idEmpresa
                             select new caj_Caja_Movimiento_Tipo_x_CtaCble_Info
                             {
                                 IdEmpresa = q.IdEmpresa,
                                 IdTipoMovi  = q.IdTipoMovi,
                                 IdCtaCble = q.IdCtaCble
                             }).ToList();
                }

                return Lista;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public Boolean GrabarDB(caj_Caja_Movimiento_Tipo_x_CtaCble_Info Info)
        {
            try
            {
                List<caj_Caja_Movimiento_Tipo_x_CtaCble_Info> Lst = new List<caj_Caja_Movimiento_Tipo_x_CtaCble_Info>();
                using (EntitiesCaja Context = new EntitiesCaja())
                {
                    var Address = new caj_Caja_Movimiento_Tipo_x_CtaCble();
                    Address.IdEmpresa = Info.IdEmpresa;
                    Address.IdTipoMovi = Info.IdTipoMovi;
                    Address.IdCtaCble = Info.IdCtaCble;
                    Context.caj_Caja_Movimiento_Tipo_x_CtaCble.Add(Address);
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
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public Boolean GrabarDB(List<caj_Caja_Movimiento_Tipo_x_CtaCble_Info> Lst)
        {
            try
            {
                foreach (var item in Lst)
                {
                    if(item.IdCtaCble!=null || Convert.ToDecimal(item.IdCtaCble)!=0)
                    GrabarDB(item);
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public Boolean ModificarDB(caj_Caja_Movimiento_Tipo_x_CtaCble_Info info)
        {
            try
            {
                using (EntitiesCaja context = new EntitiesCaja())
                {
                    try
                    {
                        var contact = context.caj_Caja_Movimiento_Tipo_x_CtaCble.FirstOrDefault(minfo => minfo.IdEmpresa == info.IdEmpresa && minfo.IdTipoMovi == info.IdTipoMovi);
                        if (contact != null)
                        {
                            contact.IdEmpresa = info.IdEmpresa;
                            contact.IdTipoMovi = info.IdTipoMovi;
                            contact.IdCtaCble = info.IdCtaCble;
                            context.SaveChanges();
                        }
                        else
                        {
                            GrabarDB(info);

                        }


                    }
                    catch (Exception ex)
                    {
                        string arreglo = ToString();
                        tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                        tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                        oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                        mensaje = ex.InnerException + " " + ex.Message;
                        throw new Exception(ex.ToString());
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
                throw new Exception(ex.ToString());
            }
        }

        public caj_Caja_Movimiento_Tipo_x_CtaCble_Data(){}
    }
}
