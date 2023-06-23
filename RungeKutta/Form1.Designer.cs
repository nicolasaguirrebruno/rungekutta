namespace RungeKutta
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
            this.dgvRunge = new System.Windows.Forms.DataGridView();
            this.Xi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Yi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.K1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.K2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.K3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.K4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ximas1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Yimas1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtH = new System.Windows.Forms.TextBox();
            this.lblH = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtXinicial = new System.Windows.Forms.TextBox();
            this.lblYfinal = new System.Windows.Forms.Label();
            this.txtYinicial = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFinalY = new System.Windows.Forms.TextBox();
            this.btnGenerateRunge = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRunge)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRunge
            // 
            this.dgvRunge.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRunge.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Xi,
            this.Yi,
            this.K1,
            this.K2,
            this.K3,
            this.K4,
            this.Ximas1,
            this.Yimas1});
            this.dgvRunge.Location = new System.Drawing.Point(52, 150);
            this.dgvRunge.Name = "dgvRunge";
            this.dgvRunge.RowHeadersWidth = 51;
            this.dgvRunge.RowTemplate.Height = 24;
            this.dgvRunge.Size = new System.Drawing.Size(1628, 687);
            this.dgvRunge.TabIndex = 0;
            // 
            // Xi
            // 
            this.Xi.HeaderText = "Xi";
            this.Xi.MinimumWidth = 6;
            this.Xi.Name = "Xi";
            this.Xi.Width = 125;
            // 
            // Yi
            // 
            this.Yi.HeaderText = "Yi";
            this.Yi.MinimumWidth = 6;
            this.Yi.Name = "Yi";
            this.Yi.Width = 125;
            // 
            // K1
            // 
            this.K1.HeaderText = "K1";
            this.K1.MinimumWidth = 6;
            this.K1.Name = "K1";
            this.K1.Width = 125;
            // 
            // K2
            // 
            this.K2.HeaderText = "K2";
            this.K2.MinimumWidth = 6;
            this.K2.Name = "K2";
            this.K2.Width = 125;
            // 
            // K3
            // 
            this.K3.HeaderText = "K3";
            this.K3.MinimumWidth = 6;
            this.K3.Name = "K3";
            this.K3.Width = 125;
            // 
            // K4
            // 
            this.K4.HeaderText = "K4";
            this.K4.MinimumWidth = 6;
            this.K4.Name = "K4";
            this.K4.Width = 125;
            // 
            // Ximas1
            // 
            this.Ximas1.HeaderText = "Xi+1";
            this.Ximas1.MinimumWidth = 6;
            this.Ximas1.Name = "Ximas1";
            this.Ximas1.Width = 125;
            // 
            // Yimas1
            // 
            this.Yimas1.HeaderText = "Yi+1";
            this.Yimas1.MinimumWidth = 6;
            this.Yimas1.Name = "Yimas1";
            this.Yimas1.Width = 125;
            // 
            // txtH
            // 
            this.txtH.Location = new System.Drawing.Point(157, 72);
            this.txtH.Name = "txtH";
            this.txtH.Size = new System.Drawing.Size(107, 22);
            this.txtH.TabIndex = 1;
            // 
            // lblH
            // 
            this.lblH.AutoSize = true;
            this.lblH.Location = new System.Drawing.Point(72, 75);
            this.lblH.Name = "lblH";
            this.lblH.Size = new System.Drawing.Size(79, 16);
            this.lblH.TabIndex = 2;
            this.lblH.Text = "Ingrese el H";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(305, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ingrese el X inicial";
            // 
            // txtXinicial
            // 
            this.txtXinicial.Location = new System.Drawing.Point(425, 72);
            this.txtXinicial.Name = "txtXinicial";
            this.txtXinicial.Size = new System.Drawing.Size(107, 22);
            this.txtXinicial.TabIndex = 3;
            // 
            // lblYfinal
            // 
            this.lblYfinal.AutoSize = true;
            this.lblYfinal.Location = new System.Drawing.Point(569, 75);
            this.lblYfinal.Name = "lblYfinal";
            this.lblYfinal.Size = new System.Drawing.Size(115, 16);
            this.lblYfinal.TabIndex = 6;
            this.lblYfinal.Text = "Ingrese el Y inicial";
            // 
            // txtYinicial
            // 
            this.txtYinicial.Location = new System.Drawing.Point(689, 72);
            this.txtYinicial.Name = "txtYinicial";
            this.txtYinicial.Size = new System.Drawing.Size(107, 22);
            this.txtYinicial.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(841, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Ingrese el valor de corte";
            // 
            // txtFinalY
            // 
            this.txtFinalY.Location = new System.Drawing.Point(998, 75);
            this.txtFinalY.Name = "txtFinalY";
            this.txtFinalY.Size = new System.Drawing.Size(107, 22);
            this.txtFinalY.TabIndex = 7;
            // 
            // btnGenerateRunge
            // 
            this.btnGenerateRunge.Location = new System.Drawing.Point(1172, 58);
            this.btnGenerateRunge.Name = "btnGenerateRunge";
            this.btnGenerateRunge.Size = new System.Drawing.Size(216, 51);
            this.btnGenerateRunge.TabIndex = 9;
            this.btnGenerateRunge.Text = "Generar Runge Kutta";
            this.btnGenerateRunge.UseVisualStyleBackColor = true;
            this.btnGenerateRunge.Click += new System.EventHandler(this.btnGenerateRunge_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1742, 849);
            this.Controls.Add(this.btnGenerateRunge);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFinalY);
            this.Controls.Add(this.lblYfinal);
            this.Controls.Add(this.txtYinicial);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtXinicial);
            this.Controls.Add(this.lblH);
            this.Controls.Add(this.txtH);
            this.Controls.Add(this.dgvRunge);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRunge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRunge;
        private System.Windows.Forms.DataGridViewTextBoxColumn Xi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Yi;
        private System.Windows.Forms.DataGridViewTextBoxColumn K1;
        private System.Windows.Forms.DataGridViewTextBoxColumn K2;
        private System.Windows.Forms.DataGridViewTextBoxColumn K3;
        private System.Windows.Forms.DataGridViewTextBoxColumn K4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ximas1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Yimas1;
        private System.Windows.Forms.TextBox txtH;
        private System.Windows.Forms.Label lblH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtXinicial;
        private System.Windows.Forms.Label lblYfinal;
        private System.Windows.Forms.TextBox txtYinicial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFinalY;
        private System.Windows.Forms.Button btnGenerateRunge;
    }
}

