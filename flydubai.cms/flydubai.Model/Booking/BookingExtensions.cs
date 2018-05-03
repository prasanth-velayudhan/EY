using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using flydubai.Common;

namespace flydubai.Model.Booking
{
    /// <summary>
    /// Booking Extensions
    /// </summary>
    public static class BookingExtensions
    {
        /// <summary>
        /// Ases the baggage charge.
        /// </summary>
        /// <param name="charge">The charge.</param>
        /// <returns></returns>
        public static BaggageCharge AsBaggageCharge(this Charge charge)
        {
            //A-5616---included JBAG code
            string[] baggageChargeCodes = ConfigurationManager.AppSettings["BaggageChargeCodes"].Split(',');

            //this works because BaggageCharge is just made up of getters ..
            if (baggageChargeCodes.Contains(charge.CodeType))
                return new BaggageCharge() { Amount = charge.Amount, CodeType = charge.CodeType, Description = charge.Description, IsSSR = charge.IsSSR, TaxID = charge.TaxID };
            else
                return null;
        }

        //A-5616
        /// <summary>
        /// Ases the meal charge.
        /// </summary>
        /// <param name="charge">The charge.</param>
        /// <returns></returns>
        public static Charge AsMealCharge(this Charge charge, IEnumerable<CodeType> codetype)
        {
            string[] mealChargeCodes = codetype.Where(c => c.CodeTypeCategory.CodeTypeCategoryId == (int)Enums.CodeTypeCategory.Meals || c.CodeTypeCategory.CodeTypeCategoryId == (int)Enums.CodeTypeCategory.PreSellMeals).Select(x => x.CodeTypeId).ToArray();//new string[] { "AVML", "CHML", "DBML", "HNML", "LFML", "LSML", "VGML", "VLML", "VOML", "MECA", "MEVG", "MICC", "MIFB", "MIVF", "MOCH", "MRCE", "MRVD", "BAVC", "BECA", "BEVB", "KFCR" };

            //this works because BaggageCharge is just made up of getters ..
            if (mealChargeCodes.Contains(charge.CodeType))
                return new Charge() { Amount = charge.Amount, CodeType = charge.CodeType, Description = charge.Description, IsSSR = charge.IsSSR, TaxID = charge.TaxID };
            else
                return null;
        }
    }
}
