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

        public Result(string sity, List<Room> rooms)
        {
            dT = new WorkWithDatabase().GetdTSity(sity);
            Rooms = rooms;
            BoilerOutput = GetBoilerOutput();
        }
        /// <summary>
        /// рассчитать мощьность котла
        /// </summary>
        public int GetBoilerOutput()
        {
            double HeatLoss = 0;
            foreach (var room in Rooms)
                HeatLoss += room.GetHeatLoss(dT);
            return (int)Math.Ceiling(HeatLoss);
        }
        /// <summary>
        /// рассчитать диаметр теплоносителя
        /// </summary>
        public int GetDiameterCoolant()
        {
            return DiameterCoolant = new WorkWithDatabase().GetInnerDiameterPipe(BoilerOutput);
        }
        /// <summary>
        /// рассчитать тип насоса
        /// </summary>
        public string GetPumpCapacity()
        {
            int pumpPressure = new WorkWithDatabase().GetPumpPressure(GetCountRadiator());

            return TypeCapacity = DiameterCoolant + " / " + pumpPressure;
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
