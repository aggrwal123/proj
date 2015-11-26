using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace BabyNames
{
    public partial class BabyNamesFinder : Form
    {
        public BabyNamesFinder()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string gender = cboGender.SelectedItem.ToString().ToLower();
            int year = Convert.ToInt32(cboYear.SelectedItem.ToString());
            int top = Convert.ToInt32(cboType.SelectedItem.ToString());

            if (gender == "both") top = top / 2;

            string s = Application.StartupPath+"/BabyNames";
            DirectoryInfo d = new DirectoryInfo(s);
            FileInfo[] fs = d.GetFiles();


            List<FileInfo> ar = new List<FileInfo>();
            foreach (FileInfo f in fs)
            {
                string fname = f.Name.ToLower();
                int yr = int.Parse(fname.Substring(fname.Length - 12, 4));

                if ((gender == "male" || gender == "female") && yr == year)
                {
                    if (fname.StartsWith(gender))
                        ar.Add(f);
                }
                else if (yr == year)
                    ar.Add(f);


            }

            foreach (FileInfo ft in ar)
            {
                StreamReader sr = ft.OpenText();
                
                int i = 0;
                int line = 1;
                listBox1.Items.Clear();
                while (!sr.EndOfStream)
                {
                    string str = sr.ReadLine();
                    
                    string[] strar = str.Split(',');
                    
                    if (line != 1)
                    {
                        listBox1.Items.Add(strar[0].Substring(1,strar[0].Length-2));
                    }
                   if (top != 0)
                    {
                        if (i < top)
                            i++;
                        else
                            break;
                    }

                    line++;
                }
            }

            
        }

        private void BabyNamesFinder_Load(object sender, EventArgs e)
        {
            for (int i = 1944; i <= 2013; i++)
                cboYear.Items.Add(i);

            cboYear.SelectedIndex = 0;
            cboGender.SelectedIndex = 0;
            cboType.SelectedIndex = 0;

            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            BabyNameComparisonChart f = new BabyNameComparisonChart();
            f.Show();
        }
    }
}
