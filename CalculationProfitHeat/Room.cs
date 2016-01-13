using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationProfitHeat
{
    public class Room 
    {
		/// <summary>
		/// название
		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// этаж
		/// </summary>
		int Level { get; set; }
		/// <summary>
		/// тип комнаты
		/// </summary>
		public string TypeRoom { get; set; }
		/// <summary>
		/// тип радиатора
		/// </summary>
		string RadiatorType { get; set; }
        /// <summary>
        /// количество секций радиатора
        /// </summary>
        public int CountSections { get; set; }
        /// <summary>
        /// вентиляция
        /// </summary>
        Ventilation Ventilation { get; set; }
        /// <summary>
        /// конструктивные ограждения
        /// </summary>
        public List<Cladding> Claddings { get; set; }
		/// <summary>
		/// окна
		/// </summary>
		public List<Window> Windows { get; set; }
        /// <summary>
        /// теплопотери комнаты
        /// </summary>
        double HeatLoss { get; set; } = 0;

        public Room(string name, int level, string typeRoom, string radiatorType)
		{
			Name = name;
			Level = level;
			TypeRoom = typeRoom;
			RadiatorType = radiatorType;

			Claddings = new List<Cladding>();
			Windows = new List<Window>();
		}
        /// <summary>
        /// теплопотери комнаты
        /// </summary>
        public double GetHeatLoss(string sity)
        {
            double dT = WorkWithDatabase.GetTRoom(TypeRoom) - WorkWithDatabase.GetdTSity(sity);
            foreach(var cladding in Claddings)
                HeatLoss += cladding.GetHeatLoss(dT);

            foreach (var window in Windows)
                HeatLoss += window.GetHeatLoss(dT);

            HeatLoss += Ventilation.GetHeatLoss(dT);

            return HeatLoss;
        }
        /// <summary>
        /// расчет количество секций радиатора
        /// </summary>
        public int GetCountSections(string typeRadiator)
        {
            double powerOneSectionsRadiator = WorkWithDatabase.GetPowerOneSectionsRadiator(typeRadiator);
            return CountSections = (int)Math.Ceiling(HeatLoss / powerOneSectionsRadiator);
        }
    }
}
