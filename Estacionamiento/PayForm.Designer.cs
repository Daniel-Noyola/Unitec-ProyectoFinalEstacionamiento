namespace Estacionamiento
{
    partial class PayForm
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
            tableLayoutPanel1 = new TableLayoutPanel();
            label5 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            TableData = new TableLayoutPanel();
            label6 = new Label();
            BtnTickets = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(label5, 0, 4);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(label4, 0, 3);
            tableLayoutPanel1.Location = new Point(12, 69);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(5);
            tableLayoutPanel1.RightToLeft = RightToLeft.Yes;
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Size = new Size(148, 249);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            label5.Location = new Point(87, 206);
            label5.Name = "label5";
            label5.Size = new Size(53, 25);
            label5.TabIndex = 2;
            label5.Text = "Total";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            label1.Location = new Point(86, 16);
            label1.Name = "label1";
            label1.Size = new Size(54, 25);
            label1.TabIndex = 1;
            label1.Text = "Folio";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            label2.Location = new Point(78, 63);
            label2.Name = "label2";
            label2.Size = new Size(62, 25);
            label2.TabIndex = 2;
            label2.Text = "Fecha";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            label3.Location = new Point(15, 110);
            label3.Name = "label3";
            label3.Size = new Size(125, 25);
            label3.TabIndex = 2;
            label3.Text = "Hora Entrada";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            label4.Location = new Point(30, 157);
            label4.Name = "label4";
            label4.Size = new Size(110, 25);
            label4.TabIndex = 2;
            label4.Text = "Hora Salida";
            // 
            // TableData
            // 
            TableData.ColumnCount = 1;
            TableData.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            TableData.Location = new Point(166, 69);
            TableData.Name = "TableData";
            TableData.RowCount = 5;
            TableData.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            TableData.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            TableData.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            TableData.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            TableData.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            TableData.Size = new Size(142, 249);
            TableData.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(75, 29);
            label6.Name = "label6";
            label6.Size = new Size(183, 37);
            label6.TabIndex = 2;
            label6.Text = "Pagar Boleto";
            // 
            // BtnTickets
            // 
            BtnTickets.BackColor = Color.FromArgb(184, 230, 254);
            BtnTickets.FlatStyle = FlatStyle.Popup;
            BtnTickets.Font = new Font("Segoe UI Semibold", 12.25F, FontStyle.Bold);
            BtnTickets.ForeColor = SystemColors.ControlText;
            BtnTickets.Location = new Point(186, 338);
            BtnTickets.Name = "BtnTickets";
            BtnTickets.Size = new Size(122, 33);
            BtnTickets.TabIndex = 3;
            BtnTickets.Text = "Pagar Boleto";
            BtnTickets.UseVisualStyleBackColor = false;
            BtnTickets.Click += BtnTickets_Click;
            // 
            // PayForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(238, 242, 255);
            ClientSize = new Size(340, 392);
            Controls.Add(BtnTickets);
            Controls.Add(label6);
            Controls.Add(TableData);
            Controls.Add(tableLayoutPanel1);
            Name = "PayForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PayForm";
            Load += PayForm_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label5;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TableLayoutPanel TableData;
        private Label label6;
        private Button BtnTickets;
    }
}