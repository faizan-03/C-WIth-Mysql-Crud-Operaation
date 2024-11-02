namespace MIDParactice
{
    partial class inserform
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            Textcode = new TextBox();
            Textname = new TextBox();
            Textcredits = new TextBox();
            button1 = new Button();
            IcancelBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(63, 95);
            label1.Name = "label1";
            label1.Size = new Size(159, 25);
            label1.TabIndex = 0;
            label1.Text = "Enter Course Code";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(63, 149);
            label2.Name = "label2";
            label2.Size = new Size(164, 25);
            label2.TabIndex = 1;
            label2.Text = "Enter Course Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(63, 207);
            label3.Name = "label3";
            label3.Size = new Size(142, 25);
            label3.TabIndex = 2;
            label3.Text = "Enter the Credits";
            // 
            // Textcode
            // 
            Textcode.Location = new Point(290, 97);
            Textcode.Name = "Textcode";
            Textcode.Size = new Size(286, 31);
            Textcode.TabIndex = 3;
            // 
            // Textname
            // 
            Textname.Location = new Point(290, 149);
            Textname.Name = "Textname";
            Textname.Size = new Size(286, 31);
            Textname.TabIndex = 4;
            // 
            // Textcredits
            // 
            Textcredits.Location = new Point(290, 207);
            Textcredits.Name = "Textcredits";
            Textcredits.Size = new Size(286, 31);
            Textcredits.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(300, 290);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 6;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // IcancelBtn
            // 
            IcancelBtn.Location = new Point(464, 290);
            IcancelBtn.Name = "IcancelBtn";
            IcancelBtn.Size = new Size(112, 34);
            IcancelBtn.TabIndex = 7;
            IcancelBtn.Text = "Cancel";
            IcancelBtn.UseVisualStyleBackColor = true;
            IcancelBtn.Click += IcancelBtn_Click;
            // 
            // inserform
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(IcancelBtn);
            Controls.Add(button1);
            Controls.Add(Textcredits);
            Controls.Add(Textname);
            Controls.Add(Textcode);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "inserform";
            Text = "inserform";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox Textcode;
        private TextBox Textname;
        private TextBox Textcredits;
        private Button button1;
        private Button IcancelBtn;
    }
}