
namespace Search_box
{
    partial class Set
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Set));
            this.Title_Search_Box = new System.Windows.Forms.Label();
            this.GuanBi = new System.Windows.Forms.PictureBox();
            this.title_panel = new System.Windows.Forms.Panel();
            this.Left_side_column = new System.Windows.Forms.Panel();
            this.panel = new System.Windows.Forms.Panel();
            this.System_Set = new System.Windows.Forms.Button();
            this.Search_engine = new System.Windows.Forms.Button();
            this.Praise_us = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GuanBi)).BeginInit();
            this.title_panel.SuspendLayout();
            this.Left_side_column.SuspendLayout();
            this.SuspendLayout();
            // 
            // Title_Search_Box
            // 
            this.Title_Search_Box.AutoSize = true;
            this.Title_Search_Box.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Title_Search_Box.Location = new System.Drawing.Point(5, 5);
            this.Title_Search_Box.Name = "Title_Search_Box";
            this.Title_Search_Box.Size = new System.Drawing.Size(125, 20);
            this.Title_Search_Box.TabIndex = 1;
            this.Title_Search_Box.Text = "设置 - Search Box";
            // 
            // GuanBi
            // 
            this.GuanBi.BackColor = System.Drawing.Color.Transparent;
            this.GuanBi.Image = global::Search_box.Properties.Resources.GuanBi;
            this.GuanBi.Location = new System.Drawing.Point(570, 0);
            this.GuanBi.Name = "GuanBi";
            this.GuanBi.Size = new System.Drawing.Size(30, 30);
            this.GuanBi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.GuanBi.TabIndex = 4;
            this.GuanBi.TabStop = false;
            this.GuanBi.Click += new System.EventHandler(this.GuanBi_Click);
            // 
            // title_panel
            // 
            this.title_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.title_panel.Controls.Add(this.GuanBi);
            this.title_panel.Controls.Add(this.Title_Search_Box);
            this.title_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.title_panel.Location = new System.Drawing.Point(0, 0);
            this.title_panel.Name = "title_panel";
            this.title_panel.Size = new System.Drawing.Size(600, 30);
            this.title_panel.TabIndex = 5;
            // 
            // Left_side_column
            // 
            this.Left_side_column.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Left_side_column.Controls.Add(this.Praise_us);
            this.Left_side_column.Controls.Add(this.Search_engine);
            this.Left_side_column.Controls.Add(this.System_Set);
            this.Left_side_column.Dock = System.Windows.Forms.DockStyle.Left;
            this.Left_side_column.Location = new System.Drawing.Point(0, 30);
            this.Left_side_column.Name = "Left_side_column";
            this.Left_side_column.Size = new System.Drawing.Size(130, 320);
            this.Left_side_column.TabIndex = 6;
            // 
            // panel
            // 
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(130, 30);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(470, 320);
            this.panel.TabIndex = 7;
            // 
            // System_Set
            // 
            this.System_Set.Dock = System.Windows.Forms.DockStyle.Top;
            this.System_Set.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.System_Set.Location = new System.Drawing.Point(0, 0);
            this.System_Set.Name = "System_Set";
            this.System_Set.Size = new System.Drawing.Size(128, 32);
            this.System_Set.TabIndex = 0;
            this.System_Set.Text = "系统设置";
            this.System_Set.UseVisualStyleBackColor = true;
            // 
            // Search_engine
            // 
            this.Search_engine.Dock = System.Windows.Forms.DockStyle.Top;
            this.Search_engine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Search_engine.Location = new System.Drawing.Point(0, 32);
            this.Search_engine.Name = "Search_engine";
            this.Search_engine.Size = new System.Drawing.Size(128, 32);
            this.Search_engine.TabIndex = 1;
            this.Search_engine.Text = "搜索引擎";
            this.Search_engine.UseVisualStyleBackColor = true;
            // 
            // Praise_us
            // 
            this.Praise_us.Dock = System.Windows.Forms.DockStyle.Top;
            this.Praise_us.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Praise_us.Location = new System.Drawing.Point(0, 64);
            this.Praise_us.Name = "Praise_us";
            this.Praise_us.Size = new System.Drawing.Size(128, 32);
            this.Praise_us.TabIndex = 2;
            this.Praise_us.Text = "赞赏我们";
            this.Praise_us.UseVisualStyleBackColor = true;
            // 
            // Set
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 350);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.Left_side_column);
            this.Controls.Add(this.title_panel);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Set";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "设置 - Search Box";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Set_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GuanBi)).EndInit();
            this.title_panel.ResumeLayout(false);
            this.title_panel.PerformLayout();
            this.Left_side_column.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label Title_Search_Box;
        private System.Windows.Forms.PictureBox GuanBi;
        private System.Windows.Forms.Panel title_panel;
        private System.Windows.Forms.Panel Left_side_column;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button System_Set;
        private System.Windows.Forms.Button Search_engine;
        private System.Windows.Forms.Button Praise_us;
    }
}