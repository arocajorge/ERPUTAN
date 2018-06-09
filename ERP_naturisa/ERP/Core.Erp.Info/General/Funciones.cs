using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Diagnostics;
//using System.Windows.Forms;



namespace Core.Erp.Info.General
{
    public class Funciones
    {
       

        public  Boolean ValidaNumero(char e)
        {

            if (char.IsDigit(e) || char.IsControl(e))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public Boolean Validanumero_decimal(char e)
        {

            if (char.IsDigit(e) || char.IsControl(e) || char.IsPunctuation(e))
            {

                return false;
            }
            else
            {
                return true;
            }
        }

        public Boolean Validanumero_decimal(char e, string cadena)
        {
            bool IsDec = false;
            if (!char.IsNumber(e))
            {
                if (e == '.')
                {
                    if (cadena.IndexOf('.') >= 0)
                    {
                        IsDec = true;
                    }
                    else
                    {
                        IsDec = false;
                    }
                }
                else
                {
                    IsDec = true;
                }
            }

            if (char.IsControl(e)) { return false; }
            return IsDec;
        }

        public string Format_text_2_decimales(string cadena)
        {
            //if (cadena.IndexOf('.') >= 0)
            //{
            //    try
            //    {
            //        cadena = cadena.Substring(0, cadena.IndexOf('.') + 3);
            //    }
            //    catch (Exception)
            //    {
            //        if (cadena.IndexOf('.') == (cadena.Length - 1))
            //        {
            //            cadena = cadena + "00";
            //        }
            //        else if (cadena.IndexOf('.') == (cadena.Length - 2))
            //        {
            //            cadena = cadena + "0";
            //        }

            //    }
            //}
            //else
            //{
            //    cadena = cadena + ".00";
            //}

            cadena = String.Format("{0:0.00}",cadena);
            return cadena;
        }

        // NUMERO A LETRA
        public string NumeroALetras(string num)
        {
            string res, dec = "";
            Int64 entero;
            int decimales;
            double nro;
            try
            {
                nro = Convert.ToDouble(num);
            }
            catch
            {
                return "";
            }

            entero = Convert.ToInt64(Math.Truncate(nro));
            decimales = Convert.ToInt32(Math.Round((nro - entero) * 100, 2));
            if (decimales > 0)
            {
                if(decimales < 10)
                    dec = " CON 0" + decimales.ToString() + "/100 ****";
                else
                    dec = " CON " + decimales.ToString() + "/100 ****";
                //  dec = " CON 0," + decimales.ToString();//+ "/100";
                //   dec = " CON " + Core.Erp.Info.General.Funciones.NumeroALetras(Convert.ToDouble(decimales));
            }
            else
                dec = " CON 00/100 ****";

            res = Core.Erp.Info.General.Funciones.NumeroALetras(Convert.ToDecimal(entero)) + dec;
            return res;
        }

        static string NumeroALetras(decimal value)
        {
            string Num2Text = "";
            value = Math.Truncate(value);
            if (value == 0) Num2Text = "CERO";

            else if (value == 1) Num2Text = "UNO";

            else if (value == 2) Num2Text = "DOS";

            else if (value == 3) Num2Text = "TRES";

            else if (value == 4) Num2Text = "CUATRO";

            else if (value == 5) Num2Text = "CINCO";

            else if (value == 6) Num2Text = "SEIS";

            else if (value == 7) Num2Text = "SIETE";

            else if (value == 8) Num2Text = "OCHO";

            else if (value == 9) Num2Text = "NUEVE";

            else if (value == 10) Num2Text = "DIEZ";

            else if (value == 11) Num2Text = "ONCE";

            else if (value == 12) Num2Text = "DOCE";

            else if (value == 13) Num2Text = "TRECE";

            else if (value == 14) Num2Text = "CATORCE";

            else if (value == 15) Num2Text = "QUINCE";

            else if (value < 20) Num2Text = "DIECI" + Core.Erp.Info.General.Funciones.NumeroALetras(Convert.ToDecimal((value - 10)));

            else if (value == 20) Num2Text = "VEINTE";

            else if (value < 30) Num2Text = "VEINTI" + Core.Erp.Info.General.Funciones.NumeroALetras(Convert.ToDecimal((value - 20)));

            else if (value == 30) Num2Text = "TREINTA";

            else if (value == 40) Num2Text = "CUARENTA";

            else if (value == 50) Num2Text = "CINCUENTA";

            else if (value == 60) Num2Text = "SESENTA";

            else if (value == 70) Num2Text = "SETENTA";

            else if (value == 80) Num2Text = "OCHENTA";

            else if (value == 90) Num2Text = "NOVENTA";

            else if (value < 100) Num2Text = Core.Erp.Info.General.Funciones.NumeroALetras(Convert.ToDecimal((Math.Truncate(value / 10) * 10))) + " Y " + Core.Erp.Info.General.Funciones.NumeroALetras(Convert.ToDecimal((value % 10)));

            else if (value == 100) Num2Text = "CIEN";

            else if (value < 200) Num2Text = "CIENTO " + Core.Erp.Info.General.Funciones.NumeroALetras(Convert.ToDecimal((value - 100)));

            else if ((value == 200) || (value == 300) || (value == 400) || (value == 600) || (value == 800)) Num2Text = Core.Erp.Info.General.Funciones.NumeroALetras(Convert.ToDecimal((value / 100))) + "CIENTOS";

            else if (value == 500) Num2Text = "QUINIENTOS";

            else if (value == 700) Num2Text = "SETECIENTOS";

            else if (value == 900) Num2Text = "NOVECIENTOS";

            else if (value < 1000) Num2Text = Core.Erp.Info.General.Funciones.NumeroALetras(Convert.ToDecimal((Math.Truncate(value / 100) * 100))) + " " + Core.Erp.Info.General.Funciones.NumeroALetras(Convert.ToDecimal((value % 100)));

            else if (value == 1000) Num2Text = "UN MIL";

            else if (value < 2000) Num2Text = "UN MIL " + Core.Erp.Info.General.Funciones.NumeroALetras(Convert.ToDecimal((value % 1000)));

            else if (value < 1000000)
            {
                Num2Text = Core.Erp.Info.General.Funciones.NumeroALetras(Convert.ToDecimal((Math.Truncate(value / 1000)))) + " MIL";

                if ((value % 1000) > 0) Num2Text = Num2Text + " " + Core.Erp.Info.General.Funciones.NumeroALetras(Convert.ToDecimal((value % 1000)));
            }



            else if (value == 1000000) Num2Text = "UN MILLON";

            else if (value < 2000000) Num2Text = "UN MILLON " + Core.Erp.Info.General.Funciones.NumeroALetras(Convert.ToDecimal((value % 1000000)));

            else if (value < 1000000000000)
            {
                Num2Text = Core.Erp.Info.General.Funciones.NumeroALetras(Convert.ToDecimal((value / 1000000))) + " MILLONES ";

                if ((value - Math.Truncate(value / 1000000) * 1000000) > 0) Num2Text = Num2Text + " " + Core.Erp.Info.General.Funciones.NumeroALetras(Convert.ToDecimal((value - Math.Truncate(value / 1000000) * 1000000)));
            }

            else if (value == 1000000000000) Num2Text = "UN BILLON";

            else if (value < 2000000000000) Num2Text = "UN BILLON " + Core.Erp.Info.General.Funciones.NumeroALetras(Convert.ToDecimal((value - Math.Truncate(value / 1000000000000) * 1000000000000)));

            else
            {
                Num2Text = Core.Erp.Info.General.Funciones.NumeroALetras(Convert.ToDecimal((Math.Truncate(value / 1000000000000)))) + " BILLONES";

                if ((value - Math.Truncate(value / 1000000000000) * 1000000000000) > 0) Num2Text = Num2Text + " " + Core.Erp.Info.General.Funciones.NumeroALetras(Convert.ToDecimal((value - Math.Truncate(value / 1000000000000) * 1000000000000)));
            }
            return Num2Text;
        }

        ///De image a byte []:
        public static byte[] ImageAArray(Image Imagen)
        {
            try
            {
                MemoryStream ms = new MemoryStream();
                Imagen.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
                return ms.ToArray();
            }
            catch (Exception)
            {
                return null;
            }
        }
        ///De byte [] a image:
        public static Image ArrayAImage(byte[] ArrBite)
        {
            try
            {
                MemoryStream ms = new MemoryStream();
                Image returnImage = null;


                if (ArrBite != null)
                {   ms = new MemoryStream(ArrBite);
                    returnImage = Image.FromStream(ms);    
                }

                
                
                return returnImage;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public  static string cadena(string cadena)
        {
            try
            {
                string[] split = cadena.Split(new Char[] { ' ' });

                string resul = "";

                for (int i = 0; i < split.Length; i++)
                {
                    if (split[i] != "")
                    {
                        resul = resul + split[i];
                    }
                }
                return resul.ToLower();
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static void Crear_y_abrir_Archivo_txt(byte[] buffer, string FILE_NAME)
        {
            try
            {
                if (File.Exists(FILE_NAME))
                {
                    File.Delete(FILE_NAME);
                }

                using (FileStream fs = new FileStream(FILE_NAME, FileMode.CreateNew))
                {
                    using (BinaryWriter w = new BinaryWriter(fs))
                    {

                        w.Write(buffer);
                        
                    }
                }

                Process.Start("Notepad", FILE_NAME);
                
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static void Abrir_Archivo_txt(string ruta)
        {
            try
            {
                Process.Start("Notepad", ruta);
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public Funciones(){ }


    }
}

