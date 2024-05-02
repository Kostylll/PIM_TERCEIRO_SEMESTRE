using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PimProject.Application.Utils
{
    public static class Utility
    {
        public static DateTime FormatStringToDateTime(string date)
        {
            try
            {
                if (date.Length >= 9)
                {
                    var year = int.Parse(date.Substring(0, 4));
                    var month = int.Parse(date.Substring(4, 2));
                    var day = int.Parse(date.Substring(6, 2));
                    var dateFormated = new DateTime(year, month, day);

                    return dateFormated;
                }


            }
            catch (Exception)
            {

                throw;
            }
            return new DateTime();
        }

    }
}
