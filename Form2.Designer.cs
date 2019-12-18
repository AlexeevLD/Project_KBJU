namespace KBJU
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.tb_menu = new System.Windows.Forms.TextBox();
            this.dgv_bludo = new System.Windows.Forms.DataGridView();
            this.id_bludo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name_bludo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_zav = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_obed = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_yzhin = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Pn = new System.Windows.Forms.Button();
            this.btn_Vt = new System.Windows.Forms.Button();
            this.btn_Sr = new System.Windows.Forms.Button();
            this.btn_Ct = new System.Windows.Forms.Button();
            this.btn_Pt = new System.Windows.Forms.Button();
            this.btn_Sb = new System.Windows.Forms.Button();
            this.btn_Vs = new System.Windows.Forms.Button();
            this.btn_Print = new System.Windows.Forms.Button();
            this.rbt_zav = new System.Windows.Forms.RadioButton();
            this.rbt_obed = new System.Windows.Forms.RadioButton();
            this.rbt_yzhin = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.report1 = new FastReport.Report();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bludo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_zav)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_obed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_yzhin)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.report1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название меню:";
            // 
            // tb_menu
            // 
            this.tb_menu.Location = new System.Drawing.Point(109, 11);
            this.tb_menu.Name = "tb_menu";
            this.tb_menu.Size = new System.Drawing.Size(257, 20);
            this.tb_menu.TabIndex = 1;
            // 
            // dgv_bludo
            // 
            this.dgv_bludo.AllowUserToAddRows = false;
            this.dgv_bludo.AllowUserToDeleteRows = false;
            this.dgv_bludo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgv_bludo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_bludo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_bludo,
            this.name_bludo});
            this.dgv_bludo.Location = new System.Drawing.Point(12, 61);
            this.dgv_bludo.MultiSelect = false;
            this.dgv_bludo.Name = "dgv_bludo";
            this.dgv_bludo.ReadOnly = true;
            this.dgv_bludo.RowHeadersVisible = false;
            this.dgv_bludo.Size = new System.Drawing.Size(354, 469);
            this.dgv_bludo.TabIndex = 2;
            this.dgv_bludo.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_bludo_CellDoubleClick);
            // 
            // id_bludo
            // 
            this.id_bludo.DataPropertyName = "id_bludo";
            this.id_bludo.HeaderText = "id_bludo";
            this.id_bludo.Name = "id_bludo";
            this.id_bludo.ReadOnly = true;
            this.id_bludo.Visible = false;
            // 
            // name_bludo
            // 
            this.name_bludo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name_bludo.DataPropertyName = "name_bludo";
            this.name_bludo.HeaderText = "Название блюда";
            this.name_bludo.MinimumWidth = 200;
            this.name_bludo.Name = "name_bludo";
            this.name_bludo.ReadOnly = true;
            // 
            // dgv_zav
            // 
            this.dgv_zav.AllowUserToAddRows = false;
            this.dgv_zav.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_zav.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_zav.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dgv_zav.Location = new System.Drawing.Point(417, 61);
            this.dgv_zav.Name = "dgv_zav";
            this.dgv_zav.RowHeadersVisible = false;
            this.dgv_zav.Size = new System.Drawing.Size(321, 134);
            this.dgv_zav.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_bludo";
            this.dataGridViewTextBoxColumn1.HeaderText = "id_bludo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "name_bludo";
            this.dataGridViewTextBoxColumn2.HeaderText = "Название блюда";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dgv_obed
            // 
            this.dgv_obed.AllowUserToAddRows = false;
            this.dgv_obed.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_obed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_obed.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dgv_obed.Location = new System.Drawing.Point(417, 224);
            this.dgv_obed.Name = "dgv_obed";
            this.dgv_obed.RowHeadersVisible = false;
            this.dgv_obed.Size = new System.Drawing.Size(321, 138);
            this.dgv_obed.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "id_bludo";
            this.dataGridViewTextBoxColumn3.HeaderText = "id_bludo";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "name_bludo";
            this.dataGridViewTextBoxColumn4.HeaderText = "Название блюда";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dgv_yzhin
            // 
            this.dgv_yzhin.AllowUserToAddRows = false;
            this.dgv_yzhin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_yzhin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_yzhin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dgv_yzhin.Location = new System.Drawing.Point(417, 391);
            this.dgv_yzhin.Name = "dgv_yzhin";
            this.dgv_yzhin.RowHeadersVisible = false;
            this.dgv_yzhin.Size = new System.Drawing.Size(321, 139);
            this.dgv_yzhin.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "id_bludo";
            this.dataGridViewTextBoxColumn5.HeaderText = "id_bludo";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Visible = false;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "name_bludo";
            this.dataGridViewTextBoxColumn6.HeaderText = "Название блюда";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // btn_Pn
            // 
            this.btn_Pn.Location = new System.Drawing.Point(417, 9);
            this.btn_Pn.Name = "btn_Pn";
            this.btn_Pn.Size = new System.Drawing.Size(31, 23);
            this.btn_Pn.TabIndex = 6;
            this.btn_Pn.Text = "Пн";
            this.btn_Pn.UseVisualStyleBackColor = true;
            this.btn_Pn.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Vt
            // 
            this.btn_Vt.Location = new System.Drawing.Point(454, 9);
            this.btn_Vt.Name = "btn_Vt";
            this.btn_Vt.Size = new System.Drawing.Size(31, 23);
            this.btn_Vt.TabIndex = 7;
            this.btn_Vt.Text = "Вт";
            this.btn_Vt.UseVisualStyleBackColor = true;
            this.btn_Vt.Click += new System.EventHandler(this.btn_Vt_Click);
            // 
            // btn_Sr
            // 
            this.btn_Sr.Location = new System.Drawing.Point(491, 9);
            this.btn_Sr.Name = "btn_Sr";
            this.btn_Sr.Size = new System.Drawing.Size(31, 23);
            this.btn_Sr.TabIndex = 8;
            this.btn_Sr.Text = "Ср";
            this.btn_Sr.UseVisualStyleBackColor = true;
            this.btn_Sr.Click += new System.EventHandler(this.btn_Sr_Click);
            // 
            // btn_Ct
            // 
            this.btn_Ct.Location = new System.Drawing.Point(528, 9);
            this.btn_Ct.Name = "btn_Ct";
            this.btn_Ct.Size = new System.Drawing.Size(31, 23);
            this.btn_Ct.TabIndex = 9;
            this.btn_Ct.Text = "Чт";
            this.btn_Ct.UseVisualStyleBackColor = true;
            this.btn_Ct.Click += new System.EventHandler(this.btn_Ct_Click);
            // 
            // btn_Pt
            // 
            this.btn_Pt.Location = new System.Drawing.Point(565, 9);
            this.btn_Pt.Name = "btn_Pt";
            this.btn_Pt.Size = new System.Drawing.Size(31, 23);
            this.btn_Pt.TabIndex = 10;
            this.btn_Pt.Text = "Пт";
            this.btn_Pt.UseVisualStyleBackColor = true;
            this.btn_Pt.Click += new System.EventHandler(this.btn_Pt_Click);
            // 
            // btn_Sb
            // 
            this.btn_Sb.Location = new System.Drawing.Point(602, 9);
            this.btn_Sb.Name = "btn_Sb";
            this.btn_Sb.Size = new System.Drawing.Size(31, 23);
            this.btn_Sb.TabIndex = 11;
            this.btn_Sb.Text = "Сб";
            this.btn_Sb.UseVisualStyleBackColor = true;
            this.btn_Sb.Click += new System.EventHandler(this.btn_Sb_Click);
            // 
            // btn_Vs
            // 
            this.btn_Vs.Location = new System.Drawing.Point(639, 9);
            this.btn_Vs.Name = "btn_Vs";
            this.btn_Vs.Size = new System.Drawing.Size(31, 23);
            this.btn_Vs.TabIndex = 12;
            this.btn_Vs.Text = "Вс";
            this.btn_Vs.UseVisualStyleBackColor = true;
            this.btn_Vs.Click += new System.EventHandler(this.btn_Vs_Click);
            // 
            // btn_Print
            // 
            this.btn_Print.Location = new System.Drawing.Point(676, 9);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(67, 23);
            this.btn_Print.TabIndex = 13;
            this.btn_Print.Text = "Печать";
            this.btn_Print.UseVisualStyleBackColor = true;
            this.btn_Print.Click += new System.EventHandler(this.btn_Print_Click);
            // 
            // rbt_zav
            // 
            this.rbt_zav.AutoSize = true;
            this.rbt_zav.Checked = true;
            this.rbt_zav.Location = new System.Drawing.Point(12, 64);
            this.rbt_zav.Name = "rbt_zav";
            this.rbt_zav.Size = new System.Drawing.Size(14, 13);
            this.rbt_zav.TabIndex = 14;
            this.rbt_zav.TabStop = true;
            this.rbt_zav.UseVisualStyleBackColor = true;
            // 
            // rbt_obed
            // 
            this.rbt_obed.AutoSize = true;
            this.rbt_obed.Location = new System.Drawing.Point(12, 238);
            this.rbt_obed.Name = "rbt_obed";
            this.rbt_obed.Size = new System.Drawing.Size(14, 13);
            this.rbt_obed.TabIndex = 15;
            this.rbt_obed.TabStop = true;
            this.rbt_obed.UseVisualStyleBackColor = true;
            // 
            // rbt_yzhin
            // 
            this.rbt_yzhin.AutoSize = true;
            this.rbt_yzhin.Location = new System.Drawing.Point(12, 401);
            this.rbt_yzhin.Name = "rbt_yzhin";
            this.rbt_yzhin.Size = new System.Drawing.Size(14, 13);
            this.rbt_yzhin.TabIndex = 16;
            this.rbt_yzhin.TabStop = true;
            this.rbt_yzhin.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbt_zav);
            this.panel1.Controls.Add(this.rbt_yzhin);
            this.panel1.Controls.Add(this.rbt_obed);
            this.panel1.Location = new System.Drawing.Point(372, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(39, 485);
            this.panel1.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(414, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "Завтрак";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(414, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "Обед";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(414, 372);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "Ужин";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(9, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 16);
            this.label5.TabIndex = 21;
            this.label5.Text = "Доступные блюда";
            // 
            // report1
            // 
            this.report1.NeedRefresh = false;
            this.report1.ReportResourceString = resources.GetString("report1.ReportResourceString");
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 543);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_Print);
            this.Controls.Add(this.btn_Vs);
            this.Controls.Add(this.btn_Sb);
            this.Controls.Add(this.btn_Pt);
            this.Controls.Add(this.btn_Ct);
            this.Controls.Add(this.btn_Sr);
            this.Controls.Add(this.btn_Vt);
            this.Controls.Add(this.btn_Pn);
            this.Controls.Add(this.dgv_yzhin);
            this.Controls.Add(this.dgv_obed);
            this.Controls.Add(this.dgv_zav);
            this.Controls.Add(this.dgv_bludo);
            this.Controls.Add(this.tb_menu);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Меню на понедельник";
            this.Shown += new System.EventHandler(this.Form2_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bludo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_zav)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_obed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_yzhin)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.report1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox tb_menu;
        private System.Windows.Forms.DataGridView dgv_bludo;
        private System.Windows.Forms.DataGridView dgv_zav;
        private System.Windows.Forms.DataGridView dgv_obed;
        private System.Windows.Forms.DataGridView dgv_yzhin;
        private System.Windows.Forms.Button btn_Pn;
        private System.Windows.Forms.Button btn_Vt;
        private System.Windows.Forms.Button btn_Sr;
        private System.Windows.Forms.Button btn_Ct;
        private System.Windows.Forms.Button btn_Pt;
        private System.Windows.Forms.Button btn_Sb;
        private System.Windows.Forms.Button btn_Vs;
        private System.Windows.Forms.Button btn_Print;
        private System.Windows.Forms.RadioButton rbt_zav;
        private System.Windows.Forms.RadioButton rbt_obed;
        private System.Windows.Forms.RadioButton rbt_yzhin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_bludo;
        private System.Windows.Forms.DataGridViewTextBoxColumn name_bludo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private FastReport.Report report1;
    }
}