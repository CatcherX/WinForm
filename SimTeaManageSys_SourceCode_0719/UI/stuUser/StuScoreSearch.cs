using System;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using BLL;
using Model;


namespace UI
{
    public partial class StuScoreSearch : CentralUse
    {
        public StuScoreSearch()
        {


            InitializeComponent();
        }
        /// <summary>
        /// 作为事件处理程序，刷新表格；
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void RefreshDataGridView(object sender,EventArgs e)
        {
            //label2.Text = e.Name;
            label2.Text = SelCourse.strTrans;

            SqlRead = objLoginUIBLL.LoginUserRead();

            if (SqlRead.Read())
            {
                objLoginUserModel.UserId = SqlRead["UserId"].ToString();
            }
            dataGridView1.DataSource = objScoreSearchBLL.ScoreStuSearch(objLoginUserModel);

            if (dataGridView1.CurrentRow.Index >= 0)
            {
                //获取表格中的第一行（0），第二个单元格的值：
                label1.Text = dataGridView1[1, 0].Value.ToString() + "  同学, 你好！\n你的成绩单如下:\n请查阅！";
            }
            else
            {
                MessageBox.Show("同学，你好！\n 你的成绩暂没数据.\n请稍后再查询\n");
                label1.Text = "同学，你好！\n 你的成绩暂没数据.\n请稍后再查询\n";
            }

            if (label1.Text == "")
            {
                label1.Text = "同学，你好！\n 你的成绩暂没数据.\n请稍后再查询\n";
            }
        }


        LoginUIBLL objLoginUIBLL = new LoginUIBLL();
        LoginUserModel objLoginUserModel = new LoginUserModel();
        ScoreSearchBLL objScoreSearchBLL = new ScoreSearchBLL();
        SqlDataReader SqlRead;
        SaveFileDialog objDialog = new SaveFileDialog();
        string FileName;


       

        private void StuScoreSearch_Load(object sender, EventArgs e)
        {
            RefreshDataGridView(this, null);
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            //DataPrint objDataPrint = new DataPrint();
            //objDataPrint.ExportToExcel();
            int CurrentRow = dataGridView1.CurrentRow.Index;
            FileName = dataGridView1[1, CurrentRow].Value.ToString() + "的成绩单_" + DateTime.Now.Month + DateTime.Now.Day + DateTime.Now.Hour + DateTime.Now.Second.ToString();


            #region 导出为Excel
            objDialog.Filter = "Excel(*.xls)|*.xls";
            objDialog.Title = "导出为Excel文件";
            objDialog.FileName = FileName;
            objDialog.ShowDialog();
            objDialog.FilterIndex = 0;
            objDialog.RestoreDirectory = true;
            objDialog.CreatePrompt = true;
            Stream objStream;
            objStream = objDialog.OpenFile();       //数组超出了下限
            StreamWriter objSW = new StreamWriter(objStream, System.Text.Encoding.GetEncoding(-0));
            string objStr = "";
            try
            {
                //写入标题
                for (int r = 0; r < dataGridView1.ColumnCount; r++)
                {
                    if (r > 0)
                    {
                        objStr += "\t";
                    }
                    objStr += dataGridView1.Columns[r].HeaderText;//获取或设置列标题单元格的标题文本
                }
                objSW.WriteLine(objStr);

                //写入内容
                for (int l = 0; l < dataGridView1.Rows.Count; l++)
                {
                    string tempStr = "";
                    for (int m = 0; m < dataGridView1.Columns.Count; m++)
                    {
                        if (m > 0)
                        {
                            tempStr += "\t";
                        }
                        tempStr += dataGridView1.Rows[l].Cells[m].Value.ToString();

                    }
                    objSW.WriteLine(tempStr);
                }

                MessageBox.Show("导出成功！"); 
            }

            finally
            {
                objSW.Close();
                objStream.Close();
            } 
            #endregion

        }

        private void btnExportText_Click(object sender, EventArgs e)
        {
          

            int CurrentRow = dataGridView1.CurrentRow.Index;
            string FileName = dataGridView1[1, CurrentRow].Value.ToString() + "的成绩单_" + DateTime.Now.Month + DateTime.Now.Day + DateTime.Now.Hour + DateTime.Now.Second.ToString();



            #region 导出为文本
            Stream objStream;
            StreamWriter objSTW;
            string objstr = "";
            objDialog.Filter = "TXT文件(*.txt)|*.txt";
            objDialog.Title = "导出为txt文件";
            objDialog.FileName = FileName;

            objDialog.FilterIndex = 0;
            objDialog.RestoreDirectory = true;
            objDialog.CreatePrompt = true;
            objDialog.ShowDialog();
            objStream = objDialog.OpenFile();
            objSTW = new StreamWriter(objStream, System.Text.Encoding.Unicode);

            try
            {
                //写内容
                for (int j = 0; j < dataGridView1.Rows.Count; j++)
                {
                    for (int k = 0; k < dataGridView1.Columns.Count; k++)
                    {
                        if (k > 0)
                        {
                            objstr += "\t";
                        }
                        if (dataGridView1.Rows[j].Cells[k].Value == null)
                        {
                            objstr += dataGridView1.Rows[j].Cells[k].Value;
                        }
                        else
                        {
                            objstr += dataGridView1.Rows[j].Cells[k].Value.ToString();
                        }
                        objSTW.WriteLine(objstr);
                        objstr = "";
                    }
                }
            }
            finally
            {
                objSTW.Close();
                objStream.Close();
            } 
            #endregion
            MessageBox.Show("导出成功！");


        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
