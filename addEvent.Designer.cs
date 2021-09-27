
namespace Desktop_Organiser
{
    partial class addEvent
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

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.showBtn = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.textTextBox = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.rank = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.text = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.isActive = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // showBtn
            // 
            this.showBtn.Location = new System.Drawing.Point(127, 8);
            this.showBtn.Name = "showBtn";
            this.showBtn.Size = new System.Drawing.Size(77, 33);
            this.showBtn.TabIndex = 5;
            this.showBtn.Text = "Show";
            this.showBtn.UseVisualStyleBackColor = true;
            this.showBtn.Click += new System.EventHandler(this.showBtn_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(3, 11);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(118, 22);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Enter your plans:";
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(616, 149);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(77, 33);
            this.addBtn.TabIndex = 7;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // textTextBox
            // 
            this.textTextBox.Location = new System.Drawing.Point(3, 79);
            this.textTextBox.Multiline = true;
            this.textTextBox.Name = "textTextBox";
            this.textTextBox.Size = new System.Drawing.Size(690, 64);
            this.textTextBox.TabIndex = 8;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.rank,
            this.title,
            this.text,
            this.isActive});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(2, 188);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(693, 165);
            this.listView1.TabIndex = 9;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.Visible = false;
            // 
            // rank
            // 
            this.rank.Text = "Rank";
            this.rank.Width = 134;
            // 
            // title
            // 
            this.title.Text = "Title";
            this.title.Width = 123;
            // 
            // text
            // 
            this.text.Text = "Text";
            this.text.Width = 122;
            // 
            // isActive
            // 
            this.isActive.Text = "isActive";
            this.isActive.Width = 132;
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(127, 54);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(566, 22);
            this.titleTextBox.TabIndex = 10;
            // 
            // addEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.textTextBox);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.showBtn);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "addEvent";
            this.Size = new System.Drawing.Size(699, 365);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button showBtn;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.TextBox textTextBox;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader rank;
        private System.Windows.Forms.ColumnHeader title;
        private System.Windows.Forms.ColumnHeader text;
        private System.Windows.Forms.ColumnHeader isActive;
        private System.Windows.Forms.TextBox titleTextBox;
    }
}
