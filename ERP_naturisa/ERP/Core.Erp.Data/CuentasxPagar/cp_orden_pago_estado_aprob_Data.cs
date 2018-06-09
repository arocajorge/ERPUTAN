using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Data.CuentasxPagar
{
    public class cp_orden_pago_estado_aprob_Data
    {
        string mensaje = "";

        public List<cp_orden_pago_estado_aprob_Info> Get_List_orden_pago_estado_aprob()
        {
            try
            {
                List<cp_orden_pago_estado_aprob_Info> lista = new List<cp_orden_pago_estado_aprob_Info>();
                lista = new List<cp_orden_pago_estado_aprob_Info>();


                EntitiesCuentasxPagar ORol = new EntitiesCuentasxPagar();

                var sresult = from A in ORol.cp_orden_pago_estado_aprob
                              select A;

                foreach (var item in sresult)
                {
                    cp_orden_pago_estado_aprob_Info Reg = new cp_orden_pago_estado_aprob_Info();

                    Reg.IdEstadoAprobacion = item.IdEstadoAprobacion;
                    Reg.Descripcion = item.Descripcion;

                    lista.Add(Reg);
                }
                return lista;
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

        public Boolean ValidarCodigoExiste(string Cod)
        {
            try
            {
                EntitiesCuentasxPagar context = new EntitiesCuentasxPagar();

                var Existe = from q in context.cp_orden_pago_estado_aprob
                             where q.IdEstadoAprobacion == Cod
                             select q;
                if (Existe.ToList().Count() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
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

        public Boolean ModificarDB(List<cp_orden_pago_estado_aprob_Info> lst)
        {
            try
            {
                foreach (cp_orden_pago_estado_aprob_Info item in lst)
                {
                    if (ValidarCodigoExiste(item.IdEstadoAprobacion))
                    {
                                              
                      ModificarDB(item);                                          
                    }
                    else
                    {
                        GuardarDB(item);
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
       
        public Boolean GuardarDB(cp_orden_pago_estado_aprob_Info Info)
        {
            try
            {
                EntitiesCuentasxPagar context = new EntitiesCuentasxPagar();
                var address = new cp_orden_pago_estado_aprob();
                address.IdEstadoAprobacion = Info.IdEstadoAprobacion;
                address.Descripcion= Info.Descripcion;

                context.cp_orden_pago_estado_aprob.Add(address);
                context.SaveChanges();
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

        public Boolean ModificarDB(cp_orden_pago_estado_aprob_Info Info)
        {
            try
            {
                EntitiesCuentasxPagar context = new EntitiesCuentasxPagar();

                var address = context.cp_orden_pago_estado_aprob.FirstOrDefault(var => var.IdEstadoAprobacion == Info.IdEstadoAprobacion);
                if (address != null)
                {
                    address.Descripcion = Info.Descripcion;
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
    }
}
