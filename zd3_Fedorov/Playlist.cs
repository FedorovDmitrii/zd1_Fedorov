using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zd3_Fedorov
{
    class Playlist
    {
        private List<Song> list;
        private int currentIndex;
        // Конструктор. Создает пустой плейлист.
        public Playlist()
        {
            list = new List<Song>();
            currentIndex = 0;
        }
        // Получает текущую песню в плейлисте.
        public Song CurrentSong()
        {
            if (list.Count == 0)
            {
                throw new IndexOutOfRangeException("Невозможно получить текущую аудиозапись для пустого плейлиста!");
            }
            return list[currentIndex];
        }
        // Добавление песен
        // Добавляет новую песню в плейлист.
        public void AddSong(Song song)
        {
            list.Add(song);
        }
        // Добавляет новую песню в плейлист по отдельным параметрам.
        public void AddSong(string author, string title, string filename)
        {
            Song song = new Song(author, title, filename);
            list.Add(song);
        }
        // Навигация
        // Переключает на следующую песню.
        public void NextSong()
        {
            if (list.Count == 0)
            {
                throw new InvalidOperationException("Плейлист пуст.");
            }
            currentIndex = (currentIndex + 1) % list.Count;
        }
        // Переключает на предыдущую песню.
        public void PreviousSong()
        {
            if (list.Count == 0)
            {
                throw new InvalidOperationException("Плейлист пуст.");
            }
            currentIndex = (currentIndex - 1 + list.Count) % list.Count;
        }
        // Переключает на песню по указанному индексу.
        public void GoTo(int index)
        {
            if (index < 0 || index >= list.Count)
            {
                throw new IndexOutOfRangeException("Указан неверный индекс.");
            }
            currentIndex = index;
        }
        // Переключает на первую песню.
        public void GoToStart()
        {
            if (list.Count == 0)
            {
                throw new InvalidOperationException("Плейлист пуст.");
            }
            currentIndex = 0;
        }
        // Удаление песен
        // Удаляет песню по индексу.
        public void RemoveSong(int index)
        {
            if (index < 0 || index >= list.Count)
            {
                throw new IndexOutOfRangeException("Неверный индекс для удаления.");
            }
            list.RemoveAt(index);
            if (currentIndex >= list.Count && list.Count > 0)
            {
                currentIndex = list.Count - 1;
            }
        }
        // Удаляет первую найденную песню, совпадающую с указанной.
        public bool RemoveSong(Song song)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Author == song.Author && list[i].Title == song.Title)
                {
                    list.RemoveAt(i);
                    if (currentIndex >= list.Count && list.Count > 0)
                    {
                        currentIndex = list.Count - 1;
                    }
                    return true;
                }
            }
            return false;
        }
        // Очищает весь плейлист.
        public void ClearPlaylist()
        {
            list.Clear();
            currentIndex = 0;
        }
        // Вспомогательные методы
        // Возвращает количество песен в плейлисте.
        public int Count()
        {
            return list.Count;
        }
        // Возвращает все песни из плейлиста в виде списка строк.
        public List<string> GetAllSongs()
        {
            List<string> result = new List<string>();
            for (int i = 0; i < list.Count; i++)
            {
                result.Add(i + ": " + list[i].Author + " - " + list[i].Title);
            }
            return result;
        }
    }
}
