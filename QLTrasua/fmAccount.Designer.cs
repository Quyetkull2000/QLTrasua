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
            this.dg_ViewNhanvien = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.USP_RecipeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_ViewNhanvien)).BeginInit();
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
            this.bt_ViewNhanvien.Location = new System.Drawing.Point(98, 91);
            this.bt_ViewNhanvien.Name = "bt_ViewNhanvien";
            this.bt_ViewNhanvien.Size = new System.Drawing.Size(83, 32);
            this.bt_ViewNhanvien.TabIndex = 0;
            this.bt_ViewNhanvien.Text = "Hiển thị";
            this.bt_ViewNhanvien.UseVisualStyleBackColor = true;
            // 
            // dg_ViewNhanvien
            // 
            this.dg_ViewNhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_ViewNhanvien.Location = new System.Drawing.Point(98, 129);
            this.dg_ViewNhanvien.Name = "dg_ViewNhanvien";
            this.dg_ViewNhanvien.Size = new System.Drawing.Size(662, 324);
            this.dg_ViewNhanvien.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(293, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Danh sách nhân viên";
            // 
            // fmAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dg_ViewNhanvien);
            this.Controls.Add(this.bt_ViewNhanvien);
            this.Name = "fmAccount";
            this.Text = "fmAccount";
            ((System.ComponentModel.ISupportInitialize)(this.USP_RecipeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_ViewNhanvien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource USP_RecipeBindingSource;
        private System.Windows.Forms.Button bt_ViewNhanvien;
        private System.Windows.Forms.DataGridView dg_ViewNhanvien;
        private System.Windows.Forms.Label label1;
    }
}