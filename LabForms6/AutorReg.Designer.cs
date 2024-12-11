namespace LabForms6
{
    partial class AutorReg
    {

        private System.ComponentModel.IContainer components = null;

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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            checkPass = new CheckBox();
            comboBox1 = new ComboBox();
            AutButton = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 59);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(199, 27);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(6, 125);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(199, 27);
            textBox2.TabIndex = 1;
            textBox2.UseSystemPasswordChar = true;
            // 
            // checkPass
            // 
            checkPass.AutoSize = true;
            checkPass.Location = new Point(211, 128);
            checkPass.Name = "checkPass";
            checkPass.Size = new Size(140, 24);
            checkPass.TabIndex = 2;
            checkPass.Text = "Показать пароль";
            checkPass.UseVisualStyleBackColor = true;
            checkPass.CheckedChanged += ShowPasswordCheckBox_CheckedChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(6, 201);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(199, 28);
            comboBox1.TabIndex = 3;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // AutButton
            // 
            AutButton.Location = new Point(58, 281);
            AutButton.Name = "AutButton";
            AutButton.Size = new Size(174, 29);
            AutButton.TabIndex = 4;
            AutButton.Text = "Авторизация";
            AutButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 36);
            label1.Name = "label1";
            label1.Size = new Size(110, 20);
            label1.TabIndex = 5;
            label1.Text = "Введите логин";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 102);
            label2.Name = "label2";
            label2.Size = new Size(120, 20);
            label2.TabIndex = 6;
            label2.Text = "Введите пароль";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 178);
            label3.Name = "label3";
            label3.Size = new Size(125, 20);
            label3.TabIndex = 7;
            label3.Text = "Ваша должность";
            // 
            // AutorReg
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(332, 409);
            Controls.Add(textBox1);
            Controls.Add(textBox2);
            Controls.Add(comboBox1);
            Controls.Add(AutButton);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(label3);
            Name = "AutorReg";
            Text = "Авторизация";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;

        private ComboBox comboBox1;

        private Label label1;
        private Label label2;
        private Label label3;
    }
}
