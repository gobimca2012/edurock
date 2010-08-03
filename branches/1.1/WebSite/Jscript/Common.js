// JavaScript Document
$.fn.serializeNoViewState = function()
{
   var data = this.find("input,textarea,select,input[type=file]")
   .not("[type=hidden][name^=__]")
   .serialize();
   return  data;
}
$.fn.ToolTipMouseHover = function()
{
   $(this).hover(
   function ()
   {
      var po = $(this).offset();

      var len = $(this).width();
      var left = po.left + 25;
      $('.eventtip', this).css(
      {
         left : left + 'px',
         border : 'solid 1px #cfcfcf',
         padding : '5px',
         background : '#fff',
         position : 'absolute',
         display : 'block',
         height : 'auto',
         width : 'auto'
      }
      );

   }
   ,
   function ()
   {
      $('.eventtip', this).css(
      {
         position : 'relative',
         display : 'none'

      }
      );
   }
   );

}
$.fn.ToolTipCourse = function()
{
   $("#tooltipcontainer").addClass("loading");
   $(this).click(function()
   {

      var pos = $(this).offset();
      var width = $(this).width();
      $("#tooltipcontainer").css(
      {
         left : (300) + 'px',
         top : 100 + 'px',
         width : '300px',
         height : '300px'
      }
      );

      var CollegeID = $(this).attr('rel')
      var Path = $(this).attr('rev')
      $.ajax(
      {
         type : 'GET',
         url : Path,
         success : function(data)
         {
            $("#tooltipcontainer").html("Loading................");
            data = $(data).find("#tooltipcontent");
            $("#tooltipcontainer").html('&nbsp;');
            $("#tooltipcontainer").html(data);
            linkparse("#tooltipcontainer");
         }

      }
      );
      $("#tooltipcontainer").removeClass("loading");
      return false;
   }
   );
}


$.fn.PU = function(url)
{

   var id = $(this).attr("id");
   id = "#" + id;
   $(this).html("");
   $(this).html("Loading................");
   $(this).dialog(
   {
      open : function()
      {
         $.ajax(
         {
            type : 'POST',
            url : url,
            success : function(data)
            {
               data = $(data).find(".content");

               $(id).html(data);
               linkparse(id);
               $(id).dialog('option', 'position', 'center');
            }

         }
         );
      }
      ,
      position : 'center',
      width : "auto",
      minWidth : "400",
      close : function(event, ui)
      {
         $(this).dialog('destroy');
      }

   }
   );

}

$.fn.PUI = function(url)
{
   var id = $(this).attr("id");
   id = "#" + id;
   $(this).html("");
   $(this).html("Loading................");

   var str = "<iframe id='popup' frameborder='0' src='";
   str += url;
   str += "' style='width:auto;height:auto; overflow:auto;'></iframe>";
   $(this).html(str);
   $(this).dialog(
   {
      position : 'center',
      width : "auto",

      minWidth : "400",
      close : function(event, ui)
      {
         $(this).dialog('destroy');
      }
   }
   );
   linkparse(id);
   return false;

}
$.fn.PUIW = function(url, swidth, sheight)
{
   var id = $(this).attr("id");
   id = "#" + id;
   $(this).html("");
   $(this).html("Loading................");

   var str = "<iframe id='Ipopup' ALLOWTRANSPARENCY='true' frameborder='0' src='";
   str += url;
   str += "' style='width:" + swidth + "px;height:" + sheight + "px; background:none; overflow:auto;'></iframe>";
   $(this).html(str);
   $(this).dialog(
   {
      position : 'center',
      width : 'auto',
      height : 'auto',
      close : function(event, ui)
      {
         $(this).dialog('destroy');
      }
   }
   );
   $("#Ipopup").css(
   {
      width : "'"+swidth+"'px",
      height : "'"+sheight+"'px"
   }
   );
   linkparse(id);
   return false;

}

$.fn.ToolTipClose = function()
{

   $("#tooltipcontainer").empty();

}

$.fn.LP = function(id, url)
{
   $(this).html("Loading...");
   $.ajax(
   {
      type : "POST",
      url : url,
      contentType : "application/json; charset=utf-8",
      dataType : "html",
      success : function(message)
      {
         $(this).html("Loading................");
         message = $(message).find(".content").html();
         $(id).html(message);
         linkparse(id);
      }
      ,
      error : function(errormessage)
      {
         $(id).removeClass("loading");
      }
   }
   );


}

$.fn.LPJ = function(id, url)
{
   $(this).html("Loading...");
   $.ajax(
   {
      type : "POST",
      url : url,
      contentType : "application/json; charset=utf-8",
      dataType : "json",
      success : function(message)
      {
         $(this).html("Loading................");
         message = $(message).find(".content").html();
         $(id).html(message);
         linkparse(id);
      }
      ,
      error : function(errormessage)
      {
         $(id).removeClass("loading");
      }
   }
   );


}




