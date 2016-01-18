using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationProfitHeat
{
    public class Result
    {
        /// <summary>
        /// Регион расположения дома
        /// </summary>
        double dT{ get; set; }
        /// <summary>
        /// мощьность котла
        /// </summary>
        int BoilerOutput { get; set; }
        /// <summary>
        /// диаметр теплоносителя
        /// </summary>
        int DiameterCoolant { get; set; }
        /// <summary>
        /// тип насоса
        /// </summary>
        string TypeCapacity { get; set; }
        /// <summary>
        /// список комнат
        /// </summary>
        List<Room> Rooms { get; set; }
        /// <summary>
        /// расход куб.м/ч
        /// </summary>
        double Consumption { get; set; }

        public Result(string sity, List<Room> rooms)
        {
            dT = WorkWithDatabase.GetdTSity(sity);
            Rooms = rooms;
            BoilerOutput = GetBoilerOutput();
            Consumption = 0.6;
        }
        /// <summary>
        /// рассчитать мощьность котла
        /// </summary>
        public int GetBoilerOutput()
        {
            double HeatLoss = 0;
            foreach (var room in Rooms)
                HeatLoss += room.GetHeatLoss(room.TypeRoom);
            return (int)Math.Ceiling(HeatLoss);
        }
        /// <summary>
        /// рассчитать диаметр теплоносителя
        /// </summary>
        public int GetDiameterCoolant()
        {
            return DiameterCoolant = WorkWithDatabase.GetInnerDiameterPipe(BoilerOutput);
        }
        /// <summary>
        /// рассчитать тип насоса
        /// </summary>
        public string GetPumpCapacity()
        {
            ///отвод 90 по 2 на каждый радиатор, сужение по 4 на радиатор, один кпан и фильтр грязевик
            double sumResistance = GetResistanceElementov(1, GetCountRadiator() * 2) + GetResistanceElementov(1, GetCountRadiator() * 4) + GetResistanceElementov(3.8, 1) + GetResistancePipe(GetCountRadiator(), 0.012);
            sumResistance += GetResistancePipe(GetCountRadiator() * 10, DiameterCoolant);

            int pumpPressure = WorkWithDatabase.GetPumpPressure(sumResistance);

            return TypeCapacity = DiameterCoolant + " / " + pumpPressure;
        }

        private double GetSpeedCurrent(double consumption)
        {
            return (4 * consumption / 360) / (Math.PI * DiameterCoolant * DiameterCoolant);
        }

        private double GetResistanceElementov(double coefficient, int count)
        {
            return coefficient * count * GetSpeedCurrent(Consumption) * GetSpeedCurrent(Consumption) / 19.62;
        }

        private double GetResistancePipe(double length, double diametr)
        {
            double koefTreniy = 0.025;
            return (koefTreniy * length * GetSpeedCurrent(Consumption) * GetSpeedCurrent(Consumption)) / (diametr * 2 * 9.81);
        }

        private int GetCountRadiator()
        {
            int countRadiator = 0;
            foreach (var room in Rooms)
                if (room.CountSections > 0)
                    countRadiator++;
            return countRadiator;
        }
    }
}
