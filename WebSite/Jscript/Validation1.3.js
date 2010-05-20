var isPassword = true;
var unvalidIDs = new Array();
var validationType = new Array();
var validationMessage = new Array();
var idCounter = 0;
var showupID = new Array();
var IsValidateSuccessFully=false;
function ControlObject(obj, message, type, param1, param2)
{
   this.obj = obj;
   this.message = message;
   this.param1 = param1;
   this.param2 = param2;
   var divid = $(obj).attr("id") + "val";
   var divhasid = "#" + divid;
   this.id = divid;
   this.hasid = divhasid;
   this.type = type;
   this.cid = $(obj).attr("id");
}
function addUnvalidObject(obj)
{
   for(var i = 0; i < unvalidIDs.length; i ++ )
   {
      var needtoAdd = true;
      if(unvalidIDs[i] == obj)
      {
         needtoAdd = false;
      }
   }
   if(needtoAdd == true)
   {
      unvalidIDs[idCounter] = obj;
      idCounter = idCounter + 1;
   }
   if(unvalidIDs.length == 0)
   {
      idCounter = idCounter + 1;
      unvalidIDs[0] = obj;
   }
}
function MessageDisplay(obj, message)
{
   var pos = $(obj).offset();
   var width = $(obj).width();
   var divid = $(obj).attr("id") + "val";
   var divhasid = "#" + divid;
   $(divhasid).remove();
   for(var i = 0; i < unvalidIDs.length; i ++ )
   {
      if(unvalidIDs[i].divid == divid)
      {

      }
      else
      {
         var downHasDiv = "#" + unvalidIDs[i].divid;
         $(downHasDiv).remove();
      }
   }
   var containner = "<div id='"+divid+"'><h1>Rohan</h1></div>";
   //$("body").append(containner);
   $('#'+$(obj).attr("id")).parent().append(containner);
   $(divhasid).html(message);
   $(divhasid).css(
   {
      left : (pos.left + width + 10) + 'px',
      top : pos.top - 20 + 'px'      
   }
   );
   $(divhasid).addClass('valtooltip');
   showupID[showupID.length] = divhasid;
}
function MessageDown(obj)
{
   var divid = $(obj).attr("id") + "val";
   var divhasid = "#" + divid;
   var goFlag = true;
   for(var i = 0; i < showupID.length; i ++ )
   {
      if(showupID[i] == divhasid)
      {
         goFlag = false;
      }
   }
   if(goFlag == true)
   {
      $(divhasid).remove();
   }
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
   var maxlen = new ControlObject(this, Message, "mendatory", 0, "");
   addUnvalidObject(maxlen);
}
function MaximumLength(obj, max, Message)
{
   var data = $(obj).val();
   var maxval = parseInt(max);
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
   var maxlen = new ControlObject(this, Message, "max", max, "");
   addUnvalidObject(maxlen);

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
   var maxlen = new ControlObject(this, Message, "min", min, "");
   addUnvalidObject(maxlen);

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
function NoSpecialCharector(obj, Message)
{
   var data = $(obj).val();
   var iChars = "!@#$%^&*()+=-[]\\\';,./{}|\":<>?~_";
   for (var i = 0; i < data.length; i ++ )
   {
      if (iChars.indexOf(data.charAt(i)) != - 1)
      {
         MessageDisplay(obj, Message);
         return false;
      }

   }
   MessageDown(obj);
   return true;
}

$.fn.DigitOnly = function(Message)
{
   var maxlen = new ControlObject(this, Message, "dig", 0, "");
   addUnvalidObject(maxlen);

}
$.fn.NoSpecialChar = function(Message)
{
   var maxlen = new ControlObject(this, Message, "nospe", 0, "");
   addUnvalidObject(maxlen);

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
   var maxlen = new ControlObject(this, Message, "email", 0, "");
   addUnvalidObject(maxlen);
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
   var maxlen = new ControlObject(this, Message, "website", 0, "");
   addUnvalidObject(maxlen);
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
   var maxlen = new ControlObject(this, Message, "alph", 0, "");
   addUnvalidObject(maxlen);
}

$.fn.dropdownMandatory = function(Message, selectedvalue)
{
   var maxlen = new ControlObject(this, Message, "ddm", selectedvalue, "");
   addUnvalidObject(maxlen);

}
$.fn.birthdayDropdownMandatory = function(Message,dd1,dd2)
{
   var maxlen = new ControlObject(this, Message, "bday", dd1, dd2);
   addUnvalidObject(maxlen);

}
$.fn.CompartTextBox = function(id2, Message)
{
   var maxlen = new ControlObject(this, Message, "comp", id2, "");
   addUnvalidObject(maxlen);
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
function CompartTextBox(obj, id2, Message)
{
   var data = $(obj).val();
   var data1 = $(id2).val();
   if(data == data1)
   {
      MessageDown(obj);
      return true;

   }
   else
   {
      MessageDisplay(obj, Message);
      return false;
   }
}
function GetDropdownSelected(id)
{
   var obj = document.getElementById(id);
   for (var i = 0; i < obj.options.length; i ++ )
   {
      if (obj.options[ i ].selected)
      {
         //         alert(obj.options[ i ].value);
         return obj.options[ i ].value;
      }
   }
}

$.fn.ValidateButton = function()
{

   $(this).click(function()
   {
      IsValidateSuccessFully=false;
      showupID = new Array();
      var goahead = false;
      var isValidate = true;
      if(unvalidIDs.length > 0)
      {
         var xaxaddd = unvalidIDs;
         for(var i = 0; i < unvalidIDs.length; i ++ )
         {
            var idvalid = unvalidIDs[i].hasid.replace("val", "");
            if(unvalidIDs[i].type == "mendatory")
            {
               goahead = Mendatory($(idvalid), unvalidIDs[i].message);
               if(goahead == false)
               {
                  if(isValidate == true)
                  {
                     $(idvalid).focus();
                  }
                  isValidate = goahead;

                  // return false;
               }

            }
            else if(unvalidIDs[i].type == "max")
            {
               goahead = MaximumLength($(idvalid), unvalidIDs[i].param1, unvalidIDs[i].message);
               if(goahead == false)
               {
                  if(isValidate == true)
                  {
                     $(idvalid).focus();
                  }
                  isValidate = goahead;
                  // return false;
               }
            }
            else if(unvalidIDs[i].type == "comp")
            {
               goahead = CompartTextBox($(idvalid), "#" + unvalidIDs[i].param1, unvalidIDs[i].message);
               if(goahead == false)
               {
                  if(isValidate == true)
                  {
                     $(idvalid).focus();
                  }
                  isValidate = goahead;
                  // return false;
               }
            }
            else if(unvalidIDs[i].type == "min")
            {
               goahead = MinimumLength($(idvalid), unvalidIDs[i].param1, unvalidIDs[i].message);
               if(goahead == false)
               {
                  if(isValidate == true)
                  {
                     $(idvalid).focus();
                  }
                  isValidate = goahead;
                  // return false;
               }
            }
            else if(unvalidIDs[i].type == "dig")
            {
               goahead = DigitOnly($(idvalid), unvalidIDs[i].message);
               if(goahead == false)
               {
                  if(isValidate == true)
                  {
                     $(idvalid).focus();
                  }
                  isValidate = goahead;
                  // return false;
               }
            }
            else if(unvalidIDs[i].type == "nospe")
            {
               goahead = NoSpecialCharector($(idvalid), unvalidIDs[i].message);
               if(goahead == false)
               {
                  if(isValidate == true)
                  {
                     $(idvalid).focus();
                  }
                  isValidate = goahead;
                  // return false;
               }
            }
            else if(unvalidIDs[i].type == "website")
            {
               goahead = WebSite($(idvalid), unvalidIDs[i].message);
               if(goahead == false)
               {
                  if(isValidate == true)
                  {
                     $(idvalid).focus();
                  }
                  isValidate = goahead;
                  // return false;
               }
            }
            else if(unvalidIDs[i].type == "alph")
            {
               goahead = AlphabetOnly($(idvalid), unvalidIDs[i].message);
               if(goahead == false)
               {
                  if(isValidate == true)
                  {
                     $(idvalid).focus();
                  }
                  isValidate = goahead;
                  // return false;
               }
            }
            else if(unvalidIDs[i].type == "email")
            {
               goahead = Email($(idvalid), unvalidIDs[i].message);
               if(goahead == false)
               {
                  if(isValidate == true)
                  {
                     $(idvalid).focus();
                  }
                  isValidate = goahead;
                  // return false;
               }
            }
            else if(unvalidIDs[i].type == "ddm")
            {
               var ddval = GetDropdownSelected(unvalidIDs[i].cid);
               if(ddval == unvalidIDs[i].param1)
               {
                  MessageDisplay($(idvalid), unvalidIDs[i].message);
                  goahead = false;
               }
               else
               {
                  MessageDown($(idvalid));
                  goahead = true;
               }
               if(goahead == false)
               {
                  if(isValidate == true)
                  {
                     $(idvalid).focus();
                  }
                  isValidate = goahead;
                  // return false;
               }
            }
            else if(unvalidIDs[i].type == "bday")
            {
               var ddval = GetDropdownSelected(unvalidIDs[i].cid);
               var ddval1 = GetDropdownSelected(unvalidIDs[i].param1);
               var ddval2 = GetDropdownSelected(unvalidIDs[i].param2);
               if(ddval == '0'|| ddval1=='0'|| ddval2=='0')
               {
                  MessageDisplay($('#'+unvalidIDs[i].param2), unvalidIDs[i].message);
                  goahead = false;
               }
               else
               {
                  MessageDown($('#'+unvalidIDs[i].param2));
               }
               if(goahead == false)
               {
                  if(isValidate == true)
                  {
                     $(idvalid).focus();
                  }
                  isValidate = goahead;
                  // return false;
               }
            }

         }
         IsValidateSuccessFully=isValidate;
         return isValidate;
      }
      else
      {
         return true;
      }

   }
   );
}

function DatePickerValidate(id1, id2)
{
   $(id1).datepicker(
   {
      dateFormat : 'mm/dd/yy',
      minDate : new Date(),
      onSelect : function(dateText, inst)
      {
         var myDateParts = dateText.split("/");
         var dday = myDateParts[1];
         var dmonthyear = myDateParts[0];
         var dyear = myDateParts[2] ;
         $(id2).removeAttr("disabled");
         $(id2).datepicker(
         {
            dateFormat : 'mm/dd/yy',
            minDate : new Date(dyear, dmonthyear - 1, dday)
         }
         );
      }

   }
   );
   $(id2).attr("disabled", "disabled");
}