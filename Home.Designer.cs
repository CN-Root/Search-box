
namespace Search_box
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.Search = new System.Windows.Forms.TextBox();
            this.ChuangTiTouMing = new System.Windows.Forms.Timer(this.components);
            this.SheZhi = new System.Windows.Forms.PictureBox();
            this.FanKui = new System.Windows.Forms.PictureBox();
            this.SouSuo = new System.Windows.Forms.PictureBox();
            this.Search_engine = new System.Windows.Forms.PictureBox();
            this.background = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.SheZhi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FanKui)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SouSuo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Search_engine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.background)).BeginInit();
            this.SuspendLayout();
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(182)))), ((int)(((byte)(182)))));
            this.Search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Search.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Search.Location = new System.Drawing.Point(48, 9);
            this.Search.Multiline = true;
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(503, 30);
            this.Search.TabIndex = 2;
            // 
            // ChuangTiTouMing
            // 
            this.ChuangTiTouMing.Tick += new System.EventHandler(this.ChuangTiTouMing_Tick);
            // 
            // SheZhi
            // 
            this.SheZhi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(182)))), ((int)(((byte)(182)))));
            this.SheZhi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SheZhi.Image = global::Search_box.Properties.Resources.GengDuo;
            this.SheZhi.Location = new System.Drawing.Point(629, 9);
            this.SheZhi.Name = "SheZhi";
            this.SheZhi.Size = new System.Drawing.Size(30, 30);
            this.SheZhi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SheZhi.TabIndex = 5;
            this.SheZhi.TabStop = false;
            this.SheZhi.Click += new System.EventHandler(this.SheZhi_Click);
            // 
            // FanKui
            // 
            this.FanKui.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(182)))), ((int)(((byte)(182)))));
            this.FanKui.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FanKui.Image = global::Search_box.Properties.Resources.FanKui;
            this.FanKui.Location = new System.Drawing.Point(593, 9);
            this.FanKui.Name = "FanKui";
            this.FanKui.Size = new System.Drawing.Size(30, 30);
            this.FanKui.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.FanKui.TabIndex = 4;
            this.FanKui.TabStop = false;
            this.FanKui.Click += new System.EventHandler(this.FanKui_Click);
            // 
            // SouSuo
            // 
            this.SouSuo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(182)))), ((int)(((byte)(182)))));
            this.SouSuo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SouSuo.Image = global::Search_box.Properties.Resources.favicon;
            this.SouSuo.Location = new System.Drawing.Point(557, 9);
            this.SouSuo.Name = "SouSuo";
            this.SouSuo.Size = new System.Drawing.Size(30, 30);
            this.SouSuo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SouSuo.TabIndex = 3;
            this.SouSuo.TabStop = false;
            this.SouSuo.Click += new System.EventHandler(this.SouSuo_Click);
            // 
            // Search_engine
            // 
            this.Search_engine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(182)))), ((int)(((byte)(182)))));
            this.Search_engine.Image = global::Search_box.Properties.Resources.BaiDu;
            this.Search_engine.Location = new System.Drawing.Point(12, 9);
            this.Search_engine.Name = "Search_engine";
            this.Search_engine.Size = new System.Drawing.Size(30, 30);
            this.Search_engine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Search_engine.TabIndex = 1;
            this.Search_engine.TabStop = false;
            // 
            // background
            // 
            this.background.BackColor = System.Drawing.Color.Transparent;
            this.background.BackgroundImage = global::Search_box.Properties.Resources.background;
            this.background.Location = new System.Drawing.Point(0, 0);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(656, 48);
            this.background.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.background.TabIndex = 0;
            this.background.TabStop = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 48);
            this.Controls.Add(this.SheZhi);
            this.Controls.Add(this.FanKui);
            this.Controls.Add(this.SouSuo);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Search_engine);
            this.Controls.Add(this.background);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Home";
            this.Opacity = 0.8D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.ResizeBegin += new System.EventHandler(this.Home_ResizeBegin);
            this.ResizeEnd += new System.EventHandler(this.Home_ResizeEnd);
            this.Move += new System.EventHandler(this.Home_Move);
            this.Resize += new System.EventHandler(this.Home_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.SheZhi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FanKui)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SouSuo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Search_engine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.background)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox background;
        private System.Windows.Forms.PictureBox Search_engine;
        private System.Windows.Forms.TextBox Search;
        private System.Windows.Forms.PictureBox SouSuo;
        private System.Windows.Forms.PictureBox FanKui;
        private System.Windows.Forms.PictureBox SheZhi;
        private System.Windows.Forms.Timer ChuangTiTouMing;
    }
}