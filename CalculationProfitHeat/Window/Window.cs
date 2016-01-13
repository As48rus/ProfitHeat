using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationProfitHeat
{
    /// <summary>
    /// Окно
    /// </summary>
    public class Window 
    {
		/// <summary>
		/// площадь
		/// </summary>
        public double Area { get; set; }
		/// <summary>
		/// стеклопакет
		/// </summary>
        public Glazed Glazed { get; set; }
        /// <summary>
        /// оконный профиль
        /// </summary>
        public WindowProfile WindowProfile { get; set; }
		/// <summary>
		/// теплопроводность
		/// </summary>
        public double HeatConductivity { get; set; }

		public Window(double area, Glazed glazed, WindowProfile windowProfile)
		{
			Area = area;
			Glazed = glazed;
            WindowProfile = windowProfile;
		}
        /// <summary>
        /// теплопотери через окна
        /// </summary>
        public double GetHeatLoss(double dT)
        {
            return Glazed.GetHeatLoss(dT) + WindowProfile.GetHeatLoss(dT);
        }

    }
}
