using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.General;
using Core.Erp.Data.General;


namespace Core.Erp.Data.General
{
    public class tb_ubicacion_Data
    {
        string mensaje="";
        public List<tb_ubicacion_Info> Get_List_Ubicacion()
        {
            try
            {
                List<tb_ubicacion_Info> lM = new List<tb_ubicacion_Info>();
                EntitiesGeneral OEUbicacion = new EntitiesGeneral();

                var select_ubicacion = from A in OEUbicacion.tb_ubicacion
                                       orderby A.IdUbicacion, A.IdUbicacion_Padre, A.ub_posicion 
                                      select A;

                foreach (var item in select_ubicacion)
                {
                    tb_ubicacion_Info info = new tb_ubicacion_Info();
                    info.IdUbicacion = item.IdUbicacion.Trim();
                    info.IdUbicacion_Padre = item.IdUbicacion_Padre.Trim();
                    info.ub_descripcion = item.ub_descripcion.Trim();
                    info.ub_nivel = item.ub_nivel;
                    info.ub_posicion = item.ub_posicion;
                    info.Estado = item.Estado;
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

        public List<tb_ubicacion_Info> Get_List_Ciudad()
        {
            try
            {
                List<tb_ubicacion_Info> lM = new List<tb_ubicacion_Info>();
                EntitiesGeneral OEUbicacion = new EntitiesGeneral();

                var select_ubicacion = from A in OEUbicacion.tb_ubicacion
                                       orderby A.IdUbicacion, A.IdUbicacion_Padre, A.ub_posicion
                                       where A.ub_nivel == 2
                                       select A;

                foreach (var item in select_ubicacion)
                {
                    tb_ubicacion_Info info = new tb_ubicacion_Info();
                    info.IdUbicacion = item.IdUbicacion.Trim();
                    info.IdUbicacion_Padre = item.IdUbicacion_Padre.Trim();
                    info.ub_descripcion = item.ub_descripcion.Trim();
                    info.ub_nivel = item.ub_nivel;
                    info.ub_posicion = item.ub_posicion;
                    info.Estado = item.Estado;
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

        public List<tb_ubicacion_Info> Get_List_Pais()
        {
            try
            {
                List<tb_ubicacion_Info> lM = new List<tb_ubicacion_Info>();
                EntitiesGeneral OEUbicacion = new EntitiesGeneral();

                var select_ubicacion = from A in OEUbicacion.tb_ubicacion
                                       orderby A.IdUbicacion, A.IdUbicacion_Padre, A.ub_posicion
                                       where A.ub_nivel == 0
                                       select A;

                foreach (var item in select_ubicacion)
                {
                    tb_ubicacion_Info info = new tb_ubicacion_Info();
                    info.IdUbicacion = item.IdUbicacion.Trim();
                    info.IdUbicacion_Padre = item.IdUbicacion_Padre.Trim();
                    info.ub_descripcion = item.ub_descripcion.Trim();
                    info.ub_nivel = item.ub_nivel;
                    info.ub_posicion = item.ub_posicion;
                    info.Estado = item.Estado;
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

        public Boolean ModificarDB(tb_ubicacion_Info info, ref string msg)
        {
            try
            {
                using (EntitiesGeneral context = new EntitiesGeneral())
                {
                    var contact = context.tb_ubicacion.FirstOrDefault(obj => obj.IdUbicacion == info.IdUbicacion);
                    if (contact != null)
                    {
                        contact.IdUbicacion_Padre = info.IdUbicacion_Padre;
                        contact.ub_descripcion = info.ub_descripcion;
                        contact.ub_posicion = info.ub_posicion;
                        contact.IdUsuarioUltMod = info.IdUsuarioUltMod;
                        contact.Fecha_UltMod = info.Fecha_UltMod;
                        contact.nom_pc = info.nom_pc;
                        contact.ip = info.ip;
                        contact.Estado = info.Estado;
                        context.SaveChanges();
                        msg = "Se ha procedido actualizar el registro de la ubicación #: " + info.IdUbicacion.ToString() + " para la ubicación: " + info.ub_descripcion + " exitosamente";
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
     
        public string Get_Id(string codPadre)
        {
            string idHijo = "";


            try
            {
                //declaracion de variables
                //int numDigitosxPadre = 0;
                int i_nivelPadre = 0;
                int numDigitosxHijo = 0;
                int i_nivelHijo = 0;

                EntitiesGeneral OEUbicacion = new EntitiesGeneral();
                var tb = from C in OEUbicacion.tb_ubicacion
                         where C.IdUbicacion == codPadre
                         select new { C.ub_nivel };
                foreach (var item in tb)
                {
                    //obtengo el nivel del padre de dicha cta
                    i_nivelPadre = Convert.ToInt32(item.ub_nivel);
                }

                OEUbicacion.Dispose();
                
                //numDigitosxPadre = 3;
                numDigitosxHijo = 3;

                // al nivel del hijo le sumo uno
                i_nivelHijo = i_nivelPadre + 1;

                OEUbicacion = new EntitiesGeneral();
                //var tb3 = from F in OEUbicacion.tb_ubicacion
                //          where F.IdUbicacion.StartsWith(codPadre)
                //          select new { id = F.IdUbicacion.Substring(F.IdUbicacion_Padre.Trim().Length) };
                IQueryable<string> tb3 ; ;
                if (string.IsNullOrEmpty(codPadre))
                {
                    tb3 = from F in OEUbicacion.tb_ubicacion
                          where F.IdUbicacion_Padre == codPadre
                          select F.IdUbicacion;
                }
                else 
                {
                //tb3 = from q in 
                    
                    tb3 = from F in OEUbicacion.tb_ubicacion
                          where F.IdUbicacion.StartsWith(codPadre) && F.IdUbicacion != codPadre
                          select F.IdUbicacion;
                }

                //.Substring(F.IdUbicacion_Padre.Trim().Length) 

                List<int> lista = new List<int>();
                foreach (var item in tb3)
                {
                    var valor = item.Substring(codPadre.Trim().Length);
                    if (valor.Length == 3)
                        lista.Add(Convert.ToInt32(item));
                }
                
                if (lista.Count > 0)
                {
                    //obtengo el max de loxs id
                    var temp = (from A in lista
                                select A).Max() + 1;
                    idHijo = temp.ToString();
                    idHijo = "000000000" + idHijo;
                    int value = idHijo.Length - numDigitosxHijo;
                    idHijo = idHijo.Substring(value, numDigitosxHijo);
                    idHijo = codPadre + idHijo;
                }
                else
                {
                    //asigno el primer valor cuando no obtengo nada de la lista
                    idHijo = codPadre + "001";
                }
                
                string result = idHijo.ToString();  //.Substring(value, numDigitosxHijo);

                return result;
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

        public Boolean GrabarDB(tb_ubicacion_Info info, ref string id, ref string msg)
        {
            try
            {
                using (EntitiesGeneral context = new EntitiesGeneral())
                {
                    var address = new tb_ubicacion();
                    string idsucur = Get_Id(info.IdUbicacion_Padre);
                    id = idsucur;
                    address.IdUbicacion= idsucur;
                    address.IdUbicacion_Padre = info.IdUbicacion_Padre;
                    address.ub_descripcion = info.ub_descripcion;
                    address.ub_nivel = info.ub_nivel;
                    address.ub_posicion = info.ub_posicion;
                    address.IdUsuario = info.IdUsuario;
                    address.Fecha_Transac = info.Fecha_Transac;
                    address.nom_pc = info.nom_pc;
                    address.ip = info.ip;
                    address.Estado = "A";
                    context.tb_ubicacion.Add(address);
                    context.SaveChanges();
                    msg = "Se ha procedido a grabar el registro de la Ubbicación #: " + id.ToString() + " para la ubicación: " + info.ub_descripcion + " exitosamente";
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

        public Boolean EliminarDB(tb_ubicacion_Info info, ref  string msg)
        {
            try
            {
                EntitiesGeneral OECSucursal = new EntitiesGeneral();
                var select = from q in OECSucursal.tb_ubicacion
                             where q.IdUbicacion==info.IdUbicacion && q.Estado == "A"
                             select q;

                if (select.ToList().Count > 0)
                {
                    using (EntitiesGeneral context = new EntitiesGeneral())
                    {
                        var contact = context.tb_ubicacion.First(obj => obj.IdUbicacion==info.IdUbicacion);
                        contact.IdUsuarioUltAnu = info.IdUsuarioUltAnu;
                        contact.Fecha_UltAnu = info.Fecha_UltAnu;
                        contact.ub_posicion = info.ub_posicion;
                        contact.nom_pc = info.nom_pc;
                        contact.ip = info.ip;
                        contact.Estado ="I";      
                        context.SaveChanges();
                        msg = "Se ha procedido anular el registro de la ubicación #: " + info.IdUbicacion.ToString() + " para la ubicación: " + info.ub_descripcion + " exitosamente";
                    }

                    return true;
                }
                else
                {
                    msg = "No es posible anular el registro de la ubicación #: " + info.IdUbicacion.ToString() + " debido a que ya se encuentra anulado.";
                    return false;
                }
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

        public tb_ubicacion_Info Get_Info_Ubicacion(string idUbicacion)
        {
            try
            {
                EntitiesGeneral OEUbicacion = new EntitiesGeneral();

                var select_ubicacion = from A in OEUbicacion.tb_ubicacion
                                       where A.IdUbicacion==idUbicacion
                                       select A;
                tb_ubicacion_Info info = new tb_ubicacion_Info();
                foreach (var item in select_ubicacion)
                {

                    info.IdUbicacion = item.IdUbicacion.Trim();
                    info.IdUbicacion_Padre = item.IdUbicacion_Padre.Trim();
                    info.ub_descripcion = item.ub_descripcion.Trim();
                    info.ub_nivel = item.ub_nivel;
                    info.ub_posicion = item.ub_posicion;
                    info.Estado = item.Estado;
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

        public tb_ubicacion_Data() { }
    }
}
