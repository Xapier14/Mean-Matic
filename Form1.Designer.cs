namespace MeanMatic
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dg_qdata = new System.Windows.Forms.DataGridView();
            this.qC_Weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qC_Frequency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_LoadQData = new System.Windows.Forms.Button();
            this.tb_NewQuestion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button_AddQuestion = new System.Windows.Forms.Button();
            this.button_oRefresh = new System.Windows.Forms.Button();
            this.button_SaveQuestionData = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.TB_weight = new System.Windows.Forms.TextBox();
            this.TB_freq = new System.Windows.Forms.TextBox();
            this.button_SetFreq = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label_LoadedQu = new System.Windows.Forms.Label();
            this.CB_RTM = new System.Windows.Forms.CheckBox();
            this.button_UnloadData = new System.Windows.Forms.Button();
            this.dg_Overview = new System.Windows.Forms.DataGridView();
            this.dgC_Q = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgC_Points = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgC_R = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgC_WAM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgC_Variance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgC_StdDev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CB_IncQ = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button_ExportData = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dg_qdata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Overview)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Overview Data:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Question Data:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dg_qdata
            // 
            this.dg_qdata.AllowUserToAddRows = false;
            this.dg_qdata.AllowUserToDeleteRows = false;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dg_qdata.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle22;
            this.dg_qdata.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dg_qdata.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.dg_qdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_qdata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.qC_Weight,
            this.qC_Frequency});
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dg_qdata.DefaultCellStyle = dataGridViewCellStyle23;
            this.dg_qdata.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dg_qdata.GridColor = System.Drawing.Color.Black;
            this.dg_qdata.Location = new System.Drawing.Point(12, 291);
            this.dg_qdata.MultiSelect = false;
            this.dg_qdata.Name = "dg_qdata";
            this.dg_qdata.ReadOnly = true;
            this.dg_qdata.RowHeadersWidth = 51;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dg_qdata.RowsDefaultCellStyle = dataGridViewCellStyle24;
            this.dg_qdata.RowTemplate.Height = 24;
            this.dg_qdata.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_qdata.Size = new System.Drawing.Size(868, 161);
            this.dg_qdata.TabIndex = 3;
            this.dg_qdata.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dg_qdata.SelectionChanged += new System.EventHandler(this.dg_qdata_selChange);
            // 
            // qC_Weight
            // 
            this.qC_Weight.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.qC_Weight.HeaderText = "Weight (Point)";
            this.qC_Weight.MinimumWidth = 6;
            this.qC_Weight.Name = "qC_Weight";
            this.qC_Weight.ReadOnly = true;
            // 
            // qC_Frequency
            // 
            this.qC_Frequency.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.qC_Frequency.HeaderText = "Frequency (Responses)";
            this.qC_Frequency.MinimumWidth = 6;
            this.qC_Frequency.Name = "qC_Frequency";
            this.qC_Frequency.ReadOnly = true;
            // 
            // button_LoadQData
            // 
            this.button_LoadQData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_LoadQData.BackColor = System.Drawing.Color.Yellow;
            this.button_LoadQData.ForeColor = System.Drawing.Color.Black;
            this.button_LoadQData.Location = new System.Drawing.Point(697, 224);
            this.button_LoadQData.Name = "button_LoadQData";
            this.button_LoadQData.Size = new System.Drawing.Size(183, 31);
            this.button_LoadQData.TabIndex = 4;
            this.button_LoadQData.Text = "Load Question Data";
            this.button_LoadQData.UseVisualStyleBackColor = false;
            this.button_LoadQData.Click += new System.EventHandler(this.button_LoadQData_Click);
            // 
            // tb_NewQuestion
            // 
            this.tb_NewQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_NewQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.tb_NewQuestion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tb_NewQuestion.Location = new System.Drawing.Point(115, 230);
            this.tb_NewQuestion.Name = "tb_NewQuestion";
            this.tb_NewQuestion.Size = new System.Drawing.Size(418, 22);
            this.tb_NewQuestion.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "New Question:";
            // 
            // button_AddQuestion
            // 
            this.button_AddQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_AddQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button_AddQuestion.ForeColor = System.Drawing.Color.Black;
            this.button_AddQuestion.Location = new System.Drawing.Point(539, 230);
            this.button_AddQuestion.Name = "button_AddQuestion";
            this.button_AddQuestion.Size = new System.Drawing.Size(116, 23);
            this.button_AddQuestion.TabIndex = 7;
            this.button_AddQuestion.Text = "Add Question";
            this.button_AddQuestion.UseVisualStyleBackColor = false;
            this.button_AddQuestion.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_oRefresh
            // 
            this.button_oRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_oRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.button_oRefresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button_oRefresh.Location = new System.Drawing.Point(754, 6);
            this.button_oRefresh.Name = "button_oRefresh";
            this.button_oRefresh.Size = new System.Drawing.Size(126, 23);
            this.button_oRefresh.TabIndex = 9;
            this.button_oRefresh.Text = "Refresh Source";
            this.button_oRefresh.UseVisualStyleBackColor = false;
            this.button_oRefresh.Click += new System.EventHandler(this.button_oRefresh_Click);
            // 
            // button_SaveQuestionData
            // 
            this.button_SaveQuestionData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_SaveQuestionData.BackColor = System.Drawing.Color.Yellow;
            this.button_SaveQuestionData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_SaveQuestionData.Location = new System.Drawing.Point(539, 485);
            this.button_SaveQuestionData.Name = "button_SaveQuestionData";
            this.button_SaveQuestionData.Size = new System.Drawing.Size(179, 23);
            this.button_SaveQuestionData.TabIndex = 10;
            this.button_SaveQuestionData.Text = "Save Question Data";
            this.button_SaveQuestionData.UseVisualStyleBackColor = false;
            this.button_SaveQuestionData.Click += new System.EventHandler(this.button_SaveQuestionData_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 461);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Weight:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 488);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Frequency:";
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button3.Location = new System.Drawing.Point(273, 458);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(338, 23);
            this.button3.TabIndex = 13;
            this.button3.Text = "Increment specified frequency to specified weight";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // TB_weight
            // 
            this.TB_weight.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_weight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.TB_weight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TB_weight.Location = new System.Drawing.Point(97, 458);
            this.TB_weight.Name = "TB_weight";
            this.TB_weight.Size = new System.Drawing.Size(61, 22);
            this.TB_weight.TabIndex = 14;
            // 
            // TB_freq
            // 
            this.TB_freq.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_freq.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.TB_freq.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TB_freq.Location = new System.Drawing.Point(97, 486);
            this.TB_freq.Name = "TB_freq";
            this.TB_freq.Size = new System.Drawing.Size(61, 22);
            this.TB_freq.TabIndex = 15;
            // 
            // button_SetFreq
            // 
            this.button_SetFreq.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_SetFreq.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button_SetFreq.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_SetFreq.Location = new System.Drawing.Point(273, 486);
            this.button_SetFreq.Name = "button_SetFreq";
            this.button_SetFreq.Size = new System.Drawing.Size(260, 23);
            this.button_SetFreq.TabIndex = 16;
            this.button_SetFreq.Text = "Set frequency to specified weight";
            this.button_SetFreq.UseVisualStyleBackColor = false;
            this.button_SetFreq.Click += new System.EventHandler(this.button_SetFreq_Click);
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button5.Location = new System.Drawing.Point(724, 485);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(156, 23);
            this.button5.TabIndex = 17;
            this.button5.Text = "About Program";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label_LoadedQu
            // 
            this.label_LoadedQu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_LoadedQu.AutoSize = true;
            this.label_LoadedQu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label_LoadedQu.ForeColor = System.Drawing.Color.Black;
            this.label_LoadedQu.Location = new System.Drawing.Point(178, 271);
            this.label_LoadedQu.Name = "label_LoadedQu";
            this.label_LoadedQu.Size = new System.Drawing.Size(158, 17);
            this.label_LoadedQu.TabIndex = 18;
            this.label_LoadedQu.Text = "Loaded Question: -N/A-";
            this.label_LoadedQu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_LoadedQu.Click += new System.EventHandler(this.label_LoadedQu_Click);
            // 
            // CB_RTM
            // 
            this.CB_RTM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CB_RTM.AutoSize = true;
            this.CB_RTM.Location = new System.Drawing.Point(724, 458);
            this.CB_RTM.Name = "CB_RTM";
            this.CB_RTM.Size = new System.Drawing.Size(156, 21);
            this.CB_RTM.TabIndex = 19;
            this.CB_RTM.Text = "Real Time Selection";
            this.CB_RTM.UseVisualStyleBackColor = true;
            // 
            // button_UnloadData
            // 
            this.button_UnloadData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_UnloadData.BackColor = System.Drawing.Color.Red;
            this.button_UnloadData.ForeColor = System.Drawing.Color.White;
            this.button_UnloadData.Location = new System.Drawing.Point(617, 458);
            this.button_UnloadData.Name = "button_UnloadData";
            this.button_UnloadData.Size = new System.Drawing.Size(101, 23);
            this.button_UnloadData.TabIndex = 20;
            this.button_UnloadData.Text = "Unload Data";
            this.button_UnloadData.UseVisualStyleBackColor = false;
            this.button_UnloadData.Click += new System.EventHandler(this.button_UnloadData_Click);
            // 
            // dg_Overview
            // 
            this.dg_Overview.AllowUserToAddRows = false;
            this.dg_Overview.AllowUserToDeleteRows = false;
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle25.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dg_Overview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle25;
            this.dg_Overview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dg_Overview.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle26.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle26.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_Overview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle26;
            this.dg_Overview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Overview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgC_Q,
            this.dgC_Points,
            this.dgC_R,
            this.dgC_WAM,
            this.dgC_Variance,
            this.dgC_StdDev});
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle27.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dg_Overview.DefaultCellStyle = dataGridViewCellStyle27;
            this.dg_Overview.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dg_Overview.GridColor = System.Drawing.Color.Black;
            this.dg_Overview.Location = new System.Drawing.Point(12, 35);
            this.dg_Overview.MultiSelect = false;
            this.dg_Overview.Name = "dg_Overview";
            this.dg_Overview.ReadOnly = true;
            this.dg_Overview.RowHeadersWidth = 51;
            dataGridViewCellStyle28.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle28.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dg_Overview.RowsDefaultCellStyle = dataGridViewCellStyle28;
            this.dg_Overview.RowTemplate.Height = 24;
            this.dg_Overview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_Overview.Size = new System.Drawing.Size(868, 183);
            this.dg_Overview.TabIndex = 0;
            this.dg_Overview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_Overview_CellContentClick);
            // 
            // dgC_Q
            // 
            this.dgC_Q.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgC_Q.HeaderText = "Question (Statement)";
            this.dgC_Q.MinimumWidth = 6;
            this.dgC_Q.Name = "dgC_Q";
            this.dgC_Q.ReadOnly = true;
            // 
            // dgC_Points
            // 
            this.dgC_Points.HeaderText = "Points (Number of Weights)";
            this.dgC_Points.MinimumWidth = 6;
            this.dgC_Points.Name = "dgC_Points";
            this.dgC_Points.ReadOnly = true;
            this.dgC_Points.Width = 125;
            // 
            // dgC_R
            // 
            this.dgC_R.HeaderText = "Responses";
            this.dgC_R.MinimumWidth = 6;
            this.dgC_R.Name = "dgC_R";
            this.dgC_R.ReadOnly = true;
            this.dgC_R.Width = 125;
            // 
            // dgC_WAM
            // 
            this.dgC_WAM.HeaderText = "WAM";
            this.dgC_WAM.MinimumWidth = 6;
            this.dgC_WAM.Name = "dgC_WAM";
            this.dgC_WAM.ReadOnly = true;
            this.dgC_WAM.Width = 125;
            // 
            // dgC_Variance
            // 
            this.dgC_Variance.HeaderText = "Variance";
            this.dgC_Variance.MinimumWidth = 6;
            this.dgC_Variance.Name = "dgC_Variance";
            this.dgC_Variance.ReadOnly = true;
            this.dgC_Variance.Width = 125;
            // 
            // dgC_StdDev
            // 
            this.dgC_StdDev.HeaderText = "Standard Deviation";
            this.dgC_StdDev.MinimumWidth = 6;
            this.dgC_StdDev.Name = "dgC_StdDev";
            this.dgC_StdDev.ReadOnly = true;
            this.dgC_StdDev.Width = 125;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.CB_IncQ);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(164, 458);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(103, 50);
            this.panel1.TabIndex = 21;
            // 
            // CB_IncQ
            // 
            this.CB_IncQ.AutoSize = true;
            this.CB_IncQ.Location = new System.Drawing.Point(26, 27);
            this.CB_IncQ.Name = "CB_IncQ";
            this.CB_IncQ.Size = new System.Drawing.Size(67, 21);
            this.CB_IncQ.TabIndex = 22;
            this.CB_IncQ.Text = "Inc. Q";
            this.CB_IncQ.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(0, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 17);
            this.label6.TabIndex = 22;
            this.label6.Text = "Quick Add 1";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(0, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(20, 22);
            this.textBox1.TabIndex = 22;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button_ExportData
            // 
            this.button_ExportData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_ExportData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_ExportData.Location = new System.Drawing.Point(574, 6);
            this.button_ExportData.Name = "button_ExportData";
            this.button_ExportData.Size = new System.Drawing.Size(174, 23);
            this.button_ExportData.TabIndex = 22;
            this.button_ExportData.Text = "Export Data (.txt)";
            this.button_ExportData.UseVisualStyleBackColor = false;
            this.button_ExportData.Click += new System.EventHandler(this.button_ExportData_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "txt";
            this.saveFileDialog1.Filter = "Text files|*.txt";
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(892, 523);
            this.Controls.Add(this.button_ExportData);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dg_Overview);
            this.Controls.Add(this.label_LoadedQu);
            this.Controls.Add(this.button_UnloadData);
            this.Controls.Add(this.CB_RTM);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button_SetFreq);
            this.Controls.Add(this.TB_freq);
            this.Controls.Add(this.TB_weight);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button_SaveQuestionData);
            this.Controls.Add(this.button_oRefresh);
            this.Controls.Add(this.button_AddQuestion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_NewQuestion);
            this.Controls.Add(this.button_LoadQData);
            this.Controls.Add(this.dg_qdata);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Silver;
            this.MinimumSize = new System.Drawing.Size(910, 570);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Mean-Matic";
            ((System.ComponentModel.ISupportInitialize)(this.dg_qdata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Overview)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dg_qdata;
        private System.Windows.Forms.Button button_LoadQData;
        private System.Windows.Forms.TextBox tb_NewQuestion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_AddQuestion;
        private System.Windows.Forms.Button button_oRefresh;
        private System.Windows.Forms.Button button_SaveQuestionData;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox TB_weight;
        private System.Windows.Forms.TextBox TB_freq;
        private System.Windows.Forms.Button button_SetFreq;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label_LoadedQu;
        private System.Windows.Forms.CheckBox CB_RTM;
        private System.Windows.Forms.Button button_UnloadData;
        private System.Windows.Forms.DataGridViewTextBoxColumn qC_Weight;
        private System.Windows.Forms.DataGridViewTextBoxColumn qC_Frequency;
        private System.Windows.Forms.DataGridView dg_Overview;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgC_Q;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgC_Points;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgC_R;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgC_WAM;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgC_Variance;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgC_StdDev;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox CB_IncQ;
        private System.Windows.Forms.Button button_ExportData;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

