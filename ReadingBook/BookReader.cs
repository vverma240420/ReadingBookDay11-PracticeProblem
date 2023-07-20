using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadingBook
{
    public class BookReader
    {
        public static int CountRemainingChapters(int totalChapters, BookChapter[] chapters, int currentPage)
        {
            int remainingChapters = 0;
            for(int i=0; i<totalChapters; i++) 
            {
                if (chapters[i].StartPage<= currentPage && chapters[i].EndPage>=currentPage)
                {
                    remainingChapters = totalChapters - i;
                    break;
                }
            }
            return remainingChapters;
        }
    }
}
