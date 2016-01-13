using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationProfitHeat
{
    /// <summary>
    /// вентиляция
    /// </summary>
    public class Ventilation 
    {
        /// <summary>
        /// расчетная кратность воздухообмена 0,3 - для комант, 0,8 - для помещений с камином и подобных им, 1,0 - для кухонь и санузлов
        /// </summary>
        double K { get; set; }
        /// <summary>
        /// объем помещения
        /// </summary>
        double V { get; set; }

        public Ventilation(string typeRoom, double v)
        {
            K = WorkWithDatabase.GetVentilationRate(typeRoom);
            V = v;
        }
        /// <summary>
        /// теплопотери через вентиляцию
        /// </summary>
        public double GetHeatLoss(double dT)
        {
            return (K * V * (dT)) / 3;
        }
    }
}
