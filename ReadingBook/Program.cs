namespace ReadingBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int totalChapters = 4;
            BookChapter[] chapters = new BookChapter[]
            {
                new BookChapter{StartPage = 1, EndPage = 4},
                new BookChapter{StartPage = 5, EndPage = 7},
                new BookChapter{StartPage = 9, EndPage = 16},
                new BookChapter{StartPage = 17, EndPage = 26}
            };
            int currentPage = 7;
            int remainingChapters = BookReader.CountRemainingChapters(totalChapters, chapters, currentPage);
            Console.WriteLine(remainingChapters);
            Console.ReadLine();
        }
    }
}