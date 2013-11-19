using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using SimStuManageSysBLL;
using SimStuManageSysModel;
using DataBaseOperate;

namespace SimStuManageSys
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

        private void classinfo_Load(object sender, EventArgs e)
        {
            ShowClass();
        }

        private  void btnSearch_Click(object sender, EventArgs e)
        {

            #region 使用实体类在三层中传递数据
            ClassBLL objClass1BLL = new ClassBLL();
            SchoolMolel objClassModel = new SchoolMolel();

            DataBaseOperaClass objDataBase = new DataBaseOperaClass();

            objClassModel.SchNum = txtClaNum.Text;
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
            //objClass.ProNum = txtbProNum.Text;

            //if (objClass1BLL.AddClass(objClass) == true)
            //    MessageBox.Show("数据添加成功");
            //else
            //    MessageBox.Show("数据添加成功");
            //dgvClass.DataSource = objClass1BLL.ShowClass(); 
            #endregion

            #region 使用实体类在各层传递数据：
            
            if (txtClaNum.Text == "" || txtClaName.Text == "")
            {
                MessageBox.Show("班号、班名都不能为空！\n 请重新输入！");
            }
            else
            {
                ClassBLL objClassBLL = new ClassBLL();

                SchoolMolel objClassModel = new SchoolMolel();

                objClassModel.ClaName = txtClaName.Text;
                objClassModel.SchNum = txtClaNum.Text;
                objClassModel.DeptNum = txtDeptNum.Text;
                objClassModel.ProNum = txtProNum.Text;
                

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
            //objClass.DeptNum = txtDeptNum.Text;
            //objClass.ProNum = txtProNum.Text;
            //if (objClass1BLL.ChangeClass(objClass) == true)
            //    MessageBox.Show("数据修改成功");
            //else
            //    MessageBox.Show("数据修改失败");

            //dgvClass.DataSource = objClass1BLL.ShowClass(); 
            #endregion

            #region 使用实体类在各层传递数据
            //if (txtStuNum.Text == "")
            if (txtClaNum.Text=="" || txtClaName.Text=="")
            {
                MessageBox.Show("班号、班名不能为空！\n 请重新输入！");
            }
            else
            {
                
                ClassBLL objClassBLL = new ClassBLL();

                SchoolMolel objClassModel = new SchoolMolel();

                objClassModel.ClaName = txtClaName.Text;
                objClassModel.SchNum = txtClaNum.Text;
                objClassModel.DeptNum = txtDeptNum.Text;
                objClassModel.ProNum = txtProNum.Text;
                
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
            SchoolMolel objClassModel = new SchoolMolel();

            objClassModel.SchNum = txtClaNum.Text;

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

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtClaNum.Text = "";
            txtClaName.Text = "";
            txtDeptNum.Text = "";
            txtProNum.Text = "";
        }

        private void dgvClass_Click(object sender, EventArgs e)
        {
            #region  //单击网格，显示结果在文本框：
            int CurrentRow = dgvClass.CurrentRow.Index;
            txtClaNum.Text = dgvClass[0, CurrentRow].Value.ToString();
            txtClaName.Text = dgvClass[1, CurrentRow].Value.ToString();
            txtDeptNum.Text = dgvClass[2, CurrentRow].Value.ToString();
            txtProNum.Text = dgvClass[3, CurrentRow].Value.ToString();
            #endregion

        }


    }
}