$.fn.LoadPage = function(url)
{
   var id = $(this).attr("id");
   id = "#" + id;
   $(this).html("Loading...");
   $.ajax(
   {
      type : "POST",
      url : url,
      contentType : "application/json; charset=utf-8",
      dataType : "html",
      data :
      {
      }
      ,
      success : function(message)
      {
         message = $(message).find(".content");
         $(id).html(message);
         $(id).find("a").filter(function()
         {
            ParseParam(this);
         }
         );
         return false;

      }
      ,
      error : function(errormessage)
      {

         $(id).removeClass("loading");
         return false;
      }
   }
   );
   return false;


}


$.fn.AjaxPost = function(url, pdata)
{

   $.ajax(
   {
      type : "GET",
      url : url,
      data : "{'orderArray':'"+pdata+"'}",
      contentType : "application/json; charset=utf-8",
      dataType : "json",
      success : function(message)
      {
         alert(message);
      }
      ,
      error : function(errormessage)
      {
         alert(errormessage);
      }
   }
   );

}

function linkparse(id)
{
   $(id).find("a").filter(function()
   {
      ParseParam(this);
   }
   );
}
function SuccessHtml(obj, htm)
{
   $(this).html(replacehtml);
   linkparse(id);
}

$.fn.LPP = function(url)
{

   var data = $(this).serializeNoViewState();
   $(this).html("Loading...");
   var id = $(this).attr("id");
   id = "#" + id;
   $.post(url, data,
   function(result)
   {

      result = $(result).find(".content").html();
      $(id).html(result);

      linkparse(id);
   }
   );
}
$.fn.LPPR = function(url)
{

   var data = $().serializeNoViewState();
   $(this).html("Loading...");
   var id = $(this).attr("id");
   id = "#" + id;
   $.post(url, data,
   function(result)
   {

      result = $(result).find(".content").html();
      $(id).replaceWith(result);
      linkparse(id);
   }
   );
}
$.fn.LPPF = function(formid, url)
{

   var data = $(formid).serializeNoViewState();
   $(this).html("Loading...");
   var id = $(this).attr("id");
   id = "#" + id;
   $.post(url, data,
   function(result)
   {

      result = $(result).find(".content").html();
      $(id).html(result);
      linkparse(id);
   }
   );
}


$.fn.COAUTO = function(url)
{
   var id = $(this).attr("id");
   id = "#" + id;

   $.ajax(
   {
      type : "POST",
      url : url,
      data : "{}",
      contentType : "application/json; charset=utf-8",
      dataType : "json",
      success : function(msg)
      {

         $(id).autocomplete(msg.d,
         {
            autoFill : true
         }

         );
      }
   }
   );
}
$.fn.PCS = function()
{
   $(this).replaceWith("");
}
$.fn.AJP = function(url, jsonData)
{
   $.ajax(
   {
      type : "POST",
      url : url,
      contentType : "application/json; charset=utf-8",
      data : jsonData,
      dataType : "json",
      success : function(msg)
      {
         return true;
      }

   }
   );
}
$.fn.AJP = function(url, jsonData)
{
   $.ajax(
   {
      type : "POST",
      url : url,
      contentType : "application/json; charset=utf-8",
      data : jsonData,
      dataType : "json",
      success : function(msg)
      {
         return true;
      }

   }
   );
}

$.fn.POCLOSE = function()
{

   $(this).empty();

}
$.fn.MSG = function(message)
{

   $(this).html(message);

}
function ParseParam(domobj)
{
   var strparam = $(domobj).attr("rel");
   var mySplitResult = strparam.split("|vt|");

   switch (mySplitResult[0])
   {
      case "LoadPage" :
         $(domobj).click(function()
         {
            $(mySplitResult[1]).LoadPage(mySplitResult[2]);
         }
         );

         break;
      case "VTPU" :
         $(domobj).click(function()
         {
            $(mySplitResult[1]).PU(mySplitResult[2]);
         }
         );

         break;
      case "LPP" :
         $(domobj).click(function()
         {
            $(mySplitResult[1]).LPP(mySplitResult[2]);
         }
         );

         break;

   }
}

$.fn.WidgetAdd = function(url)
{

   var id = $(this).attr("id");
   id = "#" + id;
   $.ajax(
   {
      type : "POST",
      url : url,
      contentType : "application/json; charset=utf-8",
      dataType : "html",
      success : function(message)
      {

         message = $(message).find(".content").html();
         $(id).append(message);
         linkparse(id);
         UpdateDockSerialization(id, "/WebSite/Pages/Customize.aspx/UpdateSerialization");

      }
      ,
      error : function(errormessage)
      {
         $(id).removeClass("loading");
      }
   }
   );

}

$.fn.WidgetEdit = function(url)
{

   var id = $(this).attr("id");
   id = "#" + id;
   $(this).html("Loading...");
   $.ajax(
   {
      type : "POST",
      url : url,
      contentType : "application/json; charset=utf-8",
      dataType : "html",
      success : function(message)
      {

         message = $(message).find(".content").html();
         $(id).replaceWith(message);
         $(id).find("a").filter(function()
         {
            ParseParam(this);
         }
         );

      }
      ,
      error : function(errormessage)
      {
         $(id).removeClass("loading");
      }
   }
   );

}

