using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private int points = 0; // Pontszám nyilvántartása
        private int completedTasks = 0; // Teljesített feladatok száma
        private string userName = "Nincs megadva"; // Felhasználónév alapértelmezett értékkel

        public Form1()
        {
            InitializeComponent();

            // NumericUpDown beállítása
            numericUpDown1.Minimum = 1; // Minimum érték
            numericUpDown1.Maximum = 10; // Maximum érték

            // Felhasználónév bekérése indításkor
            userName = PromptForUserName();
            labelNAME.Text = $"Név: {userName}";

            // Gombok eseményeinek hozzárendelése
            BTNAdd.Click += BTNAdd_Click;
            BTNDel.Click += BTNDel_Click;
            BTNComplete.Click += BTNComplete_Click;
            BTNImportant.Click += BTNImportant_Click;
            BTNExit.Click += BTNExit_Click;
        }

        // Felhasználónév bekérése egy egyszerű üzenetablakkal
        private string PromptForUserName()
        {
            // Egyedi ablak a felhasználónév megadására
            Form prompt = new Form()
            {
                Width = 300,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = "Felhasználónév megadása",
                StartPosition = FormStartPosition.CenterScreen
            };
            Label textLabel = new Label() { Left = 20, Top = 20, Text = "Add meg a neved:" };
            TextBox inputBox = new TextBox() { Left = 20, Top = 50, Width = 240 };
            Button confirmation = new Button() { Text = "OK", Left = 180, Width = 80, Top = 80, DialogResult = DialogResult.OK };
            prompt.Controls.Add(textLabel);
            prompt.Controls.Add(inputBox);
            prompt.Controls.Add(confirmation);
            prompt.AcceptButton = confirmation;

            return prompt.ShowDialog() == DialogResult.OK ? inputBox.Text : "Névtelen";
        }


        // Feladat hozzáadása
        private void BTNAdd_Click(object sender, EventArgs e)
        {
            string taskName = textBox1.Text.Trim();
            int difficulty = (int)numericUpDown1.Value;

            if (!string.IsNullOrEmpty(taskName))
            {
                // Új feladat hozzáadása a ListView-hoz
                ListViewItem item = new ListViewItem(taskName);
                item.SubItems.Add(difficulty.ToString()); // Nehézség hozzáadása
                listView2.Items.Add(item);

                textBox1.Clear();
                numericUpDown1.Value = 1;
            }
            else
            {
                MessageBox.Show("Kérlek, adj meg egy feladatot!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Feladat törlése
        private void BTNDel_Click(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count > 0)
            {
                foreach (ListViewItem item in listView2.SelectedItems)
                {
                    listView2.Items.Remove(item);
                }
            }
            else
            {
                MessageBox.Show("Jelölj ki egy feladatot a törléshez!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Feladat teljesítése
        private void BTNComplete_Click(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count > 0)
            {
                foreach (ListViewItem item in listView2.SelectedItems)
                {
                    int difficulty = int.Parse(item.SubItems[1].Text); // Nehézség beolvasása
                    points += difficulty; // Pontok növelése a nehézség alapján

                    listView2.Items.Remove(item);
                    completedTasks++;
                }

                UpdateStats();
            }
            else
            {
                MessageBox.Show("Jelölj ki egy feladatot a teljesítéshez!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Feladat fontosként megjelölése
        private void BTNImportant_Click(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count > 0)
            {
                foreach (ListViewItem item in listView2.SelectedItems)
                {
                    item.BackColor = System.Drawing.Color.Yellow; // Megjelölés sárgával
                }
            }
            else
            {
                MessageBox.Show("Jelölj ki egy feladatot a fontosként megjelöléshez!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Kilépés az alkalmazásból
        private void BTNExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Statisztikák frissítése
        private void UpdateStats()
        {
            labelPOINTS.Text = $"Pontszám: {points}";
            labelCOMPLETED.Text = $"Végrehajtott feladatok: {completedTasks}";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

}
