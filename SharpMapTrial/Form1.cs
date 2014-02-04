using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SharpMap;

namespace SharpMapTrial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SharpMap.Layers.VectorLayer vlay = new SharpMap.Layers.VectorLayer("States");
            //vlay.DataSource = new SharpMap.Data.Providers.ShapeFile("path_to_data\\states_ugl.shp", true);
             vlay.DataSource = new SharpMap.Data.Providers.ShapeFile(" F:\\delete\\SharpMapTrial\\states_ugl.shp", true);
           
            mapBox1.Map.Layers.Add(vlay);
            mapBox1.Map.ZoomToExtents();
            mapBox1.Refresh();
        }
    }
}
