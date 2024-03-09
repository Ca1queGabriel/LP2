namespace Pvolume
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblVolume = new System.Windows.Forms.Label();
            this.lblAltura = new System.Windows.Forms.Label();
            this.lblRaio = new System.Windows.Forms.Label();
            this.txtRaio = new System.Windows.Forms.TextBox();
            this.txtVolume = new System.Windows.Forms.TextBox();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.btmFechar = new System.Windows.Forms.Button();
            this.btmCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblVolume
            // 
            this.lblVolume.AutoSize = true;
            this.lblVolume.Location = new System.Drawing.Point(29, 216);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(63, 20);
            this.lblVolume.TabIndex = 0;
            this.lblVolume.Text = "Volume";
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(29, 165);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(51, 20);
            this.lblAltura.TabIndex = 1;
            this.lblAltura.Text = "Altura";
            // 
            // lblRaio
            // 
            this.lblRaio.AutoSize = true;
            this.lblRaio.Location = new System.Drawing.Point(29, 107);
            this.lblRaio.Name = "lblRaio";
            this.lblRaio.Size = new System.Drawing.Size(42, 20);
            this.lblRaio.TabIndex = 2;
            this.lblRaio.Text = "Raio";
            // 
            // txtRaio
            // 
            this.txtRaio.Location = new System.Drawing.Point(130, 107);
            this.txtRaio.Name = "txtRaio";
            this.txtRaio.Size = new System.Drawing.Size(242, 26);
            this.txtRaio.TabIndex = 3;
            this.txtRaio.Validated += new System.EventHandler(this.txtRaio_Validated);
            // 
            // txtVolume
            // 
            this.txtVolume.Enabled = false;
            this.txtVolume.Location = new System.Drawing.Point(130, 216);
            this.txtVolume.Name = "txtVolume";
            this.txtVolume.Size = new System.Drawing.Size(242, 26);
            this.txtVolume.TabIndex = 4;
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(130, 165);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(242, 26);
            this.txtAltura.TabIndex = 5;
            this.txtAltura.Validated += new System.EventHandler(this.txtAltura_Validated);
            // 
            // btmFechar
            // 
            this.btmFechar.Location = new System.Drawing.Point(448, 323);
            this.btmFechar.Name = "btmFechar";
            this.btmFechar.Size = new System.Drawing.Size(245, 115);
            this.btmFechar.TabIndex = 6;
            this.btmFechar.Text = "Fechar";
            this.btmFechar.UseVisualStyleBackColor = true;
            // 
            // btmCalcular
            // 
            this.btmCalcular.Location = new System.Drawing.Point(130, 323);
            this.btmCalcular.Name = "btmCalcular";
            this.btmCalcular.Size = new System.Drawing.Size(235, 115);
            this.btmCalcular.TabIndex = 7;
            this.btmCalcular.Text = "Calcular";
            this.btmCalcular.UseVisualStyleBackColor = true;
            this.btmCalcular.Click += new System.EventHandler(this.btmCalcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1336, 696);
            this.Controls.Add(this.btmCalcular);
            this.Controls.Add(this.btmFechar);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.txtVolume);
            this.Controls.Add(this.txtRaio);
            this.Controls.Add(this.lblRaio);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.lblVolume);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVolume;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Label lblRaio;
        private System.Windows.Forms.TextBox txtRaio;
        private System.Windows.Forms.TextBox txtVolume;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.Button btmFechar;
        private System.Windows.Forms.Button btmCalcular;
    }
}

