namespace Estacionamiento.Classes
{
    public class Ticket
    {
        public int Id { get; } = GetRandomId();
        public DateTime CheckInDate { get; } = DateTime.Now;
        public DateTime CheckOutDate { get; set; }
        public bool IsPaid { get; set; } = false;
        public double Total { get; set; }

        // ---- Lista tickets ----
        public static List<Ticket> Tickets = [];

        public static void AddTicket(Ticket ticket)
        {
            Tickets.Add(ticket);
        }
        public static Ticket? GetTicket(int id)
        {
            Ticket? ticket = Tickets.Find(ticket => ticket.Id == id);
            return ticket;
        }

        //Calcular el total segun el tiempo que se quedo
        public string CalculateTotal()
        {
            TimeSpan totalTime = CheckOutDate - CheckInDate;
            double pricePerHour = 1800;

            Total = totalTime.TotalHours * pricePerHour;

            return Total.ToString("F2");
        }

        // ---- Getters - Setters ----
        public string GetCheckInDate(string separador)
        {
            return CheckInDate.ToString($"dd{separador}mm{separador}yyyy");
        }
        public string GetCheckInHour(string separador)
        {
            return CheckInDate.ToString($"HH{separador}mm{separador}ss");
        }

        public void SetCheckOutDate()
        {
            CheckOutDate = DateTime.Now;
        }
        public string GetCheckOutDate(string separador)
        {
            return CheckOutDate.ToString($"dd{separador}mm{separador}yyyy");
        }
        public string GetCheckOutHour(string separador)
        {
            return CheckOutDate.ToString($"HH{separador}mm{separador}ss");
        }

        //Helpers----------
        public static int GetRandomId()
        {
            Random random = new();
            string id;

            do
            {
                id = "";
                for (int i = 0; i < 6; i++)
                {
                    id += random.Next(0, 10).ToString();
                }

            }
            while (GetTicket(int.Parse(id)) != null);


            return int.Parse(id);
        }
    }
}
