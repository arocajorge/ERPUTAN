using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Core.Erp.Info.General;
using Core.Erp.Data.General;
//using Core.Erp.Business.Datasets;


namespace Core.Erp.Data.General
{
    public class Tabla_Data
    {
        string mensaje = "";
        public List<Tabla_Info> ObtenerTabla()
        {
            try
            {

                List<Tabla_Info> lM = new List<Tabla_Info>();
                EntitiesGeneral Otabla = new EntitiesGeneral();


                var selecttable = from A in Otabla.tb_Tabla
                                       select A;



                foreach (var item in selecttable)
                {
                    Tabla_Info t = new Tabla_Info();
                    t.IdTabla = item.IdTabla;
                    t.Nombre = item.Nombre;
                    t.IdModulo = Convert.ToInt32( item.IdModulo);
                    t.TablaDB = item.TablaDB;
                    t.NameControl = item.NameControl;
                    lM.Add(t);
                }

                return (lM);
            }

            catch (Exception  ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }


        public DataTable ObtenerTablaDT()
        {
            try
            {
            
                
                //DataTable dttabla = new DataSetGeneral.tb_TablaDataTable();
                DataTable dttabla= new DataTable();

            return (dttabla);
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                        "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                 mensaje = ex.InnerException + " " + ex.Message;
                 throw new Exception(ex.InnerException.ToString());
            }
        }

        public Tabla_Data() { }
    }
}
