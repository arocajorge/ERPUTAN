using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Core.Erp.Info.Inventario;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.Inventario
{
    public class in_ajusteFisico_Data
    {
        public decimal _IdAjusteFisico { get; set; }
        public decimal _idEgresoMovi { get; set; }
        public decimal _idIngresoMovi { get; set; }
        in_movi_inve_Data idData = new in_movi_inve_Data();
        string mensaje = "";

        public decimal GetId(int idEmpresa) 
        {
            try
            {
                decimal IdAjusteFisico = 0;
                using (EntitiesInventario Contex = new EntitiesInventario())
                {
                    
                    EntitiesInventario oEInventario = new EntitiesInventario();

                    var Select = from q in oEInventario.in_ajusteFisico
                                 where q.IdEmpresa == idEmpresa
                                 select q;
                    if (Select.ToList().Count == 0)
                    {
                        _IdAjusteFisico = 1;
                        return 1;
                    }
                    else
                    {

                        var qmax = (from q in oEInventario.in_ajusteFisico
                                    where q.IdEmpresa == idEmpresa
                                    select q.IdAjusteFisico).Max();

                        IdAjusteFisico = Convert.ToInt32(qmax.ToString()) + 1;

                        _IdAjusteFisico = IdAjusteFisico;
                        return IdAjusteFisico;
                    }
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

        public in_ajusteFisico_Info Get_info_ajuste_fisico(int IdEmpresa, decimal IdAjusteFisico)
        {
            try
            {
                in_ajusteFisico_Info info = new in_ajusteFisico_Info();

                using (EntitiesInventario Context = new EntitiesInventario())
                {

                    var lst = from q in Context.in_ajusteFisico
                              where q.IdEmpresa == IdEmpresa
                              && q.IdAjusteFisico == IdAjusteFisico
                              select q;

                    foreach (var item in lst)
                    {
                        info.IdEmpresa = item.IdEmpresa;
                        info.IdAjusteFisico = item.IdAjusteFisico;
                        info.IdSucursal = item.IdSucursal;
                        info.IdBodega = item.IdBodega;
                        info.IdMovi_inven_tipo_Egr = Convert.ToInt32((item.IdMovi_inven_tipo_Egr == null) ? 0 : item.IdMovi_inven_tipo_Egr);
                        info.IdMovi_inven_tipo_Ing = Convert.ToInt32((item.IdMovi_inven_tipo_Ing == null) ? 0 : item.IdMovi_inven_tipo_Ing);
                        info.IdAjusteFisico = item.IdAjusteFisico;
                        info.IdNumMovi_Ing = Convert.ToDecimal((item.IdNumMovi_Ing == null) ? 0 : item.IdNumMovi_Ing);
                        info.IdNumMovi_Egr = Convert.ToDecimal((item.IdNumMovi_Egr == null) ? 0 : item.IdNumMovi_Egr); ;
                        info.Observacion = item.Observacion;
                        info.Fecha = item.Fecha;
                        info.Estado = item.Estado;
                        info.IdEstadoAprobacion = item.IdEstadoAprobacion;
                    }
                }

                return info;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(mensaje);
            }
        }

        public Boolean GuardarDB(in_ajusteFisico_Info Info,ref decimal  idAjuste,ref decimal  idEgressoMovi,ref decimal  idIngresoMovi ) 
        {
            try
            {
                idAjuste = GetId(Info.IdEmpresa);



                using (EntitiesInventario Contex = new EntitiesInventario())
                {
                    var lst = from q in Contex.in_ajusteFisico
                              where q.IdAjusteFisico == Info.IdAjusteFisico
                              && q.IdEmpresa == Info.IdEmpresa
                              select q;

                    if (lst.Count() == 0)
                    {
                        var Address = new in_ajusteFisico();

                        Address.IdAjusteFisico = _IdAjusteFisico;
                        Address.IdEmpresa = Info.IdEmpresa;
                        Address.IdBodega = Info.IdBodega;
                        Address.IdSucursal = Info.IdSucursal;
                        Address.Observacion = Info.Observacion;
                        Address.IdMovi_inven_tipo_Egr = Info.IdMovi_inven_tipo_Egr;
                        Address.IdMovi_inven_tipo_Ing = Info.IdMovi_inven_tipo_Ing;

                        if (idEgressoMovi == 0)
                        {
                            Address.IdNumMovi_Egr = null;
                        }
                        else
                        {
                            Address.IdNumMovi_Egr = idEgressoMovi;
                        }
                        if (idIngresoMovi == 0)
                        {
                            Address.IdNumMovi_Ing = null;
                        }
                        else
                        {
                            Address.IdNumMovi_Ing = idIngresoMovi;
                        }
                        Address.Fecha = Convert.ToDateTime(Info.Fecha.ToShortDateString());
                        Address.Estado = Info.Estado;
                        Address.CodAjusteFisico = "AJUFI" + _IdAjusteFisico;
                        Address.IdEstadoAprobacion = Info.IdEstadoAprobacion;
                        Contex.in_ajusteFisico.Add(Address);
                        Contex.SaveChanges();
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
                throw new Exception(mensaje);
            }


        }

        public Boolean ModificarDB(in_ajusteFisico_Info Info)
        {
            try
            {
                using (EntitiesInventario Contex = new EntitiesInventario())
                {
                    var Address = Contex.in_ajusteFisico.FirstOrDefault(q => q.IdEmpresa == Info.IdEmpresa && q.IdAjusteFisico == Info.IdAjusteFisico);
                    if (Address != null)
                    {
                        Address.Observacion = Info.Observacion;
                        Address.Fecha = Convert.ToDateTime(Info.Fecha.ToShortDateString());
                        Address.IdEstadoAprobacion = Info.IdEstadoAprobacion;
                        Contex.SaveChanges();   
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
                throw new Exception(mensaje);
            }
        }

        public List<in_ajusteFisico_Info> Get_List_ajusteFisico(int idEmpresa, int IdSucursal, int idBodga, DateTime FechaIni, DateTime FechaFin) 
        {
            List<in_ajusteFisico_Info> lista = new List<in_ajusteFisico_Info>();


            EntitiesInventario oEnti = new EntitiesInventario();

            try
            {
                 var select = from q in oEnti.vwin_ajusteFisico
                                 where q.IdEmpresa == idEmpresa 
                                 && q.IdBodega == idBodga 
                                 && q.IdSucursal == IdSucursal
                                 && q.Fecha > FechaIni && q.Fecha< FechaFin
                                 select q;
                    foreach (var item in select)
                    {
                        in_ajusteFisico_Info info = new in_ajusteFisico_Info();

                        info.bo_descripcion = item.bo_Descripcion;
                        info.su_Descripcion = item.Su_Descripcion;
                        info.IdBodega = item.IdBodega;
                        info.IdEmpresa = item.IdEmpresa;
                        info.IdSucursal = item.IdSucursal;
                        info.IdMovi_inven_tipo_Egr = Convert.ToInt32((item.IdMovi_inven_tipo_Egr == null) ? 0 : item.IdMovi_inven_tipo_Egr);
                        info.IdMovi_inven_tipo_Ing = Convert.ToInt32((item.IdMovi_inven_tipo_Ing == null) ? 0 : item.IdMovi_inven_tipo_Ing);
                        info.IdAjusteFisico = item.IdAjusteFisico;
                        info.IdNumMovi_Ing = Convert.ToDecimal((item.IdNumMovi_Ing == null) ? 0 : item.IdNumMovi_Ing);
                        info.IdNumMovi_Egr = Convert.ToDecimal((item.IdNumMovi_Egr == null) ? 0 : item.IdNumMovi_Egr);;
                        info.DescripcionIngreso = item.tm_descripcion_ing;
                        info.DescripcionEngreso = item.tm_descripcion_Egr;
                        info.Fecha = item.Fecha;
                        info.Observacion = item.Observacion;
                        info.Estado = item.Estado;
                        info.IdEstadoAprobacion = item.IdEstadoAprobacion;
                        info.Nombre_Estado = item.Nombre_Estado;

                        lista.Add(info);

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
                throw new Exception(mensaje);
            }
           
        }

        public List<in_ajusteFisico_Info> Get_List_ajusteFisico(int idEmpresa, int IdSucursalIni, int IdSucursalFin, int idBodgaIni,int idBodegaFin, DateTime FechaIni, DateTime FechaFin)
        {
            List<in_ajusteFisico_Info> lista = new List<in_ajusteFisico_Info>();


            EntitiesInventario oEnti = new EntitiesInventario();

            try
            {
                var select = from q in oEnti.vwin_ajusteFisico
                             where q.IdEmpresa == idEmpresa
                             && IdSucursalIni<= q.IdSucursal && q.IdSucursal <= IdSucursalFin
                             && idBodgaIni<= q.IdBodega && q.IdBodega <=idBodegaFin
                             && q.Fecha > FechaIni && q.Fecha < FechaFin
                             select q;
                foreach (var item in select)
                {
                    in_ajusteFisico_Info info = new in_ajusteFisico_Info();

                    info.bo_descripcion = item.bo_Descripcion;
                    info.su_Descripcion = item.Su_Descripcion;
                    info.IdBodega = item.IdBodega;
                    info.IdEmpresa = item.IdEmpresa;
                    info.IdSucursal = item.IdSucursal;
                    info.IdMovi_inven_tipo_Egr = Convert.ToInt32((item.IdMovi_inven_tipo_Egr == null) ? 0 : item.IdMovi_inven_tipo_Egr);
                    info.IdMovi_inven_tipo_Ing = Convert.ToInt32((item.IdMovi_inven_tipo_Ing == null) ? 0 : item.IdMovi_inven_tipo_Ing);
                    info.IdAjusteFisico = item.IdAjusteFisico;
                    info.IdNumMovi_Ing = Convert.ToDecimal((item.IdNumMovi_Ing == null) ? 0 : item.IdNumMovi_Ing);
                    info.IdNumMovi_Egr = Convert.ToDecimal((item.IdNumMovi_Egr == null) ? 0 : item.IdNumMovi_Egr); ;
                    info.DescripcionIngreso = item.tm_descripcion_ing;
                    info.DescripcionEngreso = item.tm_descripcion_Egr;
                    info.Fecha = item.Fecha;
                    info.Observacion = item.Observacion;
                    info.Estado = item.Estado;
                    info.IdEstadoAprobacion = item.IdEstadoAprobacion;
                    info.Nombre_Estado = item.Nombre_Estado;

                    lista.Add(info);

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
                throw new Exception(mensaje);
            }

        }

        public Boolean AnularDB(in_ajusteFisico_Info info) 
        {
            try
            {
                using (EntitiesInventario Contex = new EntitiesInventario())
                {
                    var contac = Contex.in_ajusteFisico.FirstOrDefault(Obj => Obj.IdAjusteFisico == info.IdAjusteFisico && Obj.IdEmpresa == info.IdEmpresa);
                    if (contac != null)
                    {
                        contac.Estado = "I";
                        contac.FechaAnulacion = DateTime.Now;
                        contac.IdUsuarioAnulacion = info.IdUsuarioAnulacion;
                        contac.motivo_anula = info.motivo_anula;
                        contac.nom_pc = info.nom_pc;
                        contac.ip = info.ip;
                        Contex.SaveChanges();
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
                throw new Exception(mensaje);
            }
        
        }

        public Boolean ModificarDB(int IdEmpresa, decimal IdAjusteFisico, string IdEstadoAproba, decimal IdNumMovi_Egr, decimal IdNumMovi_Ing) 
        {
            try
            {
                using (EntitiesInventario oen = new EntitiesInventario())
                {
                    var Contacct = oen.in_ajusteFisico.FirstOrDefault(v => v.IdAjusteFisico == IdAjusteFisico && v.IdEmpresa == IdEmpresa);
                    if (Contacct != null)
                    {
                        if (IdNumMovi_Egr == 0)
                        {
                            Contacct.IdNumMovi_Egr = null;
                        }
                        else
                        {
                            Contacct.IdNumMovi_Egr = IdNumMovi_Egr;
                        }


                        if (IdNumMovi_Ing == 0)
                        {
                            Contacct.IdNumMovi_Ing = null;
                        }
                        else
                        {
                            Contacct.IdNumMovi_Ing = IdNumMovi_Ing;
                        }


                        Contacct.IdEstadoAprobacion = IdEstadoAproba;
                        oen.SaveChanges();
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
                throw new Exception(mensaje);
            }

        }

        public List<in_Producto_Info>  Get_List_Productos_en_ajuste_fisico_a_fecha(int idEmpresa, List<in_Producto_Info> listadoProducto_a_buscar, DateTime FechaAjuste, ref string mensaje)
        {
            try
            {
                FechaAjuste = Convert.ToDateTime(FechaAjuste.ToShortDateString());
                List<in_Producto_Info> list_producto_existentes = new List<in_Producto_Info>();

                EntitiesInventario oEnti = new EntitiesInventario();

                List<string> listIdProducto = new List<string>();

                foreach (var item in listadoProducto_a_buscar)
                {
                    listIdProducto.Add(item.IdProducto.ToString().Trim());
                }

                var select = from Ajus in oEnti.in_ajusteFisico
                             join Ajus_det in oEnti.in_AjusteFisico_Detalle
                             on new { Ajus.IdEmpresa, Ajus.IdAjusteFisico } equals new { Ajus_det.IdEmpresa, Ajus_det.IdAjusteFisico }
                             where Ajus.IdEmpresa == idEmpresa
                             && Ajus.Fecha == FechaAjuste
                             && listIdProducto.Contains(Ajus_det.IdProducto.ToString())
                             select Ajus;

                foreach (var item in select)
                {
                    in_Producto_Info info = new in_Producto_Info();
                    list_producto_existentes.Add(info);
                }



               return list_producto_existentes;

            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(mensaje);
            }
        }
    }
}