function UpdateDockSerialization(ColumnpanelID, url)
{
   var data = $(ColumnpanelID).sortable('toArray');
   var jsondata = "";
   for(var i = 0; i < data.length; i ++ )
   {
      if(i != data.length - 1)
      {
         jsondata += "'"+data[i]+"',"
      }
      else
      {
         jsondata += "'"+data[i]+"'"
      }

   }
   var myjson = "{'SerData':[" + jsondata + "]}";
   $.ajax(
   {
      type : "POST",
      url : url,
      contentType : "application/json; charset=utf-8",
      dataType : "json",
      data : myjson,
      success : function(message)
      {
         alert("success");
      }
      ,
      error : function(errormessage)
      {
         alert("Fail");
      }
   }
   );
   linkparse(id);

}

$.fn.ToolTipURl = function(url)
{
   $(this).click(function()
   {
      var pos = $(this).offset();
      var width = $(this).width();
      $("#tooltipcontainer").css(
      {
         left : (pos.left + width) + 'px',
         top : pos.top - 5 + 'px',
         width : '300px',
         height : '300px'
      }
      );
      $("#tooltipcontainer").LPP(url);
      return false;
   }
   );
}


$.fn.LoadPageNoReplace = function(url)
{
   $.ajax(
   {
      type : "POST",
      url : url,
      contentType : "application/json; charset=utf-8",
      dataType : "html",
      success : function(message)
      {

      }
      ,
      error : function(errormessage)
      {

      }
   }
   );


}

$.fn.textWaterMark = function(textMessage)
{
   $(this).attr("value", textMessage);
   $(this).click(function()
   {
      $(this).attr("value", "");
   }
   );
   $(this).blur(function()
   {
      var txtvalue = $(this).attr("value");
      if(txtvalue == "")
      {
         $(this).attr("value", textMessage);
      }
   }
   );
}

$.fn.ShowonClick = function(containerid)
{
   {
      if($(containerid).hasClass('vis'))
      {
         $(containerid).removeClass('vis');
         $(containerid).addClass('hid');
      }
      else
      {
         $(containerid).removeClass('hid');
         $(containerid).addClass('vis');
      }
   }

}


function fileUpload(form, action_url, div_id)
{
   // Create the iframe...
   var iframe = document.createElement("iframe");
   iframe.setAttribute("id", "upload_iframe");
   iframe.setAttribute("name", "upload_iframe");
   iframe.setAttribute("width", "0");
   iframe.setAttribute("height", "0");
   iframe.setAttribute("border", "0");
   iframe.setAttribute("style", "width: 0; height: 0; border: none;");

   // Add to document...
   form.parentNode.appendChild(iframe);
   window.frames['upload_iframe'].name = "upload_iframe";

   iframeId = document.getElementById("upload_iframe");



   // Set properties of form...
   form.setAttribute("target", "upload_iframe");
   form.setAttribute("action", action_url);
   form.setAttribute("method", "post");
   form.setAttribute("enctype", "multipart/form-data");
   form.setAttribute("encoding", "multipart/form-data");

   // Submit the form...
   form.submit();
   $("#upload_iframe").remove();

   document.getElementById(div_id).innerHTML = "Uploading...";
}


$.fn.ConfirmBox = function(trueText)
{
   $(this).click(function()
   {
      $("#confirmbox").dialog(
      {
         bgiframe : true,
         resizable : false,
         height : 140,
         modal : true,
         overlay :
         {
            backgroundColor : '#000',
            opacity : 0.5
         }
         ,
         buttons :
         {
            "Delete All" : function()
            {
               $(this).dialog('close');
               return true;
            }
            ,
            Cancel : function()
            {
               $(this).dialog('close');
               return false;
            }
         }
      }
      );
   }
   );
}


$.fn.TipMouseHover = function(MessageText)
{
   var Inner = "<div class='toolTipMain'> <table cellspacing='0' cellpadding='0'>     <tbody><tr>         <td class='topLeft'/>         <td class='topMiddle'/>         <td class='topright'/>     </tr>     <tr>         <td class='contentMiddle'/>         <td class='contentMiddle'>             <div class='content'>" + MessageText + "</div>         </td>         <td class='contentMiddle'/>     </tr>     <tr>         <td class='bottomLeft'/>         <td class='bottomMiddle'/>         <td class='bottomright'/>     </tr> </tbody></table> </div>";
   $(this).hover(
   function ()
   {
      var po = $(this).offset();
      var len = $(this).width();
      var left = po.left + 10;
      var top = po.top + 20;
      $('#ToolTipHover').css(
      {
         left : left + 'px',
         top : top + 'px',
         position : 'absolute'
      }
      );

      $('#ToolTipHover').html(Inner);
      $('#ToolTipHover').show("slow");
   }
   ,
   function ()
   {
     // $('#ToolTipHover').hide();
      $('#ToolTipHover').css(
      {

      }
      );

   }
   );

}
function GetDropdownSelectedValue(id)
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