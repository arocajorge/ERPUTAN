using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Inventario;
using Core.Erp.Business.Inventario;
using Core.Erp.Business.General;
using Core.Erp.Data.Inventario;




namespace Core.Erp.Business.Inventario
{
   public  class in_UnidadMedida_Bus
    {

            tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
            in_UnidadMedida_Info InfoUniMe = new in_UnidadMedida_Info();

            in_UnidadMedida_Data OData = new in_UnidadMedida_Data();
            in_UnidadMedida_Equiv_conversion_Data ODataUniMed_Equ = new in_UnidadMedida_Equiv_conversion_Data();
                
        string mensaje = "";

       public List<in_UnidadMedida_Info> Get_list_UnidadMedida_equivalencia(string IdUnidadMedida)
        {
            try
            {
                List<in_UnidadMedida_Info> lM = new List<in_UnidadMedida_Info>();
                lM = OData.Get_list_UnidadMedida_equivalencia(IdUnidadMedida);
                return (lM);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_list_UnidadMedida_equivalencia", ex.Message), ex) { EntityType = typeof(in_UnidadMedida_Bus) };

            }
        }

        public List<in_UnidadMedida_Info> Get_list_UnidadMedida()
        {
            try
            {
                List<in_UnidadMedida_Info> lM = new List<in_UnidadMedida_Info>();
                lM=OData.Get_list_UnidadMedida();
                return (lM);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Obtener_list_UnidadMedida", ex.Message), ex) { EntityType = typeof(in_UnidadMedida_Bus) };

            }
        }

        public Boolean ValidarObjeto(in_UnidadMedida_Info Info, ref string mensaje)
        {
            try
            {

                Boolean tieneEquivalenciaGeneral = false;

                if (Info.listUnidadMedida_Equiv_conversion.Count == 0)
                {
                    mensaje = "No tiene Listado de conversion";
                    return false;
                }

                if (Info.Descripcion=="")
                {
                    mensaje = "No tiene nombre de unidad de medida";
                    return false;
                }


                foreach (var item in Info.listUnidadMedida_Equiv_conversion)
                {
                    tieneEquivalenciaGeneral = false;

                    if (item.IdUnidadMedida_equiva == Info.IdUnidadMedida)
                    {
                        tieneEquivalenciaGeneral = true;
                        mensaje = "No tiene equivalencia de conversion" ;
                        break;
                    }
                }

                Dictionary<string, string> ListKeyIdUniMed = new Dictionary<string, string>();

                try
                {
                    foreach (var item in Info.listUnidadMedida_Equiv_conversion)
                    {
                        ListKeyIdUniMed.Add(item.IdUnidadMedida_equiva, item.IdUnidadMedida_equiva);
                    }
                }
                catch (Exception ex)
                {
                    Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                    throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ValidarObjeto", ex.Message), ex) { EntityType = typeof(in_UnidadMedida_Bus) };

                }
                
                

                return true;
            }
            catch (Exception ex)
            {
               oLog.Log_Error(ex.ToString());
                mensaje = "Error Consulta General .." + ex.Message;
                throw new Exception(mensaje);
            }

        }


        private void corregirObjeto(ref in_UnidadMedida_Info Info,ref string mensaje)
        {
            try
            {
                Boolean tieneEquivalenciaGeneral = false;

       
                if (Info.listUnidadMedida_Equiv_conversion.Count == 0)
                {
                    in_UnidadMedida_Equiv_conversion_Info itemObj = new in_UnidadMedida_Equiv_conversion_Info();
                    itemObj.IdUnidadMedida = Info.IdUnidadMedida;
                    itemObj.IdUnidadMedida_equiva=Info.IdUnidadMedida;
                    itemObj.valor_equiv=1;
                    itemObj.interpretacion = "1 " + Info.Descripcion + " equivale a " + itemObj.valor_equiv + " " + Info.Descripcion;
                    Info.listUnidadMedida_Equiv_conversion.Add(itemObj);
                }


                foreach (var item in Info.listUnidadMedida_Equiv_conversion)
                {
                    tieneEquivalenciaGeneral = false;
                    if (item.IdUnidadMedida_equiva == Info.IdUnidadMedida)
                    {
                        tieneEquivalenciaGeneral = true;
                        break;
                    }
                }

                if (tieneEquivalenciaGeneral==false)
                {
                    in_UnidadMedida_Equiv_conversion_Info itemObj = new in_UnidadMedida_Equiv_conversion_Info();
                    itemObj.IdUnidadMedida = Info.IdUnidadMedida;
                    itemObj.IdUnidadMedida_equiva = Info.IdUnidadMedida;
                    itemObj.valor_equiv = 1;
                    itemObj.interpretacion = "1 " + Info.Descripcion + " equivale a " + itemObj.valor_equiv + " " + Info.Descripcion;
                    Info.listUnidadMedida_Equiv_conversion.Add(itemObj);
                }



                foreach (var item in Info.listUnidadMedida_Equiv_conversion)
                {
                    item.IdUnidadMedida = Info.IdUnidadMedida;
                    item.interpretacion = "1 " + Info.Descripcion + " equivale a " + item.valor_equiv + " " + item.IdUnidadMedida_equiva;
                }
            

            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "corregirObjeto", ex.Message), ex) { EntityType = typeof(in_UnidadMedida_Bus) };

            }
        }

        public Boolean GrabarDB(in_UnidadMedida_Info prI, ref string IdUnidadMedida, ref string mensaje)
        {
            try
            {
                Boolean res = false;

                if (prI.IdUnidadMedida == "")
                { prI.IdUnidadMedida = OData.getIdUnidadMedida(); }


                corregirObjeto(ref prI, ref mensaje);

                if (ValidarObjeto(prI, ref mensaje))
                {
                    res = OData.GrabarDB(prI, ref IdUnidadMedida, ref mensaje);

                    if (res)
                    {
                        res = ODataUniMed_Equ.GuardarListDB(prI.listUnidadMedida_Equiv_conversion, ref mensaje);
                    }

                }

                return res;

            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(in_UnidadMedida_Bus) };

            }
        }

        public Boolean ModificarDB(in_UnidadMedida_Info prI, ref string mensaje)
        {
            try
            {
                Boolean res = false;
                
                corregirObjeto(ref prI, ref mensaje);

                if (ValidarObjeto(prI, ref mensaje))
                {
                    res = OData.ModificarDB(prI, ref mensaje);

                    if (res)
                    {
                        ODataUniMed_Equ.EliminarDB(prI.IdUnidadMedida, ref mensaje);
                        ODataUniMed_Equ.GuardarListDB(prI.listUnidadMedida_Equiv_conversion, ref mensaje);
                    }

                }

                return res;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(in_UnidadMedida_Bus) };

            }
        }

        public Boolean AnularDB(in_UnidadMedida_Info UniInfo, ref  string mensaje)
        {
            try
            {
                return OData.AnularDB(UniInfo, ref mensaje);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "AnularDB", ex.Message), ex) { EntityType = typeof(in_UnidadMedida_Bus) };

            }
        }


        public Boolean Existe_IdUnidadMedida(string IdUnidaMedida)
        {
            try
            {
                return OData.Existe_IdUnidadMedida(IdUnidaMedida);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Existe_IdUnidadMedida", ex.Message), ex) { EntityType = typeof(in_UnidadMedida_Bus) };

            }
        }


       public in_UnidadMedida_Bus()
       {

       }
    }
}
