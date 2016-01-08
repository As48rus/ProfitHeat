using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationProfitHeat
{
    /// <summary>
    /// Тип комнаты
    /// </summary>
    public enum TypeRoom
    {
		/// <summary>
		/// ванная
		/// </summary>
        bathroom,
		/// <summary>
		/// туалет
		/// </summary>
        WC,
		/// <summary>
		/// прихожая
		/// </summary>
        hallway,
		/// <summary>
		/// гостиная
		/// </summary>
        lounge,
		/// <summary>
		/// спальня
		/// </summary>
        bedroom,
		/// <summary>
		/// кабинет
		/// </summary>
        cabinet,
		/// <summary>
		/// кладовая
		/// </summary>
        pantry,
		/// <summary>
		/// кухня
		/// </summary>
        kitchen,
		/// <summary>
		/// подвал
		/// </summary>
        basement,
		/// <summary>
		/// коридор
		/// </summary>
        corridor
    }
}
