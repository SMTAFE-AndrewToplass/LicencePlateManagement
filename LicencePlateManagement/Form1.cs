using System.Text;
using System.Windows.Forms;

namespace LicencePlateManagement
{
    public partial class Form1 : Form
    {
        private List<string> licencePlates = [];
        private List<string> taggedLicencePlates = [];

        public Form1()
        {
            InitializeComponent();
            ResizeTableLayoutContent();
        }

        #region Form events

        private void Form1_Resize(object sender, EventArgs e)
        {
            ResizeTableLayoutContent();
        }

        private void BtnFileLoad_Click(object sender, EventArgs e)
        {
            // Setup open file dialog.
            OpenFileDialog openFileDialog = new()
            {
                InitialDirectory = Application.StartupPath,
                FileName = "day_",
                Filter = "txt file|*.txt",
                DefaultExt = "txt",
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Update status label with opened file information.
                toolStripStatusLabel.Text = $"File opened: {openFileDialog.FileName}";

                // Clear existing licence plates.
                licencePlates.Clear();

                // Read file line-by-line and add licence plates to List.
                using (StreamReader sr = File.OpenText(openFileDialog.FileName))
                {
                    string? s = String.Empty;
                    while ((s = sr.ReadLine()) is not null)
                    {
                        // Skip line if empty.
                        if (s == String.Empty) continue;

                        // Add licence plate from the file to the List.
                        licencePlates.Add(s.ToUpper());
                    }
                }
                ShowList(licencePlates, listBoxMain);
            }
        }

        private void BtnFileSave_Click(object sender, EventArgs e)
        {
            string startPath = Application.StartupPath;
            // Get existing files to automatically set default name of new file.
            List<int> fileNumbers = [];
            foreach ( var file in Directory.GetFiles(startPath, "day_*.txt"))
            {
                // Extract the day number from each file name.
                string fileNumber = Path.GetFileName(file).Replace("day_", "").Replace(".txt", "");
                fileNumbers.Add(int.Parse(fileNumber));
            }
            // Set new number to largest + 1, or 1 if no other files exist.
            int num = ((fileNumbers.Count > 0) ? fileNumbers.Max() : 0) + 1;
            // Add zeros to start of number so it at least two digits.
            string newFileName = $"day_{num:00}";

            SaveFileDialog saveFileDialog = new()
            {
                InitialDirectory = startPath,
                FileName = newFileName,
                Filter = "txt file|*.txt",
                DefaultExt = "txt",
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Update status label with file saved information.
                toolStripStatusLabel.Text = $"File saved: {saveFileDialog.FileName}";

                string path = saveFileDialog.FileName;

                if (!path.Equals(""))
                {
                    // If file already exists, then delete it.
                    if (File.Exists(path))
                    {
                        File.Delete(path);
                    }

                    string fileContents = string.Join("\n", licencePlates);
                    // Create the file to save.
                    using (FileStream fs = File.Create(path))
                    {
                        byte[] contents = new UTF8Encoding().GetBytes(fileContents);
                        fs.Write(contents, 0, contents.Length);
                    }
                }

            }
        }

        private void BtnFileReset_Click(object sender, EventArgs e)
        {
            // Clear lists and update listboxes.
            licencePlates.Clear();
            taggedLicencePlates.Clear();
            ShowList(licencePlates, listBoxMain);
            ShowList(taggedLicencePlates, listBoxTagged);

            // Update status label.
            toolStripStatusLabel.Text = $"Reset all data";
        }

        private void BtnActionEnter_Click(object sender, EventArgs e)
        {
            // Check if text input is valid.
            string licence = txtBoxAction.Text.ToUpper();
            if (!IsInputValid(licence)) return;

            // If licence plate is already inside the list then cancel.
            if (AlreadyExistsInList(licencePlates, licence)) return;

            // Add licence plate to list and update list box display.
            licencePlates.Add(licence);
            ShowList(licencePlates, listBoxMain);
        }

        private void BtnActionExit_Click(object sender, EventArgs e)
        {
            // Check if text input is valid.
            string licence = txtBoxAction.Text.ToUpper();
            if (!IsInputValid(licence)) return;

            // Set focus back to the text box.
            txtBoxAction.Focus();

            // Check if item is inside list.
            if (!AlreadyExistsInList(licencePlates, licence))
            {
                MessageBox.Show($"The licence plate {licence} does not exist inside the list.");
                return;
            }

            // If item is inside list, remove it and update listbox displays.
            licencePlates.Remove(licence);
            ShowList(licencePlates, listBoxMain);
        }

