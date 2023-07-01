using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2
{
    public class ClassCalculo
    {
        public int TotalSalario(int AFP, int IRS, int ASR)
        {

            return AFP + IRS + ASR; ;
        }
        public int SueldoNeto(int Total, int sueldo)
        {

            return  Total + sueldo;
        }
    }
}
