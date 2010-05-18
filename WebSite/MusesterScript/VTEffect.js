$.fn.Collapspanel=function()
{
$(this).click(function()
{   
   if($(this).attr("class") == "hide")
   {
      $(this).attr("class","");
      $(this).attr("class","show");
      $(this).next().show("slow");
   }
   else
   {
      $(this).attr("class","");
      $(this).attr("class","hide");
      $(this).next().hide("slow");
   }
   }
);

$(this).attr("class","hide");
$(this).next().hide();
$(this).first().next().show("slow");
$(this).first().attr("class","show");
}

$.fn.Collapspanel=function(SelectedID)
{
$(this).click(function()
{   
   if($(this).attr("class") == "hide")
   {
      $(this).attr("class","");
      $(this).attr("class","show");
      $(this).next().show("slow");
   }
   else
   {
      $(this).attr("class","");
      $(this).attr("class","hide");
      $(this).next().hide("slow");
   }
   }
);

$(this).attr("class","hide");
$(this).next().hide();
var sel=$("#"+SelectedID).parents("table").show("slow");
$("#"+SelectedID).attr("class","labelselected");
$("#"+SelectedID).parents("table").prev().attr("class","show");

}