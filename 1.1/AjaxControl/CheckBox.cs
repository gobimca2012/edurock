using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AjaxControl
{
    public class CheckBox : System.Web.UI.WebControls.HyperLink
    {
        public bool Checked
        {
            get;
            set;
        }
        public string CheckedClassName
        {
            get;
            set;
        }
        public string CustomID
        {
            get;
            set;
        }
        
        protected override void OnLoad(EventArgs e)
        {
            if (Checked)
            {
                this.CssClass = "checked";
            }
            else
            {
                this.CssClass = "unchecked";
            }
            string _CheckClassName="checked";
            if (Checked )
            {
                _CheckClassName = "unchecked";
            }
            this.Attributes["href"] = "javascript:void(0);";
            this.Attributes["onclick"] = string.Format("$(this).CheckBox('{0}');", _CheckClassName);
            //this.Text = string.Format("<div id='{0}'></div>", this.ID);
            if (CustomID == null|| CustomID=="")
            {
                CustomID = ID;
            }
            this.Text = string.Format("<input id='{0}' type='text' value='111'></input>", this.CustomID);
            base.OnLoad(e);
        }
    }
}
