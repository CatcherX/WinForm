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
    public partial class StuWebComments : CentralUse
    {
        public StuWebComments()
        {
            InitializeComponent();
        }
        
            LoginUIBLL objLoginUIBLL = new LoginUIBLL();
            LoginUserModel objLoginUserModel = new LoginUserModel();

        private void StuWebComments_Load(object sender, EventArgs e)
        {
            txtComment.Text="请先选择留言类型，然后输入你想要说的话！编辑完成之后，点击提交！";
            
            rdbconsult.Checked = true;
        }

        private void btnPost_Click(object sender, EventArgs e)
        {

            #region 获取当前登录用户ID
            LoginUIBLL objLoginUIBLL = new LoginUIBLL();
            LoginUserModel objLoginUserModel = new LoginUserModel();
            SqlDataReader SqlRead;
            SqlRead = objLoginUIBLL.LoginUserRead();

            if (SqlRead.Read() == true)
            {
                objLoginUserModel.UserId = SqlRead["UserId"].ToString();
            }
            #endregion

            string SqlString="Insert into V_StuWebComment";

            #region 类型选择
            if (rdbSuggest.Checked == true)
            {
                SqlString += "(学号,建议) Values('" + objLoginUserModel.UserId + "','" + txtComment.Text + "')";
            }
            if (rdbCriticism.Checked == true)
            {
                SqlString += "(学号,批评) Values('" + objLoginUserModel.UserId + "','" + txtComment.Text + "')";
            }

            if (rdbconsult.Checked == true)
            {
                SqlString += "(学号,咨询) Values('" + objLoginUserModel.UserId + "','" + txtComment.Text + "')";
            } 
            #endregion

            DataBaseOperateClass2 objDataBaseOperateClass2 = new DataBaseOperateClass2();

            #region 异常处理
            try
            {
                if (objDataBaseOperateClass2.GetExecute(SqlString) == true)
                    MessageBox.Show("成功提交！谢谢参与！");
                else
                    MessageBox.Show("抱歉！提交失败！请查看错误消息：");
            }
            catch (Exception e1)
            {
                MessageBox.Show("抱歉！提交失败！请查看错误消息：");
                MessageBox.Show("错误消息：" + e1);
            } 
            #endregion

        }

        private void txtComment_Click(object sender, EventArgs e)
        {
            txtComment.Text = "";
            label1.Text = "输入你想说的话：";
        }

    }
}
