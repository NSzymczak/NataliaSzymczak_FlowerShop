
namespace Lab_NataliaSzymczak
{
    partial class FlowerShop
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
            this.buttonFloristry = new System.Windows.Forms.Button();
            this.buttonDecoration = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonView = new System.Windows.Forms.Button();
            this.buttonManagement = new System.Windows.Forms.Button();
            this.buttonSorting = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonFloristry
            // 
            this.buttonFloristry.Location = new System.Drawing.Point(65, 165);
            this.buttonFloristry.Name = "buttonFloristry";
            this.buttonFloristry.Size = new System.Drawing.Size(166, 44);
            this.buttonFloristry.TabIndex = 0;
            this.buttonFloristry.Text = "Florystyke";
            this.buttonFloristry.UseVisualStyleBackColor = true;
            this.buttonFloristry.Click += new System.EventHandler(this.ButtonFloristry_Click);
            // 
            // buttonDecoration
            // 
            this.buttonDecoration.Location = new System.Drawing.Point(293, 164);
            this.buttonDecoration.Name = "buttonDecoration";
            this.buttonDecoration.Size = new System.Drawing.Size(172, 45);
            this.buttonDecoration.TabIndex = 1;
            this.buttonDecoration.Text = "Artykuł dekoracyjny";
            this.buttonDecoration.UseVisualStyleBackColor = true;
            this.buttonDecoration.Click += new System.EventHandler(this.ButtonDecoration_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(217, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Zamówienia:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gabriola", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(80, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(395, 88);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kwiaciarnia Internetowa";
            // 
            // buttonView
            // 
            this.buttonView.Location = new System.Drawing.Point(65, 227);
            this.buttonView.Name = "buttonView";
            this.buttonView.Size = new System.Drawing.Size(166, 45);
            this.buttonView.TabIndex = 4;
            this.buttonView.Text = "Przegląd zamówień";
            this.buttonView.UseVisualStyleBackColor = true;
            this.buttonView.Click += new System.EventHandler(this.buttonView_Click);
            // 
            // buttonManagement
            // 
            this.buttonManagement.Location = new System.Drawing.Point(293, 227);
            this.buttonManagement.Name = "buttonManagement";
            this.buttonManagement.Size = new System.Drawing.Size(172, 45);
            this.buttonManagement.TabIndex = 5;
            this.buttonManagement.Text = "Zarządzanie zamówieniami";
            this.buttonManagement.UseVisualStyleBackColor = true;
            this.buttonManagement.Click += new System.EventHandler(this.buttonManagement_Click);
            // 
            // buttonSorting
            // 
            this.buttonSorting.Location = new System.Drawing.Point(65, 289);
            this.buttonSorting.Name = "buttonSorting";
            this.buttonSorting.Size = new System.Drawing.Size(166, 36);
            this.buttonSorting.TabIndex = 6;
            this.buttonSorting.Text = "Sortowanie";
            this.buttonSorting.UseVisualStyleBackColor = true;
            this.buttonSorting.Click += new System.EventHandler(this.buttonSorting_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(293, 289);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(176, 36);
            this.buttonSearch.TabIndex = 7;
            this.buttonSearch.Text = "Wyszukiwanie";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // FlowerShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 351);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonSorting);
            this.Controls.Add(this.buttonManagement);
            this.Controls.Add(this.buttonView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDecoration);
            this.Controls.Add(this.buttonFloristry);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FlowerShop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FlowerShop";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonFloristry;
        private System.Windows.Forms.Button buttonDecoration;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonView;
        private System.Windows.Forms.Button buttonManagement;
        private System.Windows.Forms.Button buttonSorting;
        private System.Windows.Forms.Button buttonSearch;
    }
}

