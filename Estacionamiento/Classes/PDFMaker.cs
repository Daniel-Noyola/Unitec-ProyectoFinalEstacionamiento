using iText.IO.Font.Constants;
using iText.IO.Image;
using iText.Kernel.Font;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using QRCoder;
using System.Drawing.Imaging;

namespace Estacionamiento.Classes
{
    internal static class PDFMaker
    {
        //public static string Dir = $"D:\\Daniel\\Tickets";
        public static string Dir = $"C:\\TicketsEstacionamiento";
        public static void MakeTicket(Ticket ticket)
        {
            string path = $"{Dir}\\{ticket.Id}.pdf";
            string parkingName = "Estacionamiento las Americas";
            ImageData qrCode = CreateQrCode("Datos de prueba");

            try
            {
                //Crear el archivo PDF
                using (var writer = new PdfWriter(path))
                {
                using (var pdf =  new PdfDocument(writer))
                {
                    var doc = new Document(pdf);

                    //Contenido del PDF
                    var fontBold = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);

                    //Titulo del documento
                    var title = new Paragraph(parkingName)
                    .SetFont(fontBold)
                    .SetFontSize(20)
                    .SetTextAlignment(TextAlignment.CENTER)
                    .SetMarginBottom(20);

                    var sub = new Paragraph("Informacion del ticket")
                        .SetFont(fontBold)
                        .SetFontSize(14);

                    //Contenido del documento
                    var telQuejas = new Paragraph("Quejas y sugerencias al 5512345678")
                        .SetTextAlignment(TextAlignment.RIGHT)
                        .SetFontSize(10);

                    var ticketNo = new Paragraph($"Folio: {ticket.Id}");
                    var date = new Paragraph($"Fecha: {ticket.GetCheckInDate("/")}");
                    var checkIn = new Paragraph($"Hora de entrada: {ticket.GetCheckInHour(":")}hrs");

                    var qrImg = new iText.Layout.Element.Image(qrCode);
                    qrImg.ScaleToFit(150, 150);
                    qrImg.SetHorizontalAlignment(iText.Layout.Properties.HorizontalAlignment.CENTER);




                    //Armado del PDF
                    doc.Add(title);
                    doc.Add(telQuejas);
                    doc.Add(sub);
                    doc.Add(ticketNo);
                    doc.Add(date);
                    doc.Add(checkIn);
                    doc.Add(qrImg);
                    doc.Close();

                    MessageBox.Show("Ticket Guardado");
                    OpenPDF(path);

                }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public static void EditTicket(Ticket ticket)
        {
            string path = $"{Dir}\\{ticket.Id}.pdf";
            string parkingName = "Estacionamiento las Americas";
            ImageData qrCode = CreateQrCode("Datos de prueba");

            if (File.Exists(path)) File.Delete(path); 

            try
            {
                //Crear el archivo PDF
                using (var writer = new PdfWriter(path))
                {
                    using (var pdf = new PdfDocument(writer))
                    {
                        var doc = new Document(pdf);

                        //Contenido del PDF
                        var fontBold = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);

                        //Titulo del documento
                        var title = new Paragraph(parkingName)
                        .SetFont(fontBold)
                        .SetFontSize(20)
                        .SetTextAlignment(TextAlignment.CENTER)
                        .SetMarginBottom(20);

                        var sub = new Paragraph("Informacion del ticket")
                            .SetFont(fontBold)
                            .SetFontSize(14);

                        //Contenido del documento
                        var telQuejas = new Paragraph("Quejas y sugerencias al 5512345678")
                            .SetTextAlignment(TextAlignment.RIGHT)
                            .SetFontSize(10);

                        var ticketNo = new Paragraph($"Folio: {ticket.Id}");
                        var date = new Paragraph($"Fecha: {ticket.GetCheckInDate("/")}");
                        var checkIn = new Paragraph($"Hora de entrada: {ticket.GetCheckInHour(":")}hrs");
                        var checkOut = new Paragraph($"Hora de entrada: {ticket.GetCheckOutHour(":")}hrs");

                        var total = new Paragraph($"Total: ${ticket.Total:F2}")
                            .SetFontSize(15)
                            .SetFont(fontBold);

                        var state = new Paragraph($"Estado: Pagado")
                            .SetFontSize(15)
                            .SetFont(fontBold);

                        var qrImg = new iText.Layout.Element.Image(qrCode);
                        qrImg.ScaleToFit(150, 150);
                        qrImg.SetHorizontalAlignment(iText.Layout.Properties.HorizontalAlignment.CENTER);


                        //Armado del PDF
                        doc.Add(title);
                        doc.Add(telQuejas);
                        doc.Add(sub);
                        doc.Add(ticketNo);
                        doc.Add(date);
                        doc.Add(checkIn);
                        doc.Add(checkOut);
                        doc.Add(total);
                        doc.Add(state);
                        doc.Add(qrImg);
                        doc.Close();

                        OpenPDF(path);

                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        //Generar código QR
        public static ImageData CreateQrCode(string data)
        {
            QRCodeGenerator qrGenerator = new();
            using QRCodeData qrCodeData = qrGenerator.CreateQrCode(data, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(20);

            using (MemoryStream ms = new MemoryStream())
            {
                qrCodeImage.Save(ms, ImageFormat.Png);
                ms.Position = 0;

                ImageData imageData = ImageDataFactory.Create(ms.ToArray());
                return imageData;
            }

        }

        public static void OpenPDF(string path)
        {
            var psi = new System.Diagnostics.ProcessStartInfo
            {
                FileName = path,
                UseShellExecute = true
            };

            System.Diagnostics.Process.Start(psi);
        }
    }
}
