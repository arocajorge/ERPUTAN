using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Data.Contabilidad
{
    public class ct_cbtecble_tipo_x_empresa_Data
    {
        string mensaje = "";

        public List<ct_cbtecble_tipo_x_empresa_Info> Get_list_cbtecble_tipo_x_empresa(int IdEmpresa)
        {
            try
            {
                List<ct_cbtecble_tipo_x_empresa_Info> Lst = new List<ct_cbtecble_tipo_x_empresa_Info>();
                EntitiesDBConta oEnti = new EntitiesDBConta();
                var Query = from q in oEnti.ct_cbtecble_tipo_x_empresa
                            where q.IdEmpresa == IdEmpresa
                            select q;
                foreach (var item in Query)
                {
                    ct_cbtecble_tipo_x_empresa_Info Obj = new ct_cbtecble_tipo_x_empresa_Info();
                    Obj.IdEmpresa = item.IdEmpresa;
                    Obj.IdTipoCbte = item.IdTipoCbte;
                    Obj.UltReg = item.UltReg;
                    Lst.Add(Obj);
                }
                return Lst;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public ct_cbtecble_tipo_x_empresa_Info Get_Info_cbtecble_tipo_x_empresa(int IdEmpresa, int IdTipoCbte)
        {
            ct_cbtecble_tipo_x_empresa_Info Obj = new ct_cbtecble_tipo_x_empresa_Info();

            try
            {
                EntitiesDBConta oEnti = new EntitiesDBConta();
                ct_cbtecble_tipo_x_empresa item = oEnti.ct_cbtecble_tipo_x_empresa.FirstOrDefault(
                            q => q.IdEmpresa == IdEmpresa && q.IdTipoCbte == IdTipoCbte);
                
               
                Obj.IdEmpresa = item.IdEmpresa;
                Obj.IdTipoCbte = item.IdTipoCbte;
                Obj.UltReg = item.UltReg;
                return Obj;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public Boolean Get_Existe_Cbte_x_Empresa(int IdEmpresa, int IdTipoCbte, ref string MensajeError) // verifica si el tipo de comprobante existe en la empresa solicitada
        {
            try
            {
                EntitiesDBConta tabla = new EntitiesDBConta();
                var q = from reg in tabla.ct_cbtecble_tipo_x_empresa
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
        int GetId(int IdEmpresa)
        {
            try
            {
                int Id = 0;


                EntitiesDBConta oEntities = new EntitiesDBConta();
                var select = from q in oEntities.ct_cbtecble_tipo_x_empresa
                             where q.IdEmpresa == IdEmpresa       
                             select q;
                if (select.ToList().Count < 1)
                {
                    Id = 1;
                }
                else
                {
                    var GetiD = (from q in oEntities.ct_cbtecble_tipo_x_empresa
                                 where q.IdEmpresa == IdEmpresa
                                 select q.IdTipoCbte).Max();

                    Id = Convert.ToInt32(GetiD.ToString()) + 1;
                }
                return Id;

            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }

        }

        public Boolean GuardarDB(ct_cbtecble_tipo_x_empresa_Info Info) 
        {
            try
            {
                using (EntitiesDBConta Context = new EntitiesDBConta()) 
                {
                    var Address = new ct_cbtecble_tipo_x_empresa();

                    Address.IdTipoCbte = Info.IdTipoCbte;
                    Address.IdEmpresa = Info.IdEmpresa;
                    Address.UltReg = 0;
                    
                    Context.ct_cbtecble_tipo_x_empresa.Add(Address);
                    Context.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public Boolean EliminarDB(ct_cbtecble_tipo_x_empresa_Info Info) 
        {
            try
            {
                using (EntitiesDBConta Context = new EntitiesDBConta()) 
                {
                    Context.Database.ExecuteSqlCommand("delete from ct_cbtecble_tipo_x_empresa where IdEmpresa = "+Info.IdEmpresa+" and IdTipoCbte = "+Info.IdTipoCbte);
                
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        
        }

    }
}
