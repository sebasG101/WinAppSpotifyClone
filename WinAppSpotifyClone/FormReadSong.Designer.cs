namespace WinAppSpotifyClone
{
    partial class FormReadSong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReadSong));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDSONGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sONGNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sONGPATHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pLAYSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tBLSONGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bDD_SpotifyMusicDataSet = new WinAppSpotifyClone.BDD_SpotifyMusicDataSet();
            this.tBL_SONGTableAdapter = new WinAppSpotifyClone.BDD_SpotifyMusicDataSetTableAdapters.TBL_SONGTableAdapter();
            this.bdD_SpotifyMusicDataSet1 = new WinAppSpotifyClone.BDD_SpotifyMusicDataSet();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.btnPlay3 = new System.Windows.Forms.Button();
            this.btnPlay4 = new System.Windows.Forms.Button();
            this.btnPlay5 = new System.Windows.Forms.Button();
            this.btnPlay1 = new System.Windows.Forms.Button();
            this.btnPlay2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLSONGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDD_SpotifyMusicDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdD_SpotifyMusicDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDSONGDataGridViewTextBoxColumn,
            this.sONGNAMEDataGridViewTextBoxColumn,
            this.sONGPATHDataGridViewTextBoxColumn,
            this.pLAYSDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tBLSONGBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(1, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(723, 503);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // iDSONGDataGridViewTextBoxColumn
            // 
            this.iDSONGDataGridViewTextBoxColumn.DataPropertyName = "ID_SONG";
            this.iDSONGDataGridViewTextBoxColumn.HeaderText = "ID_SONG";
            this.iDSONGDataGridViewTextBoxColumn.Name = "iDSONGDataGridViewTextBoxColumn";
            this.iDSONGDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sONGNAMEDataGridViewTextBoxColumn
            // 
            this.sONGNAMEDataGridViewTextBoxColumn.DataPropertyName = "SONG_NAME";
            this.sONGNAMEDataGridViewTextBoxColumn.HeaderText = "SONG_NAME";
            this.sONGNAMEDataGridViewTextBoxColumn.Name = "sONGNAMEDataGridViewTextBoxColumn";
            // 
            // sONGPATHDataGridViewTextBoxColumn
            // 
            this.sONGPATHDataGridViewTextBoxColumn.DataPropertyName = "SONG_PATH";
            this.sONGPATHDataGridViewTextBoxColumn.HeaderText = "SONG_PATH";
            this.sONGPATHDataGridViewTextBoxColumn.Name = "sONGPATHDataGridViewTextBoxColumn";
            // 
            // pLAYSDataGridViewTextBoxColumn
            // 
            this.pLAYSDataGridViewTextBoxColumn.DataPropertyName = "PLAYS";
            this.pLAYSDataGridViewTextBoxColumn.HeaderText = "PLAYS";
            this.pLAYSDataGridViewTextBoxColumn.Name = "pLAYSDataGridViewTextBoxColumn";
            // 
            // tBLSONGBindingSource
            // 
            this.tBLSONGBindingSource.DataMember = "TBL_SONG";
            this.tBLSONGBindingSource.DataSource = this.bDD_SpotifyMusicDataSet;
            // 
            // bDD_SpotifyMusicDataSet
            // 
            this.bDD_SpotifyMusicDataSet.DataSetName = "BDD_SpotifyMusicDataSet";
            this.bDD_SpotifyMusicDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBL_SONGTableAdapter
            // 
            this.tBL_SONGTableAdapter.ClearBeforeFill = true;
            // 
            // bdD_SpotifyMusicDataSet1
            // 
            this.bdD_SpotifyMusicDataSet1.DataSetName = "BDD_SpotifyMusicDataSet";
            this.bdD_SpotifyMusicDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(21, 177);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(433, 291);
            this.axWindowsMediaPlayer1.TabIndex = 2;
            // 
            // btnPlay3
            // 
            this.btnPlay3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnPlay3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPlay3.BackgroundImage")));
            this.btnPlay3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay3.Location = new System.Drawing.Point(448, 79);
            this.btnPlay3.Name = "btnPlay3";
            this.btnPlay3.Size = new System.Drawing.Size(98, 22);
            this.btnPlay3.TabIndex = 4;
            this.btnPlay3.Text = "▶";
            this.btnPlay3.UseVisualStyleBackColor = false;
            this.btnPlay3.Click += new System.EventHandler(this.btnPlay3_Click);
            // 
            // btnPlay4
            // 
            this.btnPlay4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnPlay4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPlay4.BackgroundImage")));
            this.btnPlay4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay4.Location = new System.Drawing.Point(448, 107);
            this.btnPlay4.Name = "btnPlay4";
            this.btnPlay4.Size = new System.Drawing.Size(98, 22);
            this.btnPlay4.TabIndex = 5;
            this.btnPlay4.Text = "▶";
            this.btnPlay4.UseVisualStyleBackColor = false;
            this.btnPlay4.Click += new System.EventHandler(this.btnPlay4_Click);
            // 
            // btnPlay5
            // 
            this.btnPlay5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnPlay5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPlay5.BackgroundImage")));
            this.btnPlay5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay5.Location = new System.Drawing.Point(448, 135);
            this.btnPlay5.Name = "btnPlay5";
            this.btnPlay5.Size = new System.Drawing.Size(98, 22);
            this.btnPlay5.TabIndex = 6;
            this.btnPlay5.Text = "▶";
            this.btnPlay5.UseVisualStyleBackColor = false;
            this.btnPlay5.Click += new System.EventHandler(this.btnPlay5_Click);
            // 
            // btnPlay1
            // 
            this.btnPlay1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnPlay1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPlay1.BackgroundImage")));
            this.btnPlay1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay1.Location = new System.Drawing.Point(448, 23);
            this.btnPlay1.Name = "btnPlay1";
            this.btnPlay1.Size = new System.Drawing.Size(98, 22);
            this.btnPlay1.TabIndex = 7;
            this.btnPlay1.Text = "▶";
            this.btnPlay1.UseVisualStyleBackColor = false;
            this.btnPlay1.Click += new System.EventHandler(this.btnPlay1_Click);
            // 
            // btnPlay2
            // 
            this.btnPlay2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnPlay2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPlay2.BackgroundImage")));
            this.btnPlay2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay2.Location = new System.Drawing.Point(448, 51);
            this.btnPlay2.Name = "btnPlay2";
            this.btnPlay2.Size = new System.Drawing.Size(98, 22);
            this.btnPlay2.TabIndex = 8;
            this.btnPlay2.Text = "▶";
            this.btnPlay2.UseVisualStyleBackColor = false;
            this.btnPlay2.Click += new System.EventHandler(this.btnPlay2_Click);
            // 
            // FormReadSong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 507);
            this.Controls.Add(this.btnPlay2);
            this.Controls.Add(this.btnPlay1);
            this.Controls.Add(this.btnPlay5);
            this.Controls.Add(this.btnPlay4);
            this.Controls.Add(this.btnPlay3);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormReadSong";
            this.Text = "Song Player";
            this.Load += new System.EventHandler(this.FormReadSong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLSONGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDD_SpotifyMusicDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdD_SpotifyMusicDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private BDD_SpotifyMusicDataSet bDD_SpotifyMusicDataSet;
        private System.Windows.Forms.BindingSource tBLSONGBindingSource;
        private BDD_SpotifyMusicDataSetTableAdapters.TBL_SONGTableAdapter tBL_SONGTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDSONGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sONGNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sONGPATHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pLAYSDataGridViewTextBoxColumn;
        private BDD_SpotifyMusicDataSet bdD_SpotifyMusicDataSet1;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Button btnPlay3;
        private System.Windows.Forms.Button btnPlay4;
        private System.Windows.Forms.Button btnPlay5;
        private System.Windows.Forms.Button btnPlay1;
        private System.Windows.Forms.Button btnPlay2;
    }
}