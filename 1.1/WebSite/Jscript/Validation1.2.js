var isPassword = true;
var unvalidIDs = new Array();
var validationType = new Array();
var validationMessage = new Array();
var idCounter = 0;
$(function()
{
   for(var i = 0; i < unvalidIDs.length; i ++ )
   {
      var idvalid = unvalidIDs[i].replace("val", "");
      if(validationType[i] == "mendatory")
      {
         if(Mendatory($(idvalid), validationMessage[i])==true)
         {
            i=i-1;
         }         
      }
   }
}
);

function addUnvalidID(id, type, Message)
{
   for(var i = 0; i < unvalidIDs.length; i ++ )
   {
      var needtoAdd = true;
      if(unvalidIDs[i] == id)
      {
         needtoAdd = false;
      }

   }
   if(needtoAdd == true)
   {
      unvalidIDs[idCounter] = id;
      validationType[idCounter] = type;
      validationMessage[idCounter] = Message;
      idCounter = idCounter + 1;

   }
   if(unvalidIDs.length == 0)
   {
      idCounter = idCounter + 1;
      unvalidIDs[0] = id;
      validationType[0] = type;
      validationMessage[0] = Message;
   }
}
function removeUnvalidID(id)
{

   var tempId = new Array();
   var tempType = new Array();
   var tempMessage = new Array();
   var tempcounter = 0;
   for(var i = 0; i < unvalidIDs.length; i ++ )
   {
      if(unvalidIDs[i] == id)
      {

      }
      else
      {
         tempId[tempcounter] = unvalidIDs[i];
         tempType[tempcounter] = validationType[i];
         tempMessage[tempcounter] = validationMessage[i];
         tempcounter = tempcounter + 1;
      }
   }
   idCounter = idCounter - 1;
   unvalidIDs = tempId;
   validationType = tempType;
   validationMessage = tempMessage;

}
function MessageDisplay(obj, message)
{
   var pos = $(obj).offset();
   var width = $(obj).width();
   var divid = $(obj).attr("id") + "val";
   var divhasid = "#" + divid;
   $(divhasid).remove();

   var containner = "<div id='"+divid+"' style='border:solid 1px #000;background:#fff;padding:5px' class='ui-corner-all'><h1>Rohan</h1></div>";
   $("body").append(containner);
   $(divhasid).html(message);
   $(divhasid).css(
   {
      left : (pos.left+width+2) + 'px',
      top : pos.top -2 + 'px',
      position : 'absolute',
      background : '#fff',
      padding : '5px',
      color : '#000',
      border : 'solid 2px #000'

   }
   );




}
function MessageDown(obj)
{

   var divid = $(obj).attr("id") + "val";
   var divhasid = "#" + divid;
   $(divhasid).remove();
   removeUnvalidID(divhasid);
}
function insertValidationId(obj, type, Message)
{
   var divid = $(obj).attr("id") + "val";
   var divhasid = "#" + divid;
   addUnvalidID(divhasid, type, Message);
}

