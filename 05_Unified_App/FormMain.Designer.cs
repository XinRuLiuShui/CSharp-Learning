namespace _05_Unified_App
{
    partial class FormMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.panelTop = new System.Windows.Forms.Panel();
            this.buttonExit = new System.Windows.Forms.Button();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.panelRight = new System.Windows.Forms.Panel();
            this.buttonChangePassword = new System.Windows.Forms.Button();
            this.buttonSearchPainters = new System.Windows.Forms.Button();
            this.buttonSearchPaintings = new System.Windows.Forms.Button();
            this.buttonAddPainting = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelTop.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(220)))), ((int)(((byte)(57)))));
            this.panelTop.Controls.Add(this.buttonExit);
            this.panelTop.Controls.Add(this.labelTitle);
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1373, 71);
            this.panelTop.TabIndex = 0;
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(220)))), ((int)(((byte)(57)))));
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(195)))));
            this.buttonExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(195)))));
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonExit.Location = new System.Drawing.Point(1301, 12);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(53, 38);
            this.buttonExit.TabIndex = 1;
            this.buttonExit.Text = "×";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.button5_Click);
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(238)))), ((int)(((byte)(156)))));
            this.panelLeft.Controls.Add(this.buttonChangePassword);
            this.panelLeft.Controls.Add(this.buttonSearchPainters);
            this.panelLeft.Controls.Add(this.buttonSearchPaintings);
            this.panelLeft.Controls.Add(this.buttonAddPainting);
            this.panelLeft.Controls.Add(this.monthCalendar1);
            this.panelLeft.Location = new System.Drawing.Point(3, 77);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(235, 679);
            this.panelLeft.TabIndex = 1;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(6, 9);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(238)))), ((int)(((byte)(156)))));
            this.panelRight.Location = new System.Drawing.Point(263, 77);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(1091, 679);
            this.panelRight.TabIndex = 0;
            // 
            // buttonChangePassword
            // 
            this.buttonChangePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(225)))), ((int)(((byte)(87)))));
            this.buttonChangePassword.FlatAppearance.BorderSize = 0;
            this.buttonChangePassword.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(195)))));
            this.buttonChangePassword.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(195)))));
            this.buttonChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChangePassword.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonChangePassword.Image = global::_05_Unified_App.Properties.Resources.key;
            this.buttonChangePassword.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonChangePassword.Location = new System.Drawing.Point(36, 601);
            this.buttonChangePassword.Name = "buttonChangePassword";
            this.buttonChangePassword.Size = new System.Drawing.Size(162, 53);
            this.buttonChangePassword.TabIndex = 1;
            this.buttonChangePassword.Text = "修 改 密 码";
            this.buttonChangePassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonChangePassword.UseVisualStyleBackColor = false;
            // 
            // buttonSearchPainters
            // 
            this.buttonSearchPainters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(225)))), ((int)(((byte)(87)))));
            this.buttonSearchPainters.FlatAppearance.BorderSize = 0;
            this.buttonSearchPainters.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(195)))));
            this.buttonSearchPainters.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(195)))));
            this.buttonSearchPainters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearchPainters.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonSearchPainters.Image = global::_05_Unified_App.Properties.Resources.artist;
            this.buttonSearchPainters.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSearchPainters.Location = new System.Drawing.Point(36, 366);
            this.buttonSearchPainters.Name = "buttonSearchPainters";
            this.buttonSearchPainters.Size = new System.Drawing.Size(162, 53);
            this.buttonSearchPainters.TabIndex = 1;
            this.buttonSearchPainters.Text = "   作 家 信 息";
            this.buttonSearchPainters.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSearchPainters.UseVisualStyleBackColor = false;
            // 
            // buttonSearchPaintings
            // 
            this.buttonSearchPaintings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(225)))), ((int)(((byte)(87)))));
            this.buttonSearchPaintings.FlatAppearance.BorderSize = 0;
            this.buttonSearchPaintings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(195)))));
            this.buttonSearchPaintings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(195)))));
            this.buttonSearchPaintings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearchPaintings.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonSearchPaintings.Image = global::_05_Unified_App.Properties.Resources.website_design;
            this.buttonSearchPaintings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSearchPaintings.Location = new System.Drawing.Point(36, 290);
            this.buttonSearchPaintings.Name = "buttonSearchPaintings";
            this.buttonSearchPaintings.Size = new System.Drawing.Size(162, 53);
            this.buttonSearchPaintings.TabIndex = 1;
            this.buttonSearchPaintings.Text = "   作 品 信 息";
            this.buttonSearchPaintings.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSearchPaintings.UseVisualStyleBackColor = false;
            this.buttonSearchPaintings.Click += new System.EventHandler(this.buttonSearchPaintings_Click);
            // 
            // buttonAddPainting
            // 
            this.buttonAddPainting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(225)))), ((int)(((byte)(87)))));
            this.buttonAddPainting.FlatAppearance.BorderSize = 0;
            this.buttonAddPainting.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(195)))));
            this.buttonAddPainting.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(195)))));
            this.buttonAddPainting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddPainting.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonAddPainting.Image = global::_05_Unified_App.Properties.Resources.layer_plus__1_;
            this.buttonAddPainting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddPainting.Location = new System.Drawing.Point(36, 211);
            this.buttonAddPainting.Name = "buttonAddPainting";
            this.buttonAddPainting.Size = new System.Drawing.Size(162, 53);
            this.buttonAddPainting.TabIndex = 1;
            this.buttonAddPainting.Text = "   添 加 作 品";
            this.buttonAddPainting.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAddPainting.UseVisualStyleBackColor = false;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelTitle.Image = global::_05_Unified_App.Properties.Resources.customize_computer__1_;
            this.labelTitle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelTitle.Location = new System.Drawing.Point(22, 18);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(285, 38);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "    艺术作品管理系统";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(195)))));
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMain";
            this.Text = "主界面";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Frm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Frm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Frm_MouseUp);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelLeft.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Button buttonAddPainting;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button buttonSearchPaintings;
        private System.Windows.Forms.Button buttonSearchPainters;
        private System.Windows.Forms.Button buttonChangePassword;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button buttonExit;
    }
}

