using System.Diagnostics;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace TodoAppCSharp
{
    public partial class Form1 : Form
    {
        private List<Task> tasks = new List<Task>();

        public Form1()
        {
            InitializeComponent();
            Save.Enabled = false;
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

                TaskManager.SaveTasks(tasks); //  Save to JSON
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            int selectedIndex = AllTasks.SelectedIndex;
            if (selectedIndex >= 0)
            {
                tasks.RemoveAt(selectedIndex);
                AllTasks.Items.RemoveAt(selectedIndex);

                TaskManager.SaveTasks(tasks); //  Save updated list
            }
        }

        private void buttonToggleDone_Click(object sender, EventArgs e)
        {
            int selectedIndex = AllTasks.SelectedIndex;
            if (selectedIndex >= 0 && selectedIndex < tasks.Count)
            {
                Task task = tasks[selectedIndex];
                task.IsDone = !task.IsDone;

                // Update the ListBox item
                AllTasks.Items[selectedIndex] = tasks[selectedIndex]; ; // Force refresh
                AllTasks.Items[selectedIndex] = task;

                TaskManager.SaveTasks(tasks);
                buttonToggleDone.Text = task.IsDone ? "Mark as Undone" : "Mark as Done";
            }
            else
            {
                MessageBox.Show("Please select a task.");
            }
        }

        private void AllTasks_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = AllTasks.SelectedIndex;

            if (selectedIndex >= 0 && selectedIndex < tasks.Count)
            {
                var task = tasks[selectedIndex];
                buttonToggleDone.Text = task.IsDone ? "Mark as Undone" : "Mark as Done";
            }
            else
            {
                buttonToggleDone.Text = "Mark as Done";
            }
        }
        private int editingIndex = -1;
        private void Edit_Click(object sender, EventArgs e)
        {
            if (AllTasks.SelectedIndex != -1)
            {
                editingIndex = AllTasks.SelectedIndex;
                Task selectedTask = tasks[editingIndex];
                TaskToGo.Text = selectedTask.Description;
                Save.Enabled = true;
                Add.Enabled = false;
                Delete.Enabled = false;
                buttonToggleDone.Enabled = false;
                Edit.Enabled = false;
            }
        }
        private void Save_Click(object sender, EventArgs e)
        {
            if (editingIndex != -1 && !string.IsNullOrWhiteSpace(TaskToGo.Text))
            {
                tasks[editingIndex].Description = TaskToGo.Text.Trim();
                editingIndex = -1;
                TaskToGo.Clear();
                Save.Enabled = false;
                Add.Enabled = true;
                Delete.Enabled = true;
                buttonToggleDone.Enabled = true;
                Edit.Enabled = true;
                TaskManager.SaveTasks(tasks);
            }
        }
        private void ExportToJson(string path)
        {
            var json = JsonSerializer.Serialize(tasks);
            File.WriteAllText(path, json);
        }
        private void ImportFromJson(string path)
        {
            if (File.Exists(path))
            {
                var json = File.ReadAllText(path);
                tasks = JsonSerializer.Deserialize<List<Task>>(json);
                AllTasks.Items.Clear();
                foreach (var task in tasks)
                {
                    AllTasks.Items.Add(task);
                }
                TaskManager.SaveTasks(tasks);
            }
        }

        private void Import_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "JSON Files (*.json)|*.json|All Files (*.*)|*.*";
            openFileDialog.Title = "Select a JSON file to import";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                ImportFromJson(openFileDialog.FileName);
                MessageBox.Show("Tasks imported successfully!");
            }
        }


        private void Export_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "JSON Files (*.json)|*.json|All Files (*.*)|*.*";
            saveFileDialog.Title = "Save tasks to JSON";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                ExportToJson(saveFileDialog.FileName);
                MessageBox.Show("Tasks exported successfully!");
            }
        }

    }
}