function Mendatory(obj, Message)
{
   var data = $(obj).val();
   if(data == null || data == "")
   {
      MessageDisplay(obj, Message);
      return false;
   }
   else
   {
      $(obj).css("background", "#FFF");
      MessageDown(obj);
      return true;
   }
}
$.fn.Mendatory = function(Message)
{
   insertValidationId(this, "mendatory", Message);
   $(this).focusout(function()
   {
      Mendatory(this, Message);

   }
   );
   $(this).change(function()
   {
      Mendatory(this, Message);

   }
   );

}
function MaximumLength(obj, max, Message)
{
   var data = $(obj).val();
   var maxval=parseInt(max);
   if(data.length > maxval)
   {
      MessageDisplay(obj, Message);
      return false;
   }
   else
   {
      $(obj).css("background", "#FFF");
      MessageDown(obj);
      isMax = obj;
      return true;
   }
}
$.fn.MaximumLength = function(max, Message)
{
   insertValidationId(this, "max", Message);
   this.focusout(function()
   {
      MaximumLength(this, max, Message);
   }
   );

}
function MinimumLength(obj, min, Message)
{
   var data = $(obj).val();
   if(data.length < min)
   {
      MessageDisplay(obj, Message);
      return false;
   }
   else
   {
      $(obj).css("background", "#FFF");
      MessageDown(obj);
      return true;
   }
}
$.fn.MinLength = function(min, Message)
{
   insertValidationId(this, "min", Message);
   this.focusout(function()
   {
      MinimumLength(this, min, Message);
   }
   );

}
function DigitOnly(obj, Message)
{
   var data = $(obj).val();
   for(i = 0; i < data.length; i ++ )
   {
      var num = data.charAt(i);
      if((num >= "0") && (num <= "9"))
      {
         $(obj).css("background", "#FFF");
         MessageDown(obj);
         return true;
      }
      else
      {
         MessageDisplay(obj, Message);
         return false;
      }
   }

}
$.fn.DigitOnly = function(Message)
{
   insertValidationId(this, "digi", Message);
   this.focusout(function()
   {
      DigitOnly(this, Message);
   }
   );

}
function Email(obj, Message)
{
   var data = $(obj).val();
   var reg = /^([A-Za-z0-9_\-\.])+\@([A-Za-z0-9_\-\.])+\.([A-Za-z]{2,4})$/;
   if(reg.test(data) == false)
   {
      MessageDisplay(obj, Message);
      return false;
   }
   else
   {
      $(obj).css("background", "#FFF");
      MessageDown(obj);
      return true;
   }

}
$.fn.Email = function(Message)
{
   insertValidationId(this, "email", Message);
   this.focusout(function()
   {
      Email(this, Message);
   }
   );

}
function WebSite(obj, Message)
{
   var data = $(obj).val();
   // var reg = /^http:\/\/www\.[a-z]+\.(com)|(org)|(edu)|(net)$/
   var reg = /^(([\w]+:)?\/\/)?(([\d\w]|%[a-fA-f\d]{2,2})+(:([\d\w]|%[a-fA-f\d]{2,2})+)?@)?([\d\w][-\d\w]{0,253}[\d\w]\.)+[\w]{2,4}(:[\d]+)?(\/([-+_~.\d\w]|%[a-fA-f\d]{2,2})*)*(\?(&?([-+_~.\d\w]|%[a-fA-f\d]{2,2})=?)*)?(#([-+_~.\d\w]|%[a-fA-f\d]{2,2})*)?$/;
   if(reg.test(data) == false)
   {
      MessageDisplay(obj, Message);
      return false;
   }
   else
   {
      $(obj).css("background", "#FFF");
      MessageDown(obj);
      return true;
   }

}
$.fn.WebSite = function(Message)
{
   insertValidationId(this, "website", Message);
   this.focusout(function()
   {
      WebSite(this, Message);
   }
   );

}
function AlphabetOnly(obj, Message)
{
   var data = $(obj).val();
   // var reg = /^http:\/\/www\.[a-z]+\.(com)|(org)|(edu)|(net)$/
   var reg = /[a-zA-z]/;
   if(reg.test(data) == false)
   {
      MessageDisplay(obj, Message);
      return false;
   }
   else
   {
      $(obj).css("background", "#FFF");
      MessageDown(obj);
      return true;
   }

}
$.fn.AlphabetOnly = function(Message)
{
   insertValidationId(this, "alpha", Message);
   this.focusout(function()
   {
      AlphabetOnly(Message);
   }
   );

}

$.fn.PasswordCompare = function(passid, Message)
{
   isRohanvaldate = false;
   // insertValidationId(this);
   this.blur(function()
   {
      var data = $(this).val();
      var data1 = $(passid).val();

      if(data == data1)
      {
         $(this).css("background", "#FFF");
         MessageDown(this);
         isRohanvaldate = true;

      }
      else
      {
         MessageDisplay(this, Message);
         isRohanvaldate = false;
      }

   }
   );

}

$.fn.ValidateButton = function()
{

   $(this).click(function()
   {
      if(unvalidIDs.length > 0)
      {
         var idfocus = unvalidIDs[0].replace("val", "");
         $(idfocus).focus();
         for(var i = 0; i < unvalidIDs.length; i ++ )
         {
            var idvalid = unvalidIDs[i].replace("val", "");
            if(validationType[i] == "mendatory")
            {
               Mendatory($(idvalid), validationMessage[i]);
               return false;
            }
         }
         return false;
      }
      else
      {
         return true;
      }

   }
   );
}