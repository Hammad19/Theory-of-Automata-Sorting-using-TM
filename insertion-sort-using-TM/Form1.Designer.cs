
namespace insertion_sort_using_TM
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.TBForm = new System.Windows.Forms.TabControl();
            this.TBgiris = new System.Windows.Forms.TabPage();
            this.BtnSort = new System.Windows.Forms.Button();
            this.txtOutputs = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtInputs = new System.Windows.Forms.TextBox();
            this.TBlog = new System.Windows.Forms.TabPage();
            this.lwTM = new System.Windows.Forms.ListView();
            this.sayi1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sayi2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TMlog = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TBForm.SuspendLayout();
            this.TBgiris.SuspendLayout();
            this.TBlog.SuspendLayout();
            this.SuspendLayout();
            // 
            // TBForm
            // 
            this.TBForm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TBForm.Controls.Add(this.TBgiris);
            this.TBForm.Controls.Add(this.TBlog);
            this.TBForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TBForm.Location = new System.Drawing.Point(0, 12);
            this.TBForm.Name = "TBForm";
            this.TBForm.SelectedIndex = 0;
            this.TBForm.Size = new System.Drawing.Size(2182, 1785);
            this.TBForm.TabIndex = 0;
            // 
            // TBgiris
            // 
            this.TBgiris.Controls.Add(this.BtnSort);
            this.TBgiris.Controls.Add(this.txtOutputs);
            this.TBgiris.Controls.Add(this.label2);
            this.TBgiris.Controls.Add(this.label1);
            this.TBgiris.Controls.Add(this.txtInputs);
            this.TBgiris.Location = new System.Drawing.Point(12, 76);
            this.TBgiris.Name = "TBgiris";
            this.TBgiris.Padding = new System.Windows.Forms.Padding(3);
            this.TBgiris.Size = new System.Drawing.Size(2158, 1697);
            this.TBgiris.TabIndex = 0;
            this.TBgiris.Text = "MainTab";
            this.TBgiris.UseVisualStyleBackColor = true;
            // 
            // BtnSort
            // 
            this.BtnSort.Location = new System.Drawing.Point(66, 267);
            this.BtnSort.Name = "BtnSort";
            this.BtnSort.Size = new System.Drawing.Size(320, 89);
            this.BtnSort.TabIndex = 4;
            this.BtnSort.Text = "Sort";
            this.BtnSort.UseVisualStyleBackColor = true;
            this.BtnSort.Click += new System.EventHandler(this.BtnSort_Click);
            // 
            // txtOutputs
            // 
            this.txtOutputs.Location = new System.Drawing.Point(65, 459);
            this.txtOutputs.Name = "txtOutputs";
            this.txtOutputs.ReadOnly = true;
            this.txtOutputs.Size = new System.Drawing.Size(1298, 62);
            this.txtOutputs.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 372);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(289, 55);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sorted array";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(747, 55);
            this.label1.TabIndex = 1;
            this.label1.Text = "Write array giving space between.";
            // 
            // txtInputs
            // 
            this.txtInputs.Location = new System.Drawing.Point(65, 162);
            this.txtInputs.Name = "txtInputs";
            this.txtInputs.Size = new System.Drawing.Size(1298, 62);
            this.txtInputs.TabIndex = 0;
            this.txtInputs.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInputs_KeyPress);
            // 
            // TBlog
            // 
            this.TBlog.Controls.Add(this.lwTM);
            this.TBlog.Location = new System.Drawing.Point(12, 76);
            this.TBlog.Name = "TBlog";
            this.TBlog.Padding = new System.Windows.Forms.Padding(3);
            this.TBlog.Size = new System.Drawing.Size(2158, 1697);
            this.TBlog.TabIndex = 1;
            this.TBlog.Text = "Turning machine outs";
            this.TBlog.UseVisualStyleBackColor = true;
            // 
            // lwTM
            // 
            this.lwTM.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.sayi1,
            this.sayi2,
            this.TMlog});
            this.lwTM.FullRowSelect = true;
            this.lwTM.GridLines = true;
            this.lwTM.HideSelection = false;
            this.lwTM.Location = new System.Drawing.Point(0, 3);
            this.lwTM.Name = "lwTM";
            this.lwTM.Size = new System.Drawing.Size(1849, 885);
            this.lwTM.TabIndex = 1;
            this.lwTM.UseCompatibleStateImageBehavior = false;
            this.lwTM.View = System.Windows.Forms.View.List;
            // 
            // sayi1
            // 
            this.sayi1.Text = "Num1";
            // 
            // sayi2
            // 
            this.sayi2.Text = "Num2";
            // 
            // TMlog
            // 
            this.TMlog.Text = "TM Bandı";
            this.TMlog.Width = 500;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2194, 1797);
            this.Controls.Add(this.TBForm);
            this.Name = "Form1";
            this.Text = "Insertion Sort Using TM";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.TBForm.ResumeLayout(false);
            this.TBgiris.ResumeLayout(false);
            this.TBgiris.PerformLayout();
            this.TBlog.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TBForm;
        private System.Windows.Forms.TabPage TBgiris;
        private System.Windows.Forms.TextBox txtInputs;
        private System.Windows.Forms.TabPage TBlog;
        private System.Windows.Forms.TextBox txtOutputs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lwTM;
        private System.Windows.Forms.Button BtnSort;
        public System.Windows.Forms.ColumnHeader sayi1;
        public System.Windows.Forms.ColumnHeader sayi2;
        public System.Windows.Forms.ColumnHeader TMlog;
    }
}

