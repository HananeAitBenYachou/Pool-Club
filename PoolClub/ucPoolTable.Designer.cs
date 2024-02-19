namespace PoolClub
{
    partial class ucPoolTable
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gbPoolTable = new System.Windows.Forms.GroupBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.btnEnd = new Guna.UI2.WinForms.Guna2Button();
            this.pbTableImage = new System.Windows.Forms.PictureBox();
            this.btnStartStop = new Guna.UI2.WinForms.Guna2Button();
            this.gbPoolTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTableImage)).BeginInit();
            this.SuspendLayout();
            // 
            // gbPoolTable
            // 
            this.gbPoolTable.BackColor = System.Drawing.Color.Black;
            this.gbPoolTable.Controls.Add(this.btnEnd);
            this.gbPoolTable.Controls.Add(this.lblTime);
            this.gbPoolTable.Controls.Add(this.pbTableImage);
            this.gbPoolTable.Controls.Add(this.btnStartStop);
            this.gbPoolTable.Controls.Add(this.lblPlayerName);
            this.gbPoolTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbPoolTable.Font = new System.Drawing.Font("Gill Sans MT", 11F, System.Drawing.FontStyle.Bold);
            this.gbPoolTable.ForeColor = System.Drawing.Color.White;
            this.gbPoolTable.Location = new System.Drawing.Point(0, 0);
            this.gbPoolTable.Name = "gbPoolTable";
            this.gbPoolTable.Size = new System.Drawing.Size(473, 308);
            this.gbPoolTable.TabIndex = 0;
            this.gbPoolTable.TabStop = false;
            this.gbPoolTable.Text = "Table";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Black;
            this.lblTime.Font = new System.Drawing.Font("Gill Sans MT", 18F, System.Drawing.FontStyle.Bold);
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(81, 259);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(136, 42);
            this.lblTime.TabIndex = 1;
            this.lblTime.Text = "00:00:00";
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.Font = new System.Drawing.Font("Gill Sans MT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerName.Location = new System.Drawing.Point(195, 12);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(100, 39);
            this.lblPlayerName.TabIndex = 0;
            this.lblPlayerName.Text = "Player";
            // 
            // gameTimer
            // 
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // btnEnd
            // 
            this.btnEnd.BorderColor = System.Drawing.Color.White;
            this.btnEnd.BorderRadius = 22;
            this.btnEnd.BorderThickness = 2;
            this.btnEnd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEnd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEnd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEnd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEnd.FillColor = System.Drawing.Color.Black;
            this.btnEnd.Font = new System.Drawing.Font("Gill Sans MT", 10F, System.Drawing.FontStyle.Bold);
            this.btnEnd.ForeColor = System.Drawing.Color.White;
            this.btnEnd.Image = global::PoolClub.Properties.Resources.end;
            this.btnEnd.Location = new System.Drawing.Point(323, 157);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(137, 51);
            this.btnEnd.TabIndex = 5;
            this.btnEnd.Text = "End";
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // pbTableImage
            // 
            this.pbTableImage.Image = global::PoolClub.Properties.Resources.pool;
            this.pbTableImage.Location = new System.Drawing.Point(16, 61);
            this.pbTableImage.Name = "pbTableImage";
            this.pbTableImage.Size = new System.Drawing.Size(256, 202);
            this.pbTableImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbTableImage.TabIndex = 2;
            this.pbTableImage.TabStop = false;
            // 
            // btnStartStop
            // 
            this.btnStartStop.BorderColor = System.Drawing.Color.White;
            this.btnStartStop.BorderRadius = 22;
            this.btnStartStop.BorderThickness = 2;
            this.btnStartStop.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnStartStop.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnStartStop.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnStartStop.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnStartStop.FillColor = System.Drawing.Color.Black;
            this.btnStartStop.Font = new System.Drawing.Font("Gill Sans MT", 10F, System.Drawing.FontStyle.Bold);
            this.btnStartStop.ForeColor = System.Drawing.Color.White;
            this.btnStartStop.Image = global::PoolClub.Properties.Resources.start;
            this.btnStartStop.Location = new System.Drawing.Point(323, 90);
            this.btnStartStop.Name = "btnStartStop";
            this.btnStartStop.Size = new System.Drawing.Size(137, 51);
            this.btnStartStop.TabIndex = 3;
            this.btnStartStop.Text = "Start";
            this.btnStartStop.TextChanged += new System.EventHandler(this.btnStartStop_TextChanged);
            this.btnStartStop.Click += new System.EventHandler(this.btnStartStop_Click);
            // 
            // ucPoolTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.gbPoolTable);
            this.Name = "ucPoolTable";
            this.Size = new System.Drawing.Size(473, 308);
            this.gbPoolTable.ResumeLayout(false);
            this.gbPoolTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTableImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPoolTable;
        private System.Windows.Forms.PictureBox pbTableImage;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblPlayerName;
        private Guna.UI2.WinForms.Guna2Button btnEnd;
        private Guna.UI2.WinForms.Guna2Button btnStartStop;
        private System.Windows.Forms.Timer gameTimer;
    }
}
