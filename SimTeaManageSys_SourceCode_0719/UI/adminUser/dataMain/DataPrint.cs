using System;
using System.IO;
using System.Windows.Forms;
using BLL;

namespace UI
{
    public partial class DataPrint : CentralUse
    {
        public DataPrint()
        {
            InitializeComponent();
        }
        string FileName;

        SaveFileDialog objDialog = new SaveFileDialog();

        DataPrintBLL objDataPrint = new DataPrintBLL();
        
        private void DataPrint_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            #region 导出为表格功能
            if (rdbSchInfo.Checked)
            {
                ExportToExcel();
            }
            
            if (rdbPrintManager.Checked)
            {
                ExportToExcel();
            }

            if (rdbPrintStudentInfo.Checked)
            {
                ExportToExcel();
            }

            if (rdbPrintTeacherInfo.Checked)
            {
                ExportToExcel();
            }

            if (rdbCourseInfo.Checked)
            {
                ExportToExcel();
            }

            if (rdbStuScore.Checked)
            {
                ExportToExcel();
            }
            
            if (rdbClassScore.Checked)
            {
                ExportToExcel();
            }

            MessageBox.Show("数据导出成功", "系统提示");

            #endregion
        }
        
        
        private void btnExportText_Click(object sender, EventArgs e)
        {
            #region 导出为文本功能
            if (rdbSchInfo.Checked)
            {
                ExportToTxt();
            }

            
            if (rdbPrintManager.Checked)
            {
                ExportToTxt();
            }

            if (rdbPrintStudentInfo.Checked)
            {
                ExportToTxt();
            }

            if (rdbPrintTeacherInfo.Checked)
            {
                ExportToTxt();
            }

            if (rdbCourseInfo.Checked)
            {
                ExportToTxt();
            }

            if (rdbStuScore.Checked)
            {
                ExportToTxt();
            }

            if (rdbClassScore.Checked)
            {
                ExportToTxt();
            }

            MessageBox.Show("数据导出成功", "系统提示");

            #endregion
        }




        #region 导出为表格  //▲▲怎样以点击选中的rdb控件名称作为标题？即怎样获取单击控件的文本名称
		//$$已经解决，选用一个变量获取文本，然后再赋值给：objDialog.FileName
        public void ExportToExcel()
        {

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

            finally
            {
                objSW.Close();
                objStream.Close();
            }
        }
        #endregion

        #region 导出为文本 //▲▲怎样以点击选中的rdb控件名称作为标题？即怎样获取单击控件的文本名称
		//$$已经解决，选用一个变量获取文本，然后再赋值给：objDialog.FileName
        public void ExportToTxt()
        {
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
        }
        #endregion


        #region 点击对应rdbXX后，自动显示数据在表格和赋值给变量FileName，用作导出文件名：

        private void rdbSchInfo_Click(object sender, EventArgs e)
            {
                dataGridView1.DataSource = objDataPrint.SchoolInfo();
                FileName = rdbSchInfo.Text;
            }

            private void rdbPrintStudentInfo_Click(object sender, EventArgs e)
            {
                dataGridView1.DataSource = objDataPrint.PrintStuInfo();
                FileName = rdbPrintStudentInfo.Text;
            }

            private void rdbPrintManager_Click(object sender, EventArgs e)
            {
                dataGridView1.DataSource = objDataPrint.PrintAdminInfo();
                FileName = rdbPrintManager.Text;
            }

            private void rdbCourseInfo_Click(object sender, EventArgs e)
            {
                dataGridView1.DataSource = objDataPrint.PrintCourseInfo();
                FileName = rdbCourseInfo.Text;
            }

            private void rdbPrintTeacherInfo_Click(object sender, EventArgs e)
            {
                dataGridView1.DataSource = objDataPrint.PrintTeaInfo();
                FileName=rdbPrintTeacherInfo.Text;
            }

            private void rdbStuScore_Click(object sender, EventArgs e)
            {
                dataGridView1.DataSource = 0;
                FileName = rdbStuScore.Text;
            }

            private void rdbClassScore_Click(object sender, EventArgs e)
            {
                dataGridView1.DataSource = 0;   //由于上一个是搜索个人的，要重置一下表格内容
                dataGridView1.DataSource = objDataPrint.PrintClassScore();
                FileName = rdbClassScore.Text;
            }

        #endregion

           
            
    }
}