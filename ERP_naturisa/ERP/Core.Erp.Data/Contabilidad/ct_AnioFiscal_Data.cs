using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.Contabilidad
{
    public class ct_AnioFiscal_Data
    {
        string mensaje = "";

       public  List<ct_AnioFiscal_Info> Get_list_AnioFiscal()
        {
            try
            {
           
            List<ct_AnioFiscal_Info> lM = new List<ct_AnioFiscal_Info>();
            EntitiesDBConta OEAnioFiscal = new EntitiesDBConta();                

            var selectanioFiscal = from A in OEAnioFiscal.ct_anio_fiscal
                                   select A;                               


             foreach (var item in selectanioFiscal)
             {
                 ct_AnioFiscal_Info aF = new ct_AnioFiscal_Info();
                 aF.IdanioFiscal = item.IdanioFiscal;
                 aF.af_fechaIni = Convert.ToDateTime(item.af_fechaIni);
                 aF.af_fechaFin = Convert.ToDateTime(item.af_fechaFin);
                 aF.af_estado = item.af_estado;
                 lM.Add(aF);
             }
                 return lM;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

       public Boolean ModificarDB(ct_AnioFiscal_Info aif, ref string msg)
       {
           try
           {
               Boolean res = false;
               using (EntitiesDBConta context = new EntitiesDBConta())
               {
                   var contact = context.ct_anio_fiscal.FirstOrDefault(vanio => vanio.IdanioFiscal == aif.IdanioFiscal);

                   if (contact != null)
                   {
                       contact.af_estado = aif.af_estado;
                       contact.af_fechaFin = aif.af_fechaFin;
                       contact.af_fechaIni = aif.af_fechaIni;
                       context.SaveChanges();
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
               mensaje = ex.ToString();
               msg = mensaje;
               throw new Exception(ex.ToString());
           }
       }

       public Boolean GrabarDB(ct_AnioFiscal_Info aif, ref string msg)
       {
           try
           {
               Boolean res = false;
               using (EntitiesDBConta context = new EntitiesDBConta())
               {
                   EntitiesDBConta EDB = new EntitiesDBConta();

                  

                   var Q = from per in EDB.ct_anio_fiscal
                           where per.IdanioFiscal == aif.IdanioFiscal
                           select per;
                   if (Q.ToList().Count == 0)
                   {

                       ct_anio_fiscal address = new ct_anio_fiscal();
                       address.IdanioFiscal = aif.IdanioFiscal;
                       address.af_fechaIni = aif.af_fechaIni;
                       address.af_fechaFin = aif.af_fechaFin;
                       address.af_estado = aif.af_estado;
                       context.ct_anio_fiscal.Add(address);
                       context.SaveChanges();
                       res = true;
                   }
                   else
                   {
                       msg = " ya existe el Año Fiscal ";
                       return res;
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
               mensaje = ex.ToString();
               msg = mensaje;
               throw new Exception(ex.ToString());
           }
       }

       public Boolean EliminarDB(ct_AnioFiscal_Info aif, ref string msg)
       {
           try
           {
               using (EntitiesDBConta context = new EntitiesDBConta())
               {
                   var contact = context.ct_anio_fiscal.FirstOrDefault(vanio => vanio.IdanioFiscal == aif.IdanioFiscal);
                   if (contact != null)
                   {
                       contact.af_estado = "I";
                       context.SaveChanges();
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
               mensaje = ex.ToString();
               msg = mensaje;
               throw new Exception(ex.ToString());
           }
       }

       public Boolean Get_Tiene_PeriodosxAnio(int IdEmpresa, int IdAnio, ref string msg)
       {
           try
           {
               EntitiesDBConta reg = new EntitiesDBConta();

               var q = from Periodo in reg.ct_periodo
                       where Periodo.IdEmpresa == IdEmpresa && Periodo.IdanioFiscal == IdAnio
                       select Periodo;

               if (q.ToList().Count > 0)
               {
                   msg = "No se puede eliminar el año fiscal, debido a que existen períodos";
                   return true;
               }
               else
               {
                   msg = "";
                   return false;
               }
           }
           catch (Exception ex)
           {
               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                   "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               mensaje = ex.ToString();

               msg = ex.Message;
               throw new Exception(ex.ToString());
           }
       }

       public ct_AnioFiscal_Info Get_Info_cuenta_utilidad_x_anio_fiscal(int IdEmpresa, int Anio)
       {
           try
           {

               List<ct_AnioFiscal_Info> lM = new List<ct_AnioFiscal_Info>();
               EntitiesDBConta OEAnioFiscal = new EntitiesDBConta();
               ct_AnioFiscal_Info aF = new ct_AnioFiscal_Info();

               var selectanioFiscal = from A in OEAnioFiscal.vwct_anio_fiscal_x_cuenta_utilidad
                                      where A.IdanioFiscal == Anio
                                      && A.IdEmpresa==IdEmpresa
                                      select A;


               foreach (var item in selectanioFiscal)
               {
                   aF.IdanioFiscal = item.IdanioFiscal;
                   aF.pc_Cuenta = item.pc_Cuenta;
                   aF.IdCtaCble = item.IdCtaCble;
                   aF.IdGrupoCble = item.IdGrupoCble;
                   aF.IdNivelCta = item.IdNivelCta;
                   aF.IdEmpresa = item.IdEmpresa;
                   aF.gc_GrupoCble = item.gc_GrupoCble;
               }
               return aF;
           }
           catch (Exception ex)
           {
               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                   "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               mensaje = ex.ToString();
               throw new Exception(ex.ToString());
           }
       }
        
       public ct_AnioFiscal_Info Get_Info_Anio_fiscal(int Anio)
       {
           try
           {

               List<ct_AnioFiscal_Info> lM = new List<ct_AnioFiscal_Info>();
               EntitiesDBConta OEAnioFiscal = new EntitiesDBConta();
               ct_AnioFiscal_Info aF = new ct_AnioFiscal_Info();

               var selectanioFiscal = from A in OEAnioFiscal.ct_anio_fiscal
                                      where A.IdanioFiscal == Anio
                                      select A;


               foreach (var item in selectanioFiscal)
               {
                   aF.IdanioFiscal = item.IdanioFiscal;
                   aF.af_fechaIni = item.af_fechaIni;
                   aF.af_fechaFin = item.af_fechaFin;
                   aF.af_estado = item.af_estado;
               }
               return aF;
           }
           catch (Exception ex)
           {
               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                   "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               mensaje = ex.ToString();
               throw new Exception(ex.ToString());
           }
       }



       public ct_AnioFiscal_Data()
       {
        
       }
    }
}
