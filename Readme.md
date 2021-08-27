<!-- default badges list -->
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1428)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [MyDateEdit.cs](./CS/Q204684/MyDateEdit.cs) (VB: [MyDateEdit.vb](./VB/Q204684/MyDateEdit.vb))
<!-- default file list end -->
# How to customize properties of the buttons in the DateEdit's pop-up window


<p>To accomplish this task, create the DateEdit descendant and override its CreatePopupForm method. Both the PopupDateEditForm and VistaPopupDateEditForm contain the DateEditCalendar control available via the Calendar property. You can customize its properties and the properties of its controls before returning a newly created form. This example demonstrates how to enable the text trimming feature for the Today and Clear buttons.</p>

<br/>


