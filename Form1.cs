using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INTS_Shift_Calculator
{
    public partial class Form1 : Form
    {
        public readonly TimeSpan hFechamento = TimeSpan.Parse("08:30");
        public Form1()
        {
            InitializeComponent();
            CreatePanelBorder(Color.Black, panel_txtbox);



        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string totalHour = "", name, hour;

            if (cbox_employers.Text != "" && Regex.IsMatch(txtbox_hours.Text, @"^\d{2}:\d{2}$"))
            {
                totalHour = CalculateTime(txtbox_hours.Text);
                //label_test.Text = txtbox_hours.Text;
                name = cbox_employers.Text;
                hour = txtbox_hours.Text;

                AddEmployerOnList(name, hour, totalHour);
                pic_warnEmployer.Hide();
                pic_warnTime.Hide();
                CreatePanelBorder(Color.Black, panel_txtbox);
                CreatePanelBorder(Color.Black, panel_employers);
            }

            //Se tiver errado a hora
            else if(!Regex.IsMatch(txtbox_hours.Text, @"^\d{2}:\d{2}$"))
            {
                    CreatePanelBorder(Color.Red, panel_txtbox);
                    pic_warnTime.Show();
            }

            //Se tiver certo a hora
            else if(Regex.IsMatch(txtbox_hours.Text, @"^\d{2}:\d{2}$") && cbox_employers.Text == "")
            {
                pic_warnTime.Hide();
                CreatePanelBorder(Color.Black, panel_txtbox);
                CreatePanelBorder(Color.Red, panel_employers);
                pic_warnEmployer.Show();


            }

            else if (cbox_employers.Text != "" && !Regex.IsMatch(txtbox_hours.Text, @"^\d{2}:\d{2}$"))
            {

            }
            else
            {
                CreatePanelBorder(Color.Red, panel_employers);
                pic_warnEmployer.Show();
            }


        }

        public void AddEmployerOnList(string name, string hour, string totalHour)
        {
            listbox_eHours.Items.Add(($"{name} | {hour}am | {totalHour} hours"));
        }

        public string CalculateTime(string hour)
        {
            TimeSpan dif = hFechamento - TimeSpan.Parse(hour);
            return dif.ToString(@"hh\:mm");
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            if (listbox_eHours.SelectedIndex != -1)
            {
                listbox_eHours.Items.RemoveAt(listbox_eHours.SelectedIndex);
            }


        }

        public void CreatePanelBorder(Color color, Panel panel)
        {
            panel.Paint += (s, pe) => Panel_txtbox_Paint(s, pe, color, panel);
            panel.Invalidate();
        }
        private void btn_copy_Click(object sender, EventArgs e)
        {
            DateTime tomorrow = DateTime.Today.AddDays(1);
            string dayOfWeekTomorrow = tomorrow.DayOfWeek.ToString(); // Retorna o dia da semana em inglês para amanhã
            string tomorrowFormatted = tomorrow.ToString("dd/MM/yy"); // Retorna a data de amanhã no formato "dd/MM/yy"


            string textCopy = string.Empty;
            textCopy += "Please all below confirm your shifts \n";
            textCopy += "\n";//Espaçamento de uma linha
            textCopy += $"*Alocation for {dayOfWeekTomorrow}*\n";
            textCopy += $"{tomorrowFormatted}\n";
            textCopy += "\n";//Espaçamento de uma linha

            //Insere elementos da lista
            foreach (string s in listbox_eHours.Items)
            {
                textCopy += s+"\n\n";
            }

            textCopy += "\n*‼️‼️Arrive Depot on time, no lateness‼️‼️*\n";

            Clipboard.SetText(textCopy);
            label_copied.Show();

            HideLabel(label_copied,2000);


        }

        private void txtbox_hours_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
           
        }

        private void Panel_txtbox_Paint(object sender, PaintEventArgs e, Color color, Panel panel)
        {
            // Desenha a borda personalizada ao redor do Panel
            ControlPaint.DrawBorder(e.Graphics, panel.ClientRectangle, color, ButtonBorderStyle.Solid);
            
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtbox_hours_Click(object sender, EventArgs e)
        {
            txtbox_hours.Focus();
        }

        private void panel_txtbox_Click(object sender, EventArgs e)
        {
            txtbox_hours.Focus();
        }

        private void HideLabel(Label label, int milliseconds)
        {
            // Configura o Timer
            Timer timer = new Timer();
            timer.Interval = milliseconds;
            timer.Tick += (sender, e) =>
            {
                // Faz o Label desaparecer
                label.Visible = false;
                // Para o Timer
                timer.Stop();
            };
            timer.Start();
        }
    }
}
