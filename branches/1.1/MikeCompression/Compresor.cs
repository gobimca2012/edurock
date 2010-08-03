using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace MikeCompression
{
    public class Compresor
    {
        public void CompressPage()
        {
            HttpResponse Response = HttpContext.Current.Response;

            if (true)
            {
                string AcceptEncoding = HttpContext.Current.Request.Headers["Accept-Encoding"];
                if (AcceptEncoding.Contains("deflate"))
                {
                    Response.Filter = new System.IO.Compression.DeflateStream(Response.Filter,
                                               System.IO.Compression.CompressionMode.Compress);
                    Response.AppendHeader("Content-Encoding", "deflate");
                }
                else
                {
                    Response.Filter = new System.IO.Compression.GZipStream(Response.Filter,
                                              System.IO.Compression.CompressionMode.Compress);
                    Response.AppendHeader("Content-Encoding", "gzip");
                }
            }

            // Allow proxy servers to cache encoded and unencoded versions separately
            Response.AppendHeader("Vary", "Content-Encoding");

        }
    }

}
