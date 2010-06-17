﻿function loadobject(url, loadid, clickid)
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

function Timmer(containnerid,url,Milisecond)
{
$(containnerid).LoadPage(url);
$("#aa").countdown(
         {
            interval : Milisecond,
            onTick : function(control, day, hrs, min, sec)
            {
               $(containnerid).LoadPage(url);
            }
         }
);
}