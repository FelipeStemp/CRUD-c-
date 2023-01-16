namespace marcenariaproject
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.consulta = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.gridPrincipal = new System.Windows.Forms.DataGridView();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtNF = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtEntrada = new System.Windows.Forms.TextBox();
            this.txtDespesas = new System.Windows.Forms.TextBox();
            this.cbParcelas = new System.Windows.Forms.ComboBox();
            this.cbPagas = new System.Windows.Forms.ComboBox();
            this.dataUP = new System.Windows.Forms.DateTimePicker();
            this.update = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.excel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridPrincipal)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(131, 115);
            this.button1.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(311, 118);
            this.button1.TabIndex = 0;
            this.button1.Text = "Adicionar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(2902, 79);
            this.button2.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(262, 82);
            this.button2.TabIndex = 1;
            this.button2.Text = "Buscar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // consulta
            // 
            this.consulta.Location = new System.Drawing.Point(2266, 93);
            this.consulta.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.consulta.Name = "consulta";
            this.consulta.Size = new System.Drawing.Size(560, 47);
            this.consulta.TabIndex = 2;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(828, 115);
            this.button3.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(311, 118);
            this.button3.TabIndex = 4;
            this.button3.Text = "Carregar tabela";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // gridPrincipal
            // 
            this.gridPrincipal.AllowUserToAddRows = false;
            this.gridPrincipal.AllowUserToDeleteRows = false;
            this.gridPrincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPrincipal.Location = new System.Drawing.Point(56, 309);
            this.gridPrincipal.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gridPrincipal.Name = "gridPrincipal";
            this.gridPrincipal.ReadOnly = true;
            this.gridPrincipal.RowHeadersWidth = 102;
            this.gridPrincipal.RowTemplate.Height = 49;
            this.gridPrincipal.Size = new System.Drawing.Size(2059, 1197);
            this.gridPrincipal.TabIndex = 5;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(2523, 208);
            this.txtNome.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(584, 47);
            this.txtNome.TabIndex = 6;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(2523, 292);
            this.txtTel.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(584, 47);
            this.txtTel.TabIndex = 7;
            // 
            // txtNF
            // 
            this.txtNF.Location = new System.Drawing.Point(2523, 378);
            this.txtNF.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.txtNF.Name = "txtNF";
            this.txtNF.Size = new System.Drawing.Size(584, 47);
            this.txtNF.TabIndex = 8;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(2523, 467);
            this.txtValor.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(584, 47);
            this.txtValor.TabIndex = 9;
            // 
            // txtEntrada
            // 
            this.txtEntrada.Location = new System.Drawing.Point(2523, 558);
            this.txtEntrada.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.txtEntrada.Name = "txtEntrada";
            this.txtEntrada.Size = new System.Drawing.Size(584, 47);
            this.txtEntrada.TabIndex = 10;
            // 
            // txtDespesas
            // 
            this.txtDespesas.Location = new System.Drawing.Point(2523, 647);
            this.txtDespesas.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.txtDespesas.Name = "txtDespesas";
            this.txtDespesas.Size = new System.Drawing.Size(584, 47);
            this.txtDespesas.TabIndex = 11;
            // 
            // cbParcelas
            // 
            this.cbParcelas.FormattingEnabled = true;
            this.cbParcelas.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbParcelas.Location = new System.Drawing.Point(2523, 731);
            this.cbParcelas.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbParcelas.Name = "cbParcelas";
            this.cbParcelas.Size = new System.Drawing.Size(303, 49);
            this.cbParcelas.TabIndex = 12;
            // 
            // cbPagas
            // 
            this.cbPagas.FormattingEnabled = true;
            this.cbPagas.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbPagas.Location = new System.Drawing.Point(2523, 809);
            this.cbPagas.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbPagas.Name = "cbPagas";
            this.cbPagas.Size = new System.Drawing.Size(303, 49);
            this.cbPagas.TabIndex = 13;
            // 
            // dataUP
            // 
            this.dataUP.Location = new System.Drawing.Point(2523, 891);
            this.dataUP.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dataUP.Name = "dataUP";
            this.dataUP.Size = new System.Drawing.Size(584, 47);
            this.dataUP.TabIndex = 14;
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(2523, 1407);
            this.update.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(423, 84);
            this.update.TabIndex = 15;
            this.update.Text = "Alterar";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2284, 214);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 41);
            this.label1.TabIndex = 17;
            this.label1.Text = "Nome";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2284, 298);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 41);
            this.label2.TabIndex = 18;
            this.label2.Text = "Telefone";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2284, 384);
            this.label3.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 41);
            this.label3.TabIndex = 19;
            this.label3.Text = "NF";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2284, 473);
            this.label4.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 41);
            this.label4.TabIndex = 20;
            this.label4.Text = "Valor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2284, 564);
            this.label5.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 41);
            this.label5.TabIndex = 21;
            this.label5.Text = "Entrada";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2284, 653);
            this.label6.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 41);
            this.label6.TabIndex = 22;
            this.label6.Text = "Despesas";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(2284, 739);
            this.label7.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 41);
            this.label7.TabIndex = 23;
            this.label7.Text = "Parcelas";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(2284, 812);
            this.label8.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(211, 41);
            this.label8.TabIndex = 24;
            this.label8.Text = "Parcelas pagas";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(2284, 891);
            this.label9.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 41);
            this.label9.TabIndex = 25;
            this.label9.Text = "Data";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(2266, 44);
            this.label10.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(234, 41);
            this.label10.TabIndex = 26;
            this.label10.Text = "Pesquisar por ID";
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(2266, 980);
            this.txtDesc.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(980, 403);
            this.txtDesc.TabIndex = 27;
            // 
            // excel
            // 
            this.excel.Location = new System.Drawing.Point(1534, 115);
            this.excel.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.excel.Name = "excel";
            this.excel.Size = new System.Drawing.Size(311, 118);
            this.excel.TabIndex = 28;
            this.excel.Text = "Exportar EXCEL";
            this.excel.UseVisualStyleBackColor = true;
            this.excel.Click += new System.EventHandler(this.excel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(3305, 1503);
            this.Controls.Add(this.excel);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.update);
            this.Controls.Add(this.dataUP);
            this.Controls.Add(this.cbPagas);
            this.Controls.Add(this.cbParcelas);
            this.Controls.Add(this.txtDespesas);
            this.Controls.Add(this.txtEntrada);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtNF);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.gridPrincipal);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.consulta);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridPrincipal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Button button2;
        private TextBox consulta;
        private Button button3;
        private DataGridView gridPrincipal;
        private TextBox txtNome;
        private TextBox txtTel;
        private TextBox txtNF;
        private TextBox txtValor;
        private TextBox txtEntrada;
        private TextBox txtDespesas;
        private ComboBox cbParcelas;
        private ComboBox cbPagas;
        private DateTimePicker dataUP;
        private Button update;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox txtDesc;
        private Button excel;
    }
}