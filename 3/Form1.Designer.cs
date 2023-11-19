namespace _3
{
    partial class Form1
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
            this.buttonoOnayla = new System.Windows.Forms.Button();
            this.labelDurum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonoOnayla
            // 
            this.buttonoOnayla.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonoOnayla.Location = new System.Drawing.Point(97, 47);
            this.buttonoOnayla.Name = "buttonoOnayla";
            this.buttonoOnayla.Size = new System.Drawing.Size(289, 96);
            this.buttonoOnayla.TabIndex = 0;
            this.buttonoOnayla.Text = "Onayla";
            this.buttonoOnayla.UseVisualStyleBackColor = true;
            this.buttonoOnayla.Click += new System.EventHandler(this.buttonoOnayla_Click);
            this.buttonoOnayla.MouseLeave += new System.EventHandler(this.buttonoOnayla_MouseLeave);
            this.buttonoOnayla.MouseHover += new System.EventHandler(this.buttonoOnayla_MouseHover);
            // 
            // labelDurum
            // 
            this.labelDurum.AutoSize = true;
            this.labelDurum.Location = new System.Drawing.Point(203, 213);
            this.labelDurum.Name = "labelDurum";
            this.labelDurum.Size = new System.Drawing.Size(0, 20);
            this.labelDurum.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelDurum);
            this.Controls.Add(this.buttonoOnayla);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonoOnayla;
        private System.Windows.Forms.Label labelDurum;
    }
}

