using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Data.General;
using Core.Erp.Info.General;
using Core.Erp.Info.ActivoFijo;

namespace Core.Erp.Data.ActivoFijo
{
    public class Af_Mej_Baj_Activo_Data
    {
        tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
        string mensaje = "";

        public Boolean GuardarDB(Af_Mej_Baj_Activo_Info InfoAf, ref decimal Id_Mejora_Baja_Activo,  ref string msjError)
        {
            try
            {
                using (EntitiesActivoFijo Context = new EntitiesActivoFijo())
                {                    
                    var Address = new Af_Mej_Baj_Activo();
                    Address.IdEmpresa = InfoAf.IdEmpresa;
                    Address.Id_Mejora_Baja_Activo = InfoAf.Id_Mejora_Baja_Activo = Id_Mejora_Baja_Activo = GetId(InfoAf.IdEmpresa, InfoAf.Id_Tipo);
                    Address.Id_Tipo = InfoAf.Id_Tipo;
                    Address.IdActivoFijo = InfoAf.IdActivoFijo;
                    Address.IdProveedor = InfoAf.IdProveedor;
                    Address.Cod_Mej_Baj_Activo = (InfoAf.Cod_Mej_Baj_Activo == "" || InfoAf.Cod_Mej_Baj_Activo == null) ? "Mej_Baj_" + InfoAf.Id_Mejora_Baja_Activo : InfoAf.Cod_Mej_Baj_Activo;
                    Address.ValorActivo = InfoAf.ValorActivo;
                    Address.Valor_Mej_Baj_Activo = InfoAf.Valor_Mej_Baj_Activo;
                    Address.Compr_Mej_Baj = InfoAf.Compr_Mej_Baj;
                    Address.DescripcionTecnica = InfoAf.DescripcionTecnica;
                    Address.Motivo = InfoAf.Motivo;
                    Address.IdUsuario = InfoAf.IdUsuario;
                    Address.Fecha_Transac = InfoAf.Fecha_Transac;                   
                    Address.nom_pc = InfoAf.nom_pc;
                    Address.ip = InfoAf.ip;
                    Address.Estado = InfoAf.Estado;

                    Context.Af_Mej_Baj_Activo.Add(Address);
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

        public decimal GetId(int IdEmpresa, string Id_Tipo)
        {
            try
            {
                decimal Id;
                EntitiesActivoFijo ocxc = new EntitiesActivoFijo();
                var select = (from q in ocxc.Af_Mej_Baj_Activo
                              where q.IdEmpresa == IdEmpresa && q.Id_Tipo == Id_Tipo
                              select q.Id_Mejora_Baja_Activo).Count();
                
                if (select == 0)
                {
                    Id = 1;
                }
                else
                {
                    var select_IdCXC = (from q in ocxc.Af_Mej_Baj_Activo
                                        where q.IdEmpresa == IdEmpresa && q.Id_Tipo == Id_Tipo
                                        select q.Id_Mejora_Baja_Activo).Max();
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
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public Boolean ModificarDB(Af_Mej_Baj_Activo_Info InfoAf, ref string msjError)
        {
            try
            {
                using (EntitiesActivoFijo Context = new EntitiesActivoFijo())
                {
                    var contact = Context.Af_Mej_Baj_Activo.FirstOrDefault(af => af.IdEmpresa == InfoAf.IdEmpresa && af.Id_Mejora_Baja_Activo == InfoAf.Id_Mejora_Baja_Activo && af.Id_Tipo == InfoAf.Id_Tipo);
                    if (contact != null)
                    {
                        contact.IdProveedor = InfoAf.IdProveedor;
                        contact.Valor_Mej_Baj_Activo = InfoAf.Valor_Mej_Baj_Activo;
                        contact.Compr_Mej_Baj = InfoAf.Compr_Mej_Baj;
                        contact.DescripcionTecnica = InfoAf.DescripcionTecnica;
                        contact.Motivo = InfoAf.Motivo;
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

        public Boolean AnularDB(Af_Mej_Baj_Activo_Info InfoAf, ref string msjError)
        {
            try
            {
                using (EntitiesActivoFijo Context = new EntitiesActivoFijo())
                {
                    var contact = Context.Af_Mej_Baj_Activo.FirstOrDefault(af => af.IdEmpresa == InfoAf.IdEmpresa && af.Id_Mejora_Baja_Activo == InfoAf.Id_Mejora_Baja_Activo && af.Id_Tipo == InfoAf.Id_Tipo);
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

        public Af_Mej_Baj_Activo_Info Get_Info_Mej_Baj_Activo(int IdEmpresa, decimal Id_Mej_Baj_Activo, string Id_Tipo)
        {
            try
            {
                Af_Mej_Baj_Activo_Info infoAf = new Af_Mej_Baj_Activo_Info();

                using (EntitiesActivoFijo listado = new EntitiesActivoFijo())
                {
                    var select = from q in listado.Af_Mej_Baj_Activo
                                 where q.IdEmpresa == IdEmpresa
                                 && q.Id_Mejora_Baja_Activo == Id_Mej_Baj_Activo && q.Id_Tipo == Id_Tipo
                                 select q;

                    foreach (var item in select)
                    {
                        infoAf.IdEmpresa = item.IdEmpresa;
                        infoAf.Id_Mejora_Baja_Activo = item.Id_Mejora_Baja_Activo;
                        infoAf.Id_Tipo = item.Id_Tipo;
                        infoAf.IdActivoFijo = item.IdActivoFijo;
                        infoAf.IdProveedor = item.IdProveedor;
                        infoAf.Cod_Mej_Baj_Activo = item.Cod_Mej_Baj_Activo;
                        infoAf.ValorActivo = Convert.ToDouble(item.ValorActivo);
                        infoAf.Valor_Mej_Baj_Activo = Convert.ToDouble(item.Valor_Mej_Baj_Activo);
                        infoAf.Compr_Mej_Baj = item.Compr_Mej_Baj;
                        infoAf.DescripcionTecnica = item.DescripcionTecnica;
                        infoAf.Motivo = item.Motivo;
                        infoAf.IdUsuario = item.IdUsuario;
                        infoAf.Fecha_Transac = Convert.ToDateTime(item.Fecha_Transac);
                        infoAf.Estado = item.Estado;
                    }
                }
                return infoAf;
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

        public List<Af_Mej_Baj_Activo_Info> Get_List_Mej_Baj_Activo(int IdEmpresa, string IdTipo, DateTime FechaIni, DateTime FechaFin)
        {
            try
            {
                List<Af_Mej_Baj_Activo_Info> lstInfo = new List<Af_Mej_Baj_Activo_Info>();

                using (EntitiesActivoFijo listado = new EntitiesActivoFijo())
                {
                    var select = from q in listado.vwAf_Mej_Baj_Activo
                                 where q.IdEmpresa == IdEmpresa  && q.Id_Tipo == IdTipo 
                                 && q.Fecha_Transac >= FechaIni && q.Fecha_Transac <= FechaFin 
                                 select q;

                    foreach (var item in select)
                    {
                        Af_Mej_Baj_Activo_Info infoAf = new Af_Mej_Baj_Activo_Info();

                        infoAf.IdEmpresa = item.IdEmpresa;
                        infoAf.Id_Mejora_Baja_Activo = item.Id_Mejora_Baja_Activo;
                        infoAf.Id_Tipo = item.Id_Tipo;
                        infoAf.IdActivoFijo = item.IdActivoFijo;
                        infoAf.Af_Nombre = item.Af_Nombre;
                        infoAf.Encargado = item.NomCompleto;
                        infoAf.IdProveedor = item.IdProveedor;
                        infoAf.pr_nombre = item.pr_nombre;
                        infoAf.ValorActivo = Convert.ToDouble(item.ValorActivo);
                        infoAf.Valor_Mej_Baj_Activo = Convert.ToDouble(item.Valor_Mej_Baj_Activo);
                        infoAf.Compr_Mej_Baj = item.Compr_Mej_Baj;
                        infoAf.DescripcionTecnica = item.DescripcionTecnica;
                        infoAf.Motivo = item.Motivo;
                        infoAf.Fecha_Transac = Convert.ToDateTime(item.Fecha_Transac);
                        infoAf.Estado = item.Estado;

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

        public List<Af_Mej_Baj_Activo_Info> Get_List_Sum_Valor_Mej_Baj_Activo(int IdEmpresa, decimal IdActivoFijo)
        {
            try
            {
                List<Af_Mej_Baj_Activo_Info> lstInfo = new List<Af_Mej_Baj_Activo_Info>();

                using (EntitiesActivoFijo listado = new EntitiesActivoFijo())
                {

                    var select = from q in listado.vwAf_Mej_Baj_Activo
                                 where q.IdEmpresa == IdEmpresa && q.IdActivoFijo == IdActivoFijo
                                 group q by new
                                 {
                                     q.IdEmpresa,
                                     q.Id_Tipo,
                                     q.IdActivoFijo,
                                     q.ValorActivo
                                 }
                                     into grouping
                                     select new { grouping.Key, Valor_Mej_Baj_Activo = grouping.Sum(p => p.Valor_Mej_Baj_Activo) , };
                                        
                    
                    foreach (var item in select)
                    {
                        Af_Mej_Baj_Activo_Info infoAf = new Af_Mej_Baj_Activo_Info();

                        infoAf.IdEmpresa = item.Key.IdEmpresa;
                        infoAf.Id_Tipo = item.Key.Id_Tipo;
                        infoAf.IdActivoFijo = item.Key.IdActivoFijo;
                        infoAf.ValorActivo = Convert.ToDouble(item.Key.ValorActivo);
                        infoAf.Valor_Mej_Baj_Activo = (Convert.ToDouble(item.Valor_Mej_Baj_Activo) < 0) ? Convert.ToDouble(item.Valor_Mej_Baj_Activo) * (-1) : Convert.ToDouble(item.Valor_Mej_Baj_Activo);
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
    }
}
