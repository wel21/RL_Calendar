using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calendar_Overlay
{
    public partial class FrmCalendar : Form
    {
        public FrmCalendar()
        {
            InitializeComponent();
        }

        private void FrmCalendar_Load(object sender, EventArgs e)
        {
            DoubleBuffered = true;
        }

        private void FrmCalendar_Paint(object sender, PaintEventArgs e)
        {
            Graphics G = e.Graphics;

            G.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;

            Font F = new Font("Consolas", 11);

            Color cB = Color.FromArgb(45, 112, 197);
            Color cG = Color.FromArgb(78, 201, 176);
            Color cW = Color.FromArgb(220, 220, 220);
            Color cStr = Color.FromArgb(214, 157, 133);

            float iTopVal = (float)20.7343712;
            float iTop = 0;
            string s = "private class ";
            char sc = '"';
            SizeF sz = G.MeasureString(s, F);
            float sz1 = 0;
            G.DrawString(s, F, ToBrush(cB), 0, iTop);
            s = "Calendar";
            G.DrawString(s, F, ToBrush(cW), sz.Width, iTop);

            iTop += iTopVal;
            s = "{";
            G.DrawString(s, F, ToBrush(cW), 0, iTop);


            //next line --------------------------------------------------
            iTop += iTopVal;
            s = "    Time ";
            G.DrawString(s, F, ToBrush(cG), 0, iTop);
            sz = G.MeasureString(s, F);

            s = "t  = ";
            G.DrawString(s, F, ToBrush(cW), sz.Width, iTop);
            sz1 = sz.Width;
            sz = G.MeasureString(s, F);

            s = sc.ToString() + DateTime.Now.ToString("hh:mm:ss tt") + sc.ToString();
            G.DrawString(s, F, ToBrush(cStr), sz1 + sz.Width, iTop);
            sz1 += sz.Width;
            sz = G.MeasureString(s, F);

            s = ";";
            G.DrawString(s, F, ToBrush(cW), sz1 + sz.Width - 6, iTop);
            sz = G.MeasureString(s, F);


            //next line --------------------------------------------------
            iTop += iTopVal;
            s = "    Day ";
            G.DrawString(s, F, ToBrush(cG), 0, iTop);
            sz = G.MeasureString(s, F);

            s = "d   = ";
            G.DrawString(s, F, ToBrush(cW), sz.Width, iTop);
            sz1 = sz.Width;
            sz = G.MeasureString(s, F);

            s = sc.ToString() + DateTime.Now.ToString("dddd") + sc.ToString();
            G.DrawString(s, F, ToBrush(cStr), sz1 + sz.Width, iTop);
            sz1 += sz.Width;
            sz = G.MeasureString(s, F);

            s = ";";
            G.DrawString(s, F, ToBrush(cW), sz1 + sz.Width - 6, iTop);
            sz = G.MeasureString(s, F);


            //next line --------------------------------------------------
            iTop += iTopVal;
            s = "    Month ";
            G.DrawString(s, F, ToBrush(cG), 0, iTop);
            sz = G.MeasureString(s, F);

            s = "m = ";
            G.DrawString(s, F, ToBrush(cW), sz.Width, iTop);
            sz1 = sz.Width;
            sz = G.MeasureString(s, F);

            s = sc.ToString() + DateTime.Now.ToString("MMMM") + sc.ToString();
            G.DrawString(s, F, ToBrush(cStr), sz1 + sz.Width, iTop);
            sz1 += sz.Width;
            sz = G.MeasureString(s, F);

            s = ";";
            G.DrawString(s, F, ToBrush(cW), sz1 + sz.Width - 6, iTop);
            sz = G.MeasureString(s, F);


            //next line --------------------------------------------------
            iTop += iTopVal;
            s = "    Date ";
            G.DrawString(s, F, ToBrush(cG), 0, iTop);
            sz = G.MeasureString(s, F);

            s = "dt = ";
            G.DrawString(s, F, ToBrush(cW), sz.Width, iTop);
            sz1 = sz.Width;
            sz = G.MeasureString(s, F);

            s = sc.ToString() + DateTime.Now.ToString("dd") + sc.ToString();
            G.DrawString(s, F, ToBrush(cStr), sz1 + sz.Width, iTop);
            sz1 += sz.Width;
            sz = G.MeasureString(s, F);

            s = ";";
            G.DrawString(s, F, ToBrush(cW), sz1 + sz.Width - 6, iTop);
            sz = G.MeasureString(s, F);


            //next line --------------------------------------------------
            iTop += iTopVal;
            s = "    Year ";
            G.DrawString(s, F, ToBrush(cG), 0, iTop);
            sz = G.MeasureString(s, F);

            s = "y  = ";
            G.DrawString(s, F, ToBrush(cW), sz.Width, iTop);
            sz1 = sz.Width;
            sz = G.MeasureString(s, F);

            s = sc.ToString() + DateTime.Now.ToString("yyyy") + sc.ToString();
            G.DrawString(s, F, ToBrush(cStr), sz1 + sz.Width, iTop);
            sz1 += sz.Width;
            sz = G.MeasureString(s, F);

            s = ";";
            G.DrawString(s, F, ToBrush(cW), sz1 + sz.Width - 6, iTop);
            sz = G.MeasureString(s, F);


            //next line --------------------------------------------------
            iTop += iTopVal;
            s = "    Start ";
            G.DrawString(s, F, ToBrush(cG), 0, iTop);
            sz = G.MeasureString(s, F);

            s = "s = ";
            G.DrawString(s, F, ToBrush(cW), sz.Width, iTop);
            sz1 = sz.Width;
            sz = G.MeasureString(s, F);

            s = sc.ToString() + "Sunday" + sc.ToString();
            G.DrawString(s, F, ToBrush(cStr), sz1 + sz.Width, iTop);
            sz1 += sz.Width;
            sz = G.MeasureString(s, F);

            s = ";";
            G.DrawString(s, F, ToBrush(cW), sz1 + sz.Width - 6, iTop);
            sz = G.MeasureString(s, F);


            //next line --------------------------------------------------
            iTop += iTopVal;
            iTop += iTopVal;
            s = "    Days";
            G.DrawString(s, F, ToBrush(cG), 0, iTop);
            sz = G.MeasureString(s, F);

            s = "[] s = new ";
            G.DrawString(s, F, ToBrush(cW), sz.Width - 6, iTop);
            sz1 = sz.Width;
            sz = G.MeasureString(s, F);

            s = "Days"; 
            G.DrawString(s, F, ToBrush(cG), sz1 + sz.Width, iTop);
            sz1 += sz.Width;
            sz = G.MeasureString(s, F);

            s = "[] {";
            G.DrawString(s, F, ToBrush(cW), sz1 + sz.Width - 6, iTop);
            sz1 += sz.Width;
            sz = G.MeasureString(s, F);

            float chrW = G.MeasureString("a", F).Width;
            string[] sday = new string[] { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };
            DateTime dstart = Convert.ToDateTime(DateTime.Now.ToString("MM") + "/01/" + DateTime.Now.ToString("yyyy"));
            DateTime dend = dstart.AddMonths(1).AddDays(-1);
            int idaypos = 0;
            for (int i = 0; i < sday.Count(); i++) { if (sday[i] == dstart.ToString("ddd")) { idaypos = i; }}

            float ispace = chrW * 5;
            float ifirstsweekspace = chrW * ((idaypos-1) * 3);
            float ileft = ispace + ifirstsweekspace;


            //next line --------------------------------------------------
            iTop += iTopVal;
            for (int i=0; i< Convert.ToInt32(dend.ToString("dd")); i++)
            {
                s = (i+1).ToString();
                
                if (DateTime.Now.ToString("dd") == (i + 1).ToString("00"))
                    G.DrawString(s, new Font(F.FontFamily, 14, FontStyle.Bold), ToBrush(cG), ileft + (i + 1 < 10 ? 8 : 0) - 1, iTop - 3);
                else
                    G.DrawString(s, F, ToBrush(cStr), ileft + (i + 1 < 10 ? 8 : 0), iTop);

                G.DrawString(",", F, ToBrush(cW), ileft  + chrW + 4, iTop); 
                sz1 += sz.Width;
                sz = G.MeasureString(s, F);

                ileft += chrW * 3;

                if (Convert.ToDateTime(DateTime.Now.ToString("MM") + "/" + (i+1).ToString("00") + "/" + DateTime.Now.ToString("yyyy")).ToString ("ddd")=="Sun")
                {
                    iTop += iTopVal;
                    ileft = ispace;
                }

            }


            //next line --------------------------------------------------
            iTop += iTopVal;
            s = "    }";
            G.DrawString(s, F, ToBrush(cW), 0, iTop);


            //next line --------------------------------------------------
            iTop += iTopVal;
            iTop += iTopVal;
            s = "    private void ";
            G.DrawString(s, F, ToBrush(cB), 0, iTop);
            sz = G.MeasureString(s, F);

            s = "About()";
            G.DrawString(s, F, ToBrush(cW), sz.Width, iTop);
            sz1 = sz.Width;
            sz = G.MeasureString(s, F);


            //next line --------------------------------------------------
            iTop += iTopVal;
            s = "    {";
            G.DrawString(s, F, ToBrush(cW), 0, iTop);


            //next line --------------------------------------------------
            iTop += iTopVal;
            s = "        Console ";
            G.DrawString(s, F, ToBrush(cG), 0, iTop);
            sz = G.MeasureString(s, F);

            s = ".Write(";
            G.DrawString(s, F, ToBrush(cW), sz.Width, iTop);
            sz1 = sz.Width;
            sz = G.MeasureString(s, F);
            
            s = sc.ToString() + "By: Wel" + sc.ToString() ;
            G.DrawString(s, F, ToBrush(cStr), sz1 + sz.Width-4, iTop);
            sz1 += sz.Width;
            sz = G.MeasureString(s, F);

            s =  ");" ;
            G.DrawString(s, F, ToBrush(cW), sz1 + sz.Width - 10, iTop);
            sz1 += sz.Width;
            sz = G.MeasureString(s, F);


            //next line --------------------------------------------------
            iTop += iTopVal;
            s = "    }\n}";
            G.DrawString(s, F, ToBrush(cW), 0, iTop);
            
            Console.Write("sf");

        }

        private Brush ToBrush(Color c)
        {
            return new SolidBrush(c);
        }

        int imin = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            imin += 1;

            if (imin == 10000)
            {
                imin = 0;
                GC.Collect();
            }
            this.Invalidate();
        }
    }
}
