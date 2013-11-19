using System;
using System.Windows.Forms;
using BLL;
using Model;

namespace UI
{
    public partial class DepartmentInfo:CentralUse
    {
        public DepartmentInfo()
        {
            InitializeComponent();
        }

        DepartmentModel objDepartmentModel = new DepartmentModel();
        DepartmentBLL objDepartmentBLL = new DepartmentBLL();
        

        //刷新网格：
        private void RefreshTable()
        {
            SelCourseBLL objSelCourseBLL = new SelCourseBLL();
            dataGridView1.DataSource = objSelCourseBLL.ShowDepartment();
        }

        //Show DataGridViewInfo To Text:
        private void dataGridView1_Click(object sender, EventArgs e)
        {
            int CurrentRow = dataGridView1.CurrentRow.Index;
            cmbDeptNum.Text = dataGridView1[0, CurrentRow].Value.ToString();
            cmbDeptName.Text = dataGridView1[1, CurrentRow].Value.ToString();
            cmbSchNum.Text = dataGridView1[2, CurrentRow].Value.ToString();
            
            
        }


        private void Form1_Load(object sender, EventArgs e)
        {
                RefreshTable();
        }
        
        //Add
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cmbDeptName.Text == "" || cmbDeptNum.Text== "" || cmbSchNum.Text=="")
            {
                MessageBox.Show("学校编号,系名称、系编号、学校编号都不能为空.\n");
            }
            else
            {
                objDepartmentModel.DeptName = cmbDeptName.Text;
                objDepartmentModel.DeptNum = cmbDeptNum.Text;
                objDepartmentModel.SchNum = cmbSchNum.Text;

                if (objDepartmentBLL.AddDeptment(objDepartmentModel) == true) 
                {
                    MessageBox.Show("成功执行！");
                }
                    else
                {
                    MessageBox.Show("执行失败！");
                }



            }



            RefreshTable();
           
        }

        //Update:
        private void btnModify_Click_1(object sender, EventArgs e)
        {
            if (cmbDeptName.Text == "" || cmbDeptNum.Text == "" || cmbSchNum.Text == "")
            {
                MessageBox.Show("学校编号,系名称、系编号、学校编号都不能为空.\n");
            }
            else
            {
                objDepartmentModel.DeptName = cmbDeptName.Text;
                objDepartmentModel.DeptNum = cmbDeptNum.Text;
                objDepartmentModel.SchNum = cmbSchNum.Text;

                if(objDepartmentBLL.UpdateDeptment(objDepartmentModel)==true)
                 {
                    MessageBox.Show("成功执行！");
                }
                    else
                {
                    MessageBox.Show("执行失败！");
                }
            }
            RefreshTable();
           
        }

        //Delete:
        private void btnDel_Click(object sender, EventArgs e)
        {
            if (cmbDeptName.Text == "" || cmbDeptNum.Text == "" || cmbSchNum.Text == "")
            {
                MessageBox.Show("学校编号,系名称、系编号、学校编号都不能为空.\n");
            }
            else
            {
                objDepartmentModel.DeptName = cmbDeptName.Text;
                objDepartmentModel.DeptNum = cmbDeptNum.Text;
                objDepartmentModel.SchNum = cmbSchNum.Text;

                if(objDepartmentBLL.DelDeptment(objDepartmentModel)==true)
                {
                    MessageBox.Show("成功执行！");
                }
                    else
                {
                    MessageBox.Show("执行失败！");
                }
            }

            RefreshTable();
        }

        //Search:
        private void btnSearch_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = 0;
            
            if (cmbDeptName.Text == "" || cmbDeptNum.Text == "" || cmbSchNum.Text == "")
            {
                MessageBox.Show("学校编号,系名称、系编号、学校编号都不能为空.\n");
            }
            else
            {
                objDepartmentModel.DeptName = cmbDeptName.Text;
                objDepartmentModel.DeptNum = cmbDeptNum.Text;
                objDepartmentModel.SchNum = cmbSchNum.Text;
            }

            dataGridView1.DataSource=objDepartmentBLL.SearchDeptment(objDepartmentModel);
            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            RefreshTable();

        }

        
  
    }
}
