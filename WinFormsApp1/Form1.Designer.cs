namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            comboBox1 = new ComboBox();
            hScrollBar1 = new HScrollBar();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            button8 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            vScrollBar2 = new VScrollBar();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(553, 28);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(131, 23);
            comboBox1.TabIndex = 0;
            comboBox1.Text = "ФИО_пользователя";
            // 
            // hScrollBar1
            // 
            hScrollBar1.Location = new Point(134, 392);
            hScrollBar1.Name = "hScrollBar1";
            hScrollBar1.Size = new Size(387, 14);
            hScrollBar1.TabIndex = 3;
            hScrollBar1.Scroll += hScrollBar1_Scroll;
            // 
            // button1
            // 
            button1.Location = new Point(12, 78);
            button1.Name = "button1";
            button1.Size = new Size(106, 34);
            button1.TabIndex = 4;
            button1.Text = "Абоненты";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(12, 118);
            button2.Name = "button2";
            button2.Size = new Size(106, 34);
            button2.TabIndex = 5;
            button2.Text = "Управление\r\nоборудованием";
            button2.UseCompatibleTextRendering = true;
            button2.UseVisualStyleBackColor = true;
            button2.UseWaitCursor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(12, 158);
            button3.Name = "button3";
            button3.Size = new Size(106, 34);
            button3.TabIndex = 6;
            button3.Text = "Активы";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(12, 198);
            button4.Name = "button4";
            button4.Size = new Size(106, 34);
            button4.TabIndex = 7;
            button4.Text = "Биллинг";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 8F);
            button5.Location = new Point(12, 238);
            button5.Name = "button5";
            button5.Size = new Size(106, 32);
            button5.TabIndex = 8;
            button5.Text = "Поддержка\r\nпользователей";
            button5.UseCompatibleTextRendering = true;
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(12, 276);
            button6.Name = "button6";
            button6.Size = new Size(106, 32);
            button6.TabIndex = 9;
            button6.Text = "CRM";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.AutoSize = true;
            button7.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button7.BackColor = Color.Silver;
            button7.FlatStyle = FlatStyle.Popup;
            button7.Location = new Point(41, 361);
            button7.Name = "button7";
            button7.Size = new Size(50, 25);
            button7.TabIndex = 10;
            button7.Text = "проф.";
            button7.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.LightGray;
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 9F));
            tableLayoutPanel1.Location = new Point(134, 92);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 125F));
            tableLayoutPanel1.Size = new Size(397, 297);
            tableLayoutPanel1.TabIndex = 11;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint_1;
            // 
            // button8
            // 
            button8.AutoSize = true;
            button8.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button8.BackColor = Color.Silver;
            button8.FlatStyle = FlatStyle.Popup;
            button8.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button8.Location = new Point(54, 392);
            button8.Name = "button8";
            button8.Size = new Size(22, 25);
            button8.TabIndex = 12;
            button8.Text = "?";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(224, 224, 224);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(106, 63);
            label1.TabIndex = 14;
            label1.Text = "Логотип\r\nТНС\r\n";
            label1.TextAlign = ContentAlignment.BottomCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(134, 13);
            label2.Name = "label2";
            label2.Size = new Size(204, 37);
            label2.TabIndex = 15;
            label2.Text = "Абоненты ТНС";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(224, 224, 224);
            label3.Location = new Point(690, 31);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 16;
            label3.Text = "ФОТО";
            // 
            // vScrollBar2
            // 
            vScrollBar2.Location = new Point(521, 145);
            vScrollBar2.Name = "vScrollBar2";
            vScrollBar2.Size = new Size(11, 247);
            vScrollBar2.TabIndex = 17;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(vScrollBar2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button8);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(hScrollBar1);
            Controls.Add(comboBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private HScrollBar hScrollBar1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private TableLayoutPanel tableLayoutPanel1;
        private Button button8;
        private Label label1;
        private Label label2;
        private Label label3;
        private VScrollBar vScrollBar2;
    }
}
