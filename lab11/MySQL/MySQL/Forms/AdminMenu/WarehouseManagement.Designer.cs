namespace MySQL.Forms.AdminMenu.FormsAdminMenu
{
    partial class WarehouseManagement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridCountProducts = new System.Windows.Forms.DataGridView();
            this.dataGridDetailsProduct = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAddSupply = new System.Windows.Forms.Button();
            this.comboBoxSortProducts = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnResetSort = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCountProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDetailsProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridCountProducts
            // 
            this.dataGridCountProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightCoral;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridCountProducts.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridCountProducts.Location = new System.Drawing.Point(30, 57);
            this.dataGridCountProducts.Name = "dataGridCountProducts";
            this.dataGridCountProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridCountProducts.Size = new System.Drawing.Size(498, 511);
            this.dataGridCountProducts.TabIndex = 0;
            this.dataGridCountProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridCountProducts_CellClick);
            // 
            // dataGridDetailsProduct
            // 
            this.dataGridDetailsProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDetailsProduct.Location = new System.Drawing.Point(571, 57);
            this.dataGridDetailsProduct.Name = "dataGridDetailsProduct";
            this.dataGridDetailsProduct.Size = new System.Drawing.Size(273, 511);
            this.dataGridDetailsProduct.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(568, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Поставки товара";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(27, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Список товаров на складе";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExit.Location = new System.Drawing.Point(921, 259);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(191, 30);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAddSupply
            // 
            this.btnAddSupply.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddSupply.Location = new System.Drawing.Point(921, 193);
            this.btnAddSupply.Name = "btnAddSupply";
            this.btnAddSupply.Size = new System.Drawing.Size(191, 33);
            this.btnAddSupply.TabIndex = 5;
            this.btnAddSupply.Text = "Добавить новую поставку";
            this.btnAddSupply.UseVisualStyleBackColor = true;
            this.btnAddSupply.Click += new System.EventHandler(this.btnAddSupply_Click);
            // 
            // comboBoxSortProducts
            // 
            this.comboBoxSortProducts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSortProducts.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxSortProducts.FormattingEnabled = true;
            this.comboBoxSortProducts.Location = new System.Drawing.Point(921, 57);
            this.comboBoxSortProducts.Name = "comboBoxSortProducts";
            this.comboBoxSortProducts.Size = new System.Drawing.Size(191, 26);
            this.comboBoxSortProducts.TabIndex = 6;
            this.comboBoxSortProducts.SelectedIndexChanged += new System.EventHandler(this.comboBoxSortProducts_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(897, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(234, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Сортировка по категории товара";
            // 
            // btnResetSort
            // 
            this.btnResetSort.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnResetSort.Location = new System.Drawing.Point(921, 116);
            this.btnResetSort.Name = "btnResetSort";
            this.btnResetSort.Size = new System.Drawing.Size(191, 33);
            this.btnResetSort.TabIndex = 8;
            this.btnResetSort.Text = "Сбросить сортировку";
            this.btnResetSort.UseVisualStyleBackColor = true;
            this.btnResetSort.Click += new System.EventHandler(this.btnResetSort_Click);
            // 
            // WarehouseManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 612);
            this.Controls.Add(this.btnResetSort);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxSortProducts);
            this.Controls.Add(this.btnAddSupply);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridDetailsProduct);
            this.Controls.Add(this.dataGridCountProducts);
            this.Name = "WarehouseManagement";
            this.Text = "WarehouseManagement";
            this.Load += new System.EventHandler(this.WarehouseManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCountProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDetailsProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridCountProducts;
        private System.Windows.Forms.DataGridView dataGridDetailsProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAddSupply;
        private System.Windows.Forms.ComboBox comboBoxSortProducts;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnResetSort;
    }
}