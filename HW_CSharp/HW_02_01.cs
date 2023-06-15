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
    public partial class HW_02_01 : Form
    {

        public HW_02_01()
        {
            InitializeComponent();
     

         
        }

        private double txtMpay;
        private double txttPay;

        private void sumdata()
        {
            // 定義參數
            double txtMo = double.Parse(txtMoney.Text);
            double txtYr = double.Parse(txtYears.Text);
            double txtRt = double.Parse(txtRate.Text);
            double txtFm = double.Parse(txtFM.Text);

            // 計算貸款相關數值
            double txtlaon = txtMo - txtFm; // 貸款金額=金額-頭期
            double txtMRt = txtRt / 100 / 12; // 月利率=年利率/100/12
            double txtMonth = txtYr * 12; // 月=年*12
            double numerator = txtlaon * txtMRt * Math.Pow(1 + txtMRt, txtMonth);
            double denominator = Math.Pow(1 + txtMRt, txtMonth) - 1;
            txtMpay = numerator / denominator; // 每月要付的錢=(貸款金額 * 月利率 * (1+月利率)^月數) / ((1+月利率)^月數 - 1)
            txttPay = txtMpay * txtMonth;

        }





        public void btnMM_Click(object sender, EventArgs e)
        {

            sumdata();

            // 顯示結果
            MessageBox.Show("月付金額:" + txtMpay +"元", "貸款計算結果");

        }

        public void btnTM_Click(object sender, EventArgs e)
        {
            sumdata();

            // 顯示結果
            MessageBox.Show("總額:" + txttPay + "元", "貸款計算結果");
        }



        private void btnReport_Click(object sender, EventArgs e)
        {

            HW_02_02 Frm_HW02_02 = new HW_02_02();

            Frm_HW02_02.LabMoneyShow=txtMoney.Text;


            Frm_HW02_02.LabRateShow = txtRate.Text;

            Frm_HW02_02.LabYearsShow = txtYears.Text;

            Frm_HW02_02.LabFmShow = txtFM.Text;

            Frm_HW02_02.LabMpayShow = txtMpay.ToString();

            Frm_HW02_02.LabTpayShow = txttPay.ToString();


            Frm_HW02_02.ShowDialog();
        }
    }
}
