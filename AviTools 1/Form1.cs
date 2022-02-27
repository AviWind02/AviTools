/*
    Made by Avi
    2022-02-26
    This is made for fun it just transfers files for now
    and soon it'll do more. :)
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace AviTools_1
{
    public partial class Form1 : Form
    {
        private string currentDirsrc, currentDirdes;
        private string pickedDrivesrc, pickedDrivedes;
        private int filesTransferedCount, folderTransferedCount;
        private int filesTransferedCountError, folderTransferedCountError;
        private int fileCount, folderCount;

        private void setCountinDir()
        {
            try
            {
                if (pickedDrivesrc != null)
                {
                    fileCount = System.IO.Directory.GetFiles(pickedDrivesrc, "*.*", SearchOption.AllDirectories).Count();
                    folderCount = System.IO.Directory.GetDirectories(pickedDrivesrc, "*", SearchOption.AllDirectories).Count();
                    CountofFileTextbox.Text = "File Count: " + fileCount;
                    CountofFolderTextbox.Text = "Folder Count: " + folderCount;
    
                }
            }catch (Exception ex)
            {
                //Log("ik but i wont fix it now. :)");
            }


        }
   

        private void setPathForDir()
        {
            try
            {
                if (pickedDrivesrc != null)
                    textBoxForsrc.Text = pickedDrivesrc;
                else
                    textBoxForsrc.Text = "Path not picked";
                if (pickedDrivedes != null)
                    textBoxForDestination.Text = pickedDrivedes;
                else
                    textBoxForDestination.Text = "Path not picked";

            }
            catch (Exception ex)
            {
                //Log("ik but i wont fix it now. :)");
            }


        }
        private void loadDrives()
        {
            listBoxForSource.Items.Clear();
            listBoxForDestination.Items.Clear();
            foreach (var drive in DriveInfo.GetDrives())
            {
                listBoxForSource.Items.Add(drive);
                listBoxForDestination.Items.Add(drive);

            }
        }
        private void loadDirectorySrc()
        {

        
            // Get information about the source directory
            var dir = new DirectoryInfo(pickedDrivesrc);
            // Cache directories before we start copying
            DirectoryInfo[] dirs = dir.GetDirectories();
            foreach (DirectoryInfo subDir in dirs)
                listBoxForSource.Items.Add(subDir.FullName);
            currentDirsrc = pickedDrivesrc;
            Log("Now in dir:" + pickedDrivesrc);
            setCountinDir();
            loadFile();
            setPathForDir();

        }
        private void loadDirectoryDes()
        {
            // Get information about the source directory
            var dir = new DirectoryInfo(pickedDrivedes);
            // Cache directories before we start copying
            DirectoryInfo[] dirs = dir.GetDirectories();
            foreach (DirectoryInfo subDir in dirs)
                listBoxForDestination.Items.Add(subDir.FullName);
            currentDirdes = pickedDrivedes;
            Log("Now in dir:" + pickedDrivedes);
            setPathForDir();

        }
        private void loadFile()
        {
            richTextBoxForFIieFoundinDir.Text = "";
           // Get information about the source directory
            var dir = new DirectoryInfo(pickedDrivesrc);
            // Cache directories before we start copying
            DirectoryInfo[] dirs = dir.GetDirectories();
            foreach (FileInfo file in dir.GetFiles())
            {
                richTextBoxForFIieFoundinDir.Text += file.Name + "\n";
                richTextBoxForFIieFoundinDir.SelectionStart = fileErrors.Text.Length;
                richTextBoxForFIieFoundinDir.ScrollToCaret();
            }

        }

        private void CopyDirectory(string sourceDir, string destinationDir, bool recursive)
        {
            try
            {
                // Get information about the source directory
                var dir = new DirectoryInfo(sourceDir);

            // Check if the source directory exists
            if (!dir.Exists)
                throw new DirectoryNotFoundException($"Source directory not found: {dir.FullName}");

            // Cache directories before we start copying
            DirectoryInfo[] dirs = dir.GetDirectories();

            // Create the destination directory
            Directory.CreateDirectory(destinationDir);
     
            // Get the files in the source directory and copy to the destination directory
            foreach (FileInfo file in dir.GetFiles())
            {
                string targetFilePath = Path.Combine(destinationDir, file.Name);
                if (checkBoxSkipFiles.Checked == true && !File.Exists(targetFilePath))
                    file.CopyTo(targetFilePath);
                else if(checkBoxForDup.Checked == true && File.Exists(targetFilePath))
                    file.CopyTo(Path.Combine(destinationDir, "Dup" + file.Name));
                else if (overWriteCheck.Checked == true && File.Exists(targetFilePath))
                    file.CopyTo(Path.Combine(destinationDir, file.Name), true);
                
                if (File.Exists(targetFilePath))
                {
                    LogTransferFile(targetFilePath);
                    filesTransferedCount++;
                    FilesTransferedTextBox.Text = "Files transfered: " + filesTransferedCount;
                }
                else
                {
                    LogErrorFile(targetFilePath);
                    filesTransferedCountError++;
                    FilesFailedTextBox.Text = "Files failed: " + filesTransferedCountError;
                }
            }

            // If recursive and copying subdirectories, recursively call this method
            if (recursive)
            {
                foreach (DirectoryInfo subDir in dirs)
                {
                    string newDestinationDir = Path.Combine(destinationDir, subDir.Name);
                    CopyDirectory(subDir.FullName, newDestinationDir, true);
                    if (Directory.Exists(destinationDir))
                    {
                        LogTransferFile(destinationDir);
                        folderTransferedCount++;
                        FolderTransferedTextBox.Text = "Folders transfered: " + folderTransferedCount;

                    }
                    else
                    {
                        LogErrorFile(destinationDir);
                        folderTransferedCountError++;
                       FolderTransferedTextBox.Text = "Folders failed: " + folderTransferedCountError;

                    }
                }
            }
           
                FilesLeftToTransferTextBox.Text = "File Left: " + (fileCount - filesTransferedCount);
                FolderLeftToTransferTextBox.Text = "Folder Left: " + (folderCount - folderTransferedCount);

                progressBarForTranfer.Maximum = fileCount;
                progressBarForTranfer.Value = filesTransferedCount;
                progressBarForFolder.Maximum = folderCount;
                progressBarForFolder.Value = folderTransferedCount;
            } catch (Exception ex)
            {
                Log(ex.Message);
            }
            
        }

        private void Log(string s)
        {

            richTextLogBox.Text += s + "\n";
            richTextLogBox.SelectionStart = fileErrors.Text.Length;
            richTextLogBox.ScrollToCaret();
        }
        private void LogErrorFile(string s)
        {

            fileErrors.Text += "Transfer Error: " + s + "\n";
            fileErrors.SelectionStart = fileErrors.Text.Length;
            fileErrors.ScrollToCaret();
        }
        private void LogTransferFile(string s)
        {
            filesTransfered.Text += "Transfered: " + s + "\n";
            filesTransfered.SelectionStart = filesTransfered.Text.Length;
            filesTransfered.ScrollToCaret();
        }
        private void g_loadFile()
        {
            string Appdata = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            if (Directory.Exists(Appdata+"\\Avi"))
            {
                if(File.Exists(Appdata + "\\Avi\\Avi.txt"))
                foreach (string line in System.IO.File.ReadLines(Appdata + "\\Avi\\Avi.txt"))
                {
                    listBoxForRecentPaths.Items.Add(line);
                }
            }
            else
            {
                Directory.CreateDirectory(Appdata + "\\Avi");
                File.Create(Appdata + "\\Avi\\Avi.txt");
            }
        }
        public Form1()
        {
            InitializeComponent();
            loadDrives();
            g_loadFile();
        }


        private void listBoxForSource_SelectedIndexChanged(object sender, EventArgs e)
        {
          
                try
                {
                    pickedDrivesrc = listBoxForSource.GetItemText(listBoxForSource.SelectedItem);
                    listBoxForSource.Items.Clear();
                    loadDirectorySrc();
                }
                catch (Exception ex)
                {
                    Log(ex.Message);
                }
            

        }

    
        private void buttonBack_Click(object sender, EventArgs e)
        {
            if (pickedDrivesrc != null)
            {
                listBoxForSource.Items.Clear();
                if (pickedDrivesrc.Contains(@"\"))
                {
                    string removeString = currentDirsrc.Split('\\').Last();
                    pickedDrivesrc = pickedDrivesrc.Replace(@"\" + removeString, "");
                    loadDirectorySrc();
                }
                else
                {
                    loadDrives();
                    pickedDrivesrc = null;
                }
            }
            else
                Log("Pick a Directory.");
            
                
        }

        private void buttonTranfer_Click(object sender, EventArgs e)
        {
            CopyDirectory(pickedDrivesrc, pickedDrivedes, true);
            System.IO.File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Avi\\Avi.txt", pickedDrivesrc + "\r\n");
        }


        private void listBoxForDestination_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                pickedDrivedes = listBoxForDestination.GetItemText(listBoxForDestination.SelectedItem);
                listBoxForDestination.Items.Clear();
                loadDirectoryDes();
            }
            catch (Exception ex)
            {
                Log(ex.Message);
            }
        }

        private void listBoxForRecentPaths_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                pickedDrivesrc = listBoxForRecentPaths.GetItemText(listBoxForRecentPaths.SelectedItem);
                listBoxForSource.Items.Clear();
                loadDirectorySrc();
            }
            catch (Exception ex)
            {
                Log(ex.Message);
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            if (pickedDrivedes != null)
            {
                listBoxForDestination.Items.Clear();
                if (pickedDrivedes.Contains(@"\"))
                {
                    string removeString = currentDirdes.Split('\\').Last();
                    pickedDrivedes = pickedDrivedes.Replace(@"\" + removeString, "");
                    loadDirectoryDes();
                }
                else
                {
                    loadDrives();
                    pickedDrivedes = null;
                }
            }
            else
                Log("Pick a Directory.");
        }



        private void overWriteCheck_CheckedChanged(object sender, EventArgs e)
        {

            checkBoxSkipFiles.Checked = false;
            checkBoxForDup.Checked = false;
            checkBox4.Checked = false;

        }

        private void checkBoxSkipFiles_CheckedChanged(object sender, EventArgs e)
        {
            overWriteCheck.Checked = false;
            checkBoxForDup.Checked = false;
            checkBox4.Checked = false;
        }

        private void checkBoxForDup_CheckedChanged(object sender, EventArgs e)
        {

            checkBoxSkipFiles.Checked = false;
            overWriteCheck.Checked = false;
            checkBox4.Checked = false;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

            checkBoxSkipFiles.Checked = false;
            checkBoxForDup.Checked = false;
            overWriteCheck.Checked = false;
        }

    }

}
