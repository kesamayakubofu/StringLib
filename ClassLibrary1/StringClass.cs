using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace StringLib


{
    public class StringClass
    {
        /// <summary>
        /// Метод возвращает true, если входная строка является датой в корректном формате, в противном случае возвращает - false. 
        /// </summary>
        /// <param name="textString"></param>
        /// <param name="typeDate"></param>
        /// <returns></returns>
        public static bool StringParse(string textString, int typeDate)
        {
            DateTime dateresult;
            if (!DateTime.TryParse(textString, out dateresult))
            {
                return false;
            }
            if ((typeDate < 1) || (typeDate > 13))
            {
                return false;
            }
            string[] types =
                {
             "YYYY.MM.DD",
             "YYYY.DD.MM",
             "MM.DD.YYYY",
             "YYYY-M-D",
             "YYYY/M/D",
             "YYYY.DD.MM",
             "D.M.YYYY",
             "D-M-YYYY",
             "D/M/YYYY",
             "DD.MM.YYYY",
             "DD-MM-YYYY",
             "DD/MM/YYYY",
             "M/D/YYYY"

            };


                return true;
        }

        }

    
}
