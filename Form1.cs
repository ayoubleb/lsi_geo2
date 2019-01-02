using SharpMap.Data.Providers;
using SharpMap.Layers;
using System;
using System.Data;

using System.Windows.Forms;
using o = Npgsql;
using PuissanceStatus;
using System.Drawing;
using System.Collections.Generic;

namespace ExShMap
{
    public partial class Form1 : Form
    {
        string str = "server=localhost;port=5432;database=ville;user=postgres;pwd=0996KING";
        o.NpgsqlConnection cnx;
        o.NpgsqlCommand cmd;
        o.NpgsqlDataAdapter ada;
        DataTable dt;
        ToolTip tt;
        Status st = new Status();

        List<double> r, x, y;

        public Form1()
        {
            InitializeComponent();
            st.Location = new Point(700, 400);
            this.Controls.Add(st);
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            tt = new ToolTip();

            cnx = new o.NpgsqlConnection(str);
            cmd = new o.NpgsqlCommand("select rayon AS r, ST_X(ST_Centroid(center)) AS x, ST_Y(ST_Centroid(center)) AS y from bts", cnx);

            ada = new o.NpgsqlDataAdapter(cmd);

            dt = new DataTable();
            ada.Fill(dt);
            grd.DataSource = dt;
            VectorLayer lr = new VectorLayer("bts");
            lr.DataSource = new PostGIS(str, "bts", "center", "id");
            r = new List<double>();
            x = new List<double>();
            y = new List<double>();
            foreach (DataRow row in dt.Rows)
            {
                r.Add(double.Parse(row["r"].ToString()));
                x.Add(double.Parse(row["x"].ToString()));
                y.Add(double.Parse(row["y"].ToString()));
            }
            mpBx.Map.Layers.Add(lr);
            mpBx.Map.ZoomToExtents();
            mpBx.Refresh();
        }

        private void mapZoomToolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void mpBx_Click(object sender, EventArgs e)
        {

        }

        private void mpBx_MouseMove(GeoAPI.Geometries.Coordinate worldPos, MouseEventArgs imagePos)
        {
                 
           tt.Show(worldPos.ToString(),mpBx);
           
           int min = 0, btsr = 0;
           double d = 0, d2=0;
           d = Math.Sqrt((worldPos.X - x[0]) * (worldPos.X - x[0]) + (worldPos.Y - y[0]) * (worldPos.Y - y[0]));

            for (int i = 1; i < x.Count; i++)
            {
               d2 = Math.Sqrt((worldPos.X - x[i]) * (worldPos.X - x[i]) + (worldPos.Y - y[i]) * (worldPos.Y - y[i]));
                if (d2 < d)
                {
                    d = d2;
                    btsr = i;
                }

            }
            double pas = r[btsr] / 5;

            int nb = Math.Max(5 - (int)(d / pas), 0);
            st.Afficher(nb);
            
           Text = "connected Antenne is : "+ btsr.ToString();
           
        }

        private void mpBx_MouseMove(object sender, EventArgs e)
        {
            /*
           // tt.Show(e.ToString(), mpBx, e.Location);
            int min = 0, btsr = 0;
            double d = 0, d2;
           // d = Math.Sqrt((e.X - x[0]) * (e.X - x[0]) + (e.Y - y[0]) * (e.Y - y[0]));

            for (int i = 1; i < x.Count; i++)
            {
               // d2 = Math.Sqrt((e.X - x[i]) * (e.X - x[i]) + (e.Y - y[i]) * (e.Y - y[i]));
                if (d2 < d)
                {
                    d = d2;
                    btsr = i;
                }

            }
            //int pas =(int) r[btsr] / 5;
            //int nb = Math.Max(5 - ((int)d / 20), 0);
            //st.Afficher(nb);
            */
           // Text = e.;

        }

        private void Form_MouseDown3(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    MessageBox.Show("Left Button Click");
                    break;
                case MouseButtons.Right:
                    MessageBox.Show("Right Button Click");
                    break;
                default:
                    break;
            }
        }
        /*
        private void Form_MouseMove(object sender, MouseEventArgs e)
        {
            tt.Show(e.Location.ToString(), mpBx, e.Location);
            int min=0,btsr=0;
            double d = 0,d2;
            d = Math.Sqrt((e.X - x[0]) * (e.X - x[0]) + (e.Y - y[0]) * (e.Y - y[0]));

            for (int i = 1; i < x.Count; i++)
            {
                d2 = Math.Sqrt((e.X - x[i]) * (e.X - x[i]) + (e.Y - y[i]) * (e.Y - y[i]));
                if(d2<d)
                {
                    d = d2;
                    btsr = i;
                }

            }
            //int pas =(int) r[btsr] / 5;
            //int nb = Math.Max(5 - ((int)d / 20), 0);
            //st.Afficher(nb);
            Text = btsr.ToString();

        }
        */
    }
}
