﻿namespace POTA_To_CAT
{
    partial class FormPOTA
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelLoading = new System.Windows.Forms.Label();
            this.labelNotLoaded = new System.Windows.Forms.Label();
            this.textBoxLog = new System.Windows.Forms.TextBox();
            this.radioButtonACTIVATIONS = new System.Windows.Forms.RadioButton();
            this.radioButtonSPOTS = new System.Windows.Forms.RadioButton();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBoxFilter = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reference = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spotName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Loc2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Frequency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Spotter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonRefreshingMin = new System.Windows.Forms.Button();
            this.timerStart = new System.Windows.Forms.Timer(this.components);
            this.timerRefresh = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panelPOTA = new System.Windows.Forms.Panel();
            this.radioButtonSOTA = new System.Windows.Forms.RadioButton();
            this.radioButtonPOTA = new System.Windows.Forms.RadioButton();
            this.panelSP = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelPOTA.SuspendLayout();
            this.panelSP.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panel1.Controls.Add(this.panelSP);
            this.panel1.Controls.Add(this.labelLoading);
            this.panel1.Controls.Add(this.labelNotLoaded);
            this.panel1.Controls.Add(this.textBoxLog);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1746, 656);
            this.panel1.TabIndex = 3;
            // 
            // labelLoading
            // 
            this.labelLoading.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLoading.BackColor = System.Drawing.Color.Olive;
            this.labelLoading.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelLoading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.labelLoading.Location = new System.Drawing.Point(1628, 52);
            this.labelLoading.Name = "labelLoading";
            this.labelLoading.Size = new System.Drawing.Size(98, 23);
            this.labelLoading.TabIndex = 64;
            this.labelLoading.Text = "Loading ...";
            this.labelLoading.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelLoading.Visible = false;
            // 
            // labelNotLoaded
            // 
            this.labelNotLoaded.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelNotLoaded.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelNotLoaded.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNotLoaded.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.labelNotLoaded.Location = new System.Drawing.Point(24, 100);
            this.labelNotLoaded.Name = "labelNotLoaded";
            this.labelNotLoaded.Size = new System.Drawing.Size(354, 47);
            this.labelNotLoaded.TabIndex = 63;
            this.labelNotLoaded.Text = "No data ...";
            this.labelNotLoaded.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelNotLoaded.Visible = false;
            this.labelNotLoaded.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // textBoxLog
            // 
            this.textBoxLog.Location = new System.Drawing.Point(1478, 134);
            this.textBoxLog.Multiline = true;
            this.textBoxLog.Name = "textBoxLog";
            this.textBoxLog.Size = new System.Drawing.Size(220, 284);
            this.textBoxLog.TabIndex = 62;
            this.textBoxLog.Visible = false;
            this.textBoxLog.WordWrap = false;
            // 
            // radioButtonACTIVATIONS
            // 
            this.radioButtonACTIVATIONS.AutoSize = true;
            this.radioButtonACTIVATIONS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButtonACTIVATIONS.Location = new System.Drawing.Point(131, 5);
            this.radioButtonACTIVATIONS.Name = "radioButtonACTIVATIONS";
            this.radioButtonACTIVATIONS.Size = new System.Drawing.Size(139, 24);
            this.radioButtonACTIVATIONS.TabIndex = 59;
            this.radioButtonACTIVATIONS.Text = "ACTIVATIONS";
            this.radioButtonACTIVATIONS.UseVisualStyleBackColor = true;
            this.radioButtonACTIVATIONS.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButtonSPOTS
            // 
            this.radioButtonSPOTS.AutoSize = true;
            this.radioButtonSPOTS.Checked = true;
            this.radioButtonSPOTS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButtonSPOTS.Location = new System.Drawing.Point(13, 5);
            this.radioButtonSPOTS.Name = "radioButtonSPOTS";
            this.radioButtonSPOTS.Size = new System.Drawing.Size(86, 24);
            this.radioButtonSPOTS.TabIndex = 58;
            this.radioButtonSPOTS.TabStop = true;
            this.radioButtonSPOTS.Text = "SPOTS";
            this.radioButtonSPOTS.UseVisualStyleBackColor = true;
            this.radioButtonSPOTS.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button3.Location = new System.Drawing.Point(655, 8);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 31);
            this.button3.TabIndex = 57;
            this.button3.Text = "Clear Filter";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.Location = new System.Drawing.Point(528, 7);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 31);
            this.button2.TabIndex = 56;
            this.button2.Text = "Filter";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBoxFilter
            // 
            this.textBoxFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxFilter.Location = new System.Drawing.Point(294, 9);
            this.textBoxFilter.Name = "textBoxFilter";
            this.textBoxFilter.Size = new System.Drawing.Size(217, 27);
            this.textBoxFilter.TabIndex = 55;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(11, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 20);
            this.label1.TabIndex = 54;
            this.label1.Text = "Filter (OR funct. in some columns):";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Reference,
            this.spotName,
            this.Loc2,
            this.Frequency,
            this.Mode,
            this.Grid,
            this.Spotter,
            this.Comments,
            this.Time});
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(15, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ShowCellErrors = false;
            this.dataGridView1.ShowCellToolTips = false;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.ShowRowErrors = false;
            this.dataGridView1.Size = new System.Drawing.Size(1711, 592);
            this.dataGridView1.TabIndex = 53;
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Activator";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 95;
            // 
            // Reference
            // 
            this.Reference.HeaderText = "Reference";
            this.Reference.MinimumWidth = 6;
            this.Reference.Name = "Reference";
            this.Reference.ReadOnly = true;
            this.Reference.Width = 90;
            // 
            // spotName
            // 
            this.spotName.HeaderText = "Name";
            this.spotName.MinimumWidth = 6;
            this.spotName.Name = "spotName";
            this.spotName.ReadOnly = true;
            this.spotName.Width = 300;
            // 
            // Loc2
            // 
            this.Loc2.HeaderText = "Location Decription";
            this.Loc2.MinimumWidth = 6;
            this.Loc2.Name = "Loc2";
            this.Loc2.ReadOnly = true;
            this.Loc2.Width = 125;
            // 
            // Frequency
            // 
            this.Frequency.HeaderText = "Frequency";
            this.Frequency.MinimumWidth = 6;
            this.Frequency.Name = "Frequency";
            this.Frequency.ReadOnly = true;
            this.Frequency.Width = 125;
            // 
            // Mode
            // 
            this.Mode.HeaderText = "Mode";
            this.Mode.MinimumWidth = 6;
            this.Mode.Name = "Mode";
            this.Mode.ReadOnly = true;
            this.Mode.Width = 80;
            // 
            // Grid
            // 
            this.Grid.HeaderText = "Grid";
            this.Grid.MinimumWidth = 6;
            this.Grid.Name = "Grid";
            this.Grid.ReadOnly = true;
            this.Grid.Width = 125;
            // 
            // Spotter
            // 
            this.Spotter.HeaderText = "Spotter";
            this.Spotter.MinimumWidth = 6;
            this.Spotter.Name = "Spotter";
            this.Spotter.ReadOnly = true;
            this.Spotter.Width = 125;
            // 
            // Comments
            // 
            this.Comments.HeaderText = "Comments";
            this.Comments.MinimumWidth = 6;
            this.Comments.Name = "Comments";
            this.Comments.ReadOnly = true;
            this.Comments.Width = 300;
            // 
            // Time
            // 
            this.Time.HeaderText = "Date time";
            this.Time.MinimumWidth = 6;
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            this.Time.Width = 300;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonRefresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonRefresh.Location = new System.Drawing.Point(1617, 11);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(106, 31);
            this.buttonRefresh.TabIndex = 52;
            this.buttonRefresh.Text = "Refresh now";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // buttonRefreshingMin
            // 
            this.buttonRefreshingMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRefreshingMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonRefreshingMin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonRefreshingMin.Location = new System.Drawing.Point(1342, 11);
            this.buttonRefreshingMin.Name = "buttonRefreshingMin";
            this.buttonRefreshingMin.Size = new System.Drawing.Size(255, 31);
            this.buttonRefreshingMin.TabIndex = 49;
            this.buttonRefreshingMin.Text = "Start refresh every 2 min.";
            this.buttonRefreshingMin.UseVisualStyleBackColor = true;
            this.buttonRefreshingMin.Click += new System.EventHandler(this.buttonRefreshingMin_Click);
            // 
            // timerStart
            // 
            this.timerStart.Tick += new System.EventHandler(this.timerStart_Tick);
            // 
            // timerRefresh
            // 
            this.timerRefresh.Interval = 120000;
            this.timerRefresh.Tick += new System.EventHandler(this.timerRefresh_Tick);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // panelPOTA
            // 
            this.panelPOTA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelPOTA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPOTA.Controls.Add(this.radioButtonSPOTS);
            this.panelPOTA.Controls.Add(this.radioButtonACTIVATIONS);
            this.panelPOTA.Location = new System.Drawing.Point(1027, 8);
            this.panelPOTA.Name = "panelPOTA";
            this.panelPOTA.Size = new System.Drawing.Size(285, 34);
            this.panelPOTA.TabIndex = 65;
            // 
            // radioButtonSOTA
            // 
            this.radioButtonSOTA.AutoSize = true;
            this.radioButtonSOTA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButtonSOTA.Location = new System.Drawing.Point(818, 14);
            this.radioButtonSOTA.Name = "radioButtonSOTA";
            this.radioButtonSOTA.Size = new System.Drawing.Size(75, 24);
            this.radioButtonSOTA.TabIndex = 66;
            this.radioButtonSOTA.Text = "SOTA";
            this.radioButtonSOTA.UseVisualStyleBackColor = true;
            this.radioButtonSOTA.CheckedChanged += new System.EventHandler(this.radioButtonSOTA_CheckedChanged);
            // 
            // radioButtonPOTA
            // 
            this.radioButtonPOTA.AutoSize = true;
            this.radioButtonPOTA.Checked = true;
            this.radioButtonPOTA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButtonPOTA.Location = new System.Drawing.Point(910, 14);
            this.radioButtonPOTA.Name = "radioButtonPOTA";
            this.radioButtonPOTA.Size = new System.Drawing.Size(75, 24);
            this.radioButtonPOTA.TabIndex = 67;
            this.radioButtonPOTA.TabStop = true;
            this.radioButtonPOTA.Text = "POTA";
            this.radioButtonPOTA.UseVisualStyleBackColor = true;
            this.radioButtonPOTA.CheckedChanged += new System.EventHandler(this.radioButtonSOTA_CheckedChanged);
            // 
            // panelSP
            // 
            this.panelSP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSP.Controls.Add(this.radioButtonSOTA);
            this.panelSP.Controls.Add(this.radioButtonPOTA);
            this.panelSP.Controls.Add(this.buttonRefreshingMin);
            this.panelSP.Controls.Add(this.buttonRefresh);
            this.panelSP.Controls.Add(this.button3);
            this.panelSP.Controls.Add(this.button2);
            this.panelSP.Controls.Add(this.panelPOTA);
            this.panelSP.Controls.Add(this.textBoxFilter);
            this.panelSP.Controls.Add(this.label1);
            this.panelSP.Location = new System.Drawing.Point(3, 1);
            this.panelSP.Name = "panelSP";
            this.panelSP.Size = new System.Drawing.Size(1731, 50);
            this.panelSP.TabIndex = 68;
            // 
            // FormPOTA
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1750, 660);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Name = "FormPOTA";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.ShowIcon = false;
            this.Text = "SOTA/POTA To CAT";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelPOTA.ResumeLayout(false);
            this.panelPOTA.PerformLayout();
            this.panelSP.ResumeLayout(false);
            this.panelSP.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonRefreshingMin;
        private System.Windows.Forms.Timer timerStart;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBoxFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButtonACTIVATIONS;
        private System.Windows.Forms.RadioButton radioButtonSPOTS;
        private System.Windows.Forms.Timer timerRefresh;
        private System.Windows.Forms.TextBox textBoxLog;
        private System.Windows.Forms.Label labelLoading;
        private System.Windows.Forms.Label labelNotLoaded;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reference;
        private System.Windows.Forms.DataGridViewTextBoxColumn spotName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Loc2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Frequency;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Spotter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comments;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.RadioButton radioButtonPOTA;
        private System.Windows.Forms.RadioButton radioButtonSOTA;
        private System.Windows.Forms.Panel panelPOTA;
        private System.Windows.Forms.Panel panelSP;
    }
}

