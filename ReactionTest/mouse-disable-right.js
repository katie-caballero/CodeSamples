/*********************************************************************
 * FILE NAME: mouse_rightclick_disable.js
 * 
 * DESCRIPTION: Disables the browser reaction to a mouse right-click event
 * 
 * COPYRIGHT(C) 2007 HM ELECTRONICS INC., ALL RIGHTS RESERVED 
 * 
 * CREATED: January 17, 2007
 *
 * SOURCE: http://www.dynamicdrive.com/dynamicindex9/noright.htm
 *
 * REVISION HISTORY:
 * 
 *******************************************************************/

//captures IE4's mouse click and cancels if a right-click
function clickIE4()
{
    //if a right click event
    if (event.button == 2)
        return false;   //cancel the request
}

//captures NS4's mouse click and cancels if a right-click
function clickNS4(e)
{
    //verify that this is Netscape 4.x
    if (document.layers || document.getElementById && !document.all)
        //if a right click event
        if (e.which == 2 || e.which == 3)
            return false;   //cancel the request
}

//if a Netscape 4.x browser
if (document.layers)
{
    //redirecting the mouse capture event
    document.captureEvents(Event.MOUSEDOWN);
    document.onmousedown = clickNS4;
}
//if an IE4 browser
else if (document.all && !document.getElementById)
{
    //redirecting the mouse capture event
    document.onmousedown = clickIE4;
}

//disabling the right-click browser reaction (for all other)
document.oncontextmenu = function() { return false; }