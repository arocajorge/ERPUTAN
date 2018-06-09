using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.Roles.Archivos_para_Bancos;

namespace Core.Erp.Business.Roles.Archivos_para_Bancos
{
    public class ro_Solicitud_Tarjeta_Guayaquil_Bus
    {
        public Boolean Generar_Solicitud_Tarjeta_Banco_Guayaquil(List<ro_Solicitud_Tarjeta_Guayaquil_Info> Lista, string patch, string NombreArchivo)
        {
            try
            {
                int i = 0;
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(patch + NombreArchivo + ".txt", true))
                {
                    foreach (var item in Lista)
                    {
                        string linea = "";
                        i++;
                        if (i == 1)
                        {
                            linea += item.TipoRegistro;
                            linea += item.CodigoEmpresa;
                            linea += item.CodigoEmpleado;
                            linea += item.Nombre;
                            linea += item.CobroServicio;
                            linea += item.Monto;
                            linea += item.Fecha;
                        }
                        else
                        {
                            linea += item.TipoRegistro;
                            linea += item.CodigoEmpresa;
                            linea += item.CodigoEmpleado;
                            linea += item.Nombre;
                            linea += item.CobroServicio;
                            linea += item.Filler;
                            linea += item.CodigoProceso;
                            linea += item.Monto;
                        }
                        file.WriteLine(linea);
                    }
                    file.Close();
                }
                return true;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Pagos_x_Archivos", ex.Message), ex) { EntityType = typeof(ro_Solicitud_Tarjeta_Guayaquil_Bus) };
            }
        }

        public Boolean Grabar_Solicitud_Tarjeta_Banco_Guayaquil(ro_Solicitud_Tarjeta_Guayaquil_Info Info)
        {
            try
            {

                return true;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Pagos_x_Archivos", ex.Message), ex) { EntityType = typeof(ro_Solicitud_Tarjeta_Guayaquil_Bus) };
            }
        }


        //public Boolean Generar_archivo_pago_Banco_Guayaquil(ro_Solicitud_Tarjeta_Guayaquil_Info info, string patch, string nombre_File)
        //{
        //    try
        //    {
                
        //        return true;
        //    }
        //    catch (Exception ex)
        //    {
        //        Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
        //        throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Generar_archivo", ex.Message), ex) { EntityType = typeof(cp_Archivo_Banco_Pichincha_Pago_Bus) };
        //    }
        //}
    }
}
