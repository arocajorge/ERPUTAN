using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.ActivoFijo;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.ActivoFijo
{
    public class Af_Depreciacion_Det_Data
    {
        tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();        
        string mensaje = "";

        public Boolean GuardarDB(List<Af_Depreciacion_Det_Info> lstInfo, decimal IdDepreciacion, int IdTipoDepreciacion,  ref string msjError)
        {
            try
            {
                using (EntitiesActivoFijo Context = new EntitiesActivoFijo())
                {
                    int secuencia = 0;
                    foreach (var item in lstInfo)
                    {
                        secuencia = secuencia + 1;                        
                        var Address = new Af_Depreciacion_Det();
                        Address.IdEmpresa = item.IdEmpresa;
                        Address.IdDepreciacion = IdDepreciacion;
                        Address.IdTipoDepreciacion = IdTipoDepreciacion;
                        Address.Secuencia = secuencia;
                        Address.IdActivoFijo = item.IdActivoFijo;
                        Address.Ciclo = item.Ciclo;
                        Address.Concepto = item.Concepto;
                        Address.Valor_Compra = item.Valor_Compra;
                        Address.Valor_Salvamento = item.Valor_Salvamento;
                        Address.Vida_Util = item.Vida_Util;
                        Address.Porc_Depreciacion = item.Porc_Depreciacion;
                        Address.Valor_Depreciacion = item.Valor_Depreciacion;
                        Address.Valor_Depre_Acum = item.Valor_Depre_Acum;
                        Address.Valor_Importe = item.Valor_Importe;
                        Address.Es_Activo_x_Mejora = item.Es_Activo_x_Mejora;
                                                
                        Context.Af_Depreciacion_Det.Add(Address);
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
                mensaje = ex.InnerException + " " + ex.Message;
                msjError = mensaje;
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public List<Af_Depreciacion_Det_Info> Get_List_Depreciacion_Det(int IdEmpresa, decimal IdDepreciacion, int IdTipoDepreciacion)
        {
            try
            {
                List<Af_Depreciacion_Det_Info> lstInfo = new List<Af_Depreciacion_Det_Info>();

                using (EntitiesActivoFijo listado = new EntitiesActivoFijo())
                {
                    var select = from q in listado.Af_Depreciacion_Det
                                 where q.IdEmpresa == IdEmpresa
                                 && q.IdDepreciacion == IdDepreciacion && q.IdTipoDepreciacion == IdTipoDepreciacion
                                 select q;

                    foreach (var item in select)
                    {
                        Af_Depreciacion_Det_Info InfoDepre = new Af_Depreciacion_Det_Info();
                        InfoDepre.IdEmpresa = item.IdEmpresa;
                        InfoDepre.IdDepreciacion = item.IdDepreciacion;
                        InfoDepre.IdTipoDepreciacion = item.IdTipoDepreciacion;
                        InfoDepre.Secuencia = item.Secuencia;
                        InfoDepre.IdActivoFijo = item.IdActivoFijo;
                        InfoDepre.Ciclo = item.Ciclo;
                        InfoDepre.Concepto = item.Concepto;
                        InfoDepre.Valor_Compra = item.Valor_Compra;
                        InfoDepre.Valor_Salvamento = item.Valor_Salvamento;
                        InfoDepre.Vida_Util = item.Vida_Util;
                        InfoDepre.Porc_Depreciacion = item.Porc_Depreciacion;
                        InfoDepre.Valor_Depreciacion = item.Valor_Depreciacion;
                        InfoDepre.Valor_Depre_Acum = item.Valor_Depre_Acum;
                        InfoDepre.Valor_Importe = item.Valor_Importe;
                        InfoDepre.Es_Activo_x_Mejora = item.Es_Activo_x_Mejora;

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

        public List<vwAf_ActivoFijo_Info> Get_List_Depreciacion_Detalle(int IdEmpresa, decimal IdDepreciacion, int IdTipoDepreciacion)
        {
            try
            {
                List<vwAf_ActivoFijo_Info> lstInfo = new List<vwAf_ActivoFijo_Info>();

                using (EntitiesActivoFijo listado = new EntitiesActivoFijo())
                {
                    var select = from q in listado.vwAf_Depreciacion_Detalle
                                 where q.IdEmpresa == IdEmpresa
                                 && q.IdDepreciacion == IdDepreciacion && q.IdTipoDepreciacion == IdTipoDepreciacion
                                 select q;

                    foreach (var item in select)
                    {
                        vwAf_ActivoFijo_Info Info = new vwAf_ActivoFijo_Info();
                        Info.IdEmpresa = item.IdEmpresa;
                        Info.IdActivoFijo = item.IdActivoFijo;
                        Info.IdTipoDepreciacion = item.IdTipoDepreciacion;
                        Info.cod_tipo_depreciacion = item.cod_tipo_depreciacion;
                        Info.Af_Nombre = item.Af_Nombre;
                        Info.Af_costo_compra = item.Valor_Compra;
                        Info.Af_ValorSalvamento = Convert.ToDouble(item.Valor_Salvamento);
                        Info.Af_Vida_Util = item.Vida_Util;
                        Info.Ciclo = Convert.ToInt32(item.Ciclo);
                        Info.Af_Vida_TipDepre = Convert.ToInt32(item.Vida_Util);                                                
                        Info.Af_porcentaje_deprec = item.Porc_Depreciacion;
                        Info.Valor_Depre = Convert.ToDouble(item.Valor_Depreciacion);
                        Info.Valor_Depreciacion_Acum = Convert.ToDouble(item.Valor_Depre_Acum);
                        Info.Valor_Importe = Convert.ToDouble(item.Valor_Importe);
                        Info.Concepto_Depre = item.Concepto;
                        Info.Es_Activo_x_Mejora = item.Es_Activo_x_Mejora;
                        Info.CodActivoFijo = item.CodActivoFijo;
                       
                        lstInfo.Add(Info);
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

        public Boolean Guardar_HistoricoDB(List<Af_Depreciacion_Det_Info> lstInfo, int IdHisDepreciacion, decimal IdDepreciacion, int IdTipoDepreciacion, ref string msjError)
        {
            try
            {
                using (EntitiesActivoFijo Context = new EntitiesActivoFijo())
                {
                    int secuencia = 0;
                    foreach (var item in lstInfo)
                    {
                        secuencia = secuencia + 1;                        
                        var Address = new Af_Depreciacion_Det_His_Anulacion();
                        Address.IdEmpresa = item.IdEmpresa;
                        Address.IdHisDepreciacion = IdHisDepreciacion;
                        Address.IdDepreciacion = IdDepreciacion;
                        Address.IdTipoDepreciacion = IdTipoDepreciacion;
                        Address.Secuencia = secuencia;
                        Address.IdActivoFijo = item.IdActivoFijo;
                        Address.Ciclo = item.Ciclo;
                        Address.Concepto = item.Concepto;
                        Address.Valor_Compra = item.Valor_Compra;
                        Address.Valor_Salvamento = item.Valor_Salvamento;
                        Address.Vida_Util = item.Vida_Util;
                        Address.Porc_Depreciacion = item.Porc_Depreciacion;
                        Address.Valor_Depreciacion = item.Valor_Depreciacion;
                        Address.Valor_Depre_Acum = item.Valor_Depre_Acum;
                        Address.Valor_Importe = item.Valor_Importe;
                        Address.Es_Activo_x_Mejora = item.Es_Activo_x_Mejora;

                        Context.Af_Depreciacion_Det_His_Anulacion.Add(Address);
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
                mensaje = ex.InnerException + " " + ex.Message;
                msjError = mensaje;
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public Boolean EliminarDB(List<Af_Depreciacion_Det_Info> lstInfo, ref string msjError)
        {
            try
            {
                using (EntitiesActivoFijo Context = new EntitiesActivoFijo())
                {
                    foreach (var item in lstInfo)
                    {
                        var contact = Context.Af_Depreciacion_Det.FirstOrDefault(q => q.IdEmpresa == item.IdEmpresa && q.IdDepreciacion == item.IdDepreciacion && q.IdTipoDepreciacion == item.IdTipoDepreciacion);
                        if (contact != null)
                        {
                            Context.Af_Depreciacion_Det.Remove(contact);
                            Context.SaveChanges();
                        }
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

        public double Get_DepreAcum_x_Activo(int IdEmpresa, int IdActivoFijo)
        {
            try
            {
                double ValorDepreAcum = 0;
                using (EntitiesActivoFijo listado = new EntitiesActivoFijo())
                {
                    var select = from q in listado.Af_Depreciacion_Det
                                 where q.IdEmpresa == IdEmpresa
                                 && q.IdActivoFijo == IdActivoFijo
                                 select q;

                    if (select.Count() > 0)
                    {
                        ValorDepreAcum = select.Sum(q => q.Valor_Depreciacion);
                    }
                    else
                    {
                        ValorDepreAcum = 0;
                    }                    
                }
                return ValorDepreAcum;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                return 0;
            }
        }
    }
}
