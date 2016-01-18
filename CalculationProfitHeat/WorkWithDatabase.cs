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

        public static double GetQueryResultsSelect(string nameProcedure, object value, string name)
        {
            double result = 0;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand com = new SqlCommand(nameProcedure, con);
                com.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter param = new SqlParameter();
                param.ParameterName = name;
                param.Value = value;
                if (value is int)
                    param.SqlDbType = System.Data.SqlDbType.Int;
                else if(value is string)
                    param.SqlDbType = System.Data.SqlDbType.NChar;
                param.Direction = System.Data.ParameterDirection.Input;
                com.Parameters.Add(param);

                con.Open();
                SqlDataReader reader = com.ExecuteReader();
                if (reader.Read())
                    try
                    {
                        result = reader.GetDouble(0);
                    }
                    catch
                    {
                        result = reader.GetInt16(0);
                    }
            }

            return result;

        }


        /// <summary>
        /// Коэффициент теплосопротивления (м² * °С / Вт)
        /// </summary>
        public static double GetCoefficientThermalResistance(int countCameras, int thickness)
        {
            double result = 0;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand com = new SqlCommand("GetCoefficientThermalResistanceForProfile", con);
                com.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter param = new SqlParameter();
                param.ParameterName = "@countCameras";
                param.Value = countCameras;
                param.SqlDbType = System.Data.SqlDbType.Int;
                param.Direction = System.Data.ParameterDirection.Input;
                com.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@thickness";
                param.Value = thickness;
                param.SqlDbType = System.Data.SqlDbType.Int;
                param.Direction = System.Data.ParameterDirection.Input;
                com.Parameters.Add(param);

                con.Open();
                SqlDataReader reader = com.ExecuteReader();
                if(reader.Read())
                    result = reader.GetDouble(0);
            }

            return result;
        }

        /// <summary>
        /// Коэффициент теплопроводности (Вт / (м * °С))
        /// </summary>
        public static double GetCoefficientThermalConductivity(string nameMaterial)
        {
            return GetQueryResultsSelect("GetCoefficientThermalConductivity", nameMaterial, "@nameMaterial");
        }

        /// <summary>
        /// Коэффициент теплосопротивления (м² * °С / Вт)
        /// </summary>
        public static double GetCoefficientThermalResistance(string formulaGlass)
        {
            return GetQueryResultsSelect("GetCoefficientThermalResistanceForGlazed", formulaGlass, "@formulaGlass");
        }

        /// <summary>
        /// скорость вентиляции
        /// </summary>
        public static double GetVentilationRate(string typeRoom)
        {
            return GetQueryResultsSelect("GetVentilationRate", typeRoom, "@typeRoom");
        }

        /// <summary>
        /// нормальная температура в комнате
        /// </summary>
        public static double GetTRoom(string typeRoom)
        {
            return GetQueryResultsSelect("GetTRoom", typeRoom, "@typeRoom");
        }

        /// <summary>
        /// перепад температур между помещением и улицей
        /// </summary>
        public static double GetdTSity(string sity)
        {
            return GetQueryResultsSelect("GetdTSity", sity, "@sity");
        }

        /// <summary>
        /// мощность одной секции радиатора
        /// </summary>
        public static double GetPowerOneSectionsRadiator(string typeRadiator)
        {
            return GetQueryResultsSelect("GetPowerOneSectionsRadiator", typeRadiator, "@typeRadiator");
        }

        public static List<Pipe> GetQueryResultsSelectDiametr(string request)
        {
            List<Pipe> result = new List<Pipe>();
            using (SqlConnection con = new SqlConnection(connectionString))
            {

                SqlCommand com = new SqlCommand(request, con);
                con.Open();
                SqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    int diamtr = dr.GetByte(0);
                    int power = dr.GetInt32(1);
                    result.Add(new Pipe(diamtr, power));
                }
            }
            return result;
        }

        /// <summary>
        /// внутренний диаметр трубы
        /// </summary>
        public static int GetInnerDiameterPipe(int boilerPower)
        {
            string queryStr = "SELECT Diametr, BoilerPower FROM Pipes";
            List<Pipe> result = GetQueryResultsSelectDiametr(queryStr);

            foreach (var pipe in result)
                if (pipe.PowerBoiler > boilerPower)
                    return pipe.Diametr;
            return 0;
        }

        /// <summary>
        /// давление насоса
        /// </summary>
        public static int GetPumpPressure(double resistanceCalculated)
        {
            int result = 0;
            ///выбор насоса по сопротивлению
            var resistances = new[] 
            {
                new { rated = 2, calculated = 2.0},
                new { rated = 4, calculated = 3.3},
                new { rated = 6, calculated = 5.2},
                new { rated = 7, calculated = 6.3},
                new { rated = 8, calculated = 7.5}
            };

            for (int i = 0; i < resistances.Length; i++)
            {
                if(resistanceCalculated < resistances[i].calculated)
                {
                    result = resistances[i].rated;
                    break;
                }
            }
            return result;
        }
    }
    public class Pipe
    {
        public int Diametr { get; set; }
        public int PowerBoiler { get; set; }
        public Pipe(int diamtr, int powerBoiler)
        {
            Diametr = diamtr;
            PowerBoiler = powerBoiler;
        }
    }

}
