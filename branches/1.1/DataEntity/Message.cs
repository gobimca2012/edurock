
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Reflection;
namespace DataEntity
{
    partial class MessageDataContext
    {
        public MessageDataContext() :
            base(global::System.Configuration.ConfigurationManager.ConnectionStrings["LocalSqlServer"].ConnectionString, mappingSource)
        {
            OnCreated();
        }
    }
}
