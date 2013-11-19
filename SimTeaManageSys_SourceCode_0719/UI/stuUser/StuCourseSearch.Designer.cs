namespace UI
{
    partial class StuCourseSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StuCourseSearch));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gpbAction = new System.Windows.Forms.GroupBox();
            this.btnExportText = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnExportExcel = new System.Windows.Forms.Button();
            this.Printer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gpbAction.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Silver;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(31, 259);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(664, 213);
            this.dataGridView1.TabIndex = 17;
            // 
            // gpbAction
            // 
            this.gpbAction.Controls.Add(this.btnExportText);
            this.gpbAction.Controls.Add(this.btnExit);
            this.gpbAction.Controls.Add(this.btnExportExcel);
            this.gpbAction.Location = new System.Drawing.Point(375, 29);
            this.gpbAction.Name = "gpbAction";
            this.gpbAction.Size = new System.Drawing.Size(221, 192);
            this.gpbAction.TabIndex = 15;
            this.gpbAction.TabStop = false;
            this.gpbAction.Text = "执行操作:";
            // 
            // btnExportText
            // 
            this.btnExportText.Font = new System.Drawing.Font("宋体", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnExportText.Location = new System.Drawing.Point(46, 78);
            this.btnExportText.Name = "btnExportText";
            this.btnExportText.Size = new System.Drawing.Size(142, 54);
            this.btnExportText.TabIndex = 5;
            this.btnExportText.Text = "导出为TXT文本";
            this.btnExportText.UseVisualStyleBackColor = true;
            this.btnExportText.Click += new System.EventHandler(this.btnExportText_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(62, 148);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(96, 38);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "退出";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.Font = new System.Drawing.Font("宋体", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnExportExcel.Location = new System.Drawing.Point(46, 19);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(142, 53);
            this.btnExportExcel.TabIndex = 3;
            this.btnExportExcel.Text = "导出为EXCEL表格";
            this.btnExportExcel.UseVisualStyleBackColor = true;
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // Printer
            // 
            this.Printer.BackColor = System.Drawing.Color.SkyBlue;
            this.Printer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Printer.BackgroundImage")));
            this.Printer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Printer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Printer.Location = new System.Drawing.Point(624, 152);
            this.Printer.Name = "Printer";
            this.Printer.Size = new System.Drawing.Size(48, 48);
            this.Printer.TabIndex = 16;
            this.Printer.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(49, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 96);
            this.label1.TabIndex = 18;
            this.label1.Text = "同学，你好。当前选课目录如下，\r\n请根据实际情况进行选课。\r\n\r\n选课在相应窗口中进行！\r\n\r\n点击右边相应按钮可以导出课程内容。";
            // 
            // StuCourseSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 501);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gpbAction);
            this.Controls.Add(this.Printer);
            this.Name = "StuCourseSearch";
            this.Text = "选课表查询";
            this.Load += new System.EventHandler(this.StuCourseSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gpbAction.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox gpbAction;
        private System.Windows.Forms.Button btnExportText;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnExportExcel;
        private System.Windows.Forms.Button Printer;
        private System.Windows.Forms.Label label1;

    }
}