using System;
using System.Windows.Forms;
using BLL;
using Model;

namespace UI
{
    public partial class StudentInfo : CentralUse
    {
        public StudentInfo()
        {
            InitializeComponent();
        }

        #region 获取数据库中的学生表的列字段：
            StudentBLL objStudentBLL = new StudentBLL();
            GetTableColumnBLL objGetTableColumnBLL = new GetTableColumnBLL();
            StudentModel objStudentModel = new StudentModel();


            private void GetStuNum()
            {
                GetTableColumnBLL objGetTableColumnBLL = new GetTableColumnBLL();
                string[] StuNum = objGetTableColumnBLL.GetStuNum();
                cmbStuSearchValue.Items.AddRange(StuNum);
            }
            private void GetClaName()
            {
                SelCourseBLL objSelCourseBLL = new SelCourseBLL();
                string[] ClaName = objSelCourseBLL.GetClaName();
                cmbStuSearchValue.Items.AddRange(ClaName);
            }

            private void GetStuName()
            {
                string[] StuName = objGetTableColumnBLL.GetStuName();
                cmbStuSearchValue.Items.AddRange(StuName);
            }
        
        #endregion

        
        private void Form1_Load(object sender, EventArgs e)
        {
            cmbStuSearchMethod.Text = "请选择搜索条件";
            cmbStuSearchValue.Text = "请先选择搜索条件：";

            cmbStuSearchMethod.Items.Add("学号");
            cmbStuSearchMethod.Items.Add("姓名");
            cmbStuSearchMethod.Items.Add("班级");


            dataGridView1.DataSource = objStudentBLL.ShowStuInfo();
        }

        private void ShowStudentInfo()
        {
            dataGridView1.DataSource = objStudentBLL.ShowStuInfo();
        }
       
        //Add:
        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (txtStuNum.Text == "")
            {
                MessageBox.Show("学号不能为空！","温馨提醒",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                #region 把文本框内容赋值给Model的属性
                string Birthday = Convert.ToString(Convert.ToDateTime(dtBirthday.Text));

                objStudentModel.StuNum = txtStuNum.Text;
                objStudentModel.StuName = txtStuName.Text;
                objStudentModel.StuSex = cbxStuSex.Text;
                objStudentModel.Birthday = Birthday;        //把DateTime 类型转为String类型：
                objStudentModel.ClaNum = txtClaNum.Text;
                objStudentModel.Meno = txtMono.Text;
                objStudentModel.Policity = txtPolicity.Text;
                objStudentModel.Address = txtAddress.Text;
                objStudentModel.Favor = txtFavor.Text;
                objStudentModel.Phone = txtPhone.Text;

                if (objStudentBLL.InsertStudent(objStudentModel) == true)
                    MessageBox.Show("添加成功");
                else
                    MessageBox.Show("添加失败");
                #endregion
            }
            //dataGridView1.DataSource = objStudentBLL.ShowStuInfo();

        }

       //Update:
        private void btnModify_Click_1(object sender, EventArgs e)
        {
                string Birthday = Convert.ToString(Convert.ToDateTime(dtBirthday.Text));

                objStudentModel.StuNum = txtStuNum.Text;
                objStudentModel.StuName = txtStuName.Text;
                objStudentModel.StuSex = cbxStuSex.Text;
                objStudentModel.Birthday = Birthday;        //把DateTime 类型转为String类型：
                objStudentModel.ClaNum = txtClaNum.Text;
                objStudentModel.Meno = txtMono.Text;
                objStudentModel.Policity = txtPolicity.Text;
                objStudentModel.StuScore = txtStuScore.Text;
                objStudentModel.Address = txtAddress.Text;
                objStudentModel.Favor = txtFavor.Text;
                objStudentModel.Phone = txtPhone.Text;

            if (objStudentBLL.UpdateStudent(objStudentModel) == true)
                { MessageBox.Show("修改成功"); }
            else
                { MessageBox.Show("修改失败"); }

            //ShowStudentInfo();
            dataGridView1.DataSource = objStudentBLL.SearchStuInfo(objStudentModel);
        }


        //Del:
        private void btnDel_Click(object sender, EventArgs e)
        {
            
            string StuNum = dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString();
            if (objStudentBLL.DeleteStudent(StuNum) == true)
            { MessageBox.Show("删除成功"); }
            else
            { MessageBox.Show("删除失败"); }

            ShowStudentInfo();
        }

        
        
