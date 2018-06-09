using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Data.General
{
    public class tb_Sucursal_Data
    {
        string mensaje = "";

        public List<tb_Sucursal_Info> Get_List_Sucursal(int IdEmpresa)
        {
            try
            {

                List<tb_Sucursal_Info> lM = new List<tb_Sucursal_Info>();
                EntitiesGeneral OESucursal = new EntitiesGeneral();

                var select_sucursal = from A in OESucursal.tb_sucursal
                                      where A.IdEmpresa==IdEmpresa
                                       select A;

                foreach (var item in select_sucursal)
                {
                        tb_Sucursal_Info info = new tb_Sucursal_Info();
                        info.IdEmpresa = item.IdEmpresa;
                        info.IdSucursal = item.IdSucursal;

                        info.Su_CodigoEstablecimiento = item.Su_CodigoEstablecimiento;
                        info.Su_Ubicacion = item.Su_Ubicacion;
                        info.Su_Ruc = item.Su_Ruc;
                        info.Su_JefeSucursal = item.Su_JefeSucursal;
                        info.Su_Telefonos = item.Su_Telefonos;
                        info.Su_Direccion = item.Su_Direccion;
                        info.Es_establecimiento = item.Es_establecimiento;
                        info.Su_Descripcion = item.Su_Descripcion.Trim();
                        info.Su_Descripcion2 = "[" + item.IdSucursal + "]" + item.Su_Descripcion.Trim();
                        info.Estado = (item.Estado == "A") ? true : false;
                        info.SEstado = (item.Estado == "A") ? "ACTIVO" : "*ANULADO*";
                        info.codigo = item.codigo;
                    
                        lM.Add(info);
                  
                }
                return (lM);
            }
          
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public tb_Sucursal_Info Get_Info_Sucursal(int IdEmpresa, int IdSucursal)
        {
            try
            {
                tb_Sucursal_Info info = new tb_Sucursal_Info();
                EntitiesGeneral OESucursal = new EntitiesGeneral();

                var select_sucursal = from A in OESucursal.tb_sucursal
                                      where A.IdEmpresa == IdEmpresa
                                      && A.IdSucursal == IdSucursal
                                      select A;

                foreach (var item in select_sucursal)
                {
                                        
                    info.IdEmpresa = item.IdEmpresa;
                    info.IdSucursal = item.IdSucursal;

                    info.Su_CodigoEstablecimiento = item.Su_CodigoEstablecimiento;
                    info.Su_Ubicacion = item.Su_Ubicacion;
                    info.Su_Ruc = item.Su_Ruc;
                    info.Su_JefeSucursal = item.Su_JefeSucursal;
                    info.Su_Telefonos = item.Su_Telefonos;
                    info.Su_Direccion = item.Su_Direccion;
                    info.Es_establecimiento = item.Es_establecimiento;
                    info.Su_Descripcion = item.Su_Descripcion.Trim();
                    info.Su_Descripcion2 = "[" + item.IdSucursal + "]" + item.Su_Descripcion.Trim();
                    info.Estado = (item.Estado == "A") ? true : false;
                    info.SEstado = (item.Estado == "A") ? "ACTIVO" : "*ANULADO*";
                    info.codigo = item.codigo;
             
                }
                return info;
            }                

            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public string Get_Cod_Establecimiento_x_Sucursal(int IdEmpresa, int IdSucursal)
        {
            try
            {
                string Cod_estable = "";

                EntitiesGeneral OESucursal = new EntitiesGeneral();

                var select_sucursal = from A in OESucursal.tb_sucursal
                                      where A.IdEmpresa == IdEmpresa
                                      && A.IdSucursal == IdSucursal
                                      select A;

                foreach (var item in select_sucursal)
                {


                    Cod_estable = item.Su_CodigoEstablecimiento;
                    

                }
                return Cod_estable;
            }

            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }
        
        public Boolean ModificarDB(tb_Sucursal_Info info, ref string msg)
        {
            try
            {
                using (EntitiesGeneral context = new EntitiesGeneral())
                {
                    var contact = context.tb_sucursal.FirstOrDefault(obj => obj.IdEmpresa == info.IdEmpresa && obj.IdSucursal == info.IdSucursal);
                    if (contact != null)
                    {
                        contact.Su_Descripcion = info.Su_Descripcion;
                        contact.Su_CodigoEstablecimiento = info.Su_CodigoEstablecimiento;
                        contact.Su_Ubicacion = info.Su_Ubicacion;
                        contact.Su_Ruc = info.Su_Ruc;
                        contact.Su_JefeSucursal = info.Su_JefeSucursal;
                        contact.Su_Telefonos = info.Su_Telefonos;
                        contact.Su_Direccion = info.Su_Direccion;
                        contact.codigo = info.codigo;
                        contact.IdUsuarioUltMod = info.IdUsuarioUltMod;
                        contact.Fecha_UltMod = info.Fecha_UltMod;
                        contact.nom_pc = info.nom_pc;
                        contact.Es_establecimiento = info.Es_establecimiento;
                        contact.ip = info.ip;
                        contact.Estado = (info.Estado == true) ? "A" : "I";
                        context.SaveChanges();
                        msg = "Se ha procedido actualizar el registro de la sucursal #: " + info.IdSucursal.ToString() + " exitosamente";
                    }
                }
                return true;
            }
            catch (Exception ex )
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                msg = "Se ha producido el siguiente error: " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public int GetId(int IdEmpresa)
        {
            try
            {
                 int Id;
                EntitiesGeneral OECSucursal = new EntitiesGeneral();
                var select = from q in OECSucursal.tb_sucursal
                             where q.IdEmpresa == IdEmpresa
                                      select q;

            
                if (select.Count() == 0)
                {
                    Id = 1;
                }
                else
                {
                    var select_Sucursal = (from q in OECSucursal.tb_sucursal
                                           where q.IdEmpresa == IdEmpresa
                                           select q.IdSucursal).Max();
                    Id = Convert.ToInt32(select_Sucursal.ToString()) + 1;
              }
                return Id;
            }
			catch(Exception ex)
			{
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
            
        }

        public Boolean GrabarDB(tb_Sucursal_Info info, ref int id, ref string msg)
        {
            try
            {
                using (EntitiesGeneral context = new EntitiesGeneral())
                {
                    var address = new tb_sucursal();
                    int idsucur = GetId(info.IdEmpresa);
                    id = idsucur;
                    address.IdEmpresa = info.IdEmpresa;
                    address.IdSucursal = idsucur;
                    address.Su_Descripcion = info.Su_Descripcion;
                    address.IdUsuario = info.IdUsuario;
                    address.Fecha_Transac = info.Fecha_Transac;
                    address.Su_CodigoEstablecimiento = info.Su_CodigoEstablecimiento;
                    address.Es_establecimiento = info.Es_establecimiento;
                    address.Su_Ubicacion = info.Su_Ubicacion;
                    address.Su_Ruc = info.Su_Ruc;
                    address.Su_JefeSucursal = info.Su_JefeSucursal;
                    address.Su_Telefonos = info.Su_Telefonos;
                    address.Su_Direccion = info.Su_Direccion;

                    address.codigo = (info.codigo == "" || info.codigo == null) ? "S_" + idsucur : info.codigo;

                    address.Estado = "A";
                    context.tb_sucursal.Add(address);
                    context.SaveChanges();
                    msg = "Se ha procedido a grabar el registro de la sucursal #: " + id.ToString() + " exitosamente.";
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
                mensaje = ex.ToString() + " " + ex.Message;
                msg = "Se ha producido el siguiente error: " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public Boolean EliminarDB(tb_Sucursal_Info info, ref  string msg)
        {
            try
            {
                using (EntitiesGeneral context = new EntitiesGeneral())
                {
                    var contact = context.tb_sucursal.FirstOrDefault(obj => obj.IdEmpresa == info.IdEmpresa && obj.IdSucursal == info.IdSucursal);
                    if(contact!=null)
                    {
                    contact.IdUsuarioUltAnu = info.IdUsuarioUltAnu;
                    contact.Fecha_UltAnu = DateTime.Now;
                    contact.nom_pc = info.nom_pc;
                    contact.ip = info.ip;
                    contact.Estado = "I";
                    context.SaveChanges();
                    msg = "Se ha procedido anular el registro de la sucursal #: " + info.IdSucursal.ToString() + " exitosamente";
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
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                msg = "Se ha producido el siguiente error: " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public Boolean ValidarCodigoExiste(int IdEmresa, string Ruc, string Cod)
        {
            try
            {
                EntitiesGeneral Ent = new EntitiesGeneral();

                var Existe = from q in Ent.tb_sucursal
                             where q.IdEmpresa==IdEmresa
                             && q.Su_Ruc==Ruc
                             && q.Su_CodigoEstablecimiento == Cod 
                             select q;

                if (Existe.Count() > 0)
                {
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
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public int Get_numEstablecimiento_x_empresa_SRI(int IdEmpresa)
        {
            try
            {
                int x = 0;

                using (EntitiesGeneral Context = new EntitiesGeneral())
                {
                    var lst = from q in Context.tb_sucursal
                              where q.IdEmpresa == IdEmpresa
                              && q.Es_establecimiento == true
                              select q;

                    if (lst.Count() == 0)
                        x = 1;
                    else
                        x = lst.Count();
                }

                return x;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public tb_Sucursal_Data() { }
    }
}
