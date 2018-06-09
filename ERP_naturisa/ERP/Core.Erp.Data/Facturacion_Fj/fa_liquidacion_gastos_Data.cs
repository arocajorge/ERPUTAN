using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.Facturacion_FJ;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Data.Facturacion_Fj
{
    public class fa_liquidacion_gastos_Data
    {
        fa_liquidacion_gastos_det_Data oData_Det = new fa_liquidacion_gastos_det_Data();

        public decimal Get_Id(int idEmpresa, ref string mensaje)
        {
            try
            {
                int Id;
                Entity_Facturacion_FJ db = new Entity_Facturacion_FJ();

                var selecte = db.fa_liquidacion_gastos.Count(q => q.IdEmpresa == idEmpresa);

                if (selecte == 0)
                {
                    Id = 1;
                }
                else
                {
                    var select_em = (from q in db.fa_liquidacion_gastos
                                     where q.IdEmpresa == idEmpresa
                                     select q.IdLiquidacion).Max();
                    Id = Convert.ToInt32(select_em.ToString()) + 1;
                }

                return Id;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public List<fa_liquidacion_gastos_Info> Get_List_Liquidacion_Gastos(int IdEmpresa, DateTime FechaIni, DateTime FechaFin, ref string mensaje)
        {
            try
            {
                DateTime Fecha_Ini = Convert.ToDateTime(FechaIni.ToShortDateString());
                DateTime Fecha_Fin = Convert.ToDateTime(FechaFin.ToShortDateString());
                List<fa_liquidacion_gastos_Info> Lista = new List<fa_liquidacion_gastos_Info>();

                using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
                {
                    var lst = from q in Context.vwfa_liquidacion_gastos
                              where q.IdEmpresa == IdEmpresa
                              && q.fecha_liqui >= Fecha_Ini
                              && q.fecha_liqui <= Fecha_Fin
                              select q;

                    foreach (var item in lst)
                    {
                        fa_liquidacion_gastos_Info Info = new fa_liquidacion_gastos_Info();
                        Info.IdEmpresa = item.IdEmpresa;
                        Info.IdLiquidacion = item.IdLiquidacion;
                        Info.IdPeriodo = item.IdPeriodo;
                        Info.cod_liquidacion = item.cod_liquidacion;
                        Info.IdCliente = item.IdCliente;
                        Info.fecha_liqui = item.fecha_liqui;
                        Info.Observacion = item.Observacion;
                        Info.estado = item.estado;
                        Info.IdUsuario = item.IdUsuario;
                        Info.pe_apellido = item.pe_apellido;
                        Info.pe_razonSocial = item.pe_razonSocial;
                        Info.pe_nombre = item.pe_nombre;
                        Info.pe_cedulaRuc = item.pe_cedulaRuc;
                        Info.pe_direccion = item.pe_direccion;
                        Info.pe_telefonoCasa = item.pe_telefonoCasa;

                        Lista.Add(Info);
                    }
                }

                return Lista;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public fa_liquidacion_gastos_Info Get_Info_Liquidacion_Gastos(int IdEmpresa, decimal IdLiquidacion_Gastos, ref string mensaje)
        {
            try
            {
                fa_liquidacion_gastos_Info Info = new fa_liquidacion_gastos_Info();

                using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
                {
                    var lst = from q in Context.vwfa_liquidacion_gastos
                              where q.IdEmpresa == IdEmpresa
                              && q.IdLiquidacion == IdLiquidacion_Gastos
                              select q;

                    foreach (var item in lst)
                    {
                        
                        Info.IdEmpresa = item.IdEmpresa;
                        Info.IdLiquidacion = item.IdLiquidacion;
                        Info.IdPeriodo = item.IdPeriodo;
                        Info.cod_liquidacion = item.cod_liquidacion;
                        Info.IdCliente = item.IdCliente;
                        Info.fecha_liqui = item.fecha_liqui;
                        Info.Observacion = item.Observacion;
                        Info.estado = item.estado;
                        Info.IdUsuario = item.IdUsuario;
                        Info.pe_apellido = item.pe_apellido;
                        Info.pe_razonSocial = item.pe_razonSocial;
                        Info.pe_nombre = item.pe_nombre;
                        Info.pe_cedulaRuc = item.pe_cedulaRuc;
                        Info.pe_direccion = item.pe_direccion;
                        Info.pe_telefonoCasa = item.pe_telefonoCasa;

                        fa_liquidacion_gastos_det_Data Odata_det = new fa_liquidacion_gastos_det_Data();
                        Info.Lis_Detalle = Odata_det.Get_List_Liquidacion_Gastos_Det(Info.IdEmpresa, Info.IdLiquidacion, ref mensaje);
                    }
                }

                return Info;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public bool GuardarDB(fa_liquidacion_gastos_Info Info, ref decimal IdLiquidacion, ref string mensaje)
        {
            try
            {
                IdLiquidacion = Get_Id(Info.IdEmpresa, ref mensaje);

                using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
                {
                    fa_liquidacion_gastos contact = new fa_liquidacion_gastos();

                    contact.IdEmpresa = Info.IdEmpresa;
                    contact.IdLiquidacion = Info.IdLiquidacion = IdLiquidacion;
                    contact.IdPeriodo = Info.IdPeriodo;
                    contact.cod_liquidacion = Info.cod_liquidacion;
                    contact.IdCliente = Info.IdCliente;
                    contact.fecha_liqui = Info.fecha_liqui;
                    contact.Observacion = Info.Observacion;
                    contact.estado = Info.estado;
                    contact.IdUsuario = Info.IdUsuario;
                    contact.Fecha_Transaccion = Info.Fecha_Transaccion;
                    contact.nom_pc = Info.nom_pc;
                    contact.ip = Info.ip;

                    Context.fa_liquidacion_gastos.Add(contact);
                    Context.SaveChanges();
                }

                foreach (var item in Info.Lis_Detalle)
                {
                    item.IdEmpresa = Info.IdEmpresa;
                    item.IdLiquidacion = Info.IdLiquidacion;
                }

                oData_Det.GuardarDB(Info.Lis_Detalle, ref mensaje);

                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public bool ModificarDB(fa_liquidacion_gastos_Info Info, ref string mensaje)
        {
            try
            {
                using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
                {
                    fa_liquidacion_gastos contact = Context.fa_liquidacion_gastos.FirstOrDefault(q => q.IdEmpresa == Info.IdEmpresa && q.IdLiquidacion == Info.IdLiquidacion);
                    if (contact != null)
                    {
                        contact.IdEmpresa = Info.IdEmpresa;
                        contact.IdLiquidacion = Info.IdLiquidacion;
                        contact.IdPeriodo = Info.IdPeriodo;
                        contact.cod_liquidacion = Info.cod_liquidacion;
                        contact.IdCliente = Info.IdCliente;
                        contact.fecha_liqui = Info.fecha_liqui;
                        contact.Observacion = Info.Observacion;
                        contact.estado = "A";
                        contact.IdUsuarioUltModi = Info.IdUsuarioUltModi;
                        contact.Fecha_UltMod = DateTime.Now;
                        contact.nom_pc = Info.nom_pc;
                        contact.ip = Info.ip;
                        Context.SaveChanges();
                    }
                }

                oData_Det.EliminarDB(Info, ref mensaje);

                foreach (var item in Info.Lis_Detalle)
                {
                    item.IdEmpresa = Info.IdEmpresa;
                    item.IdLiquidacion = Info.IdLiquidacion;
                }
                oData_Det.GuardarDB(Info.Lis_Detalle, ref mensaje);

                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public bool AnularDB(fa_liquidacion_gastos_Info Info, ref string mensaje)
        {
            try
            {
                using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
                {
                    fa_liquidacion_gastos contact = Context.fa_liquidacion_gastos.FirstOrDefault(q => q.IdEmpresa == Info.IdEmpresa && q.IdLiquidacion == Info.IdLiquidacion);
                    if (contact != null)
                    {
                        contact.IdUsuarioUltAnu = Info.IdUsuarioUltAnu;
                        contact.Fecha_UltAnu = Info.Fecha_UltAnu;
                        contact.MotivoAnulacion = Info.MotivoAnulacion;
                        contact.estado = "I";

                        Context.SaveChanges();
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
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public List<fa_liquidacion_gastos_Info> Get_List_Liquidacion_Gastos_x_periodo(int IdEmpresa, int idperiodo)
        {
            try
            {

                List<fa_liquidacion_gastos_Info> Lista = new List<fa_liquidacion_gastos_Info>();

                using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
                {
                    var lst = from q in Context.vwfa_liquidaciones_group_x_liqui_x_periodo_x_cliente
                              where q.IdEmpresa == IdEmpresa
                              && q.IdPeriodo == idperiodo
                              select q;

                    foreach (var item in lst)
                    {
                        fa_liquidacion_gastos_Info Info = new fa_liquidacion_gastos_Info();
                        Info.IdEmpresa = item.IdEmpresa;
                        Info.IdLiquidacion = item.IdLiquidacion;
                        Info.IdPeriodo = item.IdPeriodo;
                        Info.cod_liquidacion = item.cod_liquidacion;
                        Info.IdCliente = item.IdCliente;
                        Info.fecha_liqui = item.fecha_liqui;
                        Info.Observacion = item.Observacion;
                        Info.pe_nombre = item.pe_nombreCompleto;
                        Info.Subtotal = item.Subtotal;
                        Info.Iva = item.Iva;
                        Info.total_liquidacion = item.total_liquidacion;

                        Lista.Add(Info);
                    }
                }

                return Lista;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                throw new Exception(ex.ToString());
            }
        }
    }
}
