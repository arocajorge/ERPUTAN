using Core.Erp.Data.General;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Info.Facturacion;
using Core.Erp.Info.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Data.Facturacion
{
    public class fa_cliente_x_ct_centro_costo_Data
    {
        String MensajeError = "";

        #region "Insertar, Actualizar, Eliminar"
        public bool Grabar(fa_cliente_x_ct_centro_costo_Info info, ref string mensaje)
        {
            try
            {
                using (Entity_Facturacion_FJ Base = new Entity_Facturacion_FJ())
                {
                    fa_cliente_x_ct_centro_costo address = new fa_cliente_x_ct_centro_costo();
                    address.IdCliente_cli = info.IdCliente_cli;
                    address.IdEmpresa_cc = info.IdEmpresa_cc;
                    address.IdEmpresa_cli = info.IdEmpresa_cli;
                    address.IdCentroCosto_cc = info.IdCentroCosto_cc;
                    address.Observacion = info.Observacion;
                    Base.fa_cliente_x_ct_centro_costo.Add(address);
                    Base.SaveChanges();
                    mensaje = "Se ha guardado exitosamente ";
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = "Se ha producido el siguiente error: " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public bool ModificarBD(fa_cliente_x_ct_centro_costo_Info info, ref string mensaje)
        {
            try
            {
                using (Entity_Facturacion_FJ Base = new Entity_Facturacion_FJ())
                {
                    var address = Base.fa_cliente_x_ct_centro_costo.FirstOrDefault(o => o.IdCliente_cli == info.IdCliente_cli && o.IdCentroCosto_cc == info.IdCentroCosto_cc);
                    if (address != null)
                    {
                        address.IdCliente_cli = info.IdCliente_cli;
                        address.IdEmpresa_cc = info.IdEmpresa_cc;
                        address.IdEmpresa_cli = info.IdEmpresa_cli;
                        address.IdCentroCosto_cc = info.IdCentroCosto_cc;
                        address.Observacion = info.Observacion;
                        Base.SaveChanges();
                        mensaje = "Se actualizo exitosamente. ";
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = "Se ha producido el siguiente error: " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public bool AnularDB(fa_cliente_x_ct_centro_costo_Info info, ref string mensaje)
        {
            try
            {
                using (Entity_Facturacion_FJ Base = new Entity_Facturacion_FJ())
                {
                    var address = Base.fa_cliente_x_ct_centro_costo.FirstOrDefault(o => o.IdCliente_cli == info.IdCliente_cli && o.IdCentroCosto_cc == info.IdCentroCosto_cc);
                    if (address != null)
                    {
                        address.IdCliente_cli = info.IdCliente_cli;
                        address.IdEmpresa_cc = info.IdEmpresa_cc;
                        address.IdEmpresa_cli = info.IdEmpresa_cli;
                        address.IdCentroCosto_cc = info.IdCentroCosto_cc;
                        address.Observacion = info.Observacion;
                        Base.SaveChanges();
                        mensaje = "Se guardo exitosamente.";
                    }
                    return true;
                }
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = "Se ha producido el siguiente error: " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }
        #endregion

        public List<fa_cliente_x_ct_centro_costo_Info> Get_Vista_Clientes_x_Centro_costo(int idEmpresa)
        {
            try
            {
                List<fa_cliente_x_ct_centro_costo_Info> Lista = new List<fa_cliente_x_ct_centro_costo_Info>();

                using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
                {
                    var lst = from q in Context.vwfa_cliente_x_ct_centro_costo
                              where q.IdEmpresa_cc == idEmpresa
                              select q;

                    foreach (var item in lst)
                    {
                        fa_cliente_x_ct_centro_costo_Info info = new fa_cliente_x_ct_centro_costo_Info();

                        info.IdEmpresa_cli = item.IdEmpresa_cli;
                        info.IdCliente_cli = item.IdCliente_cli;
                        info.IdEmpresa_cc = item.IdEmpresa_cc;
                        info.IdCentroCosto_cc = item.IdCentroCosto_cc;
                        info.nom_Centro_costo = item.nom_Centro_costo;
                        info.nom_Cliente = item.nom_Cliente;

                        Lista.Add(info);
                    }
                }

                return Lista;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }
    }
}
