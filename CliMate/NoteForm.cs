using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CliMate
{
    public partial class NoteForm : Form
    {
        private Note note;
        public NoteForm(Note note)
        {
            InitializeComponent();
            this.note = note;
            UpdateNoteForm();
            if (note == null)
                System.Diagnostics.Debug.WriteLine("Bigger error");
        }

        private void UpdateNoteForm()
        {
            richTextBox1.Text = "";
            if (note == null)
            {
                System.Diagnostics.Debug.WriteLine("Error");
                return;
            }
            int i = 0;
            foreach(string x in note.notes)
            {
                richTextBox1.Text += i + ") ";
                richTextBox1.Text += x;
                richTextBox1.Text += "\r\n";
                i++;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(richTextBox2.Text))
            {
                return;
            }
            note.addNote(richTextBox2.Text + "\r\n");
            note.saveNote();
            richTextBox2.Text = "";
            UpdateNoteForm();
        }

         private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
