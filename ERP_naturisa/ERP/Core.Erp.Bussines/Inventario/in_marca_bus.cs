using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Inventario;
using Core.Erp.Data.Inventario;
using Core.Erp.Business.General;
using System.Data;

namespace Core.Erp.Business.Inventario
{

    public class in_marca_bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        cl_parametrosGenerales_Bus PARAM = cl_parametrosGenerales_Bus.Instance;

        public in_Marca_Info Get_Info_Marca(int IdMarca, int IdEmpresa)
        {
            try
            {
                in_marca_data mb = new in_marca_data();

                return mb.Get_Info_Marca(IdMarca, IdEmpresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "BuscarMarca", ex.Message), ex) { EntityType = typeof(in_marca_bus) };
            }
        }

        public List<in_Marca_Info> Get_list_Marca(int idEmpresa)
        {
            try
            {
                in_marca_data mb = new in_marca_data();

                return mb.Get_list_Marca(idEmpresa);

            }
            catch (Exception ex)
            {

                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Obtener_listMarca", ex.Message), ex) { EntityType = typeof(in_marca_bus) };
                ;
            }
        }

        public Boolean GrabarDB(in_Marca_Info prI, ref string mensaje)
        {


            try
            {

                in_marca_data marD = new in_marca_data();
                prI.IdUsuario = PARAM.IdUsuario;
                prI.Fecha_Transac = PARAM.Fecha_Transac;
                prI.nom_pc = PARAM.nom_pc;
                prI.ip = PARAM.ip;
                return marD.GrabarDB(prI, ref mensaje);



            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(in_marca_bus) };

            }




        }

        public Boolean ModificarDB(in_Marca_Info prI, ref string mensaje)
        {
            try
            {

                in_marca_data marD = new in_marca_data();
                prI.IdUsuarioUltMod = PARAM.IdUsuario;
                prI.Fecha_UltMod = PARAM.Fecha_Transac;
                prI.nom_pc = PARAM.nom_pc;
                prI.ip = PARAM.ip;
                return marD.ModificarDB(prI, ref mensaje);

            }
            catch (Exception ex)
            {

                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(in_marca_bus) };

            }




        }

        public Boolean AnularDB(in_Marca_Info info)
        {
            try
            {
                in_marca_data data = new in_marca_data();
                info.IdUsuarioUltAnu = PARAM.IdUsuario;
                info.Fecha_UltAnu = PARAM.Fecha_Transac;
                info.nom_pc = PARAM.nom_pc;
                info.ip = PARAM.ip;
                return data.AnularDB(info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Anular", ex.Message), ex) { EntityType = typeof(in_marca_bus) };
            }
        }

        public List<in_Marca_Info> ProcesarDataTablein_Marca_Info(DataTable ds, int IdEmpresa, ref string MensajeError)
        {
            List<in_Marca_Info> lista = new List<in_Marca_Info>();
            lista.Clear();
            try
            {
                //VALIDAR QUE TENGA MAS DE 2 COLUMNAS
                if (ds.Columns.Count <= 3)
                {
                    //RECORRE EL DATATABLE REGISTRO X REGISTRO
                    if (ds.Rows.Count > 0)
                    {
                        foreach (DataRow row in ds.Rows)
                        {
                            in_Marca_Info info = new in_Marca_Info();

                            info.IdEmpresa = IdEmpresa;
                            info.Estado = "A";

                            for (int col = 0; col < ds.Columns.Count + 1; col++)
                            {
                                switch (col)
                                {
                                    case 0://IdProducto
                                        info.IdMarca = Convert.ToInt32(row[col]);
                                        break;
                                    case 1://Codigo
                                        info.Descripcion = Convert.ToString(row[col]);
                                        break;
                                    default:
                                        break;
                                }
                            }
                            lista.Add(info);
                        }
                    }
                    else
                    {
                        MensajeError = "Por favor verifique que el archivo contenga Datos.";
                        lista = new List<in_Marca_Info>();
                    }
                }
                else
                {
                    MensajeError = "Por favor verifique que el archivo tenga el formato correcto.\r Son 2 columnas.";
                    lista = new List<in_Marca_Info>();
                }
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ProcesarDataTablein_Marca_Info", ex.Message), ex) { EntityType = typeof(in_marca_bus) };
            }
            return lista;
        }
    }
}
