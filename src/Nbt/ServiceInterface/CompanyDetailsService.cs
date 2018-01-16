using Nbt.ServiceModel;
using Nbt.ServiceModel.Types;
using ServiceStack;
using ServiceStack.OrmLite;
using System;
using System.Net;

namespace Nbt.ServiceInterface
{
    public class CompanyDetailsService : Service
    {
        public CompanyDetailsResponse Get(CompanyDetails request)
        {
            var customer = Db.SingleById<Company>(request.Id);
            if (customer == null)
                throw new HttpError(HttpStatusCode.NotFound,
                    new ArgumentException("Company does not exist: " + request.Id));


            return new CompanyDetailsResponse
            {
                Company = customer
            };
        }
    }
}
