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
    public partial class TeacherInfo :CentralUse
    {  public TeacherInfo()
        {
            InitializeComponent();
        }

        private void ShowTable()
        {
            TeacherBLL objTeacherBLL = new TeacherBLL();
            dgvTeacherInfo.DataSource = objTeacherBLL.ShowTeacher();
        }


        private void TeacherInfo_Load(object sender, EventArgs e)
        {
            ShowTable();
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            #region sql语句进行添加，已注释
            //TeacherBLL objTeacherBLL = new TeacherBLL();
            //TeacherModel Teacher = new TeacherModel();
            //Teacher.TeaNum = txtNum.Text  ;
            //Teacher.TeaName = txtName.Text;
            //Teacher.TeaSex = cmbSex.Text;
            //Teacher.TeaAdress = txtAdress.Text;
            //Teacher.TeaPhone = txtPhone.Text;
            //Teacher.TeaTitle = txtTitle.Text;

            //if(objTeacherBLL.AddTeacher(Teacher)==true)
            //    MessageBox.Show("数据添加成功");
            //else
            //    MessageBox.Show("数据添加失败");
            //dgvTeacherInfo.DataSource = objTeacherBLL.ShowTeacher(); 
            #endregion

            #region  //存储过程 已注释
            ////SqlConnection objConn = new SqlConnection("Data Source=.\\SQLExpress;Initial Catalog=StuManageSystem_2008;Integrated Security=True");
            ////objConn.Open();
            ////SqlCommand objSqlCommand = new SqlCommand();
            //objSqlCommand.Connection = objConn;
            //objSqlCommand.CommandType = CommandType.StoredProcedure;
            //objSqlCommand.CommandText = "Teachers";
            //objSqlCommand.Parameters.Add("@TeaName", SqlDbType.NChar, 10);
            //objSqlCommand.Parameters["@TeaName"].Value = txtName.Text;
            //objSqlCommand.Parameters.Add("@Sex", SqlDbType.NChar, 10);
            //objSqlCommand.Parameters["@TeaSex"].Value = txtSex.Text;
            //objSqlCommand.Parameters.Add("@TeaAdress", SqlDbType.NChar, 10);
            //objSqlCommand.Parameters["@TeaAdress"].Value = txtAdress.Text;
            //objSqlCommand.Parameters.Add("@TeaPhone", SqlDbType.NChar, 10);
            //objSqlCommand.Parameters["@TeaPhone"].Value = txtPhone.Text;
            //objSqlCommand.Parameters.Add("@TeaTitle", SqlDbType.NChar, 10);
            //objSqlCommand.Parameters["@TeaTitle"].Value = txtTitle.Text;
            //if (objSqlCommand.EndExecuteNonQuery() > 0)
            //    MessageBox.Show("添加成功");
            //else MessageBox.Show("添加失败");
            //objConn.Close();



            //调用类的后半段
            //string SqlString = "select*from dbo.Teacher";

            // dgvTeacherInfo.DataSource = objDataBase.GetDataSet(SqlString).Tables[0];




            //SqlCommand objSqlCommand = new SqlCommand();
            //objSqlCommand.CommandType = CommandType.StoredProcedure;
            //objSqlCommand.CommandText = "studentInsert";

            //objSqlCommand.Parameters.AddWithValue("@TeaNum", txtNum.Text);
            //objSqlCommand.Parameters.AddWithValue("@TeaName", txtName.Text);
            //objSqlCommand.Parameters.AddWithValue("@TeaSex", cmbSex.Text);
            //objSqlCommand.Parameters.AddWithValue("@TeaAdress ", txtAdress.Text);
            //objSqlCommand.Parameters.AddWithValue("@TeaPhone", txtPhone.Text);
            //objSqlCommand.Parameters.AddWithValue("@TeaTitle", txtTitle.Text);

            //SQLClass1 objdatabase = new SQLClass1();

            //if (objdatabase.GetExecute1(objSqlCommand))
            //    MessageBox.Show("添加成功");
            //else
            //    MessageBox.Show("添加失败");

            //showDGV();
            
            #endregion

            if (txtTeaNum.Text=="" || txtTeaName.Text == "")
            {
                MessageBox.Show("工号和姓名都不能为空！\n 请重新输入！");

            }
            else
            {
                
                TeacherBLL objTeacherBLL = new TeacherBLL();
                TeacherModel objTeacherModel = new TeacherModel();

                objTeacherModel.TeaAdress = txtTeaAddress.Text;
                objTeacherModel.TeaName = txtTeaName.Text;
                objTeacherModel.TeaNum = txtTeaNum.Text;
                objTeacherModel.TeaPhone = txtTeaPhone.Text;
                objTeacherModel.TeaTitle = txtTeaTitle.Text;
                objTeacherModel.TeaSex = cbxTeaSex.Text;
                objTeacherModel.TeaTitle = txtTeaTitle.Text;

                if (objTeacherBLL.AddTeacher(objTeacherModel) == true) 
                {
                    MessageBox.Show("增加成功！");
                }
                else
                    MessageBox.Show("增加失败！");
            }



        }


        private void btnModify_Click(object sender, EventArgs e)
        {
            

            if (txtTeaNum.Text == "" || txtTeaName.Text == "")
            {
                MessageBox.Show("工号和姓名都不能为空！\n 请重新输入！");

            }
            else
            {

                TeacherBLL objTeacherBLL = new TeacherBLL();
                TeacherModel objTeacherModel = new TeacherModel();

                objTeacherModel.TeaAdress = txtTeaAddress.Text;
                objTeacherModel.TeaName = txtTeaName.Text;
                objTeacherModel.TeaNum = txtTeaNum.Text;
                objTeacherModel.TeaPhone = txtTeaPhone.Text;
                objTeacherModel.TeaTitle = txtTeaTitle.Text;
                objTeacherModel.TeaSex = cbxTeaSex.Text;
                objTeacherModel.TeaTitle = txtTeaTitle.Text;

                if (objTeacherBLL.ChangeTeacher(objTeacherModel)==true)
                {
                    MessageBox.Show("增加成功！");
                }
                else
                    MessageBox.Show("增加失败！");
            }

            ShowTable();

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
                TeacherBLL objTeacherBLL = new TeacherBLL();

                TeacherModel objTeacherModel = new TeacherModel();

                objTeacherModel.TeaNum = txtTeaNum.Text;

                if (objTeacherBLL.DeleteTeacher(objTeacherModel)==true)

                { MessageBox.Show("数据删除成功"); }
                else
                { MessageBox.Show("数据删除失败"); }
            
                ShowTable();
        }

      
        private void dgvTeacherInfo_Click(object sender, EventArgs e)
        {
               int CurrentRow = dgvTeacherInfo.CurrentRow.Index;
            txtTeaNum.Text = dgvTeacherInfo[0, CurrentRow].Value.ToString();
            txtTeaName.Text = dgvTeacherInfo[1, CurrentRow].Value.ToString();
            cbxTeaSex.Text = dgvTeacherInfo[2, CurrentRow].Value.ToString();
            txtTeaPhone.Text = dgvTeacherInfo[3, CurrentRow].Value.ToString();
            txtTeaAddress.Text = dgvTeacherInfo[4, CurrentRow].Value.ToString();
            txtTeaTitle.Text = dgvTeacherInfo[5, CurrentRow].Value.ToString();
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            ShowTable();
        }

        
    







    }
}
