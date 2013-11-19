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
using SimStuManageSysModel;
using SimStuManageSysBLL;


namespace SimStuManageSys
{
    public partial class StudentInfo : CentralUse
    {
        public StudentInfo()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StudentBLL objStudentBLL = new StudentBLL();
            dataGridView1.DataSource = objStudentBLL.ShowStuInfo();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            StudentBLL objstudentBLLClass = new StudentBLL();
            string StuNum = dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString();
            if (objstudentBLLClass.DeleteStudent(StuNum) == true)
            { MessageBox.Show("数据删除成功"); }
            else
            { MessageBox.Show("数据删除失败"); }
            dataGridView1.DataSource = objstudentBLLClass.ShowStuInfo();
        }



        private void btnAdd_Click(object sender, EventArgs e)
        {
            StudentBLL objstudentBBLClass = new StudentBLL();
            StudentModel objStudentModel = new StudentModel();
            objStudentModel.StuNum = txtStuNum.Text;
            objStudentModel.StuName = txtStuName.Text;
            objStudentModel.StuSex = cbxStuSex.Text;
            objStudentModel.Address = txtAddress.Text;
            objStudentModel.ClaNum = txtClaNum.Text;
            if (objstudentBBLClass.Insertstudent(objStudentModel) == true)
                MessageBox.Show("数据添加成功");
            else
                MessageBox.Show("数据添加失败");
            dataGridView1.DataSource = objstudentBBLClass.ShowStuInfo();

        }

       
        private void btnModify_Click_1(object sender, EventArgs e)
        {
            StudentBLL objstudentBBLClass = new StudentBLL();
            StudentModel objStudentModel = new StudentModel();
            objStudentModel.StuNum = dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString();
            objStudentModel.StuName = txtStuName.Text;
            objStudentModel.StuSex = cbxStuSex.Text;
            objStudentModel.Address = txtAddress.Text;
            if (objstudentBBLClass.UpdateStudent(objStudentModel) == true)
            { MessageBox.Show("数据修改成功"); }
            else
            { MessageBox.Show("数据修改失败"); }
            dataGridView1.DataSource = objstudentBBLClass.ShowStuInfo();
        }

       

        private void btnClear_Click(object sender, EventArgs e)
        {
            StudentModel objStudentModel = new StudentModel();
            objStudentModel.StuNum = txtStuNum.Text;
            objStudentModel.StuName = txtStuName.Text;
            objStudentModel.StuSex = cbxStuSex.Text;
            objStudentModel.Birthday = dtBirthday.Value.ToString("yyy-mm-dd");
            objStudentModel.Address = txtAddress.Text;
            string OutString = "姓名:" + objStudentModel.StuName + "\n";
            OutString += "学号：" + objStudentModel.StuNum + "\n";
            OutString += "性别:" + objStudentModel.StuSex + "\n";
            OutString += "出生日期：" + objStudentModel.Birthday + "\n";
            OutString += "地址:" + objStudentModel.Address + "\n";
            MessageBox.Show(OutString, "学生信息");

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int CurrentRow = dataGridView1.CurrentRow.Index;
            txtStuNum.Text = dataGridView1[0, CurrentRow].Value.ToString();
            txtStuName.Text = dataGridView1[1, CurrentRow].Value.ToString();
            cbxStuSex.Text = dataGridView1[2, CurrentRow].Value.ToString();
            txtPolicity.Text = dataGridView1[3, CurrentRow].Value.ToString();
            txtFavor.Text = dataGridView1[5, CurrentRow].Value.ToString();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }


    }
}
