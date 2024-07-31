namespace TunicSaveManager
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.CreateSave_button = new System.Windows.Forms.Button();
            this.LoadSave_button = new System.Windows.Forms.Button();
            this.DeleteSave_button = new System.Windows.Forms.Button();
            this.Save_text = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Files_datagrid = new System.Windows.Forms.DataGridView();
            this.Import_button = new System.Windows.Forms.Button();
            this.Export_button = new System.Windows.Forms.Button();
            this.SaveFileName_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Log_text = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Files_datagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // CreateSave_button
            // 
            this.CreateSave_button.Location = new System.Drawing.Point(12, 518);
            this.CreateSave_button.Name = "CreateSave_button";
            this.CreateSave_button.Size = new System.Drawing.Size(105, 30);
            this.CreateSave_button.TabIndex = 0;
            this.CreateSave_button.Text = "Create Save File";
            this.CreateSave_button.UseVisualStyleBackColor = true;
            this.CreateSave_button.Click += new System.EventHandler(this.CreateSave_button_Click);
            // 
            // LoadSave_button
            // 
            this.LoadSave_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LoadSave_button.Location = new System.Drawing.Point(13, 554);
            this.LoadSave_button.Name = "LoadSave_button";
            this.LoadSave_button.Size = new System.Drawing.Size(439, 30);
            this.LoadSave_button.TabIndex = 1;
            this.LoadSave_button.Text = "Load Save File";
            this.LoadSave_button.UseVisualStyleBackColor = true;
            this.LoadSave_button.Click += new System.EventHandler(this.LoadSave_button_Click);
            // 
            // DeleteSave_button
            // 
            this.DeleteSave_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteSave_button.Location = new System.Drawing.Point(123, 518);
            this.DeleteSave_button.Name = "DeleteSave_button";
            this.DeleteSave_button.Size = new System.Drawing.Size(105, 30);
            this.DeleteSave_button.TabIndex = 2;
            this.DeleteSave_button.Text = "Delete Save File";
            this.DeleteSave_button.UseVisualStyleBackColor = true;
            this.DeleteSave_button.Click += new System.EventHandler(this.DeleteSave_button_Click);
            // 
            // Save_text
            // 
            this.Save_text.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Save_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save_text.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.Save_text.Location = new System.Drawing.Point(13, 590);
            this.Save_text.Name = "Save_text";
            this.Save_text.Size = new System.Drawing.Size(439, 26);
            this.Save_text.TabIndex = 3;
            this.Save_text.Text = "Save file name";
            this.Save_text.Enter += new System.EventHandler(this.Save_text_Enter);
            this.Save_text.Leave += new System.EventHandler(this.Save_text_Leave);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(400, 629);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "RigelM13";
            // 
            // Files_datagrid
            // 
            this.Files_datagrid.AllowUserToAddRows = false;
            this.Files_datagrid.AllowUserToDeleteRows = false;
            this.Files_datagrid.AllowUserToResizeColumns = false;
            this.Files_datagrid.AllowUserToResizeRows = false;
            this.Files_datagrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Files_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Files_datagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SaveFileName_column});
            this.Files_datagrid.Location = new System.Drawing.Point(13, 13);
            this.Files_datagrid.MultiSelect = false;
            this.Files_datagrid.Name = "Files_datagrid";
            this.Files_datagrid.ReadOnly = true;
            this.Files_datagrid.RowHeadersVisible = false;
            this.Files_datagrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.Files_datagrid.Size = new System.Drawing.Size(439, 499);
            this.Files_datagrid.TabIndex = 5;
            // 
            // Import_button
            // 
            this.Import_button.Location = new System.Drawing.Point(236, 518);
            this.Import_button.Name = "Import_button";
            this.Import_button.Size = new System.Drawing.Size(105, 30);
            this.Import_button.TabIndex = 6;
            this.Import_button.Text = "Import Saves";
            this.Import_button.UseVisualStyleBackColor = true;
            this.Import_button.Click += new System.EventHandler(this.Import_button_Click);
            // 
            // Export_button
            // 
            this.Export_button.Location = new System.Drawing.Point(347, 518);
            this.Export_button.Name = "Export_button";
            this.Export_button.Size = new System.Drawing.Size(105, 30);
            this.Export_button.TabIndex = 7;
            this.Export_button.Text = "Export Saves";
            this.Export_button.UseVisualStyleBackColor = true;
            this.Export_button.Click += new System.EventHandler(this.Export_button_Click);
            // 
            // SaveFileName_column
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveFileName_column.DefaultCellStyle = dataGridViewCellStyle1;
            this.SaveFileName_column.HeaderText = "Save File Name";
            this.SaveFileName_column.Name = "SaveFileName_column";
            this.SaveFileName_column.ReadOnly = true;
            this.SaveFileName_column.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.SaveFileName_column.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.SaveFileName_column.Width = 436;
            // 
            // Log_text
            // 
            this.Log_text.AutoSize = true;
            this.Log_text.BackColor = System.Drawing.SystemColors.Control;
            this.Log_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Log_text.ForeColor = System.Drawing.Color.ForestGreen;
            this.Log_text.Location = new System.Drawing.Point(12, 627);
            this.Log_text.Name = "Log_text";
            this.Log_text.Size = new System.Drawing.Size(0, 16);
            this.Log_text.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 651);
            this.Controls.Add(this.Log_text);
            this.Controls.Add(this.Export_button);
            this.Controls.Add(this.Import_button);
            this.Controls.Add(this.Files_datagrid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Save_text);
            this.Controls.Add(this.DeleteSave_button);
            this.Controls.Add(this.LoadSave_button);
            this.Controls.Add(this.CreateSave_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Tunic Save Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Files_datagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CreateSave_button;
        private System.Windows.Forms.Button LoadSave_button;
        private System.Windows.Forms.Button DeleteSave_button;
        private System.Windows.Forms.TextBox Save_text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Files_datagrid;
        private System.Windows.Forms.Button Import_button;
        private System.Windows.Forms.Button Export_button;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaveFileName_column;
        private System.Windows.Forms.Label Log_text;
    }
}

