namespace Binary_clock
{
    public partial class Form1 : Form
    {
        DateTime now;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();

        }

        public void ceas()
        {
            int h, h1, h2;
            h = now.Hour;
            h2 = h % 10;
            h /= 10;
            h1 = h % 10;
            int a = 0, b = 0, c = 0, d = 0;
            if (h1 == 1)
            {
                a = 0; b = 0; c = 0; d = 1;
            }
            if (h1 == 2)
            {
                a = 0; b = 0; c = 1; d = 0;
            }
            label1.Text = c.ToString();
            label2.Text = d.ToString();
            a = 0; b = 0; c = 0; d = 0;
            if (h2 == 0)
            {
                a = 0; b = 0; c = 0; d = 0;
            }
            if (h2 == 1)
            {
                a = 0; b = 0; c = 0; d = 1;
            }
            if (h2 == 2)
            {
                a = 0; b = 0; c = 1; d = 0;
            }
            if (h2 == 3)
            {
                a = 0; b = 0; c = 1; d = 1;
            }
            if (h2 == 4)
            {
                a = 0; b = 1; c = 0; d = 0;
            }
            if (h2 == 5)
            {
                a = 0; b = 1; c = 0; d = 1;
            }
            if (h2 == 6)
            {
                a = 0; b = 1; c = 1; d = 0;
            }
            if (h2 == 7)
            {
                a = 0; b = 1; c = 1; d = 1;
            }
            if (h2 == 8)
            {
                a = 1; b = 0; c = 0; d = 0;
            }
            if (h2 == 9)
            {
                a = 1; b = 0; c = 0; d = 1;
            }
            label3.Text = a.ToString();
            label4.Text = b.ToString();
            label5.Text = c.ToString();
            label6.Text = d.ToString();
            int m, m1, m2;
            m = now.Minute;
            m2 = m % 10;
            m /= 10;
            m1 = m % 10;
            a = 0; b = 0; c = 0; d = 0;
            if (m1 == 0)
            {
                a = 0; b = 0; c = 0; d = 0;
            }
            if (m1 == 1)
            {
                a = 0; b = 0; c = 0; d = 1;
            }
            if (m1 == 2)
            {
                a = 0; b = 0; c = 1; d = 0;
            }
            if (m1 == 3)
            {
                a = 0; b = 0; c = 1; d = 1;
            }
            if (m1 == 4)
            {
                a = 0; b = 1; c = 0; d = 0;
            }
            if (m1 == 5)
            {
                a = 0; b = 1; c = 0; d = 1;
            }
            label7.Text = b.ToString();
            label8.Text = c.ToString();
            label9.Text = d.ToString();
            a = 0; b = 0; c = 0; d = 0;
            if (m2 == 0)
            {
                a = 0; b = 0; c = 0; d = 0;
            }
            if (m2 == 1)
            {
                a = 0; b = 0; c = 0; d = 1;
            }
            if (m2 == 2)
            {
                a = 0; b = 0; c = 1; d = 0;
            }
            if (m2 == 3)
            {
                a = 0; b = 0; c = 1; d = 1;
            }
            if (m2 == 4)
            {
                a = 0; b = 1; c = 0; d = 0;
            }
            if (m2 == 5)
            {
                a = 0; b = 1; c = 0; d = 1;
            }
            if (m2 == 6)
            {
                a = 0; b = 1; c = 1; d = 0;
            }
            if (m2 == 7)
            {
                a = 0; b = 1; c = 1; d = 1;
            }
            if (m2 == 8)
            {
                a = 1; b = 0; c = 0; d = 0;
            }
            if (m2 == 9)
            {
                a = 1; b = 0; c = 0; d = 1;
            }
            label10.Text = a.ToString();
            label11.Text = b.ToString();
            label12.Text = c.ToString();
            label13.Text = d.ToString();
            int s, s1, s2;
            s = now.Second;
            s2 = s % 10;
            s /= 10;
            s1 = s % 10;
            a = 0; b = 0; c = 0; d = 0;
            if (s1 == 0)
            {
                a = 0; b = 0; c = 0; d = 0;
            }
            if (s1 == 1)
            {
                a = 0; b = 0; c = 0; d = 1;
            }
            if (s1 == 2)
            {
                a = 0; b = 0; c = 1; d = 0;
            }
            if (s1 == 3)
            {
                a = 0; b = 0; c = 1; d = 1;
            }
            if (s1 == 4)
            {
                a = 0; b = 1; c = 0; d = 0;
            }
            if (s1 == 5)
            {
                a = 0; b = 1; c = 0; d = 1;
            }
            label14.Text = b.ToString();
            label15.Text = c.ToString();
            label16.Text = d.ToString();
            a = 0; b = 0; c = 0; d = 0;
            if (s2 == 0)
            {
                a = 0; b = 0; c = 0; d = 0;
            }
            if (s2 == 1)
            {
                a = 0; b = 0; c = 0; d = 1;
            }
            if (s2 == 2)
            {
                a = 0; b = 0; c = 1; d = 0;
            }
            if (s2 == 3)
            {
                a = 0; b = 0; c = 1; d = 1;
            }
            if (s2 == 4)
            {
                a = 0; b = 1; c = 0; d = 0;
            }
            if (s2 == 5)
            {
                a = 0; b = 1; c = 0; d = 1;
            }
            if (s2 == 6)
            {
                a = 0; b = 1; c = 1; d = 0;
            }
            if (s2 == 7)
            {
                a = 0; b = 1; c = 1; d = 1;
            }
            if (s2 == 8)
            {
                a = 1; b = 0; c = 0; d = 0;
            }
            if (s2 == 9)
            {
                a = 1; b = 0; c = 0; d = 1;
            }
            label17.Text = a.ToString();
            label18.Text = b.ToString();
            label19.Text = c.ToString();
            label20.Text = d.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            oracurenta.Text = DateTime.Now.ToString();
            now = DateTime.Now;
            ceas();
        }

        private void label21_Click(object sender, EventArgs e)
        {

        }
    }
}
    