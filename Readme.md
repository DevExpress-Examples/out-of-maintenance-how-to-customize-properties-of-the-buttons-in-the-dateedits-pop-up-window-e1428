# How to customize properties of the buttons in the DateEdit's pop-up window


<p>To accomplish this task, create the DateEdit descendant and override its CreatePopupForm method. Both the PopupDateEditForm and VistaPopupDateEditForm contain the DateEditCalendar control available via the Calendar property. You can customize its properties and the properties of its controls before returning a newly created form. This example demonstrates how to enable the text trimming feature for the Today and Clear buttons.</p>


<h3>Description</h3>

<p>Starting with version 15.2, DateEdit supports&nbsp;<strong>CalendarAppearance</strong>&nbsp;settings. To change&nbsp;the&nbsp;button&nbsp;appearance, you can use the&nbsp;CalendarAppearance.Button,&nbsp;ButtonHighlighted,&nbsp;ButtonPressed properties.</p>

<br/>


