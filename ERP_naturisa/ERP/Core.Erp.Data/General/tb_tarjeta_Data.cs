using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Data.General
{
    public class tb_tarjeta_Data
    {
        string mensaje = "";
        public int GetId()
        {
            try
            {
                    int Id;
                EntitiesGeneral oEnti = new EntitiesGeneral();
                var select = from q in oEnti.tb_tarjeta
                             select q;

                if (select.ToList().Count() == 0)
                {
                    Id = 1;
                }
                else
                {
                    var select_em = (from q in oEnti.tb_tarjeta
                                     select q.IdTarjeta).Max();
                    Id = Convert.ToInt32(select_em.ToString()) + 1;
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
                throw new Exception(ex.ToString());
            }
        }

        public List<tb_tarjeta_Info> Get_List_tarjeta() 
        {
            try
            {
                List < tb_tarjeta_Info > lst = new List<tb_tarjeta_Info>();

                EntitiesGeneral oEnti = new EntitiesGeneral();



                var tarjetas = from q in oEnti.tb_tarjeta
                               select q;

                foreach (var item in tarjetas)
                {

                    tb_tarjeta_Info info = new tb_tarjeta_Info();
                    info.IdTarjeta = item.IdTarjeta;
                    info.tr_Descripcion = item.tr_Descripcion;
                    info.Estado = item.Estado;
                    info.IdBanco = item.IdBanco;
                    lst.Add(info);
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
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public Boolean GuardarDB(tb_tarjeta_Info  Info)
        {
            try
            {
                EntitiesGeneral context = new EntitiesGeneral();
                var tarjeta = new tb_tarjeta();

                tarjeta.IdTarjeta = Info.IdTarjeta;
                tarjeta.tr_Descripcion = Info.tr_Descripcion;
                tarjeta.IdBanco = Info.IdBanco;
                tarjeta.Estado = Info.Estado;
                context.tb_tarjeta.Add(tarjeta);
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
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public Boolean ModificarDB(tb_tarjeta_Info Info)
        {
            try
            {
                EntitiesGeneral context = new EntitiesGeneral();
                var tarjeta = context.tb_tarjeta.First(var => var.IdTarjeta == Info.IdTarjeta);
                tarjeta.tr_Descripcion = Info.tr_Descripcion;
                tarjeta.IdBanco = Info.IdBanco;
                tarjeta.Estado = Info.Estado;
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
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public Boolean AnularDB(tb_tarjeta_Info Info)
        {
            try
            {
                EntitiesGeneral context = new EntitiesGeneral();
                var tarjeta = context.tb_tarjeta.FirstOrDefault(var => var.IdTarjeta == Info.IdTarjeta);
                if (tarjeta != null)
                {
                    tarjeta.Fecha_UltAnu = DateTime.Now;
                    tarjeta.IdUsuarioUltAnu = Info.IdUsuarioUltAnu;
                    tarjeta.MotivoAnulacion = Info.MotivoAnulacion;
                    tarjeta.Estado = "I";
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
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }
    }
}
