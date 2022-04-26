
namespace msfs2020_updates_disabler
{
    partial class DisablerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DisablerForm));
            this.warningLabel = new System.Windows.Forms.Label();
            this.magicButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // warningLabel
            // 
            this.warningLabel.AutoSize = true;
            this.warningLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warningLabel.Location = new System.Drawing.Point(11, 69);
            this.warningLabel.Name = "warningLabel";
            this.warningLabel.Size = new System.Drawing.Size(285, 26);
            this.warningLabel.TabIndex = 0;
            this.warningLabel.Text = "Warning: This can affect other Xbox Live games.\r\nEnable updates again after using" +
    " the simulator.";
            this.warningLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // magicButton
            // 
            this.magicButton.BackColor = System.Drawing.Color.DarkRed;
            this.magicButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.magicButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.magicButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.magicButton.ForeColor = System.Drawing.Color.White;
            this.magicButton.Location = new System.Drawing.Point(12, 12);
            this.magicButton.Name = "magicButton";
            this.magicButton.Size = new System.Drawing.Size(284, 43);
            this.magicButton.TabIndex = 2;
            this.magicButton.Text = "DISABLE UPDATES";
            this.magicButton.UseVisualStyleBackColor = false;
            this.magicButton.Click += new System.EventHandler(this.magicButton_Click);
            // 
            // DisablerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 109);
            this.Controls.Add(this.magicButton);
            this.Controls.Add(this.warningLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DisablerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MSFS 2020 Updates Disabler";
            this.Load += new System.EventHandler(this.DisablerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label warningLabel;
        private System.Windows.Forms.Button magicButton;
    }
}

