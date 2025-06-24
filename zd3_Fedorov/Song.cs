using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zd3_Fedorov
{
    // Представляет одну аудиозапись
    public struct Song
    {
        public string Author;
        public string Title;
        public string Filename;
        // Конструктор для создания новой песни
        public Song(string author, string title, string filename)
        {
            Author = author;
            Title = title;
            Filename = filename;
        }
        // Возвращает строковое представлнеие песни
        public override string ToString()
        {
            return $"{Author} - {Title}";
        }
    }
}
