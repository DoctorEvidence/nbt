using Nbt.ServiceModel;
using Nbt.ServiceModel.Types;
using ServiceStack;
using ServiceStack.OrmLite;

namespace Nbt.ServiceInterface
{
    public class CompaniesService : Service
    {
        public object Get(Companies request)
        {
            return new CompanyResponse { Companies = Db.Select<Company>() };
        }
    }
}
