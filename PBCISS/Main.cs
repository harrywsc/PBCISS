using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PBCISS
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void 添加信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {            
           
        }



        private void 信息员添加ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeptManage deptManage = DeptManage.InstanceObject();
            deptManage.MdiParent = this;
            deptManage.WindowState = FormWindowState.Maximized;
            deptManage.Focus();
            deptManage.Show();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Environment.Exit(0);
        }
    }

}
