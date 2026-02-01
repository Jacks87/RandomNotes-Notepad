// ========= DISCLAIMER - last update 1/31/2026 =========
// This source code was written by me, in my own words, and implemented by me inside my Visual Studio.
// I did not receive a complete “finished code file” from any other person to submit as-is.
// I did, however, use ChatGPT as a support tool to help with brainstorming the application idea,
// discussing GUI component choices, troubleshooting build/runtime issues, and suggesting improvements.
// All final implementation decisions, edits, and testing were performed by me.
// ChatGPT helped with debugging guidance only.
// ================================================

using System;
using System.Windows.Forms;

namespace RandomNotes
{
    public partial class FormMain : Form
    {

        // Keeps track of the currently opened file path
        private string currentFilePath = string.Empty;

        // Tracks whether the document has unsaved changes
        private bool isModified = false;

        public FormMain()
        {
            InitializeComponent();

            // Load background music when the app starts
            axWindowsMediaPlayer1.URL = "U2 - Beautiful Day.mp3";

            // Loop the song continuously
            axWindowsMediaPlayer1.settings.setMode("loop", true);

            // Start playing automatically
            axWindowsMediaPlayer1.Ctlcontrols.play();

        }

        private void richTextBoxEditor_TextChanged(object sender, EventArgs e)
        {
            // Mark the document as modified when the user types
            isModified = true;
        }

        private void monthCalendarGuatemala_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime today = DateTime.Today;
            DateTime selectedDate = e.Start;

            int daysLeft = (selectedDate - today).Days;

            if (daysLeft > 0)
            {
                labelCountdownGuatemala.Text =
                    daysLeft + " days until your Guatemala trip ✈️";
            }
            else if (daysLeft == 0)
            {
                labelCountdownGuatemala.Text =
                    "Your Guatemala trip is today! 🎉";
            }
            else
            {
                labelCountdownGuatemala.Text =
                    "This date has already passed.";
            }
        }

        private void openToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();

            // Only show text files by default
            openDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                // Load file contents into the editor
                richTextBoxEditor.Text =
                    System.IO.File.ReadAllText(openDialog.FileName);

                // Store the file path
                currentFilePath = openDialog.FileName;

                // Reset modified flag
                isModified = false;
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // If no file has been saved yet, trigger Save As
            if (string.IsNullOrEmpty(currentFilePath))
            {
                SaveAs();
            }
            else
            {
                // Overwrite existing file
                System.IO.File.WriteAllText(
                    currentFilePath,
                    richTextBoxEditor.Text);

                isModified = false;
            }
        }
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveAs();
        }

        private void SaveAs()
        {
            SaveFileDialog saveDialog = new SaveFileDialog();

            // Default file type
            saveDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                System.IO.File.WriteAllText(
                    saveDialog.FileName,
                    richTextBoxEditor.Text);

                currentFilePath = saveDialog.FileName;
                isModified = false;
            }
        }

        // ================= FILE MENU ACTIONS =================

        // NEW — clears the editor
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBoxEditor.Clear();
        }

        // OPEN — load a .txt or .rtf file
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "Text Files (*.txt)|*.txt|Rich Text (*.rtf)|*.rtf";

            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                if (openDialog.FileName.EndsWith(".rtf"))
                    richTextBoxEditor.LoadFile(openDialog.FileName);
                else
                    richTextBoxEditor.Text = System.IO.File.ReadAllText(openDialog.FileName);
            }

        }

        // SAVE — quick save (defaults to Save As)
        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            saveAsToolStripMenuItem_Click(sender, e);
        }

        // SAVE AS — choose file location
        private void saveAsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "Text Files (*.txt)|*.txt|Rich Text (*.rtf)|*.rtf";

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                if (saveDialog.FileName.EndsWith(".rtf"))
                    richTextBoxEditor.SaveFile(saveDialog.FileName);
                else
                    System.IO.File.WriteAllText(saveDialog.FileName, richTextBoxEditor.Text);
            }

        }

        // EXIT — close the app
        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
