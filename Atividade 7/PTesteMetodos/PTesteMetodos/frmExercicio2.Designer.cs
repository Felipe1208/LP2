namespace PTesteMetodos
{
    partial class frmExercicio2
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
            this.txtpalavra1 = new System.Windows.Forms.TextBox();
            this.txtpalavra2 = new System.Windows.Forms.TextBox();
            this.lblpalavra1 = new System.Windows.Forms.Label();
            this.lblpalavra2 = new System.Windows.Forms.Label();
            this.btn_compara = new System.Windows.Forms.Button();
            this.btn_insere1 = new System.Windows.Forms.Button();
            this.btn_insere2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtpalavra1
            // 
            this.txtpalavra1.Location = new System.Drawing.Point(198, 68);
            this.txtpalavra1.Name = "txtpalavra1";
            this.txtpalavra1.Size = new System.Drawing.Size(361, 20);
            this.txtpalavra1.TabIndex = 0;
            // 
            // txtpalavra2
            // 
            this.txtpalavra2.Location = new System.Drawing.Point(198, 125);
            this.txtpalavra2.Name = "txtpalavra2";
            this.txtpalavra2.Size = new System.Drawing.Size(361, 20);
            this.txtpalavra2.TabIndex = 1;
            // 
            // lblpalavra1
            // 
            this.lblpalavra1.AutoSize = true;
            this.lblpalavra1.Location = new System.Drawing.Point(109, 74);
            this.lblpalavra1.Name = "lblpalavra1";
            this.lblpalavra1.Size = new System.Drawing.Size(48, 13);
            this.lblpalavra1.TabIndex = 2;
            this.lblpalavra1.Text = "palavra1";
            // 
            // lblpalavra2
            // 
            this.lblpalavra2.AutoSize = true;
            this.lblpalavra2.Location = new System.Drawing.Point(112, 131);
            this.lblpalavra2.Name = "lblpalavra2";
            this.lblpalavra2.Size = new System.Drawing.Size(48, 13);
            this.lblpalavra2.TabIndex = 3;
            this.lblpalavra2.Text = "palavra2";
            // 
            // btn_compara
            // 
            this.btn_compara.Location = new System.Drawing.Point(165, 277);
            this.btn_compara.Name = "btn_compara";
            this.btn_compara.Size = new System.Drawing.Size(75, 23);
            this.btn_compara.TabIndex = 4;
            this.btn_compara.Text = "COMPARA";
            this.btn_compara.UseVisualStyleBackColor = true;
            this.btn_compara.Click += new System.EventHandler(this.btn_compara_Click);
            // 
            // btn_insere1
            // 
            this.btn_insere1.Location = new System.Drawing.Point(338, 277);
            this.btn_insere1.Name = "btn_insere1";
            this.btn_insere1.Size = new System.Drawing.Size(75, 23);
            this.btn_insere1.TabIndex = 5;
            this.btn_insere1.Text = "button2";
            this.btn_insere1.UseVisualStyleBackColor = true;
            this.btn_insere1.Click += new System.EventHandler(this.btn_insere1_Click);
            // 
            // btn_insere2
            // 
            this.btn_insere2.Location = new System.Drawing.Point(507, 277);
            this.btn_insere2.Name = "btn_insere2";
            this.btn_insere2.Size = new System.Drawing.Size(75, 23);
            this.btn_insere2.TabIndex = 6;
            this.btn_insere2.Text = "button3";
            this.btn_insere2.UseVisualStyleBackColor = true;
            this.btn_insere2.Click += new System.EventHandler(this.btn_insere2_Click);
            // 
            // frmExercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_insere2);
            this.Controls.Add(this.btn_insere1);
            this.Controls.Add(this.btn_compara);
            this.Controls.Add(this.lblpalavra2);
            this.Controls.Add(this.lblpalavra1);
            this.Controls.Add(this.txtpalavra2);
            this.Controls.Add(this.txtpalavra1);
            this.Name = "frmExercicio2";
            this.Text = "frmExercicio2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtpalavra1;
        private System.Windows.Forms.TextBox txtpalavra2;
        private System.Windows.Forms.Label lblpalavra1;
        private System.Windows.Forms.Label lblpalavra2;
        private System.Windows.Forms.Button btn_compara;
        private System.Windows.Forms.Button btn_insere1;
        private System.Windows.Forms.Button btn_insere2;
    }
}