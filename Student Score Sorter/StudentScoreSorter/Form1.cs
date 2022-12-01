using System.Diagnostics;
using static System.Net.Mime.MediaTypeNames;

namespace StudentScoreSorter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_DragEnter(object sender, DragEventArgs e)
        {
            // Include all effects
            e.Effect = DragDropEffects.All;
        }

        private void panel1_DragDrop(object sender, DragEventArgs e)
        {
            try
            {

                string[] getFiles = (string[])e.Data.GetData(DataFormats.FileDrop, false);
                //MessageBox.Show(getFiles.get(0));
                List<string> textLines = File.ReadLines(getFiles[0]).ToList();
                // New 
                SinglyLinkedList list = new SinglyLinkedList();
                // Add items to my Singly Linked List
                foreach (string line in textLines)
                {
                    list.add(line);
                    //listBox1.Items.Add(Test.score);
                }
                
                // Apply Merge Sort
                list.head = list.mergeSort(list.head);
                Node Listhead = list.head;
                Debug.WriteLine("What is in the Current List");
                while (Listhead != null)
                {
                    Debug.WriteLine(Listhead.data);
                    listBox1.Items.Add(Listhead.data);
                    Listhead = Listhead.nextNode;
                }
            }
            catch(Exception ex)
            {
                //throw new Exception("Error occured while reading the file! " + ex.ToString());
                MessageBox.Show("The file is of Incorrect format!!!");
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}