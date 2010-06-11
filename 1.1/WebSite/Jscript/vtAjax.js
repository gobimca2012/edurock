function loadobject(url, loadid, clickid)
{
   this.url = url;
   this.loadid = loadid;
   this.clickid = clickid;
}


$.fn.serializeNoViewState = function()
{
   return this.find("input,textarea,select")
   .not("[type=hidden][name^=__]")
   .serialize();

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
         }

      }
      );
      $("#tooltipcontainer").removeClass("loading");
      return false;
   }
   );
}

$.fn.ToolTipLP = function(id, url)
{

   $(this).click(function()
   {

      var pos = $(this).offset();
      var width = $(this).width();
      $(id).css(
      {
         left : (pos.left + width) + 'px',
         top : pos.top - 5 + 'px',
         background : '#ffffff'
      }
      );

      // $(this).LP(id, url);
      $(id).LoadPage(url);
      $(id).removeClass("loading");
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
               // data = $(data).find(".content");
               HtmlPaste(data,id);
               BuildLinks(id);
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

$.fn.PUControled = function(url,width,height)
{

   var id = $(this).attr("id");
   id = "#" + id;
   $(this).html("");      
   $(this).dialog(
   {
      position : 'center',
      width:'500',
      height:'500',      
      open : function()
      {
         $.ajax(
         {
            type : 'POST',
            url : url,
            success : function(data)
            {
               // data = $(data).find(".content");
               HtmlPaste(data,id);
               BuildLinks(id);
               $(id).dialog('option', 'position', 'center');
            }
         }
         );
      }
      ,
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
   str += "'></iframe>";
   $(this).html(str);
   $(this).dialog(
   {
      position : 'center',
      width : "auto",
      height : "auto",
      minWidth : "400",
      close : function(event, ui)
      {
         $(this).dialog('destroy');
      }
   }
   );
   return false;

}
$.fn.PUID = function(url, width, height)
{
   var id = $(this).attr("id");
   id = "#" + id;
   $(this).html("");
   $(this).html("Loading................");
   var str = "<iframe id='popup' frameborder='0' style='height:"+height+"px;width:"+width+"px;' src='" ;
   str += url;
   str += "'></iframe>";
   $(this).html(str);
   // $(this).dialog("option", "width", "900");
   $(this).dialog();
   $(this).dialog("open");
   //   $(this).dialog(
   //   {
   //      position : 'center',
   //      height : "'"+height+"px'",
   //      minWidth : "400",
   //      close : function(event, ui)
   //      {
   //         $(this).dialog('destroy');
   //      }
   //   }
   //   );

   return false;

}

$.fn.ToolTipClose = function()
{

   $("#tooltipcontainer").empty();

}

$.fn.LP = function(id, url)
{

   $.ajax(
   {
      type : "POST",
      url : url,
      contentType : "application/json; charset=utf-8",
      dataType : "html",
      success : function(message)
      {
         $(this).html("Loading................");
         // message = $(message).find(".content").html();
         $(id).html(message);
         BuildLinks(id);

      }
      ,
      error : function(errormessage)
      {
         $(id).removeClass("loading");
      }
   }
   );


}


$.fn.LoadPageJson = function(url)
{
   var ContainnerID = $(this).attr("id");
   ContainnerID = "#" + ContainnerID;
   // $(this).html("Loading...");
   ProgressBar(true);

   $.ajax(
   {
      type : "POST",
      url : url,
      contentType : "application/json; charset=utf-8",
      dataType : "json",
      data :
      {
      }
      ,
      cache : false,
      success : function(message)
      {
         JsonPaste(message, ContainnerID);
         BuildLinks(ContainnerID);
         ProgressBar(false);

      }
      ,
      error : function(errormessage)
      {
         alert(errormessage);
         $(ContainnerID).removeClass("loading");
         ProgressBar(false);
      }
   }
   );


}


$.fn.LoadPage = function(url)
{
   var ContainnerID = $(this).attr("id");
   ContainnerID = "#" + ContainnerID;
   // $(this).html("Loading...");
   ProgressBar(true);

   $.ajax(
   {
      type : "POST",
      url : url,
      contentType : "application/json; charset=utf-8",
      dataType : "html",
      success : function(message)
      {
         HtmlPaste(message,ContainnerID);
         BuildLinks(ContainnerID);
         ProgressBar(false);

      }
      ,
      error : function(errormessage)
      {
         alert(errormessage);
         $(ContainnerID).removeClass("loading");
         ProgressBar(false);
      }
   }
   );


}
function SuccessHtml(obj, htm)
{
   $(this).html(replacehtml);
}

$.fn.LPP = function(url)
{

   var data = $(this).serializeNoViewState();
   // $(this).html("Loading...");
   ProgressBar(true);
   var id = $(this).attr("id");
   id = "#" + id;
   $.post(url, data,
   function(result)
   {

      // result = $(result).find(".content").html();
      $(id).html(result);
      BuildLinks(id);
      ProgressBar(false);
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

      // result = $(result).find(".content").html();
      $(id).replaceWith(result);
      BuildLinks(id);
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

      // result = $(result).find(".content").html();
      $(id).html(result);
      BuildLinks(id);
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

         // message = $(message).find(".content").html();
         $(id).append(message);
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

         // message = $(message).find(".content").html();
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

function BuildLinks(id)
{
   $(id).find("a").filter(function()
   {
      ParseParam(this);
      NormalizeUrl(this);
   }
   );
}
function SelectAllCheckBox(value)
{
   if(value == true)
   {
      $("input:checkbox").attr('checked', 'checked');
   }
   else
   {
      $("input:checkbox").removeAttr('checked')

   }
}

/////////// new

$.fn.clickLoadJ = function()
{

   $(this).click(function()
   {
      var url = $(this).attr("rel");


      var mySplitResult = url.split("#");

      // var ContainnerID = $(this).attr("name");
      var ContainnerID = "#" + mySplitResult[1];
      url = mySplitResult[0];
      var LinkID = $(this).attr("id");
      LinkID = "#" + LinkID;
      ProgressBar(true);
      $.ajax(
      {
         type : "GET",
         url : url,
         contentType : "application/json; charset=utf-8",
         dataType : "json",
         cache : false,
         success : function(message)
         {
            JsonPaste(message, ContainnerID);
            BuildLinks(ContainnerID);
            ProgressBar(false);
            return false;

         }
         ,
         error : function(errormessage)
         {
            alert(errormessage);
            $(ContainnerID).removeClass("loading");
            ProgressBar(false);
            return false;
         }
      }
      );
   }
   );

   return false;
}

$.fn.clickLoadH = function()
{

   $(this).click(function()
   {
      var url = $(this).attr("rel");
      var mySplitResult = url.split("#");      
      var ContainnerID = "#" + mySplitResult[1];
      url = mySplitResult[0];
      var LinkID = $(this).attr("id");
      LinkID = "#" + LinkID;
      ProgressBar(true);
      $.ajax(
      {
         type : "GET",
         url : url,
         contentType : "application/json; charset=utf-8",
         dataType : "text/html",
         cache : false,
         success : function(message)
         {
            HtmlPaste(message, ContainnerID);
            BuildLinks(ContainnerID);
            ProgressBar(false);
            return false;

         }
         ,
         error : function(errormessage)
         {
            alert(errormessage);
            $(ContainnerID).removeClass("loading");
            ProgressBar(false);
            return false;
         }
      }
      );
   }
   );

   return false;
}


$.fn.LinkPostJ = function(url, PostContainnerID, ContainnerID)
{

   //   // $(this).html("Loading...");
   //   var LinkID = $(this).attr("id");
   //   LinkID = "#" + LinkID;

   $(this).click(function()
   {
      var data = $(PostContainnerID).serializeNoViewState();
      $.post(url, data,
      function(result)
      {

         JsonPaste(result, ContainnerID);
         BuildLinks(ContainnerID);
      }
      );
   }
   );
}
$.fn.LinkPostH = function(url, PostContainnerID, ContainnerID)
{
   //alert("hello");
   $(this).click(function()
   {
   //alert("hello");
      var data = $(PostContainnerID).serializeNoViewState();
      $.post(url, data,
      function(result)
      {
         HtmlPaste(result, ContainnerID);
         BuildLinks(ContainnerID);
      }
      );
   }
   );
}
function ProgressBar(status)
{
   if(status == true)
   {
      $("#progress").html("<div style='position:absolute;left:400px;top:200px;padding:10px 30px;background:#fff;border:solid 5px #1E4B81;color:#1E4B81;'>Loadding...</div>");
   }
   else
   {
      $("#progress").html("");
   }
}
function NormalizeUrl(hypobj)
{
   if($(hypobj).hasClass("ck") == true)
   {
      $(hypobj).clickLoadJ();
   }
   else  if($(hypobj).hasClass("ckh") == true)
   {
   
      $(hypobj).clickLoadH();
   }


}
function HtmlPaste(obj, ContainnerID)
{
   var htmldata = decHTMLifEnc(obj);
   $(ContainnerID).html(htmldata);
   //alert($(ContainnerID).html());
   

}

function JsonPaste(obj, ContainnerID)
{

   var htmldata = decHTMLifEnc(obj.hdom);
   $(ContainnerID).html(htmldata);
   var injscript = decHTMLifEnc(obj.sc);
   eval(injscript);

}
function redirect(url)
{
   window.location = url;
   return true;
}

function decHTMLifEnc(str)
{
   // if(isEncHTML(str))
   return str.replace(/&amp;/g, '&').replace(/&lt;/g, '<').replace(/&gt;/g, '>').replace(/&quot;/g, '"').replace(/####/g,'$');
   return str;
}
function isEncHTML(str)
{
   if(str.search(/&amp;/g) != - 1 || str.search(/&lt;/g) != - 1 || str.search(/&gt;/g) != - 1)
   return true;
   else
   return false;
}

