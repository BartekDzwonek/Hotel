namespace Hotel
{
    partial class Form5
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.but_edit = new System.Windows.Forms.Button();
            this.but_czysc = new System.Windows.Forms.Button();
            this.but_usun = new System.Windows.Forms.Button();
            this.but_zapisz = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 372);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 66);
            this.button1.TabIndex = 2;
            this.button1.Text = "Wróć";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(462, 150);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 19;
            // 
            // but_edit
            // 
            this.but_edit.Location = new System.Drawing.Point(98, 222);
            this.but_edit.Margin = new System.Windows.Forms.Padding(4);
            this.but_edit.Name = "but_edit";
            this.but_edit.Size = new System.Drawing.Size(100, 28);
            this.but_edit.TabIndex = 18;
            this.but_edit.Text = "Edytuj";
            this.but_edit.UseVisualStyleBackColor = true;
            // 
            // but_czysc
            // 
            this.but_czysc.Location = new System.Drawing.Point(218, 222);
            this.but_czysc.Margin = new System.Windows.Forms.Padding(4);
            this.but_czysc.Name = "but_czysc";
            this.but_czysc.Size = new System.Drawing.Size(100, 28);
            this.but_czysc.TabIndex = 17;
            this.but_czysc.Text = "Wyczyść";
            this.but_czysc.UseVisualStyleBackColor = true;
            // 
            // but_usun
            // 
            this.but_usun.Location = new System.Drawing.Point(218, 177);
            this.but_usun.Margin = new System.Windows.Forms.Padding(4);
            this.but_usun.Name = "but_usun";
            this.but_usun.Size = new System.Drawing.Size(100, 28);
            this.but_usun.TabIndex = 16;
            this.but_usun.Text = "Usuń";
            this.but_usun.UseVisualStyleBackColor = true;
            // 
            // but_zapisz
            // 
            this.but_zapisz.Location = new System.Drawing.Point(98, 177);
            this.but_zapisz.Margin = new System.Windows.Forms.Padding(4);
            this.but_zapisz.Name = "but_zapisz";
            this.but_zapisz.Size = new System.Drawing.Size(100, 28);
            this.but_zapisz.TabIndex = 15;
            this.but_zapisz.Text = "Zapisz";
            this.but_zapisz.UseVisualStyleBackColor = true;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.but_edit);
            this.Controls.Add(this.but_czysc);
            this.Controls.Add(this.but_usun);
            this.Controls.Add(this.but_zapisz);
            this.Controls.Add(this.button1);
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rezerwacje";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button but_edit;
        private System.Windows.Forms.Button but_czysc;
        private System.Windows.Forms.Button but_usun;
        private System.Windows.Forms.Button but_zapisz;
    }
}