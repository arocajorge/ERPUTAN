using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.Inventario;
using Core.Erp.Data.General;
using Core.Erp.Info.General;


namespace Core.Erp.Data.Inventario
{
   public class in_presentacion_Data
    {

       string mensaje = "";

       public List<in_presentacion_Info> Get_List_presentacion(int IdEmpresa)
        {
            List<in_presentacion_Info> lista = new List<in_presentacion_Info>();
            EntitiesInventario oEnt = new EntitiesInventario();
            try
            {
                var select = from q in oEnt.in_presentacion
                             where q.IdEmpresa == IdEmpresa
                             select q;

                foreach (var item in select)
                {
                    in_presentacion_Info info = new in_presentacion_Info();


                    info.IdEmpresa = item.IdEmpresa;
                    info.IdPresentacion = item.IdPresentacion;
                    info.nom_presentacion = item.nom_presentacion;
                    info.estado = item.estado;
                    
                    lista.Add(info);
                }


                return lista;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public Boolean EliminarDB(in_presentacion_Info info)
        {
            try
            {
                using (EntitiesInventario context = new EntitiesInventario())
                {
                    var contact = context.in_presentacion.FirstOrDefault(catalogo => catalogo.IdEmpresa == info.IdEmpresa && catalogo.IdPresentacion == info.IdPresentacion);
                    if (contact != null)
                    {
                        contact.estado = "I";
                        context.SaveChanges();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public Boolean GuardarDB(in_presentacion_Info info, ref string Mensaje)
        {
            try
            {
                using (EntitiesInventario oEnti = new EntitiesInventario())
                {

                    var  Q = from per in oEnti.in_presentacion
                            where per.IdEmpresa == info.IdEmpresa
                            && per.IdPresentacion == info.IdPresentacion
                            select per;

                    if (Q.ToList().Count == 0)
                    {
                              var  registo = new in_presentacion();

                            registo.IdEmpresa = info.IdEmpresa;
                            registo.IdPresentacion = (info.IdPresentacion == "" || info.IdPresentacion == null) ? Convert.ToString(GetId(info.IdEmpresa)) : info.IdPresentacion;
                            registo.nom_presentacion = info.nom_presentacion.Trim();
                            registo.estado = "A";


                            oEnti.in_presentacion.Add(registo);
                            oEnti.SaveChanges();
                            Mensaje = "Registro Ingresado Correctamente";
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
                Mensaje = "Error al ingresar el registro ";
                throw new Exception(ex.ToString());
            }
        }

        public Boolean ModificarDB(in_presentacion_Info info)
        {
            try
            {
                using (EntitiesInventario oEnti = new EntitiesInventario())
                {
                    var registro = oEnti.in_presentacion.FirstOrDefault(cata => cata.IdEmpresa == info.IdEmpresa && cata.IdPresentacion == info.IdPresentacion);
                    if (registro != null)
                    {
                        registro.nom_presentacion = info.nom_presentacion;
                        registro.estado = info.estado;
                        //registro.IdUsuarioUltMod = info.IdUsuarioUltMod;
                        //registro.FechaUltMod = info.FechaUltMod;
                        oEnti.SaveChanges();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public decimal GetId(int IdEmpresa)
        {
            try
            {
                decimal Id;
                EntitiesInventario OECbtecble = new EntitiesInventario();
                var q = from A in OECbtecble.in_presentacion
                        where A.IdEmpresa == IdEmpresa
                        select A;

                if (q.ToList().Count < 1)
                {
                    Id = 1;
                }
                else
                {
                    OECbtecble = new EntitiesInventario();
                    var selectCbtecble = (from CbtCble in OECbtecble.in_presentacion
                                          where CbtCble.IdEmpresa == IdEmpresa
                                          select CbtCble.IdPresentacion).Count();

                    Id = Convert.ToDecimal(selectCbtecble.ToString()) + 1;
                }
                return Id;

            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

    }
}
