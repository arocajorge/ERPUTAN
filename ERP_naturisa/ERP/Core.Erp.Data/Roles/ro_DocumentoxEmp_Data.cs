using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Roles;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Data.Roles
{
    public class ro_DocumentoxEmp_Data
    {
        string mensaje = "";


        public Boolean GrabarBD(ro_DocumentoxEmp_Info item)
        {
            try
            {
                   using (EntitiesRoles Context = new EntitiesRoles())
                    {
                       // var contact = ro_DocumentoxEmp.Createro_DocumentoxEmp(0, 0, 0, "", "", "", DateTime.Now, "");

                        var Address = new ro_DocumentoxEmp();

                        Address.IdEmpresa = item.IdEmpresa;
                        Address.IdEmpleado = item.IdEmpleado;
                        Address.IdDocumento = item.IdDocumento;
                        Address.Dc_Nombre = item.Dc_Nombre;
                        Address.tipo = item.tipo;
                        Address.Dc_Descripcion = item.Dc_Descripcion;
                        Address.Documento = item.Documento;
                        Address.FechaReg = item.FechaReg;
                        Address.Estado = item.Estado;

                        Context.ro_DocumentoxEmp.Add(Address);
                        Context.SaveChanges();

                    }
                
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public Boolean GuardarDB(List<ro_DocumentoxEmp_Info> LstInfo)
        {
            try
            {
                int sec = 1;

                foreach (var item in LstInfo)
                {
                    sec = sec + 1;
                    
                    using (EntitiesRoles Context = new EntitiesRoles())
                    {
                        var Address = new ro_DocumentoxEmp();
                        
                        Address.IdEmpresa = item.IdEmpresa;
                        Address.IdEmpleado = item.IdEmpleado;
                        Address.IdDocumento = item.IdDocumento;
                       
                            Address.Dc_Nombre = item.Dc_Nombre;

                       
                        if (item.Dc_Descripcion == "")
                        {
                            item.Dc_Descripcion = item.Dc_Nombre;
                        }
                        Address.tipo = item.tipo;
                        Address.Dc_Descripcion = item.Dc_Nombre;
                        Address.Documento = item.Documento;
                        Address.FechaReg = item.FechaReg;
                        Address.Estado = item.Estado;
                        Address.IdDocumento = sec;
                        Context.ro_DocumentoxEmp.Add(Address);
                        Context.SaveChanges();

                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public List<ro_DocumentoxEmp_Info> ConsultaXEmpleado(int idempresa, decimal idempleado)
        {
                List<ro_DocumentoxEmp_Info> Lst = new List<ro_DocumentoxEmp_Info>();
                EntitiesRoles oEnti = new EntitiesRoles();
            try
            {


                var Query = from q in oEnti.ro_DocumentoxEmp
                            where q.IdEmpresa == idempresa && q.IdEmpleado == idempleado
                            select q;
                foreach (var item in Query)
                {

                    ro_DocumentoxEmp_Info Obj = new ro_DocumentoxEmp_Info();
                    Obj.IdEmpresa = item.IdEmpresa;
                    Obj.IdEmpleado = item.IdEmpleado;
                    Obj.IdDocumento = item.IdDocumento;
                    Obj.Dc_Nombre = item.Dc_Nombre;
                    Obj.Dc_Descripcion = item.Dc_Descripcion;
                    Obj.Documento = item.Documento;
                    Obj.Estado = item.Estado;
                    Obj.FechaReg = item.FechaReg;
                    Obj.tipo = item.tipo;
                    Obj.check = true;
                    Lst.Add(Obj);
                }
                return Lst;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.InnerException.ToString());
            }
        }


        public Boolean EliminarDB(List<ro_DocumentoxEmp_Info> List, ref string msg)
        {
            try
            {
                using (EntitiesRoles context = new EntitiesRoles())
                {
                    // pregunto si existe documentos por ese empleado para que no se caiga

                    ro_DocumentoxEmp_Info info = List.FirstOrDefault();

                    var Query = from q in context.ro_DocumentoxEmp
                                where q.IdEmpresa == info.IdEmpresa && q.IdEmpleado == info.IdEmpleado
                                select q;


                    if (Query.Count() > 0)
                    {
                        foreach (var item in Query.ToList())
                        {
                            var address = context.ro_DocumentoxEmp.First(A => A.IdEmpresa == item.IdEmpresa
                                         && A.IdEmpleado == item.IdEmpleado && item.IdDocumento==item.IdDocumento);

                            context.ro_DocumentoxEmp.Remove(address);

                            context.SaveChanges();
                        }
                       
                    }

                }
                msg = "Guardado con exito";
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.InnerException.ToString());
            }
        }



        public Boolean AnularDB(ro_DocumentoxEmp_Info Info, ref string msg)
        {
            try
            {
                using (EntitiesRoles context = new EntitiesRoles())
                {                   
                        var address = context.ro_DocumentoxEmp.First(A => A.IdEmpresa == Info.IdEmpresa
                            && A.IdEmpleado == Info.IdEmpleado&& A.IdDocumento ==Info.IdDocumento);

                        address.Estado = "I";
                        address.Documento = null;
                        address.Dc_Descripcion = Info.Dc_Descripcion;
                        address.FechaElimin = Info.FechaElimin;
                        address.UsuarioElimin = Info.UsuarioElimin;
                        address.MotivoElimin = Info.MotivoElimin;
                        context.SaveChanges();
                    
                }
                msg = "Guardado con exito";

                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.InnerException.ToString());
            }
        }
    }
}
