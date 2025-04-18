using Estacionamiento.Classes;

namespace Estacionamiento
{
    public partial class PayForm : Form
    {
        public static Ticket ticket = null;
        public PayForm()
        {
            InitializeComponent();
        }

        private void PayForm_Load(object sender, EventArgs e)
        {
            ticket.SetCheckOutDate();

            var table = TableData;
            var font = new Font("Segoe UI Semibold", 12F, FontStyle.Italic);

            var folio = new Label();
            folio.Text = ticket.Id.ToString();
            folio.Anchor = AnchorStyles.Left;
            folio.Font = font;
            folio.AutoSize = true;

            var dateIn = new Label();
            dateIn.Text = ticket.GetCheckInDate("/");
            dateIn.Anchor = AnchorStyles.Left;
            dateIn.Font = font;
            dateIn.AutoSize = true;

            var hourIn = new Label();
            hourIn.Text = $"{ticket.GetCheckInHour(":")} hrs";
            hourIn.Anchor = AnchorStyles.Left;
            hourIn.Font = font;
            hourIn.AutoSize = true;

            var hourOut = new Label();
            hourOut.Text = $"{ticket.GetCheckOutHour(":")} hrs";
            hourOut.Anchor = AnchorStyles.Left;
            hourOut.Font = font;
            hourOut.AutoSize = true;

            string total = ticket.CalculateTotal();
            var totalStr = new Label();
            totalStr.Text = $"${total}";
            totalStr.Anchor = AnchorStyles.Left;
            totalStr.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            totalStr.AutoSize = true;


            table.Controls.AddRange([
                folio,
                dateIn,
                hourIn,
                hourOut,
                totalStr
            ]);

        }

        private void BtnTickets_Click(object sender, EventArgs e)
        {
            ticket.IsPaid = true;
            PDFMaker.EditTicket(ticket);
            MessageBox.Show($"Tu boleto con folio {ticket.Id} ha sido pagado", "Pagado");

            var listForm = new TicketsList();
            listForm.Show();
            
            Close();
        }
    }
}
