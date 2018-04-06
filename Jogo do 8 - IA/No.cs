using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jogo_do_8
{
    public class No
    {
        public int Id;
        public int ParentId;
        public Point Location;
        public bool IsVisited;
        public List<Point> NeighborHood { get; private set; }


        public No(int id, Point location, int parentId = -1)
        {
            ParentId = parentId;
            Id = id;
            Location = location;
            IsVisited = false;

            ChangeNeighborHood(location);

        }

        public void ChangeNeighborHood(Point location)
        {
            NeighborHood = new List<Point>();
            //==== 01
            if (location == new Point(10, 10))
            {
                NeighborHood.Add(new Point(50, 10));
                NeighborHood.Add(new Point(10, 50));
            }
            //==== 02
            else if (location == new Point(50, 10))
            {
                NeighborHood.Add(new Point(10, 10));
                NeighborHood.Add(new Point(90, 10));
                NeighborHood.Add(new Point(50, 50));
            }
            //==== 03
            else if (location == new Point(90, 10))
            {
                NeighborHood.Add(new Point(50, 10));
                NeighborHood.Add(new Point(90, 50));
            }
            //==== 04
            else if (location == new Point(10, 50))
            {
                NeighborHood.Add(new Point(10, 10));
                NeighborHood.Add(new Point(50, 50));
                NeighborHood.Add(new Point(10, 90));
            }
            //==== 05
            else if (location == new Point(50, 50))
            {
                NeighborHood.Add(new Point(50, 10));
                NeighborHood.Add(new Point(90, 50));
                NeighborHood.Add(new Point(50, 90));
                NeighborHood.Add(new Point(10, 50));
            }
            //==== 06
            else if (location == new Point(90, 50))
            {
                NeighborHood.Add(new Point(90, 10));
                NeighborHood.Add(new Point(50, 50));
                NeighborHood.Add(new Point(90, 90));
            }
            //==== 07
            if (location == new Point(10, 90))
            {
                NeighborHood.Add(new Point(10, 50));
                NeighborHood.Add(new Point(50, 90));
            }
            //==== 08
            else if (location == new Point(50, 90))
            {
                NeighborHood.Add(new Point(50, 50));
                NeighborHood.Add(new Point(90, 90));
                NeighborHood.Add(new Point(10, 90));
            }
            //==== 00
            else if (location == new Point(90, 90))
            {
                NeighborHood.Add(new Point(90, 50));
                NeighborHood.Add(new Point(50, 90));
            }

        }
        
        public No Clone()
        {
            var no = new No(Id, Location, ParentId)
            {
                IsVisited = IsVisited
            };

            foreach (var point in NeighborHood)
            {
                no.NeighborHood.Insert(no.NeighborHood.Count, point);
            }

            return no;
        }

        public static List<Point> Objetivo()
        {
            var listPoints = new List<Point>
            {
                new Point(90, 90),
                new Point(10, 10),
                new Point(50, 10),
                new Point(90, 10),
                new Point(10, 50),
                new Point(50, 50),
                new Point(90, 50),
                new Point(10, 90),
                new Point(50, 90)
            };
            return listPoints;
        }
        
        public static List<Point> Sortear()
        {
            var list = new List<int>();

            var listPoints = Objetivo();

            var r = new Random();

            while (list.Count < 9)
            {
                 
                var value = r.Next(0, 9);
                if (!list.Contains(value))
                    list.Add(value);
            }


            return list.Select(idx => listPoints[idx]).ToList();
        }

        public static string GetString(GroupBox group)
        {
            var a = string.Empty;
            var b = string.Empty;
            var c = string.Empty;
            var d = string.Empty;
            var e = string.Empty;
            var f = string.Empty;
            var g = string.Empty;
            var h = string.Empty;
            var i = string.Empty;


            foreach (Button control in group.Controls)
            {
                if (control.Location == new Point(10, 10))
                    a = control.Text;
                //==== 02
                else if (control.Location == new Point(50, 10))
                    b = control.Text;
                //==== 03
                else if (control.Location == new Point(90, 10))
                    c = control.Text;
                //==== 04
                else if (control.Location == new Point(10, 50))
                    d = control.Text;
                //==== 05
                else if (control.Location == new Point(50, 50))
                    e = control.Text;
                //==== 06
                else if (control.Location == new Point(90, 50))
                    f = control.Text;
                //==== 07
                if (control.Location == new Point(10, 90))
                    g = control.Text;
                //==== 08
                else if (control.Location == new Point(50, 90))
                    h = control.Text;
                //==== 00
                else if (control.Location == new Point(90, 90))
                    i = @"0";
            }

            return string.Concat(a, b, c, d, e, f, g, h, i);

        }
        
    }
}
