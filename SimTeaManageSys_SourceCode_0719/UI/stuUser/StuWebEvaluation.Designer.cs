namespace UI
{
    partial class StuWebEvaluation
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTeaName = new System.Windows.Forms.ComboBox();
            this.btnPost = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Grou = new System.Windows.Forms.GroupBox();
            this.rdbSoSo = new System.Windows.Forms.RadioButton();
            this.rdbVeryGood = new System.Windows.Forms.RadioButton();
            this.rdbGood = new System.Windows.Forms.RadioButton();
            this.cbxTeaNum = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.Grou.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "教师姓名";
            // 
            // cmbTeaName
            // 
            this.cmbTeaName.FormattingEnabled = true;
            this.cmbTeaName.Location = new System.Drawing.Point(136, 252);
            this.cmbTeaName.Name = "cmbTeaName";
            this.cmbTeaName.Size = new System.Drawing.Size(121, 20);
            this.cmbTeaName.TabIndex = 7;
            // 
            // btnPost
            // 
            this.btnPost.Location = new System.Drawing.Point(387, 244);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(75, 23);
            this.btnPost.TabIndex = 6;
            this.btnPost.Text = "提交";
            this.btnPost.UseVisualStyleBackColor = true;
            this.btnPost.Click += new System.EventHandler(this.btnPost_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(40, 286);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(532, 163);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Location = new System.Drawing.Point(294, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(252, 200);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "评价文字描述";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox1.Location = new System.Drawing.Point(17, 18);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(220, 168);
            this.textBox1.TabIndex = 0;
            this.textBox1.Click += new System.EventHandler(this.textBox1_Click);
            // 
            // Grou
            // 
            this.Grou.Controls.Add(this.rdbSoSo);
            this.Grou.Controls.Add(this.rdbVeryGood);
            this.Grou.Controls.Add(this.rdbGood);
            this.Grou.Location = new System.Drawing.Point(60, 71);
            this.Grou.Name = "Grou";
            this.Grou.Size = new System.Drawing.Size(167, 127);
            this.Grou.TabIndex = 1;
            this.Grou.TabStop = false;
            this.Grou.Text = "评价程度";
            // 
            // rdbSoSo
            // 
            this.rdbSoSo.AutoSize = true;
            this.rdbSoSo.Location = new System.Drawing.Point(96, 90);
            this.rdbSoSo.Name = "rdbSoSo";
            this.rdbSoSo.Size = new System.Drawing.Size(59, 16);
            this.rdbSoSo.TabIndex = 0;
            this.rdbSoSo.TabStop = true;
            this.rdbSoSo.Text = "还可以";
            this.rdbSoSo.UseVisualStyleBackColor = true;
            // 
            // rdbVeryGood
            // 
            this.rdbVeryGood.AutoSize = true;
            this.rdbVeryGood.Location = new System.Drawing.Point(24, 31);
            this.rdbVeryGood.Name = "rdbVeryGood";
            this.rdbVeryGood.Size = new System.Drawing.Size(71, 16);
            this.rdbVeryGood.TabIndex = 0;
            this.rdbVeryGood.TabStop = true;
            this.rdbVeryGood.Text = "非常满意";
            this.rdbVeryGood.UseVisualStyleBackColor = true;
            // 
            // rdbGood
            // 
            this.rdbGood.AutoSize = true;
            this.rdbGood.Location = new System.Drawing.Point(24, 90);
            this.rdbGood.Name = "rdbGood";
            this.rdbGood.Size = new System.Drawing.Size(47, 16);
            this.rdbGood.TabIndex = 0;
            this.rdbGood.TabStop = true;
            this.rdbGood.Text = "满意";
            this.rdbGood.UseVisualStyleBackColor = true;
            // 
            // cbxTeaNum
            // 
            this.cbxTeaNum.FormattingEnabled = true;
            this.cbxTeaNum.Location = new System.Drawing.Point(136, 222);
            this.cbxTeaNum.Name = "cbxTeaNum";
            this.cbxTeaNum.Size = new System.Drawing.Size(121, 20);
            this.cbxTeaNum.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "教师编号";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(50, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 32);
            this.label3.TabIndex = 9;
            this.label3.Text = "请先在表格中选中教师，\r\n然后进行评价操作！";
            // 
            // StuWebEvaluation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 475);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxTeaNum);
            this.Controls.Add(this.cmbTeaName);
            this.Controls.Add(this.btnPost);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Grou);
            this.Name = "StuWebEvaluation";
            this.Text = "网上评教";
            this.Load += new System.EventHandler(this.StuWebEvaluation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.Grou.ResumeLayout(false);
            this.Grou.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbVeryGood;
        private System.Windows.Forms.RadioButton rdbGood;
        private System.Windows.Forms.RadioButton rdbSoSo;
        private System.Windows.Forms.GroupBox Grou;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnPost;
        private System.Windows.Forms.ComboBox cmbTeaName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cbxTeaNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}