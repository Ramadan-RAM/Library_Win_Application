using DevExpress.XtraWaitForm;
using System;


namespace Library.Basic_Forms
{
    public partial class WaitForm1 : WaitForm
    {
        public WaitForm1()
        {
            InitializeComponent();
            progressPanel1.Text = "Copyright © 2018 - " + DateTime.Now.Year.ToString();
            progressPanel1.AutoHeight = true;
        }

        #region Overrides

        public override void SetCaption(string caption)
        {
            base.SetCaption(caption);
            progressPanel1.Caption = caption;
        }
        public override void SetDescription(string description)
        {
            base.SetDescription(description);
            progressPanel1.Description = description;
        }
        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }

        #endregion
    }
}