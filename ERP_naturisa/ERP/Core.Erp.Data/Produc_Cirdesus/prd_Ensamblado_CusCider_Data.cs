using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Produc_Cirdesus;
using Core.Erp.Data.Inventario;
using Core.Erp.Info.Inventario;
using Core.Erp.Data.Inventario_Cidersus;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.Produc_Cirdesus
{
    public class prd_Ensamblado_CusCider_Data
    {
        string mensaje = "";
        public decimal getId(int idempresa, int idsucursal)
        {
            try
            {
                decimal Id;
                EntitiesProduccion_Cidersus OEProduccion = new EntitiesProduccion_Cidersus();
                var select = from q in OEProduccion.prd_Ensamblado_CusCider
                             where q.IdEmpresa == idempresa && q.IdSucursal == idsucursal
                             select q;

                if (select.ToList().Count < 1)
                {
                    Id = 1;
                }
                else
                {
                    var select_pv = (from q in OEProduccion.prd_Ensamblado_CusCider
                                     where q.IdEmpresa == idempresa && q.IdSucursal == idsucursal
                                     select q.IdEnsamblado).Max();
                    Id = Convert.ToDecimal(select_pv.ToString()) + 1;
                }
                return Id;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString() + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }

        }
        public Boolean GuardarDB(prd_Ensamblado_CusCider_Info Info, List<prd_Ensamblado_Det_CusCider_Info> Det, ref decimal idEnsamblado, ref string msg)
        {
            try
            {

                List<prd_Ensamblado_CusCider_Info> Lst = new List<prd_Ensamblado_CusCider_Info>();
                prd_Ensamblado_Det_CusCider_Data DetData = new prd_Ensamblado_Det_CusCider_Data();
                using (EntitiesProduccion_Cidersus Context = new EntitiesProduccion_Cidersus())
                {
                    var Address = new prd_Ensamblado_CusCider();
                    idEnsamblado = getId(Info.IdEmpresa, Info.IdSucursal);
                    Address.IdEmpresa = Info.IdEmpresa;
                    Address.IdSucursal = Info.IdSucursal;
                    Address.IdEnsamblado = idEnsamblado;
                    Address.IdBodega = Info.IdBodega;
                    Address.IdGrupoTrabajo = Info.IdGrupoTrabajo;
                    Address.IdProducto = Info.IdProducto;

                    Address.CodigoBarra = "A" + DateTime.Now.Year + "M" + DateTime.Now.Month + "D" + DateTime.Now.Day + "E" + Info.IdEmpresa + "N" + idEnsamblado + "O" + Info.CodObra + "T" + Info.IdOrdenTaller + "P" + Info.IdProducto + "G" + Info.IdGrupoTrabajo;
                    Address.CodObra = Info.CodObra;
                    Address.IdOrdenTaller = Info.IdOrdenTaller;
                    Address.IdUsuario = Info.IdUsuario;
                    Address.FechaTransac = Info.FechaTransac;

                    Address.IdDespacho = Info.IdDespacho;

                    Address.Estado = "A";
                    if (Info.Observacion.Length > 1000)
                        Address.Observacion = Info.Observacion.Substring(0, 1000);
                    else Address.Observacion = Info.Observacion;
                    Context.prd_Ensamblado_CusCider.Add(Address);
                    Context.SaveChanges();

                    Det.ForEach(var =>
                    {
                        var.IdEnsamblado = Address.IdEnsamblado;
                        var.IdEmpresa = Info.IdEmpresa;
                        var.IdSucursal = Info.IdSucursal;
                    });
                    return DetData.GuardarDB(Det, ref msg);


                }

            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                msg = ex.ToString() + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref msg);
                throw new Exception(ex.ToString());
            }
        }

        public List<prd_Ensamblado_CusCider_Info> ConsultaGeneral(int idempresa, ref string msg)
        {
            try
            {
                List<prd_Ensamblado_CusCider_Info> Lst = new List<prd_Ensamblado_CusCider_Info>();
                EntitiesProduccion_Cidersus oEnti = new EntitiesProduccion_Cidersus();
                var Query = from q in oEnti.vwprd_Ensamblado_CusCidersus
                            where q.IdEmpresa == idempresa
                            select q;
                foreach (var item in Query)
                {
                    prd_Ensamblado_CusCider_Info Obj = new prd_Ensamblado_CusCider_Info();
                    Obj.CodOT = item.Codigo;
                    Obj.ob_descripcion = item.ob_descripcion;
                    Obj.bo_descripcion = item.bo_Descripcion;
                    Obj.gt_descripcion = item.gt_descripcion;
                    Obj.Producto = item.pr_descripcion;
                    Obj.su_descripcion = item.Su_Descripcion;
                    Obj.IdEmpresa = item.IdEmpresa;
                    Obj.IdSucursal = item.IdSucursal;
                    Obj.IdEnsamblado = item.IdEnsamblado;
                    Obj.IdBodega = item.IdBodega;
                    Obj.IdGrupoTrabajo = item.IdGrupoTrabajo;
                    Obj.IdProducto = item.IdProducto;
                    Obj.CodigoBarra = item.CodigoBarra;
                    Obj.CodObra = item.CodObra;
                    Obj.IdOrdenTaller = item.IdOrdenTaller;
                    Obj.IdUsuario = item.IdUsuario;
                    Obj.IdUsuarioAnu = item.IdUsuarioAnu;
                    Obj.MotivoAnu = item.MotivoAnu;
                    Obj.IdUsuarioUltModi = item.IdUsuarioUltModi;
                    //Obj.FechaAnu = item.FechaAnu;
                    Obj.FechaTransac = item.FechaTransac;
                    //Obj.FechaUltModi = item.FechaUltModi;
                    Obj.Estado = item.Estado;
                    Obj.Observacion = item.Observacion;
                    Obj.IdProcesoProductivo = item.IdProcesoProductivo;
                    Obj.IdEtapa = item.IdEtapa;
                    Lst.Add(Obj);

                }
                return Lst;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                msg = ex.ToString() + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref msg);
                throw new Exception(ex.ToString());
            }
        }

        public prd_Ensamblado_CusCider_Info ObtenerObjeto(int IdEmpresa, int IdSucursal, decimal IdEnsamblado, ref string msg)
        {
            EntitiesProduccion_Cidersus oEnti = new EntitiesProduccion_Cidersus();
            try
            {
                prd_Ensamblado_CusCider_Info Info = new prd_Ensamblado_CusCider_Info();
                var Objeto = oEnti.prd_Ensamblado_CusCider.FirstOrDefault(var =>var.IdEmpresa == IdEmpresa && var.IdSucursal == IdSucursal && var.IdEnsamblado == IdEnsamblado);
                if (Objeto != null)
                {
                    Info.IdEmpresa = Objeto.IdEmpresa;
                    Info.IdSucursal = Objeto.IdSucursal;
                    Info.IdEnsamblado = Objeto.IdEnsamblado;
                    Info.IdBodega = Objeto.IdBodega;
                    Info.IdGrupoTrabajo = Objeto.IdGrupoTrabajo;
                    Info.IdProducto = Objeto.IdProducto;
                    Info.CodigoBarra = Objeto.CodigoBarra;
                    Info.CodObra = Objeto.CodObra;
                    Info.IdOrdenTaller = Objeto.IdOrdenTaller;
                    Info.IdUsuario = Objeto.IdUsuario;
                    Info.IdUsuarioAnu = Objeto.IdUsuarioAnu;
                    Info.MotivoAnu = Objeto.MotivoAnu;
                    Info.IdUsuarioUltModi = Objeto.IdUsuarioUltModi;
                    Info.FechaAnu = Convert.ToDateTime(Objeto.FechaAnu);
                    Info.FechaTransac = Objeto.FechaTransac;
                    Info.FechaUltModi = Convert.ToDateTime(Objeto.FechaUltModi);
                    Info.Estado = Objeto.Estado;
                    Info.Observacion = Objeto.Observacion;
                }
                return Info;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                msg = ex.ToString() + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref msg);
                throw new Exception(ex.ToString());
            }
        }

        public vwprd_CantidadEnsamblada_x_OT_CusCider_Info TraerCantEnsamb(prd_OrdenTaller_Info OT, ref string msg)
        {
            try
            {
                vwprd_CantidadEnsamblada_x_OT_CusCider_Info info = new vwprd_CantidadEnsamblada_x_OT_CusCider_Info();

                EntitiesProduccion_Cidersus OEnti = new EntitiesProduccion_Cidersus();

                var objeto = OEnti.vwprd_CantidadEnsamblada_x_OT_CusCider.FirstOrDefault(var =>var.IdEmpresa == OT.IdEmpresa && var.IdSucursal == OT.IdSucursal && var.IdOrdenTaller == OT.IdOrdenTaller && var.CodObra == OT.CodObra);
                if (objeto != null)
                {
                    info.IdEmpresa = objeto.IdEmpresa;
                    info.IdSucursal = objeto.IdSucursal;
                    info.CodObra = objeto.CodObra;
                    info.IdOrdenTaller = objeto.IdOrdenTaller;
                    info.CantidadPieza = objeto.CantidadPieza;
                    info.CantEnsamblada = Convert.ToInt32(objeto.CantEnsamblada);
                }
                return info;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                msg = ex.ToString() + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref msg);
                throw new Exception(ex.ToString());
            }
        }

        in_movi_inve_Data datamovi = new in_movi_inve_Data();
        in_movi_inve_detalle_x_Producto_CusCider_Data dataxprodxcidersus = new in_movi_inve_detalle_x_Producto_CusCider_Data();
        List<prd_ensamblado_cusCider_x_in_movi_inven_Info> LstTI = new List<prd_ensamblado_cusCider_x_in_movi_inven_Info>();
        prd_ensamblado_cusCider_x_in_movi_inven_Data dataTI = new prd_ensamblado_cusCider_x_in_movi_inven_Data();

        public Boolean AnularEnsamb_Mov(prd_Ensamblado_CusCider_Info ensamblado, ref string msg)
        {
            try
            {
                LstTI = dataTI.LstTI_x_Ensamblado(ensamblado, ref msg);
                foreach (var item in LstTI)
                {
                    in_movi_inve_Info mov = new in_movi_inve_Info();
                    mov.IdEmpresa = item.IdEmpresa;
                    mov.IdSucursal = item.IdSucursal;
                    mov.IdBodega = item.IdBodega;
                    mov.IdMovi_inven_tipo = item.IdMovi_inven_tipo;
                    mov.IdNumMovi = item.IdNumMovi;
                    //if (datamovi.AnularCabeceraYDetalleyActualizaStock(mov, ref msg) == false)
                    if (datamovi.AnularDB(mov, ref msg) == false)
                        return false;
                    //if (dataxprodxcidersus.AnularDB(item.IdEmpresa, item.IdSucursal, item.IdBodega,
                    //    item.IdNumMovi, item.IdMovi_inven_tipo, ref msg) == false)
                    //    return false;

                }
                if (AnularDB(ensamblado, ref msg) == false)
                    return false;
                return true;

            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                msg = ex.ToString() + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref msg);
                return false;
            }

        }

        //modificado por pedro salinas, se le cambio el First por el FirstOrDefault y se agrego una pregunta para identificar si el query esta en null
        public Boolean AnularDB(prd_Ensamblado_CusCider_Info ensamblado, ref string msg)
        {
            try
            {
                using (EntitiesProduccion_Cidersus context = new EntitiesProduccion_Cidersus())
                {
                    var contact = context.prd_Ensamblado_CusCider.FirstOrDefault(obj => obj.IdEnsamblado == ensamblado.IdEnsamblado && obj.IdSucursal == ensamblado.IdSucursal && obj.IdEmpresa == ensamblado.IdEmpresa);
                    if (contact != null)
                    {
                        contact.Estado = "I";
                        contact.FechaAnu = ensamblado.FechaAnu;
                        contact.IdUsuarioAnu = ensamblado.IdUsuarioAnu;
                        contact.MotivoAnu = ensamblado.MotivoAnu;

                        context.SaveChanges();

                        prd_Ensamblado_Det_CusCider_Data datadet = new prd_Ensamblado_Det_CusCider_Data();
                        List<prd_Ensamblado_Det_CusCider_Info> det = new List<prd_Ensamblado_Det_CusCider_Info>();
                        det = datadet.ConsultaEnsamblado(ensamblado.IdEmpresa, ensamblado.IdSucursal, ensamblado.IdEnsamblado, ref msg);
                        if (datadet.eliminaregistrotabla(det, ref msg))
                        {
                            det.ForEach(var => { var.en_cantidad = 0; var.Observacion = "**ANULADO***" + var.Observacion; });
                            if (datadet.GuardarDB(det, ref msg))
                            {
                                msg = "Se ha procedido a anular el Ensamblado No: " + ensamblado.IdEnsamblado.ToString() + " exitosamente";

                            }
                            else return false;
                        }
                        else return false;
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                msg = ex.ToString() + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref msg);
                throw new Exception(ex.ToString());
            }
        }

        public vwprd_Ensamblado_CabDet_CusCider_Info buscacodbarramaestro(int idempresa, string codbar, ref string msg)
        {
            try
            {

                List<vwprd_Ensamblado_CabDet_CusCider_Info> LstEnsab = new List<vwprd_Ensamblado_CabDet_CusCider_Info>();
                LstEnsab = BuscarCodBarraMaestro(idempresa, codbar, ref msg);
                foreach (var item in LstEnsab)
                {

                    if (item.CBMaestro == codbar || item.CodigoBarra == codbar)
                        return item;


                }
                return new vwprd_Ensamblado_CabDet_CusCider_Info();

            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString() + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }

        }
        public List<vwprd_Ensamblado_CabDet_CusCider_Info>BuscarCodBarraMaestro(int Idempresa, string codbar, ref string msg)
        {
            try
            {
                List<vwprd_Ensamblado_CabDet_CusCider_Info> Lst = new List<vwprd_Ensamblado_CabDet_CusCider_Info>();
                EntitiesProduccion_Cidersus oEnti = new EntitiesProduccion_Cidersus();
                var Query = from q in oEnti.vwprd_Ensamblado_CabDet_CusCider
                            where (q.IdEmpresa == Idempresa)
                            && (q.CodigoBarra == codbar
                            || q.CBMaestro == codbar)

                            select q;
                foreach (var item in Query)
                {
                    vwprd_Ensamblado_CabDet_CusCider_Info Obj = new vwprd_Ensamblado_CabDet_CusCider_Info();
                    Obj.IdEmpresa = item.IdEmpresa;
                    Obj.IdSucursal = item.IdSucursal;
                    Obj.IdEnsamblado = item.IdEnsamblado;
                    Obj.Secuencia = item.Secuencia;
                    Obj.det_IdProducto = item.det_IdProducto;
                    Obj.CodigoBarra = item.CodigoBarra;
                    Obj.det_observacion = item.det_observacion;
                    Obj.IdBodega = item.IdBodega;
                    Obj.IdGrupoTrabajo = item.IdGrupoTrabajo;
                    Obj.cab_IdProducto = item.cab_IdProducto;
                    Obj.CBMaestro = item.CBMaestro;
                    Obj.CodObra = item.CodObra;
                    Obj.IdOrdenTaller = item.IdOrdenTaller;
                    Obj.IdUsuario = item.IdUsuario;
                    Obj.IdUsuarioAnu = item.IdUsuarioAnu;
                    Obj.MotivoAnu = item.MotivoAnu;
                    Obj.IdUsuarioUltModi = item.IdUsuarioUltModi;
                    Obj.FechaTransac = item.FechaTransac;
                    Obj.cab_Estado = item.cab_Estado;
                    Obj.det_observacion = item.det_observacion;
                    Obj.en_cantidad = item.en_cantidad;
                    Lst.Add(Obj);
                }
                return Lst;
            }
            catch (Exception ex) 
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                msg = ex.ToString() + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref msg);
                throw new Exception(ex.ToString());
            }
        }
    }
}




