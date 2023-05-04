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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        #region 背景透明
        private Color tr_color = Color.Transparent;
        private bool b_start = false;
        bool[] b_visible = null;

        private void SetBackgroundImageTransparent()
        {
            Point pt = this.PointToScreen(new Point(0, 0));
            Bitmap b = new Bitmap(this.Width, this.Height);
            using (Graphics g = Graphics.FromImage(b))
            {
                g.CopyFromScreen(pt, new Point(), new Size(this.Width, this.Height));
            }

            this.BackgroundImage = b;
        }
        private void BeginSet()
        {
            tr_color = this.TransparencyKey;
            b_start = true;
        }
        private void Setting()
        {
            if (b_start)
            {
                b_visible = new bool[Controls.Count];
                for (int i = 0; i < Controls.Count; i++)
                {
                    b_visible[i] = Controls[i].Visible;
                    Controls[i].Visible = false;
                }
                BackgroundImage = null;
                BackColor = Color.White;
                b_start = false;
                this.TransparencyKey = Color.White;
            }
        }
        private void EndSet()
        {
            SetBackgroundImageTransparent();
            this.TransparencyKey = tr_color;
            for (int i = 0; i < Controls.Count; i++)
            {
                Controls[i].Visible = b_visible[i];
            }
            b_start = false;
        }

        private void Home_Resize(object sender, EventArgs e)
        {
            Setting();
        }

        private void Home_ResizeBegin(object sender, EventArgs e)
        {
            Setting();
        }

        private void Home_ResizeEnd(object sender, EventArgs e)
        {
            Setting();
        }

        private void Home_Move(object sender, EventArgs e)
        {
            Setting();
        }
        #endregion

        #region 不让窗体显示在Alt+Tab
        protected override CreateParams CreateParams
        {
            get
            {
                const int WS_EX_APPWINDOW = 0x40000;
                const int WS_EX_TOOLWINDOW = 0x80;
                CreateParams cp = base.CreateParams;
                cp.ExStyle &= (~WS_EX_APPWINDOW);    // 不显示在TaskBar
                cp.ExStyle |= WS_EX_TOOLWINDOW;      // 不显示在Alt+Tab
                return cp;
            }
        }
        #endregion

        #region 加载主页
        private void Home_Load(object sender, EventArgs e)
        {
            SetBackgroundImageTransparent();//背景透明
            ChuangTiTouMing.Enabled = true;//运行窗体透明插件

            this.Opacity = 100;//设置窗体透明度

            this.TopMost = true;//设置窗体显示在最上层

            background.Dock = DockStyle.Fill;//background在父窗体中停靠
        }
        #endregion

        private void SouSuo_Click(object sender, EventArgs e)
        {

        }

        private void FanKui_Click(object sender, EventArgs e)
        {

        }

        #region 设置
        private void SheZhi_Click(object sender, EventArgs e)
        {
            Set jump1 = new Set();
            jump1.ShowDialog();
            //this.Dispose();
        }
        #endregion

        #region 窗体透明插件
        private void ChuangTiTouMing_Tick(object sender, EventArgs e)
        {
            SetBackgroundImageTransparent();//背景透明
        }
        #endregion
    }
}