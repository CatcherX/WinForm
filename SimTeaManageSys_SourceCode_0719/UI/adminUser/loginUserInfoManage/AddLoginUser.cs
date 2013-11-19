using System;
using System.Windows.Forms;
using BLL;
using Model;

namespace UI
{
    public partial class frmAdminMenuAddLoginUser : CentralUse
    {
        public frmAdminMenuAddLoginUser()
        {
            InitializeComponent();
        }

        LoginUIBLL objLoginUIBLL = new LoginUIBLL();
        LoginUserModel objLoginUserModel = new LoginUserModel();
        

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtUserID.Text == "")
            {
                MessageBox.Show("用户编号不能为空.\n请检查后输入！");
                txtUserID.Focus();
            }
            else
            {
                objLoginUserModel.UserId = txtUserID.Text;
                objLoginUserModel.UserRole = txtUserRole.Text;
                objLoginUserModel.UserPw = txtUserPw.Text;

                if (objLoginUIBLL.AddLoginUser(objLoginUserModel) == true)
                { MessageBox.Show("添加成功！");}
                else
                { MessageBox.Show("添加失败！");}

                ShowLoginUser();
            }

        }
       
        private void ShowLoginUser()
        {
            dataGridView1.DataSource = objLoginUIBLL.GetTable();
        }

        private void LoginUserInfoManage_Load(object sender, EventArgs e)
        {
            ShowLoginUser();
        }
    }
}
