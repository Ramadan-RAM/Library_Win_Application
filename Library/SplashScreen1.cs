using System;
using DevExpress.XtraSplashScreen;

namespace Library
{
    public partial class SplashScreen1 : SplashScreen
    {


        public SplashScreen1()
        {
            InitializeComponent();
            labelCopyright.Text = "Copyright © 2018 - " + DateTime.Now.Year.ToString();

        }

        #region Overrides

        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);

        }

        #endregion

    }
}