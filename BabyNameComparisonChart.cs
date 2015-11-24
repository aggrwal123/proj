using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.IO;
namespace BabyNames
{
    public partial class BabyNameComparisonChart : Form
    {
        public BabyNameComparisonChart()
        {
            InitializeComponent();
        }

        private void BabyNameComparisonChart_Load(object sender, EventArgs e)
        {
            for (int i = 1944; i <= 2013; i++)
                cboYear.Items.Add(i);

            cboYear.SelectedIndex = 0;
            cboGender.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtName.Text.Length == 0)
                {
                    MessageBox.Show("Sorry! Name cannot be blank...");
                    return;
                }


                string nvar = txtName.Text.ToLower();
                string g = cboGender.SelectedItem.ToString().ToLower();
                int y = Convert.ToInt32(cboYear.SelectedItem.ToString());


                string s = Application.StartupPath + "/BabyNames";
                DirectoryInfo d = new DirectoryInfo(s);
                FileInfo[] fs = d.GetFiles();


                List<FileInfo> ar = new List<FileInfo>();
                foreach (FileInfo f in fs)
                {
                    string fname = f.Name.ToLower();
                    int yr = int.Parse(fname.Substring(fname.Length - 12, 4));

                    if (yr >= y)
                    {
                        if ((g == "male" || g == "female") && fname.StartsWith(g))
                            ar.Add(f);
                        else if (g == "both")
                            ar.Add(f);
                    }
                }

                List<string> years = new List<string>();
                List<int> count = new List<int>();
                foreach (FileInfo ft in ar)
                {
                    StreamReader sr = ft.OpenText();
                    int line = 1;
                    while (!sr.EndOfStream)
                    {
                        string yr = ft.Name.Substring(ft.Name.Length - 12, 4);


                        string str = sr.ReadLine();
                        string[] strar = str.Split(',');
                        if (line != 1)
                        {
                            string n = strar[0].Replace("\"", "");
                            string r = strar[1].Replace("\"", "");
                            int c = int.Parse(strar[2].Replace("\"", "").Replace("=", ""));
                            if (n.ToLower() == nvar.ToLower())
                            {
                                years.Add(yr);
                                count.Add(c);
                            }
                        }
                        line++;
                    }
                }


                if(years.Count==0)
                {
                    MessageBox.Show("Sorry! No data found for " + txtName.Text);
                    return;
                }

                // Data arrays.
                string[] seriesArray = years.ToArray<string>(); 
                int[] pointsArray = count.ToArray<int>(); 

                                                         
                this.chart1.Palette = ChartColorPalette.Bright;
                // Set title.
                this.chart1.Titles.Clear();
                this.chart1.Series.Clear();
                
                this.chart1.Titles.Add("Yearwise Popularity Amount Chart for " + txtName.Text.ToUpper());
                // Add series.
           
                for (int i = 0; i < seriesArray.Length; i++)
                {
                    // Add series.
                    Series series = this.chart1.Series.Add(seriesArray[i]);
                    series.AxisLabel = "Years.......>>>>>>";
                    // Add point.
                    series.Points.Add(pointsArray[i]);
                    
                        
                }
                
                
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }
    }
}
