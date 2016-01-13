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
    public class WindowProfile 
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
        /// толщина профиля
        /// </summary>
        public int Thickness { get; set; }
        /// <summary>
        /// теплосопротивление (м² * °С / Вт)
        /// </summary>
        public double HeatResistance { get; set; }

        public WindowProfile(double area, int countCameras, int thickness)
        {
            Area = area;
            CountCameras = countCameras;
            Thickness = thickness;
            HeatResistance = WorkWithDatabase.GetCoefficientThermalResistance(CountCameras, Thickness);
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
