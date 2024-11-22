namespace BlocNotas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader leer = new StreamReader(openFileDialog1.FileName);
                textBox1.Text = leer.ReadToEnd();
                leer.Close();
            }
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path=saveFileDialog1.FileName;
                FileStream archivo = new FileStream(path,FileMode.Create,FileAccess.Write);
                StreamWriter escribir = new StreamWriter(archivo);  

            }
        }
    }
}
