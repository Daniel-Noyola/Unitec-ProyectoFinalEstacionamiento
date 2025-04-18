using System.Diagnostics;
using Estacionamiento.Classes;

namespace Estacionamiento
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        public void Main_Load(object sender, EventArgs e)
        {
            MainTimer.Start();
            Directory.CreateDirectory(PDFMaker.Dir);
        }
        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Directory.Exists(PDFMaker.Dir))
            {
                try
                {
                    Directory.Delete(PDFMaker.Dir, true);
                }
                catch
                {
                    MessageBox.Show($"No se pudo eliminar la carpeta '{PDFMaker.Dir}' cierre todos los archivos y elimine la carpeta manualmente", "Error");
                }
            }
        }
        public void MainTimer_Tick_1(object sender, EventArgs e)
        {
            TimerDisplay.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void BtnGenTicket_Click(object sender, EventArgs e)
        {
            Ticket ticket = new();
            Ticket.AddTicket(ticket);
            PDFMaker.MakeTicket(ticket);
        }

        private void BtnTickets_Click(object sender, EventArgs e)
        {
            var form = new TicketsList();
            form.Show();
        }

        private void BtnOpenFolder_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", PDFMaker.Dir);
        }
    }
}
