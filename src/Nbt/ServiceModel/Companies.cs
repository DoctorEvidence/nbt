using ServiceStack;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Nbt.ServiceModel.Types;

namespace Nbt.ServiceModel
{
    [DataContract]
    [Route("/companies")]
    public class Companies : IReturn<CompanyResponse> {}

    [DataContract]
    public class CompanyResponse : IHasResponseStatus
    {
        public CompanyResponse()
        {
            this.ResponseStatus = new ResponseStatus();
            this.Companies = new List<Company>();
        }

        [DataMember]
        public List<Company> Companies { get; set; }

        [DataMember]
        public ResponseStatus ResponseStatus { get; set; }
    }
}