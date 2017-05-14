using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake1
{
	class VerticalLine
	{
		List<Point> pList;

		public VerticalLine(int x, int yUp, int yDown,char sym)
		{
			pList = new List<Point>();

			for (int y = yUp; y < yDown; y++)
			{
				pList.Add(new Point(x,y,sym));
			}
		}


		public void Draw()
		{
			foreach (Point p in pList)
			{
				p.Draw();
			}
		}

	}
}
