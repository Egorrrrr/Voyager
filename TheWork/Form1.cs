using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Cities;
using TheWork;


namespace TheWork
{
    public partial class Form1 : Form
    {
        int num = 0;
        int countC = 0;
        int countR = 0;
        List<City> cities = new List<City>();
        Form2 a = new Form2();

        public Form1()
        {
            InitializeComponent();
        }

        public void Cleaner()
        {
            label1.Text = string.Format("Координаты: X = 0; Y = 0");

            cities.Clear();
            TheGrid.Rows.Clear();
            TheGrid.Columns.Clear();
            listBox1.Items.Clear();
            num = 0;
            countC = 0;
            countR = 0;
            Filler();
        }
        private void Filler()
        {
            while (countC < 54)
            {
                countC += 1;
                TheGrid.ColumnCount = countC;
                TheGrid.Columns[countC - 1].Width = 7;
              
            }
            while (countR <33)
            {
                countR += 1;
                TheGrid.Rows.Add();
                TheGrid.Rows[countR - 1].Height = 7;

            }
            
        }

        private void TheGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!Exists(e.ColumnIndex, e.RowIndex) )
            {
                
                num += 1;
                string name = "C" + (num-1);
                int r = e.RowIndex;
                int c = e.ColumnIndex;
                TheGrid.CurrentCell.Value = "A";
                City a = new City(c, r, name);
                cities.Add(a);
                Clist();
                return;
            }
            else
            {
                
                int r = e.RowIndex;
                int c = e.ColumnIndex;
                string name = TheGrid.CurrentCell.Value.ToString();
                name = name.Remove(0);
                for (int i = 0; i < cities.Count; i++)
                {
                    if (cities[i].X == c && cities[i].Y == r)
                    {
                        cities.RemoveAt(i);
                    }
                }
                TheGrid.CurrentCell.Value = null;
                
                Clist();
            }
            
            
        }
        


        

        public void Clist()
        {
            listBox1.Items.Clear();
            foreach (var item in cities)
            {
                string a = string.Format(item.Name + " : " + "X = {0}, " + "Y = {1}", item.X, item.Y);
                listBox1.Items.Add(a);
                
            }
            a.AddFromMap(cities);
        }
        public bool Exists(int x, int y)
        {
            for (int i = 0; i < cities.Count; i++)
            {
                if (cities[i].X == x && cities[i].Y == y)
                {
                    return true;
                }
            }
            return false;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Cleaner();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            Filler();
            label1.Text = string.Format("Координаты: X = 0; Y = 0");

        }

        private void TheGrid_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            label1.Text = string.Format("Координаты: X = {0}; Y = {1}", e.ColumnIndex, e.RowIndex);
            //Pen a = new Pen(Brushes.White);
            // label2.Text =TheGrid.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false).Location.ToString();


        }

        private void TheGrid_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            int x = TheGrid.CurrentCell.ColumnIndex;
            int y = TheGrid.CurrentCell.RowIndex;
            label1.Text = string.Format("Координаты: X = {0}; Y = {1}", x, y);
            
        }

        private void AddR_Click(object sender, EventArgs e)
        {

            try
            {
                //Cleaner();
                uint c = uint.Parse(textBox1.Text);
                Random d = new Random();
                for (int i = 0; i < c; i++)
                {
                    int x = d.Next(0, 54);
                    int y = d.Next(0, 33);
                    City a = new City(x, y, ("C" + num));
                    if (!Exists(x, y))
                    {
                       
                        cities.Add(a);
                        //TheGrid[x, y].Value = "A";
                        
                        num += 1;
                        
                    }
                    else
                    {
                       
                        i--;
                    }

                }
                Clist();
                Draw();

            }
            catch (Exception)
            {

            }
            

        }
        public void Draw()
        {
            foreach (var item in cities)
            {
                int x = item.X;
                int y = item.Y;
                int X = TheGrid.GetCellDisplayRectangle(x, y, false).Location.X;
                int Y = TheGrid.GetCellDisplayRectangle(x, y, false).Location.Y;
                Pen p = new Pen(Brushes.Red);
                Graphics g = this.TheGrid.CreateGraphics();

                g.DrawEllipse(p, X, Y, 5, 5);
            }
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            a.Show();
            
        }

        private void TheGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Form1_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void TheGrid_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            
        }

        private void TheGrid_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void Add_Click(object sender, EventArgs e)
        {
            try
            {
                List<City> a = new List<City>();
                a.AddRange(cities);
                Random r = new Random();
                int c = r.Next(0, a.Count);
                //label2.Text = c.ToString();
                int x = a[c].X;
                int y = a[c].Y;
                a.RemoveAt(c);
                int X = TheGrid.GetCellDisplayRectangle(x, y, false).Location.X + 2;
                int Y = TheGrid.GetCellDisplayRectangle(x, y, false).Location.Y + 2;
                Graphics g = this.TheGrid.CreateGraphics();
                Pen s = new Pen(Brushes.Red);
                Pen p = new Pen(Brushes.Blue);
                g.DrawEllipse(p, X-2, Y-2, 5, 5);
                for (int i = 0; i < 1400; i++)
                {
                    int f = r.Next(0, a.Count - 1);
                    int X1 = TheGrid.GetCellDisplayRectangle(a[f].X, a[f].Y, false).Location.X + 2;
                    int Y1 = TheGrid.GetCellDisplayRectangle(a[f].X, a[f].Y, false).Location.Y + 4;
                    g.DrawLine(s, X, Y, X1, Y1);
                    X = X1;
                    Y = Y1;
                    a.RemoveAt(f);

                }
                Clist();
            }
            catch(Exception)
            {

            }
        }
        
    }
}
