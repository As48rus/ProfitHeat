using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CalculationProfitHeat
{
    /// <summary>
    /// Ограждаюжая конструкция
    /// </summary>
    public class Cladding 
    {
		/// <summary>
		/// площадь
		/// </summary>
        public double Area { get; set; }
        /// <summary>
        /// материалы
        /// </summary>
        public List<Material> Materials { get; set; }

        public Cladding(double area)
		{
			Area = area;
            Materials = new List<Material>();
		}
        /// <summary>
        /// теплопотери 
        /// </summary>
        public double GetHeatLoss(double dT)
        {
            double sumR = 0;
            foreach (var material in Materials)
                sumR += material.HeatResistance();
            if (Area == 0 || sumR == 0)
                return 0;
            return Area * (dT) / sumR;
        }

    }
}
