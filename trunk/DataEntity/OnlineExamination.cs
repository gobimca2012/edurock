using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Reflection;
namespace DataEntity
{
    partial class OnlineExaminationDataContext
    {
        public OnlineExaminationDataContext() :
            base(global::System.Configuration.ConfigurationManager.ConnectionStrings["ExternalData"].ConnectionString, mappingSource)
        {
            OnCreated();
        }
    }
}
