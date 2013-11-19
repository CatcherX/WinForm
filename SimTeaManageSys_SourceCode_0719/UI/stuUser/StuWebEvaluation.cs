using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using BLL;
using DataBaseOperate2;
using Model;

namespace UI
{
    /// <summary>
    /// 后期加的功能，当初没有规划好，这个没有做成三层架构。
    /// </summary>
    public partial class StuWebEvaluation : CentralUse
    {
        public StuWebEvaluation()
        {
            InitializeComponent();
        }

        DataBaseOperateClass2 objDataBaseOperateClass2 = new DataBaseOperateClass2();
        StuWebEvalModel objStuWebEvalModel = new StuWebEvalModel();
        LoginUserModel objLoginUserModel = new LoginUserModel();

        private void StuWebEvaluation_Load(object sender, EventArgs e)
        {
            textBox1.Text = "请用精简的文字对教师的教学情况进行评价！";
            rdbGood.Checked = true;

            #region 获取当前使用用户id
                LoginUIBLL objLoginUIBLL = new LoginUIBLL();
            //LoginUserModel objLoginUserModel = new LoginUserModel();
                SqlDataReader SqlRead;
                SqlRead = objLoginUIBLL.LoginUserRead();

                if (SqlRead.Read())
                {
                    objLoginUserModel.UserId = SqlRead["UserId"].ToString();
                }  
            #endregion

                ShowEvalInfo(); 


        }

        //显示当前登录学生的评教情况：
        private void ShowEvalInfo()
        {
            //string SqlString ="Select * From dbo.V_StuWebEval Where 学号='" + objLoginUserModel.UserId + "'";

        string SqlString="Select 学号,教师编号,TeaName AS 教师姓名,教师分数,评价内容,评价状态,学期 From dbo.V_StuWebEval join Teacher on 教师编号=TeaNum and 学号='" + objLoginUserModel.UserId + "'";

            dataGridView1.DataSource = objDataBaseOperateClass2.ShowTable(SqlString);

        }


        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("评价内容不能为空！请检查再提交！", "温馨提醒", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else 
            {
                #region 进入评价：
            if (objStuWebEvalModel.EvalCheck == "是")
                MessageBox.Show("你已经进行了评教操作！不能重复提交！");
            else
            {
                //如果检查到有了评价内容，则评价状态修改为“是”
                #region 改为在数据库中设计触发器，检查到评价内容有插入数据时，就把状态设为是
                //if (objStuWebEvalModel.StuEvalTxt != "")
                //    objStuWebEvalModel.EvalCheck = "是";
                //else
                //    objStuWebEvalModel.EvalCheck = "否"; 
                #endregion

                string SqlString = "Update V_StuWebEval set 评价内容='" + textBox1.Text + "',评价状态='" + objStuWebEvalModel.EvalCheck + "',教师分数";

                objStuWebEvalModel.StuEvalTxt = textBox1.Text;

                #region 类型选择：
                if (rdbVeryGood.Checked == true)
                {
                    SqlString += "+=5 Where 学号='" + objLoginUserModel.UserId + "'";
                }
                if (rdbGood.Checked == true)
                {
                    SqlString += "+=3 Where 学号='" + objLoginUserModel.UserId + "'";
                }
                if (rdbSoSo.Checked == true)
                {
                    SqlString += "+=1 Where 学号='" + objLoginUserModel.UserId + "'";
                }
                #endregion

                SqlString += " AND 教师编号='" + cbxTeaNum.Text + "'";

                if (objDataBaseOperateClass2.GetExecute(SqlString) == true)
                {

                    //当前学生成功对教师进行评价后，把该学生对教师的评价状态设为是，防止重复评价！
                    string SqlString2 = "Update dbo.V_StuWebEval set 评价状态='是' Where 学号='" + objLoginUserModel.UserId + "'";

                    SqlString2 += " AND 教师编号='" + cbxTeaNum.Text + "'";

                    objDataBaseOperateClass2.GetExecute(SqlString2);

                    ShowEvalInfo();
                    MessageBox.Show("成功评教！谢谢参与！");


                }
                else
                {
                    MessageBox.Show("提交失败！");
                }

            }
            #endregion
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            int CurrentRow = dataGridView1.CurrentRow.Index;
            objStuWebEvalModel.StuEvalTxt = dataGridView1[4, CurrentRow].Value.ToString();
            objStuWebEvalModel.EvalCheck = dataGridView1[5, CurrentRow].Value.ToString();
            objStuWebEvalModel.TeaNum = dataGridView1[1, CurrentRow].Value.ToString();
            cbxTeaNum.Text = objStuWebEvalModel.TeaNum;
            cmbTeaName.Text = dataGridView1[2, CurrentRow].Value.ToString();
        }

       
       
    }
}
