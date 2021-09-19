
namespace Desktop_Organiser
{
    partial class Form1
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
            this.addEventBtn = new System.Windows.Forms.Button();
            this.editEventBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.menuPnl = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.menuPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(219, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Show your events";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generalToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(699, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // generalToolStripMenuItem
            // 
            this.generalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newEventToolStripMenuItem,
            this.editEventToolStripMenuItem});
            this.generalToolStripMenuItem.Name = "generalToolStripMenuItem";
            this.generalToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
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
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // addEventBtn
            // 
            this.addEventBtn.Location = new System.Drawing.Point(345, 3);
            this.addEventBtn.Name = "addEventBtn";
            this.addEventBtn.Size = new System.Drawing.Size(121, 32);
            this.addEventBtn.TabIndex = 2;
            this.addEventBtn.Text = "Show";
            this.addEventBtn.UseVisualStyleBackColor = true;
            this.addEventBtn.Click += new System.EventHandler(this.addEventBtn_Click);
            // 
            // editEventBtn
            // 
            this.editEventBtn.Location = new System.Drawing.Point(345, 41);
            this.editEventBtn.Name = "editEventBtn";
            this.editEventBtn.Size = new System.Drawing.Size(121, 32);
            this.editEventBtn.TabIndex = 3;
            this.editEventBtn.Text = "Edit";
            this.editEventBtn.UseVisualStyleBackColor = true;
            this.editEventBtn.Click += new System.EventHandler(this.editEventBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(236, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Edit your event";
            // 
            // menuPnl
            // 
            this.menuPnl.Controls.Add(this.addEventBtn);
            this.menuPnl.Controls.Add(this.label2);
            this.menuPnl.Controls.Add(this.label1);
            this.menuPnl.Controls.Add(this.editEventBtn);
            this.menuPnl.Location = new System.Drawing.Point(0, 31);
            this.menuPnl.Name = "menuPnl";
            this.menuPnl.Size = new System.Drawing.Size(699, 125);
            this.menuPnl.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 396);
            this.Controls.Add(this.menuPnl);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
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
        private System.Windows.Forms.Button addEventBtn;
        private System.Windows.Forms.Button editEventBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel menuPnl;
    }
}

