namespace Polimorfismo_Gia2_5826347
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEstudiante = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEva1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEva2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEva3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtActitudinal = new System.Windows.Forms.TextBox();
            this.btnNuevoDato = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.lvlnformacion = new System.Windows.Forms.ListView();
            this.lbResumen = new System.Windows.Forms.ListBox();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(391, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CONTROL DE EVALUACIOES- PROGRAMACION 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "DATOS DEL ALUMNO";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "ESTUDIANTE";
            this.label3.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtEstudiante
            // 
            this.txtEstudiante.Location = new System.Drawing.Point(46, 130);
            this.txtEstudiante.Name = "txtEstudiante";
            this.txtEstudiante.Size = new System.Drawing.Size(292, 20);
            this.txtEstudiante.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(381, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "EVA.1";
            this.label4.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtEva1
            // 
            this.txtEva1.Location = new System.Drawing.Point(372, 130);
            this.txtEva1.Name = "txtEva1";
            this.txtEva1.Size = new System.Drawing.Size(46, 20);
            this.txtEva1.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(452, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "EVA.2";
            this.label5.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtEva2
            // 
            this.txtEva2.Location = new System.Drawing.Point(443, 130);
            this.txtEva2.Name = "txtEva2";
            this.txtEva2.Size = new System.Drawing.Size(46, 20);
            this.txtEva2.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(534, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "EVA.3";
            this.label6.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtEva3
            // 
            this.txtEva3.Location = new System.Drawing.Point(525, 130);
            this.txtEva3.Name = "txtEva3";
            this.txtEva3.Size = new System.Drawing.Size(46, 20);
            this.txtEva3.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(628, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "ACTITUDINAL";
            this.label7.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtActitudinal
            // 
            this.txtActitudinal.Location = new System.Drawing.Point(618, 130);
            this.txtActitudinal.Name = "txtActitudinal";
            this.txtActitudinal.Size = new System.Drawing.Size(100, 20);
            this.txtActitudinal.TabIndex = 2;
            // 
            // btnNuevoDato
            // 
            this.btnNuevoDato.Location = new System.Drawing.Point(775, 87);
            this.btnNuevoDato.Name = "btnNuevoDato";
            this.btnNuevoDato.Size = new System.Drawing.Size(122, 23);
            this.btnNuevoDato.TabIndex = 3;
            this.btnNuevoDato.Text = "NUEVO DATO";
            this.btnNuevoDato.UseVisualStyleBackColor = true;
            this.btnNuevoDato.Click += new System.EventHandler(this.btnNuevoDato_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(775, 128);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(122, 23);
            this.btnRegistrar.TabIndex = 3;
            this.btnRegistrar.Text = "REGISTRAR";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // lvlnformacion
            // 
            this.lvlnformacion.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lvlnformacion.HideSelection = false;
            this.lvlnformacion.Location = new System.Drawing.Point(46, 177);
            this.lvlnformacion.Name = "lvlnformacion";
            this.lvlnformacion.Size = new System.Drawing.Size(851, 136);
            this.lvlnformacion.TabIndex = 4;
            this.lvlnformacion.UseCompatibleStateImageBehavior = false;
            this.lvlnformacion.View = System.Windows.Forms.View.Details;
            // 
            // lbResumen
            // 
            this.lbResumen.FormattingEnabled = true;
            this.lbResumen.Location = new System.Drawing.Point(46, 336);
            this.lbResumen.Name = "lbResumen";
            this.lbResumen.Size = new System.Drawing.Size(851, 95);
            this.lbResumen.TabIndex = 5;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ESTUDIANTE";
            this.columnHeader1.Width = 157;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "EVA 1";
            this.columnHeader2.Width = 111;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "EVA 2";
            this.columnHeader3.Width = 82;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "EVA 3";
            this.columnHeader4.Width = 104;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "ACTITUDINAL";
            this.columnHeader5.Width = 131;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "PROMEDIO";
            this.columnHeader6.Width = 167;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "CONDICION";
            this.columnHeader7.Width = 91;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 525);
            this.Controls.Add(this.lbResumen);
            this.Controls.Add(this.lvlnformacion);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.btnNuevoDato);
            this.Controls.Add(this.txtActitudinal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtEva3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtEva2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEva1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEstudiante);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEstudiante;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEva1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEva2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEva3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtActitudinal;
        private System.Windows.Forms.Button btnNuevoDato;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.ListView lvlnformacion;
        private System.Windows.Forms.ListBox lbResumen;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
    }
}

