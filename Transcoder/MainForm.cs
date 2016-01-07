using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SVTranscoder
{
    public sealed partial class MainForm : Form
    {
        readonly FolderBrowserDialog _folderBrowserDialog = new FolderBrowserDialog();
        readonly OpenFileDialog _openFileDlg = new OpenFileDialog();
        readonly OpenFolderDialog _openFolderDlg = new OpenFolderDialog();

        public MainForm()
        {
            InitializeComponent();
            Text = $"{Application.ProductName} {Application.ProductVersion}";
            comboBox1.SelectedIndex = 0;
        }

        private void FindFileBtn_Click(object sender, EventArgs e)
        {
            _openFileDlg.ShowDialog(this);
            PathTextBox.Text = _openFileDlg.FileName;
        }

        private void FindFolderBtn_Click(object sender, EventArgs e)
        {
            if (Environment.OSVersion.IsWinVistaOrHigher())
            {
                _openFolderDlg.ShowDialog();
                PathTextBox.Text = _openFolderDlg.SelectedPath;
            }
            else
            {
                _folderBrowserDialog.ShowDialog();
                PathTextBox.Text = _folderBrowserDialog.SelectedPath;
            }
        }

        private void TranscodeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (File.GetAttributes(PathTextBox.Text).HasFlag(FileAttributes.Directory))
                {
                    string filter = $"({textBox1.Text.Replace("|", "$|").Replace(".", @"\.")}$)";
                    var files = Directory.EnumerateFiles(PathTextBox.Text, "*", SearchOption.AllDirectories);
                    files = checkBox1.Checked ? files.Where(x => x != null && Regex.IsMatch(Path.GetExtension(x), filter, RegexOptions.IgnoreCase)) : files;

                    foreach (string file in files)
                    {
                        Helper.CipherFile(file);
                    }
                }
                else
                {
                    Helper.CipherFile(PathTextBox.Text);
                }

                MessageBox.Show("Transcode Completed", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}