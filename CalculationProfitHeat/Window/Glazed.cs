using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationProfitHeat
{
    /// <summary>
    /// Стеклопакет
    /// </summary>
    public class Glazed
    {
		/// <summary>
		/// Толщина внешнего стекла
		/// </summary>
        int Glass1 { get; set; }
		/// <summary>
		/// Толщина среднего стекла
		/// </summary>
		int Glass2 { get; set; }
		/// <summary>
		/// Толщина внктреннего стекла
		/// </summary>
		int Glass3 { get; set; }
		/// <summary>
		/// Толщина внешнего стеклопакета
		/// </summary>
		int Cameras1 { get; set; }
		/// <summary>
		/// Толщина внутреннего стеклопакета
		/// </summary>
		int Cameras2 { get; set; }
		/// <summary>
		/// Газ наполнитель
		/// </summary>
		Gas Gas { get; set; }
		/// <summary>
		/// i-напыление
		/// </summary>
		bool I_Spraning { get; set; }
        /// <summary>
        /// площадь
        /// </summary>
        public double Area { get; set; }
        /// <summary>
        /// теплосопротивление (м² * °С / Вт)
        /// </summary>
        public double HeatResistance { get; set; }

		public Glazed(string glazedStr)
		{
            //double area; int glass1; int camera1; int glass2; int camera2; int glass3; Gas gas; bool i_Spraning;
            //Area = area;
            //Glass1 = glass1;
			//Glass2 = glass2;
			//Glass3 = glass3;
			//Cameras1 = camera1;
			//Cameras2 = camera2;
			//Gas = gas;
			//I_Spraning = i_Spraning;

		}
        /// <summary>
        /// теплопотери 
        /// </summary>
        public double GetHeatLoss(double dT)
        {
            HeatResistance = new WorkWithDatabase().GetCoefficientThermalResistance("");
            return Area * (dT) / HeatResistance;
        }
    }
}
