using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Facturacion;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Data.Facturacion
{
    public class fa_Secuencia_Documento_Talonario_Data
    {
        string mensaje = "";

    //    public int GetSecuencia(fa_Secuencia_Documento_Talonario_Info info)
    //    {
    //        try
    //        {
    //            int Secuencia;
    //            EntitiesGeneral context = new EntitiesGeneral();

    //            var q = from C in context.tb_sis_Documento_Tipo_x_Secuencia_Talonario
    //                    where C.IdEmpresa == info.IdEmpresa && C.IdSucursal == info.IdSucursal && C.IdBodega == info.IdBodega && C.CodDocumentoTipo == info.CodDocumentoTipo
    //                    select C;
    //            if (q.ToList().Count == 0)
    //                return 1;
    //            else
    //            {

    //                var select_ = (from C in context.tb_sis_Documento_Tipo_x_Secuencia_Talonario
    //                               where C.IdEmpresa == info.IdEmpresa && C.IdSucursal == info.IdSucursal && C.IdBodega == info.IdBodega && C.CodDocumentoTipo == info.CodDocumentoTipo
    //                               select C.Secuencia).Max();
    //                Secuencia = Convert.ToInt32(select_.ToString()) + 1;
    //                return Secuencia;
    //            }
    //        }
    //        catch (Exception ex)
    //        {
    //            string arreglo = ToString();
    //            tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
    //            tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
    //            oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
    //            mensaje = ex.ToString();
    //            throw new Exception(ex.InnerException.ToString());
    //        }
    //    }

    //    public Boolean GuardarDB(fa_Secuencia_Documento_Talonario_Info info)
    //    {
    //        try
    //        {               
    //            using (EntitiesGeneral context = new EntitiesGeneral())
    //            {
    //                EntitiesGeneral Fac = new EntitiesGeneral();
                   
    //                var addressG = new tb_sis_Documento_Tipo_x_Secuencia_Talonario();
    //                addressG.IdEmpresa = info.IdEmpresa;
    //                addressG.IdSucursal = info.IdSucursal;
    //                addressG.IdBodega = info.IdBodega;

    //                addressG.CodDocumentoTipo = info.CodDocumentoTipo;
    //                info.Secuencia = addressG.Secuencia = GetSecuencia(info);

                    
    //                addressG.DocActual = info.DocActual;
    //                addressG.DocInicial = info.DocInicial;
    //                addressG.DocFinal = info.DocFinal;
    //                addressG.Estado = info.Estado;
    //                addressG.FechaCaducidad = Convert.ToDateTime(info.FechaCaducidad.ToShortDateString());
    //                addressG.NAutorizacion = info.NAutorizacion;
    //                addressG.Serie1 = info.Serie1;
    //                addressG.Serie2 = info.Serie2;


    //                context.tb_sis_Documento_Tipo_x_Secuencia_Talonario.Add(addressG);
    //                context.SaveChanges();
    //            }

    //            return true;
    //        }
    //        catch (Exception ex)
    //        {
    //            string arreglo = ToString();
    //            tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
    //            tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
    //            mensaje = ex.ToString();
    //            oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
    //            throw new Exception(ex.ToString());
    //        }
    //    }

    //    public List<tb_sis_Documento_Tipo_x_Empresa_Info> Get_List_Documento_Tipo_ApareceTalonario()
    //    {
    //        try
    //        {
    //            List<tb_sis_Documento_Tipo_x_Empresa_Info> lm = new List<tb_sis_Documento_Tipo_x_Empresa_Info>();
    //            EntitiesGeneral OEGeneral = new EntitiesGeneral();
    //            var q = from A in OEGeneral.tb_sis_Documento_Tipo_x_Empresa
    //                    where A.ApareceTalonario == "S"
    //                    select A;
    //            foreach (var item in q)
    //            {
    //                tb_sis_Documento_Tipo_x_Empresa_Info info = new tb_sis_Documento_Tipo_x_Empresa_Info();
    //                info.codDocumentoTipo = item.codDocumentoTipo.Trim();
    //                info.Descripcion = item.Descripcion.Trim();
    //                info.ApareceComboFac_Import = item.ApareceComboFac_Import;
    //                info.Posicion = item.Posicion;
    //                info.ApareceComboFac_TipoFact = item.ApareceComboFac_TipoFact;
    //                lm.Add(info);
    //            }
    //            return lm;
    //        }
    //        catch (Exception ex)
    //        {
    //            string arreglo = ToString();
    //            tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
    //            tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
    //            mensaje = ex.ToString();
    //            oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
    //            throw new Exception(ex.ToString());
    //        }
    //    }

    //    public List<fa_Documento_Tipo_info> Get_List_Documento_Tipo_ApareceComboFac_TipoFact()
    //    {
    //        try
    //        {
    //            List<fa_Documento_Tipo_info> lm = new List<fa_Documento_Tipo_info>();
    //            EntitiesGeneral OEGeneral = new EntitiesGeneral();
    //            var q = from A in OEGeneral.tb_sis_Documento_Tipo_x_Empresa
    //                    where A.ApareceComboFac_TipoFact == "S"
    //                    orderby A.Posicion
    //                    select A;
    //            foreach (var item in q)
    //            {
    //                fa_Documento_Tipo_info info = new fa_Documento_Tipo_info();
    //                info.codDocumentoTipo = item.codDocumentoTipo.Trim();
    //                info.descripcion = item.Descripcion.Trim();
    //                info.ApareceComboFac_Import = item.ApareceComboFac_Import;
    //                info.Posicion = item.Posicion;
    //                info.ApareceComboFac_TipoFact = item.ApareceComboFac_TipoFact;
    //                lm.Add(info);
    //            }
    //            return lm;
    //        }
    //        catch (Exception ex)
    //        {
    //            string arreglo = ToString();
    //            tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
    //            tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
    //            mensaje = ex.ToString();
    //            oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
    //            throw new Exception(ex.ToString());
    //        }
    //    }

    //    public List<fa_Documento_Tipo_info> Get_List_Documento_Tipo_ApareceComboFac_Import(int IdEmpresa)
    //    {
    //        try
    //        {
    //            List<fa_Documento_Tipo_info> lm = new List<fa_Documento_Tipo_info>();
    //            EntitiesGeneral OEGeneral = new EntitiesGeneral();
    //            var q = from A in OEGeneral.tb_sis_Documento_Tipo_x_Empresa
    //                    where A.ApareceComboFac_Import == "S" && A.IdEmpresa == IdEmpresa 
    //                    orderby A.Posicion
    //                    select A;
    //            foreach (var item in q)
    //            {
    //                fa_Documento_Tipo_info info = new fa_Documento_Tipo_info();
    //                info.codDocumentoTipo = item.codDocumentoTipo.Trim();
    //                info.descripcion = item.Descripcion.Trim();
    //                info.ApareceComboFac_Import = item.ApareceComboFac_Import;
    //                info.Posicion = item.Posicion;
    //                info.ApareceComboFac_TipoFact = item.ApareceComboFac_TipoFact;
    //                lm.Add(info);
    //            }
    //            return lm;
    //        }
    //        catch (Exception ex)
    //        {
    //            string arreglo = ToString();
    //            tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
    //            tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
    //            mensaje = ex.ToString();
    //            oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
    //            throw new Exception(ex.ToString());
    //        }
    //    }

    //    public List<fa_Secuencia_Documento_Talonario_Info> Get_List_fa_Secuencia_Documento_Talonario(int IdEmpresa)
    //    {
    //        try
    //        {
    //            List<fa_Secuencia_Documento_Talonario_Info> lm = new List<fa_Secuencia_Documento_Talonario_Info>();
    //            EntitiesFacturacion  OEGeneral = new EntitiesFacturacion();
    //            var q = from A in OEGeneral.vwfa_Documento_Tipo_x_Secuencia_Talonario
    //                    where A.IdEmpresa==IdEmpresa
    //                    select A;
    //            foreach(var item in q)
    //            {
    //                fa_Secuencia_Documento_Talonario_Info info = new fa_Secuencia_Documento_Talonario_Info();
    //                info.IdEmpresa = item.IdEmpresa;
    //                info.IdSucursal = item.IdSucursal;
    //                info.IdBodega = item.IdBodega;
    //                info.CodDocumentoTipo = item.CodDocumentoTipo;
    //                info.Serie1 = item.Serie1;
    //                info.Serie2 = item.Serie2;
    //                info.Secuencia = item.Secuencia;
    //                info.FechaCaducidad = item.FechaCaducidad;
    //                info.NAutorizacion = item.NAutorizacion;
    //                info.DocInicial = item.DocInicial;
    //                info.DocFinal = item.DocFinal;
    //                info.DocActual = item.DocActual;
    //                info.Estado = item.Estado;

    //                info.Sucursal = item.Su_Descripcion;
    //                info.Bodega = item.bo_Descripcion;
    //                lm.Add(info);
    //            }
    //            return lm;
    //        }
    //        catch (Exception ex)
    //        {
    //            string arreglo = ToString();
    //            tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
    //            tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
    //            mensaje = ex.ToString();
    //            oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
    //            throw new Exception(ex.ToString());
    //        }
    //    }

    //    public Boolean ModificarDB(fa_Secuencia_Documento_Talonario_Info info)
    //    {
    //        try
    //        {
                
    //            using (EntitiesGeneral context = new EntitiesGeneral())
    //            {
    //                var contact = context.tb_sis_Documento_Tipo_x_Secuencia_Talonario.FirstOrDefault(cot => cot.IdEmpresa == info.IdEmpresa && cot.CodDocumentoTipo == info.CodDocumentoTipo && cot.IdSucursal == info.IdSucursal && cot.IdBodega == info.IdBodega && cot.Secuencia == info.Secuencia);
    //                if (contact != null)
    //                {
    //                    contact.Serie1 = info.Serie1;
    //                    contact.Serie2 = info.Serie2;
    //                    contact.DocInicial = info.DocInicial;
    //                    contact.DocFinal = info.DocFinal;
    //                    contact.DocActual = info.DocActual;
    //                    contact.FechaCaducidad = info.FechaCaducidad;
    //                    contact.NAutorizacion = info.NAutorizacion;
    //                    contact.Estado = info.Estado;
    //                    context.SaveChanges();
    //                }
    //            }
    //            return true;
    //        }
    //        catch (Exception ex)
    //        {
    //            string arreglo = ToString();
    //            tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
    //            tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
    //            mensaje = ex.ToString();
    //            oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
    //            throw new Exception(ex.ToString());
    //        }
    //    }

    //    public Boolean AnularDB(fa_Secuencia_Documento_Talonario_Info info)
    //    {
    //        try
    //        {
    //            using (EntitiesGeneral context = new EntitiesGeneral())
    //            {
    //                var contact = context.tb_sis_Documento_Tipo_x_Secuencia_Talonario.FirstOrDefault(cot => cot.IdEmpresa == info.IdEmpresa && cot.CodDocumentoTipo == info.CodDocumentoTipo && cot.IdSucursal == info.IdSucursal && cot.IdBodega == info.IdBodega && cot.Estado == "A");
    //                if (contact != null)
    //                {
    //                    contact.Estado = "I";
    //                    context.SaveChanges();
    //                }
    //            }
    //            return true;
    //        }
    //        catch (Exception ex)
    //        {
    //            string arreglo = ToString();
    //            tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
    //            tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
    //            mensaje = ex.ToString();
    //            oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
    //            throw new Exception(ex.ToString());
    //        }
    
    //}

    //    public Boolean VerificarNumeroTalonarioIsUsed(string Qry) 
    //    {
    //        try
    //        {
    //            using (EntitiesFacturacion entity = new EntitiesFacturacion())
    //            {
    //                List<int> Consulta = entity.Database.SqlQuery<int>(Qry).ToList();
    //                if (Consulta.First() != 0)
    //                {
    //                    return true;
    //                }
    //                else
    //                {
    //                    return false;
    //                }
    //            }
    //        }
    //        catch (Exception ex)
    //        {
    //            string arreglo = ToString();
    //            tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
    //            tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
    //            mensaje = ex.ToString();
    //            oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
    //            throw new Exception(ex.ToString());
    //        }
    //    }

    //    public Boolean GuardarNumDoc(int IdEmpresa,int idSucursal,int idBodega,string serie1,string serie2,string numDocTrans,string TipoDoc, string NAutorizacion) {
    //        try
    //        {
    //            using (EntitiesGeneral context = new EntitiesGeneral())
    //            {
    //                EntitiesGeneral OEGeneral = new EntitiesGeneral();
                  
    //                    var contact = context.tb_sis_Documento_Tipo_x_Secuencia_Talonario.FirstOrDefault(cot => cot.IdEmpresa == IdEmpresa && cot.IdSucursal == idSucursal && cot.IdBodega == idBodega && cot.CodDocumentoTipo == TipoDoc && cot.Estado == "A" && cot.NAutorizacion == NAutorizacion);

    //                    if (contact != null)
    //                    {
    //                        contact.DocActual = numDocTrans;
    //                        context.SaveChanges();
    //                    }
                 
    //            }

    //            return true;
    //        }
    //        catch (Exception ex)
    //        {
    //            string arreglo = ToString();
    //            tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
    //            tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
    //            mensaje = ex.ToString();
    //            oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
    //            throw new Exception(ex.ToString());
    //        }
    //    }

    //    public List<fa_Documento_Tipo_info> Get_List_Documento_Tipo_x_Empresa(int IdEmpresa)
    //    {
    //        try
    //        {
    //            List<fa_Documento_Tipo_info> lm = new List<fa_Documento_Tipo_info>();
    //            EntitiesGeneral OEGeneral = new EntitiesGeneral();
    //            var q = from A in OEGeneral.tb_sis_Documento_Tipo_x_Empresa
    //                    where A.ApareceTalonario == "S" && A.IdEmpresa==IdEmpresa
    //                    select A;
    //            foreach (var item in q)
    //            {
    //                fa_Documento_Tipo_info info = new fa_Documento_Tipo_info();
    //                info.codDocumentoTipo = item.codDocumentoTipo.Trim();
    //                info.descripcion = item.Descripcion.Trim();
    //                info.ApareceComboFac_Import = item.ApareceComboFac_Import;
    //                info.Posicion = item.Posicion;
    //                info.ApareceComboFac_TipoFact = item.ApareceComboFac_TipoFact;
    //                lm.Add(info);
    //            }
    //            return lm;
    //        }
    //        catch (Exception ex)
    //        {
    //            string arreglo = ToString();
    //            tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
    //            tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
    //            mensaje = ex.ToString();
    //            oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
    //            throw new Exception(ex.ToString());
    //        }
    //    }

    //    public Boolean VerificarNumAutorizacionExiste(int IdEmpresa, string CodDocumentoTipo, string nAutorizacion) 
    //    {
    //        try
    //        {
    //            using (EntitiesGeneral Entity = new EntitiesGeneral())
    //            {
    //                var q = from A in Entity.tb_sis_Documento_Tipo_x_Secuencia_Talonario
    //                        where  A.IdEmpresa == IdEmpresa 
    //                        && A.CodDocumentoTipo == CodDocumentoTipo 
    //                        && A.NAutorizacion == nAutorizacion
    //                        select A;

    //                if (q.Count() != 0)
    //                    return true;
    //                else
    //                    return false;
    //            }
    //        }
    //        catch (Exception ex)
    //        {
    //            string arreglo = ToString();
    //            tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
    //            tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
    //            mensaje = ex.ToString();
    //            oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
    //            throw new Exception(ex.ToString());
    //        }
    //    }

    }
}
