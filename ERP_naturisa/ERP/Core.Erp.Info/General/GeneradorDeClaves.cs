using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.General
{
    public class GeneradorDeClaves
    {

       
            char[] ValueAfanumeric = { '2', '4', '6', '7', '+', '&', 'u', 'i', 'o', 'p', 'a', 's', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'z', 'x', 'c', 'v', 'b', 'n', 'm', 'Q', 'W', 'E', 'R', 'T', 'Y', 'U', 'I', 'O', 'P', 'A', 'S', 'D', 'F', 'G', 'H', 'J', 'K', 'L', 'Z', 'X', 'C', 'V', 'B', 'N', 'M', '1', '3', '$', '%', '5', '?', '8' };

            public List<string> GenerarPass(int LongPassMin, int LongPassMax,int CantidadContraseññas)
            {
                List<string> lst = new List<string>();
                Random ram = new Random();
                int LogitudPass = ram.Next(LongPassMin, LongPassMax);
                string Password = String.Empty;
                for (int e = 0; e < CantidadContraseññas;e++)
                {


                    for (int i = 0; i < LogitudPass; i++)
                    {
                        int rm = ram.Next(0, 2);

                        if (rm == 0)
                        {
                            Password += ram.Next(0, 10);
                        }
                        else
                        {
                            Password += ValueAfanumeric[ram.Next(0, 59)];
                        }
                    }
                    lst.Add(Password);

                    Password = string.Empty;
                }
                return lst;
              }
    }
}
