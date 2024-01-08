namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        Image kamien = Image.FromFile("C:\\Users\\Matura_1\\Desktop\\WinFormsApp2\\kamien1.png");
        Image nozyce = Image.FromFile("C:\\Users\\Matura_1\\Desktop\\WinFormsApp2\\nozyce1.png");
        Image papier = Image.FromFile("C:\\Users\\Matura_1\\Desktop\\WinFormsApp2\\papier1.png");
        int i = 1;
        int j = 1;
        public Form1()
        {
            InitializeComponent();

        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {


         



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (label8.Text != "Wybrales" && label9.Text != "Wybrales") { label7.Text = "Wybrales"; }


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
       
           
            label7.Text = "Wybierz";
            label8.Text = "Wybierz";
            label9.Text = "Wybierz";

            i++;
            j++;

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (label7.Text != "Wybrales" && label9.Text != "Wybrales") { label8.Text = "Wybrales"; }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (label7.Text != "Wybrales" && label8.Text != "Wybrales") { label9.Text = "Wybrales"; }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            Random r = new Random();
            int x = r.Next(1, 4);
            if (x == 1) { pictureBox1.Image = papier; }
            if (x == 2) { pictureBox1.Image = kamien; }
            if (x == 3) { pictureBox1.Image = nozyce; }


            if (pictureBox1.Image == papier)
            {
                if (label7.Text == "Wybrales")
                {
                    label5.Text = j.ToString();
                    
                }
                if (label8.Text == "Wybrales")
                {
                    label4.Text = i.ToString();
                    
                }
                if (label9.Text == "Wybrales")
                {
                    label4.Text = i.ToString();
                    label5.Text = j.ToString();
                    
                }
            }
            //7 - kamien
            //8 - nozyce
            //9 - papier

            if (pictureBox1.Image == kamien)
            {
                if (label9.Text == "Wybrales")
                {
                    label4.Text = i.ToString();
                    
                }
                if (label8.Text == "Wybrales")
                {
                    label5.Text = j.ToString();
                    
                }
                if (label7.Text == "Wybrales")
                {
                    label4.Text = i.ToString();
                    label5.Text = j.ToString();
                    
                }
            }

            if (pictureBox1.Image == nozyce)
            {
                if (label7.Text == "Wybrales")
                {
                    label4.Text = i.ToString();
                    
                }
                if (label9.Text == "Wybrales")
                {
                    label5.Text = j.ToString();
                    
                }
                if (label8.Text == "Wybrales")
                {
                    label4.Text = i.ToString();
                    label5.Text = j.ToString();
                    
                }
            }
        }
    }
}
