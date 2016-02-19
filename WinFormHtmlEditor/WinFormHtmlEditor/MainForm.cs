using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinFormHtmlEditor
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            tinyMceEditor.CreateEditor();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var htmlContent = tinyMceEditor.HtmlContent;
            Console.WriteLine(htmlContent);
        }
    }
}
