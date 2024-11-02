namespace MIDParactice
{
    partial class Deleteform
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
            label1 = new Label();
            DeleteText = new TextBox();
            Delete_btn = new Button();
            Cancel_BTN = new Button();
            ((System.ComponentModel.ISupportInitialize)show_courseGrid).BeginInit();
            SuspendLayout();
            // 
            // show_courseGrid
            // 
            show_courseGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            show_courseGrid.Location = new Point(2, 12);
            show_courseGrid.Name = "show_courseGrid";
            show_courseGrid.ReadOnly = true;
            show_courseGrid.RowHeadersWidth = 62;
            show_courseGrid.Size = new Size(793, 392);
            show_courseGrid.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(160, 436);
            label1.Name = "label1";
            label1.Size = new Size(375, 25);
            label1.TabIndex = 2;
            label1.Text = "Enter The Code Of Course You Want To Delete";
            // 
            // DeleteText
            // 
            DeleteText.Location = new Point(167, 473);
            DeleteText.Name = "DeleteText";
            DeleteText.Size = new Size(368, 31);
            DeleteText.TabIndex = 3;
            // 
            // Delete_btn
            // 
            Delete_btn.Location = new Point(170, 537);
            Delete_btn.Name = "Delete_btn";
            Delete_btn.Size = new Size(112, 34);
            Delete_btn.TabIndex = 4;
            Delete_btn.Text = "Delete";
            Delete_btn.UseVisualStyleBackColor = true;
            Delete_btn.Click += Delete_btn_Click;
            // 
            // Cancel_BTN
            // 
            Cancel_BTN.Location = new Point(355, 537);
            Cancel_BTN.Name = "Cancel_BTN";
            Cancel_BTN.Size = new Size(112, 34);
            Cancel_BTN.TabIndex = 5;
            Cancel_BTN.Text = "Cancel";
            Cancel_BTN.UseVisualStyleBackColor = true;
            Cancel_BTN.Click += Cancel_BTN_Click;
            // 
            // Deleteform
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(799, 630);
            Controls.Add(Cancel_BTN);
            Controls.Add(Delete_btn);
            Controls.Add(DeleteText);
            Controls.Add(label1);
            Controls.Add(show_courseGrid);
            Name = "Deleteform";
            Text = "Deleteform";
            Load += Deleteform_Load;
            ((System.ComponentModel.ISupportInitialize)show_courseGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView show_courseGrid;
        private Label label1;
        private TextBox DeleteText;
        private Button Delete_btn;
        private Button Cancel_BTN;
    }
}