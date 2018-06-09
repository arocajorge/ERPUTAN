using Core.Erp.Data.General;
using Core.Erp.Info.Facturacion;
using Core.Erp.Info.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Data.Facturacion
{
    public class fa_cliente_contacto_Data
    {

        public int getId(int IdEmpresa)
        {
            int Id = 0;
            try
            {
                EntitiesFacturacion conexion = new EntitiesFacturacion();
                int select = (from q in conexion.fa_cliente_contactos
                              where q.IdEmpresa_cli == IdEmpresa
                              select q).Count();

                if (select == 0)
                {
                    Id = 1;
                }
                else
                {
                    var select_as = (from q in conexion.fa_cliente_contactos
                                     where q.IdEmpresa_cli == IdEmpresa
                                     select q.IdCliente).Max();
                    Id = Convert.ToInt32(select_as.ToString()) + 1;
                }
                return Id;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                string MensajeError = string.Empty;
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                MensajeError = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                throw new Exception(ex.InnerException.ToString());
            }

        }
        string Mensaje = "";
        public Boolean Guardar(fa_cliente_contacto_Info Info, ref string mensaje)
        {
            try
            {
                EntitiesFacturacion conexion = new EntitiesFacturacion();
                {
                    fa_cliente_contactos Base = new fa_cliente_contactos();
                    Base.IdCliente = getId(Info.IdEmpresa_cli);
                    Base.IdEmpresa_cli = Info.IdEmpresa_cli;
                    Base.IdEmpresa_cont = Info.IdEmpresa_cont;
                    Base.IdContacto = Info.IdContacto;
                    Base.observacion = Info.observacion;

                    conexion.fa_cliente_contactos.Add(Base);
                    conexion.SaveChanges();
                    mensaje = "Se ha grabado el Cliente: " + Info.IdCliente.ToString() + " exitosamente.";                    
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref Mensaje);
                Mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }
        public bool ExisteCliente(int IdEmpresa, decimal idCliente, decimal idcontacto, ref string mensaje)
        {
            try
            {
                using (EntitiesFacturacion conexion = new EntitiesFacturacion())
                {
                    if (idCliente == 0)
                    {

                        var cliente = conexion.fa_cliente_contactos.First(p => p.IdEmpresa_cli == IdEmpresa && p.IdContacto == idcontacto);
                        if (cliente.IdContacto == idcontacto)
                        {
                            mensaje = "El Cliente ya se encuentra ingresado.";
                            return true;
                        }
                        else { return false; }
                    }
                    else
                    {
                        int existe = (from e in conexion.fa_cliente_contactos
                                      where e.IdEmpresa_cli == IdEmpresa
                                      && e.IdCliente == idCliente
                                      select e).Count();

                        if (existe != 0)
                        {
                            mensaje = "El cliente ya se encuentra ingresado.";
                            return true;
                        }
                        else { return false; }
                    }
                }
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                string MensajeError = string.Empty;
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                MensajeError = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                throw new Exception(ex.ToString());
            }
        }
    }
}
