namespace MIDParactice
{
    partial class MainForm
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
            show_courseGrid = new DataGridView();
            Delete_Btn = new Button();
            Insertbtn = new Button();
            button3 = new Button();
            Cancel_btn = new Button();
            ((System.ComponentModel.ISupportInitialize)show_courseGrid).BeginInit();
            SuspendLayout();
            // 
            // show_courseGrid
            // 
            show_courseGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            show_courseGrid.Location = new Point(14, 10);
            show_courseGrid.Name = "show_courseGrid";
            show_courseGrid.ReadOnly = true;
            show_courseGrid.RowHeadersWidth = 62;
            show_courseGrid.Size = new Size(793, 392);
            show_courseGrid.TabIndex = 0;
            // 
            // Delete_Btn
            // 
            Delete_Btn.Location = new Point(217, 451);
            Delete_Btn.Name = "Delete_Btn";
            Delete_Btn.Size = new Size(112, 34);
            Delete_Btn.TabIndex = 1;
            Delete_Btn.Text = "Delete";
            Delete_Btn.UseVisualStyleBackColor = true;
            Delete_Btn.Click += Delete_Btn_Click;
            // 
            // Insertbtn
            // 
            Insertbtn.Location = new Point(56, 451);
            Insertbtn.Name = "Insertbtn";
            Insertbtn.Size = new Size(112, 34);
            Insertbtn.TabIndex = 2;
            Insertbtn.Text = "Insert";
            Insertbtn.UseVisualStyleBackColor = true;
            Insertbtn.Click += Insertbtn_Click;
            // 
            // button3
            // 
            button3.Location = new Point(387, 451);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 3;
            button3.Text = "Update";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Cancel_btn
            // 
            Cancel_btn.Location = new Point(569, 451);
            Cancel_btn.Name = "Cancel_btn";
            Cancel_btn.Size = new Size(112, 34);
            Cancel_btn.TabIndex = 4;
            Cancel_btn.Text = "Cancel";
            Cancel_btn.UseVisualStyleBackColor = true;
            Cancel_btn.Click += Cancel_btn_Click;
            // 
            // MainForm
            // 
            ClientSize = new Size(819, 614);
            Controls.Add(Cancel_btn);
            Controls.Add(button3);
            Controls.Add(Insertbtn);
            Controls.Add(Delete_Btn);
            Controls.Add(show_courseGrid);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "MainForm";
            Text = "ShowCourses";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)show_courseGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion


        private DataGridView show_courseGrid;
        private Button Delete_Btn;
        private Button Insertbtn;
        private Button button3;
        private Button Cancel_btn;
    }
}
