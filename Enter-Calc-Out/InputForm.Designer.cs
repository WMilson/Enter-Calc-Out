namespace Enter_Calc_Out
{
    partial class InputForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.number1Label = new System.Windows.Forms.Label();
            this.number1TextBox = new System.Windows.Forms.TextBox();
            this.number2Label = new System.Windows.Forms.Label();
            this.number2TextBox = new System.Windows.Forms.TextBox();
            this.sumCheckBox = new System.Windows.Forms.CheckBox();
            this.gcdCheckBox = new System.Windows.Forms.CheckBox();
            this.productCheckBox = new System.Windows.Forms.CheckBox();
            this.okButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // number1Label
            // 
            this.number1Label.AutoSize = true;
            this.number1Label.Location = new System.Drawing.Point(20, 25);
            this.number1Label.Text = "Число 1";
            // 
            // number1TextBox
            // 
            this.number1TextBox.Location = new System.Drawing.Point(100, 22);
            this.number1TextBox.Size = new System.Drawing.Size(150, 23);
            // 
            // number2Label
            // 
            this.number2Label.AutoSize = true;
            this.number2Label.Location = new System.Drawing.Point(20, 60);
            this.number2Label.Text = "Число 2";
            // 
            // number2TextBox
            // 
            this.number2TextBox.Location = new System.Drawing.Point(100, 57);
            this.number2TextBox.Size = new System.Drawing.Size(150, 23);
            // 
            // sumCheckBox
            // 
            this.sumCheckBox.AutoSize = true;
            this.sumCheckBox.Location = new System.Drawing.Point(20, 100);
            this.sumCheckBox.Text = "Сумма";
            // 
            // gcdCheckBox
            // 
            this.gcdCheckBox.AutoSize = true;
            this.gcdCheckBox.Location = new System.Drawing.Point(20, 125);
            this.gcdCheckBox.Text = "НОД";
            // 
            // productCheckBox
            // 
            this.productCheckBox.AutoSize = true;
            this.productCheckBox.Location = new System.Drawing.Point(20, 150);
            this.productCheckBox.Text = "Произведение";
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(100, 185);
            this.okButton.Size = new System.Drawing.Size(120, 30);
            this.okButton.Text = "Ввод";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // InputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 230);
            this.Controls.Add(this.number1Label);
            this.Controls.Add(this.number1TextBox);
            this.Controls.Add(this.number2Label);
            this.Controls.Add(this.number2TextBox);
            this.Controls.Add(this.sumCheckBox);
            this.Controls.Add(this.gcdCheckBox);
            this.Controls.Add(this.productCheckBox);
            this.Controls.Add(this.okButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ввод данных";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label number1Label;
        private System.Windows.Forms.Label number2Label;
        private System.Windows.Forms.TextBox number1TextBox;
        private System.Windows.Forms.TextBox number2TextBox;
        private System.Windows.Forms.CheckBox sumCheckBox;
        private System.Windows.Forms.CheckBox gcdCheckBox;
        private System.Windows.Forms.CheckBox productCheckBox;
        private System.Windows.Forms.Button okButton;
    }
}