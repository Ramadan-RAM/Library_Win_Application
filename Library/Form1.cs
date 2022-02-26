using Library.Basic_Forms;
using System;
using System.Windows.Forms;
using System.Threading;
using Library.OP;
using Library.Account;
using DevExpress.XtraEditors;
using Library.Reports;

namespace Library
{
    public partial class Form1 : XtraForm
    {

        public Form1()
        {
            InitializeComponent();

        }

        private void BarButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool IsActiv = false;
            ItemsData itemsData = new ItemsData();
            foreach (Form item in MdiChildren)
            {
                if (item.Name == itemsData.Name)
                {
                    itemsData.Activate();
                    IsActiv = true;
                }
            }
            if (!IsActiv)
            {
                itemsData.MdiParent = this;
                itemsData.Show();
            }
        }

        private void BarButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool IsActiv = false;
            CustData custData = new CustData();
            foreach (Form item in MdiChildren)
            {
                if (item.Name == custData.Name)
                {
                    custData.Activate();
                    IsActiv = true;
                }
            }
            if (!IsActiv)
            {
                custData.MdiParent = this;
                custData.Show();
            }

        }


        private void BarButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool IsActiv = false;
            JobType jobType = new JobType();
            foreach (Form item in MdiChildren)
            {
                if (item.Name == jobType.Name)
                {
                    jobType.Activate();
                    IsActiv = true;
                }
            }
            if (!IsActiv)
            {
                jobType.MdiParent = this;
                jobType.Show();
            }


        }


        private void BarButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool IsActiv = false;
            StoreData storeData = new StoreData();
            foreach (Form item in MdiChildren)
            {
                if (item.Name == storeData.Name)
                {
                    storeData.Activate();
                    IsActiv = true;
                }
            }
            if (!IsActiv)
            {
                storeData.MdiParent = this;
                storeData.Show();
            }


        }

        private void BarButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool IsActiv = false;
            StoreConvert storeConvert = new StoreConvert();
            foreach (Form item in MdiChildren)
            {
                if (item.Name == storeConvert.Name)
                {
                    storeConvert.Activate();
                    IsActiv = true;
                }
            }
            if (!IsActiv)
            {
                storeConvert.MdiParent = this;
                storeConvert.Show();
            }

        }

        private void BarButtonItem17_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Application.Exit();
        }

        private void BarButtonItem2_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            bool IsActiv = false;
            VendorsData vendorsData = new VendorsData();
            foreach (Form item in MdiChildren)
            {
                if (item.Name == vendorsData.Name)
                {
                    vendorsData.Activate();
                    IsActiv = true;
                }
            }
            if (!IsActiv)
            {
                vendorsData.MdiParent = this;
                vendorsData.Show();
            }


        }

        private void BarButtonItem5_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            bool IsActiv = false;
            EmpData empData = new EmpData();
            foreach (Form item in MdiChildren)
            {
                if (item.Name == empData.Name)
                {
                    empData.Activate();
                    IsActiv = true;
                }
            }
            if (!IsActiv)
            {
                empData.MdiParent = this;
                empData.Show();
            }


        }

        private void BarButtonItem18_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool IsActiv = false;
            ItemCategory itemCategory = new ItemCategory();
            foreach (Form item in MdiChildren)
            {
                if (item.Name == itemCategory.Name)
                {
                    itemCategory.Activate();
                    IsActiv = true;
                }
            }
            if (!IsActiv)
            {
                itemCategory.MdiParent = this;
                itemCategory.Show();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Frm_login frm = new Frm_login();
            _ = frm.ShowDialog();

            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(100);
            }

            barButtonItem19.Caption = DateTimeOffset.Now.DateTime.ToString();
        }

        private void BarEditItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void BarButtonItem20_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool IsActiv = false;
            DistrubuteItems distrubute = new DistrubuteItems();
            foreach (Form item in MdiChildren)
            {
                if (item.Name == distrubute.Name)
                {
                    distrubute.Activate();
                    IsActiv = true;
                }
            }
            if (!IsActiv)
            {
                distrubute.MdiParent = this;
                distrubute.Show();
            }
        }

        private void BarButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool IsActiv = false;
            Purchases purchases = new Purchases();
            foreach (Form item in MdiChildren)
            {
                if (item.Name == purchases.Name)
                {
                    purchases.Activate();
                    IsActiv = true;
                }
            }
            if (!IsActiv)
            {
                purchases.MdiParent = this;
                purchases.Show();
                Refresh();
            }
        }

        private void BarButtonItem11_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool IsActiv = false;
            Salse salse = new Salse();
            foreach (Form item in MdiChildren)
            {
                if (item.Name == salse.Name)
                {
                    salse.Activate();
                    IsActiv = true;
                }
            }
            if (!IsActiv)
            {
                salse.MdiParent = this;
                salse.Show();
                Refresh();
            }
        }

        private void BarButtonItem13_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool IsActiv = false;
            CustAccountData custAccountDat = new CustAccountData();
            foreach (Form item in MdiChildren)
            {
                if (item.Name == custAccountDat.Name)
                {
                    custAccountDat.Activate();
                    IsActiv = true;
                }
            }
            if (!IsActiv)
            {
                custAccountDat.MdiParent = this;
                custAccountDat.Show();
            }
        }

        private void BarButtonItem15_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool IsActiv = false;
            VenAccountData venAccountData = new VenAccountData();
            foreach (Form item in MdiChildren)
            {
                if (item.Name == venAccountData.Name)
                {
                    venAccountData.Activate();
                    IsActiv = true;
                }
            }
            if (!IsActiv)
            {
                venAccountData.MdiParent = this;
                venAccountData.Show();
            }
        }

        private void BarButtonItem21_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool IsActiv = false;
            Frm_CustActionsRp frm = new Frm_CustActionsRp();
            foreach (Form item in MdiChildren)
            {
                if (item.Name == frm.Name)
                {
                    frm.Activate();
                    IsActiv = true;
                }
            }
            if (!IsActiv)
            {
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void BarButtonItem22_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool IsActiv = false;
            Frm_DisRP frm = new Frm_DisRP();
            foreach (Form item in MdiChildren)
            {
                if (item.Name == frm.Name)
                {
                    frm.Activate();
                    IsActiv = true;
                }
            }
            if (!IsActiv)
            {
                frm.Show();
            }
        }

        private void BarButtonItem23_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool IsActiv = false;
            Frm_VenActionsRp frm = new Frm_VenActionsRp();
            foreach (Form item in MdiChildren)
            {
                if (item.Name == frm.Name)
                {
                    frm.Activate();
                    IsActiv = true;
                }
            }
            if (!IsActiv)
            {
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void BarButtonItem24_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool IsActiv = false;
            UsersData frm = new UsersData();

            foreach (Form item in MdiChildren)
            {
                if (item.Name == frm.Name)
                {
                    frm.Activate();
                    IsActiv = true;
                }
            }

            if (!IsActiv)
            {
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void BarButtonItem25_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool IsActiv = false;
            StoreQuantity frm = new StoreQuantity();

            foreach (Form item in MdiChildren)
            {
                if (item.Name == frm.Name)
                {
                    frm.Activate();
                    IsActiv = true;
                }
            }

            if (!IsActiv)
            {
                frm.MdiParent = this;
                frm.Show();
            }
        }
    }
}
