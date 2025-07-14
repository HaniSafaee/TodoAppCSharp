namespace TodoAppCSharp
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
            TaskToGo = new TextBox();
            Add = new Button();
            AllTasks = new ListBox();
            Delete = new Button();
            buttonToggleDone = new Button();
            SuspendLayout();
            // 
            // TaskToGo
            // 
            TaskToGo.Location = new Point(78, 85);
            TaskToGo.Name = "TaskToGo";
            TaskToGo.Size = new Size(449, 27);
            TaskToGo.TabIndex = 0;
            // 
            // Add
            // 
            Add.Location = new Point(577, 85);
            Add.Name = "Add";
            Add.Size = new Size(155, 29);
            Add.TabIndex = 1;
            Add.Text = "Add";
            Add.UseVisualStyleBackColor = true;
            Add.Click += Add_Click;
            // 
            // AllTasks
            // 
            AllTasks.FormattingEnabled = true;
            AllTasks.Location = new Point(78, 145);
            AllTasks.Name = "AllTasks";
            AllTasks.Size = new Size(449, 244);
            AllTasks.TabIndex = 2;
            AllTasks.SelectedIndexChanged += AllTasks_SelectedIndexChanged;
            // 
            // Delete
            // 
            Delete.Location = new Point(577, 145);
            Delete.Name = "Delete";
            Delete.Size = new Size(155, 29);
            Delete.TabIndex = 3;
            Delete.Text = "Delete";
            Delete.UseVisualStyleBackColor = true;
            Delete.Click += Delete_Click;
            // 
            // buttonToggleDone
            // 
            buttonToggleDone.Location = new Point(577, 191);
            buttonToggleDone.Name = "buttonToggleDone";
            buttonToggleDone.Size = new Size(155, 29);
            buttonToggleDone.TabIndex = 4;
            buttonToggleDone.Text = "Mark as Done";
            buttonToggleDone.UseVisualStyleBackColor = true;
            buttonToggleDone.Click += buttonToggleDone_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonToggleDone);
            Controls.Add(Delete);
            Controls.Add(AllTasks);
            Controls.Add(Add);
            Controls.Add(TaskToGo);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TaskToGo;
        private Button Add;
        private ListBox AllTasks;
        private Button Delete;
        private Button buttonToggleDone;
    }
}
