using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Data.General;
using Core.Erp.Info.General;
using Core.Erp.Info.ActivoFijo;

namespace Core.Erp.Data.ActivoFijo
{
    public class Af_Retiro_Activo_Data
    {
        tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
        string mensaje = "";

        public Boolean GuardarDB(Af_Retiro_Activo_Info InfoAf, ref decimal IdRetiroActivo, ref string msjError)
        {
            try
            {
                using (EntitiesActivoFijo Context = new EntitiesActivoFijo())
                {
                    var Address = new Af_Retiro_Activo();

                    Address.IdEmpresa = InfoAf.IdEmpresa;
                    Address.IdRetiroActivo = InfoAf.IdRetiroActivo = IdRetiroActivo = getId(InfoAf.IdEmpresa);
                    Address.Cod_Ret_Activo = (InfoAf.Cod_Ret_Activo == "" || InfoAf.Cod_Ret_Activo == null) ? "Retiro_" + InfoAf.IdRetiroActivo : InfoAf.Cod_Ret_Activo;
                    Address.IdActivoFijo = InfoAf.IdActivoFijo;
                    Address.ValorActivo = InfoAf.ValorActivo;
                    Address.Valor_Tot_Bajas = InfoAf.Valor_Tot_Bajas;
                    Address.Valor_Tot_Mejora = InfoAf.Valor_Tot_Mejora;
                    Address.Valor_Depre_Acu = InfoAf.Valor_Depre_Acu;
                    Address.Valor_Neto = InfoAf.Valor_Neto;
                    Address.NumComprobante = InfoAf.NumComprobante;
                    Address.Concepto_Retiro = InfoAf.Concepto_Retiro;
                    Address.Fecha_Retiro = InfoAf.Fecha_Retiro;
                    Address.IdUsuario = InfoAf.IdUsuario;
                    Address.Fecha_Transac = InfoAf.Fecha_Transac;
                    Address.nom_pc = InfoAf.nom_pc;
                    Address.ip = InfoAf.ip;
                    Address.Estado = InfoAf.Estado;

                    Context.Af_Retiro_Activo.Add(Address);
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

        public decimal getId(int IdEmpresa)
        {
            try
            {
                decimal Id;
                EntitiesActivoFijo ocxc = new EntitiesActivoFijo();
                var select = (from q in ocxc.Af_Retiro_Activo
                              where q.IdEmpresa == IdEmpresa
                              select q.IdRetiroActivo).Count();

                if (select == 0)
                {
                    Id = 1;
                }
                else
                {
                    var select_IdCXC = (from q in ocxc.Af_Retiro_Activo
                                        where q.IdEmpresa == IdEmpresa
                                        select q.IdRetiroActivo).Max();
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

        public Boolean ModificarDB(Af_Retiro_Activo_Info InfoAf, ref string msjError)
        {
            try
            {
                using (EntitiesActivoFijo Context = new EntitiesActivoFijo())
                {
                    var contact = Context.Af_Retiro_Activo.FirstOrDefault(af => af.IdEmpresa == InfoAf.IdEmpresa && af.IdRetiroActivo == InfoAf.IdRetiroActivo);
                    if (contact != null)
                    {
                        contact.NumComprobante = InfoAf.NumComprobante;
                        contact.Concepto_Retiro = InfoAf.Concepto_Retiro;
                        contact.Fecha_Retiro = InfoAf.Fecha_Retiro;
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

        public Boolean AnularDB(Af_Retiro_Activo_Info InfoAf, ref string msjError)
        {
            try
            {
                using (EntitiesActivoFijo Context = new EntitiesActivoFijo())
                {
                    var contact = Context.Af_Retiro_Activo.FirstOrDefault(af => af.IdEmpresa == InfoAf.IdEmpresa && af.IdRetiroActivo == InfoAf.IdRetiroActivo);
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

        public List<Af_Retiro_Activo_Info> Get_List_Retiro_Activo(int IdEmpresa, DateTime FechaIni, DateTime FechaFin)
        {
            try
            {
                List<Af_Retiro_Activo_Info> lstInfo = new List<Af_Retiro_Activo_Info>();

                using (EntitiesActivoFijo listado = new EntitiesActivoFijo())
                {
                    var select = from q in listado.vwAf_Retiro_Activo
                                 where q.Fecha_Retiro >= FechaIni && q.Fecha_Retiro <= FechaFin
                                 && q.IdEmpresa == IdEmpresa
                                 select q;

                    foreach (var item in select)
                    {
                        Af_Retiro_Activo_Info infoAf = new Af_Retiro_Activo_Info();

                        infoAf.IdEmpresa = item.IdEmpresa;
                        infoAf.IdRetiroActivo = item.IdRetiroActivo;
                        infoAf.Cod_Ret_Activo = item.Cod_Ret_Activo;
                        infoAf.IdActivoFijo = item.IdActivoFijo;
                        infoAf.Af_Nombre = item.Af_Nombre;
                        infoAf.Encargado = item.NomCompleto;
                        infoAf.ValorActivo = item.ValorActivo;
                        infoAf.Valor_Tot_Bajas = item.Valor_Tot_Bajas;
                        infoAf.Valor_Tot_Mejora = Convert.ToDouble(item.Valor_Tot_Mejora);
                        infoAf.Valor_Depre_Acu = item.Valor_Depre_Acu;
                        infoAf.Valor_Neto = item.Valor_Neto;
                        infoAf.NumComprobante = item.NumComprobante;
                        infoAf.Concepto_Retiro = item.Concepto_Retiro;
                        infoAf.Estado = item.Estado;
                        infoAf.Fecha_Retiro = item.Fecha_Retiro;
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

        public Af_Retiro_Activo_Info Get_Info_Retiro_Activo(int IdEmpresa, decimal IdRetiroActivo)
        {
            try
            {
                Af_Retiro_Activo_Info InfoAf = new Af_Retiro_Activo_Info();

                using (EntitiesActivoFijo listado = new EntitiesActivoFijo())
                {
                    var select = from q in listado.Af_Retiro_Activo
                                 where q.IdEmpresa == IdEmpresa
                                 && q.IdRetiroActivo == IdRetiroActivo
                                 select q;

                    foreach (var item in select)
                    {
                        InfoAf.IdEmpresa = item.IdEmpresa;
                        InfoAf.IdRetiroActivo = item.IdRetiroActivo;
                        InfoAf.Cod_Ret_Activo = item.Cod_Ret_Activo;
                        InfoAf.IdActivoFijo = item.IdActivoFijo;
                        InfoAf.ValorActivo = item.ValorActivo;
                        InfoAf.Valor_Tot_Bajas = item.Valor_Tot_Bajas;
                        InfoAf.Valor_Tot_Mejora = Convert.ToDouble(item.Valor_Tot_Mejora);
                        InfoAf.Valor_Depre_Acu = item.Valor_Depre_Acu;
                        InfoAf.Valor_Neto = item.Valor_Neto;
                        InfoAf.NumComprobante = item.NumComprobante;
                        InfoAf.Concepto_Retiro = item.Concepto_Retiro;
                        InfoAf.Fecha_Retiro = item.Fecha_Retiro;
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
