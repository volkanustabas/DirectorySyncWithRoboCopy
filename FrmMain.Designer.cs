
namespace DirectorySyncWithRoboCopy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gb_sourceDirectory = new System.Windows.Forms.GroupBox();
            this.lbl_info_sourceDirectory = new System.Windows.Forms.Label();
            this.btn_browse_sourceDirectory = new System.Windows.Forms.Button();
            this.gb_addList = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_destinationDirectory = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.lb_destinationDirectory = new System.Windows.Forms.ListBox();
            this.btn_sync = new System.Windows.Forms.Button();
            this.pb_loading = new System.Windows.Forms.PictureBox();
            this.bw_sync = new System.ComponentModel.BackgroundWorker();
            this.gb_sourceDirectory.SuspendLayout();
            this.gb_addList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_loading)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_sourceDirectory
            // 
            this.gb_sourceDirectory.Controls.Add(this.lbl_info_sourceDirectory);
            this.gb_sourceDirectory.Controls.Add(this.btn_browse_sourceDirectory);
            this.gb_sourceDirectory.Location = new System.Drawing.Point(13, 13);
            this.gb_sourceDirectory.Name = "gb_sourceDirectory";
            this.gb_sourceDirectory.Size = new System.Drawing.Size(534, 74);
            this.gb_sourceDirectory.TabIndex = 0;
            this.gb_sourceDirectory.TabStop = false;
            this.gb_sourceDirectory.Text = "Source Directory";
            // 
            // lbl_info_sourceDirectory
            // 
            this.lbl_info_sourceDirectory.AutoSize = true;
            this.lbl_info_sourceDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_info_sourceDirectory.ForeColor = System.Drawing.Color.Red;
            this.lbl_info_sourceDirectory.Location = new System.Drawing.Point(7, 50);
            this.lbl_info_sourceDirectory.Name = "lbl_info_sourceDirectory";
            this.lbl_info_sourceDirectory.Size = new System.Drawing.Size(12, 16);
            this.lbl_info_sourceDirectory.TabIndex = 1;
            this.lbl_info_sourceDirectory.Text = "-";
            // 
            // btn_browse_sourceDirectory
            // 
            this.btn_browse_sourceDirectory.Location = new System.Drawing.Point(7, 20);
            this.btn_browse_sourceDirectory.Name = "btn_browse_sourceDirectory";
            this.btn_browse_sourceDirectory.Size = new System.Drawing.Size(102, 23);
            this.btn_browse_sourceDirectory.TabIndex = 0;
            this.btn_browse_sourceDirectory.Text = "Browse";
            this.btn_browse_sourceDirectory.UseVisualStyleBackColor = true;
            this.btn_browse_sourceDirectory.Click += new System.EventHandler(this.btn_browse_sourceDirectory_Click);
            // 
            // gb_addList
            // 
            this.gb_addList.Controls.Add(this.pb_loading);
            this.gb_addList.Controls.Add(this.label1);
            this.gb_addList.Controls.Add(this.tb_destinationDirectory);
            this.gb_addList.Controls.Add(this.btn_add);
            this.gb_addList.Controls.Add(this.lb_destinationDirectory);
            this.gb_addList.Location = new System.Drawing.Point(13, 93);
            this.gb_addList.Name = "gb_addList";
            this.gb_addList.Size = new System.Drawing.Size(534, 220);
            this.gb_addList.TabIndex = 2;
            this.gb_addList.TabStop = false;
            this.gb_addList.Text = "Add List";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Destination Directory";
            // 
            // tb_destinationDirectory
            // 
            this.tb_destinationDirectory.Location = new System.Drawing.Point(7, 45);
            this.tb_destinationDirectory.Name = "tb_destinationDirectory";
            this.tb_destinationDirectory.Size = new System.Drawing.Size(303, 20);
            this.tb_destinationDirectory.TabIndex = 6;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(7, 71);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(102, 23);
            this.btn_add.TabIndex = 5;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // lb_destinationDirectory
            // 
            this.lb_destinationDirectory.FormattingEnabled = true;
            this.lb_destinationDirectory.Location = new System.Drawing.Point(316, 45);
            this.lb_destinationDirectory.Name = "lb_destinationDirectory";
            this.lb_destinationDirectory.Size = new System.Drawing.Size(212, 160);
            this.lb_destinationDirectory.TabIndex = 4;
            // 
            // btn_sync
            // 
            this.btn_sync.Location = new System.Drawing.Point(13, 319);
            this.btn_sync.Name = "btn_sync";
            this.btn_sync.Size = new System.Drawing.Size(534, 49);
            this.btn_sync.TabIndex = 3;
            this.btn_sync.Text = "SYNC";
            this.btn_sync.UseVisualStyleBackColor = true;
            this.btn_sync.Click += new System.EventHandler(this.btn_sync_Click);
            // 
            // pb_loading
            // 
            this.pb_loading.Image = global::DirectorySyncWithRoboCopy.Properties.Resources.loading;
            this.pb_loading.Location = new System.Drawing.Point(210, 100);
            this.pb_loading.Name = "pb_loading";
            this.pb_loading.Size = new System.Drawing.Size(64, 64);
            this.pb_loading.TabIndex = 8;
            this.pb_loading.TabStop = false;
            // 
            // bw_sync
            // 
            this.bw_sync.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bw_sync_DoWork);
            this.bw_sync.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bw_sync_RunWorkerCompleted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 380);
            this.Controls.Add(this.btn_sync);
            this.Controls.Add(this.gb_addList);
            this.Controls.Add(this.gb_sourceDirectory);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Directory Sync With RoboCopy";
            this.gb_sourceDirectory.ResumeLayout(false);
            this.gb_sourceDirectory.PerformLayout();
            this.gb_addList.ResumeLayout(false);
            this.gb_addList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_loading)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_sourceDirectory;
        private System.Windows.Forms.Button btn_browse_sourceDirectory;
        private System.Windows.Forms.Label lbl_info_sourceDirectory;
        private System.Windows.Forms.GroupBox gb_addList;
        private System.Windows.Forms.Button btn_sync;
        private System.Windows.Forms.ListBox lb_destinationDirectory;
        private System.Windows.Forms.TextBox tb_destinationDirectory;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pb_loading;
        private System.ComponentModel.BackgroundWorker bw_sync;
    }
}

