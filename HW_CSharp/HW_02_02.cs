using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_CSharp
{
    public partial class HW_02_02 : Form
    {
        public HW_02_02()
        {
            InitializeComponent();
        }
        public string LabMoneyShow
        {
            get { return labMoneyShow.Text; }
            set { labMoneyShow.Text = value; }
        }

        public string LabRateShow
        {
            get { return labRateShow.Text; }
            set { labRateShow.Text = value; }
        }

        public string LabYearsShow
        {
            get { return labYearsShow.Text; }
            set { labYearsShow.Text = value; }
        }


        public string LabFmShow
        {
            get { return labFMShow.Text; }
            set { labFMShow.Text = value; }
        }


        public string LabMpayShow
        {
            get { return labMpayShow.Text; }
            set { labMpayShow.Text = value; }
        }

        public string LabTpayShow
        {
            get { return labTpayShow.Text; }
            set { labTpayShow.Text = value; }
        }

    }
}
