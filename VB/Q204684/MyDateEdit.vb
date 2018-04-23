Imports Microsoft.VisualBasic
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Registrator
Imports DevExpress.XtraEditors.ViewInfo
Imports DevExpress.XtraEditors.Drawing
Imports System.ComponentModel
Imports DevExpress.XtraEditors.Popup
Imports DevExpress.Utils
Namespace DXSample
	Public Class MyDateEdit
		Inherits DateEdit
		Shared Sub New()
			RepositoryItemMyDateEdit.RegisterMyDateEdit()
		End Sub
		Public Sub New()
			MyBase.New()
		End Sub
		Public Overrides ReadOnly Property EditorTypeName() As String
			Get
				Return RepositoryItemMyDateEdit.MyDateEditName
			End Get
		End Property
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Content)> _
		Public Shadows ReadOnly Property Properties() As RepositoryItemMyDateEdit
			Get
				Return CType(MyBase.Properties, RepositoryItemMyDateEdit)
			End Get
		End Property
		Protected Overrides Function CreatePopupForm() As PopupBaseForm
			If Properties.IsVistaDisplayModeInternal Then
				Return MyBase.CreatePopupForm()
			Else
				Dim form As PopupDateEditForm = CType(MyBase.CreatePopupForm(), PopupDateEditForm)
				form.Calendar.ClearButton.Appearance.TextOptions.Trimming = Trimming.EllipsisCharacter
				form.Calendar.ClearButton.Text = "Clear the value"
				form.Calendar.TodayButton.Appearance.TextOptions.Trimming = Trimming.EllipsisCharacter
				form.Calendar.TodayButton.Text = "Set the today date"
				Return form
			End If
		End Function
	End Class

	<UserRepositoryItem("RegisterMyDateEdit")> _
	Public Class RepositoryItemMyDateEdit
		Inherits RepositoryItemDateEdit
		Shared Sub New()
			RegisterMyDateEdit()
		End Sub
		Public Sub New()
			MyBase.New()
		End Sub
		Public Const MyDateEditName As String = "MyDateEdit"
		Public Overrides ReadOnly Property EditorTypeName() As String
			Get
				Return MyDateEditName
			End Get
		End Property
		Public Shared Sub RegisterMyDateEdit()
			EditorRegistrationInfo.Default.Editors.Add(New EditorClassInfo(MyDateEditName, GetType(MyDateEdit), GetType(RepositoryItemMyDateEdit), GetType(DateEditViewInfo), New ButtonEditPainter(), True))
		End Sub
		Friend ReadOnly Property IsVistaDisplayModeInternal() As Boolean
			Get
				Return MyBase.IsVistaDisplayMode()
			End Get
		End Property
	End Class
End Namespace