using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationProfitHeat
{
    public class Material
    {
        /// <summary>
        /// толщина
        /// </summary>
        public double Thickness { get; set; }
        /// <summary>
        /// название материала
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// теплопроводность (Вт / (м * °С))
        /// </summary>
        public double HeatConductivity { get; set; }

        public Material(double thickness, string name)
        {
            Thickness = thickness;
            Name = name;
            HeatConductivity = new WorkWithDatabase().GetCoefficientThermalConductivity(Name);
        }
        /// <summary>
        /// теплосопротивление (м² * °С / Вт)
        /// </summary>
        public double HeatResistance()
        {
            return Thickness / HeatConductivity;
        }
    }
}
