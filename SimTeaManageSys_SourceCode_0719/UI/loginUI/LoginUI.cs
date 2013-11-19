using System;
using System.Data.SqlClient;  //添加引用
using System.Threading;
using System.Windows.Forms;
using BLL;
using Model;

namespace UI
{
    public partial class LoginUI : CentralUse
    {
        public LoginUI()
        {
            InitializeComponent();
        }

        LoginUIBLL objLoginUIBLL = new LoginUIBLL();
        LoginUserModel objLoginUserModel = new LoginUserModel();
        SqlDataReader SqlRead;
        ReadMe objReadMe = new ReadMe();

        //public delegate void MenuHandle(string role);
        //public event MenuHandle Menuevent;

        
        
        #region 身份选择检查：
            public void RoleCheck()
                {
                    if (cmbIdentity.Text == "教师")
                        new Thread(() => Application.Run(new frmTeaMain())).Start();

                    if (cmbIdentity.Text == "教务员")
                        new Thread(() => Application.Run(new frmAdminMain())).Start();

                    if (cmbIdentity.Text == "学生")
                        new Thread(() => Application.Run(new frmStuMain())).Start();


   if (cmbIdentity.Text != "教师" && cmbIdentity.Text != "教务员" && cmbIdentity.Text != "学生" && cmbIdentity.Text != "学院领导")
                    {
        //if (MessageBox.Show("非法用户\n请检查登录身份！\n点击确定后将关闭窗口\n要更改身份请点击否", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                        MessageBox.Show("非法用户\n请检查登录身份！\n点击确定后将关闭窗口");
                        MessageBox.Show("再见！");
                    }
                }
        #endregion



