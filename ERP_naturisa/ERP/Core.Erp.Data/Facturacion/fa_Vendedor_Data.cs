using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Facturacion;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Data.Facturacion
{
    public class fa_Vendedor_Data
    {
        string mensaje = "";

        public List<fa_Vendedor_Info> Get_List_Vendedores(int idempresa)
        {
            try
            {
                List<fa_Vendedor_Info> lM = new List<fa_Vendedor_Info>();
                EntitiesFacturacion OEPVendedor = new EntitiesFacturacion();

                var select_pv = from A in OEPVendedor.fa_Vendedor
                                where A.IdEmpresa==idempresa
                                select A;

                foreach (var item in select_pv)
                {
                    fa_Vendedor_Info info = new fa_Vendedor_Info();
                    info.IdEmpresa = item.IdEmpresa;
                    info.IdVendedor = item.IdVendedor;
                    info.Ve_Vendedor = item.Ve_Vendedor.Trim();
                    info.Estado = item.Estado;
                    info.Ve_Comision = item.Ve_Comision;
                    info.ve_cedula = item.ve_cedula;
                    info.SEstado = (item.Estado == "A") ? "ACTIVO" : "*ANULADO*";
                    lM.Add(info);
                }
                return (lM);
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        }

        public Boolean ModificarDB(fa_Vendedor_Info info, ref string msg)
        {
            try
            {
                using (EntitiesFacturacion context = new EntitiesFacturacion())
                {
                    var contact = context.fa_Vendedor.FirstOrDefault(obj => obj.IdEmpresa==info.IdEmpresa && obj.IdVendedor==info.IdVendedor);
                    if (contact != null)
                    {
                        contact.Ve_Vendedor = info.Ve_Vendedor;
                        contact.IdUsuarioUltMod = info.IdUsuarioUltMod;
                        contact.Fecha_UltMod = info.Fecha_UltMod;
                        contact.Estado = info.Estado;
                        contact.Ve_Comision = info.Ve_Comision;
                        context.SaveChanges();
                        msg = "Se ha procedido actualizar el registro del Vendedor #: " + info.IdVendedor.ToString() + " exitosamente";
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                msg = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref msg);
                throw new Exception(ex.ToString());
            }
        }

        public int GetId(int IdEmpresa)
        {
            try
            {
                int Id;
                EntitiesFacturacion OEPVendedor = new EntitiesFacturacion();
                var select = from q in OEPVendedor.fa_Vendedor
                             where q.IdEmpresa == IdEmpresa
                             select q;

                if (select.ToList().Count < 1)
                {
                    Id = 1;
                }
                else
                {
                    var select_pv = (from q in OEPVendedor.fa_Vendedor
                                     where q.IdEmpresa == IdEmpresa
                                     select q.IdVendedor).Max();
                    Id = Convert.ToInt32(select_pv.ToString()) + 1;
                }
                return Id;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
            
        }

        public Boolean GrabarDB(fa_Vendedor_Info info, ref int id, ref string msg)
        {
            try
            {
                using (EntitiesFacturacion context = new EntitiesFacturacion())
                {
                    var address = new fa_Vendedor();

                    info.IdVendedor = address.IdVendedor = id = GetId(info.IdEmpresa);
                    address.IdEmpresa = info.IdEmpresa;
                    address.Ve_Vendedor = info.Ve_Vendedor;
                    address.Ve_Comision = info.Ve_Comision;
                    address.IdUsuario = info.IdUsuario;
                    address.Fecha_Transac = info.Fecha_Transac;
                    address.nom_pc = info.nom_pc;
                    address.ip = info.ip;
                    address.Estado = "A";
                    address.ve_cedula = info.ve_cedula;
                    context.fa_Vendedor.Add(address);
                    context.SaveChanges();
                    msg = "Se ha procedido a grabar el registro del Vendedor #: " + id.ToString() + " exitosamente.";
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                msg = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref msg);
                throw new Exception(ex.ToString());
            }
        }

        public Boolean AnularDB(fa_Vendedor_Info info, ref  string msg)
        {
            try
            {
                EntitiesFacturacion OEPVendedor = new EntitiesFacturacion();
                var select = from q in OEPVendedor.fa_Vendedor
                             where q.IdEmpresa==info.IdEmpresa && q.IdVendedor==info.IdVendedor
                             select q;

                if (select.ToList().Count > 0)
                {
                    using (EntitiesFacturacion context = new EntitiesFacturacion())
                    {
                        var contact = context.fa_Vendedor.FirstOrDefault(obj => obj.IdEmpresa == info.IdEmpresa && obj.IdVendedor == info.IdVendedor);
                        if (contact != null)
                        {
                            contact.IdUsuarioUltAnu = info.IdUsuarioUltAnu;
                            contact.Fecha_UltAnu = info.Fecha_UltAnu;
                            contact.Estado = "I";
                            contact.MotivoAnula = info.MotiAnula;
                            context.SaveChanges();
                            msg = "Se ha procedido anular el registro del Vendedor #: " + info.IdVendedor.ToString() + " exitosamente";
                        }
                    }
                    return true;
                }
                else
                {
                    msg = "No es posible anular el registro del Vendedor #: " + info.Ve_Vendedor  + " debido a que ya se encuentra anulado.";
                    return false;
                }
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                msg = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref msg);
                throw new Exception(ex.ToString());
            }
        }

        public Boolean VerificaSiExisteVendedor(fa_Vendedor_Info info, ref string msg)
        {
            Boolean resultado = false;
            try
            {
                EntitiesFacturacion oEnt = new EntitiesFacturacion();
                var listado = from C in oEnt.fa_Vendedor
                              where info.ve_cedula == C.ve_cedula && info.IdEmpresa == C.IdEmpresa
                              select C;
                if (listado.ToList().Count > 0)
                    resultado = true;

                return resultado;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                msg = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref msg);
                throw new Exception(ex.ToString());
            }
        }

        public fa_Vendedor_Info ConsultarVendedorPorCedula(int Idempresa, String Cedula) 
        {
            try
            {
                using (EntitiesFacturacion Entities = new EntitiesFacturacion())
                {

                    fa_Vendedor_Info  fa_Vendedor = new fa_Vendedor_Info();
                    fa_Vendedor_Info info = new fa_Vendedor_Info();
                    EntitiesFacturacion OEPVendedor = new EntitiesFacturacion();

                    var select_pv = from A in OEPVendedor.fa_Vendedor
                                    where A.IdEmpresa == Idempresa && A.ve_cedula == Cedula
                                    select A;

                    foreach (var item in select_pv)
                    {
                        
                        info.IdEmpresa = item.IdEmpresa;                       
                        info.IdVendedor = item.IdVendedor ;
                        info.Ve_Vendedor = item.Ve_Vendedor;
                        info.ve_cedula = item.ve_cedula;
                        info.Ve_Comision = item.Ve_Comision;
                        info.IdUsuario = item.IdUsuario;                        
                        info.nom_pc = item.nom_pc;
                        info.ip = item.ip;
                        info.Estado = item.Estado;	
                    }
                    return info;
                }

            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        }


        public fa_Vendedor_Data() { }
    }
}
