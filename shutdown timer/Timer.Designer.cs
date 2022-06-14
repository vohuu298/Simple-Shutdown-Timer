namespace shutdown_timer
{
    partial class Timer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Timer));
            this.btnSetnClose = new System.Windows.Forms.Button();
            this.txtHour = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtSecond = new System.Windows.Forms.TextBox();
            this.txtMinute = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.radio15min = new System.Windows.Forms.RadioButton();
            this.radio30min = new System.Windows.Forms.RadioButton();
            this.radio60min = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.ckbCustom = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnSetnClose
            // 
            this.btnSetnClose.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetnClose.Location = new System.Drawing.Point(133, 157);
            this.btnSetnClose.Name = "btnSetnClose";
            this.btnSetnClose.Size = new System.Drawing.Size(99, 29);
            this.btnSetnClose.TabIndex = 0;
            this.btnSetnClose.Text = "Set and Close";
            this.btnSetnClose.UseVisualStyleBackColor = true;
            this.btnSetnClose.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // txtHour
            // 
            this.txtHour.Location = new System.Drawing.Point(30, 123);
            this.txtHour.Name = "txtHour";
            this.txtHour.Size = new System.Drawing.Size(80, 22);
            this.txtHour.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(236, 157);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 29);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtSecond
            // 
            this.txtSecond.Location = new System.Drawing.Point(236, 123);
            this.txtSecond.Name = "txtSecond";
            this.txtSecond.Size = new System.Drawing.Size(80, 22);
            this.txtSecond.TabIndex = 5;
            // 
            // txtMinute
            // 
            this.txtMinute.Location = new System.Drawing.Point(133, 123);
            this.txtMinute.Name = "txtMinute";
            this.txtMinute.Size = new System.Drawing.Size(80, 22);
            this.txtMinute.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Hour";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(151, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Minute";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(252, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Second";
            // 
            // radio15min
            // 
            this.radio15min.AutoSize = true;
            this.radio15min.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio15min.Location = new System.Drawing.Point(27, 42);
            this.radio15min.Name = "radio15min";
            this.radio15min.Size = new System.Drawing.Size(67, 20);
            this.radio15min.TabIndex = 8;
            this.radio15min.TabStop = true;
            this.radio15min.Text = "15 min";
            this.radio15min.UseVisualStyleBackColor = true;
            this.radio15min.CheckedChanged += new System.EventHandler(this.radio15min_CheckedChanged);
            // 
            // radio30min
            // 
            this.radio30min.AutoSize = true;
            this.radio30min.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio30min.Location = new System.Drawing.Point(138, 42);
            this.radio30min.Name = "radio30min";
            this.radio30min.Size = new System.Drawing.Size(67, 20);
            this.radio30min.TabIndex = 9;
            this.radio30min.TabStop = true;
            this.radio30min.Text = "30 min";
            this.radio30min.UseVisualStyleBackColor = true;
            this.radio30min.CheckedChanged += new System.EventHandler(this.radio30min_CheckedChanged);
            // 
            // radio60min
            // 
            this.radio60min.AutoSize = true;
            this.radio60min.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio60min.Location = new System.Drawing.Point(249, 42);
            this.radio60min.Name = "radio60min";
            this.radio60min.Size = new System.Drawing.Size(67, 20);
            this.radio60min.TabIndex = 9;
            this.radio60min.TabStop = true;
            this.radio60min.Text = "60 min";
            this.radio60min.UseVisualStyleBackColor = true;
            this.radio60min.CheckedChanged += new System.EventHandler(this.radio60min_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(306, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Choose from list or enter manually:";
            // 
            // ckbCustom
            // 
            this.ckbCustom.AutoSize = true;
            this.ckbCustom.Location = new System.Drawing.Point(30, 76);
            this.ckbCustom.Name = "ckbCustom";
            this.ckbCustom.Size = new System.Drawing.Size(74, 20);
            this.ckbCustom.TabIndex = 12;
            this.ckbCustom.Text = "Custom";
            this.ckbCustom.UseVisualStyleBackColor = true;
            this.ckbCustom.CheckedChanged += new System.EventHandler(this.ckbCustom_CheckedChanged);
            // 
            // Timer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(340, 201);
            this.Controls.Add(this.ckbCustom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.radio60min);
            this.Controls.Add(this.radio30min);
            this.Controls.Add(this.radio15min);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMinute);
            this.Controls.Add(this.txtSecond);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtHour);
            this.Controls.Add(this.btnSetnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Timer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shutdown Timer";
            this.Load += new System.EventHandler(this.Timer_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSetnClose;
        private System.Windows.Forms.TextBox txtHour;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtSecond;
        private System.Windows.Forms.TextBox txtMinute;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radio15min;
        private System.Windows.Forms.RadioButton radio30min;
        private System.Windows.Forms.RadioButton radio60min;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox ckbCustom;
    }
}

