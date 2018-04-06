namespace Jogo_do_8
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bt00 = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.bt08 = new System.Windows.Forms.Button();
            this.bt07 = new System.Windows.Forms.Button();
            this.bt06 = new System.Windows.Forms.Button();
            this.bt05 = new System.Windows.Forms.Button();
            this.bt04 = new System.Windows.Forms.Button();
            this.bt03 = new System.Windows.Forms.Button();
            this.bt02 = new System.Windows.Forms.Button();
            this.bt01 = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.btSortear = new System.Windows.Forms.Button();
            this.btRunThreads = new System.Windows.Forms.Button();
            this.ltbCaminhoLagura = new System.Windows.Forms.ListBox();
            this.threadBuscaEmLargura = new System.ComponentModel.BackgroundWorker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblTime = new System.Windows.Forms.Label();
            this.threadBuscaEmProfundidade = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ltbCaminhoProfundidadeIter = new System.Windows.Forms.ListBox();
            this.lblLarg = new System.Windows.Forms.Label();
            this.lblProf = new System.Windows.Forms.Label();
            this.ckbAndamento = new System.Windows.Forms.CheckBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btStop = new System.Windows.Forms.Button();
            this.txtCadeiaProblema = new System.Windows.Forms.TextBox();
            this.lblLargExp = new System.Windows.Forms.Label();
            this.lblProfExp = new System.Windows.Forms.Label();
            this.lblLargSteps = new System.Windows.Forms.Label();
            this.lblProfSteps = new System.Windows.Forms.Label();
            this.threadBuscaEmLarguraH1 = new System.ComponentModel.BackgroundWorker();
            this.threadBuscaEmProfundidadeH1 = new System.ComponentModel.BackgroundWorker();
            this.lblLargStepsH1 = new System.Windows.Forms.Label();
            this.lblLargExpH1 = new System.Windows.Forms.Label();
            this.lblLargH1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ltbCaminhoLaguraH1 = new System.Windows.Forms.ListBox();
            this.lblProfStepsH1 = new System.Windows.Forms.Label();
            this.lblProfExpH1 = new System.Windows.Forms.Label();
            this.lblProfH1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ltbCaminhoProfundidade = new System.Windows.Forms.ListBox();
            this.dgvAnimar = new System.Windows.Forms.DataGridView();
            this.col0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btAnimarLarg = new System.Windows.Forms.Button();
            this.btAnimarProfInter = new System.Windows.Forms.Button();
            this.btAnimarProf = new System.Windows.Forms.Button();
            this.btAnimarLargH1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnimar)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bt00);
            this.groupBox1.Controls.Add(this.bt08);
            this.groupBox1.Controls.Add(this.bt07);
            this.groupBox1.Controls.Add(this.bt06);
            this.groupBox1.Controls.Add(this.bt05);
            this.groupBox1.Controls.Add(this.bt04);
            this.groupBox1.Controls.Add(this.bt03);
            this.groupBox1.Controls.Add(this.bt02);
            this.groupBox1.Controls.Add(this.bt01);
            this.groupBox1.Location = new System.Drawing.Point(1, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(141, 135);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // bt00
            // 
            this.bt00.AllowDrop = true;
            this.bt00.BackColor = System.Drawing.Color.Transparent;
            this.bt00.ImageIndex = 0;
            this.bt00.ImageList = this.imageList1;
            this.bt00.Location = new System.Drawing.Point(90, 90);
            this.bt00.Name = "bt00";
            this.bt00.Size = new System.Drawing.Size(40, 40);
            this.bt00.TabIndex = 0;
            this.bt00.Tag = "0";
            this.bt00.UseVisualStyleBackColor = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "focus-icon.png");
            // 
            // bt08
            // 
            this.bt08.AllowDrop = true;
            this.bt08.Location = new System.Drawing.Point(50, 90);
            this.bt08.Name = "bt08";
            this.bt08.Size = new System.Drawing.Size(40, 40);
            this.bt08.TabIndex = 8;
            this.bt08.Tag = "8";
            this.bt08.Text = "8";
            this.bt08.UseVisualStyleBackColor = true;
            // 
            // bt07
            // 
            this.bt07.Location = new System.Drawing.Point(10, 90);
            this.bt07.Name = "bt07";
            this.bt07.Size = new System.Drawing.Size(40, 40);
            this.bt07.TabIndex = 7;
            this.bt07.Tag = "7";
            this.bt07.Text = "7";
            this.bt07.UseVisualStyleBackColor = true;
            // 
            // bt06
            // 
            this.bt06.Location = new System.Drawing.Point(90, 50);
            this.bt06.Name = "bt06";
            this.bt06.Size = new System.Drawing.Size(40, 40);
            this.bt06.TabIndex = 6;
            this.bt06.Tag = "6";
            this.bt06.Text = "6";
            this.bt06.UseVisualStyleBackColor = true;
            // 
            // bt05
            // 
            this.bt05.Location = new System.Drawing.Point(50, 50);
            this.bt05.Name = "bt05";
            this.bt05.Size = new System.Drawing.Size(40, 40);
            this.bt05.TabIndex = 5;
            this.bt05.Tag = "5";
            this.bt05.Text = "5";
            this.bt05.UseVisualStyleBackColor = true;
            // 
            // bt04
            // 
            this.bt04.Location = new System.Drawing.Point(10, 50);
            this.bt04.Name = "bt04";
            this.bt04.Size = new System.Drawing.Size(40, 40);
            this.bt04.TabIndex = 4;
            this.bt04.Tag = "4";
            this.bt04.Text = "4";
            this.bt04.UseVisualStyleBackColor = true;
            // 
            // bt03
            // 
            this.bt03.Location = new System.Drawing.Point(90, 10);
            this.bt03.Name = "bt03";
            this.bt03.Size = new System.Drawing.Size(40, 40);
            this.bt03.TabIndex = 3;
            this.bt03.Tag = "3";
            this.bt03.Text = "3";
            this.bt03.UseVisualStyleBackColor = true;
            // 
            // bt02
            // 
            this.bt02.Location = new System.Drawing.Point(50, 10);
            this.bt02.Name = "bt02";
            this.bt02.Size = new System.Drawing.Size(40, 40);
            this.bt02.TabIndex = 2;
            this.bt02.Tag = "2";
            this.bt02.Text = "2";
            this.bt02.UseVisualStyleBackColor = true;
            // 
            // bt01
            // 
            this.bt01.Location = new System.Drawing.Point(10, 10);
            this.bt01.Name = "bt01";
            this.bt01.Size = new System.Drawing.Size(40, 40);
            this.bt01.TabIndex = 1;
            this.bt01.Tag = "1";
            this.bt01.Text = "1";
            this.bt01.UseVisualStyleBackColor = true;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Italic);
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(159, 49);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(16, 13);
            this.lblError.TabIndex = 1;
            this.lblError.Text = "...";
            // 
            // btSortear
            // 
            this.btSortear.Location = new System.Drawing.Point(162, 22);
            this.btSortear.Name = "btSortear";
            this.btSortear.Size = new System.Drawing.Size(75, 23);
            this.btSortear.TabIndex = 2;
            this.btSortear.Text = "Sortear Numeros";
            this.btSortear.UseVisualStyleBackColor = true;
            this.btSortear.Click += new System.EventHandler(this.btSortear_Click);
            // 
            // btRunThreads
            // 
            this.btRunThreads.Location = new System.Drawing.Point(12, 172);
            this.btRunThreads.Name = "btRunThreads";
            this.btRunThreads.Size = new System.Drawing.Size(96, 29);
            this.btRunThreads.TabIndex = 3;
            this.btRunThreads.Text = "Executar";
            this.btRunThreads.UseVisualStyleBackColor = true;
            this.btRunThreads.Click += new System.EventHandler(this.btRunThreads_Click);
            // 
            // ltbCaminhoLagura
            // 
            this.ltbCaminhoLagura.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ltbCaminhoLagura.FormattingEnabled = true;
            this.ltbCaminhoLagura.Location = new System.Drawing.Point(12, 245);
            this.ltbCaminhoLagura.Name = "ltbCaminhoLagura";
            this.ltbCaminhoLagura.Size = new System.Drawing.Size(121, 264);
            this.ltbCaminhoLagura.TabIndex = 4;
            // 
            // threadBuscaEmLargura
            // 
            this.threadBuscaEmLargura.WorkerSupportsCancellation = true;
            this.threadBuscaEmLargura.DoWork += new System.ComponentModel.DoWorkEventHandler(this.threadBuscaEmLargura_DoWork);
            this.threadBuscaEmLargura.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.threadBuscaEmLargura_RunWorkerCompleted);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(12, 204);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(93, 13);
            this.lblTime.TabIndex = 5;
            this.lblTime.Text = "Tempo decorrido.:";
            // 
            // threadBuscaEmProfundidade
            // 
            this.threadBuscaEmProfundidade.WorkerSupportsCancellation = true;
            this.threadBuscaEmProfundidade.DoWork += new System.ComponentModel.DoWorkEventHandler(this.threadBuscaEmProfundidadeItera_DoWork);
            this.threadBuscaEmProfundidade.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.threadBuscaEmProfundidadeItera_RunWorkerCompleted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Busca em Largura";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(136, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Busca Prof. Iterativa";
            // 
            // ltbCaminhoProfundidadeIter
            // 
            this.ltbCaminhoProfundidadeIter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ltbCaminhoProfundidadeIter.FormattingEnabled = true;
            this.ltbCaminhoProfundidadeIter.Location = new System.Drawing.Point(139, 245);
            this.ltbCaminhoProfundidadeIter.Name = "ltbCaminhoProfundidadeIter";
            this.ltbCaminhoProfundidadeIter.Size = new System.Drawing.Size(157, 264);
            this.ltbCaminhoProfundidadeIter.TabIndex = 7;
            // 
            // lblLarg
            // 
            this.lblLarg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblLarg.AutoSize = true;
            this.lblLarg.Location = new System.Drawing.Point(9, 512);
            this.lblLarg.Name = "lblLarg";
            this.lblLarg.Size = new System.Drawing.Size(49, 13);
            this.lblLarg.TabIndex = 9;
            this.lblLarg.Text = "00:00:00";
            // 
            // lblProf
            // 
            this.lblProf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblProf.AutoSize = true;
            this.lblProf.Location = new System.Drawing.Point(136, 512);
            this.lblProf.Name = "lblProf";
            this.lblProf.Size = new System.Drawing.Size(49, 13);
            this.lblProf.TabIndex = 10;
            this.lblProf.Text = "00:00:00";
            // 
            // ckbAndamento
            // 
            this.ckbAndamento.AutoSize = true;
            this.ckbAndamento.Location = new System.Drawing.Point(12, 153);
            this.ckbAndamento.Name = "ckbAndamento";
            this.ckbAndamento.Size = new System.Drawing.Size(98, 17);
            this.ckbAndamento.TabIndex = 11;
            this.ckbAndamento.Text = "Ver andamento";
            this.toolTip1.SetToolTip(this.ckbAndamento, "Visualizar o andamento atrapalha a performance.:");
            this.ckbAndamento.UseVisualStyleBackColor = true;
            // 
            // btStop
            // 
            this.btStop.Location = new System.Drawing.Point(114, 172);
            this.btStop.Name = "btStop";
            this.btStop.Size = new System.Drawing.Size(75, 29);
            this.btStop.TabIndex = 12;
            this.btStop.Text = "Parar";
            this.btStop.UseVisualStyleBackColor = true;
            this.btStop.Click += new System.EventHandler(this.btStop_Click);
            // 
            // txtCadeiaProblema
            // 
            this.txtCadeiaProblema.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCadeiaProblema.Location = new System.Drawing.Point(162, 87);
            this.txtCadeiaProblema.MaxLength = 9;
            this.txtCadeiaProblema.Name = "txtCadeiaProblema";
            this.txtCadeiaProblema.Size = new System.Drawing.Size(83, 22);
            this.txtCadeiaProblema.TabIndex = 13;
            this.txtCadeiaProblema.Text = "123456078";
            this.txtCadeiaProblema.Validating += new System.ComponentModel.CancelEventHandler(this.txtCadeiaProblema_Validating);
            // 
            // lblLargExp
            // 
            this.lblLargExp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblLargExp.AutoSize = true;
            this.lblLargExp.Location = new System.Drawing.Point(8, 534);
            this.lblLargExp.Name = "lblLargExp";
            this.lblLargExp.Size = new System.Drawing.Size(43, 13);
            this.lblLargExp.TabIndex = 14;
            this.lblLargExp.Text = "Abertos";
            // 
            // lblProfExp
            // 
            this.lblProfExp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblProfExp.AutoSize = true;
            this.lblProfExp.Location = new System.Drawing.Point(136, 534);
            this.lblProfExp.Name = "lblProfExp";
            this.lblProfExp.Size = new System.Drawing.Size(43, 13);
            this.lblProfExp.TabIndex = 15;
            this.lblProfExp.Text = "Abertos";
            // 
            // lblLargSteps
            // 
            this.lblLargSteps.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblLargSteps.AutoSize = true;
            this.lblLargSteps.Location = new System.Drawing.Point(8, 558);
            this.lblLargSteps.Name = "lblLargSteps";
            this.lblLargSteps.Size = new System.Drawing.Size(40, 13);
            this.lblLargSteps.TabIndex = 16;
            this.lblLargSteps.Text = "Steps.:";
            // 
            // lblProfSteps
            // 
            this.lblProfSteps.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblProfSteps.AutoSize = true;
            this.lblProfSteps.Location = new System.Drawing.Point(136, 558);
            this.lblProfSteps.Name = "lblProfSteps";
            this.lblProfSteps.Size = new System.Drawing.Size(40, 13);
            this.lblProfSteps.TabIndex = 17;
            this.lblProfSteps.Text = "Steps.:";
            // 
            // threadBuscaEmLarguraH1
            // 
            this.threadBuscaEmLarguraH1.WorkerSupportsCancellation = true;
            this.threadBuscaEmLarguraH1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.threadBuscaEmLarguraH1_DoWork);
            this.threadBuscaEmLarguraH1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.threadBuscaEmLarguraH1_RunWorkerCompleted);
            // 
            // threadBuscaEmProfundidadeH1
            // 
            this.threadBuscaEmProfundidadeH1.WorkerSupportsCancellation = true;
            this.threadBuscaEmProfundidadeH1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.threadBuscaEmProfundidadeH1_DoWork);
            this.threadBuscaEmProfundidadeH1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.threadBuscaEmProfundidadeH1_RunWorkerCompleted);
            // 
            // lblLargStepsH1
            // 
            this.lblLargStepsH1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblLargStepsH1.AutoSize = true;
            this.lblLargStepsH1.Location = new System.Drawing.Point(298, 558);
            this.lblLargStepsH1.Name = "lblLargStepsH1";
            this.lblLargStepsH1.Size = new System.Drawing.Size(40, 13);
            this.lblLargStepsH1.TabIndex = 22;
            this.lblLargStepsH1.Text = "Steps.:";
            // 
            // lblLargExpH1
            // 
            this.lblLargExpH1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblLargExpH1.AutoSize = true;
            this.lblLargExpH1.Location = new System.Drawing.Point(298, 534);
            this.lblLargExpH1.Name = "lblLargExpH1";
            this.lblLargExpH1.Size = new System.Drawing.Size(43, 13);
            this.lblLargExpH1.TabIndex = 21;
            this.lblLargExpH1.Text = "Abertos";
            // 
            // lblLargH1
            // 
            this.lblLargH1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblLargH1.AutoSize = true;
            this.lblLargH1.Location = new System.Drawing.Point(299, 512);
            this.lblLargH1.Name = "lblLargH1";
            this.lblLargH1.Size = new System.Drawing.Size(49, 13);
            this.lblLargH1.TabIndex = 20;
            this.lblLargH1.Text = "00:00:00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(299, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 15);
            this.label6.TabIndex = 19;
            this.label6.Text = "Busca em Largura H1";
            // 
            // ltbCaminhoLaguraH1
            // 
            this.ltbCaminhoLaguraH1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ltbCaminhoLaguraH1.FormattingEnabled = true;
            this.ltbCaminhoLaguraH1.Location = new System.Drawing.Point(302, 245);
            this.ltbCaminhoLaguraH1.Name = "ltbCaminhoLaguraH1";
            this.ltbCaminhoLaguraH1.Size = new System.Drawing.Size(143, 264);
            this.ltbCaminhoLaguraH1.TabIndex = 18;
            // 
            // lblProfStepsH1
            // 
            this.lblProfStepsH1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblProfStepsH1.AutoSize = true;
            this.lblProfStepsH1.Location = new System.Drawing.Point(448, 558);
            this.lblProfStepsH1.Name = "lblProfStepsH1";
            this.lblProfStepsH1.Size = new System.Drawing.Size(40, 13);
            this.lblProfStepsH1.TabIndex = 27;
            this.lblProfStepsH1.Text = "Steps.:";
            // 
            // lblProfExpH1
            // 
            this.lblProfExpH1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblProfExpH1.AutoSize = true;
            this.lblProfExpH1.Location = new System.Drawing.Point(448, 534);
            this.lblProfExpH1.Name = "lblProfExpH1";
            this.lblProfExpH1.Size = new System.Drawing.Size(43, 13);
            this.lblProfExpH1.TabIndex = 26;
            this.lblProfExpH1.Text = "Abertos";
            // 
            // lblProfH1
            // 
            this.lblProfH1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblProfH1.AutoSize = true;
            this.lblProfH1.Location = new System.Drawing.Point(448, 512);
            this.lblProfH1.Name = "lblProfH1";
            this.lblProfH1.Size = new System.Drawing.Size(49, 13);
            this.lblProfH1.TabIndex = 25;
            this.lblProfH1.Text = "00:00:00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(448, 227);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(166, 15);
            this.label7.TabIndex = 24;
            this.label7.Text = "Busca Profundidade (20)";
            // 
            // ltbCaminhoProfundidade
            // 
            this.ltbCaminhoProfundidade.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ltbCaminhoProfundidade.FormattingEnabled = true;
            this.ltbCaminhoProfundidade.Location = new System.Drawing.Point(451, 245);
            this.ltbCaminhoProfundidade.Name = "ltbCaminhoProfundidade";
            this.ltbCaminhoProfundidade.Size = new System.Drawing.Size(157, 264);
            this.ltbCaminhoProfundidade.TabIndex = 23;
            // 
            // dgvAnimar
            // 
            this.dgvAnimar.AllowUserToAddRows = false;
            this.dgvAnimar.AllowUserToDeleteRows = false;
            this.dgvAnimar.BackgroundColor = System.Drawing.Color.White;
            this.dgvAnimar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAnimar.ColumnHeadersVisible = false;
            this.dgvAnimar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col0,
            this.col1,
            this.col2});
            this.dgvAnimar.Location = new System.Drawing.Point(471, 12);
            this.dgvAnimar.Name = "dgvAnimar";
            this.dgvAnimar.ReadOnly = true;
            this.dgvAnimar.RowHeadersVisible = false;
            this.dgvAnimar.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvAnimar.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvAnimar.RowTemplate.Height = 40;
            this.dgvAnimar.Size = new System.Drawing.Size(160, 130);
            this.dgvAnimar.TabIndex = 28;
            // 
            // col0
            // 
            this.col0.HeaderText = "col0";
            this.col0.Name = "col0";
            this.col0.ReadOnly = true;
            this.col0.Width = 50;
            // 
            // col1
            // 
            this.col1.HeaderText = "col1";
            this.col1.Name = "col1";
            this.col1.ReadOnly = true;
            this.col1.Width = 50;
            // 
            // col2
            // 
            this.col2.HeaderText = "col2";
            this.col2.Name = "col2";
            this.col2.ReadOnly = true;
            this.col2.Width = 50;
            // 
            // btAnimarLarg
            // 
            this.btAnimarLarg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btAnimarLarg.Location = new System.Drawing.Point(11, 577);
            this.btAnimarLarg.Name = "btAnimarLarg";
            this.btAnimarLarg.Size = new System.Drawing.Size(75, 23);
            this.btAnimarLarg.TabIndex = 29;
            this.btAnimarLarg.Text = "Simular";
            this.btAnimarLarg.UseVisualStyleBackColor = true;
            this.btAnimarLarg.Click += new System.EventHandler(this.btAnimarLarg_Click);
            // 
            // btAnimarProfInter
            // 
            this.btAnimarProfInter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btAnimarProfInter.Location = new System.Drawing.Point(139, 577);
            this.btAnimarProfInter.Name = "btAnimarProfInter";
            this.btAnimarProfInter.Size = new System.Drawing.Size(75, 23);
            this.btAnimarProfInter.TabIndex = 30;
            this.btAnimarProfInter.Text = "Simular";
            this.btAnimarProfInter.UseVisualStyleBackColor = true;
            this.btAnimarProfInter.Click += new System.EventHandler(this.btAnimarProfInter_Click);
            // 
            // btAnimarProf
            // 
            this.btAnimarProf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btAnimarProf.Location = new System.Drawing.Point(451, 577);
            this.btAnimarProf.Name = "btAnimarProf";
            this.btAnimarProf.Size = new System.Drawing.Size(75, 23);
            this.btAnimarProf.TabIndex = 32;
            this.btAnimarProf.Text = "Simular";
            this.btAnimarProf.UseVisualStyleBackColor = true;
            this.btAnimarProf.Click += new System.EventHandler(this.btAnimarProf_Click);
            // 
            // btAnimarLargH1
            // 
            this.btAnimarLargH1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btAnimarLargH1.Location = new System.Drawing.Point(301, 577);
            this.btAnimarLargH1.Name = "btAnimarLargH1";
            this.btAnimarLargH1.Size = new System.Drawing.Size(75, 23);
            this.btAnimarLargH1.TabIndex = 31;
            this.btAnimarLargH1.Text = "Simular";
            this.btAnimarLargH1.UseVisualStyleBackColor = true;
            this.btAnimarLargH1.Click += new System.EventHandler(this.btAnimarLargH1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(159, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(306, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Digite a sequencia nesta caixa ou sorteie uma nova sequencia:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 612);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btAnimarProf);
            this.Controls.Add(this.btAnimarLargH1);
            this.Controls.Add(this.btAnimarProfInter);
            this.Controls.Add(this.btAnimarLarg);
            this.Controls.Add(this.dgvAnimar);
            this.Controls.Add(this.lblProfStepsH1);
            this.Controls.Add(this.lblProfExpH1);
            this.Controls.Add(this.lblProfH1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ltbCaminhoProfundidade);
            this.Controls.Add(this.lblLargStepsH1);
            this.Controls.Add(this.lblLargExpH1);
            this.Controls.Add(this.lblLargH1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ltbCaminhoLaguraH1);
            this.Controls.Add(this.lblProfSteps);
            this.Controls.Add(this.lblLargSteps);
            this.Controls.Add(this.lblProfExp);
            this.Controls.Add(this.lblLargExp);
            this.Controls.Add(this.txtCadeiaProblema);
            this.Controls.Add(this.btStop);
            this.Controls.Add(this.ckbAndamento);
            this.Controls.Add(this.lblProf);
            this.Controls.Add(this.lblLarg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ltbCaminhoProfundidadeIter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.ltbCaminhoLagura);
            this.Controls.Add(this.btRunThreads);
            this.Controls.Add(this.btSortear);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Jogo do 8 - IA";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnimar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bt00;
        private System.Windows.Forms.Button bt08;
        private System.Windows.Forms.Button bt07;
        private System.Windows.Forms.Button bt06;
        private System.Windows.Forms.Button bt05;
        private System.Windows.Forms.Button bt04;
        private System.Windows.Forms.Button bt03;
        private System.Windows.Forms.Button bt02;
        private System.Windows.Forms.Button bt01;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btSortear;
        private System.Windows.Forms.Button btRunThreads;
        private System.Windows.Forms.ListBox ltbCaminhoLagura;
        private System.ComponentModel.BackgroundWorker threadBuscaEmLargura;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblTime;
        private System.ComponentModel.BackgroundWorker threadBuscaEmProfundidade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox ltbCaminhoProfundidadeIter;
        private System.Windows.Forms.Label lblLarg;
        private System.Windows.Forms.Label lblProf;
        private System.Windows.Forms.CheckBox ckbAndamento;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btStop;
        private System.Windows.Forms.TextBox txtCadeiaProblema;
        private System.Windows.Forms.Label lblLargExp;
        private System.Windows.Forms.Label lblProfExp;
        private System.Windows.Forms.Label lblLargSteps;
        private System.Windows.Forms.Label lblProfSteps;
        private System.ComponentModel.BackgroundWorker threadBuscaEmLarguraH1;
        private System.ComponentModel.BackgroundWorker threadBuscaEmProfundidadeH1;
        private System.Windows.Forms.Label lblLargStepsH1;
        private System.Windows.Forms.Label lblLargExpH1;
        private System.Windows.Forms.Label lblLargH1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox ltbCaminhoLaguraH1;
        private System.Windows.Forms.Label lblProfStepsH1;
        private System.Windows.Forms.Label lblProfExpH1;
        private System.Windows.Forms.Label lblProfH1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox ltbCaminhoProfundidade;
        private System.Windows.Forms.DataGridView dgvAnimar;
        private System.Windows.Forms.DataGridViewTextBoxColumn col0;
        private System.Windows.Forms.DataGridViewTextBoxColumn col1;
        private System.Windows.Forms.DataGridViewTextBoxColumn col2;
        private System.Windows.Forms.Button btAnimarLarg;
        private System.Windows.Forms.Button btAnimarProfInter;
        private System.Windows.Forms.Button btAnimarProf;
        private System.Windows.Forms.Button btAnimarLargH1;
        private System.Windows.Forms.Label label3;
    }
}

