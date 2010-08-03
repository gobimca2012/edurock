using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Reflection;
namespace DataEntity
{

    partial class InstituteDataContext
    {
        public InstituteDataContext() :
            base(global::System.Configuration.ConfigurationManager.ConnectionStrings["LocalSqlServer"].ConnectionString, mappingSource)
        {
            OnCreated();
        }
    }

}
