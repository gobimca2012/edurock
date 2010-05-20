
var isRohanvaldate = true;
var isEmail = true;
var isMax = true;
var isMin = true;
var isMendatory = true;
var isDigit = true;
var isWebSite = true;
var isAlphbet = true;
var isPassword = true;
var unvalidIDs = new Array();

var idCounter = 0;
function addUnvalidID(id)
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
      idCounter = idCounter + 1;

   }
   if(unvalidIDs.length == 0)
   {
      idCounter = idCounter + 1;
      unvalidIDs[0] = id;
   }
}
function removeUnvalidID(id)
{

   var tempId = new Array();
   var tempcounter = 0;
   for(var i = 0; i < unvalidIDs.length; i ++ )
   {
      if(unvalidIDs[i] == id)
      {

      }
      else
      {
         tempId[tempcounter] = unvalidIDs[i];
         tempcounter = tempcounter + 1;
      }
   }
   idCounter = idCounter - 1;
   unvalidIDs = tempId;
}
function MessageDisplay(obj, message)
{
   var pos = $(obj).offset();
   var width = $(obj).width();
   var divid = $(obj).attr("id") + "val";
   var divhasid = "#" + divid;
   $(divhasid).remove();

   var containner = "<div id='"+divid+"' style='border:solid 10px #000;background:#c0c0c0;'><h1>Rohan</h1></div>";
   $("body").append(containner);
   $(divhasid).html(message);
   $(divhasid).css(
   {
      left : (pos.left + width + 10) + 'px',
      top : pos.top - 5 + 'px',
      position : 'absolute',
      background : '#000',
      padding : '5px',
      color : '#fff',
      border : 'solid 5px #000',
      width : '1000',
      height : '1000'

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
function insertValidationId(obj)
{
   var divid = $(obj).attr("id") + "val";
   var divhasid = "#" + divid;
   addUnvalidID(divhasid);
}
function Mendatory(obj)
{
   var data = $(obj).val();
   if(data == null || data == "")
   {
      insertValidationId(this);
      MessageDisplay(obj, Message);
      isRohanvaldate = false;
   }
   else
   {
      $(obj).css("background", "#FFF");
      MessageDown(obj);
      isRohanvaldate = true;
      isMendatory = true;
   }
}
$.fn.Mendatory = function(Message)
{
   isRohanvaldate = false;
   isMendatory = false;
   Mendatory(this);
   $(this).blur(function()
   {
      Mendatory(this);

   }
   );

}

$.fn.MaximumLength = function(max, Message)
{
   isMax = false;
   isRohanvaldate = false;
   insertValidationId(this);
   this.blur(function()
   {
      var data = $(this).val();
      if(data.length > max)
      {
         MessageDisplay(this, Message);
         isRohanvaldate = false;
      }
      else
      {
         $(this).css("background", "#FFF");
         MessageDown(this);
         isMax = true;
         isRohanvaldate = true;
      }
   }
   );

}

$.fn.MinLength = function(min, Message)
{
   isMin = false;
   isRohanvaldate = false;
   insertValidationId(this);
   this.blur(function()
   {
      var data = $(this).val();
      if(data.length < min)
      {
         MessageDisplay(this, Message);
         isRohanvaldate = false;
      }
      else
      {
         $(this).css("background", "#FFF");
         MessageDown(this);
         isMin = true;
         isRohanvaldate = true;
      }
   }
   );

}

$.fn.DigitOnly = function(Message)
{
   isDigit = false;
   isRohanvaldate = false;
   insertValidationId(this);
   this.blur(function()
   {
      var data = $(this).val();
      for(i = 0; i < data.length; i ++ )
      {
         var num = data.charAt(i);
         if((num >= "0") && (num <= "9"))
         {
            $(this).css("background", "#FFF");
            MessageDown(this);
            isRohanvaldate = true;
            isDigit = true;
         }
         else
         {
            MessageDisplay(this, Message);
            isRohanvaldate = false;
         }
      }

   }
   );

}

$.fn.Email = function(Message)
{
   isEmail = false;
   isRohanvaldate = false;
   insertValidationId(this);
   this.blur(function()
   {
      var data = $(this).val();
      var reg = /^([A-Za-z0-9_\-\.])+\@([A-Za-z0-9_\-\.])+\.([A-Za-z]{2,4})$/;
      if(reg.test(data) == false)
      {
         MessageDisplay(this, Message);
         isRohanvaldate = false;
      }
      else
      {
         $(this).css("background", "#FFF");
         MessageDown(this);
         isRohanvaldate = true;
         isEmail = true;
      }

   }
   );

}

$.fn.WebSite = function(Message)
{
   isWebSite = false;
   isRohanvaldate = false;
   insertValidationId(this);
   this.blur(function()
   {
      var data = $(this).val();
      // var reg = /^http:\/\/www\.[a-z]+\.(com)|(org)|(edu)|(net)$/
      var reg = /^(([\w]+:)?\/\/)?(([\d\w]|%[a-fA-f\d]{2,2})+(:([\d\w]|%[a-fA-f\d]{2,2})+)?@)?([\d\w][-\d\w]{0,253}[\d\w]\.)+[\w]{2,4}(:[\d]+)?(\/([-+_~.\d\w]|%[a-fA-f\d]{2,2})*)*(\?(&?([-+_~.\d\w]|%[a-fA-f\d]{2,2})=?)*)?(#([-+_~.\d\w]|%[a-fA-f\d]{2,2})*)?$/;
      if(reg.test(data) == false)
      {
         MessageDisplay(this, Message);
         isRohanvaldate = false;
      }
      else
      {
         $(this).css("background", "#FFF");
         MessageDown(this);
         isRohanvaldate = true;
         isWebSite = true;
      }

   }
   );

}
$.fn.AlphabetOnly = function(Message)
{
   isRohanvaldate = false;
   insertValidationId(this);
   this.blur(function()
   {
      var data = $(this).val();
      // var reg = /^http:\/\/www\.[a-z]+\.(com)|(org)|(edu)|(net)$/
      var reg = /[a-zA-z]/;
      if(reg.test(data) == false)
      {
         MessageDisplay(this, Message);
         isRohanvaldate = false;
      }
      else
      {
         $(this).css("background", "#FFF");
         MessageDown(this);
         isRohanvaldate = true;
      }

   }
   );

}

$.fn.PasswordCompare = function(passid, Message)
{
   isRohanvaldate = false;
   insertValidationId(this);
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
         $(this).focus();

         if(unvalidIDs.length > 0)
         {
            var idfocus = unvalidIDs[0].replace("val", "");
            $(idfocus).focus();
            return false;
            return isRohanvaldate;
         }
         return false;
         return isRohanvaldate;
      }

   }
   );
}