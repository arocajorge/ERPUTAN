using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Core.Erp.Info.Inventario;
using Core.Erp.Info.General;
using Core.Erp.Data.General;



namespace Core.Erp.Data.Inventario
{
   public class in_devolucion_inven_Data
    {
        string mensaje = "";

        public decimal GetId(int IdEmpresa)
        {
            decimal Id = 0;
            try
            {

                EntitiesInventario contex = new EntitiesInventario();
                var selecte = contex.in_devolucion_inven.Count(q => q.IdEmpresa == IdEmpresa);

                if (selecte == 0)
                {
                    Id = 1;
                }
                else
                {
                    var select_em = (from q in contex.in_devolucion_inven
                                     where q.IdEmpresa == IdEmpresa
                                     select q.IdDev_Inven).Max();
                    Id = Convert.ToDecimal(select_em.ToString()) + 1;
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

        public Boolean GuardarDB(in_devolucion_inven_Info info, ref decimal IdDev_Inven, ref string mensaje)
        {
            try
            {
                using (EntitiesInventario Context = new EntitiesInventario())
                {
                    var Address = new in_devolucion_inven();

                    Address.IdEmpresa = info.IdEmpresa;
                    Address.IdDev_Inven = info.IdDev_Inven = IdDev_Inven =GetId(info.IdEmpresa);
                    Address.cod_Dev_Inven = (info.cod_Dev_Inven == "") ? IdDev_Inven.ToString() : info.cod_Dev_Inven;
                    Address.Fecha = Convert.ToDateTime(info.Fecha.ToShortDateString());

                    Address.Devuelve_toda_tran= info.Devuelve_toda_tran;
                    Address.estado = "A";


                    Address.IdSucursal_movi_inven = info.IdSucursal_movi_inven;
                    Address.IdMovi_inven_tipo = info.IdMovi_inven_tipo;
                    Address.IdNumMovi = info.IdNumMovi;
                    Address.observacion = (info.observacion == "") ? "" : info.observacion;
                    Address.IdUsuario = info.IdUsuario;
                    Address.Fecha_Transac = info.Fecha_Transac;
                    Address.IdUsuarioUltModi= info.IdUsuarioUltModi;
                    Address.Fecha_UltMod= info.Fecha_UltMod;
                    Address.IdusuarioUltAnu= info.IdusuarioUltAnu;
                    Address.Fecha_UltAnu= info.Fecha_UltAnu;
                    Address.nom_pc = info.nom_pc;
                    Address.ip = info.ip;
                    
                    Context.in_devolucion_inven.Add(Address);
                    Context.SaveChanges();
                  
                    mensaje = "Grabación ok..";
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

        public Boolean ModificarDB(in_devolucion_inven_Info info, ref string msgs)
        {
            try
            {
                using (EntitiesInventario context = new EntitiesInventario())
                {
                    var contact = context.in_devolucion_inven.FirstOrDefault(q => q.IdEmpresa == info.IdEmpresa
                        && q.IdDev_Inven == info.IdDev_Inven);

                    if (contact != null)
                    {
                        contact.cod_Dev_Inven = info.cod_Dev_Inven;
                        contact.Fecha = info.Fecha;
                        contact.Devuelve_toda_tran = info.Devuelve_toda_tran;
                        contact.estado = info.estado;
                        contact.observacion = info.observacion;
                        contact.IdUsuarioUltModi = info.IdUsuarioUltModi;
                        contact.Fecha_UltMod = info.Fecha_UltMod;
                        context.SaveChanges();
                        msgs = "Se ha procedido a modificar el registro de Egreso Varios  #: " + info.IdNumMovi.ToString() + " exitosamente";
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString() + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref msgs);

                msgs = "Se ha producido el siguiente error: " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public Boolean AnularDB(in_devolucion_inven_Info info, ref string msgs)
        {
            try
            {
                using (EntitiesInventario context = new EntitiesInventario())
                {
                    var contact = context.in_devolucion_inven.FirstOrDefault(q => q.IdEmpresa == info.IdEmpresa
                        && q.IdDev_Inven == info.IdDev_Inven);


                    if (contact != null)
                    {
                        contact.estado = "I";
                        contact.IdusuarioUltAnu = info.IdusuarioUltAnu;
                        contact.Fecha_UltAnu = info.Fecha_UltAnu;
                        contact.MotivoAnulacion = info.MotivoAnulacion;
                        contact.observacion = "**Anulado**" + info.observacion;
                        context.SaveChanges();
                        msgs = "Se ha procedido a anular el registro Egreso varios  #: " + info.IdDev_Inven.ToString() + " exitosamente";
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString() + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref msgs);

                msgs = "Se ha producido el siguiente error: " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

       public List<in_devolucion_inven_Info> Get_List_in_devolucion_inven(int IdEmpresa, int IdSucursalIni, int IdSucursalFin,
          DateTime FechaIni, DateTime FechaFin)
        {
            List<in_devolucion_inven_Info> Lst = new List<in_devolucion_inven_Info>();
            try
            {
                FechaIni = Convert.ToDateTime(FechaIni.ToShortDateString());
                FechaFin = Convert.ToDateTime(FechaFin.ToShortDateString());
                EntitiesInventario oEnti = new EntitiesInventario();


                                var Query = from q in oEnti.vwin_devolucion_inven
                                where q.IdEmpresa == IdEmpresa
                                && q.IdSucursal_movi_inven >= IdSucursalIni && q.IdSucursal_movi_inven <= IdSucursalFin
                                && FechaIni<=q.Fecha && q.Fecha <= FechaFin
                                select q;

                    foreach (var item in Query)
                    {
                        in_devolucion_inven_Info Obj = new in_devolucion_inven_Info();

                        Obj.IdEmpresa = item.IdEmpresa;
                        Obj.IdSucursal_movi_inven = item.IdSucursal_movi_inven;
                        Obj.IdMovi_inven_tipo = item.IdMovi_inven_tipo;
                        Obj.IdNumMovi = item.IdNumMovi;
                        Obj.cod_Dev_Inven = item.cod_Dev_Inven;
                        Obj.Fecha = item.Fecha;
                        Obj.estado = item.estado;
                        Obj.observacion = item.observacion;
                         Obj.nom_sucursal = item.nom_sucursal;

                        Obj.Devuelve_toda_tran = item.Devuelve_toda_tran;
                        Obj.IdDev_Inven = item.IdDev_Inven;
                        Obj.IdUsuario = item.IdUsuario;
                       

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

       public in_devolucion_inven_Info Get_Info_in_devolucion_inven(int IdEmpresa,  decimal IdDev_Inven)
        {
            try
            {
                in_devolucion_inven_Info Obj = new in_devolucion_inven_Info();
                EntitiesInventario oEnti = new EntitiesInventario();

                var Query = from q in oEnti.vwin_devolucion_inven
                            where q.IdEmpresa == IdEmpresa
                            && q.IdDev_Inven == IdDev_Inven
                            select q;
                foreach (var item in Query)
                {


                    Obj.IdEmpresa = item.IdEmpresa;
                    Obj.IdSucursal_movi_inven = item.IdSucursal_movi_inven;
                    Obj.IdMovi_inven_tipo = item.IdMovi_inven_tipo;
                    Obj.IdNumMovi = item.IdNumMovi;
                    Obj.cod_Dev_Inven = item.cod_Dev_Inven;
                    Obj.Fecha = item.Fecha;
                    Obj.estado = item.estado;
                    Obj.observacion = item.observacion;
                   Obj.nom_sucursal = item.nom_sucursal;

                    Obj.Devuelve_toda_tran = item.Devuelve_toda_tran;
                    Obj.IdDev_Inven = item.IdDev_Inven;
                    Obj.IdUsuario = item.IdUsuario;
                       
                }

                return Obj;
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
