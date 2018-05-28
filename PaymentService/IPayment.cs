using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace PaymentService
{
    [ServiceContract]
    public interface IPayment
    {
        [OperationContract]
        bool ValidateCard(Card card);
        bool ValidateCardAsync(Card card);
    }

    [DataContract]
    public class Card
    {
        [DataMember(IsRequired = true)]
        public string CardNumber { get; set; }
        [DataMember(IsRequired = true)]
        public int CardExpirationMonth { get; set; }
        [DataMember(IsRequired = true)]
        public int CardExpirationYear { get; set; }
        [DataMember(IsRequired = true)]
        public string Name { get; set; }
        [DataMember(IsRequired = true)]
        public string Cvs { get; set; }
    }
}
