namespace Estacionamiento
{
    partial class TicketsList
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
            TableLayout = new TableLayoutPanel();
            label3 = new Label();
            label2 = new Label();
            LblFolio = new Label();
            label1 = new Label();
            Title = new Label();
            TableLayout.SuspendLayout();
            SuspendLayout();
            // 
            // TableLayout
            // 
            TableLayout.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            TableLayout.ColumnCount = 4;
            TableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 56F));
            TableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            TableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 85F));
            TableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 115F));
            TableLayout.Controls.Add(label3, 3, 0);
            TableLayout.Controls.Add(label2, 2, 0);
            TableLayout.Controls.Add(LblFolio, 0, 0);
            TableLayout.Controls.Add(label1, 1, 0);
            TableLayout.Location = new Point(0, 41);
            TableLayout.Name = "TableLayout";
            TableLayout.Padding = new Padding(10);
            TableLayout.RowCount = 1;
            TableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            TableLayout.Size = new Size(565, 411);
            TableLayout.TabIndex = 0;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(442, 11);
            label3.Name = "label3";
            label3.Size = new Size(109, 23);
            label3.TabIndex = 3;
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(356, 11);
            label2.Name = "label2";
            label2.Size = new Size(79, 23);
            label2.TabIndex = 2;
            label2.Text = "Estado";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LblFolio
            // 
            LblFolio.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblFolio.Location = new Point(14, 11);
            LblFolio.Name = "LblFolio";
            LblFolio.Size = new Size(50, 23);
            LblFolio.TabIndex = 0;
            LblFolio.Text = "Folio";
            LblFolio.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(71, 11);
            label1.Name = "label1";
            label1.Size = new Size(263, 23);
            label1.TabIndex = 1;
            label1.Text = "Fecha Registro";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Title
            // 
            Title.Dock = DockStyle.Top;
            Title.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Title.Location = new Point(0, 0);
            Title.Name = "Title";
            Title.Size = new Size(565, 38);
            Title.TabIndex = 1;
            Title.Text = "Lista de Tickets";
            Title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TicketsList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(238, 242, 255);
            ClientSize = new Size(565, 450);
            Controls.Add(Title);
            Controls.Add(TableLayout);
            Name = "TicketsList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TicketsList";
            Load += TicketsList_Load;
            TableLayout.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel TableLayout;
        private Label LblFolio;
        private Label label1;
        private Label Title;
        private Label label2;
        private Label label3;
    }
}