using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace ConsoleApplication1
{
    public partial class ItensFrame : Form
    {
        private int refresh = 1;

        private MainFormStudent mfs = new MainFormStudent();
        public ItensFrame()
        {
            InitializeComponent();
        }

        private void ItensFrame_Load(object sender, EventArgs e)
        {
            //dataGridView1.ColumnHeadersVisible = false;
            //dataGridView1.RowHeadersVisible = false;
            //dataGridView1.AllowUserToAddRows = false;
            //dataGridView1.DataSource = GetFunctionsFiles.Instance.Ishowfiles(MainFormStudent.IgetCell, Login.iresult);
            if (refresh == 1)
            {
                DataTable DT = GetFunctionsFiles.Instance.Ishowfiles(MainFormStudent.IgetCell, Login.iresult);
                foreach (DataRow row in DT.Rows)
                {
                    listBox1.Items.Add(row[0]);
                }
                refresh = 0;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataBindings.Clear();
            this.Close();
            mfs.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_DragDrop(object sender, DragEventArgs e)
        {
 
        }

        //Get file name
        private string getFileName(string path)
        {
            return Path.GetFileNameWithoutExtension(path);
        }


        private void listBox1_DragDrop(object sender, DragEventArgs e)
        {
            //string destination = utilites._Inicialpath();
            //OpenFileDialog ofd = new OpenFileDialog();
            //ofd.Multiselect = true;

            //if(DialogResult.OK == ofd.ShowDialog())
            //{
            //    foreach (string file in ofd.FileNames)
            //    {
            //        File.Copy(file, Path.Combine(destination, Path.GetFileName(file)));
            //    }
            //}

            //Take dropped items and store in array
            String[] droppedFiles = (String[])e.Data.GetData(DataFormats.FileDrop);
            //LOOP THROUGH ITEMS AND DISPLAY THEM
            foreach (String file in droppedFiles)
            {
                String filename = getFileName(file);
                MessageBox.Show("Ficheiro largado " + filename);
                listBox1.Items.Add(filename);
                GetFunctionsFiles.Instance.Istorefiles(file, MainFormStudent.IgetCell, Login.iresult);
                //File.Copy(file, Path.Combine(utilites._Inicialpath, Path.GetFileName(file)));
                
            }
        }

        private void listBox1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true)
            {
                e.Effect = DragDropEffects.All;
            }
        }

    }
}
