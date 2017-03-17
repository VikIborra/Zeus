﻿using System.Drawing;
using Zeus.Core;

namespace Zeus
{
    partial class formPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formPrincipal));
            this.ddlTabelas = new System.Windows.Forms.ComboBox();
            this.btnEntidade = new System.Windows.Forms.Button();
            this.btnChamadaProc = new System.Windows.Forms.Button();
            this.btnProc = new System.Windows.Forms.Button();
            this.radioCsharp = new System.Windows.Forms.RadioButton();
            this.radioJava = new System.Windows.Forms.RadioButton();
            this.radioNode = new System.Windows.Forms.RadioButton();
            this.radioSGBD3 = new System.Windows.Forms.RadioButton();
            this.radioSGBD2 = new System.Windows.Forms.RadioButton();
            this.radioSGBD1 = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSequence = new System.Windows.Forms.Button();
            this.btnBatch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnChkTabela = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnExemplo = new System.Windows.Forms.Button();
            this.btnConnection = new System.Windows.Forms.Button();
            this.txtConnectionString = new System.Windows.Forms.TextBox();
            this.salvar = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.progressBar1 = new Zeus.Core.NewProgressBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.ddlDatabase = new System.Windows.Forms.ComboBox();
            this.txtPreFixoProcedures = new System.Windows.Forms.TextBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.txtPrefixoTabela = new System.Windows.Forms.TextBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.txtPreFixoPackages = new System.Windows.Forms.TextBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.ddlUnificar = new System.Windows.Forms.ComboBox();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnConfiguracoes = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ddlTabelas
            // 
            this.ddlTabelas.FormattingEnabled = true;
            this.ddlTabelas.Location = new System.Drawing.Point(11, 17);
            this.ddlTabelas.Name = "ddlTabelas";
            this.ddlTabelas.Size = new System.Drawing.Size(356, 24);
            this.ddlTabelas.TabIndex = 0;
            this.ddlTabelas.SelectedIndexChanged += new System.EventHandler(this.EventSetParamters);
            // 
            // btnEntidade
            // 
            this.btnEntidade.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEntidade.Location = new System.Drawing.Point(6, 15);
            this.btnEntidade.Name = "btnEntidade";
            this.btnEntidade.Size = new System.Drawing.Size(89, 30);
            this.btnEntidade.TabIndex = 1;
            this.btnEntidade.Text = "Entidade";
            this.btnEntidade.UseVisualStyleBackColor = true;
            this.btnEntidade.Click += new System.EventHandler(this.btnEntidade_Click);
            // 
            // btnChamadaProc
            // 
            this.btnChamadaProc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnChamadaProc.Location = new System.Drawing.Point(101, 15);
            this.btnChamadaProc.Name = "btnChamadaProc";
            this.btnChamadaProc.Size = new System.Drawing.Size(156, 30);
            this.btnChamadaProc.TabIndex = 4;
            this.btnChamadaProc.Text = "Acesso Banco de Dados";
            this.btnChamadaProc.UseVisualStyleBackColor = true;
            this.btnChamadaProc.Click += new System.EventHandler(this.btnChamadaProc_Click);
            // 
            // btnProc
            // 
            this.btnProc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnProc.Location = new System.Drawing.Point(263, 15);
            this.btnProc.Name = "btnProc";
            this.btnProc.Size = new System.Drawing.Size(95, 30);
            this.btnProc.TabIndex = 5;
            this.btnProc.Text = "Procedure";
            this.btnProc.UseVisualStyleBackColor = true;
            this.btnProc.Click += new System.EventHandler(this.btnProcSql_Click);
            // 
            // radioCsharp
            // 
            this.radioCsharp.AutoSize = true;
            this.radioCsharp.Checked = true;
            this.radioCsharp.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.radioCsharp.Location = new System.Drawing.Point(6, 19);
            this.radioCsharp.Name = "radioCsharp";
            this.radioCsharp.Size = new System.Drawing.Size(43, 20);
            this.radioCsharp.TabIndex = 7;
            this.radioCsharp.TabStop = true;
            this.radioCsharp.Text = "C #";
            this.radioCsharp.UseVisualStyleBackColor = true;
            this.radioCsharp.CheckedChanged += new System.EventHandler(this.EventSetParamters);
            // 
            // radioJava
            // 
            this.radioJava.AutoSize = true;
            this.radioJava.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.radioJava.Location = new System.Drawing.Point(6, 42);
            this.radioJava.Name = "radioJava";
            this.radioJava.Size = new System.Drawing.Size(48, 20);
            this.radioJava.TabIndex = 8;
            this.radioJava.TabStop = true;
            this.radioJava.Text = "Java";
            this.radioJava.UseVisualStyleBackColor = true;
            this.radioJava.CheckedChanged += new System.EventHandler(this.EventSetParamters);
            // 
            // radioNode
            // 
            this.radioNode.AutoSize = true;
            this.radioNode.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.radioNode.Location = new System.Drawing.Point(6, 71);
            this.radioNode.Name = "radioNode";
            this.radioNode.Size = new System.Drawing.Size(68, 20);
            this.radioNode.TabIndex = 9;
            this.radioNode.TabStop = true;
            this.radioNode.Text = "Node JS";
            this.radioNode.UseVisualStyleBackColor = true;
            this.radioNode.CheckedChanged += new System.EventHandler(this.EventSetParamters);
            // 
            // radioSGBD3
            // 
            this.radioSGBD3.AutoSize = true;
            this.radioSGBD3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.radioSGBD3.Location = new System.Drawing.Point(7, 66);
            this.radioSGBD3.Name = "radioSGBD3";
            this.radioSGBD3.Size = new System.Drawing.Size(58, 20);
            this.radioSGBD3.TabIndex = 2;
            this.radioSGBD3.TabStop = true;
            this.radioSGBD3.Text = "MySql";
            this.radioSGBD3.UseVisualStyleBackColor = true;
            this.radioSGBD3.CheckedChanged += new System.EventHandler(this.CleanParamters);
            // 
            // radioSGBD2
            // 
            this.radioSGBD2.AutoSize = true;
            this.radioSGBD2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.radioSGBD2.Location = new System.Drawing.Point(7, 43);
            this.radioSGBD2.Name = "radioSGBD2";
            this.radioSGBD2.Size = new System.Drawing.Size(103, 20);
            this.radioSGBD2.TabIndex = 1;
            this.radioSGBD2.TabStop = true;
            this.radioSGBD2.Text = "Microsoft SQL";
            this.radioSGBD2.UseVisualStyleBackColor = true;
            this.radioSGBD2.CheckedChanged += new System.EventHandler(this.CleanParamters);
            // 
            // radioSGBD1
            // 
            this.radioSGBD1.AutoSize = true;
            this.radioSGBD1.Checked = true;
            this.radioSGBD1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.radioSGBD1.Location = new System.Drawing.Point(7, 20);
            this.radioSGBD1.Name = "radioSGBD1";
            this.radioSGBD1.Size = new System.Drawing.Size(62, 20);
            this.radioSGBD1.TabIndex = 0;
            this.radioSGBD1.TabStop = true;
            this.radioSGBD1.Text = "Oracle";
            this.radioSGBD1.UseVisualStyleBackColor = true;
            this.radioSGBD1.CheckedChanged += new System.EventHandler(this.CleanParamters);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSequence);
            this.groupBox3.Controls.Add(this.btnEntidade);
            this.groupBox3.Controls.Add(this.btnChamadaProc);
            this.groupBox3.Controls.Add(this.btnProc);
            this.groupBox3.Font = new System.Drawing.Font("Gill Sans MT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.groupBox3.Location = new System.Drawing.Point(469, 147);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(471, 56);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "10 - Gerar";
            // 
            // btnSequence
            // 
            this.btnSequence.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSequence.Location = new System.Drawing.Point(364, 15);
            this.btnSequence.Name = "btnSequence";
            this.btnSequence.Size = new System.Drawing.Size(101, 30);
            this.btnSequence.TabIndex = 17;
            this.btnSequence.Text = "Sequence";
            this.btnSequence.UseVisualStyleBackColor = true;
            this.btnSequence.Click += new System.EventHandler(this.btnSequence_Click);
            // 
            // btnBatch
            // 
            this.btnBatch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBatch.Location = new System.Drawing.Point(11, 19);
            this.btnBatch.Name = "btnBatch";
            this.btnBatch.Size = new System.Drawing.Size(100, 23);
            this.btnBatch.TabIndex = 18;
            this.btnBatch.Text = "Batch Execute";
            this.btnBatch.UseVisualStyleBackColor = true;
            this.btnBatch.Click += new System.EventHandler(this.btnBatch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(382, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 18);
            this.label1.TabIndex = 14;
            this.label1.Text = "ZEUS 0.7";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnChkTabela);
            this.groupBox4.Controls.Add(this.ddlTabelas);
            this.groupBox4.Font = new System.Drawing.Font("Gill Sans MT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.groupBox4.Location = new System.Drawing.Point(21, 147);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(448, 56);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "9 - Tabela";
            // 
            // btnChkTabela
            // 
            this.btnChkTabela.AutoSize = true;
            this.btnChkTabela.ForeColor = System.Drawing.Color.White;
            this.btnChkTabela.Location = new System.Drawing.Point(374, 19);
            this.btnChkTabela.Name = "btnChkTabela";
            this.btnChkTabela.Size = new System.Drawing.Size(59, 20);
            this.btnChkTabela.TabIndex = 1;
            this.btnChkTabela.Text = "Todas";
            this.btnChkTabela.UseVisualStyleBackColor = true;
            this.btnChkTabela.CheckedChanged += new System.EventHandler(this.btnChkTabela_CheckedChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnExemplo);
            this.groupBox5.Controls.Add(this.btnConnection);
            this.groupBox5.Controls.Add(this.txtConnectionString);
            this.groupBox5.Font = new System.Drawing.Font("Gill Sans MT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.groupBox5.Location = new System.Drawing.Point(240, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(511, 66);
            this.groupBox5.TabIndex = 13;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "3 - Connection String";
            // 
            // btnExemplo
            // 
            this.btnExemplo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnExemplo.Location = new System.Drawing.Point(481, 19);
            this.btnExemplo.Name = "btnExemplo";
            this.btnExemplo.Size = new System.Drawing.Size(21, 29);
            this.btnExemplo.TabIndex = 2;
            this.btnExemplo.Text = "?";
            this.btnExemplo.UseVisualStyleBackColor = true;
            this.btnExemplo.Click += new System.EventHandler(this.btnExemplo_Click);
            // 
            // btnConnection
            // 
            this.btnConnection.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnConnection.Location = new System.Drawing.Point(402, 19);
            this.btnConnection.Name = "btnConnection";
            this.btnConnection.Size = new System.Drawing.Size(75, 29);
            this.btnConnection.TabIndex = 1;
            this.btnConnection.Text = "Conectar";
            this.btnConnection.UseVisualStyleBackColor = true;
            this.btnConnection.Click += new System.EventHandler(this.btnConnection_Click);
            // 
            // txtConnectionString
            // 
            this.txtConnectionString.Location = new System.Drawing.Point(9, 24);
            this.txtConnectionString.Name = "txtConnectionString";
            this.txtConnectionString.Size = new System.Drawing.Size(387, 20);
            this.txtConnectionString.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.lblStatus);
            this.groupBox6.Controls.Add(this.progressBar1);
            this.groupBox6.Font = new System.Drawing.Font("Gill Sans MT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.groupBox6.Location = new System.Drawing.Point(21, 209);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(448, 55);
            this.groupBox6.TabIndex = 11;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Status";
            // 
            // lblStatus
            // 
            this.lblStatus.ForeColor = System.Drawing.Color.Snow;
            this.lblStatus.Location = new System.Drawing.Point(6, 19);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(430, 18);
            this.lblStatus.TabIndex = 15;
            this.lblStatus.Text = "Aguardando Instruções";
            // 
            // progressBar1
            // 
            this.progressBar1.ForeColor = System.Drawing.Color.Maroon;
            this.progressBar1.Location = new System.Drawing.Point(6, 35);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(430, 10);
            this.progressBar1.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioNode);
            this.groupBox1.Controls.Add(this.radioCsharp);
            this.groupBox1.Controls.Add(this.radioJava);
            this.groupBox1.Font = new System.Drawing.Font("Gill Sans MT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.groupBox1.Location = new System.Drawing.Point(21, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(111, 131);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "1 - Linguagem";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioSGBD3);
            this.groupBox2.Controls.Add(this.radioSGBD2);
            this.groupBox2.Controls.Add(this.radioSGBD1);
            this.groupBox2.Font = new System.Drawing.Font("Gill Sans MT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.groupBox2.Location = new System.Drawing.Point(131, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(110, 131);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "2 - SGBD";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.ddlDatabase);
            this.groupBox7.Font = new System.Drawing.Font("Gill Sans MT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.groupBox7.Location = new System.Drawing.Point(751, 12);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(189, 66);
            this.groupBox7.TabIndex = 14;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "4 - Schema";
            // 
            // ddlDatabase
            // 
            this.ddlDatabase.Enabled = false;
            this.ddlDatabase.FormattingEnabled = true;
            this.ddlDatabase.Location = new System.Drawing.Point(6, 20);
            this.ddlDatabase.Name = "ddlDatabase";
            this.ddlDatabase.Size = new System.Drawing.Size(177, 24);
            this.ddlDatabase.TabIndex = 1;
            this.ddlDatabase.SelectedIndexChanged += new System.EventHandler(this.ddlDatabase_SelectedIndexChanged);
            // 
            // txtPreFixoProcedures
            // 
            this.txtPreFixoProcedures.Location = new System.Drawing.Point(9, 19);
            this.txtPreFixoProcedures.Name = "txtPreFixoProcedures";
            this.txtPreFixoProcedures.Size = new System.Drawing.Size(150, 20);
            this.txtPreFixoProcedures.TabIndex = 0;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.txtPreFixoProcedures);
            this.groupBox8.Font = new System.Drawing.Font("Gill Sans MT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.groupBox8.Location = new System.Drawing.Point(240, 78);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(175, 65);
            this.groupBox8.TabIndex = 0;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "5 - Pré-Fixo Procedures";
            // 
            // txtPrefixoTabela
            // 
            this.txtPrefixoTabela.Location = new System.Drawing.Point(6, 19);
            this.txtPrefixoTabela.Name = "txtPrefixoTabela";
            this.txtPrefixoTabela.Size = new System.Drawing.Size(159, 20);
            this.txtPrefixoTabela.TabIndex = 0;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.txtPrefixoTabela);
            this.groupBox9.Font = new System.Drawing.Font("Gill Sans MT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.groupBox9.Location = new System.Drawing.Point(415, 78);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(182, 65);
            this.groupBox9.TabIndex = 1;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "6 - Pré-Fixo Tabelas";
            // 
            // txtPreFixoPackages
            // 
            this.txtPreFixoPackages.Location = new System.Drawing.Point(6, 19);
            this.txtPreFixoPackages.Name = "txtPreFixoPackages";
            this.txtPreFixoPackages.Size = new System.Drawing.Size(188, 20);
            this.txtPreFixoPackages.TabIndex = 0;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.txtPreFixoPackages);
            this.groupBox10.Font = new System.Drawing.Font("Gill Sans MT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.groupBox10.Location = new System.Drawing.Point(597, 78);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(200, 65);
            this.groupBox10.TabIndex = 2;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "7- Pré-Fixo Packages";
            // 
            // ddlUnificar
            // 
            this.ddlUnificar.FormattingEnabled = true;
            this.ddlUnificar.Items.AddRange(new object[] {
            "SIM",
            "NÃO"});
            this.ddlUnificar.Location = new System.Drawing.Point(6, 22);
            this.ddlUnificar.Name = "ddlUnificar";
            this.ddlUnificar.Size = new System.Drawing.Size(124, 24);
            this.ddlUnificar.TabIndex = 0;
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.ddlUnificar);
            this.groupBox11.Font = new System.Drawing.Font("Gill Sans MT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.groupBox11.Location = new System.Drawing.Point(797, 78);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(143, 65);
            this.groupBox11.TabIndex = 3;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "8 - Unificar Output";
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.button1);
            this.groupBox12.Controls.Add(this.btnConfiguracoes);
            this.groupBox12.Controls.Add(this.btnBatch);
            this.groupBox12.Controls.Add(this.label1);
            this.groupBox12.Font = new System.Drawing.Font("Gill Sans MT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.groupBox12.Location = new System.Drawing.Point(469, 209);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(471, 55);
            this.groupBox12.TabIndex = 18;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "11 - Extras";
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(252, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "Classes Necessárias";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnConfiguracoes
            // 
            this.btnConfiguracoes.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnConfiguracoes.Location = new System.Drawing.Point(117, 19);
            this.btnConfiguracoes.Name = "btnConfiguracoes";
            this.btnConfiguracoes.Size = new System.Drawing.Size(131, 23);
            this.btnConfiguracoes.TabIndex = 19;
            this.btnConfiguracoes.Text = "Salvar Configurações";
            this.btnConfiguracoes.UseVisualStyleBackColor = true;
            this.btnConfiguracoes.Click += new System.EventHandler(this.btnConfiguracoes_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(957, 281);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // formPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(956, 279);
            this.Controls.Add(this.groupBox12);
            this.Controls.Add(this.groupBox11);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.groupBox10);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "formPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zeus - 0.7";
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox ddlTabelas;
        private System.Windows.Forms.Button btnEntidade;
        private System.Windows.Forms.Button btnChamadaProc;
        private System.Windows.Forms.Button btnProc;
        private System.Windows.Forms.RadioButton radioCsharp;
        private System.Windows.Forms.RadioButton radioJava;
        private System.Windows.Forms.RadioButton radioSGBD1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtConnectionString;
        private System.Windows.Forms.Button btnConnection;
        private System.Windows.Forms.CheckBox btnChkTabela;
        private System.Windows.Forms.FolderBrowserDialog salvar;
        private System.Windows.Forms.Button btnExemplo;
        private System.Windows.Forms.RadioButton radioSGBD2;
        private System.Windows.Forms.RadioButton radioSGBD3;
        private NewProgressBar progressBar1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioNode;
        private System.Windows.Forms.Button btnSequence;
        private System.Windows.Forms.Button btnBatch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.ComboBox ddlDatabase;
        private System.Windows.Forms.TextBox txtPreFixoProcedures;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TextBox txtPrefixoTabela;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.TextBox txtPreFixoPackages;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.ComboBox ddlUnificar;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.Button btnConfiguracoes;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

