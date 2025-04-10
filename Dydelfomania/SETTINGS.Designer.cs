namespace Dydelfomania
{
    partial class SETTINGS
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
            checkBox1 = new CheckBox();
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Checked = true;
            checkBox1.CheckState = CheckState.Checked;
            checkBox1.Location = new Point(156, 133);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(81, 19);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "Krokodyl ?";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // button1
            // 
            button1.Location = new Point(12, 170);
            button1.Name = "button1";
            button1.Size = new Size(240, 23);
            button1.TabIndex = 1;
            button1.Text = "DONE";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(54, 53);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(42, 23);
            textBox1.TabIndex = 2;
            textBox1.Text = "3";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(152, 37);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 3;
            textBox2.Text = "1";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(152, 95);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 4;
            textBox3.Text = "0";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(54, 111);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(42, 23);
            textBox4.TabIndex = 5;
            textBox4.Text = "3";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 56);
            label1.Name = "label1";
            label1.Size = new Size(16, 15);
            label1.TabIndex = 6;
            label1.Text = "x:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 114);
            label2.Name = "label2";
            label2.Size = new Size(16, 15);
            label2.TabIndex = 7;
            label2.Text = "y:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(152, 77);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 8;
            label3.Text = "Pracz(e):";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(152, 19);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 9;
            label4.Text = "Dydelf(y):";
            // 
            // SETTINGS
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(264, 205);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(checkBox1);
            Name = "SETTINGS";
            Text = "SETTINGS";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox checkBox1;
        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}