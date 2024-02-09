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
            this.cbox_employers = new System.Windows.Forms.ComboBox();
            this.txtbox_hours = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.listbox_eHours = new System.Windows.Forms.ListBox();
            this.btn_copy = new System.Windows.Forms.Button();
            this.btn_remove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbox_employers
            // 
            this.cbox_employers.FormattingEnabled = true;
            this.cbox_employers.Items.AddRange(new object[] {
            "Nome1",
            "Nome2",
            "Nome3",
            "Nome4"});
            this.cbox_employers.Location = new System.Drawing.Point(13, 24);
            this.cbox_employers.Name = "cbox_employers";
            this.cbox_employers.Size = new System.Drawing.Size(322, 21);
            this.cbox_employers.TabIndex = 0;
            // 
            // txtbox_hours
            // 
            this.txtbox_hours.Location = new System.Drawing.Point(13, 52);
            this.txtbox_hours.Name = "txtbox_hours";
            this.txtbox_hours.Size = new System.Drawing.Size(200, 20);
            this.txtbox_hours.TabIndex = 1;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(220, 51);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(115, 23);
            this.btn_add.TabIndex = 2;
            this.btn_add.Text = "button1";
            this.btn_add.UseVisualStyleBackColor = true;
            // 
            // listbox_eHours
            // 
            this.listbox_eHours.FormattingEnabled = true;
            this.listbox_eHours.Items.AddRange(new object[] {
            "Nome1",
            "Nome2",
            "Nome3",
            "Nome4"});
            this.listbox_eHours.Location = new System.Drawing.Point(13, 79);
            this.listbox_eHours.Name = "listbox_eHours";
            this.listbox_eHours.Size = new System.Drawing.Size(322, 173);
            this.listbox_eHours.TabIndex = 3;
            // 
            // btn_copy
            // 
            this.btn_copy.Location = new System.Drawing.Point(13, 262);
            this.btn_copy.Name = "btn_copy";
            this.btn_copy.Size = new System.Drawing.Size(322, 23);
            this.btn_copy.TabIndex = 4;
            this.btn_copy.Text = "button2";
            this.btn_copy.UseVisualStyleBackColor = true;
            // 
            // btn_remove
            // 
            this.btn_remove.Location = new System.Drawing.Point(250, 91);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(75, 23);
            this.btn_remove.TabIndex = 5;
            this.btn_remove.Text = "button1";
            this.btn_remove.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 297);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.btn_copy);
            this.Controls.Add(this.listbox_eHours);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txtbox_hours);
            this.Controls.Add(this.cbox_employers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbox_employers;
        private System.Windows.Forms.TextBox txtbox_hours;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.ListBox listbox_eHours;
        private System.Windows.Forms.Button btn_copy;
        private System.Windows.Forms.Button btn_remove;
    }
}

