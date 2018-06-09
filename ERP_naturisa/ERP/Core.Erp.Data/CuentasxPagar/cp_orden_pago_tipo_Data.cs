using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Data.CuentasxPagar
{
    public class cp_orden_pago_tipo_Data
    {
        string mensaje = "";

        public List<cp_orden_pago_tipo_Info> Get_List_orden_pago_tipo()
        {
            try
            {
                EntitiesCuentasxPagar context = new EntitiesCuentasxPagar();
                List<cp_orden_pago_tipo_Info> lst = new List<cp_orden_pago_tipo_Info>();
                var select = from q in context.cp_orden_pago_tipo
                             select q;

                cp_orden_pago_tipo_Info Info;
                foreach(var item in select)
                {
                    Info = new cp_orden_pago_tipo_Info();
                    Info.IdTipo_op = item.IdTipo_op;
                    Info.Descripcion = item.Descripcion;
                    Info.Estado = item.Estado;
                    if (item.GeneraDiario == "S")
                    {
                        Info.GeneraDiario = "Si";
                    }
                    else
                    {
                        Info.GeneraDiario = "No";
                    }
                    Info.check = false;
                    lst.Add(Info);
                }
                return lst;
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

                var Existe = from q in context.cp_orden_pago_tipo
                             where q.IdTipo_op == Cod
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

        public Boolean ModificarDB(List<cp_orden_pago_tipo_Info> lst)
        {
            try
            {
                foreach (cp_orden_pago_tipo_Info item in lst)
                {
                    if (ValidarCodigoExiste(item.IdTipo_op))
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

        public Boolean GuardarDB(cp_orden_pago_tipo_Info Info)
        {
            try
            {
                EntitiesCuentasxPagar context = new EntitiesCuentasxPagar();
                var address = new cp_orden_pago_tipo();
                address.IdTipo_op = Info.IdTipo_op;
                address.Descripcion = Info.Descripcion;
                address.Estado = Info.Estado;
                address.GeneraDiario = Info.GeneraDiario;
                context.cp_orden_pago_tipo.Add(address);
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

        public Boolean ModificarDB(cp_orden_pago_tipo_Info Info)
        {
            try
            {
                EntitiesCuentasxPagar context = new EntitiesCuentasxPagar();
                var address = context.cp_orden_pago_tipo.FirstOrDefault(var =>  var.IdTipo_op == Info.IdTipo_op);
                if (address != null)
                {
                    address.Descripcion = Info.Descripcion;
                    address.GeneraDiario = Info.GeneraDiario;
                    address.Estado = Info.Estado;
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

        public List<cp_orden_pago_tipo_Info> Get_List_orden_pago_tipo_x_Empresa(int IdEmpresa)
       {
           try
           {
               List<cp_orden_pago_tipo_Info> lM = new List<cp_orden_pago_tipo_Info>();
               EntitiesCuentasxPagar OEUser = new EntitiesCuentasxPagar();

               var OrdenTipoPago = from selec in OEUser.vwcp_orden_pago_tipo_x_empresa
                                   where selec.Estado == "A" && selec.IdEmpresa==IdEmpresa
                                   select selec ;

               foreach (var item in OrdenTipoPago)
               {
                   cp_orden_pago_tipo_Info info = new cp_orden_pago_tipo_Info();
                   info.IdTipo_op = item.IdTipo_op;
                   info.Descripcion = item.Descripcion;
                   info.Estado =item.Estado;
                   info.GeneraDiario = item.GeneraDiario;


                   info.IdEmpresa = item.IdEmpresa;
                   info.IdCtaCble = item.IdCtaCble;
                   info.IdCtaCble_Credito = item.IdCtaCble_Credito;
                   info.IdCentroCosto = item.IdCentroCosto;
                   info.IdTipoCbte_OP = item.IdTipoCbte_OP;
                   info.IdTipoCbte_OP_anulacion = item.IdTipoCbte_OP_anulacion;
                   info.IdEstadoAprobacion = item.IdEstadoAprobacion;
                   info.Dispara_Alerta = (item.Dispara_Alerta == null) ? false : Convert.ToBoolean(item.Dispara_Alerta);



                   lM.Add(info);
               }
               return (lM);
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
