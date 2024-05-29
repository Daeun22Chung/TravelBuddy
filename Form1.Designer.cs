namespace daunTrip
{
    partial class Form1
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
            this.pnlNav = new System.Windows.Forms.Panel();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlTitleBar = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblHome = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnChn = new System.Windows.Forms.Button();
            this.btnJP = new System.Windows.Forms.Button();
            this.btnKor = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlNav.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            this.pnlTitleBar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlNav
            // 
            this.pnlNav.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.pnlNav.Controls.Add(this.btnChn);
            this.pnlNav.Controls.Add(this.btnJP);
            this.pnlNav.Controls.Add(this.btnKor);
            this.pnlNav.Controls.Add(this.pnlLogo);
            this.pnlNav.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlNav.Location = new System.Drawing.Point(0, 0);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(230, 564);
            this.pnlNav.TabIndex = 0;
            this.pnlNav.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlNav_Paint);
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pnlLogo.Controls.Add(this.label1);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(230, 70);
            this.pnlLogo.TabIndex = 0;
            this.pnlLogo.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlLogo_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.UpArrow;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(18, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Travel buddy";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pnlTitleBar
            // 
            this.pnlTitleBar.BackColor = System.Drawing.Color.Thistle;
            this.pnlTitleBar.Controls.Add(this.btnAdd);
            this.pnlTitleBar.Controls.Add(this.lblHome);
            this.pnlTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitleBar.Location = new System.Drawing.Point(230, 0);
            this.pnlTitleBar.Name = "pnlTitleBar";
            this.pnlTitleBar.Size = new System.Drawing.Size(735, 70);
            this.pnlTitleBar.TabIndex = 1;
            this.pnlTitleBar.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTitleBar_Paint);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(628, 41);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add Room";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblHome
            // 
            this.lblHome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHome.AutoSize = true;
            this.lblHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHome.Location = new System.Drawing.Point(52, 22);
            this.lblHome.Name = "lblHome";
            this.lblHome.Size = new System.Drawing.Size(79, 25);
            this.lblHome.TabIndex = 0;
            this.lblHome.Text = "HOME";
            this.lblHome.Click += new System.EventHandler(this.lblHome_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.Cornsilk;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(230, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(735, 494);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnChn
            // 
            this.btnChn.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnChn.FlatAppearance.BorderSize = 0;
            this.btnChn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChn.Image = global::daunTrip.Properties.Resources.china__1_;
            this.btnChn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChn.Location = new System.Drawing.Point(0, 170);
            this.btnChn.Name = "btnChn";
            this.btnChn.Size = new System.Drawing.Size(230, 50);
            this.btnChn.TabIndex = 3;
            this.btnChn.Text = "CHINA";
            this.btnChn.UseVisualStyleBackColor = true;
            this.btnChn.Click += new System.EventHandler(this.btnChn_Click);
            // 
            // btnJP
            // 
            this.btnJP.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnJP.FlatAppearance.BorderSize = 0;
            this.btnJP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJP.Image = global::daunTrip.Properties.Resources.japan__1_;
            this.btnJP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnJP.Location = new System.Drawing.Point(0, 120);
            this.btnJP.Name = "btnJP";
            this.btnJP.Size = new System.Drawing.Size(230, 50);
            this.btnJP.TabIndex = 2;
            this.btnJP.Text = "JAPAN";
            this.btnJP.UseVisualStyleBackColor = true;
            this.btnJP.Click += new System.EventHandler(this.btnJP_Click);
            // 
            // btnKor
            // 
            this.btnKor.AutoSize = true;
            this.btnKor.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnKor.FlatAppearance.BorderSize = 0;
            this.btnKor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKor.Image = global::daunTrip.Properties.Resources.korea__2_;
            this.btnKor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKor.Location = new System.Drawing.Point(0, 70);
            this.btnKor.Name = "btnKor";
            this.btnKor.Size = new System.Drawing.Size(230, 50);
            this.btnKor.TabIndex = 1;
            this.btnKor.Text = "KOREA";
            this.btnKor.UseVisualStyleBackColor = true;
            this.btnKor.Click += new System.EventHandler(this.btnKor_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::daunTrip.Properties.Resources.free_icon_friends_2583040;
            this.panel2.ForeColor = System.Drawing.Color.Cornsilk;
            this.panel2.Location = new System.Drawing.Point(75, 163);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(514, 331);
            this.panel2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(200, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(288, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "현지에서 여행 동행을 구해봐요!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(965, 564);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlTitleBar);
            this.Controls.Add(this.pnlNav);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlNav.ResumeLayout(false);
            this.pnlNav.PerformLayout();
            this.pnlLogo.ResumeLayout(false);
            this.pnlLogo.PerformLayout();
            this.pnlTitleBar.ResumeLayout(false);
            this.pnlTitleBar.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.Button btnKor;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Button btnChn;
        private System.Windows.Forms.Button btnJP;
        private System.Windows.Forms.Panel pnlTitleBar;
        private System.Windows.Forms.Label lblHome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
    }
}

