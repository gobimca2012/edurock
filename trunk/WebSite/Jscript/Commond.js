$.fn.serializeNoViewState = function()
{
    return this.find("input,textarea,select")
               .not("[type=hidden][name^=__]")
               .serialize();    
}