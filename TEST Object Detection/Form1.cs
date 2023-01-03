using System.Windows.Forms;
using Yolov5Net;
namespace TEST_Object_Detection
{
    public partial class Form1 : Form
    {

        Image sourceImage;
        Image resultImage;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog()==DialogResult.OK) {
                sourceImage=Image.FromFile(ofd.FileName);
                source_pbox.Image=sourceImage;
                detect_btn.Enabled=true;
            }
        }

        private void detect_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(object_txt.Text)) {
                MessageBox.Show("write object name to detect like : person");
                return;
            }

            Yolov5Net.App.Program.Detect(this.sourceImage,object_txt.Text, out Bitmap resultImage2, out double scoreResult);
            resultImage = resultImage2;
            result_pbox.Image = resultImage;
            button2.Enabled = true;
            MessageBox.Show("Score is  : "+scoreResult);
            score_txt.Text = "" + scoreResult;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();

                if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                {
                    resultImage.Save(folderBrowserDialog1.SelectedPath + "\\"+textBox1.Text.Trim()+"_Score_"+score_txt.Text+".png");
                    MessageBox.Show("Result Image Saved ");

                }
            }
            else {
                MessageBox.Show("you must write file name in text box");
            }

         
       
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = Yolov5Net.App.Program.getAllLabels();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}