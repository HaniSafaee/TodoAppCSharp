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
            Edit = new Button();
            Save = new Button();
            Import = new Button();
            Export = new Button();
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
            buttonToggleDone.Location = new Point(577, 188);
            buttonToggleDone.Name = "buttonToggleDone";
            buttonToggleDone.Size = new Size(155, 29);
            buttonToggleDone.TabIndex = 4;
            buttonToggleDone.Text = "Mark as Done";
            buttonToggleDone.UseVisualStyleBackColor = true;
            buttonToggleDone.Click += buttonToggleDone_Click;
            // 
            // Edit
            // 
            Edit.Location = new Point(577, 231);
            Edit.Name = "Edit";
            Edit.Size = new Size(155, 29);
            Edit.TabIndex = 5;
            Edit.Text = "Edit";
            Edit.UseVisualStyleBackColor = true;
            Edit.Click += Edit_Click;
            // 
            // Save
            // 
            Save.Location = new Point(577, 274);
            Save.Name = "Save";
            Save.Size = new Size(155, 29);
            Save.TabIndex = 6;
            Save.Text = "Save";
            Save.UseVisualStyleBackColor = true;
            Save.Click += Save_Click;
            // 
            // Import
            // 
            Import.Location = new Point(577, 317);
            Import.Name = "Import";
            Import.Size = new Size(155, 29);
            Import.TabIndex = 7;
            Import.Text = "Import";
            Import.UseVisualStyleBackColor = true;
            Import.Click += Import_Click;
            // 
            // Export
            // 
            Export.Location = new Point(577, 360);
            Export.Name = "Export";
            Export.Size = new Size(155, 29);
            Export.TabIndex = 8;
            Export.Text = "Export";
            Export.UseVisualStyleBackColor = true;
            Export.Click += Export_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Export);
            Controls.Add(Import);
            Controls.Add(Save);
            Controls.Add(Edit);
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
        private Button Edit;
        private Button Save;
        private Button Import;
        private Button Export;
    }
}
