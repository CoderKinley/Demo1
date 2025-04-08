namespace demoSidePanel1
{
    public partial class sideControlPanel : UserControl
    {
        public sideControlPanel()
        {
            InitializeComponent();
            this.Size = new Size(25, 25);
            this.AutoSize = true;
            //this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.MinimumSize = new Size(25, 25);
        }

        // Public method to toggle the panel width externally
        public void TogglePanel()
        {
            if (panel1.Width >= 200)
            {
                panel1.Width = 60;
            }
            else
            {
                panel1.Width = 200;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //TogglePanel(); // reuse the same logic
        }

        private void sideControlPanel_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

        }

        private void iconButton8_Click(object sender, EventArgs e)
        {
            TogglePanel();
        }
    }
}
 