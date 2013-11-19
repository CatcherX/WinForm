namespace UI
{
    partial class StuWebComments
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
            this.txtComment = new System.Windows.Forms.TextBox();
            this.rdbSuggest = new System.Windows.Forms.RadioButton();
            this.rdbCriticism = new System.Windows.Forms.RadioButton();
            this.rdbconsult = new System.Windows.Forms.RadioButton();
            this.btnPost = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtComment
            // 
            this.txtComment.BackColor = System.Drawing.Color.LightGreen;
            this.txtComment.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtComment.Location = new System.Drawing.Point(28, 15);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(422, 324);
            this.txtComment.TabIndex = 0;
            this.txtComment.Click += new System.EventHandler(this.txtComment_Click);
            // 
            // rdbSuggest
            // 
            this.rdbSuggest.AutoSize = true;
            this.rdbSuggest.Location = new System.Drawing.Point(25, 20);
            this.rdbSuggest.Name = "rdbSuggest";
            this.rdbSuggest.Size = new System.Drawing.Size(47, 16);
            this.rdbSuggest.TabIndex = 1;
            this.rdbSuggest.TabStop = true;
            this.rdbSuggest.Text = "建议";
            this.rdbSuggest.UseVisualStyleBackColor = true;
            // 
            // rdbCriticism
            // 
            this.rdbCriticism.AutoSize = true;
            this.rdbCriticism.Location = new System.Drawing.Point(163, 20);
            this.rdbCriticism.Name = "rdbCriticism";
            this.rdbCriticism.Size = new System.Drawing.Size(47, 16);
            this.rdbCriticism.TabIndex = 1;
            this.rdbCriticism.TabStop = true;
            this.rdbCriticism.Text = "批评";
            this.rdbCriticism.UseVisualStyleBackColor = true;
            // 
            // rdbconsult
            // 
            this.rdbconsult.AutoSize = true;
            this.rdbconsult.Location = new System.Drawing.Point(317, 20);
            this.rdbconsult.Name = "rdbconsult";
            this.rdbconsult.Size = new System.Drawing.Size(47, 16);
            this.rdbconsult.TabIndex = 1;
            this.rdbconsult.TabStop = true;
            this.rdbconsult.Text = "咨询";
            this.rdbconsult.UseVisualStyleBackColor = true;
            // 
            // btnPost
            // 
            this.btnPost.Location = new System.Drawing.Point(204, 426);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(75, 23);
            this.btnPost.TabIndex = 2;
            this.btnPost.Text = "提交";
            this.btnPost.UseVisualStyleBackColor = true;
            this.btnPost.Click += new System.EventHandler(this.btnPost_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtComment);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(473, 345);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "留言内容";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "欢迎各位同学！";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbSuggest);
            this.groupBox2.Controls.Add(this.rdbCriticism);
            this.groupBox2.Controls.Add(this.rdbconsult);
            this.groupBox2.Location = new System.Drawing.Point(41, 364);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(422, 47);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "类型：";
            // 
            // StuWebComments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 464);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnPost);
            this.Name = "StuWebComments";
            this.Text = "网上留言";
            this.Load += new System.EventHandler(this.StuWebComments_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.RadioButton rdbSuggest;
        private System.Windows.Forms.RadioButton rdbCriticism;
        private System.Windows.Forms.RadioButton rdbconsult;
        private System.Windows.Forms.Button btnPost;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
    }
}