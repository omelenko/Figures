namespace Figures
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
            listBox1 = new ListBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            listBox2 = new ListBox();
            listBox3 = new ListBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(133, 424);
            listBox1.TabIndex = 0;
            listBox1.DoubleClick += listBox1_DoubleClick;
            // 
            // button1
            // 
            button1.Location = new Point(654, 389);
            button1.Name = "button1";
            button1.Size = new Size(134, 47);
            button1.TabIndex = 3;
            button1.Text = "Створити коло";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(654, 336);
            button2.Name = "button2";
            button2.Size = new Size(134, 47);
            button2.TabIndex = 4;
            button2.Text = "Створити трикутник";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(654, 283);
            button3.Name = "button3";
            button3.Size = new Size(134, 47);
            button3.TabIndex = 5;
            button3.Text = "Створити квадрат";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(151, 12);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(133, 424);
            listBox2.TabIndex = 7;
            listBox2.DoubleClick += listBox2_DoubleClick;
            // 
            // listBox3
            // 
            listBox3.FormattingEnabled = true;
            listBox3.ItemHeight = 15;
            listBox3.Location = new Point(290, 12);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(133, 424);
            listBox3.TabIndex = 8;
            listBox3.DoubleClick += listBox3_DoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(453, 12);
            label1.Name = "label1";
            label1.Size = new Size(335, 15);
            label1.TabIndex = 9;
            label1.Text = "Нажміть два рази на елемент щоб відобразити його площу";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(listBox3);
            Controls.Add(listBox2);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private ListBox listBox2;
        private ListBox listBox3;
        private Label label1;
    }
}
