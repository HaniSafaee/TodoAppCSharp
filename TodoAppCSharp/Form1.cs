using System.Collections.Generic;
using System.Windows.Forms;

namespace TodoAppCSharp
{
    public partial class Form1 : Form
    {
        private List<Task> tasks = new List<Task>();

        public Form1()
        {
            InitializeComponent();
            tasks = TaskManager.LoadTasks();
            foreach (var task in tasks)
            {
                AllTasks.Items.Add(task);
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            string text = TaskToGo.Text.Trim();
            if (!string.IsNullOrEmpty(text))
            {
                Task newTask = new Task { Description = text, IsDone = false };
                tasks.Add(newTask);
                AllTasks.Items.Add(newTask);
                TaskToGo.Clear();

                TaskManager.SaveTasks(tasks); // 💾 Save to JSON
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            int selectedIndex = AllTasks.SelectedIndex;
            if (selectedIndex >= 0)
            {
                tasks.RemoveAt(selectedIndex);
                AllTasks.Items.RemoveAt(selectedIndex);

                TaskManager.SaveTasks(tasks); // 💾 Save updated list
            }
        }

    }
}
