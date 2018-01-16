using Nbt.ServiceModel.Types;
using ServiceStack;
using System.Runtime.Serialization;

namespace Nbt.ServiceModel
{
    [DataContract]
    [Route("/companies/{Id}")]
    public class CompanyDetails : IReturn<CompanyDetailsResponse>
    {
        [DataMember]
        public string Id { get; set; }
    }

    [DataContract]
    public class CompanyDetailsResponse : IHasResponseStatus
    {
        public CompanyDetailsResponse()
        {
            this.ResponseStatus = new ResponseStatus();

        }

        [DataMember]
        public Company Company { get; set; }



        [DataMember]
        public ResponseStatus ResponseStatus { get; set; }
    }
}