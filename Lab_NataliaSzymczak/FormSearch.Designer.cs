
namespace Lab_NataliaSzymczak
{
    partial class FormSearch
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxName = new System.Windows.Forms.CheckBox();
            this.checkBoxPrice = new System.Windows.Forms.CheckBox();
            this.numericUpDownTo = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownFrom = new System.Windows.Forms.NumericUpDown();
            this.labelName = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.labelDelivery = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.checkBoxDelivery = new System.Windows.Forms.CheckBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.recipientSurname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.recipientName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DeliveryDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DateofPucharse = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Allcost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFrom)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(453, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 17);
            this.label3.TabIndex = 39;
            this.label3.Text = "do";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(452, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 17);
            this.label4.TabIndex = 38;
            this.label4.Text = "od";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(453, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 17);
            this.label2.TabIndex = 37;
            this.label2.Text = "do";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(452, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 17);
            this.label1.TabIndex = 36;
            this.label1.Text = "od";
            // 
            // checkBoxName
            // 
            this.checkBoxName.AutoSize = true;
            this.checkBoxName.Location = new System.Drawing.Point(727, 254);
            this.checkBoxName.Name = "checkBoxName";
            this.checkBoxName.Size = new System.Drawing.Size(90, 21);
            this.checkBoxName.TabIndex = 35;
            this.checkBoxName.Text = "Aktywne?";
            this.checkBoxName.UseVisualStyleBackColor = true;
            // 
            // checkBoxPrice
            // 
            this.checkBoxPrice.AutoSize = true;
            this.checkBoxPrice.Location = new System.Drawing.Point(727, 169);
            this.checkBoxPrice.Name = "checkBoxPrice";
            this.checkBoxPrice.Size = new System.Drawing.Size(90, 21);
            this.checkBoxPrice.TabIndex = 34;
            this.checkBoxPrice.Text = "Aktywne?";
            this.checkBoxPrice.UseVisualStyleBackColor = true;
            // 
            // numericUpDownTo
            // 
            this.numericUpDownTo.Location = new System.Drawing.Point(483, 186);
            this.numericUpDownTo.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownTo.Name = "numericUpDownTo";
            this.numericUpDownTo.Size = new System.Drawing.Size(200, 22);
            this.numericUpDownTo.TabIndex = 33;
            // 
            // numericUpDownFrom
            // 
            this.numericUpDownFrom.Location = new System.Drawing.Point(483, 158);
            this.numericUpDownFrom.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownFrom.Name = "numericUpDownFrom";
            this.numericUpDownFrom.Size = new System.Drawing.Size(200, 22);
            this.numericUpDownFrom.TabIndex = 32;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(483, 221);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(125, 17);
            this.labelName.TabIndex = 31;
            this.labelName.Text = "Nazwisko odbiorcy";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(483, 137);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(118, 17);
            this.labelPrice.TabIndex = 30;
            this.labelPrice.Text = "Cena zamówienia";
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.Location = new System.Drawing.Point(483, 99);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerTo.TabIndex = 29;
            this.dateTimePickerTo.Value = new System.DateTime(2021, 6, 13, 0, 0, 0, 0);
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.Location = new System.Drawing.Point(483, 71);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerFrom.TabIndex = 28;
            this.dateTimePickerFrom.Value = new System.DateTime(2021, 6, 13, 0, 0, 0, 0);
            // 
            // labelDelivery
            // 
            this.labelDelivery.AutoSize = true;
            this.labelDelivery.Location = new System.Drawing.Point(483, 27);
            this.labelDelivery.Name = "labelDelivery";
            this.labelDelivery.Size = new System.Drawing.Size(93, 17);
            this.labelDelivery.TabIndex = 27;
            this.labelDelivery.Text = "Data dostawy";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(486, 253);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(197, 22);
            this.textBoxName.TabIndex = 26;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(527, 332);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(141, 40);
            this.buttonSearch.TabIndex = 25;
            this.buttonSearch.Text = "Szukaj";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // checkBoxDelivery
            // 
            this.checkBoxDelivery.AutoSize = true;
            this.checkBoxDelivery.Location = new System.Drawing.Point(727, 82);
            this.checkBoxDelivery.Name = "checkBoxDelivery";
            this.checkBoxDelivery.Size = new System.Drawing.Size(90, 21);
            this.checkBoxDelivery.TabIndex = 24;
            this.checkBoxDelivery.Text = "Aktywne?";
            this.checkBoxDelivery.UseVisualStyleBackColor = true;
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
            this.listView1.Size = new System.Drawing.Size(434, 373);
            this.listView1.TabIndex = 40;
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
            // FormSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 442);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBoxName);
            this.Controls.Add(this.checkBoxPrice);
            this.Controls.Add(this.numericUpDownTo);
            this.Controls.Add(this.numericUpDownFrom);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.dateTimePickerTo);
            this.Controls.Add(this.dateTimePickerFrom);
            this.Controls.Add(this.labelDelivery);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.checkBoxDelivery);
            this.Name = "FormSearch";
            this.Text = "FormSearch";
            this.Load += new System.EventHandler(this.FormSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFrom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxName;
        private System.Windows.Forms.CheckBox checkBoxPrice;
        private System.Windows.Forms.NumericUpDown numericUpDownTo;
        private System.Windows.Forms.NumericUpDown numericUpDownFrom;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.Label labelDelivery;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.CheckBox checkBoxDelivery;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader recipientSurname;
        private System.Windows.Forms.ColumnHeader recipientName;
        private System.Windows.Forms.ColumnHeader DeliveryDate;
        private System.Windows.Forms.ColumnHeader DateofPucharse;
        private System.Windows.Forms.ColumnHeader Allcost;
    }
}