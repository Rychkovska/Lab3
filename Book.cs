using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
	public class Book
	{
		public string Title;
		public string Author;
		public int NumPages;
		public int WordCount;
		public string Publisher;
		public int YearPublished;
		public string Language;
		public string Genre;


		public double CalculateWordsPerPage()
		{
			if (NumPages > 0)
			{
				return(int)((double)WordCount / NumPages);
			}
			else
			{
				Console.WriteLine("Кількість сторінок не може бути 0 або менше.");
				return 0;
			}
		}
		public string IsLargeBook()
		{
			if (NumPages >= 500)
			{
				return "Це велика книга";
			}
			else
			{
				return "Це не велика книга";
			}
		}
	}
}
