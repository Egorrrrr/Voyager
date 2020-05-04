using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Cities;
namespace TheWork


{
    public partial class Form2 : Form
    {
        //Form1 v = new Form1();
        bool addinprgoress = false;
        int CountC = 0;
        int CountR = 0;
        public Form2()
        {
            InitializeComponent();
        }
        public void Adder(int times)
        {
            
            
                CountC += 1;
                CountR += 1;
                Grid.ColumnCount = CountC;
                Grid.Rows.Add();
                Grid.Columns[CountC - 1].HeaderCell.Value = "C" + (CountC-1);
                Grid.Rows[CountR - 1].HeaderCell.Value = "C" + (CountR - 1);
                Grid.Columns[CountC - 1].Width = 40;
                Grid.Rows[CountR - 1].Cells[CountC - 1].ReadOnly = true;
            
        }
        public void Clear()
        {
            Grid.Rows.Clear();
            Grid.Columns.Clear();
            CountC = 0;
            CountR = 0;
        }

        private void Grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (CountR < 7)
            {
                CountC += 1;
                CountR += 1;
                Grid.ColumnCount = CountC;
                Grid.Rows.Add();
                Grid.Columns[CountC - 1].HeaderCell.Value = CountC + "A";
                Grid.Rows[CountR - 1].HeaderCell.Value = CountR + "A";
                Grid.Columns[CountC - 1].Width = 40;
                Grid.Rows[CountR - 1].Cells[CountC - 1].ReadOnly = true;
            }
        }

        private void Grid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (!addinprgoress)
                {
                    string val = Grid.CurrentCell.Value.ToString();
                    if (!uint.TryParse(val, out uint a))
                    {
                        val = val.Remove(val.Length - 1);
                        Grid.CurrentCell.Value = val;
                    }
                    else
                    {
                        int r = e.RowIndex;
                        int c = e.ColumnIndex;
                        Grid.Rows[c].Cells[r].Value = val;
                    }
                }
            }
            catch (Exception)
            {

            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                Grid.Rows.RemoveAt(CountR - 1);
                Grid.ColumnCount = CountC - 1;
                CountC -= 1;
                CountR -= 1;
            }
            catch (Exception)
            {

            }
        }

        private void OpenFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

            try
            {
                uint[,] f;
                string a = openFileDialog1.FileName;
                StreamReader b = new StreamReader(a);
                string c = "";
                c = b.ReadToEnd();
                string[] h = c.Split('\n');
                string[] h2 = h[0].Split(' ');
                if (h2.Length != h.Length)
                {
                    throw new Exception("net");
                }
                f = new uint[h2.Length, h.Length];
                for (int i = 0; i < h.Length; i++)
                {
                    string[] r = h[i].Split(' ');

                    for (int j = 0; j < h.Length; j++)
                    {
                        f[i, j] = uint.Parse(r[j]);
                    }
                }
                for (int i = 0; i < h.Length; i++)
                {
                    for (int j = 0; j < h.Length; j++)
                    {
                    }
                }
                ToGrid(f);

            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка");
            }
        }
        public void ToGrid(uint[,] a)
        {
            addinprgoress = true;
            Clear();
            Adder(a.GetLength(0));
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(0); j++)
                {
                    Grid[j, i].Value = a[i, j].ToString();

                }
            }
            addinprgoress = false;

        }
        public double Dstnse(City a, City b)
        {

                double dx = (double)a.X - b.X;
                double dy = (double)a.Y - b.Y;
            return Math.Sqrt(dx * dx + dy * dy);
        }
        public void AddFromMap(List<City> a)
        {
            Clear();
            for (int i = 0; i < a.Count; i++)
            {
                CountC += 1;
                CountR += 1;
                Grid.ColumnCount = CountC;
                Grid.Rows.Add();
                Grid.Columns[CountC - 1].Width = 30;
                Grid.Rows[CountR - 1].Height = 30;
                
            }
            CountC = +1;
            for (int i = 0; i < a.Count; i++)
            {
                Grid.Rows[i].HeaderCell.Value = a[i].Name;
                for (int j = 0; j < a.Count; j++)
                {
                    double ds = Dstnse(a[i], a[j]);
                    if (ds != 0)
                    {
                        Grid[i, j].Value = ds;
                        Grid[j, i].Value = Grid[i, j].Value;
                    }
                    Grid.Columns[j].HeaderCell.Value = a[j].Name;
                    label1.Text = i + " ; " + j;
                }

            }

        }
        private void Button3_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }
    }
}
