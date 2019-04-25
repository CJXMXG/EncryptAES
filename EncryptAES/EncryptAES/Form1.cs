using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncryptAES
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string key = "kkkkkkk123456789";//保持16位
        //加密
        private void button1_Click(object sender, EventArgs e)
        {
           
            byte[] contentByte = System.Text.Encoding.Default.GetBytes(tb1.Text.Trim());
            byte[] resultByte = AESHelper.Encrypt(contentByte, key);//加密后
            tb2.Text = Convert.ToBase64String(resultByte);
        }

        //解密
        private void button2_Click(object sender, EventArgs e)
        {
            byte[] javaBaseArray = Convert.FromBase64String(tb2.Text);

            byte[] finalByte = AESHelper.Decrypt(javaBaseArray, key);
            tb3.Text = System.Text.Encoding.Default.GetString(finalByte);
        }
    }
}
