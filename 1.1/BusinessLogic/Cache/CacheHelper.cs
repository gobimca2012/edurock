using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace BusinessLogic.Cache
{

    public class CacheHelper
    {
        private int instituteID;
        public CacheHelper()
        {
            instituteID = new UserAuthontication().InstituteID;
        }
        public string GetCacheKey(string key)
        {
            return instituteID.ToString() + "_" + key;
        }
        public object GetCacheData(string key, object returnObject)
        {
            if (HttpContext.Current.Cache[GetCacheKey(key)] != null)
                returnObject = HttpContext.Current.Cache[GetCacheKey(key)];
            else
                returnObject = null;
            return returnObject;
        }
        public void AddData(string key,object data)
        {
            HttpContext.Current.Cache[GetCacheKey(key)] = data;
        }
    }
}
