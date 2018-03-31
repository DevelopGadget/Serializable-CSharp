namespace Serializable
{
    partial class Principal
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label6;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.TableEquipos = new System.Windows.Forms.DataGridView();
            this.Index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estadio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UrlEscudo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UrlEstadio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tboxNombre = new System.Windows.Forms.TextBox();
            this.tboxEstadio = new System.Windows.Forms.TextBox();
            this.tboxuEscudo = new System.Windows.Forms.TextBox();
            this.tboxuEstadio = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnMod = new System.Windows.Forms.Button();
            this.btnElim = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tboxFind = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.pbEscudo = new System.Windows.Forms.PictureBox();
            this.pbEstadio = new System.Windows.Forms.PictureBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TableEquipos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEscudo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEstadio)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(46, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(99, 13);
            label1.TabIndex = 2;
            label1.Text = "Nombre del equipo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(242, 9);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(101, 13);
            label2.TabIndex = 4;
            label2.Text = "Nombre del estadio:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(455, 9);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(78, 13);
            label3.TabIndex = 6;
            label3.Text = "Url del escudo:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(651, 9);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(77, 13);
            label4.TabIndex = 8;
            label4.Text = "Url del estadio:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(102, 81);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(100, 13);
            label5.TabIndex = 17;
            label5.Text = "Imagen del escudo:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(444, 81);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(99, 13);
            label6.TabIndex = 18;
            label6.Text = "Imagen del estadio:";
            // 
            // TableEquipos
            // 
            this.TableEquipos.AllowUserToAddRows = false;
            this.TableEquipos.AllowUserToDeleteRows = false;
            this.TableEquipos.AllowUserToResizeColumns = false;
            this.TableEquipos.AllowUserToResizeRows = false;
            this.TableEquipos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableEquipos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Index,
            this.Nombre,
            this.Estadio,
            this.UrlEscudo,
            this.UrlEstadio});
            this.TableEquipos.Location = new System.Drawing.Point(12, 387);
            this.TableEquipos.MultiSelect = false;
            this.TableEquipos.Name = "TableEquipos";
            this.TableEquipos.ReadOnly = true;
            this.TableEquipos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TableEquipos.Size = new System.Drawing.Size(760, 162);
            this.TableEquipos.TabIndex = 0;
            // 
            // Index
            // 
            this.Index.Frozen = true;
            this.Index.HeaderText = "Index";
            this.Index.Name = "Index";
            this.Index.ReadOnly = true;
            this.Index.Visible = false;
            this.Index.Width = 20;
            // 
            // Nombre
            // 
            this.Nombre.Frozen = true;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 180;
            // 
            // Estadio
            // 
            this.Estadio.Frozen = true;
            this.Estadio.HeaderText = "Estadio";
            this.Estadio.Name = "Estadio";
            this.Estadio.ReadOnly = true;
            this.Estadio.Width = 180;
            // 
            // UrlEscudo
            // 
            this.UrlEscudo.Frozen = true;
            this.UrlEscudo.HeaderText = "Url Escudo";
            this.UrlEscudo.Name = "UrlEscudo";
            this.UrlEscudo.ReadOnly = true;
            this.UrlEscudo.Width = 180;
            // 
            // UrlEstadio
            // 
            this.UrlEstadio.Frozen = true;
            this.UrlEstadio.HeaderText = "Url Estadio";
            this.UrlEstadio.Name = "UrlEstadio";
            this.UrlEstadio.ReadOnly = true;
            this.UrlEstadio.Width = 180;
            // 
            // tboxNombre
            // 
            this.tboxNombre.Location = new System.Drawing.Point(12, 35);
            this.tboxNombre.Name = "tboxNombre";
            this.tboxNombre.Size = new System.Drawing.Size(167, 20);
            this.tboxNombre.TabIndex = 1;
            // 
            // tboxEstadio
            // 
            this.tboxEstadio.Location = new System.Drawing.Point(208, 35);
            this.tboxEstadio.Name = "tboxEstadio";
            this.tboxEstadio.Size = new System.Drawing.Size(167, 20);
            this.tboxEstadio.TabIndex = 3;
            // 
            // tboxuEscudo
            // 
            this.tboxuEscudo.Location = new System.Drawing.Point(408, 35);
            this.tboxuEscudo.Name = "tboxuEscudo";
            this.tboxuEscudo.Size = new System.Drawing.Size(167, 20);
            this.tboxuEscudo.TabIndex = 5;
            // 
            // tboxuEstadio
            // 
            this.tboxuEstadio.Location = new System.Drawing.Point(605, 35);
            this.tboxuEstadio.Name = "tboxuEstadio";
            this.tboxuEstadio.Size = new System.Drawing.Size(167, 20);
            this.tboxuEstadio.TabIndex = 7;
            // 
            // btnAdd
            // 
            this.btnAdd.Image = global::Serializable.Properties.Resources.Add;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(654, 81);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(96, 45);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Registrar";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnMod
            // 
            this.btnMod.Enabled = false;
            this.btnMod.Image = global::Serializable.Properties.Resources.Update;
            this.btnMod.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMod.Location = new System.Drawing.Point(654, 132);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(96, 45);
            this.btnMod.TabIndex = 10;
            this.btnMod.Text = "Modificar";
            this.btnMod.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMod.UseVisualStyleBackColor = true;
            // 
            // btnElim
            // 
            this.btnElim.Enabled = false;
            this.btnElim.Image = global::Serializable.Properties.Resources.Delete;
            this.btnElim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnElim.Location = new System.Drawing.Point(654, 183);
            this.btnElim.Name = "btnElim";
            this.btnElim.Size = new System.Drawing.Size(96, 45);
            this.btnElim.TabIndex = 11;
            this.btnElim.Text = "Eliminar";
            this.btnElim.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnElim.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Image = global::Serializable.Properties.Resources.Delete;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(654, 336);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(96, 45);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // tboxFind
            // 
            this.tboxFind.Location = new System.Drawing.Point(116, 349);
            this.tboxFind.Name = "tboxFind";
            this.tboxFind.Size = new System.Drawing.Size(167, 20);
            this.tboxFind.TabIndex = 13;
            // 
            // btnFind
            // 
            this.btnFind.Image = global::Serializable.Properties.Resources.Find;
            this.btnFind.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFind.Location = new System.Drawing.Point(12, 336);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(84, 45);
            this.btnFind.TabIndex = 14;
            this.btnFind.Text = "Buscar";
            this.btnFind.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFind.UseVisualStyleBackColor = true;
            // 
            // pbEscudo
            // 
            this.pbEscudo.Location = new System.Drawing.Point(12, 107);
            this.pbEscudo.Name = "pbEscudo";
            this.pbEscudo.Size = new System.Drawing.Size(310, 210);
            this.pbEscudo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbEscudo.TabIndex = 15;
            this.pbEscudo.TabStop = false;
            // 
            // pbEstadio
            // 
            this.pbEstadio.Location = new System.Drawing.Point(338, 107);
            this.pbEstadio.Name = "pbEstadio";
            this.pbEstadio.Size = new System.Drawing.Size(310, 210);
            this.pbEstadio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbEstadio.TabIndex = 16;
            this.pbEstadio.TabStop = false;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(label6);
            this.Controls.Add(label5);
            this.Controls.Add(this.pbEstadio);
            this.Controls.Add(this.pbEscudo);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.tboxFind);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnElim);
            this.Controls.Add(this.btnMod);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(label4);
            this.Controls.Add(this.tboxuEstadio);
            this.Controls.Add(label3);
            this.Controls.Add(this.tboxuEscudo);
            this.Controls.Add(label2);
            this.Controls.Add(this.tboxEstadio);
            this.Controls.Add(label1);
            this.Controls.Add(this.tboxNombre);
            this.Controls.Add(this.TableEquipos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Serializable Equipos";
            this.Load += new System.EventHandler(this.Principal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TableEquipos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEscudo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEstadio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView TableEquipos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Index;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estadio;
        private System.Windows.Forms.DataGridViewTextBoxColumn UrlEscudo;
        private System.Windows.Forms.DataGridViewTextBoxColumn UrlEstadio;
        private System.Windows.Forms.TextBox tboxNombre;
        private System.Windows.Forms.TextBox tboxEstadio;
        private System.Windows.Forms.TextBox tboxuEscudo;
        private System.Windows.Forms.TextBox tboxuEstadio;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnMod;
        private System.Windows.Forms.Button btnElim;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox tboxFind;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.PictureBox pbEscudo;
        private System.Windows.Forms.PictureBox pbEstadio;
    }
}

