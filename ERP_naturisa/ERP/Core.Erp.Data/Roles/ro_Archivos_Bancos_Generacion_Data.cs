
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Core.Erp.Info.Roles;
using Core.Erp.Info.General;
using Core.Erp.Data.General;
namespace Core.Erp.Data.Roles
{
    public class ro_Archivos_Bancos_Generacion_Data
    {
        string mensaje = "";

        public decimal GetIdArchivo()
        {
            try
            {
               int Id;
                EntitiesRoles OECbtecble = new EntitiesRoles();

                var q = from C in OECbtecble.ro_archivos_bancos_generacion
                        //  where C.IdEmpresa == idempresa //&& C.IdEmpleado == idEmpleado
                        select C;
                if (q.ToList().Count == 0)
                    return 1;
                else
                {
                    var select_ = (from t in OECbtecble.ro_archivos_bancos_generacion
                                   select t.IdArchivo).Max();
                    Id = Convert.ToInt32(select_.ToString()) + 1;
                    return Id;
                }
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
        
        public Boolean GrabarBD(ro_Archivos_Bancos_Generacion_Info Item, ref decimal Id, ref string mensaje)
        {
            try
            {
                using (EntitiesRoles Context = new EntitiesRoles())
                {
                    ro_archivos_bancos_generacion Transf = new ro_archivos_bancos_generacion();

                    Transf.IdEmpresa = Item.IdEmpresa;
                    Transf.IdArchivo = Id = GetIdArchivo();
                    Transf.IdNomina = Item.IdNomina;
                    Transf.IdNominaTipo = Item.IdNominaTipo;
                    Transf.IdPeriodo = Item.IdPeriodo;
                    Transf.IdBanco = Item.IdBanco;

                    if(Item.IdDivision!=0)
                      Transf.IdDivision = Item.IdDivision ;
                    Transf.archivo = Item.Archivo;
                    Transf.Nom_Archivo = Item.Nom_Archivo;
                    Transf.Cod_Empresa = Item.Cod_Empresa;
                    Transf.Fecha_Transac = Convert.ToDateTime(Item.Fecha_Genera);
                    Transf.IdUsuario = Item.UsuarioIngresa;
                    Transf.estado = "A";
                    Transf.IdBanco_Acredita = Item.IdBanco_Acredita;
                    Transf.IdProceso_Bancario = Item.IdProceso_Bancario;
                    Context.ro_archivos_bancos_generacion.Add(Transf);
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

        public List<ro_Archivos_Bancos_Generacion_Info> Get_List_Archivos_Bancos_Generacion(int IdEmpresa,DateTime FechaInicio,DateTime Fecha_Fin)
        {
                   List<ro_Archivos_Bancos_Generacion_Info> lM = new List<ro_Archivos_Bancos_Generacion_Info>();
            try
            {
                using (EntitiesRoles oen = new EntitiesRoles())
                {
                    DateTime Fecha_I = Convert.ToDateTime(FechaInicio.ToShortDateString());
                    DateTime Fecha_F = Convert.ToDateTime(Fecha_Fin.ToShortDateString());

                    EntitiesRoles OEPeriodo = new EntitiesRoles();

                    var selectPeriodo = from C in OEPeriodo.vwRo_Archivos_Bancos_Generacion
                                        where C.IdEmpresa == IdEmpresa
                                        where C.pe_FechaIni>=Fecha_I
                                        && C.pe_FechaIni <= Fecha_Fin
                                        select C;
                    foreach (var item in selectPeriodo)
                    {
                        ro_Archivos_Bancos_Generacion_Info Cbt = new ro_Archivos_Bancos_Generacion_Info();
                        Cbt.IdEmpresa = IdEmpresa;
                         Cbt.IdArchivo = item.IdArchivo;
                         Cbt.IdNomina = item.IdNomina;
                         Cbt.IdNominaTipo = item.IdNominaTipo;
                         Cbt.IdPeriodo = item.IdPeriodo;
                         Cbt.IdDivision=Convert.ToInt32(item.IdDivision);
                         Cbt.Cod_Empresa = item.Cod_Empresa;
                         Cbt.Nom_Archivo=item.Nom_Archivo;
                         Cbt.Archivo=item.archivo;
                         Cbt.Fecha_Genera=item.Fecha_Transac;
                         Cbt.ba_descripcion = item.ba_descripcion;
                         Cbt.IdBanco = item.IdBanco;
                         Cbt.IdBanco_Acredita = item.IdBanco_Acredita;
                         Cbt.IdProceso_Bancario = item.IdProceso_Bancario;
                        //campos vista
                        Cbt.Descripcion=item.Descripcion;
                        Cbt.DescripcionProcesoNomina=item.DescripcionProcesoNomina;
                        Cbt.Descripcion_Division=item.Descripcion_Division;
                        
                                                                                  
                        Cbt.pe_FechaIni=item.pe_FechaIni;
                        Cbt.pe_FechaFin=item.pe_FechaFin;
                        Cbt.Periodo = item.pe_FechaIni.ToShortDateString().ToString().Substring(0, 10)+" al "+item.pe_FechaFin.ToShortDateString().ToString().Substring(0, 10);
                        Cbt.fecha_Descripcion = item.pe_FechaIni + " - " + item.pe_FechaFin;

                       Cbt.FechaIngresa =Convert.ToDateTime( item.Fecha_Transac);
                       Cbt.UsuarioIngresa = item.IdUsuario;
                       Cbt.Estado = item.estado;
                       Cbt.MotivoAnulacion = item.MotiAnula;
                       Cbt.Valor = item.Valor;
                       lM.Add(Cbt);

                    }
                    return (lM);
                }

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
        }//haac 02/12/13

        public Boolean GetExiste(ro_Archivos_Bancos_Generacion_Info info, ref string msg)
        {
            try
            {
                Boolean valorRetornar = false;
                using (EntitiesRoles db = new EntitiesRoles())
                {
                    int cont = (from a in db.ro_archivos_bancos_generacion
                                where a.IdEmpresa == info.IdEmpresa && a.IdArchivo == info.IdArchivo
                                select a).Count();

                    if (cont > 0) { valorRetornar = true; }
                    else { valorRetornar = false; }
                }
                return valorRetornar;
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

        public Boolean ModificarBD(ro_Archivos_Bancos_Generacion_Info Item,  ref string mensaje)
        {
            try
            {
                using (EntitiesRoles db = new EntitiesRoles())
                {
                    var Transf = db.ro_archivos_bancos_generacion.First(obj => obj.IdArchivo == Item.IdArchivo && obj.IdEmpresa == Item.IdEmpresa);                          
                    Transf.IdNomina = Item.IdNomina;
                    Transf.IdNominaTipo = Item.IdNominaTipo;
                    Transf.IdPeriodo = Item.IdPeriodo;
                    Transf.IdBanco = Item.IdBanco;
                    Transf.IdDivision = Item.IdDivision;
                    Transf.archivo = Item.Archivo;
                    Transf.Nom_Archivo = Item.Nom_Archivo;
                    Transf.Cod_Empresa = Item.Cod_Empresa;
                    Transf.Fecha_UltMod = Item.FechaModifica;
                    Transf.IdUsuarioUltMod = Item.UsuarioModifica;
                    Transf.IdBanco_Acredita = Item.IdBanco_Acredita;
                    Transf.IdProceso_Bancario = Item.IdProceso_Bancario;
                    db.SaveChanges();
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
