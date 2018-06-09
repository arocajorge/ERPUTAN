using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.ActivoFijo;
using Core.Erp.Data.General;
using Core.Erp.Info.General;
using Core.Erp.Info.Contabilidad;

namespace Core.Erp.Data.ActivoFijo
{
    public class Af_Depreciacion_Data
    {
        tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
        Af_Depreciacion_Det_Data dataDetalle = new Af_Depreciacion_Det_Data();
        string mensaje = "";

        public Boolean GuardarDB(Af_Depreciacion_Info Info, ref decimal IdDepreciacion, ref string msjError)
        {
            try
            {
                using (EntitiesActivoFijo Context = new EntitiesActivoFijo())
                {
                    var Address = new Af_Depreciacion();
                    Address.IdEmpresa = Info.IdEmpresa;
                    Address.IdDepreciacion = Info.IdDepreciacion = IdDepreciacion = GetId(Info.IdEmpresa, Info.IdTipoDepreciacion);
                    Address.IdTipoDepreciacion = Info.IdTipoDepreciacion;
                    Address.Cod_Depreciacion = (Info.Cod_Depreciacion == "" || Info.Cod_Depreciacion == null ) ? "Depre_" + Info.IdDepreciacion : Info.Cod_Depreciacion;
                    Address.IdPeriodo = Info.IdPeriodo;
                    Address.Descripcion = Info.Descripcion;
                    Address.Fecha_Depreciacion = Info.Fecha_Depreciacion.Date;
                    Address.Num_Act_Depre = Info.Num_Act_Depre;
                    Address.Valor_Tot_Act = Info.Valor_Tot_Act;
                    Address.Valor_Tot_Depre = Info.Valor_Tot_Depre;
                    Address.Valor_Tot_DepreAcum = Info.Valor_Tot_DepreAcum;
                    Address.Valot_Tot_Importe = Info.Valot_Tot_Importe;
                    Address.IdUsuario = Info.IdUsuario;
                    Address.Fecha_Transac = Info.Fecha_Transac;
                    Address.nom_pc = Info.nom_pc;
                    Address.ip = Info.ip;
                    Address.Estado = Info.Estado;
                    Context.Af_Depreciacion.Add(Address);
                    Context.SaveChanges();

                    dataDetalle.GuardarDB(Info.ListDetalle,Info.IdDepreciacion , Info.IdTipoDepreciacion, ref msjError);
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

        public decimal GetId(int IdEmpresa, int IdTipoDepreciacion)
        {
            try
            {
                decimal Id;
                EntitiesActivoFijo ocxc = new EntitiesActivoFijo();
                var select = (from q in ocxc.Af_Depreciacion
                              where q.IdEmpresa == IdEmpresa && q.IdTipoDepreciacion == IdTipoDepreciacion
                              select q.IdDepreciacion).Count();

                if (select == 0)
                {
                    Id = 1;
                }
                else
                {
                    var select_IdCXC = (from q in ocxc.Af_Depreciacion
                                        where q.IdEmpresa == IdEmpresa && q.IdTipoDepreciacion == IdTipoDepreciacion
                                        select q.IdDepreciacion).Max();
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

        public Boolean ModificarDB(Af_Depreciacion_Info Info, ref string msjError)
        {
            try
            {
                using (EntitiesActivoFijo Context = new EntitiesActivoFijo())
                {
                    var contact = Context.Af_Depreciacion.FirstOrDefault(q => q.IdEmpresa == Info.IdEmpresa && q.IdDepreciacion == Info.IdDepreciacion && q.IdTipoDepreciacion == Info.IdTipoDepreciacion);
                    if (Context != null)
                    {
                        //contact.IdUsuarioUltMod = Info.IdUsuarioUltAnu;
                        //contact.Fecha_UltMod = Info.Fecha_UltAnu;
                        contact.Descripcion = Info.Descripcion;
                        contact.Fecha_Depreciacion = Info.Fecha_Depreciacion;
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

        public Boolean AnularDB(Af_Depreciacion_Info InfoAf, ref string msjError)
        {
            try
            {
                using (EntitiesActivoFijo Context = new EntitiesActivoFijo())
                {
                    var contact = Context.Af_Depreciacion.FirstOrDefault(q => q.IdEmpresa == InfoAf.IdEmpresa && q.IdDepreciacion == InfoAf.IdDepreciacion && q.IdTipoDepreciacion == InfoAf.IdTipoDepreciacion);
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

        public Boolean EliminarDB(Af_Depreciacion_Info Info, ref string msjError)
        {
            try
            {

                using (EntitiesActivoFijo Context = new EntitiesActivoFijo())
                {
                    foreach (var item in Info.ListDetalle)
                    {
                        item.IdDepreciacion = Info.IdDepreciacion;
                        item.IdTipoDepreciacion = Info.IdTipoDepreciacion;
                    }
                    dataDetalle.EliminarDB(Info.ListDetalle, ref msjError);

                    var contact = Context.Af_Depreciacion.FirstOrDefault(q => q.IdEmpresa == Info.IdEmpresa && q.IdDepreciacion == Info.IdDepreciacion && q.IdTipoDepreciacion == Info.IdTipoDepreciacion);
                    if (contact != null)
                    {
                        Context.Af_Depreciacion.Remove(contact);
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

        public List<Af_Depreciacion_Info> Get_List_Depreciacion(int IdEmpresa, int IdTipoDepreciacion, DateTime FechaIni, DateTime FechaFin)
        {
            try
            {
                List<Af_Depreciacion_Info> lstInfo = new List<Af_Depreciacion_Info>();

                using (EntitiesActivoFijo listado = new EntitiesActivoFijo())
                {
                    var select = from q in listado.vwAf_Depreciacion
                                 where q.IdEmpresa == IdEmpresa
                                 && q.IdTipoDepreciacion == IdTipoDepreciacion
                                 && q.Fecha_Depreciacion >= FechaIni && q.Fecha_Depreciacion <= FechaFin
                                 select q;

                    foreach (var item in select)
                    {
                        Af_Depreciacion_Info InfoDepre = new Af_Depreciacion_Info();
                        InfoDepre.IdEmpresa = item.IdEmpresa;
                        InfoDepre.IdDepreciacion = item.IdDepreciacion;
                        InfoDepre.IdTipoDepreciacion = item.IdTipoDepreciacion;
                        InfoDepre.Cod_Depreciacion = item.Cod_Depreciacion;
                        InfoDepre.IdPeriodo = item.IdPeriodo;
                        InfoDepre.Descripcion = item.Descripcion;
                        InfoDepre.Fecha_Depreciacion = item.Fecha_Depreciacion;
                        InfoDepre.IdUsuario = item.IdUsuario;
                        InfoDepre.nom_tipo_depreciacion = item.nom_tipo_depreciacion;
                        InfoDepre.cod_tipo_depreciacion = item.cod_tipo_depreciacion;
                        InfoDepre.Valor_Depreciacion = Convert.ToDouble(item.Valor_Depreciacion);
                        InfoDepre.Valor_Depre_Acum = Convert.ToDouble(item.Valor_Depre_Acum);
                        InfoDepre.Valor_Importe = Convert.ToDouble(item.Valor_Importe);
                        InfoDepre.Estado = item.Estado;

                        lstInfo.Add(InfoDepre);
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

        public List<ct_Periodo_Info> Get_Periodos_No_Depreciados(int IdEmpresa)
        {
            try
            {
                List<ct_Periodo_Info> lstInfo = new List<ct_Periodo_Info>();
                using (EntitiesActivoFijo listado = new EntitiesActivoFijo())
                {
                    var select = from q in listado.vwaf_Periodo_Sin_Depreciar
                                 where q.IdEmpresa == IdEmpresa 
                                 select q;

                    foreach (var item in select)
                    {
                        ct_Periodo_Info Cbt = new ct_Periodo_Info();
                        Cbt.IdEmpresa = item.IdEmpresa;
                        Cbt.IdPeriodo = item.IdPeriodo;
                        Cbt.nom_periodo = item.IdanioFiscal.ToString() + "-" + item.smes.Trim();
                        Cbt.IdanioFiscal = item.IdanioFiscal;
                        Cbt.pe_mes = item.pe_mes;
                        Cbt.pe_FechaIni = item.pe_FechaIni;
                        Cbt.pe_FechaFin = item.pe_FechaFin;
                        Cbt.pe_cerrado = item.pe_cerrado;
                        Cbt.pe_estado = item.pe_estado;
                        lstInfo.Add(Cbt);
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

        public Af_Depreciacion_Info Get_Info_Depreciacion(int IdEmpresa, decimal IdDepreciacion, int IdTipoDepreciacion)
        {
            try
            {
                Af_Depreciacion_Info InfoDepre = new Af_Depreciacion_Info();

                using (EntitiesActivoFijo listado = new EntitiesActivoFijo())
                {
                    var select = from q in listado.Af_Depreciacion
                                 where q.IdEmpresa == IdEmpresa
                                 && q.IdDepreciacion == IdDepreciacion && q.IdTipoDepreciacion == IdTipoDepreciacion
                                 select q;

                    foreach (var item in select)
                    {
                        InfoDepre.IdEmpresa = item.IdEmpresa;
                        InfoDepre.IdDepreciacion = item.IdDepreciacion;
                        InfoDepre.IdTipoDepreciacion = item.IdTipoDepreciacion;
                        InfoDepre.Cod_Depreciacion = item.Cod_Depreciacion;
                        InfoDepre.IdPeriodo = item.IdPeriodo;
                        InfoDepre.Descripcion = item.Descripcion;
                        InfoDepre.Fecha_Depreciacion = item.Fecha_Depreciacion;
                        InfoDepre.Num_Act_Depre = item.Num_Act_Depre;
                        InfoDepre.Valor_Tot_Act = item.Valor_Tot_Act;
                        InfoDepre.Valor_Tot_Depre = item.Valor_Tot_Depre;
                        InfoDepre.Valor_Tot_DepreAcum = item.Valor_Tot_DepreAcum;
                        InfoDepre.Valot_Tot_Importe = item.Valot_Tot_Importe;
                        InfoDepre.IdUsuario = item.IdUsuario;
                        InfoDepre.Estado = item.Estado;

                        InfoDepre.lstGridDepre = dataDetalle.Get_List_Depreciacion_Detalle(InfoDepre.IdEmpresa, InfoDepre.IdDepreciacion, InfoDepre.IdTipoDepreciacion);
                    }
                }
                return InfoDepre;
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

        public Boolean Guardar_HistoricoDB(Af_Depreciacion_Info Info, ref string msjError)
        {
            try
            {
                int IdHisDepreciacion = 0;
                using (EntitiesActivoFijo Context = new EntitiesActivoFijo())
                {                    
                    var Address = new Af_Depreciacion_His_Anulacion();
                    Address.IdEmpresa = Info.IdEmpresa;
                    Address.IdHisDepreciacion = IdHisDepreciacion = Get_HistoricoId(Info.IdEmpresa);
                    Address.IdDepreciacion = Info.IdDepreciacion;
                    Address.IdTipoDepreciacion = Info.IdTipoDepreciacion;
                    Address.Cod_Depreciacion = Info.Cod_Depreciacion;
                    Address.IdPeriodo = Info.IdPeriodo;
                    Address.Descripcion = Info.Descripcion;
                    Address.Fecha_Depreciacion = Info.Fecha_Depreciacion;
                    Address.Num_Act_Depre = Info.Num_Act_Depre;
                    Address.Valor_Tot_Act = Info.Valor_Tot_Act;
                    Address.Valor_Tot_Depre = Info.Valor_Tot_Depre;
                    Address.Valor_Tot_DepreAcum = Info.Valor_Tot_DepreAcum;
                    Address.Valot_Tot_Importe = Info.Valot_Tot_Importe;
                    Address.IdUsuario = Info.IdUsuario;
                    Address.Fecha_Transac = Info.Fecha_Transac;
                    Address.nom_pc = Info.nom_pc;
                    Address.ip = Info.ip;
                    Address.Estado = Info.Estado;
                    Address.IdUsuarioUltMod = Info.IdUsuarioUltAnu;
                    Address.Fecha_UltMod = Info.Fecha_UltAnu;
                    Address.IdUsuarioUltAnu = Info.IdUsuarioUltAnu;
                    Address.Fecha_UltAnu = Info.Fecha_UltAnu;
                    Address.MotivoAnula = Info.MotivoAnula;

                    Context.Af_Depreciacion_His_Anulacion.Add(Address);
                    Context.SaveChanges();

                    dataDetalle.Guardar_HistoricoDB(Info.ListDetalle,IdHisDepreciacion,  Info.IdDepreciacion, Info.IdTipoDepreciacion, ref msjError);
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

        public int Get_HistoricoId(int IdEmpresa)
        {
            try
            {
                int Id;
                EntitiesActivoFijo ocxc = new EntitiesActivoFijo();
                var select = (from q in ocxc.Af_Depreciacion_His_Anulacion
                              where q.IdEmpresa == IdEmpresa 
                              select q.IdHisDepreciacion).Count();

                if (select == 0)
                {
                    Id = 1;
                }
                else
                {
                    var select_IdCXC = (from q in ocxc.Af_Depreciacion_His_Anulacion
                                        where q.IdEmpresa == IdEmpresa
                                        select q.IdHisDepreciacion).Max();
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

        public Boolean VerificarUltDepre(int IdEmpresa, decimal IdDepreciacion, int IdTipoDepreciacion)
        {
            try
            {                
                EntitiesActivoFijo ocxc = new EntitiesActivoFijo();
                var select = (from q in ocxc.Af_Depreciacion
                              where q.IdEmpresa == IdEmpresa && q.IdDepreciacion == IdDepreciacion
                              && q.IdTipoDepreciacion == IdTipoDepreciacion && q.Estado == "A"
                              select q.IdDepreciacion).Max();

                if (Convert.ToInt32(select.ToString()) == IdDepreciacion)                
                    return true;                
                else
                    return false;
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

        public Boolean VerificarPeriodoExistente(int IdEmpresa, int IdPeriodo, string Estado)
        {
            try
            {
                EntitiesActivoFijo ocxc = new EntitiesActivoFijo();
                var select = (from q in ocxc.Af_Depreciacion
                              where q.IdEmpresa == IdEmpresa && q.IdPeriodo == IdPeriodo
                              && q.Estado == Estado
                              select q);

                if (select.Count() > 0)
                    return false;
                else
                    return true;
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

        public List<vwAf_Valores_Depre_Contabilizar_Info> Get_List_ValoresDepreciacion_xCtaCble
            (int IdEmpresa, decimal IdDepreciacion, int IdTipoDepreciacion, int IdPeriodo, Cl_Enumeradores.eForma_Contabilizar FormaContabilizar)
        {
            try
            {
                List<vwAf_Valores_Depre_Contabilizar_Info> lstInfo = new List<vwAf_Valores_Depre_Contabilizar_Info>();
                
                using (EntitiesActivoFijo listado = new EntitiesActivoFijo())
                {
                    var selectValores = from q in listado.vwAf_Valores_Depre_Contabilizar
                                 where q.IdEmpresa == IdEmpresa && q.IdDepreciacion == IdDepreciacion
                                 && q.IdTipoDepreciacion == IdTipoDepreciacion && q.IdPeriodo == IdPeriodo
                                 select q;
                    
                   
                    var select = from gro in selectValores
                                        group gro by new
                                        {
                                            gro.IdEmpresa,
                                            gro.IdDepreciacion,
                                            gro.IdTipoDepreciacion,
                                            gro.IdPeriodo,
                                            gro.Cod_Depreciacion,
                                            gro.cod_tipo_depreciacion,
                                            gro.Fecha_Depreciacion,
                                        } into grouping
                                        select new { grouping.Key, Valor_Depre = grouping.Sum(p => p.Valor_Depreciacion) };
                    
                    foreach (var item in select)
                    {
                        vwAf_Valores_Depre_Contabilizar_Info info = new vwAf_Valores_Depre_Contabilizar_Info();
                        info.IdEmpresa = item.Key.IdEmpresa;
                        info.IdDepreciacion = item.Key.IdDepreciacion;
                        info.IdTipoDepreciacion = item.Key.IdTipoDepreciacion;
                        info.Cod_Depreciacion = item.Key.Cod_Depreciacion;
                        info.IdPeriodo = item.Key.IdPeriodo;
                        info.Fecha_Depreciacion = item.Key.Fecha_Depreciacion;
                        info.Valor_Depreciacion = Convert.ToDouble(item.Valor_Depre);
                        //info.IdCtaCbleDepre = item.Key.IdCtaCble_Dep_Acum ;
                        //info.IdCtaCbleGastos = item.Key.IdCtaCble_Gastos_Depre ;
                        info.cod_tipo_depreciacion = item.Key.cod_tipo_depreciacion;
                        info.ObservacionCbteCble = "Contabilizacion " + FormaContabilizar + " de " + item.Key.cod_tipo_depreciacion + " Periodo " + Convert.ToString(item.Key.IdPeriodo); 

                        lstInfo.Add(info);
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

        public List<vwAf_Valores_Depre_Contabilizar_Info> Get_List_ValoresDepreciacion_xActivo(int IdEmpresa, decimal IdDepreciacion, int IdTipoDepreciacion, int IdPeriodo, Cl_Enumeradores.eForma_Contabilizar FormaContabilizar)
        {
            try
            {
                List<vwAf_Valores_Depre_Contabilizar_Info> lstInfo = new List<vwAf_Valores_Depre_Contabilizar_Info>();

                using (EntitiesActivoFijo listado = new EntitiesActivoFijo())
                {
                    var selectValores = from q in listado.vwAf_Valores_Depre_Contabilizar
                                        where q.IdEmpresa == IdEmpresa && q.IdDepreciacion == IdDepreciacion
                                        && q.IdTipoDepreciacion == IdTipoDepreciacion && q.IdPeriodo == IdPeriodo
                                        select q;

                    var select = from gro in selectValores
                                        group gro by new
                                        {
                                            gro.IdEmpresa,
                                            gro.IdDepreciacion,
                                            gro.IdTipoDepreciacion,
                                            gro.IdPeriodo,
                                            gro.Cod_Depreciacion,
                                            gro.cod_tipo_depreciacion,
                                            gro.IdActivoFijo,
                                            gro.Af_Nombre,
                                            gro.Fecha_Depreciacion,
                                            gro.IdActijoFijoTipo
                                        } into grouping
                                        select new { grouping.Key, Valor_Depre = grouping.Sum(p => p.Valor_Depreciacion) };
                    foreach (var item in select)
                    {
                        vwAf_Valores_Depre_Contabilizar_Info info = new vwAf_Valores_Depre_Contabilizar_Info();
                        info.IdEmpresa = item.Key.IdEmpresa;
                        info.IdDepreciacion = item.Key.IdDepreciacion;
                        info.IdTipoDepreciacion = item.Key.IdTipoDepreciacion;
                        info.Cod_Depreciacion = item.Key.Cod_Depreciacion;
                        info.IdPeriodo = item.Key.IdPeriodo;
                        info.Fecha_Depreciacion = item.Key.Fecha_Depreciacion;
                        info.Valor_Depreciacion = Convert.ToDouble(item.Valor_Depre);
                        info.cod_tipo_depreciacion = item.Key.cod_tipo_depreciacion;
                        info.ObservacionCbteCble = "Contabilizacion " + FormaContabilizar + " de " + item.Key.cod_tipo_depreciacion + " Periodo " + Convert.ToString(item.Key.IdPeriodo) + " Activo " + item.Key.Af_Nombre;
                        info.IdActivoFijo = item.Key.IdActivoFijo;
                        info.IdActijoFijoTipo = item.Key.IdActijoFijoTipo;
                        lstInfo.Add(info);
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

        public List<vwAf_Valores_Depre_Contabilizar_Info> Get_List_ValoresDepreciacion_xTipo_CtaCble(
            int IdEmpresa, decimal IdDepreciacion, int IdTipoDepreciacion, int IdPeriodo, Cl_Enumeradores.eForma_Contabilizar FormaContabilizar)
        {
            try
            {
                List<vwAf_Valores_Depre_Contabilizar_Info> lstInfo = new List<vwAf_Valores_Depre_Contabilizar_Info>();

                using (EntitiesActivoFijo listado = new EntitiesActivoFijo())
                {
                    var selectValores = from q in listado.vwAf_Valores_Depre_Contabilizar
                                        where q.IdEmpresa == IdEmpresa 
                                        && q.IdDepreciacion == IdDepreciacion
                                        && q.IdTipoDepreciacion == IdTipoDepreciacion 
                                        && q.IdPeriodo == IdPeriodo
                                        select q;

                   
                    var select = from gro in selectValores
                                        group gro by new
                                        {
                                            gro.IdEmpresa,
                                            gro.IdDepreciacion,
                                            gro.IdTipoDepreciacion,
                                            gro.IdPeriodo,
                                            gro.Cod_Depreciacion,
                                            gro.cod_tipo_depreciacion,
                                            gro.IdActijoFijoTipo,
                                            gro.Af_Descripcion,
                                            gro.Fecha_Depreciacion
                                            //,
                                            //gro.IdCtaCble_Dep_Acum ,
                                            //gro.IdCtaCble_Gastos_Depre,
                                            //gro.IdCtaCble_Activo
                                        } into grouping
                                        select new { grouping.Key, Valor_Depre = grouping.Sum(p => p.Valor_Depreciacion) };

                    foreach (var item in select)
                    {
                        vwAf_Valores_Depre_Contabilizar_Info info = new vwAf_Valores_Depre_Contabilizar_Info();
                        info.IdEmpresa = item.Key.IdEmpresa;
                        info.IdDepreciacion = item.Key.IdDepreciacion;
                        info.cod_tipo_depreciacion = item.Key.cod_tipo_depreciacion;
                        info.IdActijoFijoTipo = item.Key.IdActijoFijoTipo;
                        info.IdTipoDepreciacion = item.Key.IdTipoDepreciacion;
                        info.Cod_Depreciacion = item.Key.Cod_Depreciacion;
                        info.IdPeriodo = item.Key.IdPeriodo;
                        info.Fecha_Depreciacion = item.Key.Fecha_Depreciacion;
                        info.Valor_Depreciacion = Convert.ToDouble(item.Valor_Depre);
                        //info.IdCtaCbleDepre = item.Key.IdCtaCble_Dep_Acum; 
                        //info.IdCtaCbleGastos = item.Key.IdCtaCble_Gastos_Depre;
                        info.ObservacionCbteCble = "Contabilizacion " + FormaContabilizar + " de " + item.Key.cod_tipo_depreciacion + " Periodo " + Convert.ToString(item.Key.IdPeriodo) + " Tipo de Activo " + item.Key.Af_Descripcion; 
                        lstInfo.Add(info);
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

        public List<ct_Periodo_Info> get_Periodos(int IdEmpresa)
        {
            try
            {
                List<ct_Periodo_Info> lstInfo = new List<ct_Periodo_Info>();
                using (EntitiesDBConta listado = new EntitiesDBConta())
                {
                    var select = from q in listado.vwct_periodo
                                 where q.IdEmpresa == IdEmpresa
                                 select q;

                    foreach (var item in select)
                    {
                        ct_Periodo_Info Cbt = new ct_Periodo_Info();
                        Cbt.IdEmpresa = item.IdEmpresa;
                        Cbt.IdPeriodo = item.IdPeriodo;
                        Cbt.nom_periodo = item.IdanioFiscal.ToString() + "-" + item.smes.Trim();
                        Cbt.IdanioFiscal = item.IdanioFiscal;
                        Cbt.pe_mes = item.pe_mes;
                        Cbt.pe_FechaIni = item.pe_FechaIni;
                        Cbt.pe_FechaFin = item.pe_FechaFin;
                        Cbt.pe_cerrado = item.pe_cerrado;
                        Cbt.pe_estado = item.pe_estado;
                        lstInfo.Add(Cbt);
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
