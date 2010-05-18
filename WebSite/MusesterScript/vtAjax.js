// JavaScript Document
// JavaScript Document
$.fn.serializeNoViewState = function()
{
   var data = this.find("input,textarea,select,input[type=file]")
   .not("[type=hidden][name^=__]")
   .serializeArray();
    alert(data);
//    var myObject = {
//  a: {
//    one: 1, 
//    two: 2, 
//    three: 3
//  }, 
//  b: [1,2,3]
//};
//var recursiveEncoded = $.param(myObject);
//var recursiveDecoded = decodeURIComponent($.param(myObject));

//alert(recursiveEncoded);
//alert(recursiveDecoded);

   var photo = document.getElementById("flUpload");
   var file  = photo.files[0];
   //data+="&fileup="+file;
   data[data.length]={name:'fileup',value:file};
    alert(data);
   //   if(data != "")
   //   {
   //      var photo = document.getElementById("flUpload");
   //      var file  = photo.files[0];
   //      data += "{filedate:" + file + "}";
   //   }
   //   alert(data);
   return  data;
}
$.fn.ToolTipMouseHover = function()
{
   $(this).hover(
   function ()
   {
      //      $(this).removeClass('eventcal');
      //      $(this).addClass('eventcalHov');
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
         width : '200px'


      }
      );

   }
   ,
   function ()
   {
      //     $(this).removeClass('eventcalHov');
      //     $(this).addClass('eventcal');
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
   // $(this).live('click', function()
   $(this).click(function()
   {

      var pos = $(this).offset();
      var width = $(this).width();
      $("#tooltipcontainer").css(
      {
         //         left : (pos.left + width) + 'px',
         //         top : pos.top - 5 + 'px'
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
   str += "' style='width:auto;height:auto;'></iframe>";
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
$.fn.PUIW = function(url,swidth,sheight)
{
   var id = $(this).attr("id");
   id = "#" + id;
   $(this).html("");
   $(this).html("Loading................");

   var str = "<iframe id='Ipopup' frameborder='0' src='";
   str += url;
   str += "' style='width:"+swidth+"px;height:"+sheight+"px;'></iframe>";
   $(this).html(str);
   $(this).dialog(
   {
      position : 'center',
      width : 'auto',
      height:'auto',      
      close : function(event, ui)
      {
         $(this).dialog('destroy');
      }
   }
   );
   $("#Ipopup").css(
   {
    width:"'"+swidth+"'px",
    height:"'"+sheight+"'px"
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
   //   var id = $(this).attr("id");
   //   id = "#" + id;
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
   //   var id = $(this).attr("id");
   //   id = "#" + id;
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
      success : function(message)
      {

         //message = $(message).find(".content").html();
         $(id).html(message);
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
$.fn.Customalert = function(message)
{
   $("body").append('<div id="alertms"><div class="alerthead"><div style="padding: 5px; background: #fff"><div id="alertmessage"></div><div style="float:   left; padding: 3px;"><a href="#">OK</a></div><div style="float: left; padding: 3px;"><a id="alertok"href="#">Cancel</a></div><div style="clear:both"></div></div></div></div>');
   $("#alertmessage").html(message);
   var pos = $(this).offset();
   var width = $(this).width();
   $("#alertms").css(
   {
      left : (pos.left + width + 10) + 'px',
      top : pos.top - 5 + 'px',
      position : 'absolute',
      background : '#000',
      padding : '5px',
      color : '#000000'

   }
   );

   $("#alertok").click(function()
   {
      return true;
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

$.fn.ShowonClick=function(containerid)
{
   // $(this).click(function()
    {
        if($(containerid).hasClass('vis'))
        {
            //alert("vis");
            $(containerid).removeClass('vis');
            $(containerid).addClass('hid');
        }
        else{
        //alert("Hid");
           $(containerid).removeClass('hid');
            $(containerid).addClass('vis');
        }
    }
    //);
}