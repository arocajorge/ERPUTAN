using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.Roles_Fj;
using Core.Erp.Data.General;
using Core.Erp.Info.General;
namespace Core.Erp.Data.Roles_Fj
{
    public class ro_marcaciones_x_empleado_x_incidentes_falt_Perm_Data
    {
        string MensajeError = "";
        tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
        public bool Grabar_DB( ro_marcaciones_x_empleado_x_incidentes_falt_Perm_Info info)
        {
            try
            {
                using (EntityRoles_FJ db= new EntityRoles_FJ())
                {
                    ro_marcaciones_x_empleado_x_incidentes_falt_Perm add = new ro_marcaciones_x_empleado_x_incidentes_falt_Perm();

                    add.IdEmpresa = info.IdEmpresa;
                    add.IdNomina_Tipo = info.IdNomina_Tipo;
                    add.IdEmpleado = info.IdEmpleado;
                    add.IdRegistro = info.IdRegistro;
                    if(info.IdTurno==0 ||info.IdTurno==null)
                    add.IdTurno =1;
                    else
                        add.IdTurno = info.IdTurno;

                    add.es_fecha_registro = info.es_fecha_registro;
                    add.Id_catalogo_Cat = info.Id_catalogo_Cat;
                    add.es_jornada_desfasada = info.es_jornada_desfasada;
                    if (info.IdSala == 0)
                        add.IdSala = null;
                    else
                        add.IdSala = info.IdSala;
                    if (info.IdRuta == 0)
                        add.IdRuta = null;
                    else
                        add.IdRuta = info.IdRuta;
                    if (info.IdDisco == 0)
                        add.IdDisco = null;
                    else
                        add.IdDisco = info.IdDisco;
                    add.Observacion = "";

                    db.ro_marcaciones_x_empleado_x_incidentes_falt_Perm.Add(add);
                    db.SaveChanges();
                }

                return true;
            }
            catch (Exception ex)
            {

                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }



        public List<ro_marcaciones_x_empleado_x_incidentes_falt_Perm_Info> lista_atrasos_faltas_x_empleado(int IdEmpresa, DateTime Fecha_Inicio, DateTime FechaFin)
        {
            try
            {
                List<ro_marcaciones_x_empleado_x_incidentes_falt_Perm_Info> lista = new List<ro_marcaciones_x_empleado_x_incidentes_falt_Perm_Info>();
                using (EntityRoles_FJ db = new EntityRoles_FJ())
                {
                    var query = from q in db.vwro_marcaciones_x_empleado_x_incidentes_falt_Perm
                                where q.IdEmpresa == IdEmpresa
                                && q.es_fechaRegistro >= Fecha_Inicio
                                && q.es_fechaRegistro <= FechaFin
                                select q;
                    foreach (var item in query)
                    {
                    ro_marcaciones_x_empleado_x_incidentes_falt_Perm_Info add = new ro_marcaciones_x_empleado_x_incidentes_falt_Perm_Info();
                    add.IdEmpresa = item.IdEmpresa;
                    add.IdEmpleado = item.IdEmpleado;
                    add.IdRegistro = item.IdRegistro;
                    add.es_fecha_registro =Convert.ToDateTime(item.es_fechaRegistro);
                    add.Id_catalogo_Cat = item.Id_catalogo_Cat;
                    add.Observacion = "";
                    add.de_descripcion = item.de_descripcion;
                    add.ca_descripcion = item.ca_descripcion;
                    add.pe_nombre = item.pe_nombre;
                    add.pe_apellido = item.pe_apellido;
                    add.pe_cedulaRuc = item.pe_cedulaRuc;
                    add.es_Hora = item.es_Hora;
                    if (item.Id_catalogo_Cat == "ATRA")
                    {
                        add.imagen = 1;
                    }
                    if (item.Id_catalogo_Cat == "PER")
                    {
                        add.imagen = 2;
                    }
                    lista.Add(add);
                    }
                }

                return lista;
            }
            catch (Exception ex)
            {

                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }
   
    
    
    }
}
