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

namespace Organicture
{
    public partial class Form1 : Form
    {
        public string search_folder;
        public List<string> sub_directories = new List<string>();
        public List<string> all_pictures = new List<string>();
        public string save_folder;

        public Form1()
        {
            InitializeComponent();
            loadPictureBtn.Visible = false;
            organiseBtn.Visible = false;
            currentDirectoryLbl.Text = "";  //always start label with an empty string
        }

        public string getPathFromExplorer()
        {
            string folder = "";

            using (var folder_dialog = new FolderBrowserDialog())
            {
                DialogResult destination_folder =  folder_dialog.ShowDialog();
                if(destination_folder == DialogResult.OK && !string.IsNullOrEmpty(folder_dialog.SelectedPath))
                {
                    folder = folder_dialog.SelectedPath;
                }
            }

            return folder;
        }

        public string getDateFromFile(string file_path)      //
        {
            return File.GetCreationTime(file_path).ToString("dd-mm-yyyy");
        }

        public string[] getAllPictures(string folder_path)
        {
            return Directory.GetFiles(folder_path);   //get all files from the folder 
        }

        public void getAllFoldersAndSubFolders(string folder_path)
        {
            foreach (string folder in getPathToAllFolders(folder_path))
            {
                if (!sub_directories.Contains(folder))
                {
                    sub_directories.Add(folder);
                    getAllFoldersAndSubFolders(folder);
                }
            }
        }

        public string[] getPathToAllFolders(string folder_path)
        {
            return Directory.GetDirectories(folder_path);    //get the directories in the current directory
        }

        private void folderPathBtn_Click(object sender, EventArgs e)
        {
            search_folder = getPathFromExplorer();      //ask the user for the directory path
            showDirectoryChosen(search_folder);     //give a notice to the user of which folder they chose
            changeLabelCurrentDirectory();      //display the current directory being used
            sub_directories.Add(search_folder);     //add the root folder to the list of folders and sub folders

            getAllFoldersAndSubFolders(search_folder);      //get all the sub folders inside of the root folder

            directoryLB.Items.Clear();
            foreach(string folder in sub_directories)       //TO DO: make it dynamic in a function
            {
                string folder_name = folder.Remove(0, 
                    folder.LastIndexOf(
                        search_folder.Remove(0, 
                            search_folder.LastIndexOf("\\")+1
                        )
                ));
                directoryLB.Items.Add(folder_name);
            }

            loadPictureBtn.Visible = true;
        }

        

        public void showDirectoryChosen(string folder_path)
        {
            MessageBox.Show("You have chosen the folder: "+ Path.GetFileName(folder_path) +"");
            changeLabelCurrentDirectory();
        }

        public void changeLabelCurrentDirectory()
        {
            currentDirectoryLbl.Text = search_folder;
        }

        private void loadPictureBtn_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (string folder in sub_directories)
                {
                    foreach (string picture in getAllPictures(folder))
                    {
                        all_pictures.Add(picture);
                    }
                }

                organiseBtn.Visible = true;
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            
        }

        private void organiseBtn_Click(object sender, EventArgs e)
        {
            save_folder = getPathFromExplorer();
            createFolders(save_folder);

        }

        public void createFolders(string path_to_folder)
        {
            foreach(string picture in all_pictures)
            {
                string pic_date = getDateFromFile(picture);
                string pic_name = Path.GetFileName(picture);
                string folder = save_folder + "\\" + pic_date;
                if (!Directory.Exists(folder))
                {
                    Directory.CreateDirectory(folder);
                }

                File.Move(picture, folder + "\\" + pic_name, false);
            }

            MessageBox.Show("All done :)");
        }
    }
}
