namespace MIDParactice
{
    partial class UpdateForm
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
            show_courseGrid = new DataGridView();
            ucancel = new Button();
            Ubtn = new Button();
            UTextcredits = new TextBox();
            UTextname = new TextBox();
            UTextcode = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)show_courseGrid).BeginInit();
            SuspendLayout();
            // 
            // show_courseGrid
            // 
            show_courseGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            show_courseGrid.Location = new Point(12, 12);
            show_courseGrid.Name = "show_courseGrid";
            show_courseGrid.ReadOnly = true;
            show_courseGrid.RowHeadersWidth = 62;
            show_courseGrid.Size = new Size(908, 109);
            show_courseGrid.TabIndex = 0;
            // 
            // ucancel
            // 
            ucancel.Location = new Point(525, 382);
            ucancel.Name = "ucancel";
            ucancel.Size = new Size(112, 34);
            ucancel.TabIndex = 15;
            ucancel.Text = "Cancel";
            ucancel.UseVisualStyleBackColor = true;
            ucancel.Click += ucancel_Click;
            // 
            // Ubtn
            // 
            Ubtn.Location = new Point(361, 382);
            Ubtn.Name = "Ubtn";
            Ubtn.Size = new Size(112, 34);
            Ubtn.TabIndex = 14;
            Ubtn.Text = "Update";
            Ubtn.UseVisualStyleBackColor = true;
            Ubtn.Click += Ubtn_Click;
            // 
            // UTextcredits
            // 
            UTextcredits.Location = new Point(351, 299);
            UTextcredits.Name = "UTextcredits";
            UTextcredits.Size = new Size(286, 31);
            UTextcredits.TabIndex = 13;
            // 
            // UTextname
            // 
            UTextname.Location = new Point(351, 241);
            UTextname.Name = "UTextname";
            UTextname.Size = new Size(286, 31);
            UTextname.TabIndex = 12;
            // 
            // UTextcode
            // 
            UTextcode.Location = new Point(351, 189);
            UTextcode.Name = "UTextcode";
            UTextcode.Size = new Size(286, 31);
            UTextcode.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(124, 299);
            label3.Name = "label3";
            label3.Size = new Size(142, 25);
            label3.TabIndex = 10;
            label3.Text = "Enter the Credits";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(124, 241);
            label2.Name = "label2";
            label2.Size = new Size(164, 25);
            label2.TabIndex = 9;
            label2.Text = "Enter Course Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(124, 187);
            label1.Name = "label1";
            label1.Size = new Size(159, 25);
            label1.TabIndex = 8;
            label1.Text = "Enter Course Code";
            // 
            // UpdateForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(932, 570);
            Controls.Add(ucancel);
            Controls.Add(Ubtn);
            Controls.Add(UTextcredits);
            Controls.Add(UTextname);
            Controls.Add(UTextcode);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(show_courseGrid);
            Name = "UpdateForm";
            Text = "UpdateForm";
            Load += UpdateForm_Load;
            ((System.ComponentModel.ISupportInitialize)show_courseGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView show_courseGrid;
        private Button ucancel;
        private Button Ubtn;
        private TextBox UTextcredits;
        private TextBox UTextname;
        private TextBox UTextcode;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}