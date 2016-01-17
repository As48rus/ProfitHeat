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
        /// <summary>
        /// например (4-10Ar-4)
        /// </summary>
        public string GlazedFormula { get; set; }

        public Glazed(string glazedStr)
		{
            GlazedFormula = glazedStr;

		}
        /// <summary>
        /// теплопотери 
        /// </summary>
        public double GetHeatLoss(double dT)
        {
            HeatResistance = WorkWithDatabase.GetCoefficientThermalResistance(GlazedFormula);
            return Area * (dT) / HeatResistance;
        }
    }
}