        //登录按钮事件：
            private void btnOK_Click_1(object sender, EventArgs e)
            {
                #region 检验是否非法用户登录：
                if (cmbIdentity.Text != "教师" && cmbIdentity.Text != "教务员" && cmbIdentity.Text != "学生"&&cmbIdentity.Text!="学院领导")
                {
                    //if (MessageBox.Show("非法用户\n请检查登录身份！\n点击确定后将关闭窗口\n要更改身份请点击否", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)

                    if (MessageBox.Show("非法用户\n请检查登录身份！\n是否重新输入？", "温馨提示！", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.Yes)
                    {
                        Clear();
                        txtUid.Focus();
                        return;              //要在这里加入一个返回值，让它不要继续执行下一步。
                    }
                    else
                    {//否则退出登录界面
                        MessageBox.Show("再见！");
                        this.Close();
                    }

                }
                #endregion

                #region 检查输入信息是否为空
                if (txtUid.Text == "" && txtUid.Text == "" && cmbIdentity.Text == "")
                {
                    MessageBox.Show("用户名、登录身份、密码都不能为空！\n请检查后再登录！");
                    txtUid.Focus();
                    return;
                }
                #endregion

                else
                {
                    try
                    {
                        #region 教师身份
                        if (cmbIdentity.Text == "教师")
                        {
                            objLoginUserModel.UserId = txtUid.Text;
                            objLoginUserModel.UserRole = cmbIdentity.Text;
                            //objLoginUserModel.UserPw = txtPwd.Text;
           
                            objLoginUserModel.UserPw = GetMD5.GetMd5.GetMd5_32(txtUid.Text + txtPwd.Text);

                            SqlRead = objLoginUIBLL.LoginUserRead(objLoginUserModel);
                            //从数据库中找出用户名相符的密码，和身份

                            if (SqlRead.Read()) //从数据库中读取内容与登录信息验证
                            {
                                objLoginUserModel.UserId = txtUid.Text;
                                objLoginUIBLL.UpdateLoginUserStates(objLoginUserModel);


                                frmTeaMain objfrmTeaMain = new frmTeaMain();
                                objfrmTeaMain.Show();

                                this.Hide();
                            }

                            else
                            {
                                if (MessageBox.Show("请检查登录身份、用户名、密码是否正确！\n是否重新输入？", "温馨提示！", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.Yes)
                                {
                                    txtPwd.Text = ""; txtPwd.Focus();//清除密码框的信息，重新输入
                                }
                                else
                                    this.Close();//否则退出登录界面
                            }
                        }
                        #endregion

                        #region 学生身份：
                        if (cmbIdentity.Text == "学生")
                        {
                            objLoginUserModel.UserId = txtUid.Text;
                            objLoginUserModel.UserRole = cmbIdentity.Text;
                            objLoginUserModel.UserPw = txtPwd.Text;

                            objLoginUserModel.UserPw = GetMD5.GetMd5.GetMd5_32(txtUid.Text + txtPwd.Text);

                            SqlRead = objLoginUIBLL.LoginUserRead(objLoginUserModel);
                            //从数据库中找出用户名相符的密码，和身份

                            if (SqlRead.Read()) //从数据库中读取内容与登录信息验证
                            {
                                objLoginUserModel.UserId = txtUid.Text;
                                objLoginUIBLL.UpdateLoginUserStates(objLoginUserModel);


                                frmStuMain objfrmStuMain = new frmStuMain();
                                objfrmStuMain.Show();

                                this.Hide();

                                //objfrmStuMain.ShowDialog();
                                //new Thread(() => Application.Run(new frmStuMain())).Start();
                                //this.Close();
                            }

                            else
                            {
                                if (MessageBox.Show("请检查登录身份、用户名、密码是否正确！\n是否重新输入？", "温馨提示！", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.Yes)
                                {
                                    txtPwd.Text = ""; txtPwd.Focus();//清除密码框的信息，重新输入
                                }
                                else
                                    this.Close();//否则退出登录界面
                            }
                        }
                        #endregion

                        #region 教务员身份：
                        if (cmbIdentity.Text == "教务员")
                        {
                            objLoginUserModel.UserId = txtUid.Text;
                            objLoginUserModel.UserRole = cmbIdentity.Text;
                            objLoginUserModel.UserPw = txtPwd.Text;

                            objLoginUserModel.UserPw = GetMD5.GetMd5.GetMd5_32(txtUid.Text + txtPwd.Text);

                            SqlRead = objLoginUIBLL.LoginUserRead(objLoginUserModel);
                            //从数据库中找出用户名相符的密码，和身份


                            if (SqlRead.Read()) //从数据库中读取内容与登录信息验证
                            {
                                objLoginUserModel.UserId = txtUid.Text;
                                objLoginUIBLL.UpdateLoginUserStates(objLoginUserModel);


                                frmAdminMain objfrmAdminMain = new frmAdminMain();
                                objfrmAdminMain.Show();
                                //new Thread(() => Application.Run(new frmAdminMain())).Start();

                                ////this.Close();//▲▲怎样才可以不会把新打开的窗口也关闭掉？？
                                ////这样处理？
                                //objfrmTeaMain.ShowDialog();
                                //this.Close();
                                this.Hide();
                            }


                            else
                            {
                                if (MessageBox.Show("请检查登录身份、用户名、密码是否正确！\n是否重新输入？", "温馨提示！", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.Yes)
                                {
                                    txtPwd.Text = ""; txtPwd.Focus();//清除密码框的信息，重新输入
                                }
                                else
                                    this.Close();//否则退出登录界面
                            }



                        }
                        #endregion

                        #region 学院领导身份
                         if (cmbIdentity.Text == "学院领导")
                        {
                            objLoginUserModel.UserId = txtUid.Text;
                            objLoginUserModel.UserRole = cmbIdentity.Text;
                            objLoginUserModel.UserPw = txtPwd.Text;

                   objLoginUserModel.UserPw = GetMD5.GetMd5.GetMd5_32(txtUid.Text + txtPwd.Text);

                            SqlRead = objLoginUIBLL.LoginUserRead(objLoginUserModel);
                            //从数据库中找出用户名相符的密码，和身份


                            if (SqlRead.Read()) //从数据库中读取内容与登录信息验证
                            {
                                objLoginUserModel.UserId = txtUid.Text;
                                objLoginUIBLL.UpdateLoginUserStates(objLoginUserModel);

                                frmVipAllInfo objfrmVipAllInfo = new frmVipAllInfo();
                                objfrmVipAllInfo.Show();
                                //new Thread(() => Application.Run(new frmAdminMain())).Start();

                                ////this.Close();//▲▲怎样才可以不会把新打开的窗口也关闭掉？？
                                ////这样处理？
                                //objfrmTeaMain.ShowDialog();
                                //this.Close();
                                this.Hide();
                            }


                            else
                            {
                                if (MessageBox.Show("请检查登录身份、用户名、密码是否正确！\n是否重新输入？", "温馨提示！", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.Yes)
                                {
                                    txtPwd.Text = ""; txtPwd.Focus();//清除密码框的信息，重新输入
                                }
                                else
                                    this.Close();//否则退出登录界面
                            }



                        }
                        #endregion
                    }

                    #region Catch //当连接数据库出现问题时进入异常
                    catch (Exception e1)
                    {
                        if (MessageBox.Show("登录失败！你是否仔细阅读了使用说明呢？请根据错误消息进行处理。\n是否查看错误消息？", "温馨提醒", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                        {
                            MessageBox.Show("错误消息：" + e1);
                            if (MessageBox.Show("是否返回使用说明窗口？", "温馨提醒", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                            {
                                this.Hide();
                                //  objReadMe.MdiParent = this;
                                objReadMe.Show();
                            }
                            else
                            {
                                txtPwd.Focus();
                            }
                            ;
                        }
                        else
                        {
                            if (MessageBox.Show("是否返回使用说明窗口？", "温馨提醒", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                            {
                                this.Hide();
                                //  objReadMe.MdiParent = this;
                                objReadMe.Show();
                            }
                            else
                            {
                                cmbIdentity.Focus();
                            }
                        }
                    } 
                    #endregion
                }
            }
         
        //下拉列表触发文本框内容变化：
        private void cmbIdentity_SelectedIndexChanged(object sender, EventArgs e)
        {
                if (cmbIdentity.Text == "教师" || cmbIdentity.Text == "教务员")
                    txtUid.Text = "请输入工号";
                if (cmbIdentity.Text == "学生")
                    txtUid.Text = "请输入学号";
                //if (cmbIdentity.Text != "教务员" && cmbIdentity.Text != "学生" && cmbIdentity.Text != "教师")
                if (cmbIdentity.Text == "学院领导")
                    txtUid.Text = "请输入用户名";
                if (cmbIdentity.Text =="")
                    txtUid.Text = "请先选择登录身份！";

                 txtPwd.Text = "";  //身份变化时，密码要清空;;

                 if (txtUid.Text == "请先选择登录身份！" || txtUid.Text == "请输入工号" || txtUid.Text == "请输入学号" || txtUid.Text == "请输入用户名")
                 {
                     txtPwd.ReadOnly = true;
                 }
                 else
                 {
                     txtPwd.ReadOnly = false;
                 }


        }


        //下拉列表：
        private void UserLoginUI_Load(object sender, EventArgs e)
            {
                txtUid.Text = "请先选择登录身份！";
                //txtPwd.Text = "密码";
                cmbIdentity.Text = "请选择登录身份";

                cmbIdentity.Items.Add("学院领导");
                cmbIdentity.Items.Add("学生");
                cmbIdentity.Items.Add("教师");
                cmbIdentity.Items.Add("教务员");

                cmbIdentity.Focus();

                //if (Menuevent != null)
                //    Menuevent(cmbIdentity.Text); 
     if (txtUid.Text == "请先选择登录身份！"||txtUid.Text=="请输入工号"||txtUid.Text=="请输入学号"||txtUid.Text=="请输入用户名")
                {
                    txtPwd.ReadOnly = true;
                }


            }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("再见！欢迎下次使用！");
            //this.Close();
            Application.Exit();
        }

        private void Clear() 
        {
            
            txtPwd.Text = "";
            txtUid.Text = "";
            cmbIdentity.SelectedIndex = -1;
            cmbIdentity.Text = "";
            
        }

        private void txtUid_MouseClick(object sender, MouseEventArgs e)
        {

            #region //根据登录身份判断在点击输入框时是否要先清空信息框,当内容为提示性语言时要先清空：
            if (txtUid.Text == "请输入工号")
            {
                txtUid.Text = "";
                txtPwd.Text = "";
            }
            if (txtUid.Text == "请输入学号")
            {
                txtUid.Text = "";
                txtPwd.Text = "";
            }
            if (txtUid.Text == "请输入用户名")
            {
                txtUid.Text = "";
                txtPwd.Text = "";
            }
            else
            {

            } 
            #endregion


        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void cmbIdentity_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();    //退出登陆界面    
        }

        private void LoginUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Application.Exit();
        }

        private void txtUid_Click(object sender, EventArgs e)
        {
            txtPwd.ReadOnly = false;
        }


    }
}
