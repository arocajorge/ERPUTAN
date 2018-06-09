using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.ActivoFijo_FJ;
using Core.Erp.Data.General;
using Core.Erp.Info.General;
namespace Core.Erp.Data.ActivoFijo_FJ
{
   public class Af_Poliza_x_AF_Data
    {
       string mensaje = "";
        public Boolean GuardarDB(Af_Poliza_x_AF_Info Info, ref int IdPoliza)
        {
            try
            {
                using (EntitiesActivoFijo_FJ Context = new EntitiesActivoFijo_FJ())
                {
                    var Address = new Af_Poliza_x_AF();

                    Address.IdEmpresa = Info.IdEmpresa;
                    Address.IdPoliza = getId(Info.IdEmpresa);
                    Address.IdProveedor = Info.IdProveedor;
                    Address.cod_poliza = Info.cod_poliza;
                    Address.fecha = Info.fecha.Date;
                    Address.observacion = Info.observacion;
                    Address.fecha_vigencia_desde = Info.fecha_vigencia_desde.Date;
                    Address.fecha_vigencia_hasta = Info.fecha_vigencia_hasta.Date;


                    Address.num_cuotas = Info.num_cuotas;
                    Address.valor_cuota = Info.valor_cuota;
                    Address.IdCentroCosto = Info.IdCentroCosto;
                    Address.IdCentroCosto_sub_centro_costo = Info.IdCentroCosto_sub_centro_costo;
                    Address.fecha_1era_cuota = Info.fecha_1era_cuota;
                    Address.suma_asegurada = Info.suma_asegurada;
                    Address.total_meses = Info.total_meses;
                    Address.subtotal = Info.subtotal;
                    Address.porc_iva = Info.porc_iva;
                    Address.iva = Info.iva;
                    Address.Total = Info.Total;
                    Address.Estado = "A";
                    Address.pago_contado = Info.pago_contado;
                    Address.subtotal_noIva = Info.subtotal_noIva;
                    Context.Af_Poliza_x_AF.Add(Address);
                    Context.SaveChanges();
                    IdPoliza =Convert.ToInt32( Address.IdPoliza);

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
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public List<Af_Poliza_x_AF_Info> Get_List_Poliza(int IdEmpresa,DateTime fi,DateTime ff)
        {
            List<Af_Poliza_x_AF_Info> Lst = new List<Af_Poliza_x_AF_Info>();
            try
            {
                DateTime fecha_desde = Convert.ToDateTime(fi.ToShortDateString());
                DateTime fecha_hasta = Convert.ToDateTime(ff.ToShortDateString());

                using (  EntitiesActivoFijo_FJ oEnti = new EntitiesActivoFijo_FJ())
                {

                    var query = (from j in oEnti.vwaf_Af_Poliza_x_AF
                                 where j.IdEmpresa == IdEmpresa
                                 && j.fecha_vigencia_desde >= fecha_desde
                                 && j.fecha_vigencia_desde <= fecha_hasta
                                 select j);
                    foreach (var item in query)
                    {
                        Af_Poliza_x_AF_Info info = new Af_Poliza_x_AF_Info();
                        info.IdEmpresa = item.IdEmpresa;
                        info.IdPoliza = item.IdPoliza;
                        info.IdProveedor = item.IdProveedor;
                        info.cod_poliza = item.cod_poliza;
                        info.fecha = item.fecha.Date;
                        info.observacion = item.observacion;
                        info.fecha_vigencia_desde = item.fecha_vigencia_desde.Date;
                        info.fecha_vigencia_hasta = item.fecha_vigencia_hasta.Date;
                        info.num_cuotas = item.num_cuotas;
                        info.valor_cuota = item.valor_cuota;
                        info.fecha_1era_cuota = item.fecha_1era_cuota;
                        info.suma_asegurada = item.suma_asegurada;
                        info.total_meses = item.total_meses;
                        info.subtotal = item.subtotal;
                        info.porc_iva = item.porc_iva;
                        info.iva = item.iva;
                        info.total_meses = item.total_meses;
                        info.Total = item.Total;
                        info.Estado = item.Estado;
                        info.cod_poliza = item.cod_poliza;
                        info.observacion = item.observacion;
                        info.pe_cedulaRuc = item.pe_cedulaRuc;
                        info.pe_nombreCompleto = item.pe_nombreCompleto;
                        info.pago_contado = item.pago_contado;
                        info.subtotal_noIva = item.subtotal_noIva;
                        info.IdCentroCosto = item.IdCentroCosto;
                        info.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;
                        Lst.Add(info);


                    }
                }

               
                return Lst;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.InnerException.ToString());
            }
        }


        public Boolean ModificarDB(Af_Poliza_x_AF_Info Info)
        {
            try
            {
                using (EntitiesActivoFijo_FJ context = new EntitiesActivoFijo_FJ())
                {
                    var Address = context.Af_Poliza_x_AF.First(minfo => minfo.IdEmpresa == Info.IdEmpresa && minfo.IdPoliza == Info.IdPoliza);
                    if (Address != null)
                    {
                        
                        Address.cod_poliza = Info.cod_poliza;
                        Address.IdProveedor = Info.IdProveedor;
                        Address.fecha = Info.fecha.Date;
                        Address.observacion = Info.observacion;
                        Address.fecha_vigencia_desde = Info.fecha_vigencia_desde.Date;
                        Address.fecha_vigencia_hasta = Info.fecha_vigencia_hasta.Date;
                        Address.num_cuotas = Info.num_cuotas;
                        Address.valor_cuota = Info.valor_cuota;
                        Address.fecha_1era_cuota = Info.fecha_1era_cuota;
                        Address.suma_asegurada = Info.suma_asegurada;
                        Address.total_meses = Info.total_meses;
                        Address.subtotal = Info.subtotal;
                        Address.porc_iva = Info.porc_iva;
                        Address.iva = Info.iva;
                        Address.Total = Info.Total;
                        Address.cod_poliza = Info.cod_poliza;
                        Address.pago_contado = Info.pago_contado;
                        Address.subtotal_noIva = Info.subtotal_noIva;
                        Address.IdUsuarioUltMod = Info.IdUsuarioUltMod;
                        Address.Fecha_UltMod = Info.Fecha_UltMod;
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
                mensaje = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public Boolean AnularDB(Af_Poliza_x_AF_Info Info)
        {
            try
            {
                using (EntitiesActivoFijo_FJ context = new EntitiesActivoFijo_FJ())
                {
                    var Address = context.Af_Poliza_x_AF.First(minfo => minfo.IdEmpresa == Info.IdEmpresa && minfo.IdPoliza == Info.IdPoliza);
                    if (Address != null)
                    {

                        Address.Estado = "I";
                        Address.IdUsuarioUltAnu = Info.IdUsuarioUltAnu;
                        Address.Fecha_UltAnu = Info.Fecha_UltAnu;
                        Address.MotivoAnulacion = Info.MotivoAnulacion;
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
                mensaje = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.InnerException.ToString());
            }
        }


        public int getId(int IdEmpresa)
        {
            try
            {
                int Id;
                EntitiesActivoFijo_FJ contex= new EntitiesActivoFijo_FJ();
                var select = from q in contex.Af_Poliza_x_AF
                             where q.IdEmpresa == IdEmpresa 
                             select q;

                if (select.ToList().Count() == 0)
                {
                    Id = 1;
                }
                else
                {
                    var select_em = (from q in contex.Af_Poliza_x_AF
                                     where q.IdEmpresa == IdEmpresa
                                     select q.IdPoliza).Max();
                    Id = Convert.ToInt32(select_em.ToString()) + 1;
                }
                return Id;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.InnerException.ToString());
            }
        }

    }
}
