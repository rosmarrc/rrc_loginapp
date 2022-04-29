
namespace rrc_loginapp
{
    partial class Form2
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtusuarioREG = new System.Windows.Forms.TextBox();
            this.textCONT = new System.Windows.Forms.TextBox();
            this.registrar = new System.Windows.Forms.Button();
            this.ATRAS = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnSalir.Font = new System.Drawing.Font("Discoteca Rounded", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnSalir.Location = new System.Drawing.Point(734, 425);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(128, 60);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Discoteca Rounded", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.label1.Location = new System.Drawing.Point(219, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(447, 72);
            this.label1.TabIndex = 4;
            this.label1.Text = "REGISTRAR USUARIO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Discoteca Rounded", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.label2.Location = new System.Drawing.Point(240, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 51);
            this.label2.TabIndex = 7;
            this.label2.Text = "USUARIO:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Discoteca Rounded", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.label3.Location = new System.Drawing.Point(164, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(237, 51);
            this.label3.TabIndex = 6;
            this.label3.Text = "CONTRASEÑA:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtusuarioREG
            // 
            this.txtusuarioREG.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtusuarioREG.Font = new System.Drawing.Font("Discoteca Rounded", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusuarioREG.Location = new System.Drawing.Point(407, 185);
            this.txtusuarioREG.Name = "txtusuarioREG";
            this.txtusuarioREG.Size = new System.Drawing.Size(247, 52);
            this.txtusuarioREG.TabIndex = 8;
            // 
            // textCONT
            // 
            this.textCONT.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textCONT.Font = new System.Drawing.Font("Discoteca Rounded", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCONT.Location = new System.Drawing.Point(407, 247);
            this.textCONT.Name = "textCONT";
            this.textCONT.Size = new System.Drawing.Size(289, 52);
            this.textCONT.TabIndex = 9;
            // 
            // registrar
            // 
            this.registrar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.registrar.BackColor = System.Drawing.Color.LightSkyBlue;
            this.registrar.Font = new System.Drawing.Font("Discoteca Rounded", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.registrar.Location = new System.Drawing.Point(308, 305);
            this.registrar.Name = "registrar";
            this.registrar.Size = new System.Drawing.Size(222, 55);
            this.registrar.TabIndex = 10;
            this.registrar.Text = "REGISTRAR";
            this.registrar.UseVisualStyleBackColor = false;
            this.registrar.Click += new System.EventHandler(this.registrar_Click);
            // 
            // ATRAS
            // 
            this.ATRAS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ATRAS.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ATRAS.Font = new System.Drawing.Font("Discoteca Rounded", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ATRAS.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ATRAS.Location = new System.Drawing.Point(12, 425);
            this.ATRAS.Name = "ATRAS";
            this.ATRAS.Size = new System.Drawing.Size(222, 60);
            this.ATRAS.TabIndex = 11;
            this.ATRAS.Text = "Retroceder";
            this.ATRAS.UseVisualStyleBackColor = false;
            this.ATRAS.Click += new System.EventHandler(this.ATRAS_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(874, 497);
            this.Controls.Add(this.ATRAS);
            this.Controls.Add(this.registrar);
            this.Controls.Add(this.textCONT);
            this.Controls.Add(this.txtusuarioREG);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalir);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtusuarioREG;
        private System.Windows.Forms.TextBox textCONT;
        private System.Windows.Forms.Button registrar;
        private System.Windows.Forms.Button ATRAS;
    }
}