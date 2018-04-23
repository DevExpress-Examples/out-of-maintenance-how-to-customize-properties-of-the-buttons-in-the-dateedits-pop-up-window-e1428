Namespace DXApplication1
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.dateEdit1 = New DevExpress.XtraEditors.DateEdit()
			DirectCast(Me.dateEdit1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.dateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' dateEdit1
			' 
			Me.dateEdit1.EditValue = Nothing
			Me.dateEdit1.Location = New System.Drawing.Point(76, 57)
			Me.dateEdit1.Name = "dateEdit1"
			Me.dateEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.dateEdit1.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Vista
			Me.dateEdit1.Properties.ShowMonthNavigationButtons = DevExpress.Utils.DefaultBoolean.True
			Me.dateEdit1.Properties.VistaCalendarInitialViewStyle = DevExpress.XtraEditors.VistaCalendarInitialViewStyle.CenturyView
			Me.dateEdit1.Properties.VistaCalendarViewStyle = (CType(((((DevExpress.XtraEditors.VistaCalendarViewStyle.MonthView Or DevExpress.XtraEditors.VistaCalendarViewStyle.YearView) Or DevExpress.XtraEditors.VistaCalendarViewStyle.QuarterView) Or DevExpress.XtraEditors.VistaCalendarViewStyle.YearsGroupView) Or DevExpress.XtraEditors.VistaCalendarViewStyle.CenturyView), DevExpress.XtraEditors.VistaCalendarViewStyle))
			Me.dateEdit1.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.True
			Me.dateEdit1.Properties.WeekNumberRule = DevExpress.XtraEditors.Controls.WeekNumberRule.FirstDay
			Me.dateEdit1.Size = New System.Drawing.Size(100, 20)
			Me.dateEdit1.TabIndex = 0
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(338, 252)
			Me.Controls.Add(Me.dateEdit1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			DirectCast(Me.dateEdit1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.dateEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private dateEdit1 As DevExpress.XtraEditors.DateEdit

	End Class
End Namespace

