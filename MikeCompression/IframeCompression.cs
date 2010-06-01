using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace MikeCompression
{
    public class IframeCompression
    {
        public void Compress()
        {
            HttpContext context = HttpContext.Current;
            HttpRequest request = context.Request;
            string acceptEncoding = request.Headers["Accept-Encoding"];
            HttpResponse response = context.Response;
            if (!string.IsNullOrEmpty(acceptEncoding))
            {
                acceptEncoding = acceptEncoding.ToUpperInvariant();
                if (acceptEncoding.Contains("GZIP"))
                {
                    //response.Filter = new GZipStream(context.Response.Filter, 
                    //CompressionMode.Compress);
                    response.Filter = new InframeFilter(context.Response.Filter,
                                      CompressOptions.GZip);
                    response.AppendHeader("Content-encoding", "gzip");
                }
                else if (acceptEncoding.Contains("DEFLATE"))
                {
                    //response.Filter = new DeflateStream(context.Response.Filter, 
                    //CompressionMode.Compress);
                    response.Filter = new WhitespaceFilter(context.Response.Filter,
                                      CompressOptions.Deflate);
                    response.AppendHeader("Content-encoding", "deflate");
                }
            }
            response.Cache.VaryByHeaders["Accept-Encoding"] = true;
        }
    }
}
