using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace utility_applications
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string folderPath = "";
        private void frmdelete_Load(object sender, EventArgs e)
        {

            btt_loseSetting.FlatStyle = FlatStyle.Flat;
            btt_loseSetting.BackColor = Color.Transparent;
            btt_loseSetting.FlatAppearance.BorderSize = 0;


            pictureBox1.SendToBack();

        }

        private void settingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gbx_setting.Visible = true;
            gbx_delete.Visible = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbb_settingLanguage.SelectedIndex == 0)
            {

                tsm_delete.Text = "Xóa file";
                lb_foderPathLockfoder.Text = "Đường dẫ foder"; 
                tsm_encryption.Text = "Mã hóa";
                tsm_setting.Text = "Cài đặt";
                btt_Lock.Text = "Khóa";
                btt_unlock.Text = "Mở Khóa"; 
                lb_language.Text = "Ngôn ngữ";
                bttDelete.Text = "Xóa";
                bttselect_all.Text = "Chọn tất cả";
                bttscan.Text = "Quét";
                lb_SelectScanMode.Text = "Vui lòng chọn chế độ quét";
                lb_SelectScanMode1.Text = "Lưu ý: nếu chọn chế độ quét tất cả, phần mền sẽ quét tất cả file có trong thư mục gốc lẫn thư mục con";
                lb_instructSetFoder.Text = "Vui lòng chọn thư mục muốn xóa các file trùng lập";

            }
            if (cbb_settingLanguage.SelectedIndex == 1)
            {
                lb_foderPathLockfoder.Text = "foder path";
                tsm_delete.Text = "Delete files";
                btt_Lock.Text = "Lock";
                btt_unlock.Text = "unlock";
                tsm_encryption.Text = "Encode";
                tsm_setting.Text = "Setting";

                lb_language.Text = "Language";
                bttDelete.Text = "Delete";
                bttselect_all.Text = "Select all";
                bttscan.Text = "To scan";
                lb_SelectScanMode.Text = "Please select scan mode";
                lb_SelectScanMode1.Text = "Note: if you select all scan mode, the software will scan all files in the root folder and subfolders";
                lb_instructSetFoder.Text = "Please select the folder where you want to delete duplicate files";



            }
        }
        private void btt_loseSetting_Click(object sender, EventArgs e)
        {
            gbx_setting.Visible = false;
        }
        private void bttgetpath_Click(object sender, EventArgs e)
        {
            getPath path = new getPath();
            folderPath = path.Getpath();
        }

        private void bttselect_all_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lstv_listFileDelete.Items)
            {
                item.Checked = true;
            }

        }
        public double GetDirectorySize(string path)
        {
            DirectoryInfo directory = new DirectoryInfo(path);
            long size = 0;
            foreach (string file in Directory.GetFiles(path))
            {
                FileInfo fileInfo = new FileInfo(file);
                size += fileInfo.Length / 1024;
            }
            return size;
        }
        private string ComputeFileHash(string filePath)
        {
            using (FileStream stream = File.OpenRead(filePath))
            {
                SHA256Managed sha = new SHA256Managed();
                byte[] hash = sha.ComputeHash(stream);
                return BitConverter.ToString(hash).Replace("-", string.Empty);
            }
        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

            Dictionary<string, string> fileHashes = new Dictionary<string, string>();
            string folderPath = e.Argument.ToString();     
            string[] files = Directory.GetFiles(folderPath);
            lstv_listFileDelete.Invoke((MethodInvoker)delegate {
                lstv_listFileDelete.CheckBoxes = true;
            });
            double total_file_size = 0;
            double sizeofoder = GetDirectorySize(folderPath);
            foreach (string filePath in files)
            {
                FileInfo fileInfo = new FileInfo(filePath);
                double filesizeloadding = (double)fileInfo.Length / 1024;
                total_file_size = total_file_size + filesizeloadding;
                double loaddingPT = total_file_size / sizeofoder * 100;
                string fileHash = ComputeFileHash(filePath);
                if (fileHashes.ContainsKey(fileHash))
                {
                    double fileSizeKB = (double)fileInfo.Length / 1024;
                    ListViewItem item = new ListViewItem(fileInfo.Name);
                    item.SubItems.Add(fileSizeKB.ToString("N2") + " KB");
                    item.Tag = filePath;
                    lstv_listFileDelete.Invoke((MethodInvoker)delegate {
                        lstv_listFileDelete.Items.Add(item);
                    });
                }
                else
                {
                    fileHashes[fileHash] = filePath;
                }
                lb_loading.Invoke((MethodInvoker)delegate {
                    lb_loading.Text = loaddingPT.ToString("N1") + "%";
                });
            }
            MessageBox.Show("Số lượng file trùng có trong folder: " + lstv_listFileDelete.Items.Count, "Số lượng", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            pictureBox1.Visible = false;
            lb_loading.Visible = false;
            lstv_listFileDelete.Visible = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void bttscan_Click(object sender, EventArgs e)
        {
            do
            {
                if (folderPath == "")
                {
                    DialogResult result = MessageBox.Show("Vui lòng nhập foder cần quét", "Không tìm thấy foder", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    if (result == DialogResult.OK)
                    {
                        getPath path = new getPath();
                        folderPath = path.Getpath();
                    }
                    else
                    {
                        break;
                    }
                }
            } while (folderPath == "");
            backgroundWorker1.RunWorkerAsync(folderPath);


            progressBar1.Visible = true;
            pictureBox1.Visible = true;
            lstv_listFileDelete.Visible = false;
            lb_loading.Visible = true;
        }

        private void bttDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa, các tệp tin sẽ bị xóa vĩnh viễn và không thể khôi phục", "Xác nhận xóa", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {
                foreach (ListViewItem item in lstv_listFileDelete.Items)
                {

                    if (item.Checked)
                    {
                        string filePathfile = item.Tag.ToString();
                        File.Delete(filePathfile);
                        lstv_listFileDelete.Items.Remove(item);
                    }
                }
            }
            else if (result == DialogResult.Cancel)
            {
                MessageBox.Show("bạn đã hủy các tệp tin sẽ vẫn giữ nguyên");
            }

            
        }

        private void tsm_delete_Click(object sender, EventArgs e)
        {
            gbx_delete.Visible = true;
            gbx_setting.Visible = false;
            gbx_lockFoder.Visible = false;
        }


        static string[] GetFilesRecursively(string directory)
        {
            string[] files = Directory.GetFiles(directory);

            foreach (string subDirectory in Directory.GetDirectories(directory))
            {

                string[] subDirectoryFiles = GetFilesRecursively(subDirectory);


                files = files.Concat(subDirectoryFiles).ToArray();
            }
            return files;
        }



        private void tsm_encryption_Click(object sender, EventArgs e)
        {
            gbx_delete.Visible = false;
            gbx_setting.Visible = false;
            gbx_lockFoder.Visible = true;
        }

        private void tsm_setting_Click(object sender, EventArgs e)
        {
            gbx_setting.Visible = true;
            gbx_delete.Visible = false;
            gbx_lockFoder.Visible=false;

        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            getPath path = new getPath();
            folderPath = path.Getpath();
            txtPath.Text = folderPath;


        }

        

        private void btt_Lock_Click(object sender, EventArgs e)
        {
            if (txtPath.Text.Length > 0)
            {
                try
                {
                    string folderPath = txtPath.Text;
                    string adminUserName = Environment.UserName;
                    DirectorySecurity ds = Directory.GetAccessControl(folderPath);
                    FileSystemAccessRule fsa = new FileSystemAccessRule(adminUserName, FileSystemRights.FullControl, AccessControlType.Deny);
                    ds.AddAccessRule(fsa);
                    Directory.SetAccessControl(folderPath, ds);
                    MessageBox.Show("folder is Locked");
                }

                catch
                {
                }
            }
        }

        private void btt_unlock_Click(object sender, EventArgs e)
        {
            if (txtPath.Text.Length > 0)
            {
                try
                {
                    string folderPath = txtPath.Text;
                    string adminUserName = Environment.UserName;
                    DirectorySecurity ds = Directory.GetAccessControl(folderPath);
                    FileSystemAccessRule fsa = new FileSystemAccessRule(adminUserName, FileSystemRights.FullControl, AccessControlType.Deny);
                    ds.RemoveAccessRule(fsa);
                    Directory.SetAccessControl(folderPath, ds);
                    MessageBox.Show("folder is unlocked");
                }
                catch
                {
                }
            }
        }
    }
}

