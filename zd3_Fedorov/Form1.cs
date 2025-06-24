using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zd3_Fedorov
{
    public partial class Form1 : Form
    {
        private Playlist playlist = new Playlist();
        public Form1()
        {
            InitializeComponent();
            UpdateUI();
        }
        private void UpdateUI()
        {
            listBoxSongs.Items.Clear();
            foreach (string item in playlist.GetAllSongs())
            {
                listBoxSongs.Items.Add(item);
            }
            try
            {
                labelCurrentSong.Text = "Текущая песня: " + playlist.CurrentSong().ToString();
            }
            catch
            {
                labelCurrentSong.Text = "Текущая песня: —";
            }
        }
        private void buttonAddByFields_Click(object sender, EventArgs e)
        {
            string author = textBoxAuthor.Text.Trim();
            string title = textBoxTitle.Text.Trim();
            string filename = textBoxFileName.Text.Trim();

            if (string.IsNullOrEmpty(author) || string.IsNullOrEmpty(title))
            {
                MessageBox.Show("Введите автора и название.");
                return;
            }
            playlist.AddSong(author, title, filename);
            UpdateUI();
            textBoxAuthor.Clear();
            textBoxTitle.Clear();
            textBoxFileName.Clear();
        }
        private void buttonNext_Click(object sender, EventArgs e)
        {
            playlist.NextSong();
            UpdateUI();
        }
        private void buttonPrev_Click(object sender, EventArgs e)
        {
            playlist.PreviousSong();
            UpdateUI();
        }
        private void buttonGoToStart_Click(object sender, EventArgs e)
        {
            playlist.GoToStart();
            UpdateUI();
        }
        private void buttonRemoveByIndex_Click(object sender, EventArgs e)
        {
            string input = textBoxInputRemove.Text.Trim();
            if (int.TryParse(input, out int index))
            {
                playlist.RemoveSong(index);
                UpdateUI();
            }
            else
            {
                MessageBox.Show("Неверный индекс.");
            }
        }
        private void buttonRemoveByValue_Click(object sender, EventArgs e)
        {
            string input = textBoxInputRemove.Text.Trim();
            string[] parts = input.Split('-');
            if (parts.Length == 2)
            {
                string author = parts[0].Trim();
                string title = parts[1].Trim();
                playlist.RemoveSong(new Song(author, title, ""));
                UpdateUI();
            }
            else
            {
                MessageBox.Show("Формат: Автор - Название");
            }
        }
        private void buttonClear_Click(object sender, EventArgs e)
        {
            playlist.ClearPlaylist();
            UpdateUI();
        }
    }
}
