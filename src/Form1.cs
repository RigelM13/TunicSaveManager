using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TunicSaveManager
{
    public partial class Form1 : Form
    {
        string UserSavesPath    = "";
        string TunicSavesPath   = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /* Get Tunic Save Path */
            UserSavesPath   = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\AppData\\LocalLow\\TunicSaveManager";
            TunicSavesPath  = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\AppData\\LocalLow\\Andrew Shouldice\\Secret Legend\\SAVES";

            /* Create folder */
            if(false == Directory.Exists(UserSavesPath))
            {
                Directory.CreateDirectory(UserSavesPath);
            }

            /* Load files */
            foreach (var SaveFile in Directory.GetDirectories(UserSavesPath))
            {
                Files_datagrid.Rows.Add(Path.GetFileName(SaveFile));
            }

            Files_datagrid.ColumnHeadersDefaultCellStyle.Font       = new Font(DataGridView.DefaultFont, FontStyle.Bold);
            Files_datagrid.ColumnHeadersDefaultCellStyle.Alignment  = DataGridViewContentAlignment.MiddleCenter;
            Files_datagrid.ColumnHeadersDefaultCellStyle.BackColor  = Color.LightGray;
            Files_datagrid.EnableHeadersVisualStyles                = false;

            Save_text.ForeColor = Color.LightGray;
        }

        private void CreateSave_button_Click(object sender, EventArgs e)
        {
            if ("" != Save_text.Text)
            {
                string SaveFilePath = UserSavesPath + "\\" + Save_text.Text;

                try
                {
                    if (false == Directory.Exists(SaveFilePath))
                    {
                        Directory.CreateDirectory(SaveFilePath);

                        foreach (var file in Directory.GetFiles(TunicSavesPath))
                        {
                            File.Copy(file, Path.Combine(SaveFilePath, Path.GetFileName(file)));
                        }

                        Files_datagrid.Rows.Add(Save_text.Text);

                        Log_text.Text = "Save file created";
                    }
                    else
                    {
                        MessageBox.Show("Save file already exists.", "Cannot create Save file", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch
                {
                    MessageBox.Show("Invalid characters for save file.", "Cannot create Save file", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void DeleteSave_button_Click(object sender, EventArgs e)
        {
            int     SaveFileIndex   = 0;
            string  SaveFilePath    = "";      

            if (0 != Files_datagrid.Rows.Count)
            {
                SaveFileIndex   = Files_datagrid.CurrentCell.RowIndex;
                SaveFilePath    = UserSavesPath + "\\" + Files_datagrid.CurrentCell.Value;

                try
                {
                    Directory.Delete(SaveFilePath, true);
                    Files_datagrid.Rows.RemoveAt(SaveFileIndex);

                    Log_text.Text = "Save file deleted";
                }
                catch
                {
                    MessageBox.Show("Cannot load save file.", "Unexpected error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }  
            }
        }

        private void LoadSave_button_Click(object sender, EventArgs e)
        {
            int     SaveFileIndex   = 0;
            string  SaveFilePath    = "";

            if (0 != Files_datagrid.Rows.Count)
            {
                SaveFileIndex   = Files_datagrid.CurrentCell.RowIndex;
                SaveFilePath    = UserSavesPath + "\\" + Files_datagrid.CurrentCell.Value;

                try
                {
                    Directory.Delete(TunicSavesPath, true);
                    Directory.CreateDirectory(TunicSavesPath);

                    foreach (var file in Directory.GetFiles(SaveFilePath))
                    {
                        File.Copy(file, Path.Combine(TunicSavesPath, Path.GetFileName(file)));
                    }

                    Log_text.Text = "Save file loaded";
                }
                catch
                {
                    MessageBox.Show("Cannot load save file.", "Unexpected error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Save_text_Enter(object sender, EventArgs e)
        {
            if (Color.LightGray == Save_text.ForeColor)
            {
                Save_text.Text = "";
                Save_text.ForeColor = Color.Black;
            }
        }

        private void Save_text_Leave(object sender, EventArgs e)
        {
            if("" == Save_text.Text)
            {
                Save_text.Text = "Save file name";
                Save_text.ForeColor = Color.LightGray;
            }
        }

        private void Export_button_Click(object sender, EventArgs e)
        {
            SaveFileDialog ExportSavesDialog = new SaveFileDialog();

            ExportSavesDialog.InitialDirectory  = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Documents";
            ExportSavesDialog.FileName          = "TunicSaves.zip";
            ExportSavesDialog.Filter            = "zip files (*.zip)|*.zip";
            ExportSavesDialog.FilterIndex       = 1;
            ExportSavesDialog.RestoreDirectory  = true;

            if (ExportSavesDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ZipFile.CreateFromDirectory(UserSavesPath, ExportSavesDialog.FileName);

                    Log_text.Text = "Save files exported";
                }
                catch
                {
                    MessageBox.Show("Cannot create export file.", "Unexpected error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Import_button_Click(object sender, EventArgs e)
        {
            OpenFileDialog ImportSavesDialog = new OpenFileDialog();

            ImportSavesDialog.InitialDirectory  = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Documents";
            ImportSavesDialog.FileName          = "TunicSaves.zip";
            ImportSavesDialog.Filter            = "zip files (*.zip)|*.zip";
            ImportSavesDialog.FilterIndex       = 1;
            ImportSavesDialog.RestoreDirectory  = true;

            if (ImportSavesDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Directory.Delete(UserSavesPath, true);
                    ZipFile.ExtractToDirectory(ImportSavesDialog.FileName, UserSavesPath);

                    /* Load files */
                    foreach (var SaveFile in Directory.GetDirectories(UserSavesPath))
                    {
                        Files_datagrid.Rows.Add(Path.GetFileName(SaveFile));
                    }

                    Log_text.Text = "Save files imported";
                }
                catch
                {
                    MessageBox.Show("Cannot create export file.", "Unexpected error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
