namespace JoguinhoLixo
{
    partial class UsarItem
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
            System.Windows.Forms.Label label24;
            this.cbxItem = new System.Windows.Forms.ComboBox();
            this.btnUitem = new System.Windows.Forms.Button();
            label24 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            label24.Location = new System.Drawing.Point(32, 53);
            label24.Name = "label24";
            label24.Size = new System.Drawing.Size(236, 25);
            label24.TabIndex = 36;
            label24.Text = "Selecione um item:";
            // 
            // cbxItem
            // 
            this.cbxItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxItem.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxItem.FormattingEnabled = true;
            this.cbxItem.Location = new System.Drawing.Point(37, 100);
            this.cbxItem.MaxDropDownItems = 18;
            this.cbxItem.Name = "cbxItem";
            this.cbxItem.Size = new System.Drawing.Size(231, 24);
            this.cbxItem.TabIndex = 37;
            // 
            // btnUitem
            // 
            this.btnUitem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUitem.Location = new System.Drawing.Point(30, 487);
            this.btnUitem.Name = "btnUitem";
            this.btnUitem.Size = new System.Drawing.Size(238, 23);
            this.btnUitem.TabIndex = 38;
            this.btnUitem.Text = "Usar Item";
            this.btnUitem.UseVisualStyleBackColor = true;
            this.btnUitem.Click += new System.EventHandler(this.btnUitem_Click);
            // 
            // UsarItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 522);
            this.Controls.Add(this.btnUitem);
            this.Controls.Add(this.cbxItem);
            this.Controls.Add(label24);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UsarItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UsarItem";
            this.Load += new System.EventHandler(this.UsarItem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxItem;
        private System.Windows.Forms.Button btnUitem;
    }
}