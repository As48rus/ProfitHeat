using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationProfitHeat
{
    /// <summary>
    /// работа с базой даных
    /// </summary>
    class WorkWithDatabase
    {
        public void CreateConnection()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// результат зарпроса
        /// </summary>
        public void GetQueryResults()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Коэффициент теплопроводности (Вт / (м * °С))
        /// </summary>
        public double GetCoefficientThermalConductivity(string nameMaterial)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Коэффициент теплосопротивления (м² * °С / Вт)
        /// </summary>
        public double GetCoefficientThermalResistance(int countCameras)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Коэффициент теплосопротивления (м² * °С / Вт)
        /// </summary>
        public double GetCoefficientThermalResistance(string formulaGlass)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// скорость вентиляции
        /// </summary>
        public double GetVentilationRate(string typeRoom)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// перепад температур между помещением и улицей
        /// </summary>
        public double GetdTSity(string sity)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// мощность одной секции радиатора
        /// </summary>
        public double GetPowerOneSectionsRadiator(string typeRadiator)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// внутренний диаметр трубы
        /// </summary>
        public int GetInnerDiameterPipe(int boilerPower)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// давление насоса
        /// </summary>
        public int GetPumpPressure(int countRadiator)
        {
            throw new NotImplementedException();
        }
    }
}
