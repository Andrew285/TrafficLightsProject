namespace TrafficLights
{
    public partial class Form1 : Form
    {
        TrafficLights trafficLights;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            trafficLights = new TrafficLights(panel1.CreateGraphics(), panel1.Width, panel1.Height, 50);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            trafficLights.Draw();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (radioButtonManual.Checked)
            {
                trafficLights.Start();
                timer1.Enabled = false;
            }
            else
            {
                //задати тривалість для сигналів
                trafficLights.SetInterval(0, Int32.Parse(textBoxRedLight.Text) * 1000);
                trafficLights.SetInterval(1, Int32.Parse(textBoxYellowLight.Text) * 1000);
                trafficLights.SetInterval(2, Int32.Parse(textBoxGreenLight.Text) * 1000);

                timer1.Enabled = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            trafficLights.Start();
            timer1.Interval = trafficLights.GetInterval();
        }
    }
}