namespace PTesteMetodos
{
    partial class frmExercicio3
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
            this.btn_inverte = new System.Windows.Forms.Button();
            this.btn_remove = new System.Windows.Forms.Button();
            this.lblpalavra2 = new System.Windows.Forms.Label();
            this.lblpalavra1 = new System.Windows.Forms.Label();
            this.txtpalavra2 = new System.Windows.Forms.TextBox();
            this.txtpalavra1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_inverte
            // 
            this.btn_inverte.Location = new System.Drawing.Point(498, 301);
            this.btn_inverte.Name = "btn_inverte";
            this.btn_inverte.Size = new System.Drawing.Size(116, 45);
            this.btn_inverte.TabIndex = 12;
            this.btn_inverte.Text = "INVERTE";
            this.btn_inverte.UseVisualStyleBackColor = true;
            this.btn_inverte.Click += new System.EventHandler(this.btn_inverte_Click);
            // 
            // btn_remove
            // 
            this.btn_remove.Location = new System.Drawing.Point(170, 301);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(116, 45);
            this.btn_remove.TabIndex = 11;
            this.btn_remove.Text = "REMOVE";
            this.btn_remove.UseVisualStyleBackColor = true;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // lblpalavra2
            // 
            this.lblpalavra2.AutoSize = true;
            this.lblpalavra2.Location = new System.Drawing.Point(167, 172);
            this.lblpalavra2.Name = "lblpalavra2";
            this.lblpalavra2.Size = new System.Drawing.Size(48, 13);
            this.lblpalavra2.TabIndex = 10;
            this.lblpalavra2.Text = "palavra2";
            // 
            // lblpalavra1
            // 
            this.lblpalavra1.AutoSize = true;
            this.lblpalavra1.Location = new System.Drawing.Point(164, 115);
            this.lblpalavra1.Name = "lblpalavra1";
            this.lblpalavra1.Size = new System.Drawing.Size(48, 13);
            this.lblpalavra1.TabIndex = 9;
            this.lblpalavra1.Text = "palavra1";
            // 
            // txtpalavra2
            // 
            this.txtpalavra2.Location = new System.Drawing.Point(253, 166);
            this.txtpalavra2.Name = "txtpalavra2";
            this.txtpalavra2.Size = new System.Drawing.Size(361, 20);
            this.txtpalavra2.TabIndex = 8;
            // 
            // txtpalavra1
            // 
            this.txtpalavra1.Location = new System.Drawing.Point(253, 109);
            this.txtpalavra1.Name = "txtpalavra1";
            this.txtpalavra1.Size = new System.Drawing.Size(361, 20);
            this.txtpalavra1.TabIndex = 7;
            // 
            // frmExercicio3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_inverte);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.lblpalavra2);
            this.Controls.Add(this.lblpalavra1);
            this.Controls.Add(this.txtpalavra2);
            this.Controls.Add(this.txtpalavra1);
            this.Name = "frmExercicio3";
            this.Text = "frmExercicio3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_inverte;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.Label lblpalavra2;
        private System.Windows.Forms.Label lblpalavra1;
        private System.Windows.Forms.TextBox txtpalavra2;
        private System.Windows.Forms.TextBox txtpalavra1;
    }
}