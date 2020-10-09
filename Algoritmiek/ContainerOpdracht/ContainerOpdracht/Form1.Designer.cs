namespace ContainerOpdracht
{
    partial class Form1
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
            this.rbCooled = new System.Windows.Forms.RadioButton();
            this.tbLengthShip = new System.Windows.Forms.TextBox();
            this.tbWidthShip = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbQuantity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbWeightContainer = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAddContainer = new System.Windows.Forms.Button();
            this.btnFillShip = new System.Windows.Forms.Button();
            this.lvContainer = new System.Windows.Forms.ListView();
            this.rbNormal = new System.Windows.Forms.RadioButton();
            this.rbImportant = new System.Windows.Forms.RadioButton();
            this.lvShip = new System.Windows.Forms.ListView();
            this.btnMakeShip = new System.Windows.Forms.Button();
            this.tbShipWeight = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ship Propeties";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(259, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Container Properties";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Length";
            // 
            // rbCooled
            // 
            this.rbCooled.AutoSize = true;
            this.rbCooled.Location = new System.Drawing.Point(271, 100);
            this.rbCooled.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbCooled.Name = "rbCooled";
            this.rbCooled.Size = new System.Drawing.Size(73, 21);
            this.rbCooled.TabIndex = 6;
            this.rbCooled.TabStop = true;
            this.rbCooled.Text = "Cooled";
            this.rbCooled.UseVisualStyleBackColor = true;
            // 
            // tbLengthShip
            // 
            this.tbLengthShip.Location = new System.Drawing.Point(36, 52);
            this.tbLengthShip.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbLengthShip.Name = "tbLengthShip";
            this.tbLengthShip.Size = new System.Drawing.Size(100, 22);
            this.tbLengthShip.TabIndex = 8;
            // 
            // tbWidthShip
            // 
            this.tbWidthShip.Location = new System.Drawing.Point(36, 100);
            this.tbWidthShip.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbWidthShip.Name = "tbWidthShip";
            this.tbWidthShip.Size = new System.Drawing.Size(100, 22);
            this.tbWidthShip.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Width";
            // 
            // tbQuantity
            // 
            this.tbQuantity.Location = new System.Drawing.Point(387, 73);
            this.tbQuantity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbQuantity.Name = "tbQuantity";
            this.tbQuantity.Size = new System.Drawing.Size(100, 22);
            this.tbQuantity.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(383, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Quantity";
            // 
            // tbWeightContainer
            // 
            this.tbWeightContainer.Location = new System.Drawing.Point(387, 128);
            this.tbWeightContainer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbWeightContainer.Name = "tbWeightContainer";
            this.tbWeightContainer.Size = new System.Drawing.Size(100, 22);
            this.tbWeightContainer.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(383, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "Container Weight";
            // 
            // btnAddContainer
            // 
            this.btnAddContainer.Location = new System.Drawing.Point(271, 154);
            this.btnAddContainer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddContainer.Name = "btnAddContainer";
            this.btnAddContainer.Size = new System.Drawing.Size(217, 26);
            this.btnAddContainer.TabIndex = 19;
            this.btnAddContainer.Text = "Add Containers";
            this.btnAddContainer.UseVisualStyleBackColor = true;
            this.btnAddContainer.Click += new System.EventHandler(this.AddContainer_Click);
            // 
            // btnFillShip
            // 
            this.btnFillShip.Location = new System.Drawing.Point(34, 220);
            this.btnFillShip.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFillShip.Name = "btnFillShip";
            this.btnFillShip.Size = new System.Drawing.Size(464, 26);
            this.btnFillShip.TabIndex = 20;
            this.btnFillShip.Text = "Fill Ship";
            this.btnFillShip.UseVisualStyleBackColor = true;
            this.btnFillShip.Click += new System.EventHandler(this.btnFillShip_Click);
            // 
            // lvContainer
            // 
            this.lvContainer.HideSelection = false;
            this.lvContainer.Location = new System.Drawing.Point(35, 252);
            this.lvContainer.Margin = new System.Windows.Forms.Padding(4);
            this.lvContainer.Name = "lvContainer";
            this.lvContainer.Size = new System.Drawing.Size(463, 147);
            this.lvContainer.TabIndex = 23;
            this.lvContainer.UseCompatibleStateImageBehavior = false;
            // 
            // rbNormal
            // 
            this.rbNormal.AutoSize = true;
            this.rbNormal.Location = new System.Drawing.Point(271, 73);
            this.rbNormal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbNormal.Name = "rbNormal";
            this.rbNormal.Size = new System.Drawing.Size(74, 21);
            this.rbNormal.TabIndex = 5;
            this.rbNormal.TabStop = true;
            this.rbNormal.Text = "Normal";
            this.rbNormal.UseVisualStyleBackColor = true;
            // 
            // rbImportant
            // 
            this.rbImportant.AutoSize = true;
            this.rbImportant.Location = new System.Drawing.Point(271, 126);
            this.rbImportant.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbImportant.Name = "rbImportant";
            this.rbImportant.Size = new System.Drawing.Size(88, 21);
            this.rbImportant.TabIndex = 24;
            this.rbImportant.TabStop = true;
            this.rbImportant.Text = "Important";
            this.rbImportant.UseVisualStyleBackColor = true;
            // 
            // lvShip
            // 
            this.lvShip.HideSelection = false;
            this.lvShip.Location = new System.Drawing.Point(35, 407);
            this.lvShip.Margin = new System.Windows.Forms.Padding(4);
            this.lvShip.Name = "lvShip";
            this.lvShip.Size = new System.Drawing.Size(463, 147);
            this.lvShip.TabIndex = 25;
            this.lvShip.UseCompatibleStateImageBehavior = false;
            // 
            // btnMakeShip
            // 
            this.btnMakeShip.Location = new System.Drawing.Point(34, 176);
            this.btnMakeShip.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMakeShip.Name = "btnMakeShip";
            this.btnMakeShip.Size = new System.Drawing.Size(102, 26);
            this.btnMakeShip.TabIndex = 26;
            this.btnMakeShip.Text = "Make Ship";
            this.btnMakeShip.UseVisualStyleBackColor = true;
            this.btnMakeShip.Click += new System.EventHandler(this.btnMakeShip_Click);
            // 
            // tbShipWeight
            // 
            this.tbShipWeight.Location = new System.Drawing.Point(36, 150);
            this.tbShipWeight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbShipWeight.Name = "tbShipWeight";
            this.tbShipWeight.Size = new System.Drawing.Size(100, 22);
            this.tbShipWeight.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 17);
            this.label4.TabIndex = 27;
            this.label4.Text = "Ship Weight";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 593);
            this.Controls.Add(this.tbShipWeight);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnMakeShip);
            this.Controls.Add(this.lvShip);
            this.Controls.Add(this.rbImportant);
            this.Controls.Add(this.lvContainer);
            this.Controls.Add(this.btnFillShip);
            this.Controls.Add(this.btnAddContainer);
            this.Controls.Add(this.tbWeightContainer);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbQuantity);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbWidthShip);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbLengthShip);
            this.Controls.Add(this.rbCooled);
            this.Controls.Add(this.rbNormal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbCooled;
        private System.Windows.Forms.TextBox tbLengthShip;
        private System.Windows.Forms.TextBox tbWidthShip;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbQuantity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbWeightContainer;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAddContainer;
        private System.Windows.Forms.Button btnFillShip;
        private System.Windows.Forms.ListView lvContainer;
        private System.Windows.Forms.RadioButton rbNormal;
        private System.Windows.Forms.RadioButton rbImportant;
        private System.Windows.Forms.ListView lvShip;
        private System.Windows.Forms.Button btnMakeShip;
        private System.Windows.Forms.TextBox tbShipWeight;
        private System.Windows.Forms.Label label4;
    }
}
