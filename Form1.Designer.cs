namespace KBJU
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgv_menu = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_Add = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgv_allbluda = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgv_prod = new System.Windows.Forms.DataGridView();
            this.id_menu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name_menu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_menu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_bludo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name_bludo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name_product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kilocalorii = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.belki = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zhiry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uglevody = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_menu)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_allbluda)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_prod)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_menu
            // 
            this.dgv_menu.AllowUserToAddRows = false;
            this.dgv_menu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_menu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_menu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_menu,
            this.name_menu,
            this.date_menu});
            this.dgv_menu.Location = new System.Drawing.Point(6, 33);
            this.dgv_menu.MultiSelect = false;
            this.dgv_menu.Name = "dgv_menu";
            this.dgv_menu.ReadOnly = true;
            this.dgv_menu.RowHeadersVisible = false;
            this.dgv_menu.Size = new System.Drawing.Size(465, 281);
            this.dgv_menu.TabIndex = 0;
            this.dgv_menu.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_menu_CellDoubleClick);
            this.dgv_menu.Enter += new System.EventHandler(this.dgv_menu_Enter);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(484, 343);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_Add);
            this.tabPage1.Controls.Add(this.dgv_menu);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(476, 317);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Меню";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(6, 4);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(116, 23);
            this.btn_Add.TabIndex = 1;
            this.btn_Add.Text = "Новое меню";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgv_allbluda);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(476, 317);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Редактор блюд";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgv_allbluda
            // 
            this.dgv_allbluda.AllowUserToAddRows = false;
            this.dgv_allbluda.AllowUserToDeleteRows = false;
            this.dgv_allbluda.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_allbluda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_allbluda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_bludo,
            this.name_bludo});
            this.dgv_allbluda.Location = new System.Drawing.Point(3, 3);
            this.dgv_allbluda.Name = "dgv_allbluda";
            this.dgv_allbluda.RowHeadersVisible = false;
            this.dgv_allbluda.Size = new System.Drawing.Size(470, 311);
            this.dgv_allbluda.TabIndex = 0;
            this.dgv_allbluda.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_allbluda_CellEndEdit);
            this.dgv_allbluda.Enter += new System.EventHandler(this.dgv_allbluda_Enter);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dgv_prod);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(476, 317);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Ингредиенты";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgv_prod
            // 
            this.dgv_prod.AllowUserToAddRows = false;
            this.dgv_prod.AllowUserToDeleteRows = false;
            this.dgv_prod.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_prod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_prod.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_product,
            this.name_product,
            this.kilocalorii,
            this.belki,
            this.zhiry,
            this.uglevody});
            this.dgv_prod.Location = new System.Drawing.Point(3, 3);
            this.dgv_prod.Name = "dgv_prod";
            this.dgv_prod.RowHeadersVisible = false;
            this.dgv_prod.Size = new System.Drawing.Size(468, 311);
            this.dgv_prod.TabIndex = 0;
            this.dgv_prod.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_prod_CellEndEdit);
            this.dgv_prod.Enter += new System.EventHandler(this.dgv_prod_Enter);
            // 
            // id_menu
            // 
            this.id_menu.DataPropertyName = "id_menu";
            this.id_menu.HeaderText = "id_menu";
            this.id_menu.Name = "id_menu";
            this.id_menu.ReadOnly = true;
            this.id_menu.Visible = false;
            // 
            // name_menu
            // 
            this.name_menu.DataPropertyName = "name_menu";
            this.name_menu.HeaderText = "Название меню";
            this.name_menu.MinimumWidth = 250;
            this.name_menu.Name = "name_menu";
            this.name_menu.ReadOnly = true;
            this.name_menu.Width = 300;
            // 
            // date_menu
            // 
            this.date_menu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.date_menu.DataPropertyName = "date_menu";
            this.date_menu.HeaderText = "Добавлен";
            this.date_menu.Name = "date_menu";
            this.date_menu.ReadOnly = true;
            // 
            // id_bludo
            // 
            this.id_bludo.DataPropertyName = "id_bludo";
            this.id_bludo.HeaderText = "Идентификатор";
            this.id_bludo.Name = "id_bludo";
            this.id_bludo.ReadOnly = true;
            // 
            // name_bludo
            // 
            this.name_bludo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name_bludo.DataPropertyName = "name_bludo";
            this.name_bludo.HeaderText = "Название блюда";
            this.name_bludo.Name = "name_bludo";
            // 
            // id_product
            // 
            this.id_product.DataPropertyName = "id_product";
            this.id_product.HeaderText = "Идентификатор";
            this.id_product.Name = "id_product";
            this.id_product.ReadOnly = true;
            // 
            // name_product
            // 
            this.name_product.DataPropertyName = "name_product";
            this.name_product.HeaderText = "Название продукта";
            this.name_product.MinimumWidth = 100;
            this.name_product.Name = "name_product";
            this.name_product.Width = 200;
            // 
            // kilocalorii
            // 
            this.kilocalorii.DataPropertyName = "kilocalorii";
            this.kilocalorii.HeaderText = "Ккал";
            this.kilocalorii.Name = "kilocalorii";
            // 
            // belki
            // 
            this.belki.DataPropertyName = "belki";
            this.belki.HeaderText = "Белки";
            this.belki.Name = "belki";
            // 
            // zhiry
            // 
            this.zhiry.DataPropertyName = "zhiry";
            this.zhiry.HeaderText = "Жиры";
            this.zhiry.Name = "zhiry";
            // 
            // uglevody
            // 
            this.uglevody.DataPropertyName = "uglevody";
            this.uglevody.HeaderText = "Углеводы";
            this.uglevody.Name = "uglevody";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 343);
            this.Controls.Add(this.tabControl1);
            this.MinimumSize = new System.Drawing.Size(500, 300);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Общепит 1.0";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_menu)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_allbluda)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_prod)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_menu;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dgv_prod;
        private System.Windows.Forms.DataGridView dgv_allbluda;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_menu;
        private System.Windows.Forms.DataGridViewTextBoxColumn name_menu;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_menu;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_bludo;
        private System.Windows.Forms.DataGridViewTextBoxColumn name_bludo;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_product;
        private System.Windows.Forms.DataGridViewTextBoxColumn name_product;
        private System.Windows.Forms.DataGridViewTextBoxColumn kilocalorii;
        private System.Windows.Forms.DataGridViewTextBoxColumn belki;
        private System.Windows.Forms.DataGridViewTextBoxColumn zhiry;
        private System.Windows.Forms.DataGridViewTextBoxColumn uglevody;
    }
}

