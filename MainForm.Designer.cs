
namespace Desktop_Organiser
{
    partial class MainForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.generalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newEventToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oneDayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.weekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monthToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editEventToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showEventBtn = new System.Windows.Forms.Button();
            this.menuPnl = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.addEventBtn = new System.Windows.Forms.Button();
            this.quitBtn = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.menuPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(231, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Show all events";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generalToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(699, 30);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // generalToolStripMenuItem
            // 
            this.generalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newEventToolStripMenuItem,
            this.editEventToolStripMenuItem});
            this.generalToolStripMenuItem.Name = "generalToolStripMenuItem";
            this.generalToolStripMenuItem.Size = new System.Drawing.Size(74, 26);
            this.generalToolStripMenuItem.Text = "General";
            // 
            // newEventToolStripMenuItem
            // 
            this.newEventToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oneDayToolStripMenuItem,
            this.weekToolStripMenuItem,
            this.monthToolStripMenuItem,
            this.yearToolStripMenuItem});
            this.newEventToolStripMenuItem.Name = "newEventToolStripMenuItem";
            this.newEventToolStripMenuItem.Size = new System.Drawing.Size(162, 26);
            this.newEventToolStripMenuItem.Text = "New Event";
            // 
            // oneDayToolStripMenuItem
            // 
            this.oneDayToolStripMenuItem.Name = "oneDayToolStripMenuItem";
            this.oneDayToolStripMenuItem.Size = new System.Drawing.Size(135, 26);
            this.oneDayToolStripMenuItem.Text = "Day";
            // 
            // weekToolStripMenuItem
            // 
            this.weekToolStripMenuItem.Name = "weekToolStripMenuItem";
            this.weekToolStripMenuItem.Size = new System.Drawing.Size(135, 26);
            this.weekToolStripMenuItem.Text = "Week";
            // 
            // monthToolStripMenuItem
            // 
            this.monthToolStripMenuItem.Name = "monthToolStripMenuItem";
            this.monthToolStripMenuItem.Size = new System.Drawing.Size(135, 26);
            this.monthToolStripMenuItem.Text = "Month";
            // 
            // yearToolStripMenuItem
            // 
            this.yearToolStripMenuItem.Name = "yearToolStripMenuItem";
            this.yearToolStripMenuItem.Size = new System.Drawing.Size(135, 26);
            this.yearToolStripMenuItem.Text = "Year";
            // 
            // editEventToolStripMenuItem
            // 
            this.editEventToolStripMenuItem.Name = "editEventToolStripMenuItem";
            this.editEventToolStripMenuItem.Size = new System.Drawing.Size(162, 26);
            this.editEventToolStripMenuItem.Text = "Edit Event";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 26);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // showEventBtn
            // 
            this.showEventBtn.Location = new System.Drawing.Point(345, 3);
            this.showEventBtn.Name = "showEventBtn";
            this.showEventBtn.Size = new System.Drawing.Size(121, 32);
            this.showEventBtn.TabIndex = 2;
            this.showEventBtn.Text = "Show";
            this.showEventBtn.UseVisualStyleBackColor = true;
            this.showEventBtn.Click += new System.EventHandler(this.showEventBtn_Click);
            // 
            // menuPnl
            // 
            this.menuPnl.Controls.Add(this.label3);
            this.menuPnl.Controls.Add(this.addEventBtn);
            this.menuPnl.Controls.Add(this.showEventBtn);
            this.menuPnl.Controls.Add(this.label1);
            this.menuPnl.Location = new System.Drawing.Point(0, 31);
            this.menuPnl.Name = "menuPnl";
            this.menuPnl.Size = new System.Drawing.Size(699, 125);
            this.menuPnl.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(231, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Add new events";
            // 
            // addEventBtn
            // 
            this.addEventBtn.Location = new System.Drawing.Point(345, 41);
            this.addEventBtn.Name = "addEventBtn";
            this.addEventBtn.Size = new System.Drawing.Size(121, 32);
            this.addEventBtn.TabIndex = 5;
            this.addEventBtn.Text = "Add";
            this.addEventBtn.UseVisualStyleBackColor = true;
            this.addEventBtn.Click += new System.EventHandler(this.addEventBtn_Click);
            // 
            // quitBtn
            // 
            this.quitBtn.Location = new System.Drawing.Point(569, 402);
            this.quitBtn.Name = "quitBtn";
            this.quitBtn.Size = new System.Drawing.Size(121, 32);
            this.quitBtn.TabIndex = 6;
            this.quitBtn.Text = "Quit";
            this.quitBtn.UseVisualStyleBackColor = true;
            this.quitBtn.Click += new System.EventHandler(this.quitBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 443);
            this.Controls.Add(this.quitBtn);
            this.Controls.Add(this.menuPnl);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Organiser";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.menuPnl.ResumeLayout(false);
            this.menuPnl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem generalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newEventToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oneDayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem weekToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem monthToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editEventToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Button showEventBtn;
        private System.Windows.Forms.Panel menuPnl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button addEventBtn;
        private System.Windows.Forms.Button quitBtn;
    }
}

