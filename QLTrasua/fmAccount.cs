using QLTrasua.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTrasua
{
    public partial class fmAccount : Form
    {

        BindingSource accountList = new BindingSource();
        public fmAccount()
        {
            InitializeComponent();
            dtgvAccount.DataSource = accountList;
            
        }

        void Load()
        {
           
            LoadAccount();
        }

      
        void LoadAccount()
        {
            accountList.DataSource = AccountDAO.Instance.GetListAccount();
        }

        private void USP_RecipeBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void bt_ViewNhanvien_Click(object sender, EventArgs e)
        {
            LoadAccount();
        }

        private void dtgvAccount_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
