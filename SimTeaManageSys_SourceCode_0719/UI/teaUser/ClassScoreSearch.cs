using System;
using BLL;
using Model;

namespace UI
{
    public partial class ClassScoreSearch : CentralUse
    {
        public ClassScoreSearch()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ClassModel objClassModel = new ClassModel();
            ScoreSearchBLL objScoreSearchBLL = new ScoreSearchBLL();

            objClassModel.ClaName = cmbClassName.Text;
            objClassModel.StuNum = cmbStuNum.Text;
            
            dataGridView1.DataSource = objScoreSearchBLL.ScoreSearch(objClassModel);
        }

        private void ClassScoreSearch_Load(object sender, EventArgs e)
        {
            #region 添加字段名到comboBox控件中：
            GetTableColumnBLL objGetTableColumnBLL = new GetTableColumnBLL();

            string[] ClassName = objGetTableColumnBLL.GetClaName();
            cmbClassName.Items.AddRange(ClassName);

            string[] GetStuNum = objGetTableColumnBLL.GetClaNum();
            cmbStuNum.Items.AddRange(GetStuNum);

            #endregion
        }

        
        private void dataGridView1_Click(object sender, EventArgs e)
        {
            int CurrentRow = dataGridView1.CurrentRow.Index;
            cmbClassName.Text = dataGridView1[0, CurrentRow].Value.ToString();
            //cmbStuNum.Text = dataGridView1[1, CurrentRow].Value.ToString();
        }

        private void cmbClassName_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbStuNum.Text = "";

        }

        private void cmbStuNum_Click(object sender, EventArgs e)
        {
            cmbClassName.Text = "";
        }
    }
}
