namespace WebRequest_DDTECH
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.listCategories = new System.Windows.Forms.ListBox();
            this.categorias = new System.Windows.Forms.Button();
            this.labelCategoria = new System.Windows.Forms.Label();
            this.listSubCat = new System.Windows.Forms.ListBox();
            this.labelSubCat = new System.Windows.Forms.Label();
            this.listProductos = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listCategories
            // 
            this.listCategories.Font = new System.Drawing.Font("Bebas Neue", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listCategories.FormattingEnabled = true;
            this.listCategories.ItemHeight = 23;
            this.listCategories.Location = new System.Drawing.Point(13, 77);
            this.listCategories.Name = "listCategories";
            this.listCategories.Size = new System.Drawing.Size(120, 878);
            this.listCategories.TabIndex = 0;
            this.listCategories.SelectedIndexChanged += new System.EventHandler(this.listCategories_SelectedIndexChanged);
            // 
            // categorias
            // 
            this.categorias.Font = new System.Drawing.Font("Bebas Neue", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categorias.Location = new System.Drawing.Point(12, 12);
            this.categorias.Name = "categorias";
            this.categorias.Size = new System.Drawing.Size(120, 49);
            this.categorias.TabIndex = 1;
            this.categorias.Text = "C A T E G O R I A S";
            this.categorias.UseVisualStyleBackColor = true;
            this.categorias.MouseClick += new System.Windows.Forms.MouseEventHandler(this.categorias_MouseClick);
            // 
            // labelCategoria
            // 
            this.labelCategoria.AutoSize = true;
            this.labelCategoria.BackColor = System.Drawing.Color.LightSlateGray;
            this.labelCategoria.Font = new System.Drawing.Font("Bebas Neue", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCategoria.Location = new System.Drawing.Point(163, 31);
            this.labelCategoria.Name = "labelCategoria";
            this.labelCategoria.Size = new System.Drawing.Size(58, 25);
            this.labelCategoria.TabIndex = 2;
            this.labelCategoria.Text = "label1";
            this.labelCategoria.Visible = false;
            // 
            // listSubCat
            // 
            this.listSubCat.Font = new System.Drawing.Font("Bebas Neue", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listSubCat.FormattingEnabled = true;
            this.listSubCat.ItemHeight = 23;
            this.listSubCat.Location = new System.Drawing.Point(159, 77);
            this.listSubCat.Name = "listSubCat";
            this.listSubCat.Size = new System.Drawing.Size(218, 878);
            this.listSubCat.TabIndex = 3;
            this.listSubCat.SelectedIndexChanged += new System.EventHandler(this.listSubCat_SelectedIndexChanged);
            // 
            // labelSubCat
            // 
            this.labelSubCat.AutoSize = true;
            this.labelSubCat.BackColor = System.Drawing.Color.LightSlateGray;
            this.labelSubCat.Font = new System.Drawing.Font("Bebas Neue", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSubCat.Location = new System.Drawing.Point(406, 31);
            this.labelSubCat.Name = "labelSubCat";
            this.labelSubCat.Size = new System.Drawing.Size(58, 25);
            this.labelSubCat.TabIndex = 5;
            this.labelSubCat.Text = "label1";
            this.labelSubCat.Visible = false;
            // 
            // listProductos
            // 
            this.listProductos.Font = new System.Drawing.Font("Bebas Neue", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listProductos.FormattingEnabled = true;
            this.listProductos.ItemHeight = 23;
            this.listProductos.Location = new System.Drawing.Point(411, 77);
            this.listProductos.Name = "listProductos";
            this.listProductos.Size = new System.Drawing.Size(1470, 878);
            this.listProductos.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(1904, 961);
            this.Controls.Add(this.listProductos);
            this.Controls.Add(this.labelSubCat);
            this.Controls.Add(this.listSubCat);
            this.Controls.Add(this.labelCategoria);
            this.Controls.Add(this.categorias);
            this.Controls.Add(this.listCategories);
            this.Name = "Form1";
            this.Text = "WebRequest - DDTECH";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listCategories;
        private System.Windows.Forms.Button categorias;
        private System.Windows.Forms.Label labelCategoria;
        private System.Windows.Forms.ListBox listSubCat;
        private System.Windows.Forms.Label labelSubCat;
        private System.Windows.Forms.ListBox listProductos;
    }
}

