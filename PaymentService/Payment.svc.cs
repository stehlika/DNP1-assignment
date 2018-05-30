using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace PaymentService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Payment : IPayment
    {
        public bool ValidateCard(Card card)
        {
            try
            {
                if (card.CardNumber.Length != 16)
                {
                    return false;
                }

                if (card.Cvs.Length != 3)
                {
                    return false;
                }

                if (card.CardExpirationYear < DateTime.Now.Year || card.CardExpirationMonth > 12)
                {
                    return false;
                }

                if (card.CardExpirationYear == DateTime.Now.Year && card.CardExpirationMonth < DateTime.Now.Month)
                {
                    return false;
                }
            }
            catch (NullReferenceException)
            {
                return false;
            }

            return true;
        }

        public bool ValidateCardAsync(Card card)
        {
            return this.ValidateCard(card);
        }
    }
}
