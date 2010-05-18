$.fn.DELID = function(id,url,loadUrl)
{
   var Loadid = $(this).attr("id");
   Loadid = "#" + Loadid;
   var jsonData="{'id':'"+id+"'}";
   $.ajax(
   {
      type : "POST",
      url : url,
      contentType : "application/json; charset=utf-8",
      data : jsonData,
      dataType : "json",
      success : function(msg)
      {
        $(Loadid).LoadPage(loadUrl);
      }
      
   }
   );
   
   
}

$.fn.CAVAT = function(id,url)
{   
   $(this).attr("src",url);   
}
$.fn.CAVT=function(path)
{
$(this).attr("src",path);
}
