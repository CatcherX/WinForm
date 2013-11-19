using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using DataBaseOperate;
using SimStuManageSysBLL;
using SimStuManageSysModel;

namespace SimStuManageSys
{
    public partial class ProfessionInfo : CentralUse
    {
        public ProfessionInfo()
        {
            InitializeComponent();
        }

        private void ShowTable()
        {
            ProfessionBLL objProfessionBLL = new ProfessionBLL();
            dataGridView1.DataSource = objProfessionBLL.ShowProfession();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            ShowTable();
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtProNum.Text == "")
            {
                MessageBox.Show("专业号不能为空！\n 请重新输入！");

            }
            else
            {
                ProfessionBLL objProfessionBLL = new ProfessionBLL();

                ProfessionModel objProfessionModel = new ProfessionModel();

                objProfessionModel.ProNum = txtProNum.Text;
                objProfessionModel.ProName = txtProName.Text;
                objProfessionModel.DepartNum = txtDepartNum.Text;
                objProfessionModel.DepartName = txtDepartName.Text;
        
                if(objProfessionBLL.InsertProfession(objProfessionModel)==true)
                {
                    MessageBox.Show("录入成功！");
                }
                else
                    MessageBox.Show("录入失败！");
            }

            ShowTable();


        }


        private void btnModify_Click_1(object sender, EventArgs e)
        {
            if (txtProNum.Text==""|| txtProName.Text == "")
            {
                MessageBox.Show("专业号，专业名称不能为空！\n 请重新输入！");
            }
            else
            {
                ProfessionBLL objProfessionBLL = new ProfessionBLL();

                ProfessionModel objProfessionModel = new ProfessionModel();

                objProfessionModel.ProNum = txtProNum.Text;
                objProfessionModel.ProName = txtProName.Text;
                objProfessionModel.DepartNum = txtDepartNum.Text;
                objProfessionModel.DepartName = txtDepartName.Text;

                if(objProfessionBLL.UpdatejProfession(objProfessionModel)==true)
                {
                    MessageBox.Show("修改成功！");
                }
                else
                    MessageBox.Show("修改失败！");
            }

            ShowTable();


        }


        private void btnDel_Click(object sender, EventArgs e)
        {
            if (txtProNum.Text == "")
            {
                MessageBox.Show("学号不能为空！\n 请重新输入！");
            }
            else
            {

                ProfessionBLL objSelCourseBLLClass = new ProfessionBLL();
                ProfessionModel objProfessionModel = new ProfessionModel();

                objProfessionModel.ProNum = txtProNum.Text;

                if (objSelCourseBLLClass.DelProfession(objProfessionModel) == true)
                {
                    MessageBox.Show("删除成功！!");
                }
                else
                {
                    MessageBox.Show("删除失败!");
                }
            }

            ShowTable();

        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            txtProNum .Text= "";
            txtProName.Text = "";
            dataGridView1.DataSource = 0;
        }

     
        private void dataGridView1_Click(object sender, EventArgs e)
        {
            #region  //单击网格，显示结果在文本框：
            int CurrentRow =  dataGridView1. CurrentRow.Index;

            txtProNum.Text = dataGridView1[0, CurrentRow].Value.ToString();
            txtProName.Text = dataGridView1[1, CurrentRow].Value.ToString();
            
            txtDepartNum.Text = dataGridView1[2, CurrentRow].Value.ToString();
            txtDepartName.Text = dataGridView1[3, CurrentRow].Value.ToString();
            #endregion
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
