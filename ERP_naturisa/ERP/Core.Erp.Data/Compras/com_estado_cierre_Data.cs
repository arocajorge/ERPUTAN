using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Compras;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.Compras
{
    public class com_estado_cierre_Data
    {
        string mensaje = "";

        

        public List<com_estado_cierre_Info> Get_List_estado_cierre()
        {
            try
            {
                List<com_estado_cierre_Info> Lst = new List<com_estado_cierre_Info>();
                EntitiesCompras oEnti = new EntitiesCompras();

                var Query = from q in oEnti.com_estado_cierre
                            select q;

                foreach (var item in Query)
                {
                    com_estado_cierre_Info Obj = new com_estado_cierre_Info();
                    Obj.IdEstado_cierre = item.IdEstado_cierre;
                    Obj.Descripcion = item.Descripcion;
                    Obj.estado = item.estado;

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
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public Boolean GrabarDB(com_estado_cierre_Info Info, ref string msg)
        {
            try
            {
                using (EntitiesCompras DBCom = new EntitiesCompras())
                {
                    var que = from C in DBCom.com_estado_cierre
                              where C.IdEstado_cierre == Info.IdEstado_cierre
                              select C;

                    if (que.Count() == 0)
                    {
                        var TablaDb = new com_estado_cierre();

                        TablaDb.IdEstado_cierre = Info.IdEstado_cierre;
                        TablaDb.Descripcion = Info.Descripcion;
                        TablaDb.estado = Info.estado;
                        TablaDb.IdUsuarioUltMod = Info.IdUsuarioUltMod;
                        TablaDb.Fecha_Transac = Info.Fecha_Transac;

                        DBCom.com_estado_cierre.Add(TablaDb);
                        DBCom.SaveChanges();
                    }
                    else
                    {
                       
                        msg = "Error en el ingreso; código Existente";
                        return false;
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

        public Boolean ModificarDB(com_estado_cierre_Info Info, ref string msg)
        {
            try
            {
                using (EntitiesCompras context = new EntitiesCompras())
                {
                    var contact = context.com_estado_cierre.FirstOrDefault(v => v.IdEstado_cierre == Info.IdEstado_cierre);

                    if (contact != null)
                    {

                        contact.IdEstado_cierre = Info.IdEstado_cierre;
                        contact.Descripcion = Info.Descripcion;
                        contact.estado = Info.estado;
                        contact.Fecha_UltMod = Info.Fecha_UltMod;
                        contact.IdUsuarioUltMod = Info.IdUsuarioUltMod;
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
                throw new Exception(ex.ToString());
            }
        }

        public Boolean AnularDB(com_estado_cierre_Info Info, ref string msg)
        {
            try
            {
                using (EntitiesCompras context = new EntitiesCompras())
                {
                    var contact = context.com_estado_cierre.FirstOrDefault(v => v.IdEstado_cierre == Info.IdEstado_cierre);

                    if (contact != null)
                    {

                        contact.estado = "I";
                        contact.IdUsuarioUltAnu = Info.IdUsuarioUltAnu;
                        contact.FechaHoraAnul = Info.FechaHoraAnul;
                        contact.MotivoAnulacion = Info.MotivoAnulacion;
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
                throw new Exception(ex.ToString());
            }
        }
    }
}
