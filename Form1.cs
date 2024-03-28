using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LengthCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

<<<<<<< HEAD
        // 全域變數
        string strInput; // 字串型態的strInput變數
        double douOutput; // double浮點數型態的douOutput變數

        // 設計一個單位轉換計算的函式，沒有回傳值，設計兩個參數，1.類別參數、2.數值參數
        private void caculateAnswer(int _kind, double _value)
        {
            if (_kind != 0)
                txtCM.Text = string.Format("{0:0.##########}", _value);
            if (_kind != 1)
                txtM.Text = string.Format("{0:0.##########}", _value / 100);
            if (_kind != 2)
                txtKM.Text = string.Format("{0:0.##########}", _value / 100000);
            if (_kind != 3)
                txtIn.Text = string.Format("{0:0.##########}", _value / 2.54);
            if (_kind != 4)
                txtFt.Text = string.Format("{0:0.##########}", _value / 30.48);
            if (_kind != 5)
                txtYard.Text = string.Format("{0:0.##########}", _value / 91.44);
        }
        private void txtCM_KeyUp(object sender, KeyEventArgs e)
        {
            /*double douCM; //宣告一個double變數，變數名稱叫douCM
            douCM = Convert.ToDouble(txtCM.Text); //從txtCM輸入文字框取得輸入的文字，並且轉換成double的資料型態

=======
<<<<<<< HEAD
        // 全域變數
        string strInput; // 字串型態的strInput變數
        double douOutput; // double浮點數型態的douOutput變數
        private void txtCM_KeyUp(object sender, KeyEventArgs e)
        {
            /*double douCM; //宣告一個double變數，變數名稱叫douCM
=======
        private void txtCM_KeyUp(object sender, KeyEventArgs e)
        {
            double douCM; //宣告一個double變數，變數名稱叫douCM
>>>>>>> 664796c20dd62370a362ecc3e0b81d0a85836d17
            douCM = Convert.ToDouble(txtCM.Text); //從txtCM輸入文字框取得輸入的文字，並且轉換成double的資料型態

>>>>>>> 1ddbfb41e86a6eb3f6d2461f0019225cdc4ad154
            //透過string.Format格式化成小數點後共10位的數字，轉型成文字型態，在txtM顯示結果
            txtM.Text = string.Format("{0:0.##########}", douCM / 100);
            txtKM.Text = string.Format("{0:0.##########}", douCM / 100000);
            txtIn.Text = string.Format("{0:0.##########}", douCM / 2.54);
            txtFt.Text = string.Format("{0:0.##########}", douCM / 30.48);
<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> 1ddbfb41e86a6eb3f6d2461f0019225cdc4ad154
            txtYard.Text = string.Format("{0:0.##########}", douCM / 91.44);*/

            strInput = txtCM.Text; // 將txtCM文字框的值放入strInput變數

            // 判斷式，如果能夠以double.TryParse成功轉型，那才做數值的計算
            if (double.TryParse(strInput, out douOutput) == true)
            {
<<<<<<< HEAD
                /*我們把以下的單位轉換，改成可以共用的函式
=======
>>>>>>> 1ddbfb41e86a6eb3f6d2461f0019225cdc4ad154
                txtM.Text = string.Format("{0:0.##########}", douOutput / 100);
                txtKM.Text = string.Format("{0:0.##########}", douOutput / 100000);
                txtIn.Text = string.Format("{0:0.##########}", douOutput / 2.54);
                txtFt.Text = string.Format("{0:0.##########}", douOutput / 30.48);
<<<<<<< HEAD
                txtYard.Text = string.Format("{0:0.##########}", douOutput / 91.44);*/

                //執行計算長度函式
                caculateAnswer(0, douOutput);
=======
                txtYard.Text = string.Format("{0:0.##########}", douOutput / 91.44);
>>>>>>> 1ddbfb41e86a6eb3f6d2461f0019225cdc4ad154
            }
            else
            {
                // 如果無法轉型，則是在說明文字中顯示錯誤訊息，並且將txtCM文字框清除
                txtInfo.Text = "請輸入數字";
                txtCM.Text = "";
            }
<<<<<<< HEAD
=======
=======
            txtYard.Text = string.Format("{0:0.##########}", douCM / 91.44);
>>>>>>> 664796c20dd62370a362ecc3e0b81d0a85836d17
>>>>>>> 1ddbfb41e86a6eb3f6d2461f0019225cdc4ad154
        }

        private void txtM_KeyUp(object sender, KeyEventArgs e)
        {
<<<<<<< HEAD
            strInput = txtM.Text; // 將txtCM文字框的值放入strInput變數

            // 判斷式，如果能夠以double.TryParse成功轉型，那才做數值的計算
            if (double.TryParse(strInput, out douOutput) == true)
            {
                /*txtCM.Text = string.Format("{0:0.##########}", douOutput * 100);
                txtKM.Text = string.Format("{0:0.##########}", douOutput * 0.001);
                txtIn.Text = string.Format("{0:0.##########}", douOutput * 39.37);
                txtFt.Text = string.Format("{0:0.##########}", douOutput * 3.28);
                txtYard.Text = string.Format("{0:0.##########}", douOutput * 1.09);*/

                caculateAnswer(1, douOutput * 100); // 事先將公尺轉換成公分
            }
            else
            {
                // 如果無法轉型，則是在說明文字中顯示錯誤訊息，並且將txtM文字框清除
                txtInfo.Text = "請輸入數字";
                txtM.Text = "";
            }
=======
            double douM;
            douM = Convert.ToDouble(txtM.Text);

            txtCM.Text = string.Format("{0:0.##########}", douM * 100);
            txtKM.Text = string.Format("{0:0.##########}", douM * 0.001);
            txtIn.Text = string.Format("{0:0.##########}", douM * 39.37);
            txtFt.Text = string.Format("{0:0.##########}", douM * 3.28);
            txtYard.Text = string.Format("{0:0.##########}", douM * 1.09);
>>>>>>> 1ddbfb41e86a6eb3f6d2461f0019225cdc4ad154
        }

        private void txtKM_KeyUp(object sender, KeyEventArgs e)
        {
<<<<<<< HEAD
            strInput = txtKM.Text; // 將txtKM文字框的值放入strInput變數

            // 判斷式，如果能夠以double.TryParse成功轉型，那才做數值的計算
            if (double.TryParse(strInput, out douOutput) == true)
            {
                caculateAnswer(2, douOutput * 100000);
            }
            else
            {
                // 如果無法轉型，則是在說明文字中顯示錯誤訊息，並且將txtKM文字框清除
                txtInfo.Text = "請輸入數字";
                txtKM.Text = "";
            }
=======
            double douKM;
            douKM = Convert.ToDouble(txtKM.Text);

            txtCM.Text = string.Format("{0:0.##########}", douKM * 100);
            txtM.Text = string.Format("{0:0.##########}", douKM * 1000);
            txtIn.Text = string.Format("{0:0.##########}", douKM * 39370.1);
            txtFt.Text = string.Format("{0:0.##########}", douKM * 3280.84);
            txtYard.Text = string.Format("{0:0.##########}", douKM * 1093.61);
>>>>>>> 1ddbfb41e86a6eb3f6d2461f0019225cdc4ad154
        }

        private void txtIn_KeyUp(object sender, KeyEventArgs e)
        {
<<<<<<< HEAD
            strInput = txtIn.Text; // 將txtIn文字框的值放入strInput變數

            // 判斷式，如果能夠以double.TryParse成功轉型，那才做數值的計算
            if (double.TryParse(strInput, out douOutput) == true)
            {
                caculateAnswer(3, douOutput * 2.54);
            }
            else
            {
                // 如果無法轉型，則是在說明文字中顯示錯誤訊息，並且將txtIn文字框清除
                txtInfo.Text = "請輸入數字";
                txtIn.Text = "";
            }
=======
            double douIn;
            douIn = Convert.ToDouble(txtIn.Text);

            txtCM.Text = string.Format("{0:0.##########}", douIn * 2.54);
            txtM.Text = string.Format("{0:0.##########}", douIn * 0.0254);
            txtKM.Text = string.Format("{0:0.##########}", douIn * 0.0000254);
            txtFt.Text = string.Format("{0:0.##########}", douIn * 0.0833);
            txtYard.Text = string.Format("{0:0.##########}", douIn * 0.0278);
>>>>>>> 1ddbfb41e86a6eb3f6d2461f0019225cdc4ad154
        }

        private void txtFt_KeyUp(object sender, KeyEventArgs e)
        {
<<<<<<< HEAD
            strInput = txtFt.Text; // 將txtFt文字框的值放入strInput變數

            // 判斷式，如果能夠以double.TryParse成功轉型，那才做數值的計算
            if (double.TryParse(strInput, out douOutput) == true)
            {
                caculateAnswer(4, douOutput * 30.48);
            }
            else
            {
                // 如果無法轉型，則是在說明文字中顯示錯誤訊息，並且將txtFt文字框清除
                txtInfo.Text = "請輸入數字";
                txtFt.Text = "";
            }
=======
            double douFt;
            douFt = Convert.ToDouble(txtFt.Text);

            txtCM.Text = string.Format("{0:0.##########}", douFt * 30.48);
            txtM.Text = string.Format("{0:0.##########}", douFt * 0.3048);
            txtKM.Text = string.Format("{0:0.##########}", douFt * 0.0003048);
            txtIn.Text = string.Format("{0:0.##########}", douFt * 12);
            txtYard.Text = string.Format("{0:0.##########}", douFt * 0.3333);
>>>>>>> 1ddbfb41e86a6eb3f6d2461f0019225cdc4ad154
        }

        private void txtYard_KeyUp(object sender, KeyEventArgs e)
        {
<<<<<<< HEAD
            strInput = txtYard.Text; // 將txtYard文字框的值放入strInput變數

            // 判斷式，如果能夠以double.TryParse成功轉型，那才做數值的計算
            if (double.TryParse(strInput, out douOutput) == true)
            { 
                caculateAnswer(5, douOutput * 91.44);
            }
            else
            {
                // 如果無法轉型，則是在說明文字中顯示錯誤訊息，並且將txtYard文字框清除
                txtInfo.Text = "請輸入數字";
                txtYard.Text = "";
            }
=======
            double douYard;
            douYard = Convert.ToDouble(txtYard.Text);

            txtCM.Text = string.Format("{0:0.##########}", douYard * 91.44);
            txtM.Text = string.Format("{0:0.##########}", douYard * 0.9144);
            txtKM.Text = string.Format("{0:0.##########}", douYard * 0.0009144);
            txtIn.Text = string.Format("{0:0.##########}", douYard * 36);
            txtFt.Text = string.Format("{0:0.##########}", douYard * 3);
<<<<<<< HEAD
>>>>>>> 1ddbfb41e86a6eb3f6d2461f0019225cdc4ad154
        }

        private void btnAllClear_Click(object sender, EventArgs e)
        {
            // 給予每一個輸入文字框一個「空字串」
            txtCM.Text = "";
            txtM.Text = "";
            txtKM.Text = "";
            txtIn.Text = "";
            txtFt.Text = "";
            txtYard.Text = "";
<<<<<<< HEAD
            txtInfo.Text = "";
=======
=======
>>>>>>> 664796c20dd62370a362ecc3e0b81d0a85836d17
>>>>>>> 1ddbfb41e86a6eb3f6d2461f0019225cdc4ad154
        }
    }
}
