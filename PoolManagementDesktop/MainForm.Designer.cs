namespace PoolManagementDesktop
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnPackages = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnAppointments = new System.Windows.Forms.Button();
            this.btnLanes = new System.Windows.Forms.Button();
            this.btnPools = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.btnPackages);
            this.panelMenu.Controls.Add(this.btnAppointments);
            this.panelMenu.Controls.Add(this.btnLanes);
            this.panelMenu.Controls.Add(this.btnPools);
            this.panelMenu.Controls.Add(this.btnUsers);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 717);
            this.panelMenu.TabIndex = 0;
            // 
            // btnPackages
            // 
            this.btnPackages.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPackages.FlatAppearance.BorderSize = 0;
            this.btnPackages.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPackages.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPackages.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnPackages.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPackages.ImageIndex = 2;
            this.btnPackages.ImageList = this.ımageList1;
            this.btnPackages.Location = new System.Drawing.Point(0, 320);
            this.btnPackages.Name = "btnPackages";
            this.btnPackages.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnPackages.Size = new System.Drawing.Size(220, 60);
            this.btnPackages.TabIndex = 1;
            this.btnPackages.Text = "    Havuz Paketleri";
            this.btnPackages.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPackages.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPackages.UseVisualStyleBackColor = true;
            this.btnPackages.Click += new System.EventHandler(this.btnPackages_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "users.png");
            this.ımageList1.Images.SetKeyName(1, "appointment.png");
            this.ımageList1.Images.SetKeyName(2, "packages.png");
            this.ımageList1.Images.SetKeyName(3, "pool_lanes.png");
            this.ımageList1.Images.SetKeyName(4, "pools.png");
            // 
            // btnAppointments
            // 
            this.btnAppointments.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAppointments.FlatAppearance.BorderSize = 0;
            this.btnAppointments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAppointments.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAppointments.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAppointments.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAppointments.ImageIndex = 1;
            this.btnAppointments.ImageList = this.ımageList1;
            this.btnAppointments.Location = new System.Drawing.Point(0, 260);
            this.btnAppointments.Name = "btnAppointments";
            this.btnAppointments.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnAppointments.Size = new System.Drawing.Size(220, 60);
            this.btnAppointments.TabIndex = 1;
            this.btnAppointments.Text = "    Randevular";
            this.btnAppointments.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAppointments.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAppointments.UseVisualStyleBackColor = true;
            this.btnAppointments.Click += new System.EventHandler(this.btnAppointments_Click);
            // 
            // btnLanes
            // 
            this.btnLanes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLanes.FlatAppearance.BorderSize = 0;
            this.btnLanes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLanes.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLanes.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnLanes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLanes.ImageIndex = 3;
            this.btnLanes.ImageList = this.ımageList1;
            this.btnLanes.Location = new System.Drawing.Point(0, 200);
            this.btnLanes.Name = "btnLanes";
            this.btnLanes.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnLanes.Size = new System.Drawing.Size(220, 60);
            this.btnLanes.TabIndex = 1;
            this.btnLanes.Text = "    Havuz Şeritleri";
            this.btnLanes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLanes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLanes.UseVisualStyleBackColor = true;
            this.btnLanes.Click += new System.EventHandler(this.btnLanes_Click);
            // 
            // btnPools
            // 
            this.btnPools.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPools.FlatAppearance.BorderSize = 0;
            this.btnPools.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPools.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPools.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnPools.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPools.ImageIndex = 4;
            this.btnPools.ImageList = this.ımageList1;
            this.btnPools.Location = new System.Drawing.Point(0, 140);
            this.btnPools.Name = "btnPools";
            this.btnPools.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnPools.Size = new System.Drawing.Size(220, 60);
            this.btnPools.TabIndex = 1;
            this.btnPools.Text = "    Havuzlar";
            this.btnPools.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPools.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPools.UseVisualStyleBackColor = true;
            this.btnPools.Click += new System.EventHandler(this.btnPools_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUsers.FlatAppearance.BorderSize = 0;
            this.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsers.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUsers.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsers.ImageIndex = 0;
            this.btnUsers.ImageList = this.ımageList1;
            this.btnUsers.Location = new System.Drawing.Point(0, 80);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnUsers.Size = new System.Drawing.Size(220, 60);
            this.btnUsers.TabIndex = 1;
            this.btnUsers.Text = "    Kullanıcılar";
            this.btnUsers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUsers.UseVisualStyleBackColor = true;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelLogo.Controls.Add(this.label1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 80);
            this.panelLogo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(31, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pool Management";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panelTitleBar.Controls.Add(this.lblTitle);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(220, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(980, 80);
            this.panelTitleBar.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Montserrat", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(476, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(121, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "BAŞLIK";
            // 
            // panelDesktop
            // 
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(220, 80);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(980, 637);
            this.panelDesktop.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 717);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnPackages;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button btnAppointments;
        private System.Windows.Forms.Button btnLanes;
        private System.Windows.Forms.Button btnPools;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelDesktop;
    }
}