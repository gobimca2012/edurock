// JavaScript Document
// JavaScript Document
var isRohanvaldate = true;
var isEmail = true;
var isMax = true;
var isMin = true;
var isMendatory = true;
var isDigit = true;
var isWebSite = true;
var isAlphbet = true;
var isPassword = true;
function MessageDisplay(obj, message)
{
   var pos = $(obj).offset();
   var width = $(obj).width();
   $("body").append("<div id='ValidationMessage'></div>");
   $("#ValidationMessage").html(message);
   $("#ValidationMessage").css(
   {
      left : (pos.left + width + 10) + 'px',
      top : pos.top - 5 + 'px',
      position : 'absolute',
      background : '#000',
      padding : '5px',
      color : '#fff'

   }
   );




}
function MessageDown()
{
   $("#ValidationMessage").html("");
   $("#ValidationMessage").remove();
//   $("#ValidationMessage").css(
//   {

//      position : 'relative',
//      background : '#fff',
//      padding : '0px',
//      color : '#fff'

//   }
//   );
}
$.fn.Mendatory = function(Message)
{
   isRohanvaldate = false;
   isMendatory = false;
   $(this).blur(function()
   {

      var data = $(this).val();
      if(data == null || data == "")
      {
         MessageDisplay(this, Message);
         isRohanvaldate = false;
      }
      else
      {
         $(this).css("background", "#FFF");
         MessageDown();
         isRohanvaldate = true;
         isMendatory = true;
      }
   }
   );

}

$.fn.MaximumLength = function(max, Message)
{
   isMax = false;
   isRohanvaldate = false;
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
         MessageDown();
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
         MessageDown();
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
   this.blur(function()
   {
      var data = $(this).val();
      for(i = 0; i < data.length; i ++ )
      {
         var num = data.charAt(i);
         if((num >= "0") && (num <= "9"))
         {
            $(this).css("background", "#FFF");
            MessageDown();
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
         MessageDown();
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
         MessageDown();
         isRohanvaldate = true;
         isWebSite = true;
      }

   }
   );

}
$.fn.AlphabetOnly = function(Message)
{
   isRohanvaldate = false;
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
         MessageDown();
         isRohanvaldate = true;
      }

   }
   );

}

$.fn.PasswordCompare = function(passid, Message)
{
   isRohanvaldate = false;
   this.blur(function()
   {
      var data = $(this).val();
      var data1 = $(passid).val();

      if(data == data1)
      {
         $(this).css("background", "#FFF");
         MessageDown();
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
      if(isRohanvaldate == false)
      {
         MessageDisplay(this, "Please fill form Properly");
      }
      else
      {
         MessageDown();
      }
      return isRohanvaldate;
   }
   );
}