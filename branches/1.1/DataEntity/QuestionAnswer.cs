
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Reflection;
namespace DataEntity
{

    partial class QuestionAnswerDataContext
    {
        public QuestionAnswerDataContext() :
            base(global::System.Configuration.ConfigurationManager.ConnectionStrings["LocalSqlServer"].ConnectionString, mappingSource)
        {
            OnCreated();
        }
    }

}
