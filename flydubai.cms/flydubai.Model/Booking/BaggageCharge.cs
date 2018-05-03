using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace flydubai.Model.Booking
{
    //Currently automapper doesn't instantiate correct subtype.  For now, we have an extension method on Charge AsBaggageCharge() that will
    //return this class.
    /// <summary>
    /// Baggage Charge
    /// </summary>
    [Serializable]
    public class BaggageCharge : Charge
    {
        public bool IsIncludedInFare
        { get { return this.Amount == 0; } }

        public int BaggageWeight 
        {
            get
            {
                int weight = 0;

                if (this.Description.ToLower().Contains("kg")) 
                {
                    int.TryParse(this.Description.Substring(0, this.Description.ToLower().IndexOf("kg")), out weight);
                }

                //it would be really nice, if at some point we could get this dynamically here ... or even from reference values
                if (weight == 0)
                {
                    switch (this.CodeType)
                    {
                        case "BAGB":
                            weight = 20;
                            break;
                        case "BAGL":
                            weight = 30;
                            break;
                        case "BAGX":
                            weight = 40;
                            break;
                        case "BUPL":
                            weight = 10;
                            break;
                        case "BUPX":
                            weight = 20;
                            break;
                        case "JBAG":
                            //A-5616 added JBAG 
                            weight = 40;
                            break;
                    }
                }

                return weight;
            }
        }
    }
}
