using Estacionamiento.Classes;
using iText.Layout.Element;
using System.Data;

namespace Estacionamiento
{
    public partial class TicketsList : Form
    {
        public TicketsList()
        {
            InitializeComponent();
        }

        private void TicketsList_Load(object sender, EventArgs e)
        {


            var tickets = Ticket.Tickets;
            //Lista los boletos generados
            tickets.ForEach(ticket =>
            {
                var folio = new Label();
                folio.Text = ticket.Id.ToString();

                var date = new Label();
                date.Text = $"{ticket.GetCheckInDate("/")} {ticket.GetCheckInHour(":")}";
                date.AutoSize = true;

                var isPaid = new Label();
                isPaid.Text = ticket.IsPaid ? "Pagado" : "No pagado";
                isPaid.BackColor = ticket.IsPaid ? Color.FromArgb(0, 201, 81) : Color.FromArgb(159, 7, 18);
                isPaid.ForeColor = Color.FromArgb(244, 244, 245);

                var buttonPay = new Button();
                buttonPay.Text = ticket.IsPaid ? "Mostrar Ticket" : "Pagar";
                buttonPay.Anchor = AnchorStyles.Top;

                //Funcionalidad del boton
                buttonPay.Click += (s, e) =>
                {
                    if (!ticket.IsPaid)
                    {
                        var form = new PayForm();
                        PayForm.ticket = ticket;
                        form.Show();
                        Close();
                        return;
                    }

                    PDFMaker.OpenPDF($"{PDFMaker.Dir}\\{ticket.Id}.pdf");
                };

                TableLayout.RowCount++;
                TableLayout.Controls.AddRange([
                    folio,
                    date,
                    isPaid,
                    buttonPay
                ]);
            }
            );
        }
    }
}
