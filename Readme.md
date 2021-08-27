<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128620391/15.2.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1428)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/DXApplication1/Form1.cs) (VB: [Form1.vb](./VB/DXApplication1/Form1.vb))
<!-- default file list end -->
# How to customize properties of the buttons in the DateEdit's pop-up window


<p>To accomplish this task, create the DateEdit descendant and override its CreatePopupForm method. Both the PopupDateEditForm and VistaPopupDateEditForm contain the DateEditCalendar control available via the Calendar property. You can customize its properties and the properties of its controls before returning a newly created form. This example demonstrates how to enable the text trimming feature for the Today and Clear buttons.</p>


<h3>Description</h3>

<p>Starting with version 15.2, DateEdit supports&nbsp;<strong>CalendarAppearance</strong>&nbsp;settings. To change&nbsp;the&nbsp;button&nbsp;appearance, you can use the&nbsp;CalendarAppearance.Button,&nbsp;ButtonHighlighted,&nbsp;ButtonPressed properties.</p>

<br/>


