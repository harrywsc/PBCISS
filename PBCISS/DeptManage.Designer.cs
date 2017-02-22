namespace PBCISS
{
    partial class DeptManage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_AddDept = new System.Windows.Forms.Label();
            this.tb_AddDept = new System.Windows.Forms.TextBox();
            this.btn_AddDept = new System.Windows.Forms.Button();
            this.lb_SelectDept = new System.Windows.Forms.Label();
            this.cb_SelectDept = new System.Windows.Forms.ComboBox();
            this.lb_UpdateDept = new System.Windows.Forms.Label();
            this.tb_UpdateDept = new System.Windows.Forms.TextBox();
            this.btn_UpdateDept = new System.Windows.Forms.Button();
            this.btn_DeleteDept = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_AddDept
            // 
            this.lb_AddDept.AutoSize = true;
            this.lb_AddDept.Location = new System.Drawing.Point(60, 83);
            this.lb_AddDept.Name = "lb_AddDept";
            this.lb_AddDept.Size = new System.Drawing.Size(98, 18);
            this.lb_AddDept.TabIndex = 0;
            this.lb_AddDept.Text = "新增部门：";
            // 
            // tb_AddDept
            // 
            this.tb_AddDept.Location = new System.Drawing.Point(164, 80);
            this.tb_AddDept.Name = "tb_AddDept";
            this.tb_AddDept.Size = new System.Drawing.Size(218, 28);
            this.tb_AddDept.TabIndex = 1;
            // 
            // btn_AddDept
            // 
            this.btn_AddDept.Location = new System.Drawing.Point(436, 78);
            this.btn_AddDept.Name = "btn_AddDept";
            this.btn_AddDept.Size = new System.Drawing.Size(99, 28);
            this.btn_AddDept.TabIndex = 2;
            this.btn_AddDept.Text = "确认添加";
            this.btn_AddDept.UseVisualStyleBackColor = true;
            this.btn_AddDept.Click += new System.EventHandler(this.btn_AddDept_Click);
            // 
            // lb_SelectDept
            // 
            this.lb_SelectDept.AutoSize = true;
            this.lb_SelectDept.Location = new System.Drawing.Point(63, 189);
            this.lb_SelectDept.Name = "lb_SelectDept";
            this.lb_SelectDept.Size = new System.Drawing.Size(89, 18);
            this.lb_SelectDept.TabIndex = 3;
            this.lb_SelectDept.Text = "选择部门:";
            // 
            // cb_SelectDept
            // 
            this.cb_SelectDept.FormattingEnabled = true;
            this.cb_SelectDept.Location = new System.Drawing.Point(164, 189);
            this.cb_SelectDept.Name = "cb_SelectDept";
            this.cb_SelectDept.Size = new System.Drawing.Size(218, 26);
            this.cb_SelectDept.TabIndex = 4;
            // 
            // lb_UpdateDept
            // 
            this.lb_UpdateDept.AutoSize = true;
            this.lb_UpdateDept.Location = new System.Drawing.Point(66, 261);
            this.lb_UpdateDept.Name = "lb_UpdateDept";
            this.lb_UpdateDept.Size = new System.Drawing.Size(98, 18);
            this.lb_UpdateDept.TabIndex = 5;
            this.lb_UpdateDept.Text = "修改部门：";
            // 
            // tb_UpdateDept
            // 
            this.tb_UpdateDept.Location = new System.Drawing.Point(164, 258);
            this.tb_UpdateDept.Name = "tb_UpdateDept";
            this.tb_UpdateDept.Size = new System.Drawing.Size(218, 28);
            this.tb_UpdateDept.TabIndex = 6;
            // 
            // btn_UpdateDept
            // 
            this.btn_UpdateDept.Location = new System.Drawing.Point(436, 258);
            this.btn_UpdateDept.Name = "btn_UpdateDept";
            this.btn_UpdateDept.Size = new System.Drawing.Size(99, 28);
            this.btn_UpdateDept.TabIndex = 7;
            this.btn_UpdateDept.Text = "确认修改";
            this.btn_UpdateDept.UseVisualStyleBackColor = true;
            // 
            // btn_DeleteDept
            // 
            this.btn_DeleteDept.Location = new System.Drawing.Point(436, 184);
            this.btn_DeleteDept.Name = "btn_DeleteDept";
            this.btn_DeleteDept.Size = new System.Drawing.Size(99, 31);
            this.btn_DeleteDept.TabIndex = 8;
            this.btn_DeleteDept.Text = "确认删除";
            this.btn_DeleteDept.UseVisualStyleBackColor = true;
            // 
            // DeptManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 393);
            this.Controls.Add(this.btn_DeleteDept);
            this.Controls.Add(this.btn_UpdateDept);
            this.Controls.Add(this.tb_UpdateDept);
            this.Controls.Add(this.lb_UpdateDept);
            this.Controls.Add(this.cb_SelectDept);
            this.Controls.Add(this.lb_SelectDept);
            this.Controls.Add(this.btn_AddDept);
            this.Controls.Add(this.tb_AddDept);
            this.Controls.Add(this.lb_AddDept);
            this.Name = "DeptManage";
            this.Text = "DeptManage";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DeptManage_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_AddDept;
        private System.Windows.Forms.TextBox tb_AddDept;
        private System.Windows.Forms.Button btn_AddDept;
        private System.Windows.Forms.Label lb_SelectDept;
        private System.Windows.Forms.ComboBox cb_SelectDept;
        private System.Windows.Forms.Label lb_UpdateDept;
        private System.Windows.Forms.TextBox tb_UpdateDept;
        private System.Windows.Forms.Button btn_UpdateDept;
        private System.Windows.Forms.Button btn_DeleteDept;
    }
}