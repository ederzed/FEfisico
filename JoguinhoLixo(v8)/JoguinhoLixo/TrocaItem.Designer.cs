namespace JoguinhoLixo
{
    partial class TrocaItem
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
            this.llbxDoador = new System.Windows.Forms.ListBox();
            this.lbxReceptor = new System.Windows.Forms.ListBox();
            this.btnTrocar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // llbxDoador
            // 
            this.llbxDoador.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbxDoador.FormattingEnabled = true;
            this.llbxDoador.ItemHeight = 14;
            this.llbxDoador.Location = new System.Drawing.Point(12, 12);
            this.llbxDoador.Name = "llbxDoador";
            this.llbxDoador.Size = new System.Drawing.Size(293, 144);
            this.llbxDoador.TabIndex = 0;
            // 
            // lbxReceptor
            // 
            this.lbxReceptor.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxReceptor.FormattingEnabled = true;
            this.lbxReceptor.ItemHeight = 14;
            this.lbxReceptor.Location = new System.Drawing.Point(12, 249);
            this.lbxReceptor.Name = "lbxReceptor";
            this.lbxReceptor.Size = new System.Drawing.Size(293, 144);
            this.lbxReceptor.TabIndex = 1;
            // 
            // btnTrocar
            // 
            this.btnTrocar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrocar.Location = new System.Drawing.Point(37, 198);
            this.btnTrocar.Name = "btnTrocar";
            this.btnTrocar.Size = new System.Drawing.Size(238, 23);
            this.btnTrocar.TabIndex = 39;
            this.btnTrocar.Text = "Trocar";
            this.btnTrocar.UseVisualStyleBackColor = true;
            this.btnTrocar.Click += new System.EventHandler(this.btnTrocar_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(37, 450);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(238, 23);
            this.button1.TabIndex = 40;
            this.button1.Text = "Terminar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TrocaItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 522);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnTrocar);
            this.Controls.Add(this.lbxReceptor);
            this.Controls.Add(this.llbxDoador);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TrocaItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TrocaItem";
            this.Load += new System.EventHandler(this.TrocaItem_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox llbxDoador;
        private System.Windows.Forms.ListBox lbxReceptor;
        private System.Windows.Forms.Button btnTrocar;
        private System.Windows.Forms.Button button1;
    }
}