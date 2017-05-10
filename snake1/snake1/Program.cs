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
			//p1.Draw();
			
			Point p2 = new Point(4,5,'#');
			//p2.Draw();

			Point p3 = new Point(10, 8, '@');

			List<Point> pList = new List<Point>();
			pList.Add(p1);
			pList.Add(p2);
			pList.Add(p3);
			pList.Add(new Point(15, 15, '%'));


			foreach (Point p in pList)
			{
				p.Draw();
			}
		


			Console.ReadLine();
		
		}
		
	}
}
