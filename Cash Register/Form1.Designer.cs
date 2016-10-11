namespace Cash_Register
{
    partial class cashRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cashRegister));
            this.titleLabel = new System.Windows.Forms.Label();
            this.pizzaLabel1 = new System.Windows.Forms.Label();
            this.cheesePizza = new System.Windows.Forms.Label();
            this.canadianPizza = new System.Windows.Forms.Label();
            this.subtotal = new System.Windows.Forms.Label();
            this.calculateSubtotal = new System.Windows.Forms.Button();
            this.totalButton = new System.Windows.Forms.Button();
            this.totalText = new System.Windows.Forms.Label();
            this.canadianInput = new System.Windows.Forms.TextBox();
            this.textInput = new System.Windows.Forms.TextBox();
            this.cheeseInput = new System.Windows.Forms.TextBox();
            this.subtotalOutput = new System.Windows.Forms.Label();
            this.totalOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Palatino Linotype", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.titleLabel.Location = new System.Drawing.Point(8, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(316, 50);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Joe\'s Pizza Depot";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pizzaLabel1
            // 
            this.pizzaLabel1.AutoSize = true;
            this.pizzaLabel1.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pizzaLabel1.Location = new System.Drawing.Point(12, 72);
            this.pizzaLabel1.Name = "pizzaLabel1";
            this.pizzaLabel1.Size = new System.Drawing.Size(190, 26);
            this.pizzaLabel1.TabIndex = 1;
            this.pizzaLabel1.Text = "PEPPERONI PIZZA";
            // 
            // cheesePizza
            // 
            this.cheesePizza.AutoSize = true;
            this.cheesePizza.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cheesePizza.Location = new System.Drawing.Point(12, 119);
            this.cheesePizza.Name = "cheesePizza";
            this.cheesePizza.Size = new System.Drawing.Size(155, 26);
            this.cheesePizza.TabIndex = 2;
            this.cheesePizza.Text = "CHEESE PIZZA";
            // 
            // canadianPizza
            // 
            this.canadianPizza.AutoSize = true;
            this.canadianPizza.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.canadianPizza.Location = new System.Drawing.Point(12, 167);
            this.canadianPizza.Name = "canadianPizza";
            this.canadianPizza.Size = new System.Drawing.Size(191, 26);
            this.canadianPizza.TabIndex = 3;
            this.canadianPizza.Text = "CANADIAN PIZZA";
            // 
            // subtotal
            // 
            this.subtotal.AutoSize = true;
            this.subtotal.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtotal.Location = new System.Drawing.Point(12, 291);
            this.subtotal.Name = "subtotal";
            this.subtotal.Size = new System.Drawing.Size(120, 26);
            this.subtotal.TabIndex = 4;
            this.subtotal.Text = "SUBTOTAL";
            // 
            // calculateSubtotal
            // 
            this.calculateSubtotal.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.calculateSubtotal.FlatAppearance.BorderSize = 2;
            this.calculateSubtotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calculateSubtotal.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateSubtotal.Location = new System.Drawing.Point(228, 223);
            this.calculateSubtotal.Name = "calculateSubtotal";
            this.calculateSubtotal.Size = new System.Drawing.Size(162, 36);
            this.calculateSubtotal.TabIndex = 5;
            this.calculateSubtotal.Text = "Calculate Subtotal";
            this.calculateSubtotal.UseVisualStyleBackColor = true;
            // 
            // totalButton
            // 
            this.totalButton.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.totalButton.FlatAppearance.BorderSize = 2;
            this.totalButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.totalButton.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalButton.Location = new System.Drawing.Point(228, 343);
            this.totalButton.Name = "totalButton";
            this.totalButton.Size = new System.Drawing.Size(162, 36);
            this.totalButton.TabIndex = 6;
            this.totalButton.Text = "Calculate Total";
            this.totalButton.UseVisualStyleBackColor = true;
            // 
            // totalText
            // 
            this.totalText.AutoSize = true;
            this.totalText.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalText.Location = new System.Drawing.Point(12, 417);
            this.totalText.Name = "totalText";
            this.totalText.Size = new System.Drawing.Size(80, 26);
            this.totalText.TabIndex = 7;
            this.totalText.Text = "TOTAL";
            // 
            // canadianInput
            // 
            this.canadianInput.Location = new System.Drawing.Point(228, 167);
            this.canadianInput.Multiline = true;
            this.canadianInput.Name = "canadianInput";
            this.canadianInput.Size = new System.Drawing.Size(162, 26);
            this.canadianInput.TabIndex = 8;
            this.canadianInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textInput
            // 
            this.textInput.Location = new System.Drawing.Point(228, 72);
            this.textInput.Multiline = true;
            this.textInput.Name = "textInput";
            this.textInput.Size = new System.Drawing.Size(162, 26);
            this.textInput.TabIndex = 9;
            this.textInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cheeseInput
            // 
            this.cheeseInput.Location = new System.Drawing.Point(228, 119);
            this.cheeseInput.Multiline = true;
            this.cheeseInput.Name = "cheeseInput";
            this.cheeseInput.Size = new System.Drawing.Size(162, 26);
            this.cheeseInput.TabIndex = 10;
            this.cheeseInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // subtotalOutput
            // 
            this.subtotalOutput.AutoSize = true;
            this.subtotalOutput.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtotalOutput.Location = new System.Drawing.Point(245, 291);
            this.subtotalOutput.Name = "subtotalOutput";
            this.subtotalOutput.Size = new System.Drawing.Size(0, 26);
            this.subtotalOutput.TabIndex = 11;
            // 
            // totalOutput
            // 
            this.totalOutput.AutoSize = true;
            this.totalOutput.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalOutput.Location = new System.Drawing.Point(245, 417);
            this.totalOutput.Name = "totalOutput";
            this.totalOutput.Size = new System.Drawing.Size(0, 26);
            this.totalOutput.TabIndex = 12;
            // 
            // cashRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.ClientSize = new System.Drawing.Size(850, 671);
            this.Controls.Add(this.totalOutput);
            this.Controls.Add(this.subtotalOutput);
            this.Controls.Add(this.cheeseInput);
            this.Controls.Add(this.textInput);
            this.Controls.Add(this.canadianInput);
            this.Controls.Add(this.totalText);
            this.Controls.Add(this.totalButton);
            this.Controls.Add(this.calculateSubtotal);
            this.Controls.Add(this.subtotal);
            this.Controls.Add(this.canadianPizza);
            this.Controls.Add(this.cheesePizza);
            this.Controls.Add(this.pizzaLabel1);
            this.Controls.Add(this.titleLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "cashRegister";
            this.Text = "Joe\'s Pizza Depot             ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label pizzaLabel1;
        private System.Windows.Forms.Label cheesePizza;
        private System.Windows.Forms.Label canadianPizza;
        private System.Windows.Forms.Label subtotal;
        private System.Windows.Forms.Button calculateSubtotal;
        private System.Windows.Forms.Button totalButton;
        private System.Windows.Forms.Label totalText;
        private System.Windows.Forms.TextBox canadianInput;
        private System.Windows.Forms.TextBox textInput;
        private System.Windows.Forms.TextBox cheeseInput;
        private System.Windows.Forms.Label subtotalOutput;
        private System.Windows.Forms.Label totalOutput;
    }
}

