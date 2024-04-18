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

        private void Form1_Resize(object sender, EventArgs e)
        {
            ResizeTableLayoutContent();
        }

        #region Utility functions
        
        /// <summary>
        /// Adds all list items to a listbox.
        /// </summary>
        /// <param name="list">List containing items to add.</param>
        /// <param name="listBox">ListBox to add items to.</param>
        /// <param name="restore">Restore previous selected item index.</param>
        private void ShowList(List<string> list, ListBox listBox, bool restore = false)
        {
            int index = listBox.SelectedIndex;
            listBox.Items.Clear();
            foreach (string item in list)
            {
                listBox.Items.Add(item);
            }
            if (restore) listBox.SelectedIndex = index;
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
