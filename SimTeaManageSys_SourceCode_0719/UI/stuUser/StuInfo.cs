using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using BLL;
using Model;

namespace UI
{
    public partial class StuInfo : CentralUse
    {
        public StuInfo()
        {
            InitializeComponent();
        }

        LoginUIBLL objLoginUIBLL = new LoginUIBLL();
        StudentBLL objStudentBLL = new StudentBLL();
        StudentModel objStudentModel = new StudentModel();
        LoginUserModel objLoginUserModel = new LoginUserModel();
        //frmStuMain objfrmStuMain = new frmStuMain();
        SqlDataReader SqlRead;

        

        private void StuInfo_Load(object sender, EventArgs e)
        {
            //objStudentModel.StuNum = objfrmStuMain.frmStuMainStuNum();


            SqlRead = objLoginUIBLL.LoginUserRead();

            if (SqlRead.Read())
            {
                objLoginUserModel.UserId = SqlRead["UserId"].ToString();
            }

            dataGridView1.DataSource = objStudentBLL.LoginUserSearchStuInfo(objLoginUserModel);

            try
            {
                int CurrentRow = dataGridView1.CurrentRow.Index;
                txtStuNum.Text = dataGridView1[0, CurrentRow].Value.ToString();
                txtStuName.Text = dataGridView1[1, CurrentRow].Value.ToString();
                cbxStuSex.Text = dataGridView1[2, CurrentRow].Value.ToString();
                txtPolicity.Text = dataGridView1[3, CurrentRow].Value.ToString();
                dtBirthday.Text = dataGridView1[4, CurrentRow].Value.ToString();
                txtFavor.Text = dataGridView1[5, CurrentRow].Value.ToString();
                txtStuScore.Text = dataGridView1[6, CurrentRow].Value.ToString();
                txtMono.Text = dataGridView1[7, CurrentRow].Value.ToString();
                txtClaNum.Text = dataGridView1[8, CurrentRow].Value.ToString();
                txtPhone.Text = dataGridView1[9, CurrentRow].Value.ToString();
                txtAddress.Text = dataGridView1[10, CurrentRow].Value.ToString();
            }

            catch (Exception e1)
            {
                MessageBox.Show("同学，你好！\n 你的个人信息暂没数据.\n请稍后再查询\n敬请谅解!");
                if (MessageBox.Show("是否查看错误信息？", "", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.Yes)
                {
                    MessageBox.Show("错误信息" + e1);
                }
                else
                {
                    //this.Close();
                }

            }

        }
    }
}
