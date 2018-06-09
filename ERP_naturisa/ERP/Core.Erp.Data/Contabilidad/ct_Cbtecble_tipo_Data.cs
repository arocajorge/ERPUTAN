using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Core.Erp.Info.Contabilidad;

using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Data.Contabilidad
{
    public class ct_Cbtecble_tipo_Data
    {
        public List<ct_Cbtecble_tipo_Info> Get_list_Cbtecble_tipo(int IdEmpresa , ref string MensajeError)
        {
            try
            {
                List<ct_Cbtecble_tipo_Info> lM = new List<ct_Cbtecble_tipo_Info>();
                EntitiesDBConta OECbtecble_tipo_Info = new EntitiesDBConta();
                var selectCbtecble_tipo = from C in OECbtecble_tipo_Info.ct_cbtecble_tipo
                                          where C.IdEmpresa == IdEmpresa
                                          select C;

                foreach (var item in selectCbtecble_tipo)
                {
                    ct_Cbtecble_tipo_Info Cbt = new ct_Cbtecble_tipo_Info();
                    Cbt.IdTipoCbte = Convert.ToInt32(item.IdTipoCbte);
                    Cbt.CodTipoCbte = item.CodTipoCbte.Trim();
                    Cbt.tc_TipoCbte = item.tc_TipoCbte.Trim();
                    Cbt.tc_TipoCbte2 = "[" + item.IdTipoCbte + "]" + item.tc_TipoCbte.Trim();
                    Cbt.tc_Estado = item.tc_Estado;
                    Cbt.tc_Interno = item.tc_Interno;
                    Cbt.tc_Nemonico = item.tc_Nemonico;
                    Cbt.IdTipoCbte_Anul = item.IdTipoCbte_Anul;
                    Cbt.SEstado = (item.tc_Estado == "A") ? "ACTIVO" : "*ANULADO*";
                    Cbt.IdEmpresa = item.IdEmpresa;

                    lM.Add(Cbt);
                }

                return (lM);
            }

            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public List<ct_Cbtecble_tipo_Info> Get_list_Cbtecble_tipo(int IdEmpresa, Cl_Enumeradores.eTipoFiltro TipoFiltro, ref string MensajeError)
        {
            try
            {
                List<ct_Cbtecble_tipo_Info> lM = new List<ct_Cbtecble_tipo_Info>();
                EntitiesDBConta OECbtecble_tipo_Info = new EntitiesDBConta();
                var selectCbtecble_tipo = from C in OECbtecble_tipo_Info.ct_cbtecble_tipo
                                          where C.IdEmpresa == IdEmpresa
                                          select C;


                if (TipoFiltro == Cl_Enumeradores.eTipoFiltro.todos)
                {
                    ct_Cbtecble_tipo_Info Cbt1 = new ct_Cbtecble_tipo_Info();
                    Cbt1.IdEmpresa = IdEmpresa;
                    Cbt1.IdTipoCbte = 0;
                    Cbt1.CodTipoCbte = "ALL";
                    Cbt1.tc_TipoCbte = "TODOS LOS COMPROBANTES";
                    Cbt1.tc_Estado = "A";
                    Cbt1.tc_Interno = "S";
                    Cbt1.tc_Nemonico = "ALL";
                    
                    lM.Add(Cbt1);
                }

                foreach (var item in selectCbtecble_tipo)
                {
                    ct_Cbtecble_tipo_Info Cbt = new ct_Cbtecble_tipo_Info();
                    Cbt.IdEmpresa = item.IdEmpresa;
                    Cbt.IdTipoCbte = Convert.ToInt32(item.IdTipoCbte);
                    Cbt.CodTipoCbte = item.CodTipoCbte.Trim();
                    Cbt.tc_TipoCbte = item.tc_TipoCbte.Trim();
                    Cbt.tc_TipoCbte2 = "["+item.CodTipoCbte+"]" + item.tc_TipoCbte.Trim();
                    Cbt.tc_Estado = item.tc_Estado;
                    Cbt.tc_Interno = item.tc_Interno;
                    Cbt.tc_Nemonico = item.tc_Nemonico;
                    Cbt.IdTipoCbte_Anul = item.IdTipoCbte_Anul;
                    Cbt.SEstado = (item.tc_Estado == "A") ? "ACTIVO" : "*ANULADO*";
                    

                    lM.Add(Cbt);
                }

                return (lM);
            }

            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public Boolean ModificarDB(ct_Cbtecble_tipo_Info info, ref string MensajeError)
        {
            try
            {
                using (EntitiesDBConta context = new EntitiesDBConta())
                {
                    var contact = context.ct_cbtecble_tipo.FirstOrDefault(minfo => minfo.IdTipoCbte == info.IdTipoCbte && minfo.IdEmpresa == info.IdEmpresa);

                    if (contact != null)
                    {

                        contact.CodTipoCbte = (info.CodTipoCbte == null || info.CodTipoCbte == "") ? info.CodTipoCbte.ToString() : info.CodTipoCbte;
                        contact.CodTipoCbte = info.CodTipoCbte;
                        contact.tc_TipoCbte = info.tc_TipoCbte;
                        contact.tc_Estado = info.tc_Estado;
                        contact.tc_Interno = info.tc_Interno;
                        contact.tc_Nemonico = info.tc_Nemonico;
                        contact.IdTipoCbte_Anul = info.IdTipoCbte_Anul;
                        context.SaveChanges();
                    }

                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString();
                throw new Exception(ex.ToString());
            }

        }

        public int Get_Id(int IdEmpresa, ref  string MensajeError)
        {
            int codigo = -1;
            try
            {
                EntitiesDBConta tabla = new EntitiesDBConta();
                var q = (from reg in tabla.ct_cbtecble_tipo
                         where reg.IdEmpresa == IdEmpresa
                         select reg.IdTipoCbte).Max();
                codigo = Convert.ToInt32(q.ToString()) + 1;
                return codigo;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public Boolean Get_EsCbte_Interno(int IdEmpresa, int IdTipoCbte, ref string MensajeError) // verifica si el tipo de comprobante es interno o no
        {
            try
            {
                EntitiesDBConta tabla = new EntitiesDBConta();
                var q = from reg in tabla.ct_cbtecble_tipo
                        where reg.IdTipoCbte == IdTipoCbte && reg.tc_Interno == "S"
                        && reg.IdEmpresa == IdEmpresa
                        select reg;
                if (q.ToList().Count > 0)
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
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public Boolean Get_Existe_Cbte_x_Empresa(int IdEmpresa, int IdTipoCbte, ref string MensajeError) // verifica si el tipo de comprobante existe en la empresa solicitada
        {
            try
            {
                EntitiesDBConta tabla = new EntitiesDBConta();
                var q = from reg in tabla.ct_cbtecble_tipo
                        where reg.IdTipoCbte == IdTipoCbte
                        && reg.IdEmpresa == IdEmpresa
                        select reg;
                if (q.ToList().Count > 0)
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
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public string Get_Codigo_x_CbtCble_tipo(int IdEmpresa, int IdTipoCbte, ref string MensajeError)
        {

            try
            {
                string codigoCBTECBLE = "";

                EntitiesDBConta tabla = new EntitiesDBConta();
                var q = from reg in tabla.ct_cbtecble_tipo
                        where reg.IdTipoCbte == IdTipoCbte
                        && reg.IdEmpresa == IdEmpresa
                        select reg;
                if (q.ToList().Count > 0)
                {
                    foreach (var item in q)
                    {
                        codigoCBTECBLE = item.CodTipoCbte;
                    }
                }
                return codigoCBTECBLE;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public Boolean GrabarDB(ct_Cbtecble_tipo_Info info, ref string MensajeError)
        {
            try
            {
                using (EntitiesDBConta context = new EntitiesDBConta())
                {
                    EntitiesDBConta EDB = new EntitiesDBConta();
                    var Q = from per in EDB.ct_cbtecble_tipo
                            where per.IdTipoCbte == info.IdTipoCbte
                            select per;
                    if (Q.ToList().Count == 0)
                    {
                       
                        ct_cbtecble_tipo address = new ct_cbtecble_tipo();
                        address.IdEmpresa = info.IdEmpresa;
                        address.IdTipoCbte = info.IdTipoCbte= Get_Id(info.IdEmpresa,ref MensajeError);
                        address.CodTipoCbte = (info.CodTipoCbte == "") ? Convert.ToString( info.IdTipoCbte) : info.CodTipoCbte;
                        address.tc_TipoCbte = info.tc_TipoCbte;
                        address.tc_Estado = info.tc_Estado;
                        address.tc_Interno = info.tc_Interno;
                        address.tc_Nemonico = info.tc_Nemonico;
                        address.IdTipoCbte_Anul = info.IdTipoCbte_Anul;

                        context.ct_cbtecble_tipo.Add(address);
                        context.SaveChanges();
                    }
                    else
                        return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public Boolean EliminarDB(ct_Cbtecble_tipo_Info info, ref string MensajeError)
        {
            try
            {
                using (EntitiesDBConta context = new EntitiesDBConta())
                {
                    var contact = context.ct_cbtecble_tipo.FirstOrDefault(minfo => minfo.IdTipoCbte == info.IdTipoCbte && minfo.IdEmpresa == info.IdEmpresa);

                    if (contact != null)
                    {
                        contact.tc_Estado = "I";
                        contact.IdUsuarioUltAnu = info.IdUsuarioUltAnu;
                        contact.Fecha_UltAnu = DateTime.Now;
                        contact.MotiAnula = info.MotiAnula;
                        context.SaveChanges();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }        

        public ct_Cbtecble_tipo_Data()
        {
           
        }
    }
}
