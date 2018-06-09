using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Produc_Cirdesus;
using Core.Erp.Info.General;
using Core.Erp.Data.General;


namespace Core.Erp.Data.Produc_Cirdesus
{
  public  class prd_Operador_Data
    {
        tb_sis_Log_Error_Vzen_Data oLog = new tb_sis_Log_Error_Vzen_Data();
        string mensaje = "";
        prd_Obra_Data data = new prd_Obra_Data();

        public Boolean GuardarDB(prd_Operador_Info info, ref string msg)
        {
            try
            {
                using (EntitiesProduccion Context = new EntitiesProduccion())
                {
                    prod_Operador Address = new prod_Operador();

                    Address.IdOperador = info.IdOperador;
                    Address.IdEmpleado = info.IdEmpleado;
                    Address.NomEmpleado = info.NomEmpleado;
                    Address.IdUsuario = info.IdUsuario;
                    Address.Fecha_Transac = DateTime.Now;
                    Address.IdUsuarioUltMod = info.IdUsuarioUltMod;
                    Address.Fecha_UltMod = null;
                    Address.IdUsuarioUltAnu = info.IdUsuarioUltAnu;
                    Address.Fecha_UltAnu = null;
                    Address.nom_pc = info.nom_pc;


                    Address.ip = info.ip;
                    Address.MotiAnula = info.MotiAnula;
                    Address.Estado = info.Estado;

                    Context.prod_Operador.Add(Address);
                    Context.SaveChanges();

                }
                msg = "Grabación exitosa..";
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                msg = ex.ToString() + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref msg);
                throw new Exception(ex.ToString());
            }
        }

        public List<prd_Operador_Info> ListadoOperadores()
        {
            try
            {
                List<prd_Operador_Info> ListadoOperadores = new List<prd_Operador_Info>();
                EntitiesProduccion OEEtapa = new EntitiesProduccion();
                var registros = from A in OEEtapa.prod_Operador           
                                select A;
                prd_Operador_Info info = new prd_Operador_Info();
                foreach (var item in registros)
                {
                    info = new prd_Operador_Info();
                    info.IdOperador = item.IdOperador;
                    info.IdEmpleado = item.IdEmpleado;
                    info.NomEmpleado = item.NomEmpleado;
                    info.IdUsuario = item.IdUsuario;
                    info.Fecha_Transac = item.Fecha_Transac;
                    info.IdUsuarioUltMod = item.IdUsuarioUltMod;
                    info.Fecha_UltMod =Convert.ToDateTime( item.Fecha_UltMod);
                    info.IdUsuarioUltAnu = item.IdUsuarioUltAnu;
                    info.Fecha_UltAnu =Convert.ToDateTime( item.Fecha_UltAnu);
                    info.nom_pc = item.nom_pc;
                    info.ip = item.ip;
                    info.MotiAnula = item.MotiAnula;
                    info.Estado = item.Estado;
                    ListadoOperadores.Add(info);
                }
                return ListadoOperadores;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString() + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        }

        public Boolean ModificarDB(prd_Operador_Info info, ref string msg)
        {
            try
            {
                using (EntitiesProduccion context = new EntitiesProduccion())
                {
                    var Address = context.prod_Operador.FirstOrDefault(A => A.IdOperador == info.IdOperador && A.IdEmpleado == info.IdEmpleado);
                    if (Address != null)
                    {
                        Address.IdOperador = info.IdOperador;
                        Address.IdEmpleado = info.IdEmpleado;
                        Address.NomEmpleado = info.NomEmpleado;
                        Address.IdUsuario = info.IdUsuario;
                        Address.Fecha_Transac = info.Fecha_Transac;
                        Address.IdUsuarioUltMod = info.IdUsuario;
                        Address.Fecha_UltMod = DateTime.Now;
                        Address.IdUsuarioUltAnu = info.IdUsuarioUltAnu;
                        Address.Fecha_UltAnu = null;
                        Address.nom_pc = info.nom_pc;
                        Address.ip = info.ip;
                        Address.MotiAnula = info.MotiAnula;
                        Address.Estado = info.Estado;
                        // Context.prod_Operador.Add(Address);
                        context.SaveChanges();
                    }
                }
                // msg = "Se ha procedido actualizar el registro de la Orden de Taller #: " + info.Codigo + " exitosamente";
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                msg = ex.ToString() + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref msg);
                throw new Exception(ex.ToString());
            }
        }

        public int GedId(ref string mensaje)
        {
            int Id = 0; 
            try
            {
                EntitiesProduccion OEProduccion = new EntitiesProduccion();
                var select = from q in OEProduccion.prod_Operador
                             select q;

                if (select.ToList().Count < 1)
                {
                    Id = 1;
                }
                else
                {
                    var select_pv = (from q in OEProduccion.prod_Operador
                                     
                                     select q.IdOperador).Max();
                    Id = Convert.ToInt32(select_pv.ToString()) + 1;
                }
                return Id;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString() + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }

        }

        public Boolean AnularDB(prd_Operador_Info info, ref string msg)
        {
            try
            {
                using (EntitiesProduccion context = new EntitiesProduccion())
                {
                    var Address = context.prod_Operador.FirstOrDefault(A => A.IdOperador == info.IdOperador && A.IdEmpleado == info.IdEmpleado);
                    if (Address != null)
                    {
                        Address.Estado = info.Estado;
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
                msg = ex.ToString() + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref msg);
                throw new Exception(ex.ToString());
            }
        }
    }
}
