using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Common;
using System.Collections;

namespace CalculationProfitHeat
{
    /// <summary>
    /// работа с базой даных
    /// </summary>
    public static class WorkWithDatabase
    {
        /// <summary>
        /// строка подключения
        /// </summary>
        readonly static string connectionString = @"Data Source=HOME\SQLEXPRESS;Initial Catalog=ProfitHeat;Integrated Security=True";

        /// <summary>
        /// результат зарпроса Select
        /// </summary>
        public static ArrayList GetQueryResultsSelect(string request)
        {
            ArrayList result = new ArrayList();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                
                SqlCommand com = new SqlCommand(request, con);
                con.Open();
                SqlDataReader dr = com.ExecuteReader();
                if (dr.HasRows)
                    foreach (var res in dr)
                        result.Add(res);
            }
            return result;
        }

        /// <summary>
        /// список городов
        /// </summary>
        public static ArrayList GetAllSity()
        {
            string request = "select Name from Sity";
            return GetQueryResultsSelect(request);
        }

        /// <summary>
        /// список типов комнат
        /// </summary>
        public static ArrayList GetAllTypeRooms()
        {
            string request = "select Name from TypeRoom";
            return GetQueryResultsSelect(request);
        }

        /// <summary>
        /// список типов радиаторов
        /// </summary>
        public static ArrayList GetAllTypeRadiator()
        {
            string request = "select Material from RadiatorType";
            return GetQueryResultsSelect(request);
        }

        /// <summary>
        /// список материалов
        /// </summary>
        public static ArrayList GetAllMaterials()
        {
            string request = "select Name from Materials";
            return GetQueryResultsSelect(request);
        }

        /// <summary>
        /// список стеклопакетов
        /// </summary>
        public static ArrayList GetAllGlazedes()
        {
            string request = "select Name from Glazed";
            return GetQueryResultsSelect(request);
        }

        /// <summary>
        /// список профилей(толщина)
        /// </summary>
        public static ArrayList GetAllWindowProfilesThickness()
        {
            string request = "select distinct Thickness from WindowProfiles";
            return GetQueryResultsSelect(request);
        }

        /// <summary>
        /// список профилей(количество камер)
        /// </summary>
        public static ArrayList GetAllWindowProfilesCountCameras()
        {
            string request = "select distinct CountCameras from WindowProfiles";
            return GetQueryResultsSelect(request);
        }

        /// <summary>
        /// Коэффициент теплопроводности (Вт / (м * °С))
        /// </summary>
        public static double GetCoefficientThermalConductivity(string nameMaterial)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Коэффициент теплосопротивления (м² * °С / Вт)
        /// </summary>
        public static double GetCoefficientThermalResistance(int countCameras)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Коэффициент теплосопротивления (м² * °С / Вт)
        /// </summary>
        public static double GetCoefficientThermalResistance(string formulaGlass)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// скорость вентиляции
        /// </summary>
        public static double GetVentilationRate(string typeRoom)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// перепад температур между помещением и улицей
        /// </summary>
        public static double GetdTSity(string sity)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// мощность одной секции радиатора
        /// </summary>
        public static double GetPowerOneSectionsRadiator(string typeRadiator)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// внутренний диаметр трубы
        /// </summary>
        public static int GetInnerDiameterPipe(int boilerPower)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// давление насоса
        /// </summary>
        public static int GetPumpPressure(int countRadiator)
        {
            throw new NotImplementedException();
        }
    }
}
