using Nbt.ServiceModel.Types;
using ServiceStack;

namespace Nbt.ServiceModel
{
    [Route("/query/companies")]
    public class QueryCompanies : QueryDb<Company> { }

}