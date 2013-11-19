using System;
using System.IO;
using System.Windows.Forms;
using BLL;
using DataBaseOperate2;
using Model;

namespace UI
{
    /// <summary>
    /// 后期加的功能，当初没有规划好，这个没有做成三层架构。
    /// </summary>
    public partial class frmVipAllInfo : Form
    {
        public frmVipAllInfo()
        {
            InitializeComponent();
        }

        string FileName;

        SaveFileDialog objDialog = new SaveFileDialog();

        DataPrintBLL objDataPrint = new DataPrintBLL();



        DataBaseOperateClass2 objDataBaseOperateClass2 = new DataBaseOperateClass2();


        private void ShowAllInfo()
        {
            DataBaseOperateClass2 objDataBaseOperateClass2 = new DataBaseOperateClass2();

            string SqlString = "Select * From School";
            dataGridView1.DataSource = objDataBaseOperateClass2.ShowTable(SqlString);
        }

        private void frmVipAllInfo_Load(object sender, EventArgs e)
        {
            rdbSchInfo.Checked = true;
        }


        #region 选中类型，显示对应的数据信息在表格中；
        private void rdbSchInfo_Click(object sender, EventArgs e)
        {
            string SqlString = "select SchNum AS 校区号,SchName AS 校区名 from dbo.School";
            dataGridView1.DataSource = objDataBaseOperateClass2.ShowTable(SqlString);
            FileName = rdbSchInfo.Text;
        }

        private void rdbDeptInfo_Click(object sender, EventArgs e)
        {
            string SqlString = "select  SchName AS 校区,DeptName AS 系部名称 from Department join School on Department.SchNum=School.SchNum group by DeptName,SchName";
            dataGridView1.DataSource = objDataBaseOperateClass2.ShowTable(SqlString); FileName = rdbDeptInfo.Text;
        }

        private void rdbProfession_Click(object sender, EventArgs e)
        {
            string SqlString = "select ProNum AS 专业编号,ProName AS 专业名,Profession.deptNum AS 系别号,DeptName As 系别 from dbo.Profession join Department on Profession.deptNum=Department.deptNum";
            dataGridView1.DataSource = objDataBaseOperateClass2.ShowTable(SqlString); FileName = rdbProfession.Text;
        }

        private void rdbClassInofo_Click(object sender, EventArgs e)
        {
            string SqlString = "select ClaNum AS 班号, ClaName AS 班级名称 , Department.DeptName AS 系别 from Class join Department on Class.DeptNum=Department.DeptNum";
            dataGridView1.DataSource = objDataBaseOperateClass2.ShowTable(SqlString); FileName = rdbClassInofo.Text;
        }

        private void rdbPrintManager_Click(object sender, EventArgs e)
        {
            string SqlString = "Select AdminNum AS 工号,AdminName AS 姓名, AdminSex AS 性别,AdminPhone AS 联系电话 ,AdminAdress AS 地址 From Admin";
            dataGridView1.DataSource = objDataBaseOperateClass2.ShowTable(SqlString); FileName = rdbPrintManager.Text;
        }

        private void rdbPrintTeacherInfo_Click(object sender, EventArgs e)
        {
            string SqlString = "Select TeaNum AS 工号,TeaName AS 姓名,TeaSex AS 性别, TeaAdress AS 联系地址,TeaPhone AS 联系电话,TeaTitle AS 职称,TeaProField AS 专业方向 From Teacher";
            dataGridView1.DataSource = objDataBaseOperateClass2.ShowTable(SqlString); FileName = rdbPrintTeacherInfo.Text;
        }

        private void rdbPrintStudentInfo_Click(object sender, EventArgs e)
        {
            string SqlString = "select StuNum AS 学号,StuName AS 姓名,StuSex AS 性别,Policity AS 政治背景,Birthday AS 生日, Favor AS 爱好 ,StuScore AS 综合分 ,Meno AS 备注,ClaName AS 班别,Phone AS 联系电话,Address AS 地址 from Student join Class on Student.ClaNum=Class.ClaNum";

            


            dataGridView1.DataSource = objDataBaseOperateClass2.ShowTable(SqlString); FileName = rdbPrintStudentInfo.Text;
        }

