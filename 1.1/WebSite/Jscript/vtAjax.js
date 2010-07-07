// JavaScript Document
function loadobject(url, loadid, clickid)
{
   this.url = url;
   this.loadid = loadid;
   this.clickid = clickid;
}

//  ---------------------------------------

$.fn.serializeNoViewState = function()
{
//   return this.find("input,textarea,select")
//   .not("[type=hidden][name^=__]")
//   .serialize();
   return this.find("input,textarea,select").serialize();

}

//  ---------------------------------------


$.fn.LoadPage = function(url)
{
   var ContainnerID = $(this).attr("id");
   ContainnerID = "#" + ContainnerID;
   // $(this).html("Loading...");
   ProgressBar(true,ContainnerID);

   $.ajax(
   {
      type : "POST",
      url : url,
      contentType : "application/json; charset=utf-8",
      dataType : "html",
      success : function(message)
      {
         HtmlPaste(message, ContainnerID);
         BuildLinks(ContainnerID);
         ProgressBar(false,ContainnerID);

      }
      ,
      error : function(errormessage)
      {
         alert(errormessage);
         $(ContainnerID).removeClass("loading");
         ProgressBar(false,ContainnerID);
      }
   }
   );


}

//  ---------------------------------------

function SuccessHtml(obj, htm)
{
   $(this).html(replacehtml);
}

//  ---------------------------------------

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

//  ---------------------------------------

function BuildLinks(id)
{
   $(id).find("a").filter(function()
   {
      ParseParam(this);
      NormalizeUrl(this);
   }
   );
}

//  ---------------------------------------

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

//  ---------------------------------------

//function ProgressBar(status)
//{
//   if(status == true)
//   {
//      $("#progress").html("<div style='position:absolute;left:400px;top:200px;padding:10px 30px;background:#fff;border:solid 5px #1E4B81;color:#1E4B81;'>Loadding...</div>");
//   }
//   else
//   {
//      $("#progress").html("");
//   }
//}
function ProgressBar(status,id)
{
   if(status == true)
   {
      //$("#progress").html("<div style='position:absolute;left:400px;top:200px;padding:10px 30px;background:#fff;border:solid 5px #1E4B81;color:#1E4B81;'>Loadding...</div>");
      $(id).addClass("loading");
   }
   else
   {
      $(id).removeClass("loading");
   }
}

//  ---------------------------------------

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

//  ---------------------------------------

function HtmlPaste(obj, ContainnerID)
{
   var htmldata = decHTMLifEnc(obj);
   $(ContainnerID).html(obj);
   // alert($(ContainnerID).html());


}

//  ---------------------------------------

function JsonPaste(obj, ContainnerID)
{

   var htmldata = decHTMLifEnc(obj.hdom);
   $(ContainnerID).html(htmldata);
   var injscript = decHTMLifEnc(obj.sc);
   eval(injscript);

}

//  ---------------------------------------

function redirect(url)
{
   window.location = url;
   return true;
}

//  ---------------------------------------

