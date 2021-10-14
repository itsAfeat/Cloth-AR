namespace Clother
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
            this.picBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.picTimer = new System.Windows.Forms.Timer(this.components);
            this.timeLabel = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.conBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.debugLabel = new System.Windows.Forms.Label();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.stateBox = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateBox)).BeginInit();
            this.SuspendLayout();
            // 
            // picBtn
            // 
            this.picBtn.BackColor = System.Drawing.Color.PaleTurquoise;
            this.picBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.picBtn.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.picBtn.ForeColor = System.Drawing.Color.Black;
            this.picBtn.Location = new System.Drawing.Point(74, 445);
            this.picBtn.Name = "picBtn";
            this.picBtn.Size = new System.Drawing.Size(128, 37);
            this.picBtn.TabIndex = 0;
            this.picBtn.Text = "Take Picture";
            this.picBtn.UseVisualStyleBackColor = false;
            this.picBtn.Click += new System.EventHandler(this.PicBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.PaleTurquoise;
            this.backBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Bold);
            this.backBtn.ForeColor = System.Drawing.Color.Black;
            this.backBtn.Location = new System.Drawing.Point(479, 12);
            this.backBtn.Name = "backBtn";
            this.backBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.backBtn.Size = new System.Drawing.Size(45, 42);
            this.backBtn.TabIndex = 2;
            this.backBtn.Text = "->";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // picTimer
            // 
            this.picTimer.Enabled = true;
            this.picTimer.Interval = 1000;
            this.picTimer.Tick += new System.EventHandler(this.PicTimer_Tick);
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.BackColor = System.Drawing.Color.MediumTurquoise;
            this.timeLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.timeLabel.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Bold);
            this.timeLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.timeLabel.Location = new System.Drawing.Point(17, 18);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(58, 20);
            this.timeLabel.TabIndex = 4;
            this.timeLabel.Text = "Timer";
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.PaleTurquoise;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.saveBtn.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.ForeColor = System.Drawing.Color.Black;
            this.saveBtn.Location = new System.Drawing.Point(208, 445);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(128, 37);
            this.saveBtn.TabIndex = 5;
            this.saveBtn.Text = "Save Picture";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // conBtn
            // 
            this.conBtn.BackColor = System.Drawing.Color.PaleTurquoise;
            this.conBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.conBtn.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conBtn.ForeColor = System.Drawing.Color.Black;
            this.conBtn.Location = new System.Drawing.Point(342, 445);
            this.conBtn.Name = "conBtn";
            this.conBtn.Size = new System.Drawing.Size(128, 37);
            this.conBtn.TabIndex = 6;
            this.conBtn.Text = "Continue";
            this.conBtn.UseVisualStyleBackColor = false;
            this.conBtn.Click += new System.EventHandler(this.ConBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.debugLabel);
            this.panel1.Controls.Add(this.timeLabel);
            this.panel1.Controls.Add(this.picBox);
            this.panel1.Location = new System.Drawing.Point(12, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(515, 379);
            this.panel1.TabIndex = 8;
            // 
            // debugLabel
            // 
            this.debugLabel.AutoSize = true;
            this.debugLabel.BackColor = System.Drawing.Color.MediumTurquoise;
            this.debugLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.debugLabel.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Bold);
            this.debugLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.debugLabel.Location = new System.Drawing.Point(436, 18);
            this.debugLabel.Name = "debugLabel";
            this.debugLabel.Size = new System.Drawing.Size(64, 20);
            this.debugLabel.TabIndex = 6;
            this.debugLabel.Text = "Debug";
            this.debugLabel.Visible = false;
            // 
            // picBox
            // 
            this.picBox.BackColor = System.Drawing.Color.PaleTurquoise;
            this.picBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picBox.Location = new System.Drawing.Point(3, 3);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(509, 373);
            this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBox.TabIndex = 1;
            this.picBox.TabStop = false;
            // 
            // stateBox
            // 
            this.stateBox.BackColor = System.Drawing.Color.Maroon;
            this.stateBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.stateBox.Location = new System.Drawing.Point(10, 12);
            this.stateBox.Name = "stateBox";
            this.stateBox.Size = new System.Drawing.Size(100, 42);
            this.stateBox.TabIndex = 3;
            this.stateBox.TabStop = false;
            // 
            // MainForm
            // 
            this.AcceptButton = this.picBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.CancelButton = this.backBtn;
            this.ClientSize = new System.Drawing.Size(539, 494);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.conBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.stateBox);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.picBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cloth-AR v0.9";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button picBtn;
        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Timer picTimer;
        private System.Windows.Forms.PictureBox stateBox;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button conBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label debugLabel;
    }
}

