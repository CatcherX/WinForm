using System;
using System.IO;
using System.Windows.Forms;


namespace UI
{
    public partial class StuCourseSearch : CentralUse
    {
        public StuCourseSearch()
        {
            InitializeComponent();
        }

         SaveFileDialog objDialog = new SaveFileDialog();
         string FileName;
        


        private void StuCourseSearch_Load(object sender, EventArgs e)
        {
            CourseInfo objCourseInfo = new CourseInfo();
            dataGridView1.DataSource = objCourseInfo.ShowCourseInfo();

        }

       

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            FileName = this.Text +"_"+ DateTime.Now.Second.ToString();

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
        

            }
            catch (Exception e1)
            {
                MessageBox.Show("出错了。。。错误消息：" + e1);
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
            FileName = this.Text + "_" + DateTime.Now.Second.ToString();

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

            catch (Exception e1)
            {
                MessageBox.Show("出错了。。。错误消息：" + e1);
            }

            finally
            {
                objSTW.Close();
                objStream.Close();
            }
            #endregion
        }

       
    }
}
