using System;
namespace MikeControls
{
    public class LinkButton:System.Web.UI.WebControls.LinkButton
    {
        protected override void OnLoad(System.EventArgs e)
        {
            Page.ClientScript.RegisterStartupScript(GetType(), "addClickFunctionScript",
                _addClickFunctionScript, true);

            string script = String.Format(_addClickScript, ClientID);
            Page.ClientScript.RegisterStartupScript(GetType(), "click_" + ClientID,
                script, true);
            base.OnLoad(e);
        }

        private const string _addClickScript = "addClickFunction('{0}');";

        private const string _addClickFunctionScript =
            @"function addClickFunction(id)
{
   {
      var b = document.getElementById(id);
      if (b && typeof(b.click) == 'undefined') b.click = function()
      {
         {
            var result = true;
            if (b.onclick) result = b.onclick();
            if (typeof(result) == 'undefined' || result)
            {
               {
                  try
                  {
                     $('#' + id).trigger('click');
                      //  alert(isValidate);
                     if(IsValidateSuccessFully)
                     {
                        eval(b.getAttribute('href'));
                     }
                  }
                  catch(ee)
                  {
                   // alert(ee);
                     eval(b.getAttribute('href'));
                  }
               }
            }
         }
      }
   }
}
;";
    }
}
