using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Facturacion;

using Core.Erp.Data.General;
using Core.Erp.Info.General;


namespace Core.Erp.Data.Facturacion
{
    public class fa_TipoNota_Data
    {
        string mensaje = "";

        public List<fa_TipoNota_Info> Get_List_TipoNota(int IdEmpresa)
        {
            try
            {
                List<fa_TipoNota_Info> lM = new List<fa_TipoNota_Info>();
                EntitiesFacturacion OEPTipoNota = new EntitiesFacturacion();

                var select_tipo_nota = from A in OEPTipoNota.fa_TipoNota
                                       select A;

                foreach (var item in select_tipo_nota)
                {
                    fa_TipoNota_Info info = new fa_TipoNota_Info();
                    info.IdTipoNota = item.IdTipoNota;
                    info.CodTipoNota = item.CodTipoNota.Trim();
                    info.Tipo = item.Tipo;
                    info.no_Descripcion = item.No_Descripcion.Trim();
                    info.Nemonico = item.Nemonico;
                    info.InternoSis = item.InternoSis;
                    info.SeDeclaraSRI = item.SeDeclaraSRI;
                    info.Estado = item.Estado;
                    lM.Add(info);
                }
                return (lM);
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",  "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public List<fa_TipoNota_Info> Get_List_TipoNota(int IdEmpresa,string sTipoNota)
        {
            try
            {
                List<fa_TipoNota_Info> lM = new List<fa_TipoNota_Info>();
                EntitiesFacturacion OEPTipoNota = new EntitiesFacturacion();

                var select_tipo_nota = from A in OEPTipoNota.fa_TipoNota
                                       where A.Tipo == sTipoNota
                                       select A;

                foreach (var item in select_tipo_nota)
                {
                    fa_TipoNota_Info info = new fa_TipoNota_Info();
                    info.IdTipoNota = item.IdTipoNota;
                    info.CodTipoNota = item.CodTipoNota.Trim();
                    info.Tipo = item.Tipo;
                    info.no_Descripcion = item.No_Descripcion.Trim();
                    info.Nemonico = item.Nemonico;
                    info.InternoSis = item.InternoSis;
                    info.SeDeclaraSRI = item.SeDeclaraSRI;
                    info.Estado = item.Estado;
                    lM.Add(info);
                }
                return (lM);
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }
        
        public List<fa_TipoNota_Info> Get_List_TipoNota_Todos()
        {
            try
            {
                List<fa_TipoNota_Info> lM = new List<fa_TipoNota_Info>();
                EntitiesFacturacion OEPTipoNota = new EntitiesFacturacion();
                fa_TipoNota_Info info = new fa_TipoNota_Info();

                var select_tipo_nota = from A in OEPTipoNota.fa_TipoNota
                                       select A;

                info.IdTipoNota = 0;
                info.no_Descripcion = "TODOS";                
                lM.Add(info);

                foreach (var item in select_tipo_nota)
                {
                    info = new fa_TipoNota_Info();
                    
                    info.IdTipoNota = item.IdTipoNota;
                    info.CodTipoNota = item.CodTipoNota.Trim();
                    info.Tipo = item.Tipo;
                    info.no_Descripcion = item.No_Descripcion.Trim();                    
                    info.Nemonico = item.Nemonico;
                    info.InternoSis = item.InternoSis;
                    info.SeDeclaraSRI = item.SeDeclaraSRI;
                    info.Estado = item.Estado;
                    lM.Add(info);
                }
                return (lM);
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }
 
        public fa_TipoNota_Info Get_List_TipoNota(int idempresa, int idSucursal, int idtipoNota)
        {
            try
            {
                fa_TipoNota_Info info = new fa_TipoNota_Info();

                EntitiesFacturacion OEPTipoNota = new EntitiesFacturacion();

                string Query = " select A.IdTipoNota,A.CodTipoNota,A.Tipo,A.Nemonico,A.No_Descripcion,A.InternoSis,A.SeDeclaraSRI,A.Estado, " +
                               " A.IdUsuario,A.Fecha_Transac,A.nom_pc,A.ip,B.IdCtaCble from fa_TipoNota A, fa_TipoNota_x_Empresa_x_Sucursal B " +
                               "where A.IdTipoNota=B.IdTipoNota " +
                               "and B.IdEmpresa=" + idempresa + " and B.IdSucursal=" + idSucursal + " and B.IdTipoNota= " + idtipoNota;

                var consulta = OEPTipoNota.Database.SqlQuery<fa_TipoNota_Info>(Query).ToList();

                foreach (var item in consulta)
                {                  
                    info.IdTipoNota = item.IdTipoNota;
                    info.CodTipoNota = item.CodTipoNota.Trim();
                    info.Tipo = item.Tipo;
                    info.no_Descripcion = item.no_Descripcion.Trim();
                    info.IdCtaCble = item.IdCtaCble;
                    info.Nemonico = item.Nemonico;               
                    info.InternoSis = item.InternoSis;
                    info.SeDeclaraSRI = item.SeDeclaraSRI ;
                    info.Estado = item.Estado;
                    
                }
                return (info);
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }


        public Boolean ModificarDB(fa_TipoNota_Info info, ref string msg)
        {
            try
            {
                using (EntitiesFacturacion context = new EntitiesFacturacion())
                {
                    var contact = context.fa_TipoNota.FirstOrDefault(obj => obj.IdTipoNota== info.IdTipoNota);
                    if (contact != null)
                    {
                        contact.IdTipoNota = info.IdTipoNota;
                        contact.CodTipoNota = info.CodTipoNota;
                        contact.Tipo = info.Tipo;
                        contact.No_Descripcion = info.no_Descripcion;
                        contact.Nemonico = info.Nemonico;
                        contact.InternoSis = info.InternoSis;
                        contact.SeDeclaraSRI = info.SeDeclaraSRI;
                        contact.Estado = info.Estado;
                        contact.IdUsuarioUltMod = info.IdUsuarioUltMod;
                        contact.Fecha_UltMod = info.Fecha_UltMod;
                        context.SaveChanges();
                        msg = "Se ha procedido actualizar el registro del Tipo de Nota #: " + info.IdTipoNota.ToString() + " exitosamente";
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

        public int GetId(int idempresa)
        {
            try
            {
                int Id;
                EntitiesFacturacion OEPTipoNota = new EntitiesFacturacion();
                var select = from q in OEPTipoNota.fa_TipoNota
                             select q;

                if (select.ToList().Count < 1)
                {
                    Id = 1;
                }
                else
                {
                    EntitiesFacturacion OEPTipoNota_getId = new EntitiesFacturacion();
                    var select_pv = (from A in OEPTipoNota_getId.fa_TipoNota
                                     select A.IdTipoNota).Max();
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

        public Boolean GrabarDB(fa_TipoNota_Info info, ref int id, ref string msg)
        {
            try
            {
                using (EntitiesFacturacion context = new EntitiesFacturacion())
                {

                    if (context.fa_TipoNota.Where<fa_TipoNota>(v => v.CodTipoNota == info.CodTipoNota).Count() != 0) 
                    {
                        msg = "El codigo Ingresado ya existe por favor ingresar uno diferente";
                        return false;
                    }


                    var address = new fa_TipoNota();
                    int idpv = GetId(info.IdEmpresa);
                    id = idpv;
                    address.IdTipoNota = idpv;
                    address.CodTipoNota = (info.CodTipoNota == "") ? idpv.ToString() : info.CodTipoNota;
                    address.Tipo = info.Tipo;
                    address.No_Descripcion = info.no_Descripcion;
                    address.Nemonico = (info.Nemonico == "") ? idpv.ToString() : info.Nemonico;
                    address.InternoSis = info.InternoSis;
                    address.SeDeclaraSRI = info.SeDeclaraSRI ;
                    address.IdUsuario = info.IdUsuario;
                    address.Fecha_Transac = info.Fecha_Transac;
                    address.nom_pc = info.nom_pc;
                    address.ip = info.ip;
                    address.Estado = "A";
                    context.fa_TipoNota.Add(address);
                    context.SaveChanges();
                    msg = "Se ha procedido a grabar el registro del Tipo de Nota #: " + id.ToString() + " exitosamente.";
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

        public Boolean EliminarDB(fa_TipoNota_Info info, ref  string msg)
        {
            try
            {
                EntitiesFacturacion OEPTipoNota = new EntitiesFacturacion();
                var select = from q in OEPTipoNota.fa_TipoNota
                             where 
                             q.IdTipoNota==info.IdTipoNota
                             select q;

                if (select.ToList().Count > 0)
                {
                    using (EntitiesFacturacion context = new EntitiesFacturacion())
                    {
                        var contact = context.fa_TipoNota.FirstOrDefault(obj => obj.IdTipoNota==info.IdTipoNota);
                        if (contact != null)
                        {
                            contact.IdUsuarioUltAnu = info.IdUsuarioUltAnu;
                            contact.Fecha_UltAnu = DateTime.Now;
                            contact.nom_pc = info.nom_pc;
                            contact.ip = info.ip;
                            contact.MotiAnula = info.MotiAnula;
                            contact.Estado = "I";
                            context.SaveChanges();
                            msg = "Se ha procedido anular el registro del Tipo de Nota #: " + info.no_Descripcion + " exitosamente";
                        }
                    }

                    return true;
                }
                else
                {
                    msg = "No es posible anular el registro del Tipo de Nota #: " + info.no_Descripcion + " debido a que ya se encuentra anulado.";
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


        public fa_TipoNota_Data() { }
    }
}
