namespace RieltorKurs.Forms
{
    partial class RieltorForm
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
            this.buttonClients = new System.Windows.Forms.Button();
            this.buttonPlacement = new System.Windows.Forms.Button();
            this.buttonDeal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // labelNameForm
            // 
            this.labelNameForm.Text = "Форма риелтора";
            // 
            // buttonClients
            // 
            this.buttonClients.Location = new System.Drawing.Point(142, 267);
            this.buttonClients.Name = "buttonClients";
            this.buttonClients.Size = new System.Drawing.Size(169, 94);
            this.buttonClients.TabIndex = 5;
            this.buttonClients.Text = "Клиенты";
            this.buttonClients.UseVisualStyleBackColor = true;
            this.buttonClients.Click += new System.EventHandler(this.buttonClients_Click);
            // 
            // buttonPlacement
            // 
            this.buttonPlacement.Location = new System.Drawing.Point(652, 267);
            this.buttonPlacement.Name = "buttonPlacement";
            this.buttonPlacement.Size = new System.Drawing.Size(169, 94);
            this.buttonPlacement.TabIndex = 5;
            this.buttonPlacement.Text = "Недвижимость";
            this.buttonPlacement.UseVisualStyleBackColor = true;
            this.buttonPlacement.Click += new System.EventHandler(this.buttonPlacement_Click);
            // 
            // buttonDeal
            // 
            this.buttonDeal.Location = new System.Drawing.Point(395, 267);
            this.buttonDeal.Name = "buttonDeal";
            this.buttonDeal.Size = new System.Drawing.Size(169, 94);
            this.buttonDeal.TabIndex = 5;
            this.buttonDeal.Text = "Сделки";
            this.buttonDeal.UseVisualStyleBackColor = true;
            this.buttonDeal.Click += new System.EventHandler(this.buttonDeal_Click);
            // 
            // RieltorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 496);
            this.Controls.Add(this.buttonPlacement);
            this.Controls.Add(this.buttonDeal);
            this.Controls.Add(this.buttonClients);
            this.Margin = new System.Windows.Forms.Padding(8);
            this.Name = "RieltorForm";
            this.Text = "RieltorForm";
            this.Load += new System.EventHandler(this.RieltorForm_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.buttonBack, 0);
            this.Controls.SetChildIndex(this.pictureBoxIcon, 0);
            this.Controls.SetChildIndex(this.labelNameForm, 0);
            this.Controls.SetChildIndex(this.labelUserData, 0);
            this.Controls.SetChildIndex(this.buttonClients, 0);
            this.Controls.SetChildIndex(this.buttonDeal, 0);
            this.Controls.SetChildIndex(this.buttonPlacement, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonClients;
        private System.Windows.Forms.Button buttonPlacement;
        private System.Windows.Forms.Button buttonDeal;
    }
}