namespace INTS_Shift_Calculator
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cbox_employers = new System.Windows.Forms.ComboBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.listbox_eHours = new System.Windows.Forms.ListBox();
            this.btn_copy = new System.Windows.Forms.Button();
            this.btn_remove = new System.Windows.Forms.Button();
            this.txtbox_hours = new System.Windows.Forms.MaskedTextBox();
            this.panel_txtbox = new System.Windows.Forms.Panel();
            this.pic_warnTime = new System.Windows.Forms.PictureBox();
            this.label_Time = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_close = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel_employers = new System.Windows.Forms.Panel();
            this.pic_warnEmployer = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label_copied = new System.Windows.Forms.Label();
            this.panel_txtbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_warnTime)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_warnEmployer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // cbox_employers
            // 
            this.cbox_employers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.cbox_employers.Font = new System.Drawing.Font("Noto Sans", 11F);
            this.cbox_employers.FormattingEnabled = true;
            this.cbox_employers.ItemHeight = 23;
            this.cbox_employers.Items.AddRange(new object[] {
            "Farley",
            "Ryan",
            "Safii",
            "Bilawal",
            "Mazino",
            "Emerson",
            "Aley",
            "Rowan"});
            this.cbox_employers.Location = new System.Drawing.Point(15, 71);
            this.cbox_employers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbox_employers.Name = "cbox_employers";
            this.cbox_employers.Size = new System.Drawing.Size(322, 31);
            this.cbox_employers.TabIndex = 0;
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(203)))), ((int)(((byte)(151)))));
            this.btn_add.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("Noto Sans", 8.249999F, System.Drawing.FontStyle.Bold);
            this.btn_add.ForeColor = System.Drawing.Color.White;
            this.btn_add.Location = new System.Drawing.Point(211, 127);
            this.btn_add.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(125, 31);
            this.btn_add.TabIndex = 2;
            this.btn_add.Text = "Add New Time +";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // listbox_eHours
            // 
            this.listbox_eHours.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.listbox_eHours.Font = new System.Drawing.Font("Noto Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listbox_eHours.FormattingEnabled = true;
            this.listbox_eHours.ItemHeight = 24;
            this.listbox_eHours.Location = new System.Drawing.Point(14, 189);
            this.listbox_eHours.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listbox_eHours.Name = "listbox_eHours";
            this.listbox_eHours.Size = new System.Drawing.Size(322, 172);
            this.listbox_eHours.TabIndex = 3;
            // 
            // btn_copy
            // 
            this.btn_copy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(203)))), ((int)(((byte)(151)))));
            this.btn_copy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_copy.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_copy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_copy.Font = new System.Drawing.Font("Noto Sans", 10F, System.Drawing.FontStyle.Bold);
            this.btn_copy.ForeColor = System.Drawing.Color.White;
            this.btn_copy.Location = new System.Drawing.Point(67, 366);
            this.btn_copy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_copy.Name = "btn_copy";
            this.btn_copy.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_copy.Size = new System.Drawing.Size(215, 44);
            this.btn_copy.TabIndex = 4;
            this.btn_copy.Text = "Copy to clipboard";
            this.btn_copy.UseVisualStyleBackColor = false;
            this.btn_copy.Click += new System.EventHandler(this.btn_copy_Click);
            // 
            // btn_remove
            // 
            this.btn_remove.BackColor = System.Drawing.Color.Transparent;
            this.btn_remove.BackgroundImage = global::INTS_Shift_Calculator.Properties.Resources.Lixeirinha;
            this.btn_remove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_remove.Font = new System.Drawing.Font("Noto Sans", 8.249999F);
            this.btn_remove.Location = new System.Drawing.Point(314, 166);
            this.btn_remove.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(20, 20);
            this.btn_remove.TabIndex = 5;
            this.btn_remove.UseVisualStyleBackColor = false;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // txtbox_hours
            // 
            this.txtbox_hours.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbox_hours.Font = new System.Drawing.Font("Noto Sans", 10F);
            this.txtbox_hours.Location = new System.Drawing.Point(53, 5);
            this.txtbox_hours.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtbox_hours.Mask = "00:00";
            this.txtbox_hours.Name = "txtbox_hours";
            this.txtbox_hours.Size = new System.Drawing.Size(64, 19);
            this.txtbox_hours.TabIndex = 7;
            this.txtbox_hours.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtbox_hours.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtbox_hours_MaskInputRejected);
            this.txtbox_hours.Click += new System.EventHandler(this.txtbox_hours_Click);
            // 
            // panel_txtbox
            // 
            this.panel_txtbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel_txtbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_txtbox.Controls.Add(this.pic_warnTime);
            this.panel_txtbox.Controls.Add(this.txtbox_hours);
            this.panel_txtbox.Location = new System.Drawing.Point(14, 127);
            this.panel_txtbox.Name = "panel_txtbox";
            this.panel_txtbox.Size = new System.Drawing.Size(176, 31);
            this.panel_txtbox.TabIndex = 8;
            this.panel_txtbox.Click += new System.EventHandler(this.panel_txtbox_Click);
            // 
            // pic_warnTime
            // 
            this.pic_warnTime.BackColor = System.Drawing.Color.Transparent;
            this.pic_warnTime.BackgroundImage = global::INTS_Shift_Calculator.Properties.Resources.warning;
            this.pic_warnTime.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pic_warnTime.Location = new System.Drawing.Point(146, 3);
            this.pic_warnTime.Name = "pic_warnTime";
            this.pic_warnTime.Size = new System.Drawing.Size(25, 25);
            this.pic_warnTime.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_warnTime.TabIndex = 14;
            this.pic_warnTime.TabStop = false;
            this.pic_warnTime.Visible = false;
            // 
            // label_Time
            // 
            this.label_Time.AutoSize = true;
            this.label_Time.BackColor = System.Drawing.Color.Transparent;
            this.label_Time.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label_Time.Font = new System.Drawing.Font("Noto Sans", 12F, System.Drawing.FontStyle.Bold);
            this.label_Time.Location = new System.Drawing.Point(17, 104);
            this.label_Time.Name = "label_Time";
            this.label_Time.Size = new System.Drawing.Size(49, 24);
            this.label_Time.TabIndex = 9;
            this.label_Time.Text = "Time";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(14, 130);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(179, 31);
            this.panel1.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(211, 132);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(128, 29);
            this.panel2.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(17, 74);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(323, 31);
            this.panel3.TabIndex = 11;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(12)))));
            this.panel4.Controls.Add(this.btn_close);
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(-4, -1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(370, 37);
            this.panel4.TabIndex = 12;
            // 
            // btn_close
            // 
            this.btn_close.Image = global::INTS_Shift_Calculator.Properties.Resources.x;
            this.btn_close.Location = new System.Drawing.Point(331, 10);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(15, 15);
            this.btn_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_close.TabIndex = 1;
            this.btn_close.TabStop = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::INTS_Shift_Calculator.Properties.Resources.ico;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(20, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Noto Sans", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(113, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "INTS Shift Calculator";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label2.Font = new System.Drawing.Font("Noto Sans", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(18, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "List of Employers";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Noto Sans", 9F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(14, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(227, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "Name | Arrival Time | Worked Hours";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_employers
            // 
            this.panel_employers.BackColor = System.Drawing.Color.Transparent;
            this.panel_employers.Location = new System.Drawing.Point(14, 69);
            this.panel_employers.Name = "panel_employers";
            this.panel_employers.Size = new System.Drawing.Size(324, 33);
            this.panel_employers.TabIndex = 13;
            // 
            // pic_warnEmployer
            // 
            this.pic_warnEmployer.BackColor = System.Drawing.Color.Transparent;
            this.pic_warnEmployer.BackgroundImage = global::INTS_Shift_Calculator.Properties.Resources.warning;
            this.pic_warnEmployer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pic_warnEmployer.Location = new System.Drawing.Point(309, 44);
            this.pic_warnEmployer.Name = "pic_warnEmployer";
            this.pic_warnEmployer.Size = new System.Drawing.Size(25, 25);
            this.pic_warnEmployer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_warnEmployer.TabIndex = 14;
            this.pic_warnEmployer.TabStop = false;
            this.pic_warnEmployer.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::INTS_Shift_Calculator.Properties.Resources.copy;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(288, 376);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Black;
            this.panel5.Location = new System.Drawing.Point(72, 369);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(213, 44);
            this.panel5.TabIndex = 11;
            // 
            // label_copied
            // 
            this.label_copied.AutoSize = true;
            this.label_copied.BackColor = System.Drawing.Color.Transparent;
            this.label_copied.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_copied.Font = new System.Drawing.Font("Noto Sans", 9F, System.Drawing.FontStyle.Bold);
            this.label_copied.Location = new System.Drawing.Point(84, 413);
            this.label_copied.Name = "label_copied";
            this.label_copied.Size = new System.Drawing.Size(180, 18);
            this.label_copied.TabIndex = 9;
            this.label_copied.Text = "Contents copied to clipboard";
            this.label_copied.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_copied.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(352, 437);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pic_warnEmployer);
            this.Controls.Add(this.cbox_employers);
            this.Controls.Add(this.panel_employers);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel_txtbox);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.btn_copy);
            this.Controls.Add(this.listbox_eHours);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label_copied);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_Time);
            this.Font = new System.Drawing.Font("Noto Sans", 8.249999F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel_txtbox.ResumeLayout(false);
            this.panel_txtbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_warnTime)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_warnEmployer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbox_employers;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.ListBox listbox_eHours;
        private System.Windows.Forms.Button btn_copy;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.MaskedTextBox txtbox_hours;
        private System.Windows.Forms.Panel panel_txtbox;
        private System.Windows.Forms.Label label_Time;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btn_close;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel_employers;
        private System.Windows.Forms.PictureBox pic_warnTime;
        private System.Windows.Forms.PictureBox pic_warnEmployer;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label_copied;
    }
}

