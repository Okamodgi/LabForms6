namespace LabForms6
{
    partial class Lk
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
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lk));
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            dataGridView3 = new DataGridView();
            dataGridView1 = new DataGridView();
            FIO_Column = new DataGridViewTextBoxColumn();
            Ab_number = new DataGridViewTextBoxColumn();
            LC_Column = new DataGridViewTextBoxColumn();
            Oborud_Column = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            button1 = new Button();
            textBoxProblem = new TextBox();
            textBoxChet = new TextBox();
            textBoxLogin = new TextBox();
            label4 = new Label();
            label3 = new Label();
            comboBoxTipPr = new ComboBox();
            comboBoxState = new ComboBox();
            comboBoxUsluga = new ComboBox();
            groupBox2 = new GroupBox();
            dataGridView2 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 45F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(367, 3);
            label1.Name = "label1";
            label1.Size = new Size(386, 100);
            label1.TabIndex = 0;
            label1.Text = "Абоненты";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(790, 43);
            label2.Name = "label2";
            label2.Size = new Size(156, 46);
            label2.TabIndex = 1;
            label2.Text = "События";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(108, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(111, 94);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(10, 123);

            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersWidth = 51;
            dataGridView3.RowTemplate.Height = 29;
            dataGridView3.Size = new Size(304, 141);
            dataGridView3.TabIndex = 3;
            dataGridView3.CellContentClick += dataGridView3_CellContentClick;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            dataGridView1.Location = new Point(338, 98);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(442, 432);
            dataGridView1.TabIndex = 4;
            // 
            // FIO_Column
            // 
            FIO_Column.HeaderText = "ФИО";
            FIO_Column.MinimumWidth = 6;
            FIO_Column.Name = "FIO_Column";
            FIO_Column.Width = 125;
            // 
            // Ab_number
            // 
            Ab_number.HeaderText = "Номер договора";
            Ab_number.MinimumWidth = 6;
            Ab_number.Name = "Ab_number";
            Ab_number.Width = 125;
            // 
            // LC_Column
            // 
            LC_Column.HeaderText = "Лицевой счёт";
            LC_Column.MinimumWidth = 6;
            LC_Column.Name = "LC_Column";
            LC_Column.Width = 125;
            // 
            // Oborud_Column
            // 
            Oborud_Column.HeaderText = "Оборудование";
            Oborud_Column.MinimumWidth = 6;
            Oborud_Column.Name = "Oborud_Column";
            Oborud_Column.Width = 125;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textBoxProblem);
            groupBox1.Controls.Add(textBoxChet);
            groupBox1.Controls.Add(textBoxLogin);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(comboBoxTipPr);
            groupBox1.Controls.Add(comboBoxState);
            groupBox1.Controls.Add(comboBoxUsluga);
            groupBox1.Location = new Point(12, 270);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(302, 274);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 188);
            label8.Name = "label8";
            label8.Size = new Size(157, 20);
            label8.TabIndex = 12;
            label8.Text = "Описание проблемы";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 154);
            label7.Name = "label7";
            label7.Size = new Size(113, 20);
            label7.TabIndex = 11;
            label7.Text = "Тип проблемы";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 121);
            label6.Name = "label6";
            label6.Size = new Size(52, 20);
            label6.TabIndex = 10;
            label6.Text = "Статус";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(7, 87);
            label5.Name = "label5";
            label5.Size = new Size(54, 20);
            label5.TabIndex = 9;
            label5.Text = "Услуга";
            // 
            // button1
            // 
            button1.Location = new Point(96, 231);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 8;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBoxProblem
            // 
            textBoxProblem.Location = new Point(171, 185);
            textBoxProblem.Name = "textBoxProblem";
            textBoxProblem.Size = new Size(125, 27);
            textBoxProblem.TabIndex = 7;
            // 
            // textBoxChet
            // 
            textBoxChet.Location = new Point(171, 56);
            textBoxChet.Name = "textBoxChet";
            textBoxChet.Size = new Size(125, 27);
            textBoxChet.TabIndex = 6;
            // 
            // textBoxLogin
            // 
            textBoxLogin.Location = new Point(171, 23);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(125, 27);
            textBoxLogin.TabIndex = 5;
            textBoxLogin.TextChanged += textBox1_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 30);
            label4.Name = "label4";
            label4.Size = new Size(122, 20);
            label4.TabIndex = 4;
            label4.Text = "Логин абонента";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 56);
            label3.Name = "label3";
            label3.Size = new Size(104, 20);
            label3.TabIndex = 3;
            label3.Text = "Лицевой счёт";
            // 
            // comboBoxTipPr
            // 
            comboBoxTipPr.FormattingEnabled = true;
            comboBoxTipPr.Location = new Point(171, 151);
            comboBoxTipPr.Name = "comboBoxTipPr";
            comboBoxTipPr.Size = new Size(125, 28);
            comboBoxTipPr.TabIndex = 2;
            // 
            // comboBoxState
            // 
            comboBoxState.FormattingEnabled = true;
            comboBoxState.Location = new Point(171, 118);
            comboBoxState.Name = "comboBoxState";
            comboBoxState.Size = new Size(125, 28);
            comboBoxState.TabIndex = 1;
            // 
            // comboBoxUsluga
            // 
            comboBoxUsluga.FormattingEnabled = true;
            comboBoxUsluga.Location = new Point(171, 86);
            comboBoxUsluga.Name = "comboBoxUsluga";
            comboBoxUsluga.Size = new Size(125, 28);
            comboBoxUsluga.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView2);
            groupBox2.Location = new Point(786, 90);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(165, 440);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(0, 8);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 29;
            dataGridView2.Size = new Size(165, 432);
            dataGridView2.TabIndex = 7;
            // 
            // Lk
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(963, 542);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Controls.Add(dataGridView3);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Lk";
            Text = "Lk";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label3;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private PictureBox pictureBox1;
        private DataGridView dataGridView3;
        private DataGridView dataGridView1;
        private TextBox textBoxProblem;
        private TextBox textBoxChet;
        private TextBox textBoxLogin;
        private Button button1;
        private ComboBox comboBoxTipPr;
        private ComboBox comboBoxState;
        private ComboBox comboBoxUsluga;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DataGridViewTextBoxColumn FIO_Column;
        private DataGridViewTextBoxColumn Ab_number;
        private DataGridViewTextBoxColumn LC_Column;
        private DataGridViewTextBoxColumn Oborud_Column;
        private DataGridView dataGridView2;
    }
}