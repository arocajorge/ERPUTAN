using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Data.General;
using Core.Erp.Info.General;
using Core.Erp.Info.ActivoFijo;


namespace Core.Erp.Data.ActivoFijo
{
    public class Af_Venta_Activo_Data
    {
        tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
        string mensaje = "";

        public Boolean GuardarDB(Af_Venta_Activo_Info InfoAf, ref decimal IdVtaActivo, ref string msjError)
        {
            try
            {
                using (EntitiesActivoFijo Context = new EntitiesActivoFijo())
                {
                    //var contact = Af_Venta_Activo.CreateAf_Venta_Activo(0, 0, "", 0, 0, 0, 0, 0, 0, 0, 0, DateTime.Now);

                    var Address = new Af_Venta_Activo();
                    Address.IdEmpresa = InfoAf.IdEmpresa;
                    Address.IdVtaActivo = InfoAf.IdVtaActivo = IdVtaActivo = GetId(InfoAf.IdEmpresa);
                    Address.Cod_VtaActivo = (InfoAf.Cod_VtaActivo == "" || InfoAf.Cod_VtaActivo == null) ? "Vta_" + InfoAf.IdVtaActivo : InfoAf.Cod_VtaActivo;
                    Address.IdActivoFijo = InfoAf.IdActivoFijo;
                    Address.ValorActivo = InfoAf.ValorActivo;
                    Address.Valor_Tot_Bajas = InfoAf.Valor_Tot_Bajas;
                    Address.Valor_Tot_Mejora = InfoAf.Valor_Tot_Mejora;
                    Address.Valor_Depre_Acu = InfoAf.Valor_Depre_Acu;
                    Address.Valor_Neto = InfoAf.Valor_Neto;
                    Address.Valor_Venta = InfoAf.Valor_Venta;
                    Address.Valor_Perdi_Gana = InfoAf.Valor_Perdi_Gana;
                    Address.NumComprobante = InfoAf.NumComprobante;
                    Address.Concepto_Vta = InfoAf.Concepto_Vta;
                    Address.Fecha_Venta = InfoAf.Fecha_Venta;
                    Address.IdUsuario = InfoAf.IdUsuario;
                    Address.Fecha_Transac = InfoAf.Fecha_Transac;
                    Address.nom_pc = InfoAf.nom_pc;
                    Address.ip = InfoAf.ip;
                    Address.Estado = InfoAf.Estado;
                    //contact = Address;
                    Context.Af_Venta_Activo.Add(Address);
                    Context.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                msjError = mensaje;
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public decimal GetId(int IdEmpresa)
        {
            try
            {
                decimal Id;
                EntitiesActivoFijo ocxc = new EntitiesActivoFijo();
                var select = (from q in ocxc.Af_Venta_Activo
                              where q.IdEmpresa == IdEmpresa 
                              select q.IdVtaActivo).Count();

                if (select == 0)
                {
                    Id = 1;
                }
                else
                {
                    var select_IdCXC = (from q in ocxc.Af_Venta_Activo
                                        where q.IdEmpresa == IdEmpresa
                                        select q.IdVtaActivo).Max();
                    Id = Convert.ToInt32(select_IdCXC.ToString()) + 1;
                }
                return Id;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public Boolean ModificarDB(Af_Venta_Activo_Info InfoAf, ref string msjError)
        {
            try
            {
                using (EntitiesActivoFijo Context = new EntitiesActivoFijo())
                {
                    var contact = Context.Af_Venta_Activo.FirstOrDefault(af => af.IdEmpresa == InfoAf.IdEmpresa && af.IdVtaActivo == InfoAf.IdVtaActivo);
                    if (contact != null)
                    {
                        contact.Valor_Venta = InfoAf.Valor_Venta;
                        contact.Valor_Perdi_Gana = InfoAf.Valor_Perdi_Gana;
                        contact.NumComprobante = InfoAf.NumComprobante;
                        contact.Concepto_Vta = InfoAf.Concepto_Vta;
                        contact.Fecha_Venta = InfoAf.Fecha_Venta;
                        contact.IdUsuarioUltMod = InfoAf.IdUsuarioUltMod;
                        contact.Fecha_UltMod = InfoAf.Fecha_UltMod;
                        Context.SaveChanges();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                msjError = mensaje;
                throw new Exception(ex.ToString());
            }
        }

        public Boolean AnularDB(Af_Venta_Activo_Info InfoAf, ref string msjError)
        {
            try
            {
                using (EntitiesActivoFijo Context = new EntitiesActivoFijo())
                {
                    var contact = Context.Af_Venta_Activo.FirstOrDefault(af => af.IdEmpresa == InfoAf.IdEmpresa && af.IdVtaActivo == InfoAf.IdVtaActivo);
                    if (contact != null)
                    {
                        contact.IdUsuarioUltAnu = InfoAf.IdUsuarioUltAnu;
                        contact.Fecha_UltAnu = InfoAf.Fecha_UltAnu;
                        contact.MotivoAnula = InfoAf.MotivoAnula;
                        contact.Estado = "I";
                        Context.SaveChanges();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                msjError = mensaje;
                throw new Exception(ex.ToString());
            }
        }

        public List<Af_Venta_Activo_Info> Get_List_Venta_Activo(int IdEmpresa, DateTime FechaIni, DateTime FechaFin)
        {
            try
            {
                List<Af_Venta_Activo_Info> lstInfo = new List<Af_Venta_Activo_Info>();

                using (EntitiesActivoFijo listado = new EntitiesActivoFijo())
                {
                    var select = from q in listado.vwAf_Venta_Activo
                                 where q.Fecha_Venta >= FechaIni && q.Fecha_Venta <= FechaFin
                                  && q.IdEmpresa == IdEmpresa
                                 select q;

                    foreach (var item in select)
                    {
                        Af_Venta_Activo_Info infoAf = new Af_Venta_Activo_Info();

                        infoAf.IdEmpresa = item.IdEmpresa;
                        infoAf.IdVtaActivo = item.IdVtaActivo;
                        infoAf.Cod_VtaActivo = item.Cod_VtaActivo;
                        infoAf.IdActivoFijo = item.IdActivoFijo;
                        infoAf.Af_Nombre = item.Af_Nombre;
                        infoAf.Encargado = item.NomCompleto;
                        infoAf.ValorActivo = item.ValorActivo;
                        infoAf.Valor_Tot_Bajas = item.Valor_Tot_Bajas;
                        infoAf.Valor_Tot_Mejora = item.Valor_Tot_Mejora;
                        infoAf.Valor_Depre_Acu = item.Valor_Depre_Acu;
                        infoAf.Valor_Neto = item.Valor_Neto;
                        infoAf.Valor_Venta = item.Valor_Venta;
                        infoAf.Valor_Perdi_Gana = item.Valor_Perdi_Gana;
                        infoAf.NumComprobante = item.NumComprobante;
                        infoAf.Concepto_Vta = item.Concepto_Vta;
                        infoAf.Estado = item.Estado;
                        infoAf.Fecha_Venta = item.Fecha_Venta;
  
                        lstInfo.Add(infoAf);
                    }
                }
                return lstInfo;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public Af_Venta_Activo_Info Get_Info_Venta_Activo(int IdEmpresa, decimal IdVtaActivo)
        {
            try
            {
                Af_Venta_Activo_Info InfoAf = new Af_Venta_Activo_Info();

                using (EntitiesActivoFijo listado = new EntitiesActivoFijo())
                {
                    var select = from q in listado.Af_Venta_Activo
                                 where q.IdEmpresa == IdEmpresa
                                 && q.IdVtaActivo == IdVtaActivo
                                 select q;

                    foreach (var item in select)
                    {
                        InfoAf.IdEmpresa = item.IdEmpresa;
                        InfoAf.IdVtaActivo = item.IdVtaActivo;
                        InfoAf.Cod_VtaActivo = item.Cod_VtaActivo;
                        InfoAf.IdActivoFijo = item.IdActivoFijo;
                        InfoAf.ValorActivo = item.ValorActivo;
                        InfoAf.Valor_Tot_Bajas = item.Valor_Tot_Bajas;
                        InfoAf.Valor_Tot_Mejora = item.Valor_Tot_Mejora;
                        InfoAf.Valor_Depre_Acu = item.Valor_Depre_Acu;
                        InfoAf.Valor_Neto = item.Valor_Neto;
                        InfoAf.Valor_Venta = item.Valor_Venta;
                        InfoAf.Valor_Perdi_Gana = item.Valor_Perdi_Gana;
                        InfoAf.NumComprobante = item.NumComprobante;
                        InfoAf.Concepto_Vta = item.Concepto_Vta;
                        InfoAf.Fecha_Venta = item.Fecha_Venta;
                        InfoAf.IdUsuario = item.IdUsuario;
                        InfoAf.Fecha_Transac = Convert.ToDateTime(item.Fecha_Transac);
                        InfoAf.nom_pc = item.nom_pc;
                        InfoAf.ip = item.ip;
                        InfoAf.Estado = item.Estado;
                    }
                }
                return InfoAf;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }
    }
}
