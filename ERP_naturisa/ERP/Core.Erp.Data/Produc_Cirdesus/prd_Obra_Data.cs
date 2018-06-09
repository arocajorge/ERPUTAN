using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Produc_Cirdesus;
using Core.Erp.Data.General;
using Core.Erp.Info.General;
using Core.Erp.Data.Facturacion;
using Core.Erp.Data.Produc_Cirdesus;
using Core.Erp.Data.Produccion_Edehsa;

namespace Core.Erp.Data.Produc_Cirdesus
{
    public class prd_Obra_Data
    {
        string mensaje = "";
        public List<prd_Obra_Info> ObtenerListaObraxPP(int IdEmpresa, ref string msg)
        {
            try
            {
                using (EntitiesProduccion_Cidersus context = new EntitiesProduccion_Cidersus())
                {

                    string Query = "declare @IdEmpresa int = " + IdEmpresa +
                        "select * from prd_Obra where CodObra not in(select CodObra from prd_ProcesoProductivo_x_prd_obra where " +
                        " IdProcesoProductivo not in (select IdProcesoProductivo from prd_ProcesoProductivo where IdEmpresa ="
                        + IdEmpresa + " and Estado = 'I') and IdEmpresa = " + IdEmpresa + ") and IdEmpresa =" + IdEmpresa;

                    msg = "Proceso exitoso";
                    return context.Database.SqlQuery<prd_Obra_Info>(Query).ToList();


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


        public List<prd_Obra_Info> ObtenerClientes(int IdEmpresa, string cl_RazonSocial)
  {

      try
      {
          List<prd_Obra_Info> lm = new List<prd_Obra_Info>();
          EntitiesFacturacion OEEtapa = new EntitiesFacturacion();
          // var registros = from A in OEEtapa.vwcom_ListadoMateriales_Detalle
          //var registros = from A in OEEtapa.fa_cliente
          //                where A.cl_RazonSocial == cl_RazonSocial


          //                orderby A.cl_RazonSocial
          //                select A;
          //foreach (var item in registros)
          //{
          //    prd_Obra_Info info = new prd_Obra_Info();

          //    info.cl_RazonSocial = item.cl_RazonSocial;
          //}
          return lm;
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
        public List<prd_Obra_Info> ObtenerListaObra(int IdEmpresa)
        {
            try
            {
                List<prd_Obra_Info> lm = new List<prd_Obra_Info>();
                EntitiesProduccion_Cidersus OEEtapa = new EntitiesProduccion_Cidersus();
                var registros = from A in OEEtapa.vwprd_Obras_Cliente
                                where A.IdEmpresa == IdEmpresa
                                orderby A.CodObra
                                select A;
                foreach (var item in registros)
                {
                    prd_Obra_Info info = new prd_Obra_Info();
                    info.CodObra = item.CodObra;
                    info.IdEmpresa = item.IdEmpresa;
                    info.IdCentroCosto = item.IdCentroCosto;
                    info.Descripcion = item.Descripcion;
                    info.Estado = item.Estado;
                    info.Fecha = item.Fecha;
                    info.IdCliente = item.IdCliente;
                    info.DetalleObra = "[" + item.CodObra.Trim() + "] - " + item.Descripcion.Trim();
                    info.cl_RazonSocial = item.cl_RazonSocial;
                    info.PesoObra = item.PesoObra;
                    info.Referencia = item.Referencia;
                    lm.Add(info);
                }
                return lm;
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

        public prd_Obra_Info ObtenerUnaObra(int IdEmpresa, string CodObra)
        {
            try
            {
                EntitiesProduccion_Cidersus OEEtapa = new EntitiesProduccion_Cidersus();
                var registros = from A in OEEtapa.prd_Obra
                                where A.IdEmpresa == IdEmpresa && A.CodObra == CodObra
                                select A;
                if (registros.ToList().Count > 0)
                {
                    prd_Obra_Info info = new prd_Obra_Info();
                    foreach (var item in registros)
                    {
                        info.CodObra = item.CodObra;
                        info.IdEmpresa = item.IdEmpresa;
                        info.IdCentroCosto = item.IdCentroCosto;
                        info.Descripcion = item.Descripcion;
                        info.Estado = item.Estado;
                        info.Fecha = item.Fecha;
                        info.DetalleObra = "[" + item.CodObra.Trim() + "] - " + item.Descripcion.Trim();
                        info.PesoObra = item.PesoObra;
                        info.Referencia = item.Referencia;
                    }
                    return info;
                }
                else
                    return new prd_Obra_Info();
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

        public Boolean GuardarDB(prd_Obra_Info info, ref string msg)
        {
            try
            {
                using (EntitiesProduccion_Cidersus Context = new EntitiesProduccion_Cidersus())
                {
                    var Address = new prd_Obra();

                    Address.IdEmpresa = info.IdEmpresa;
                    Address.CodObra = info.CodObra;
                    Address.Descripcion = info.Descripcion;
                    Address.Estado = "A";
                    Address.Fecha = info.Fecha;
                    Address.IdCentroCosto = info.CodObra;
                    Address.IdUsuario = info.IdUsuario;
                    Address.FechaTransac = info.FechaTransac;

                    Address.IdCliente = info.IdCliente;
                    Address.PesoObra = info.PesoObra;
                    Address.Referencia = info.Referencia;

                    Context.prd_Obra.Add(Address);
                    Context.SaveChanges();

                }
                msg = "Grabación exitosa..";
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

        public Boolean AnularDB(prd_Obra_Info info, ref string msg)
        {
            try
            {
                using (EntitiesProduccion_Cidersus Context = new EntitiesProduccion_Cidersus())
                {
                    var contact = Context.prd_Obra.FirstOrDefault(A => A.IdEmpresa == info.IdEmpresa && A.CodObra == info.CodObra);
                    if (contact != null)
                    {
                        contact.Estado = "I";
                        contact.IdUsuarioAnu = info.IdUsuarioAnu;
                        contact.MotivoAnu = info.MotivoAnu;
                        contact.FechaAnu = info.FechaAnu;
                        Context.SaveChanges();
                        msg = "Grabación exitosa..";
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

        public Boolean ModificarDB(prd_Obra_Info info, ref string msg)
        {
            try
            {
                using (EntitiesProduccion_Cidersus Context = new EntitiesProduccion_Cidersus())
                {
                    var contact = Context.prd_Obra.FirstOrDefault(A => A.IdEmpresa == info.IdEmpresa && A.CodObra == info.CodObra);
                    if (contact != null)
                    {
                        contact.Descripcion = info.Descripcion;
                        contact.Estado = info.Estado;
                        contact.Fecha = info.Fecha;
                        contact.IdUsuarioAnu = info.IdUsuarioAnu;
                        contact.IdUsuarioUltModi = info.IdUsuarioUltModi;
                        contact.FechaUltModi = info.FechaUltModi;
                        contact.IdCliente = info.IdCliente;
                        contact.PesoObra = info.PesoObra;
                        contact.Referencia = info.Referencia;

                        Context.SaveChanges();
                        msg = "Grabación exitosa..";
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

        public Boolean VerificarExisteCodigo(string CodObra)
        {
            try
            {
                EntitiesProduccion_Cidersus oen = new EntitiesProduccion_Cidersus();

                var select = from q in oen.prd_Obra
                             where q.CodObra == CodObra
                             select q;

                if (select.ToList().Count() >= 1)
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
                mensaje = ex.ToString() + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        }

        public Boolean CompararPesoObra(decimal Peso_a_Comparar, string CodObra)
        {
            try
            {
                decimal PesoObra;
                EntitiesProduccion_Cidersus OEEtapa = new EntitiesProduccion_Cidersus();
                var select_em = (from q in OEEtapa.prd_Obra
                                 select q.PesoObra);
                
                PesoObra = Convert.ToInt32(select_em.ToString());

                if (PesoObra <= Peso_a_Comparar)
                {
                    return true;
                }
                else
                    return false;

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

        public Int32 ObtenerIdObra(ref string msg)
        {
            try
            {
                Int32 IdObra = 0;
                //EntitiesProduccion_Cidersus OEEtapa = new EntitiesProduccion_Cidersus();
                EntitiesProduccion_Edehsa OEEtapa = new EntitiesProduccion_Edehsa();

                var selecte = OEEtapa.vwprd_Obra.Count();

                if (selecte == 0)
                {
                    IdObra = 1;
                }
                else
                {
                    var select_em = (from q in OEEtapa.vwprd_Obra
                                     select q.CodObra).Max();
                    IdObra = Convert.ToInt32(select_em.ToString()) + 1;
                }

                return IdObra;
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
    }
}
