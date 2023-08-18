
namespace DuDesk
{
    partial class Fbase
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
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Image = global::DuDesk.Properties.Resources.export_24px;
            this.BtnCancelar.Location = new System.Drawing.Point(244, 278);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(89, 32);
            this.BtnCancelar.TabIndex = 0;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // Fbase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 355);
            this.Controls.Add(this.BtnCancelar);
            this.Name = "Fbase";
            this.Text = "Fbase";
            this.Load += new System.EventHandler(this.Fbase_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FBase_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button BtnCancelar;
    }
}