function decHTMLifEnc(str)
{
   // if(isEncHTML(str))
   return str.replace(/&amp;/g, '&').replace(/&lt;/g, '<').replace(/&gt;/g, '>').replace(/&quot;/g, '"').replace(/####/g,'$');
   return str;
}

//  ---------------------------------------

function isEncHTML(str)
{
   if(str.search(/&amp;/g) != - 1 || str.search(/&lt;/g) != - 1 || str.search(/&gt;/g) != - 1)
   return true;
   else
   return false;
}

//  ---------------------------------------

function Timmer(containnerid, url, Milisecond)
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

//  ---------------------------------------


$.fn.LinkPostH = function(url, PostContainnerID, ContainnerID)
{
   // alert("hello");
   $(this).click(function()
   {
      ProgressBar(true,PostContainnerID);
      var data = $(PostContainnerID).serializeNoViewState();
      var urlparts = url.toString().split('?');
      data += "&" + urlparts[1];
      $.post(urlparts[0], data,
      function(result)
      {
         HtmlPaste(result, ContainnerID);
         BuildLinks(ContainnerID);
         ProgressBar(false,PostContainnerID);
      }
      );
   }
   );
}

//  ---------------------------------------

///// PopUp////////////////////////////////

$.fn.PopUp = function(url, PopUpContainnerID)
{
   $(this).click(function()
   {
      $(PopUpContainnerID).show();
      $(PopUpContainnerID).LoadPage(url);
   }
   );
}

//  ---------------------------------------

$.fn.PopUps = function(PopUpContainnerID, url, width, height)
{
   $(this).click(function()
   {
      $(PopUpContainnerID).LoadPage(url);
      $(PopUpContainnerID).dialog(
      {
         // autoOpen : false,
         height : height + 'px',
         width : width + 'px',
         modal : true,
         position : ['center', 20],
         beforeclose : function()
         {
            $(this).dialog('hide');
            // $(this).dialog('close');
         }
      }
      );

      $(PopUpContainnerID).dialog('open');
   }
   );


}

//  ---------------------------------------





var Hours = 0;
var Minuts = 0
var Second = 0;
var timmer = null;
var PopIDdiv = null, popCloseUrl = null;
function Counter(hour, minut, second, PopupDivID, url)
{
   Hours = hour;
   Minuts = minut;
   Second = second;
   PopIDdiv = PopupDivID;
   popCloseUrl = url;
   clearInterval();
   // clearTimeout();
//   alert("hello");
//   setInterval(descreaseSecond, 60000);

}

//  ---------------------------------------

function descreaseSecond(PopupDivID, url)
{
   //   Second -- ;
   //   if(Second == 0)
   //   {

   //      Minuts -- ;
   //      Second = 60;
   //   }
   clearInterval();
   if(Minuts > 0)
   {
      Minuts -- ;
   }
   if(Minuts == 0)
   {

      if(Hours > 0)
      {
         Hours -- ;
         Minuts = 60;
      }

   }
   $("#divh").html(Hours);
   $("#divm").html(Minuts);
   $("#divs").html(Second);
   setTimeout(descreaseSecond, 1000);
   if(Hours == 0 && Minuts == 5 && Second == 60)
   {
      alert("You have 5 Minute Only");
   }
   if(Hours == 0 && Minuts == 0)
   {
      Second = 0;
      // SubmitAnswer(PopupDivID, url)
      // alert(popCloseUrl, PopIDdiv);
      $(PopIDdiv).LoadPage(popCloseUrl);
      $(PopIDdiv).dialog('close');
      clearInterval();
      //clearInterval(timmer);
   }
}

//popUp
$.fn.PUIW = function(url, swidth, sheight,rurl,rid)
{
    alert("aa");
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
         $(rid).LoadPage(rurl);
      }
   }
   );
   $(this).dialog('open');
   $("#Ipopup").css(
   {
      width : "'"+swidth+"'px",
      height : "'"+sheight+"'px"
   }
   );
   
   return false;

}


$.fn.shower=function(ShowBlockID)
{
    $(this).click(function()
    {
      
        if($(ShowBlockID).hasClass('vis'))
        {
            $(ShowBlockID).addClass('invis');
            $(ShowBlockID).removeClass('vis');
            $(ShowBlockID).hide('slow');
        }
        else
        {
            $(ShowBlockID).addClass('vis');
            $(ShowBlockID).removeClass('invis');
            $(ShowBlockID).show('slow');
        }
    }
    );
}

$.fn.dropdownPostback=function(url,PostContainnerID,ContainnerID)
{   
      var id = $(this).attr("id");
    
      url+="?ddp="+id;
      alert(url);
      ProgressBar(true,PostContainnerID);
      var data = $(PostContainnerID).serializeNoViewState();
      var urlparts = url.toString().split('?');
      data += "&" + urlparts[1];
      $.post(urlparts[0], data,
      function(result)
      {
         HtmlPaste(result, ContainnerID);
         BuildLinks(ContainnerID);
         ProgressBar(false,PostContainnerID);
      }
      );
    
    
}