        private void BtnActionEdit_Click(object sender, EventArgs e)
        {
            // Set focus back to the text box.
            txtBoxAction.Focus();

            // Check if text input is valid.
            string licence = txtBoxAction.Text.ToUpper();
            if (!IsInputValid(licence)) return;

            int i = listBoxMain.SelectedIndex;
            // If there is no selected item inside the listbox, then show error.
            if (i < 0)
            {
                MessageBox.Show("Please select an licence plate to edit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Replace licence plate with editted version.
            licencePlates[i] = licence;
            ShowList(licencePlates, listBoxMain, true);
        }

        private void BtnActionSearchBinary_Click(object sender, EventArgs e)
        {
            // Check if text input is valid.
            string licence = txtBoxAction.Text.ToUpper();
            if (!IsInputValid(licence)) return;
            // TODO
        }

        private void BtnActionSearchLinear_Click(object sender, EventArgs e)
        {
            // Check if text input is valid.
            string licence = txtBoxAction.Text.ToUpper();
            if (!IsInputValid(licence)) return;
            // TODO
        }

        private void BtnTagAdd_Click(object sender, EventArgs e)
        {
            // If there is no selected item inside the listbox, then cancel.
            if (listBoxMain.SelectedIndex < 0) return;

            // Move the selected licence plate to the tagged list.
            TagLicence(listBoxMain.SelectedIndex);

            // Update the list boxes.
            ShowList(licencePlates, listBoxMain, false);
            ShowList(taggedLicencePlates, listBoxTagged, true);
        }

        private void BtnTagRemove_Click(object sender, EventArgs e)
        {
            // If there is no selected item inside the listbox, then cancel.
            if (listBoxTagged.SelectedIndex < 0) return;

            // Move the selected licence plate to the tagged list.
            UntagLicence(listBoxTagged.SelectedIndex);

            // Update the list boxes.
            ShowList(licencePlates, listBoxMain, true);
            ShowList(taggedLicencePlates, listBoxTagged, false);
        }

        private void ListBoxMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = listBoxMain.SelectedIndex;

            // If there is no selected item inside the listbox, then cancel.
            if (i < 0) return;

            // Add the contents of the item at index `i` into the textbox.
            txtBoxAction.Text = listBoxMain.Items[i].ToString();
        }

        private void ListBoxTagged_SelectedIndexChanged(object sender, EventArgs e)
        {
            // TODO
        }

        private void ListBoxMain_DoubleClick(object sender, EventArgs e)
        {
            if (listBoxMain.SelectedIndex < 0) return;
            int i = listBoxMain.SelectedIndex;

            DialogResult msg = MessageBox.Show($"Do you want to remove '{licencePlates[i]}' from the list.", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (msg == DialogResult.Yes)
            {
                licencePlates.RemoveAt(i);
                ShowList(licencePlates, listBoxMain);
            }
            else
            {
                return;
            }
        }

        private void ListBoxTagged_DoubleClick(object sender, EventArgs e)
        {
            // TODO
        }
        #endregion

        #region Utility functions

        /// <summary>
        /// Adds all list items to a listbox.
        /// </summary>
        /// <param name="list">List containing items to add.</param>
        /// <param name="listBox">ListBox to add items to.</param>
        /// <param name="restore">Restore previous selected item index.</param>
        private void ShowList(List<string> list, ListBox listBox, bool restore = false)
        {
            // Breaks the restore selected item functionality.
            list.Sort();
            int index = -1;
            if (restore) index = listBox.SelectedIndex;
            listBox.Items.Clear();
            foreach (string item in list)
            {
                listBox.Items.Add(item);
            }
            listBox.SelectedIndex = index;
        }

        /// <summary>
        /// Search for item inside list and return if it was found or not.
        /// </summary>
        /// <param name="list">List to search for duplicates.</param>
        /// <param name="target">Item to search for.</param>
        /// <returns>True if item already exists inside the list, false if not.</returns>
        private bool AlreadyExistsInList(List<string> list, string target)
        {
            bool isFound = false;
            foreach (string item in list)
            {
                if (item.Equals(target)) isFound = true;
            }
            return isFound;
        }

        /// <summary>
        /// Adds licence number to tagged list and removes it from the main list.
        /// </summary>
        /// <param name="index">Index of item in main list to tag.</param>
        private void TagLicence(int index)
        {
            string licence = licencePlates[index];
            taggedLicencePlates.Add(licence);
            licencePlates.Remove(licence);
        }

        /// <summary>
        /// Removes licence number from tagged list and adds it back to the main list.
        /// </summary>
        /// <param name="index">Index of item in tagged list to untag.</param>
        private void UntagLicence(int index)
        {
            string licence = taggedLicencePlates[index];
            licencePlates.Add(licence);
            taggedLicencePlates.Remove(licence);
        }

        /// <summary>
        /// Verifies that the user has entered a licence plate number into the textbox.
        /// </summary>
        /// <returns>True if the user has entered a licence plate correctly, false if not.</returns>
        private bool IsInputValid(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                MessageBox.Show("You must enter a licence plate.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void ResizeTableLayoutContent()
        {
            tableLayoutContent.SuspendLayout();
            int formWidth = Size.Width - 16;
            // Limit size to the maximum width of the table layout.
            int maxWidth = tableLayoutContent.MaximumSize.Width;
            int newWidth = Math.Min(maxWidth, formWidth);
            tableLayoutContent.Size = new Size(newWidth, 0);
            tableLayoutContent.ResumeLayout(true);
        }
        #endregion
    }
}
