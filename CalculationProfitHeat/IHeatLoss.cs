using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationProfitHeat
{
    interface IHeatLoss
    {
        /// <summary>
        /// теплопотери
        /// </summary>
        /// <param name="inT">температура внутри</param>
        /// <param name="outT">температура снаружи</param>
        /// <returns></returns>
        double GetHeatLoss(double dT);

    }
}