        //Search:
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (cmbStuSearchMethod.Text == "")
            MessageBox.Show("请先选择搜索条件：");

            objStudentModel.StuNum = cmbStuSearchValue.Text;
            objStudentModel.StuName = cmbStuSearchValue.Text;

            dataGridView1.DataSource = 0;

            
            
            objStudentModel.ClaName = cmbStuSearchValue.Text;
            dataGridView1.DataSource = objStudentBLL.SearchStuInfo(objStudentModel);

            


            Clear();//进行搜索后，清空编辑框内容；
        }

        
        private void btnClear_Click(object sender, EventArgs e)
        {
            #region 把编辑框的内容内容转成一个消息框弹出：
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
            #endregion
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            #region 单击表格，显示内容在控件上：
                int CurrentRow = dataGridView1.CurrentRow.Index;
                txtStuNum.Text = dataGridView1[0, CurrentRow].Value.ToString();
                txtStuName.Text = dataGridView1[1, CurrentRow].Value.ToString();
                cbxStuSex.Text = dataGridView1[2, CurrentRow].Value.ToString();
                txtPolicity.Text = dataGridView1[4, CurrentRow].Value.ToString();
                dtBirthday.Text = dataGridView1[3, CurrentRow].Value.ToString();
                txtClaNum.Text = dataGridView1[6, CurrentRow].Value.ToString();
                txtFavor.Text = dataGridView1[8, CurrentRow].Value.ToString();
                txtStuScore.Text = dataGridView1[9, CurrentRow].Value.ToString();
                txtMono.Text = dataGridView1[10, CurrentRow].Value.ToString();
           //txtClaNum.Text = dataGridView1[8, CurrentRow].Value.ToString();
                txtPhone.Text = dataGridView1[11, CurrentRow].Value.ToString();
                txtAddress.Text = dataGridView1[12, CurrentRow].Value.ToString(); 
            #endregion
        }

        //清空信息编辑框内容：
        private void Clear()
        {
            foreach (Control ct in this.groupBox1.Controls)     //获取所有控件，这里是在GroupBox1容器内的。
            {
                if (ct is TextBox)                                  //当ct是TextBox控件时
                {
                    (ct as TextBox).Text = "";                      //把ct的text值变为空字符串；
                }
            }

            dtBirthday.Text = DateTime.Now.ToString();
        }

        private void btnClear1_Click(object sender, EventArgs e)
        {
            Clear();
        }
        //单击搜索关键词文本框时，清空提示语言，但若是关键词时，则不清空：
        private void cmbStuSearchValue_Click(object sender, EventArgs e)
        {
            if (cmbStuSearchValue.Text == "请先选择搜索条件：" || cmbStuSearchValue.Text == "在这里输入你想要搜索的学号：" || cmbStuSearchValue.Text == "在这里输入你想要搜索的班级名称：" || cmbStuSearchValue.Text == "请先在左边选择搜索条件：") 
         { cmbStuSearchValue.Text = ""; }
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbStuSearchMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbStuSearchMethod.Text == "学号")
            {
                cmbStuSearchValue.Items.Clear();        //先清空原有数据项（班级名称）
                cmbStuSearchValue.Text = "在这里输入你想要搜索的学号：";
                GetStuNum();
                objStudentModel.StuNum = cmbStuSearchValue.Text;
            }

            if (cmbStuSearchMethod.Text == "姓名")
            {
                cmbStuSearchValue.Items.Clear();
                cmbStuSearchValue.Text = "请在这里输入姓名！";
                GetStuName();
                objStudentModel.StuName = cmbStuSearchValue.Text;
            }
            
            if (cmbStuSearchMethod.Text == "班级")
            {
                cmbStuSearchValue.Items.Clear();        //先清空原有数据项（学号）
                cmbStuSearchValue.Text = "在这里输入你想要搜索的班级名称：";
                GetClaName();
                objStudentModel.ClaName = cmbStuSearchValue.Text;
            }


            
            else
            {

            }

        }

        private void txtPhone_MouseLeave(object sender, EventArgs e)
        {
            bool reg1 = System.Text.RegularExpressions.Regex.IsMatch(txtPhone.Text, @"^(\d{3,4}-)?\d{6,8}$");
            if (!reg1)
            errorPhone.SetError(txtPhone, "电话号码格式不正确，请更正！");

        }

        private void txtPhone_MouseEnter(object sender, EventArgs e)
        {
            errorPhone.Clear();
        }
    }
}
