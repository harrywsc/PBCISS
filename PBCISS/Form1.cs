using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBCISS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 登录并验证用户信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Login_Click(object sender, EventArgs e)
        {
            //if (lb_UserName.Text == "" || lb_Password.Text == "")
            //{
            //    MessageBox.Show("请输入用户名和密码！");
            //    return;
            //}
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
