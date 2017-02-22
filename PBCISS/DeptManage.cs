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
    public partial class DeptManage : Form
    {
        private static DeptManage _deptManage;
        public DeptManage()
        {
            InitializeComponent();
        }

        public static DeptManage InstanceObject()
        {
            if (_deptManage == null)
            {
                _deptManage = new DeptManage();
            }
            return _deptManage;
        }

        private void DeptManage_FormClosing(object sender, FormClosingEventArgs e)
        {
            _deptManage = null;
        }

        private void btn_AddDept_Click(object sender, EventArgs e)
        {
            Util.AddDept("caca");
        }
    }
}
