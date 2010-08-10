$.fn.AddWidget=function(widgetId,widgeturl)
{
    $(this).append('<div id="'+widgetId+'"></div>');
    $('#'+widgetId).LoadPage(widgeturl);
}

$.fn.DeleteWidget=function(widgeturl)
{
    
     
    $(this).LoadPage(widgeturl);
    $(this).remove();
}