using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Collections;
using System.IO;
using System.Web.SessionState;
using System.Drawing;

namespace ImageHandlerLib
{
    public class ImageHandler : IHttpHandler, IRequiresSessionState
    {
        private string XLen = "110";
        private string YLen = "110";

            
        #region IHttpHandler Members

        public bool IsReusable
        {
            get { return true; }
        }

        public void ProcessRequest(HttpContext context)
        {
            string name = context.Request.QueryString["name"];
            string size = context.Request.QueryString["size"];

            if (string.IsNullOrEmpty(name)) return;
            string filepath = context.Server.MapPath(name);

            //filepath = Path.Combine(filepath, Path.GetFileName(name));
            if (!File.Exists(filepath))
            {
                filepath="D:\\Rohan\\Projects\\Crameasy\\WebSite\\images\\DefaultAvtar.png";
            }
            switch (size)
            {
                case "1": //small
                    ImageHelper.WriteThumbnailSimple(context, filepath, 64);
                    break;
                case "2": //medium
                    ImageHelper.WriteThumbnail(context, filepath, 200);
                    break;
                default: //original
                    ImageHelper.WriteImage(context, filepath);
                    break;
            }
        }
 

        private byte[] GenerateThumbnail(Stream fStream, string xLen, string yLen)
        {
            Image img = Image.FromStream(fStream);
            Image thumbnailImage = img.GetThumbnailImage(int.Parse(xLen),int.Parse(yLen), new Image.GetThumbnailImageAbort(ThumbnailCallback), IntPtr.Zero);
            
            MemoryStream imageStream = new MemoryStream();        
            thumbnailImage.Save(imageStream, System.Drawing.Imaging.ImageFormat.Jpeg);

            byte[] imageContent = new Byte[imageStream.Length];
            imageStream.Position = 0;
            imageStream.Read(imageContent, 0, (int)imageStream.Length);
            return imageContent;
        }
        public bool ThumbnailCallback()
        {
            return true;
        }
        #endregion
    }
}
