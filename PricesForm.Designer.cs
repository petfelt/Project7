
namespace Project4
{
    partial class PricesForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ChocolatePrice = new System.Windows.Forms.TextBox();
            this.VanillaPrice = new System.Windows.Forms.TextBox();
            this.StrawberryPrice = new System.Windows.Forms.TextBox();
            this.SprinklesPrice = new System.Windows.Forms.TextBox();
            this.CherryPrice = new System.Windows.Forms.TextBox();
            this.ChoppedNutsPrice = new System.Windows.Forms.TextBox();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chocolate Price:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vanilla Price:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Strawberry Price:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Sprinkles Price:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Chopped Nuts Price:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Cherry Price:";
            // 
            // ChocolatePrice
            // 
            this.ChocolatePrice.Location = new System.Drawing.Point(130, 19);
            this.ChocolatePrice.Name = "ChocolatePrice";
            this.ChocolatePrice.Size = new System.Drawing.Size(116, 20);
            this.ChocolatePrice.TabIndex = 6;
            // 
            // VanillaPrice
            // 
            this.VanillaPrice.Location = new System.Drawing.Point(130, 54);
            this.VanillaPrice.Name = "VanillaPrice";
            this.VanillaPrice.Size = new System.Drawing.Size(116, 20);
            this.VanillaPrice.TabIndex = 7;
            // 
            // StrawberryPrice
            // 
            this.StrawberryPrice.Location = new System.Drawing.Point(130, 89);
            this.StrawberryPrice.Name = "StrawberryPrice";
            this.StrawberryPrice.Size = new System.Drawing.Size(116, 20);
            this.StrawberryPrice.TabIndex = 8;
            // 
            // SprinklesPrice
            // 
            this.SprinklesPrice.Location = new System.Drawing.Point(130, 124);
            this.SprinklesPrice.Name = "SprinklesPrice";
            this.SprinklesPrice.Size = new System.Drawing.Size(116, 20);
            this.SprinklesPrice.TabIndex = 9;
            // 
            // CherryPrice
            // 
            this.CherryPrice.Location = new System.Drawing.Point(130, 194);
            this.CherryPrice.Name = "CherryPrice";
            this.CherryPrice.Size = new System.Drawing.Size(116, 20);
            this.CherryPrice.TabIndex = 10;
            // 
            // ChoppedNutsPrice
            // 
            this.ChoppedNutsPrice.Location = new System.Drawing.Point(130, 159);
            this.ChoppedNutsPrice.Name = "ChoppedNutsPrice";
            this.ChoppedNutsPrice.Size = new System.Drawing.Size(116, 20);
            this.ChoppedNutsPrice.TabIndex = 11;
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(15, 230);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(231, 36);
            this.SubmitButton.TabIndex = 12;
            this.SubmitButton.Text = "Set Prices";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // PricesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 277);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.ChoppedNutsPrice);
            this.Controls.Add(this.CherryPrice);
            this.Controls.Add(this.SprinklesPrice);
            this.Controls.Add(this.StrawberryPrice);
            this.Controls.Add(this.VanillaPrice);
            this.Controls.Add(this.ChocolatePrice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PricesForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PricesForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ChocolatePrice;
        private System.Windows.Forms.TextBox VanillaPrice;
        private System.Windows.Forms.TextBox StrawberryPrice;
        private System.Windows.Forms.TextBox SprinklesPrice;
        private System.Windows.Forms.TextBox CherryPrice;
        private System.Windows.Forms.TextBox ChoppedNutsPrice;
        private System.Windows.Forms.Button SubmitButton;
    }
}