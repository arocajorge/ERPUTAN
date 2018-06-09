using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Bancos;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.Bancos
{
    public class ba_Config_Diseno_Cheque_Data
    {
        string mensaje = "";
        public Boolean GrabarDB(ba_Config_Diseno_Cheque_Info Cheque_I, ref string mensaje) 
        {
            try
            {
                using (EntitiesBanco Contex = new EntitiesBanco())
                {

                    string q = "delete ba_Config_Diseno_Cheque where IdEmpresa = {0} and IdBanco = {1}";
                    string qy = string.Format(q, Cheque_I.idEmpresa, Cheque_I.idBanco);
                    Contex.Database.ExecuteSqlCommand(qy);

                    EntitiesBanco EDChueqe = new EntitiesBanco();
                    //var contac = ba_Config_Diseno_Cheque.Createba_Config_Diseno_Cheque(0,0,0,0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
                    var address = new ba_Config_Diseno_Cheque();
                    address.IdEmpresa = Cheque_I.idEmpresa;
                    address.IdBanco = Cheque_I.idBanco;
                    address.Area_Imprimir_X = Cheque_I.Area_Imprimir_X;
                    address.Area_Imprimir_Y = Cheque_I.Area_Imprimir_Y;
                    address.Tama_Cheque_X = Cheque_I.Tama_Cheque_X;
                    address.Tama_Cheque_Y = Cheque_I.Tama_Cheque_Y;
                    address.PagueseA_X = Cheque_I.PagueseA_X;
                    address.PagueseA_Y = Cheque_I.PagueseA_Y;
                    address.ValorCheque_X = Cheque_I.ValorCheque_X;
                    address.ValorCheque_Y = Cheque_I.ValorCheque_Y;
                    address.ValorLetra_Cheque_X = Cheque_I.ValorLetra_Cheque_X;
                    address.ValorLetra_Cheque_Y = Cheque_I.ValorLetra_Cheque_Y;
                    address.Fecha_X = Cheque_I.Fecha_X;
                    address.Fecha_Y = Cheque_I.Fecha_Y;
                    address.Nom_Impresora = Cheque_I.Nom_Impresora;
                    address.Pto_Impresora = Cheque_I.Pto_Impresora;
                    //contac = address;
                    Contex.ba_Config_Diseno_Cheque.Add(address);
                    Contex.SaveChanges();
                    mensaje = "Grabado Ok";

                } return true;
            }
            catch (Exception ex )
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
        public ba_Config_Diseno_Cheque_Info Get_List_Config_Diseno_Cheque(ba_Banco_Cuenta_Info Cheque_I)
        {

            try
            {
                ba_Config_Diseno_Cheque_Info cf ; 
                using (EntitiesBanco OEBan = new EntitiesBanco())
                {
                    var q = from t in OEBan.ba_Config_Diseno_Cheque
                            where t.IdBanco == Cheque_I.IdBanco && t.IdEmpresa == Cheque_I.IdEmpresa
                            select t;
                    foreach (var item in q)
                    {
                        cf = new ba_Config_Diseno_Cheque_Info();
                        cf.Area_Imprimir_X = item.Area_Imprimir_X;
                        cf.Area_Imprimir_Y = item.Area_Imprimir_Y;
                        cf.Fecha_X = item.Fecha_X;
                        cf.Fecha_Y = item.Fecha_Y;
                        cf.idBanco = item.IdBanco;
                        cf.idEmpresa = item.IdEmpresa;
                        cf.PagueseA_X = item.PagueseA_X;
                        cf.PagueseA_Y = item.PagueseA_Y;
                        cf.Tama_Cheque_X = item.Tama_Cheque_X;
                        cf.Tama_Cheque_Y = item.Tama_Cheque_Y;
                        cf.ValorCheque_X = item.ValorCheque_X;
                        cf.ValorCheque_Y = item.ValorCheque_Y;
                        cf.ValorLetra_Cheque_X = item.ValorLetra_Cheque_X;
                        cf.ValorLetra_Cheque_Y = item.ValorLetra_Cheque_Y;
                        cf.Pto_Impresora = item.Pto_Impresora;
                        cf.Nom_Impresora = item.Nom_Impresora;
                        return cf;
                    }
                   
                }

                return new ba_Config_Diseno_Cheque_Info();
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
        public Boolean Actualizar(ba_Config_Diseno_Cheque_Info Cheque_I, ref string mensaje) 
        {
            Boolean res = false;
            try
            {
                using (EntitiesBanco Contex = new EntitiesBanco())
                {
                    var contact = Contex.ba_Config_Diseno_Cheque.FirstOrDefault(vConf => vConf.IdEmpresa == Cheque_I.idEmpresa && vConf.IdBanco == Cheque_I.idBanco);
                    if (contact != null)
                    {
                        contact.Area_Imprimir_X = Cheque_I.Area_Imprimir_X;
                        contact.Area_Imprimir_Y = Cheque_I.Area_Imprimir_Y;
                        contact.Fecha_X = Cheque_I.Fecha_X;
                        contact.Fecha_Y = Cheque_I.Fecha_Y;
                        contact.PagueseA_X = Cheque_I.PagueseA_X;
                        contact.PagueseA_Y = Cheque_I.PagueseA_Y;
                        contact.Tama_Cheque_X = Cheque_I.Tama_Cheque_X;
                        contact.Tama_Cheque_Y = Cheque_I.Tama_Cheque_Y;
                        contact.ValorCheque_X = Cheque_I.ValorCheque_X;
                        contact.ValorCheque_Y = Cheque_I.ValorCheque_Y;
                        contact.ValorLetra_Cheque_X = Cheque_I.ValorLetra_Cheque_X;
                        contact.ValorLetra_Cheque_Y = Cheque_I.ValorLetra_Cheque_Y;
                        Contex.SaveChanges();
                        res = true;
                    }
                }
                return res;
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
    }
}
/// <summary>
/// Prog: Katiuska Franco
/// Ult Mod: 26/02/2014  12:09
/// LIN 132
/// </summary>