using Core.Erp.Info.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Data.General;


namespace Core.Erp.Data.General
{
    public class tb_sis_Log_Error_Vzen_Data
    {
        string mensaje = "";
        public Boolean Guardar_Log_Error(tb_sis_Log_Error_Vzen_Info Item, ref string mensaje)
        {
            try
            {
                using (EntitiesGeneral Context = new EntitiesGeneral())
                {
                    tb_sis_Log_Error_Vzen Cabe = new tb_sis_Log_Error_Vzen();

                    Cabe.Fecha_Trans = Item.Fecha_Trans;
                    Cabe.Detalle = Item.Detalle;
                    Cabe.Tipo = Item.Tipo;
                    Cabe.Clase = Item.Clase;
                    Cabe.Pantalla = Item.Pantalla;
                    Cabe.Asamble = Item.Asamble;
                    Cabe.Usuario = Item.Usuario;
                    Cabe.Ip = Item.Ip;
                    Cabe.PC = Item.PC;

                    Context.tb_sis_Log_Error_Vzen.Add(Cabe);
                    Context.SaveChanges();
                }

                return true;
            }
            catch (Exception ex)
            {
                mensaje = ex.ToString() + " " + ex.Message;
                return false;
            }
        }


        public void Log_Error(string msg, string IdUsuario, string ip, string nom_pc, DateTime Fecha_Trans)
        {
            try
            {
                string arreglo = ToString();
                var palabras = arreglo.Split(',');
                string clase = "";
                string pantalla = "";
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(msg, "", clase = palabras[0], pantalla = palabras[1],
                    "", IdUsuario, ip, nom_pc, Fecha_Trans);
                string mensaje = "";

                //llamado a la función de grabado de log
                Guardar_Log_Error(Log_Error_sis, ref mensaje);
            }
            catch (Exception ex)
            {
                mensaje = ex.ToString() + " " + ex.Message;
            }
        }



        public List<tb_sis_Log_Error_Vzen_Info> Get_List_Log_Error_Vzen()
        {
            try
            {
                List<tb_sis_Log_Error_Vzen_Info> lM = new List<tb_sis_Log_Error_Vzen_Info>();
                EntitiesGeneral OEselecEmpresa = new EntitiesGeneral();

                var selectEmpresa = from C in OEselecEmpresa.tb_sis_Log_Error_Vzen
                                    orderby C.Id descending
                                    select C;

                foreach (var item in selectEmpresa)
                {
                    tb_sis_Log_Error_Vzen_Info Cbt = new tb_sis_Log_Error_Vzen_Info();
                    Cbt.Asamble = item.Asamble;
                    Cbt.Clase = item.Clase;
                    Cbt.Detalle = item.Detalle;
                    Cbt.Fecha_Trans = item.Fecha_Trans;
                    Cbt.Ip = item.Ip;
                    Cbt.Pantalla = item.Pantalla;
                    Cbt.PC = item.PC;
                    Cbt.Tipo = item.Tipo;
                    Cbt.Usuario = item.Usuario;
                    Cbt.Id = item.Id;

                    lM.Add(Cbt);
                }

                return (lM);
            }

            catch (Exception ex)
            {
                string arreglo = ToString();
                //tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                //tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                //                    "", "", "", "", DateTime.Now);
                //oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                //mensaje = ex.InnerException + " " + ex.Message;
                return new List<tb_sis_Log_Error_Vzen_Info>();
            }
        }

        public tb_sis_Log_Error_Vzen_Data()
        {

        }
    }
}
