namespace UI
{
    partial class LoginUI
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginUI));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.labPwd = new System.Windows.Forms.Label();
            this.cmbIdentity = new System.Windows.Forms.ComboBox();
            this.labDegree = new System.Windows.Forms.Label();
            this.txtUid = new System.Windows.Forms.TextBox();
            this.labName = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnOK);
            this.groupBox1.Controls.Add(this.txtPwd);
            this.groupBox1.Controls.Add(this.labPwd);
            this.groupBox1.Controls.Add(this.cmbIdentity);
            this.groupBox1.Controls.Add(this.labDegree);
            this.groupBox1.Controls.Add(this.txtUid);
            this.groupBox1.Controls.Add(this.labName);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // btnClear
            // 
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.btnClear, "btnClear");
            this.btnClear.Name = "btnClear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.btnOK, "btnOK");
            this.btnOK.Name = "btnOK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click_1);
            // 
            // txtPwd
            // 
            resources.ApplyResources(this.txtPwd, "txtPwd");
            this.txtPwd.Name = "txtPwd";
            // 
            // labPwd
            // 
            resources.ApplyResources(this.labPwd, "labPwd");
            this.labPwd.Name = "labPwd";
            // 
            // cmbIdentity
            // 
            this.cmbIdentity.BackColor = System.Drawing.Color.White;
            this.cmbIdentity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIdentity.FormattingEnabled = true;
            resources.ApplyResources(this.cmbIdentity, "cmbIdentity");
            this.cmbIdentity.Name = "cmbIdentity";
            this.cmbIdentity.SelectedIndexChanged += new System.EventHandler(this.cmbIdentity_SelectedIndexChanged);
            this.cmbIdentity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbIdentity_KeyPress);
            // 
            // labDegree
            // 
            resources.ApplyResources(this.labDegree, "labDegree");
            this.labDegree.Name = "labDegree";
            // 
            // txtUid
            // 
            resources.ApplyResources(this.txtUid, "txtUid");
            this.txtUid.Name = "txtUid";
            this.txtUid.Click += new System.EventHandler(this.txtUid_Click);
            this.txtUid.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtUid_MouseClick);
            // 
            // labName
            // 
            resources.ApplyResources(this.labName, "labName");
            this.labName.Name = "labName";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.LightBlue;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnExit, "btnExit");
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Name = "btnExit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // LoginUI
            // 
            this.AcceptButton = this.btnOK;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClear;
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "LoginUI";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginUI_FormClosing);
            this.Load += new System.EventHandler(this.UserLoginUI_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.Label labPwd;
        private System.Windows.Forms.ComboBox cmbIdentity;
        private System.Windows.Forms.Label labDegree;
        public System.Windows.Forms.TextBox txtUid;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;




    }
}

