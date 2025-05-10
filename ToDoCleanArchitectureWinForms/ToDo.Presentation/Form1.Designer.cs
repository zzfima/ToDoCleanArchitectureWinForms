namespace ToDo.Presentation
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
            btnAdd = new Button();
            txtTitle = new TextBox();
            lstToDos = new ListBox();
            btnMarkDone = new Button();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(12, 379);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(12, 350);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(272, 23);
            txtTitle.TabIndex = 1;
            // 
            // lstToDos
            // 
            lstToDos.FormattingEnabled = true;
            lstToDos.ItemHeight = 15;
            lstToDos.Location = new Point(12, 12);
            lstToDos.Name = "lstToDos";
            lstToDos.Size = new Size(272, 289);
            lstToDos.TabIndex = 2;
            // 
            // btnMarkDone
            // 
            btnMarkDone.Location = new Point(14, 305);
            btnMarkDone.Name = "btnMarkDone";
            btnMarkDone.Size = new Size(75, 23);
            btnMarkDone.TabIndex = 3;
            btnMarkDone.Text = "Done";
            btnMarkDone.UseVisualStyleBackColor = true;
            btnMarkDone.Click += btnMarkDone_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(312, 414);
            Controls.Add(btnMarkDone);
            Controls.Add(lstToDos);
            Controls.Add(txtTitle);
            Controls.Add(btnAdd);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private TextBox txtTitle;
        private ListBox lstToDos;
        private Button btnMarkDone;
    }
}
