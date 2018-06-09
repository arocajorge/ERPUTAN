using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Produc_Cirdesus;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

//1607 v1/10/2013
namespace Core.Erp.Data.Produc_Cirdesus
{
    public class prd_Despacho_Data
    {
        string mensaje = "";

       
        public List<prd_Despacho_Info> ObtenerDespachoCab(int idempresa)
        {
            try
            { 

                EntitiesProduccion_Cidersus OEProduccion = new EntitiesProduccion_Cidersus();
                List<prd_Despacho_Info> lM = new List<prd_Despacho_Info>();
                var select = from C in OEProduccion.vwprd_Despacho
                             where C.IdEmpresa == idempresa
                             orderby C.IdDespacho ascending
                             select C;

                foreach (var item in select)
                {
                    prd_Despacho_Info info = new prd_Despacho_Info();
                    info.IdEmpresa = item.IdEmpresa;
                    info.IdSucursal = item.IdSucursal;
                    info.IdBodega = item.IdBodega;
                    info.CodObra = item.CodObra;
                    info.IdDespacho = item.IdDespacho;
                    info.IdCliente = item.IdCliente;
                    info.NumDespacho = item.NumDespacho;
                    info.NumGuiaRemision = item.NumGuiaRemision;
                    info.NumFactura = item.NumFactura;
                    info.FechaReg = item.FechaReg;
                    info.FechaFinTras = item.FechaFinTras;
                    info.FechaIniTras = item.FechaIniTras;
                    info.PuntoPartida = item.PuntoPartida;
                    info.PuntoLLegada = item.PuntoLLegada;

                    //info.ruta = item.ruta;

                    info.TipoTransporte = item.TipoTransporte;
                    info.Chofer = item.Chofer;
                    info.Placa = item.Placa;
                    info.Observacion = item.Observacion;
                    info.Estado = item.Estado;

                    info.Su_Descripcion = item.Su_Descripcion;


                    info.Referencia = "[" + item.ob_descripcion.Trim() + "]- " + item.CodObra.Trim();
                    info.NomCliente = item.pe_nombreCompleto;

                    lM.Add(info);
                }
                return lM;
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

        public Boolean GrabarCabeceraDB(prd_Despacho_Info Info, List<prd_DespachoDetalle_Info> lmDetalleInfo, ref string msg, ref decimal idgenerada)
        {
            try
            {
                List<prd_Despacho_Info> Lst = new List<prd_Despacho_Info>();
                using (EntitiesProduccion_Cidersus Context = new EntitiesProduccion_Cidersus())
                {
                    //var contact = prd_Despacho.Createprd_Despacho( Createprd_Despacho(0, 0, 0,0, "", 0, "","", DateTime.Now, DateTime.Now, DateTime.Now, "","", "", "", "", "", "", "", DateTime.Now);
                    prd_Despacho contact = new prd_Despacho();
                    var Address = new prd_Despacho();
                    idgenerada = Info.IdDespacho = getId(Info.IdEmpresa, Info.IdSucursal);

                    Address.IdEmpresa = Info.IdEmpresa;
                    Address.IdSucursal = Info.IdSucursal;
                    Address.IdDespacho = idgenerada;
                    Address.CodObra = Info.CodObra;
                    Address.IdBodega = Info.IdBodega;
                    Address.IdCliente = Info.IdCliente;
                    Address.NumDespacho = Info.NumDespacho = ((Info.NumDespacho == null || Info.NumDespacho == "") ? Info.IdDespacho.ToString("0000") : Info.NumDespacho);
                    Address.NumGuiaRemision = Info.NumGuiaRemision;
                    Address.TipoTransporte = Info.TipoTransporte;
                    Address.FechaIniTras = Info.FechaIniTras;
                    Address.FechaFinTras = Info.FechaFinTras;
                    Address.FechaReg = Info.FechaReg;
                    Address.PuntoPartida = Info.PuntoPartida;
                    Address.PuntoLLegada = Info.PuntoLLegada;
                    Address.Chofer = Info.Chofer;
                    Address.Placa = Info.Placa;
                    Address.Observacion = Info.Observacion;
                    if (Info.Observacion.Length > 1000)
                    {
                        Address.Observacion = Info.Observacion.Substring(0, 1000);
                    }
                    Address.Estado = "A";
                    Address.IdUsuario = Info.IdUsuario;
                    Address.IdUsuarioAnu = Info.IdUsuario;
                    Address.FechaTransac = Info.FechaTransac;
                    Address.NumFactura = Info.NumFactura;

                    contact = Address;
                    Context.prd_Despacho.Add(contact);
                    Context.SaveChanges();

                    prd_DespachoDetalle_Data datadetalle = new prd_DespachoDetalle_Data();
                    if (datadetalle.grabarDB(lmDetalleInfo, Info.IdEmpresa, idgenerada, ref msg))
                    {
                        msg = "Se ha procedido a grabar el Despacho #: " + idgenerada.ToString() + " exitosamente.";
                        return true;
                    }
                    else
                    {
                        return false;
                    }
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

        public Boolean ModificaDB(prd_Despacho_Info info, ref string msg)
        {
            try
            {
                using (EntitiesProduccion_Cidersus context = new EntitiesProduccion_Cidersus())
                {
                    var contact = context.prd_Despacho.FirstOrDefault(obj => obj.IdEmpresa == info.IdEmpresa && obj.IdSucursal == info.IdSucursal && obj.CodObra == info.CodObra && obj.IdDespacho == info.IdDespacho);
                    if (contact != null)
                    {
                        contact.IdBodega = info.IdBodega;
                        contact.IdCliente = info.IdCliente;
                        contact.FechaReg = info.FechaReg;
                        contact.FechaFinTras = info.FechaFinTras;
                        contact.FechaIniTras = info.FechaIniTras;
                        contact.PuntoPartida = info.PuntoPartida;
                        contact.PuntoLLegada = info.PuntoLLegada;
                        contact.NumGuiaRemision = info.NumGuiaRemision;
                        contact.Chofer = info.Chofer;
                        contact.Placa = info.Placa;
                        contact.TipoTransporte = info.TipoTransporte;
                        contact.Observacion = info.Observacion;
                        if (info.Observacion.Length > 1000)
                        {
                            contact.Observacion = info.Observacion.Substring(0, 1000);
                        }
                        contact.IdUsuarioUltModi = info.IdUsuarioUltModi;
                        contact.FechaUltModi = DateTime.Now;
                        contact.NumDespacho = info.NumDespacho;
                        contact.NumFactura = info.NumFactura;


                        context.SaveChanges();
                        msg = "Se ha procedido a actualizar el Despacho #: " + info.NumDespacho.ToString() + " exitosamente.";
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

        //Modificado por Pedro Salinas, se combio el First por el FirstorDefault y se puso una pregunta si el query tiene o no información
        public Boolean AnularReactiva(prd_Despacho_Info info, ref string msg)
        {
            try
            {
                using (EntitiesProduccion_Cidersus context = new EntitiesProduccion_Cidersus())
                {
                    var contact = context.prd_Despacho.FirstOrDefault(A => A.IdEmpresa == info.IdEmpresa && A.IdSucursal == info.IdSucursal && A.IdDespacho == info.IdDespacho);
                    if (contact != null)
                    {
                        contact.Estado = "I";
                        contact.FechaAnu = info.FechaAnu;
                        contact.IdUsuarioAnu = info.IdUsuarioAnu;
                        contact.MotivoAnu = info.MotivoAnu;
                        contact.Observacion = info.Observacion;
                        context.SaveChanges();

                        prd_DespachoDetalle_Data datadetalle = new prd_DespachoDetalle_Data();
                        List<prd_DespachoDetalle_Info> LstDetalle = new List<prd_DespachoDetalle_Info>();

                        LstDetalle = datadetalle.ObtenerDespachoDetalle(info.IdDespacho, info.IdEmpresa, info.IdSucursal);
                        if (datadetalle.eliminarregistrotabla(LstDetalle, info.IdEmpresa, info.IdDespacho, ref msg))
                        {
                            foreach (var item in LstDetalle)
                            {
                                item.Cantidad = 0;
                                item.Observacion = "**ANULADO**" + item.Observacion;

                            }
                            datadetalle.grabarDB(LstDetalle, info.IdEmpresa, info.IdDespacho, ref msg);

                        }


                        msg = "Se anulo correctamente el Despacho # :" + info.NumDespacho;
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

        public int getId(int idempresa, int idsucursal)
        {
            try
            {
                int Id;
                EntitiesProduccion_Cidersus OEProduccion = new EntitiesProduccion_Cidersus();
                var select = from q in OEProduccion.prd_Despacho
                             where q.IdEmpresa == idempresa && q.IdSucursal == idsucursal
                             select q;

                if (select.ToList().Count < 1)
                {
                    Id = 1;
                }
                else
                {
                    var select_pv = (from q in OEProduccion.prd_Despacho
                                     where q.IdEmpresa == idempresa && q.IdSucursal == idsucursal
                                     select q.IdDespacho).Max();
                    Id = Convert.ToInt32(select_pv.ToString()) + 1;
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

        /*public int getNumDespacho(int idempresa, int idsucursal)
        {
            try
            {
                int Id;
                EntitiesProduccion_Cidersus OEProduccion = new EntitiesProduccion_Cidersus();
                var select = from q in OEProduccion.prd_Despacho
                             where q.IdEmpresa == idempresa && q.IdSucursal == idsucursal
                             select q;

                if (select.ToList().Count < 1)
                {
                    Id = 1;
                }
                else
                {
                    var select_pv = (from q in OEProduccion.prd_Despacho
                                     where q.IdEmpresa == idempresa && q.IdSucursal == idsucursal
                                     select q.IdDespacho).Max();
                    Id = Convert.ToInt32(select_pv.ToString()) + 1;
                }
                return Id;
            }
            catch (Exception)
            {

                return -1;
            }

        }*/
    }
}
