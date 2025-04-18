namespace Estacionamiento
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            BoxGenTicket = new GroupBox();
            BtnGenTicket = new Button();
            TimerDisplay = new TextBox();
            LabelWelcome = new Label();
            MainTimer = new System.Windows.Forms.Timer(components);
            BoxAdmin = new GroupBox();
            BtnOpenFolder = new Button();
            BtnTickets = new Button();
            BoxGenTicket.SuspendLayout();
            BoxAdmin.SuspendLayout();
            SuspendLayout();
            // 
            // BoxGenTicket
            // 
            BoxGenTicket.Controls.Add(BtnGenTicket);
            BoxGenTicket.Controls.Add(TimerDisplay);
            BoxGenTicket.Controls.Add(LabelWelcome);
            BoxGenTicket.Dock = DockStyle.Left;
            BoxGenTicket.Location = new Point(40, 20);
            BoxGenTicket.Name = "BoxGenTicket";
            BoxGenTicket.Size = new Size(380, 410);
            BoxGenTicket.TabIndex = 0;
            BoxGenTicket.TabStop = false;
            BoxGenTicket.Text = "Generar Ticket";
            // 
            // BtnGenTicket
            // 
            BtnGenTicket.BackColor = Color.FromArgb(184, 230, 254);
            BtnGenTicket.FlatStyle = FlatStyle.Popup;
            BtnGenTicket.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnGenTicket.ForeColor = SystemColors.ControlText;
            BtnGenTicket.Location = new Point(123, 284);
            BtnGenTicket.Name = "BtnGenTicket";
            BtnGenTicket.Size = new Size(154, 56);
            BtnGenTicket.TabIndex = 2;
            BtnGenTicket.Text = "Generar Ticket";
            BtnGenTicket.UseVisualStyleBackColor = false;
            BtnGenTicket.Click += BtnGenTicket_Click;
            // 
            // TimerDisplay
            // 
            TimerDisplay.BackColor = Color.FromArgb(238, 242, 255);
            TimerDisplay.Enabled = false;
            TimerDisplay.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TimerDisplay.Location = new Point(140, 175);
            TimerDisplay.Name = "TimerDisplay";
            TimerDisplay.ReadOnly = true;
            TimerDisplay.Size = new Size(120, 29);
            TimerDisplay.TabIndex = 1;
            TimerDisplay.TextAlign = HorizontalAlignment.Center;
            // 
            // LabelWelcome
            // 
            LabelWelcome.AutoSize = true;
            LabelWelcome.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelWelcome.Location = new Point(106, 82);
            LabelWelcome.Name = "LabelWelcome";
            LabelWelcome.Size = new Size(188, 45);
            LabelWelcome.TabIndex = 0;
            LabelWelcome.Text = "Bienvenido";
            // 
            // MainTimer
            // 
            MainTimer.Tick += MainTimer_Tick_1;
            // 
            // BoxAdmin
            // 
            BoxAdmin.Controls.Add(BtnOpenFolder);
            BoxAdmin.Controls.Add(BtnTickets);
            BoxAdmin.Dock = DockStyle.Fill;
            BoxAdmin.Location = new Point(420, 20);
            BoxAdmin.Name = "BoxAdmin";
            BoxAdmin.Size = new Size(340, 410);
            BoxAdmin.TabIndex = 1;
            BoxAdmin.TabStop = false;
            BoxAdmin.Text = "Administrar";
            // 
            // BtnOpenFolder
            // 
            BtnOpenFolder.BackColor = Color.FromArgb(184, 230, 254);
            BtnOpenFolder.FlatStyle = FlatStyle.Popup;
            BtnOpenFolder.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnOpenFolder.ForeColor = SystemColors.ControlText;
            BtnOpenFolder.Location = new Point(98, 238);
            BtnOpenFolder.Name = "BtnOpenFolder";
            BtnOpenFolder.Size = new Size(154, 56);
            BtnOpenFolder.TabIndex = 2;
            BtnOpenFolder.Text = "Abrir Carpeta";
            BtnOpenFolder.UseVisualStyleBackColor = false;
            BtnOpenFolder.Click += BtnOpenFolder_Click;
            // 
            // BtnTickets
            // 
            BtnTickets.BackColor = Color.FromArgb(184, 230, 254);
            BtnTickets.FlatStyle = FlatStyle.Popup;
            BtnTickets.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnTickets.ForeColor = SystemColors.ControlText;
            BtnTickets.Location = new Point(98, 113);
            BtnTickets.Name = "BtnTickets";
            BtnTickets.Size = new Size(154, 56);
            BtnTickets.TabIndex = 2;
            BtnTickets.Text = "Lista de Tickets";
            BtnTickets.UseVisualStyleBackColor = false;
            BtnTickets.Click += BtnTickets_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(238, 242, 255);
            ClientSize = new Size(800, 450);
            Controls.Add(BoxAdmin);
            Controls.Add(BoxGenTicket);
            Name = "Main";
            Padding = new Padding(40, 20, 40, 20);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio";
            FormClosing += Main_FormClosing;
            Load += Main_Load;
            BoxGenTicket.ResumeLayout(false);
            BoxGenTicket.PerformLayout();
            BoxAdmin.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox BoxGenTicket;
        private TextBox TimerDisplay;
        private Label LabelWelcome;
        private System.Windows.Forms.Timer MainTimer;
        private Button BtnGenTicket;
        private GroupBox BoxAdmin;
        private Button BtnTickets;
        private Button BtnOpenFolder;
    }
}
