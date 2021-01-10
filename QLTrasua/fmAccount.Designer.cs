namespace QLTrasua
{
    partial class fmAccount
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
            this.USP_RecipeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bt_ViewNhanvien = new System.Windows.Forms.Button();
            this.dtgvAccount = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.USP_RecipeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAccount)).BeginInit();
            this.SuspendLayout();
            // 
            // USP_RecipeBindingSource
            // 
            this.USP_RecipeBindingSource.DataMember = "USP_Recipe";
            this.USP_RecipeBindingSource.CurrentChanged += new System.EventHandler(this.USP_RecipeBindingSource_CurrentChanged);
            // 
            // bt_ViewNhanvien
            // 
            this.bt_ViewNhanvien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_ViewNhanvien.Location = new System.Drawing.Point(131, 112);
            this.bt_ViewNhanvien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_ViewNhanvien.Name = "bt_ViewNhanvien";
            this.bt_ViewNhanvien.Size = new System.Drawing.Size(111, 39);
            this.bt_ViewNhanvien.TabIndex = 0;
            this.bt_ViewNhanvien.Text = "Hiển thị";
            this.bt_ViewNhanvien.UseVisualStyleBackColor = true;
            this.bt_ViewNhanvien.Click += new System.EventHandler(this.bt_ViewNhanvien_Click);
            // 
            // dtgvAccount
            // 
            this.dtgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvAccount.Location = new System.Drawing.Point(131, 159);
            this.dtgvAccount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtgvAccount.Name = "dtgvAccount";
            this.dtgvAccount.RowHeadersWidth = 51;
            this.dtgvAccount.Size = new System.Drawing.Size(883, 399);
            this.dtgvAccount.TabIndex = 1;
            this.dtgvAccount.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvAccount_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(391, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Danh sách nhân viên";
            // 
            // fmAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgvAccount);
            this.Controls.Add(this.bt_ViewNhanvien);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "fmAccount";
            this.Text = "fmAccount";
            ((System.ComponentModel.ISupportInitialize)(this.USP_RecipeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAccount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource USP_RecipeBindingSource;
        private System.Windows.Forms.Button bt_ViewNhanvien;
        private System.Windows.Forms.DataGridView dtgvAccount;
        private System.Windows.Forms.Label label1;
    }
}