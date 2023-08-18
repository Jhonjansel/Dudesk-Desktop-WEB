
namespace DuDesk
{
    partial class F_Usuarios
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
            this.lb_id = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.cbNivel = new System.Windows.Forms.ComboBox();
            this.tb_Clave = new System.Windows.Forms.TextBox();
            this.tb_Usuario = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbEmpleado = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(302, 346);
            // 
            // lb_id
            // 
            this.lb_id.AutoSize = true;
            this.lb_id.Location = new System.Drawing.Point(374, 46);
            this.lb_id.Name = "lb_id";
            this.lb_id.Size = new System.Drawing.Size(0, 13);
            this.lb_id.TabIndex = 50;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = global::DuDesk.Properties.Resources.save_24px;
            this.btnGuardar.Location = new System.Drawing.Point(79, 346);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(95, 32);
            this.btnGuardar.TabIndex = 49;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // cbEstado
            // 
            this.cbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstado.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Items.AddRange(new object[] {
            "Seleccionar"});
            this.cbEstado.Location = new System.Drawing.Point(79, 274);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(312, 25);
            this.cbEstado.TabIndex = 44;
            // 
            // cbNivel
            // 
            this.cbNivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNivel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNivel.FormattingEnabled = true;
            this.cbNivel.Location = new System.Drawing.Point(79, 216);
            this.cbNivel.Name = "cbNivel";
            this.cbNivel.Size = new System.Drawing.Size(312, 25);
            this.cbNivel.TabIndex = 43;
            // 
            // tb_Clave
            // 
            this.tb_Clave.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Clave.Location = new System.Drawing.Point(236, 160);
            this.tb_Clave.Name = "tb_Clave";
            this.tb_Clave.Size = new System.Drawing.Size(155, 25);
            this.tb_Clave.TabIndex = 42;
            // 
            // tb_Usuario
            // 
            this.tb_Usuario.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Usuario.Location = new System.Drawing.Point(79, 160);
            this.tb_Usuario.Name = "tb_Usuario";
            this.tb_Usuario.Size = new System.Drawing.Size(139, 25);
            this.tb_Usuario.TabIndex = 41;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(76, 258);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 17);
            this.label11.TabIndex = 36;
            this.label11.Text = "Estado";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(76, 200);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 17);
            this.label10.TabIndex = 35;
            this.label10.Text = "Nivel";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(233, 144);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 17);
            this.label9.TabIndex = 34;
            this.label9.Text = "Clave";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(76, 144);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 17);
            this.label8.TabIndex = 33;
            this.label8.Text = "Usuario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(136, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 25);
            this.label1.TabIndex = 27;
            this.label1.Text = "AGREGAR USUARIO";
            // 
            // cbEmpleado
            // 
            this.cbEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbEmpleado.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEmpleado.FormattingEnabled = true;
            this.cbEmpleado.Location = new System.Drawing.Point(79, 105);
            this.cbEmpleado.Name = "cbEmpleado";
            this.cbEmpleado.Size = new System.Drawing.Size(312, 25);
            this.cbEmpleado.TabIndex = 52;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(76, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 51;
            this.label4.Text = "Empleado";
            // 
            // F_Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 415);
            this.Controls.Add(this.cbEmpleado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lb_id);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.cbNivel);
            this.Controls.Add(this.tb_Clave);
            this.Controls.Add(this.tb_Usuario);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "F_Usuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_Usuarios";
     
            this.Controls.SetChildIndex(this.BtnCancelar, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.label11, 0);
            this.Controls.SetChildIndex(this.tb_Usuario, 0);
            this.Controls.SetChildIndex(this.tb_Clave, 0);
            this.Controls.SetChildIndex(this.cbNivel, 0);
            this.Controls.SetChildIndex(this.cbEstado, 0);
            this.Controls.SetChildIndex(this.btnGuardar, 0);
            this.Controls.SetChildIndex(this.lb_id, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.cbEmpleado, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lb_id;
        private System.Windows.Forms.Button btnGuardar;
        public System.Windows.Forms.ComboBox cbEstado;
        public System.Windows.Forms.ComboBox cbNivel;
        public System.Windows.Forms.TextBox tb_Clave;
        public System.Windows.Forms.TextBox tb_Usuario;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox cbEmpleado;
        private System.Windows.Forms.Label label4;
    }
}