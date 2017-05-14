using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake1
{
	class Program
	{
		static void Main(string[] args)
		{

			Point p1 = new Point(1,3,'*');
			p1.Draw();
			
			Point p2 = new Point(4,5,'#');
			p2.Draw();

			HorizontalLine l1=new HorizontalLine(3,5,10,'#');
			l1.Draw();

			VerticalLine l2 = new VerticalLine(40, 3, 15, '$');
			l2.Draw();

			Console.ReadLine();
		
		}
		
	}
}
