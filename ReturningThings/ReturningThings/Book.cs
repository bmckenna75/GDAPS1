using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReturningThings
{
	class Book
	{
		private string name;
		private string author;
		private int numberOfPages;
		private int pagesRead = 0;
		private int totalReads = 0;

		//constructor
		public Book(string n, string a, int p)
		{
			name = n;
			author = a;
			numberOfPages = p;
		}

		//Standard Methods
		public void ReadPages(int pagesToRead)
		{
			if (pagesToRead > 0)
			{
				pagesRead = pagesRead + pagesToRead;
				while (pagesRead >= numberOfPages)
				{
					pagesRead = pagesRead - numberOfPages;
					totalReads += 1;
				}
			}

		}

		public double TimeToFinishReading(double MinutesPerPage)
		{
			int pagesLeft = numberOfPages - pagesRead;
			return pagesLeft * MinutesPerPage;
		}

		public string BookReport()
		{
			return name + " by " + author + " has " + numberOfPages + " page(s).  You are " + pagesRead + " page(s) in, and have read the book " + totalReads + " time(s).";
		}


	}
}
