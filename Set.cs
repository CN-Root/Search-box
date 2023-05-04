using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Search_box
{
    public partial class Set : Form
    {
        public Set()
        {
            InitializeComponent();
        }

        #region 加载主页
        private void Set_Load(object sender, EventArgs e)
        {

        }
        #endregion

        #region 关闭
        private void GuanBi_Click(object sender, EventArgs e)
        {
            this.Hide();//隐藏窗体
        }
        #endregion
    }
}