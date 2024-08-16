namespace GallerySQL
{
    partial class Search
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.galleryDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.galleryDataSet = new GallerySQL.galleryDataSet();
            this.searchstockbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.galleryDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.galleryDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DataSource = this.galleryDataSetBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 211);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(625, 342);
            this.dataGridView1.TabIndex = 0;
            // 
            // galleryDataSetBindingSource
            // 
            this.galleryDataSetBindingSource.DataSource = this.galleryDataSet;
            this.galleryDataSetBindingSource.Position = 0;
            // 
            // galleryDataSet
            // 
            this.galleryDataSet.DataSetName = "galleryDataSet";
            this.galleryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // searchstockbutton
            // 
            this.searchstockbutton.BackColor = System.Drawing.Color.PaleGreen;
            this.searchstockbutton.Location = new System.Drawing.Point(12, 13);
            this.searchstockbutton.Name = "searchstockbutton";
            this.searchstockbutton.Size = new System.Drawing.Size(83, 23);
            this.searchstockbutton.TabIndex = 1;
            this.searchstockbutton.Text = "Search Stock";
            this.searchstockbutton.UseVisualStyleBackColor = false;
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(649, 633);
            this.Controls.Add(this.searchstockbutton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Search";
            this.Text = "Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.galleryDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.galleryDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource galleryDataSetBindingSource;
        private galleryDataSet galleryDataSet;
        private System.Windows.Forms.Button searchstockbutton;
    }
}