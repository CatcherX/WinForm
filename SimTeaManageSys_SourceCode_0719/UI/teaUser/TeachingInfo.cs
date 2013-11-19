using System;
using System.Windows.Forms;
using BLL;
using Model;

namespace UI
{
    public partial class TeachingInfo : CentralUse
    {
        public TeachingInfo()
        {
            InitializeComponent();
        }

        TeachingModel objTeachingModel = new TeachingModel();
        TeachingBLL objTeachingBLL = new TeachingBLL();

        private void TeachingInfo_Load(object sender, EventArgs e)
        {
            objTeachingModel.Semester = cmbSemester.Text;
            dataGridView1.DataSource = objTeachingBLL.ShowTeachingInfo();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            #region  //单击网格，显示结果在文本框：
            int CurrentRow = dataGridView1.CurrentRow.Index;
            cmbSemester.Text = dataGridView1[1, CurrentRow].Value.ToString();
            #endregion
        }
    }
}
