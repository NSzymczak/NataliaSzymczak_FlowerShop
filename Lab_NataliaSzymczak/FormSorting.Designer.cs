
namespace Lab_NataliaSzymczak
{
    partial class Sortowanie
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.recipientSurname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.recipientName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DeliveryDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DateofPucharse = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Allcost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonSortingUp = new System.Windows.Forms.Button();
            this.buttonSortingDown = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.recipientSurname,
            this.recipientName,
            this.DeliveryDate,
            this.DateofPucharse,
            this.Allcost});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 32);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(501, 329);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // recipientSurname
            // 
            this.recipientSurname.Text = "Nazwisko odbiorcy";
            this.recipientSurname.Width = 96;
            // 
            // recipientName
            // 
            this.recipientName.Text = "Imię odbiorcy";
            this.recipientName.Width = 105;
            // 
            // DeliveryDate
            // 
            this.DeliveryDate.Text = "Data dostawy";
            this.DeliveryDate.Width = 111;
            // 
            // DateofPucharse
            // 
            this.DateofPucharse.Text = "Data zamówienia";
            this.DateofPucharse.Width = 120;
            // 
            // Allcost
            // 
            this.Allcost.Text = "Cena zamówienia";
            // 
            // buttonSortingUp
            // 
            this.buttonSortingUp.Location = new System.Drawing.Point(325, 367);
            this.buttonSortingUp.Name = "buttonSortingUp";
            this.buttonSortingUp.Size = new System.Drawing.Size(188, 61);
            this.buttonSortingUp.TabIndex = 5;
            this.buttonSortingUp.Text = "Posortuj rosnąco";
            this.buttonSortingUp.UseVisualStyleBackColor = true;
            this.buttonSortingUp.Click += new System.EventHandler(this.buttonSortingUp_Click);
            // 
            // buttonSortingDown
            // 
            this.buttonSortingDown.Location = new System.Drawing.Point(12, 367);
            this.buttonSortingDown.Name = "buttonSortingDown";
            this.buttonSortingDown.Size = new System.Drawing.Size(188, 61);
            this.buttonSortingDown.TabIndex = 4;
            this.buttonSortingDown.Text = "Posortuj malejąco";
            this.buttonSortingDown.UseVisualStyleBackColor = true;
            this.buttonSortingDown.Click += new System.EventHandler(this.buttonSortingDown_Click);
            // 
            // Sortowanie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 450);
            this.Controls.Add(this.buttonSortingUp);
            this.Controls.Add(this.buttonSortingDown);
            this.Controls.Add(this.listView1);
            this.Name = "Sortowanie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSorting";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader recipientSurname;
        private System.Windows.Forms.ColumnHeader recipientName;
        private System.Windows.Forms.ColumnHeader DeliveryDate;
        private System.Windows.Forms.ColumnHeader DateofPucharse;
        private System.Windows.Forms.Button buttonSortingUp;
        private System.Windows.Forms.Button buttonSortingDown;
        private System.Windows.Forms.ColumnHeader Allcost;
    }
}