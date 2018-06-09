using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Roles;
using Core.Erp.Data.General;
using Core.Erp.Info.General;


namespace Core.Erp.Data.Roles
{
    public class ro_empleado_x_ro_rubro_Data
    {
        string mensaje = "";

        public Boolean GrabarBD(ro_empleado_x_ro_rubro_Info Info, ref string msg)
        {
            try
            {
                List<ro_empleado_x_ro_rubro_Info> Lst = new List<ro_empleado_x_ro_rubro_Info>();
                using (EntitiesRoles Context = new EntitiesRoles())
                {
                    var Address = new ro_empleado_x_ro_rubro();

                    Address.IdEmpresa = Info.IdEmpresa;
                    Address.IdNomina_Tipo = Info.IdNomina_Tipo;
                    Address.IdNomina_TipoLiqui = Info.IdNomina_TipoLiqui;               
                    Address.IdEmpleado = Info.IdEmpleado;
                    Address.IdCentroCosto = Info.IdCentroCosto;
                    Address.IdRubro = Info.IdRubro;
                    Address.Valor = Info.Valor;
                    Context.ro_empleado_x_ro_rubro.Add(Address);
                    Context.SaveChanges();
                    //
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

        public List<ro_empleado_x_ro_rubro_Info> Get_List_empleado_x_ro_rubro_(int IdEmpresa)
        {
                List<ro_empleado_x_ro_rubro_Info> Lst = new List<ro_empleado_x_ro_rubro_Info>();
                EntitiesRoles oEnti = new EntitiesRoles();
            try
            {

                var Query = from q in oEnti.ro_empleado_x_ro_rubro
                            where q.IdEmpresa == IdEmpresa
                            select q;

                foreach (var item in Query)
                {
                    ro_empleado_x_ro_rubro_Info Obj = new ro_empleado_x_ro_rubro_Info();
                    Obj.IdEmpresa = item.IdEmpresa;
                    Obj.IdNomina_Tipo = item.IdNomina_Tipo;
                    Obj.IdNomina_TipoLiqui = item.IdNomina_TipoLiqui;   
                    Obj.IdEmpleado = item.IdEmpleado;
                    Obj.IdRubro = item.IdRubro;
                    Obj.IdCentroCosto = item.IdCentroCosto;
                    Obj.Valor = item.Valor;

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

        public List<ro_empleado_x_ro_rubro_Info> Get_List_empleado_x_ro_rubro_x_Empleado(int IdEmpresa, decimal IdEmpleado)
        {
            List<ro_empleado_x_ro_rubro_Info> Lst = new List<ro_empleado_x_ro_rubro_Info>();
            EntitiesRoles db = new EntitiesRoles();
            try
            {

                var datos = from a in db.ro_empleado_x_ro_rubro
                            where a.IdEmpresa == IdEmpresa && a.IdEmpleado==IdEmpleado
                            select a;

                foreach (var item in datos)
                {
                    ro_empleado_x_ro_rubro_Info Obj = new ro_empleado_x_ro_rubro_Info();
                    Obj.IdEmpresa = item.IdEmpresa;
                    Obj.IdNomina_Tipo = item.IdNomina_Tipo;
                    Obj.IdNomina_TipoLiqui = item.IdNomina_TipoLiqui;
                    Obj.IdEmpleado = item.IdEmpleado;
                    Obj.IdRubro = item.IdRubro;
                    Obj.IdCentroCosto = item.IdCentroCosto;
                    Obj.Valor = item.Valor;

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

        public ro_empleado_x_ro_rubro_Info Get_Info_empleado_x_ro_rubro(int IdEmpresa, decimal IdEmpleado)
        {
            EntitiesRoles oEnti = new EntitiesRoles();
            ro_empleado_x_ro_rubro_Info Info = new ro_empleado_x_ro_rubro_Info();
            try
            {

                var Objeto = oEnti.ro_empleado_x_ro_rubro.First(var => var.IdEmpresa == IdEmpresa && var.IdEmpleado == IdEmpleado);
               
                
                Info.IdEmpresa = Objeto.IdEmpresa;

                Info.IdNomina_Tipo = Objeto.IdNomina_Tipo;
                Info.IdNomina_TipoLiqui = Objeto.IdNomina_TipoLiqui;
                Info.IdEmpleado = Objeto.IdEmpleado;
                Info.IdRubro = Objeto.IdRubro;

                Info.IdCentroCosto = Objeto.IdCentroCosto;
                // Info.Secuencia = Objeto.Secuencia;
                Info.Valor = Objeto.Valor;

                return Info;
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

        public Boolean ModificarDB(ro_empleado_x_ro_rubro_Info info)
        {
            try
            {
                using (EntitiesRoles context = new EntitiesRoles())
                {
                    var contact = context.ro_empleado_x_ro_rubro.First(minfo => minfo.IdEmpresa == info.IdEmpresa
                                 && minfo.IdEmpleado == info.IdEmpleado
                                 && minfo.IdNomina_Tipo == info.IdNomina_Tipo 
                                 && minfo.IdNomina_TipoLiqui == info.IdNomina_TipoLiqui && minfo.IdRubro == info.IdRubro);
            
                    contact.Valor = info.Valor;
                    context.SaveChanges();

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

        public Boolean EliminarBD(int idEmpresa, decimal idEmpleado, ref string msg)
        {
            try
            {

                using (EntitiesRoles db = new EntitiesRoles())
                {

                    db.Database.ExecuteSqlCommand("delete from dbo.ro_empleado_x_ro_rubro where IdEmpresa =" + idEmpresa.ToString()
                            + " AND IdEmpleado=" + idEmpleado.ToString()
                            );

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

        public List<ro_empleado_x_ro_rubro_Info> Get_List_empleado_x_ro_rubro(int IdEmpresa, decimal IdEmpleado)
        {
                List<ro_empleado_x_ro_rubro_Info> Lst = new List<ro_empleado_x_ro_rubro_Info>();
                EntitiesRoles oEnti = new EntitiesRoles();
            try
            {

                var Query = from q in oEnti.vwRo_Conf_Rubros_Empleado
                            where q.IdEmpresa == IdEmpresa 
                            &&  q.IdEmpleado == IdEmpleado
                            orderby q.OrdenPres
                            select q;

                foreach (var item in Query)
                {
                    ro_empleado_x_ro_rubro_Info Obj = new ro_empleado_x_ro_rubro_Info();
                    Obj.IdEmpresa = item.IdEmpresa;
                    Obj.IdEmpleado = Convert.ToDecimal(item.IdEmpleado);
                    Obj.IdRubro = item.IdRubro;
                    Obj.InfoTipoRubro.ru_descripcion = item.ru_descripcion;
                    Obj.InfoTipoRubro.ru_tipo = item.ru_tipo;
                    Obj.InfoTipoRubro.NombreCorto = item.NombreCorto;
                    //Obj.IdCentroCosto = item.IdCentroCosto;

                    Obj.Valor = Convert.ToDecimal(item.valor == null ? 0 : item.valor);
                   // Obj.Secuencia = Convert.ToInt32(item.secuencia == null ? 0:item.valor);
                    

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

        public List<ro_empleado_x_ro_rubro_Info> Get_List_empleado_x_ro_rubro(int IdEmpresa, decimal IdEmpleado, int idNomina)
        {
                List<ro_empleado_x_ro_rubro_Info> Lst = new List<ro_empleado_x_ro_rubro_Info>();
                EntitiesRoles oEnti = new EntitiesRoles();
            try
            {
                var Query = from q in oEnti.vwRo_Nomina_x_Liqui_x_Rubro_x_Empleado
                            where q.IdEmpresa == IdEmpresa
                            && q.IdEmpleado == IdEmpleado && q.IdNomina_Tipo == idNomina
                           // orderby q.OrdenPres
                            select q;

                foreach (var item in Query)
                {
                    ro_empleado_x_ro_rubro_Info Obj = new ro_empleado_x_ro_rubro_Info();

                    Obj.IdEmpresa = item.IdEmpresa;
                    Obj.IdNomina_Tipo = item.IdNomina_Tipo;
                    Obj.IdNomina_TipoLiqui = item.IdNomina_TipoLiqui;                 
                    Obj.IdEmpleado = Convert.ToDecimal(item.IdEmpleado);
                    Obj.IdRubro = item.IdRubro;
                    Obj.Valor = Convert.ToDecimal(item.Valor == null ? 0 : item.Valor);
                    
                    Obj.Descripcion = item.Descripcion;
                    Obj.DescripcionProcesoNomina = item.DescripcionProcesoNomina;
                    Obj.rub_codigo = item.rub_codigo;
                    Obj.ru_descripcion = item.ru_descripcion;

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

        public List<ro_empleado_x_ro_rubro_Info> Get_List_empleado_x_ro_rubro(int IdEmpresa, decimal IdEmpleado, int idNomina, int idNominaLiqui)
        {
            List<ro_empleado_x_ro_rubro_Info> Lst = new List<ro_empleado_x_ro_rubro_Info>();
            EntitiesRoles oEnti = new EntitiesRoles();
            try
            {
                var datos = from a in oEnti.vwRo_Nomina_Empleado_x_Rubro
                            where a.IdEmpresa == IdEmpresa
                            && a.IdEmpleado == IdEmpleado && a.IdNomina_Tipo == idNomina
                            && a.IdNomina_TipoLiqui==idNominaLiqui
                            select a;

                foreach (var item in datos)
                {
                    ro_empleado_x_ro_rubro_Info Obj = new ro_empleado_x_ro_rubro_Info();

                    Obj.IdEmpresa = item.IdEmpresa;
                    Obj.IdNomina_Tipo = item.IdNomina_Tipo;
                    Obj.IdNomina_TipoLiqui = item.IdNomina_TipoLiqui;
                    Obj.IdEmpleado = Convert.ToDecimal(item.IdEmpleado);
                    Obj.IdRubro = item.IdRubro;
                    Obj.Valor = Convert.ToDecimal(item.Valor == null ? 0 : item.Valor);

                    Obj.Descripcion = item.Descripcion;
                    Obj.DescripcionProcesoNomina = item.DescripcionProcesoNomina;
                    Obj.rub_codigo = item.rub_codigo;
                    Obj.ru_descripcion = item.ru_descripcion;

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

        public List<ro_empleado_x_ro_rubro_Info> Get_Info_empleado_x_ro_rubro(int IdEmpresa, decimal IdEmpleado, int idNomina, int idNominaLiqui)
        {
            List<ro_empleado_x_ro_rubro_Info> Lst = new List<ro_empleado_x_ro_rubro_Info>();
            EntitiesRoles oEnti = new EntitiesRoles();
            try
            {
                var datos = from a in oEnti.vwRo_Nomina_x_Liqui_x_Rubro_x_Empleado
                            where a.IdEmpresa == IdEmpresa
                            && a.IdEmpleado == IdEmpleado && a.IdNomina_Tipo == idNomina
                            && a.IdNomina_TipoLiqui == idNominaLiqui
                            select a;

                foreach (var item in datos)
                {
                    ro_empleado_x_ro_rubro_Info Obj = new ro_empleado_x_ro_rubro_Info();

                    Obj.IdEmpresa = item.IdEmpresa;
                    Obj.IdNomina_Tipo = item.IdNomina_Tipo;
                    Obj.IdNomina_TipoLiqui = item.IdNomina_TipoLiqui;
                    Obj.IdEmpleado = Convert.ToDecimal(item.IdEmpleado);
                    Obj.IdRubro = item.IdRubro;
                    Obj.Valor = Convert.ToDecimal(item.Valor == null ? 0 : item.Valor);

                    Obj.Descripcion = item.Descripcion;
                    Obj.DescripcionProcesoNomina = item.DescripcionProcesoNomina;
                    Obj.rub_codigo = item.rub_codigo;
                    Obj.ru_descripcion = item.ru_descripcion;

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

        public List<ro_empleado_x_ro_rubro_Info> Get_List_empleado_x_ro_rubro_x_Conf_Rubros(int IdEmpresa)
        {
                List<ro_empleado_x_ro_rubro_Info> Lst = new List<ro_empleado_x_ro_rubro_Info>();
                EntitiesRoles oEnti = new EntitiesRoles();
            try
            {

                var Query = from q in oEnti.vwRo_Conf_Rubros
                            where q.IdEmpresa == IdEmpresa
                            orderby q.OrdenPres
                          
                            select q;

                foreach (var item in Query)
                {
                    ro_empleado_x_ro_rubro_Info Obj = new ro_empleado_x_ro_rubro_Info();
                    Obj.IdEmpresa = item.IdEmpresa;
                    Obj.IdRubro = item.IdRubro;
                    Obj.InfoTipoRubro.ru_descripcion = item.ru_descripcion;
                    Obj.InfoTipoRubro.ru_tipo = item.ru_tipo;
                    Obj.InfoTipoRubro.NombreCorto = item.NombreCorto;


                    

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

        public Boolean ExisteRubro(int idempresa, decimal idempleado, string IdRubro, int IdNomina_Tipo, int IdNomina_TipoLiqui, string idCentroCosto)
        {

            try
            {
                Boolean Existe;

                Existe = false;

                EntitiesRoles OERol_Empleado = new EntitiesRoles();

                var select = from A in OERol_Empleado.ro_empleado_x_ro_rubro
                             where A.IdEmpresa == idempresa && A.IdEmpleado == idempleado
                             && A.IdRubro == IdRubro && A.IdNomina_Tipo == IdNomina_Tipo && A.IdNomina_TipoLiqui == IdNomina_TipoLiqui && A.IdCentroCosto == idCentroCosto
                             select A;

                foreach (var item in select)
                {
                    Existe = true;
                }

                return Existe;

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

        public Boolean EliminarBD(int idEmpresa, decimal idEmpleado,int idNominaTipo, int idNominaTipoLiqui,  ref string msg)
        {
            try
            {
                using (EntitiesRoles db = new EntitiesRoles())
                {
                    db.Database.ExecuteSqlCommand("delete from dbo.ro_empleado_x_ro_rubro where IdEmpresa =" + idEmpresa.ToString()
                                            + " AND IdEmpleado=" + idEmpleado.ToString()
                                            + " AND IdNomina_Tipo=" + idNominaTipo.ToString()
                                            //+ " AND IdNomina_TipoLiqui=" + idNominaTipoLiqui.ToString()
                                           );
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
    }
}
