
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Reflection;
namespace DataEntity
{
    partial class ShoppingCartDataContext
    {
        public ShoppingCartDataContext() :
            base(global::System.Configuration.ConfigurationManager.ConnectionStrings["ShoppingSqlServer"].ConnectionString, mappingSource)
        {
            OnCreated();
        }
    }
}
