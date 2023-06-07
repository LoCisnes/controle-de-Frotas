namespace controle_de_FrotasJuam
{
    partial class ControleDeFrota
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCarros = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCaminhoes = new System.Windows.Forms.Button();
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.lblKm = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.txtKm = new System.Windows.Forms.TextBox();
            this.txtCarros = new System.Windows.Forms.RichTextBox();
            this.txtCaminhoes = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblEixo = new System.Windows.Forms.Label();
            this.txtEixo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCarros
            // 
            this.btnCarros.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarros.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCarros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCarros.Location = new System.Drawing.Point(145, 33);
            this.btnCarros.Name = "btnCarros";
            this.btnCarros.Size = new System.Drawing.Size(121, 35);
            this.btnCarros.TabIndex = 0;
            this.btnCarros.Text = "Carros";
            this.btnCarros.UseVisualStyleBackColor = true;
            this.btnCarros.Click += new System.EventHandler(this.btnCarros_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(494, 33);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(121, 35);
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.Text = "Salvar ";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCaminhoes
            // 
            this.btnCaminhoes.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaminhoes.Location = new System.Drawing.Point(322, 33);
            this.btnCaminhoes.Name = "btnCaminhoes";
            this.btnCaminhoes.Size = new System.Drawing.Size(121, 35);
            this.btnCaminhoes.TabIndex = 0;
            this.btnCaminhoes.Text = "Caminhões";
            this.btnCaminhoes.UseVisualStyleBackColor = true;
            this.btnCaminhoes.Click += new System.EventHandler(this.btnCaminhoes_Click);
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelo.Location = new System.Drawing.Point(47, 112);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(59, 20);
            this.lblModelo.TabIndex = 1;
            this.lblModelo.Text = "Modelo:";
            this.lblModelo.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaca.Location = new System.Drawing.Point(48, 141);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(47, 20);
            this.lblPlaca.TabIndex = 2;
            this.lblPlaca.Text = "Placa:";
            // 
            // lblKm
            // 
            this.lblKm.AutoSize = true;
            this.lblKm.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKm.Location = new System.Drawing.Point(47, 170);
            this.lblKm.Name = "lblKm";
            this.lblKm.Size = new System.Drawing.Size(34, 20);
            this.lblKm.TabIndex = 3;
            this.lblKm.Text = "Km:";
            this.lblKm.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(112, 114);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(154, 20);
            this.txtModelo.TabIndex = 4;
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(112, 143);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(154, 20);
            this.txtPlaca.TabIndex = 5;
            // 
            // txtKm
            // 
            this.txtKm.Location = new System.Drawing.Point(112, 172);
            this.txtKm.Name = "txtKm";
            this.txtKm.Size = new System.Drawing.Size(154, 20);
            this.txtKm.TabIndex = 6;
            // 
            // txtCarros
            // 
            this.txtCarros.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtCarros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCarros.Location = new System.Drawing.Point(40, 275);
            this.txtCarros.Name = "txtCarros";
            this.txtCarros.ReadOnly = true;
            this.txtCarros.Size = new System.Drawing.Size(305, 253);
            this.txtCarros.TabIndex = 16;
            this.txtCarros.Text = "";
            // 
            // txtCaminhoes
            // 
            this.txtCaminhoes.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtCaminhoes.Location = new System.Drawing.Point(404, 275);
            this.txtCaminhoes.Name = "txtCaminhoes";
            this.txtCaminhoes.ReadOnly = true;
            this.txtCaminhoes.Size = new System.Drawing.Size(305, 253);
            this.txtCaminhoes.TabIndex = 17;
            this.txtCaminhoes.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "Carros";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(399, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 25);
            this.label2.TabIndex = 19;
            this.label2.Text = "Caminhoes";
            // 
            // lblEixo
            // 
            this.lblEixo.AutoSize = true;
            this.lblEixo.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEixo.Location = new System.Drawing.Point(460, 112);
            this.lblEixo.Name = "lblEixo";
            this.lblEixo.Size = new System.Drawing.Size(39, 20);
            this.lblEixo.TabIndex = 20;
            this.lblEixo.Text = "Eixo:";
            this.lblEixo.Visible = false;
            // 
            // txtEixo
            // 
            this.txtEixo.Location = new System.Drawing.Point(505, 112);
            this.txtEixo.Name = "txtEixo";
            this.txtEixo.Size = new System.Drawing.Size(154, 20);
            this.txtEixo.TabIndex = 21;
            this.txtEixo.Visible = false;
            // 
            // ControleDeFrota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(799, 555);
            this.Controls.Add(this.txtEixo);
            this.Controls.Add(this.lblEixo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCaminhoes);
            this.Controls.Add(this.txtCarros);
            this.Controls.Add(this.txtKm);
            this.Controls.Add(this.txtPlaca);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.lblKm);
            this.Controls.Add(this.lblPlaca);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.btnCaminhoes);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnCarros);
            this.MaximizeBox = false;
            this.Name = "ControleDeFrota";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle de Frota";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCarros;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCaminhoes;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.Label lblKm;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.TextBox txtKm;
        private System.Windows.Forms.RichTextBox txtCarros;
        private System.Windows.Forms.RichTextBox txtCaminhoes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblEixo;
        private System.Windows.Forms.TextBox txtEixo;
    }
}