        private void rdbLoginUserInfo_Click(object sender, EventArgs e)
        {
            string SqlString = "Select UserId as 用户编号,UserRole AS 用户身份, UserPw as 用户密码 ,LoginCount AS 登录次数 From LoginUser";
            dataGridView1.DataSource = objDataBaseOperateClass2.ShowTable(SqlString); FileName = rdbLoginUserInfo.Text;
        }

        private void rdbCourseInfo_Click(object sender, EventArgs e)
        {
            string SqlString = "select CourseNum as 课程号,CourseName as 课程名称,Credit AS 学分,ProOrPub as 专业或公共,NeedOrOpt  AS  类型 ,Department.DeptName as 所属系 from  Course join Department on Course.DeptNum=Department.DeptNum order by CourseNum desc";
            dataGridView1.DataSource = objDataBaseOperateClass2.ShowTable(SqlString); FileName = rdbCourseInfo.Text;
        }

        private void rdbTeachingInfo_Click(object sender, EventArgs e)
        {
            string SqlString = "Select TeaName AS 教师姓名,Semester AS 学期,CourseName AS 授课名称 From Teacher,Teaching,Course Where Teacher.TeaNum=Teaching.TeaNum and Course.CourseNum=Teaching.CourseNum";
            dataGridView1.DataSource = objDataBaseOperateClass2.ShowTable(SqlString); FileName = rdbTeachingInfo.Text;
        }

        private void rdbStuWebEval_Click(object sender, EventArgs e)
        {
            string SqlString = "Select 学号,教师编号,TeaName AS 教师姓名,教师分数,评价内容,评价状态,学期 From dbo.V_StuWebEval join Teacher on 教师编号=TeaNum";
            dataGridView1.DataSource = objDataBaseOperateClass2.ShowTable(SqlString); FileName = rdbStuWebEval.Text;
        }


        private void rdbWebCommetn_Click(object sender, EventArgs e)
        {
            string SqlString = "Select * From dbo.V_StuWebComment";
            dataGridView1.DataSource = objDataBaseOperateClass2.ShowTable(SqlString); FileName = rdbWebCommetn.Text;
        }
        #endregion

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            #region 导出为表格功能
            if (rdbSchInfo.Checked)
            {
                ExportToExcel();
            }

            if (rdbDeptInfo.Checked)
            {
                ExportToExcel();
            }

            if (rdbProfession. Checked)
            {
                ExportToExcel();
            }

            if (rdbClassInofo.Checked)
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

            if (rdbTeachingInfo.Checked)
            {
                ExportToExcel();
            }

            if (rdbStuWebEval.Checked)
            {
                ExportToExcel();
            }

            if (rdbWebCommetn.Checked)
            {
                ExportToExcel();
            }


          
            MessageBox.Show("数据导出成功", "系统提示");

            #endregion
        }

        private void btnExportText_Click(object sender, EventArgs e)
        {
            #region 导出为文本
            if (rdbSchInfo.Checked)
            {
                ExportToTxt();
            }

            if (rdbDeptInfo.Checked)
            {
                ExportToTxt();
            }

            if (rdbProfession.Checked)
            {
                ExportToTxt();
            }

            if (rdbClassInofo.Checked)
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

            if (rdbTeachingInfo.Checked)
            {
                ExportToTxt();
            }

            if (rdbStuWebEval.Checked)
            {
                ExportToTxt();
            }

            if (rdbWebCommetn.Checked)
            {
                ExportToTxt();
            }
        }
            #endregion




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




        private void btnExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("尊敬的领导！再见！", "温馨提醒！", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Exit();
        }

        private void btnChangeRole_Click(object sender, EventArgs e)
        {
            LoginUI objLoginUI = new LoginUI();
            objLoginUI.Show();
            //this.Close();
            this.Hide();

            LoginUIBLL objLoginUIBLL = new LoginUIBLL();
            LoginUserModel objLoginUserModel = new LoginUserModel();
            //objLoginUserModel.UserId = toolLoginUserId.Text;
            objLoginUIBLL.UpdateLoginUserStateClose();
        }

    }
}
