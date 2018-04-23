Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms

Namespace DXApplication1
	Partial Public Class Form1
		Inherits DevExpress.XtraEditors.XtraForm

		Public Sub New()
			InitializeComponent()
			dateEdit1.Properties.AppearanceCalendar.Button.Options.UseTextOptions = True
		   dateEdit1.Properties.AppearanceCalendar.Button.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
			dateEdit1.Properties.AppearanceCalendar.ButtonHighlighted.Options.UseTextOptions = True
			dateEdit1.Properties.AppearanceCalendar.ButtonHighlighted.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
			dateEdit1.Properties.AppearanceCalendar.ButtonPressed.Options.UseTextOptions = True
			dateEdit1.Properties.AppearanceCalendar.ButtonPressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
		End Sub
	End Class
End Namespace
