using System;
using System.Windows.Forms;
using BLL;
using DataBaseOperate;
using Model;

namespace UI
{
    public partial class ClassInfo : CentralUse
    {
        
       
        public ClassInfo()
        {
            InitializeComponent();
        }

        private void ShowClass()
        {
            ClassBLL objClass1BLL = new ClassBLL();
            dgvClass.DataSource = objClass1BLL.ShowClass();
        }

        private void ShowCombox()
        {
            GetTableColumnBLL objGetTableColumnBLL = new GetTableColumnBLL();

            string[] ClaNum = objGetTableColumnBLL.GetClaNum();
            cmbClaNum.Items.AddRange(ClaNum);

            string[] ClaName = objGetTableColumnBLL.GetClaName();
            cmbClaName.Items.AddRange(ClaName);

            string[] DeptNum= objGetTableColumnBLL.GetDeptNum();
            cmbDeptNum.Items.AddRange(DeptNum);
            
            string[]  DeptName= objGetTableColumnBLL.GetDeptName();
            cmbDeptName.Items.AddRange(DeptName);

            string[] ProNum = objGetTableColumnBLL.GetProNum();
            cmbProNum.Items.AddRange(ProNum);

            string[] ProName = objGetTableColumnBLL.GetProName();
            cmbProName.Items.AddRange(ProName);
        
        }


        private void classinfo_Load(object sender, EventArgs e)
        {
            ShowClass();
            ShowCombox();
        }

        private  void btnSearch_Click(object sender, EventArgs e)
        {

            #region 使用实体类在三层中传递数据
            ClassBLL objClass1BLL = new ClassBLL();
            ClassModel objClassModel = new ClassModel();

            DataBaseOperaClass objDataBase = new DataBaseOperaClass();

            objClassModel.ClaNum = cmbClaNum.Text;
            dgvClass.DataSource = objClass1BLL.SearchClass(objClassModel); 
            #endregion
            ShowClass();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            #region //
            //ClassBLL objClass1BLL = new ClassBLL();
            //ClassModel objClass = new ClassModel();
            //objClass.ClaNum = txtbClassNum.Text;
            //objClass.ClaName = txtbClass.Text;
            //objClass.DeptNum = txtbDeptNum.Text;
            //objClass.ProNum = txtbcmbProNum.Text;

            //if (objClass1BLL.AddClass(objClass) == true)
            //    MessageBox.Show("数据添加成功");
            //else
            //    MessageBox.Show("数据添加成功");
            //dgvClass.DataSource = objClass1BLL.ShowClass(); 
            #endregion

            #region 使用实体类在各层传递数据：
            
            if (cmbClaNum.Text == "" || cmbClaName.Text == "")
            {
                MessageBox.Show("班号、班名都不能为空！\n 请重新输入！");
            }
            else
            {
                ClassBLL objClassBLL = new ClassBLL();

                ClassModel objClassModel = new ClassModel();

                objClassModel.ClaNum = cmbClaNum.Text;
                objClassModel.ClaName = cmbClaName.Text;
                objClassModel.DeptNum = cmbDeptNum.Text;
                objClassModel.DeptName = cmbDeptName.Text;
                objClassModel.ProNum = cmbProNum.Text;
                //objClassModel.ProName = cmbProName.Text;
                

                if (objClassBLL.AddClass(objClassModel)==true)
                {
                    MessageBox.Show("添加成功！");
                }
                else
                    MessageBox.Show("添加失败！");
            }
            #endregion

            ShowClass();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            #region //
            //ClassBLL objClass1BLL = new ClassBLL();
            //ClassModel objClass = new ClassModel();
            ////objClass.ClaNum = dgvClass[0, dgvClass.CurrentRow.Index].Value.ToString();
            //objClass.ClaNum = txtClassNum.Text;
            //objClass.ClaName = txtClassName.Text;
            //objClass.DeptNum = cmbDeptNum.Text;
            //objClass.ProNum = cmbProNum.Text;
            //if (objClass1BLL.ChangeClass(objClass) == true)
            //    MessageBox.Show("数据修改成功");
            //else
            //    MessageBox.Show("数据修改失败");

            //dgvClass.DataSource = objClass1BLL.ShowClass(); 
            #endregion

            #region 使用实体类在各层传递数据
            //if (txtStuNum.Text == "")
            if (cmbClaNum.Text == "" || cmbClaName.Text == "")
            {
                MessageBox.Show("班号、班名不能为空！\n 请重新输入！");
            }
            else
            {
                
                ClassBLL objClassBLL = new ClassBLL();

                ClassModel objClassModel = new ClassModel();

                objClassModel.ClaName = cmbClaName.Text;
                objClassModel.ClaNum = cmbClaNum.Text;
                objClassModel.DeptNum = cmbDeptNum.Text;
                objClassModel.ProNum = cmbProNum.Text;
                
                if(objClassBLL.ChangeClass(objClassModel)==true)
                {
                    MessageBox.Show("修改成功！");
                }
                else
                    MessageBox.Show("修改失败！");
            }
            #endregion

            ShowClass();

        }

       

        private void btnDel_Click(object sender, EventArgs e)
        {
            #region 使用实体类在各层传递数据
            ClassBLL objClass1BLL = new ClassBLL();
            ClassModel objClassModel = new ClassModel();

            objClassModel.ClaNum = cmbClaNum.Text;

            if (objClass1BLL.DeleteClass(objClassModel) == true)
            {
                objClass1BLL.DeleteClass(objClassModel);
                MessageBox.Show("数据删除成功");

            }
            else
            {
                MessageBox.Show("数据删除失败");
            } 
            #endregion

            ShowClass();
        }


        //清空信息编辑框内容：
        private void Clear()
        {
            foreach (Control ct in this.groupBox2.Controls)     //获取所有控件，这里是在GroupBox1容器内的。
            {
                if (ct is ComboBox)                                  //当ct是ComboBox控件时
                {
                    (ct as ComboBox).Text = "";                      //把ct的text值变为空字符串；
                }
            }

            //dtBirthday.Text = DateTime.Now.ToString();
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void dgvClass_Click(object sender, EventArgs e)
        {
            #region  //单击网格，显示结果在文本框：
            int CurrentRow = dgvClass.CurrentRow.Index;
            cmbClaNum.Text = dgvClass[0, CurrentRow].Value.ToString();
            cmbClaName.Text = dgvClass[1, CurrentRow].Value.ToString();
            cmbProNum.Text = dgvClass[2, CurrentRow].Value.ToString();
            cmbProName.Text = dgvClass[3, CurrentRow].Value.ToString();
            cmbDeptNum.Text = dgvClass[4, CurrentRow].Value.ToString();
            cmbDeptName.Text = dgvClass[5, CurrentRow].Value.ToString();
            #endregion

        }

        private void cmbClaNum_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbClaName.SelectedIndex = cmbClaNum.SelectedIndex;
        }

        private void cmbClaName_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbClaNum.SelectedIndex = cmbClaName.SelectedIndex;
        }

        private void cmbDeptNum_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDeptName.SelectedIndex = cmbDeptNum.SelectedIndex;
        }

        private void cmbDeptName_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDeptNum.SelectedIndex = cmbDeptName.SelectedIndex;
        }


        private void cmbProNum_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbProName.SelectedIndex = cmbProNum.SelectedIndex;
        }

        private void cmbProName_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbProNum.SelectedIndex = cmbProName.SelectedIndex;
        }

        


    }
}
