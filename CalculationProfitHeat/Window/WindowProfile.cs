using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationProfitHeat
{
    /// <summary>
    /// оконный профиль
    /// </summary>
    public class WindowProfile : IHeatLoss
    {
        /// <summary>
		/// площадь
		/// </summary>
        public double Area { get; set; }
        /// <summary>
        /// количество камер
        /// </summary>
        public int CountCameras { get; set; }
        /// <summary>
        /// теплосопротивление (м² * °С / Вт)
        /// </summary>
        public double HeatResistance { get; set; }

        public WindowProfile(double area, int countCameras)
        {
            Area = area;
            HeatResistance = WorkWithDatabase.GetCoefficientThermalResistance(CountCameras);
        }

        /// <summary>
        /// теплопотери 
        /// </summary>
        public double GetHeatLoss(double dT)
        {
            return Area * (dT) / HeatResistance;
        }
    }
}
