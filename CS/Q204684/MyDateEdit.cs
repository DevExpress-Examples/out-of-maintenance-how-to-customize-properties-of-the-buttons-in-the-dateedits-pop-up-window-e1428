using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.Registrator;
using DevExpress.XtraEditors.ViewInfo;
using DevExpress.XtraEditors.Drawing;
using System.ComponentModel;
using DevExpress.XtraEditors.Popup;
using DevExpress.Utils;
namespace DXSample {
    public class MyDateEdit : DateEdit {
        static MyDateEdit() { RepositoryItemMyDateEdit.RegisterMyDateEdit(); }
        public MyDateEdit() : base() { }
        public override string EditorTypeName { get { return RepositoryItemMyDateEdit.MyDateEditName; } }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public new RepositoryItemMyDateEdit Properties { 
            get { return (RepositoryItemMyDateEdit)base.Properties; } 
        }
        protected override PopupBaseForm CreatePopupForm() {
            if (Properties.IsVistaDisplayModeInternal) return base.CreatePopupForm();
            else {
                PopupDateEditForm form = (PopupDateEditForm)base.CreatePopupForm();
                form.Calendar.ClearButton.Appearance.TextOptions.Trimming = Trimming.EllipsisCharacter;
                form.Calendar.ClearButton.Text = "Clear the value";
                form.Calendar.TodayButton.Appearance.TextOptions.Trimming = Trimming.EllipsisCharacter;
                form.Calendar.TodayButton.Text = "Set the today date";
                return form;
            }
        }
    }

    [UserRepositoryItem("RegisterMyDateEdit")]
    public class RepositoryItemMyDateEdit : RepositoryItemDateEdit {
        static RepositoryItemMyDateEdit() { RegisterMyDateEdit(); }
        public RepositoryItemMyDateEdit() : base() { }
        public const string MyDateEditName = "MyDateEdit";
        public override string EditorTypeName { get { return MyDateEditName; } }
        public static void RegisterMyDateEdit() {
            EditorRegistrationInfo.Default.Editors.Add(new EditorClassInfo(MyDateEditName, typeof(MyDateEdit),
                typeof(RepositoryItemMyDateEdit), typeof(DateEditViewInfo), new ButtonEditPainter(), true));
        }
        internal bool IsVistaDisplayModeInternal { get { return base.IsVistaDisplayMode(); } }
    }
}