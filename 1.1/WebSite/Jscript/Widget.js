$.fn.AddWidget=function(widgetId,widgeturl)
{
    $(this).append('<dl id="'+widgetId+'"></dl>');
    $('#'+widgetId).LoadPage(widgeturl);
}

$.fn.DeleteWidget=function(widgeturl)
{   
     
    $(this).LoadPage(widgeturl);
    $(this).remove();
}

$.fn.CreateColumn=function(WidgetDomElement,ActionUrl)
{
$(this).sortable(
{

   items : WidgetDomElement,
   update : function(event, ui)
   {
      var data = $(this).sortable('serialize');
      alert(data);
      $(this).LoadPageNoReplace(ActionUrl+'?wid=ser&' + data);
   }
}
);
$(this).disableSelection();
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
