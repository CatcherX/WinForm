using System;
using System.Windows.Forms;
using BLL;
using Model;

namespace UI
{
    public partial class SchoolInfo : CentralUse
    {
        public SchoolInfo()
        {
            InitializeComponent();
        }

        SchoolModel objSchoolMolel = new SchoolModel();
        SchoolBLL objSchoolBLL = new SchoolBLL();

        private void objModel()
        {
            objSchoolMolel.SchNum = cmbSchNum.Text;
            objSchoolMolel.SchName = cmbSchName.Text;
        }

        private void ShowTable()
        {
            objSchoolMolel.SchNum = cmbSchNum.Text;
            objSchoolMolel.SchName = cmbSchName.Text;

            dataGridView1.DataSource = objSchoolBLL.ShowSchoolInfo();

            GetTableColumnBLL objGetTableColumnBLL=new GetTableColumnBLL();

            string[] SchNum = objGetTableColumnBLL.GetSchNum();
            cmbSchNum.Items.AddRange(SchNum);

            string[] SchName = objGetTableColumnBLL.GetSchName();
            cmbSchName.Items.AddRange(SchName);
        }


        private void SchoolInfo_Load(object sender, EventArgs e)
        {
            ShowTable();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            #region  //单击网格，显示结果在文本框：
            int CurrentRow = dataGridView1.CurrentRow.Index;
            //cmbSemester.Text = dataGridView1[1, CurrentRow].Value.ToString();
            cmbSchNum.Text = dataGridView1[0, CurrentRow].Value.ToString();
            cmbSchName.Text = dataGridView1[1, CurrentRow].Value.ToString();

            #endregion
        }
        
        //add:
        private void btnAdd_Click(object sender, EventArgs e)
        {
                objModel();

            if (cmbSchName.Text == "" || cmbSchNum.Text == "")
            {
                MessageBox.Show("学校编号和名称都不能为空！");
            }
            else
            {
                if (objSchoolBLL.AddSchool(objSchoolMolel) == true)
                    MessageBox.Show("添加成功！");
                else
                    MessageBox.Show("添加失败！");
            }

            ShowTable();
        }


        //update:
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            objSchoolMolel.SchNum = cmbSchNum.Text;
            objSchoolMolel.SchName = cmbSchName.Text;

            if (cmbSchName.Text == "" || cmbSchNum.Text == "")
            {
                MessageBox.Show("学校编号和名称都不能为空！");
            }
            else
            {
                if (objSchoolBLL.UpdateSchool(objSchoolMolel) == true)
                    MessageBox.Show("修改成功！");
                else
                    MessageBox.Show("修改失败！");
            }
            
            ShowTable();
        }
        //del:
        private void btnDel_Click(object sender, EventArgs e)
        {
            objModel();
            if (cmbSchNum.Text == "")
            {
                MessageBox.Show("学校编号不能为空！");
            }
            else
            {
                if (objSchoolBLL.delSchool(objSchoolMolel) == true)
                    MessageBox.Show("删除成功！");
                else
                    MessageBox.Show("删除失败！");
            }

            ShowTable();
        }

        private void cmbSchNum_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbSchName.SelectedIndex = cmbSchNum.SelectedIndex;
        }

        private void cmbSchName_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbSchNum.SelectedIndex = cmbSchName.SelectedIndex;
        }
    }
}
