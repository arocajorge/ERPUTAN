using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Produccion_Talme;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.Produccion_Talme
{
    public class prod_ChatarraTipo_CusTalme_Data
    {
        string mensaje = "";
        public List<prod_ChatarraTipo_CusTalme_Info> Get_List_ChatarraTipo_CusTalme(int IdEmpresa)
        {
                List<prod_ChatarraTipo_CusTalme_Info> Lst = new List<prod_ChatarraTipo_CusTalme_Info>();
                EntitiesProduccion oEnti = new EntitiesProduccion();
            try
            {

                var Query = from q in oEnti.prod_ChatarraTipo_CusTalme where q.IdEmpresa == IdEmpresa
                            select q;
                foreach (var item in Query)
                {
                    prod_ChatarraTipo_CusTalme_Info Obj = new prod_ChatarraTipo_CusTalme_Info();
                    Obj.IdEmpresa = item.IdEmpresa;
                    Obj.IdTipoChatarra = item.IdTipoChatarra;
                    Obj.Descripcion = item.Descripcion;
                    Obj.Estado = item.Estado;
                    Obj.Precio = Convert.ToDouble(item.Precio);
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

        public int GetId(int idEmpresa)
        {
            try
            {
                int Id;
                EntitiesProduccion OEPActivoFijo = new EntitiesProduccion();
                var select = from q in OEPActivoFijo.prod_ChatarraTipo_CusTalme
                             where q.IdEmpresa==idEmpresa
                             select q;

                if (select.ToList().Count < 1)
                {
                    Id = 1;
                }
                else
                {
                    var select_pv = (from q in OEPActivoFijo.prod_ChatarraTipo_CusTalme
                                     where q.IdEmpresa == idEmpresa
                                     select q.IdTipoChatarra).Max();
                    Id = Convert.ToInt32(select_pv.ToString()) + 1;
                }
                return Id;
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

        public Boolean GrabarDB(prod_ChatarraTipo_CusTalme_Info Lst, ref int Id, ref string mensaje)
        {
            try
            {
                using (EntitiesProduccion Context = new EntitiesProduccion())
                    {
                        prod_ChatarraTipo_CusTalme Deta = new prod_ChatarraTipo_CusTalme();

                        Deta.IdEmpresa = Lst.IdEmpresa;
                        Deta.IdTipoChatarra = Id = GetId(Lst.IdEmpresa);
                        Deta.Precio = Lst.Precio;
                        Deta.Descripcion = Lst.Descripcion;
                        Deta.Estado = Lst.Estado;

                        Context.prod_ChatarraTipo_CusTalme.Add(Deta);
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

        public Boolean ModificarDB(prod_ChatarraTipo_CusTalme_Info prI, ref string mensaje)
        {
            try
            {
                using (EntitiesProduccion context = new EntitiesProduccion())
                {
                    var contact = context.prod_ChatarraTipo_CusTalme.FirstOrDefault(VProdu => VProdu.IdEmpresa == prI.IdEmpresa && VProdu.IdTipoChatarra == prI.IdTipoChatarra);
                    if (contact != null)
                    {
                        contact.Precio = prI.Precio;
                        contact.Descripcion = prI.Descripcion;
                        contact.Estado = prI.Estado;

                        context.SaveChanges();

                        mensaje = "Se ha procedido a actualizar los datos exitosamente...";
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

        public Boolean AnularDB(prod_ChatarraTipo_CusTalme_Info info)
        {
            try
            {
                using (EntitiesProduccion context = new EntitiesProduccion())
                {
                    var contact = context.prod_ChatarraTipo_CusTalme.FirstOrDefault(minfo => minfo.IdEmpresa == info.IdEmpresa && minfo.IdTipoChatarra == info.IdTipoChatarra);
                    if (contact != null)
                    {
                        contact.Estado = "I";
                        context.SaveChanges();
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
    }
}
