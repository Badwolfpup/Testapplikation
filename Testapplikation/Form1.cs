namespace Testapplikation
{
    using System.Drawing;
    public partial class Form1 : Form
    {
        private bool drawing = false;
        private Point lastPoint = Point.Empty;
        private Pen pen = new Pen(Color.Black, 2);
        

        public Form1()
        {
            InitializeComponent();

        }


        private void button1_Click(object sender, EventArgs e)
        {
            
        }


    }
}