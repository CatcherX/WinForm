using System;
using System.Windows.Forms;
using BLL;
using Model;

namespace UI
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

        //Add:
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtProNum.Text == ""|| txtDepartName.Text==""||txtDepartNum.Text==""||txtProName.Text=="")
            {
                MessageBox.Show("专业号、专业名称、系编号、系名称都不能为空！\n 请重新输入！");

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

        //Update:
        private void btnModify_Click_1(object sender, EventArgs e)
        {
            if (txtProNum.Text == "" || txtDepartName.Text == "" || txtDepartNum.Text == "" || txtProName.Text == "")
            {
                MessageBox.Show("专业号、专业名称、系编号、系名称都不能为空！\n 请重新输入！");

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

        //Del:
        private void btnDel_Click(object sender, EventArgs e)
        {
            if (txtProNum.Text == "" || txtDepartName.Text == "" || txtDepartNum.Text == "" || txtProName.Text == "")
            {
                MessageBox.Show("专业号、专业名称、系编号、系名称都不能为空！\n 请重新输入！");

            }
            else
            {
                ProfessionBLL objProfessionBLL = new ProfessionBLL();
                ProfessionModel objProfessionModel = new ProfessionModel();

                objProfessionModel.ProNum = txtProNum.Text;

                if (objProfessionBLL.DelProfession(objProfessionModel) == true)
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
        

        //Exit:
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
