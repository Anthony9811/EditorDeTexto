namespace EditorDeTexto
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
            this.txtCuadroDeTexto = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.convertirTodasLasLetrasEnMinusculasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.convertirTodoAMayusculasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.letrasDelPárrafoAMinusculasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.letrasDelPárrafoAMayúsculasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.primerLetraEnMinusculaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.primerLetraEnMayúsculaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reemplazarPalabraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reemplazarPalabraEnEspecíficoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cantidadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cantidadTotalDePalabrasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cantidadDePalabrasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cantidadDeLetrasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cantidadDeLetrasEnPárrafoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vecesQueSeRepiteUnaPalabraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vecesQueSeRepitePalabraEnElPárrafoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblPalabraNueva = new System.Windows.Forms.Label();
            this.txtPalabraNueva = new System.Windows.Forms.TextBox();
            this.btnReemplazar = new System.Windows.Forms.Button();
            this.lblPalabraABuscar = new System.Windows.Forms.Label();
            this.txtPalabraRepetidaABuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblPalabraABuscarEnParrafo = new System.Windows.Forms.Label();
            this.txtPalabraABuscarEnElParrafo = new System.Windows.Forms.TextBox();
            this.btnBuscarRepetidaEnParrafo = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCuadroDeTexto
            // 
            this.txtCuadroDeTexto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCuadroDeTexto.Location = new System.Drawing.Point(0, 27);
            this.txtCuadroDeTexto.Name = "txtCuadroDeTexto";
            this.txtCuadroDeTexto.Size = new System.Drawing.Size(800, 338);
            this.txtCuadroDeTexto.TabIndex = 0;
            this.txtCuadroDeTexto.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aaToolStripMenuItem,
            this.reemplazarPalabraToolStripMenuItem,
            this.cantidadToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aaToolStripMenuItem
            // 
            this.aaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.convertirTodasLasLetrasEnMinusculasToolStripMenuItem,
            this.convertirTodoAMayusculasToolStripMenuItem,
            this.letrasDelPárrafoAMinusculasToolStripMenuItem,
            this.letrasDelPárrafoAMayúsculasToolStripMenuItem,
            this.primerLetraEnMinusculaToolStripMenuItem,
            this.primerLetraEnMayúsculaToolStripMenuItem});
            this.aaToolStripMenuItem.Name = "aaToolStripMenuItem";
            this.aaToolStripMenuItem.Size = new System.Drawing.Size(33, 20);
            this.aaToolStripMenuItem.Text = "Aa";
            // 
            // convertirTodasLasLetrasEnMinusculasToolStripMenuItem
            // 
            this.convertirTodasLasLetrasEnMinusculasToolStripMenuItem.Name = "convertirTodasLasLetrasEnMinusculasToolStripMenuItem";
            this.convertirTodasLasLetrasEnMinusculasToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.convertirTodasLasLetrasEnMinusculasToolStripMenuItem.Text = "Convertir todo a minusculas";
            this.convertirTodasLasLetrasEnMinusculasToolStripMenuItem.Click += new System.EventHandler(this.convertirTodasLasLetrasEnMinusculasToolStripMenuItem_Click);
            // 
            // convertirTodoAMayusculasToolStripMenuItem
            // 
            this.convertirTodoAMayusculasToolStripMenuItem.Name = "convertirTodoAMayusculasToolStripMenuItem";
            this.convertirTodoAMayusculasToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.convertirTodoAMayusculasToolStripMenuItem.Text = "Convertir todo a mayusculas";
            this.convertirTodoAMayusculasToolStripMenuItem.Click += new System.EventHandler(this.convertirTodoAMayusculasToolStripMenuItem_Click);
            // 
            // letrasDelPárrafoAMinusculasToolStripMenuItem
            // 
            this.letrasDelPárrafoAMinusculasToolStripMenuItem.Name = "letrasDelPárrafoAMinusculasToolStripMenuItem";
            this.letrasDelPárrafoAMinusculasToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.letrasDelPárrafoAMinusculasToolStripMenuItem.Text = "Letras del párrafo a minusculas";
            this.letrasDelPárrafoAMinusculasToolStripMenuItem.Click += new System.EventHandler(this.letrasDelPárrafoAMinusculasToolStripMenuItem_Click);
            // 
            // letrasDelPárrafoAMayúsculasToolStripMenuItem
            // 
            this.letrasDelPárrafoAMayúsculasToolStripMenuItem.Name = "letrasDelPárrafoAMayúsculasToolStripMenuItem";
            this.letrasDelPárrafoAMayúsculasToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.letrasDelPárrafoAMayúsculasToolStripMenuItem.Text = "Letras del párrafo a mayúsculas";
            this.letrasDelPárrafoAMayúsculasToolStripMenuItem.Click += new System.EventHandler(this.letrasDelPárrafoAMayúsculasToolStripMenuItem_Click);
            // 
            // primerLetraEnMinusculaToolStripMenuItem
            // 
            this.primerLetraEnMinusculaToolStripMenuItem.Name = "primerLetraEnMinusculaToolStripMenuItem";
            this.primerLetraEnMinusculaToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.primerLetraEnMinusculaToolStripMenuItem.Text = "Primer letra en minuscula";
            this.primerLetraEnMinusculaToolStripMenuItem.Click += new System.EventHandler(this.primerLetraEnMinusculaToolStripMenuItem_Click);
            // 
            // primerLetraEnMayúsculaToolStripMenuItem
            // 
            this.primerLetraEnMayúsculaToolStripMenuItem.Name = "primerLetraEnMayúsculaToolStripMenuItem";
            this.primerLetraEnMayúsculaToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.primerLetraEnMayúsculaToolStripMenuItem.Text = "Primer letra en mayúscula";
            this.primerLetraEnMayúsculaToolStripMenuItem.Click += new System.EventHandler(this.primerLetraEnMayúsculaToolStripMenuItem_Click);
            // 
            // reemplazarPalabraToolStripMenuItem
            // 
            this.reemplazarPalabraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reemplazarPalabraEnEspecíficoToolStripMenuItem});
            this.reemplazarPalabraToolStripMenuItem.Name = "reemplazarPalabraToolStripMenuItem";
            this.reemplazarPalabraToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.reemplazarPalabraToolStripMenuItem.Text = "Reemplazar";
            // 
            // reemplazarPalabraEnEspecíficoToolStripMenuItem
            // 
            this.reemplazarPalabraEnEspecíficoToolStripMenuItem.Name = "reemplazarPalabraEnEspecíficoToolStripMenuItem";
            this.reemplazarPalabraEnEspecíficoToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.reemplazarPalabraEnEspecíficoToolStripMenuItem.Text = "Reemplazar palabra en específico";
            this.reemplazarPalabraEnEspecíficoToolStripMenuItem.Click += new System.EventHandler(this.reemplazarPalabraEnEspecíficoToolStripMenuItem_Click);
            // 
            // cantidadToolStripMenuItem
            // 
            this.cantidadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cantidadTotalDePalabrasToolStripMenuItem,
            this.cantidadDePalabrasToolStripMenuItem,
            this.cantidadDeLetrasToolStripMenuItem,
            this.cantidadDeLetrasEnPárrafoToolStripMenuItem,
            this.vecesQueSeRepiteUnaPalabraToolStripMenuItem,
            this.vecesQueSeRepitePalabraEnElPárrafoToolStripMenuItem});
            this.cantidadToolStripMenuItem.Name = "cantidadToolStripMenuItem";
            this.cantidadToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.cantidadToolStripMenuItem.Text = "Cantidad";
            // 
            // cantidadTotalDePalabrasToolStripMenuItem
            // 
            this.cantidadTotalDePalabrasToolStripMenuItem.Name = "cantidadTotalDePalabrasToolStripMenuItem";
            this.cantidadTotalDePalabrasToolStripMenuItem.Size = new System.Drawing.Size(284, 22);
            this.cantidadTotalDePalabrasToolStripMenuItem.Text = "Cantidad total de palabras";
            this.cantidadTotalDePalabrasToolStripMenuItem.Click += new System.EventHandler(this.cantidadTotalDePalabrasToolStripMenuItem_Click);
            // 
            // cantidadDePalabrasToolStripMenuItem
            // 
            this.cantidadDePalabrasToolStripMenuItem.Name = "cantidadDePalabrasToolStripMenuItem";
            this.cantidadDePalabrasToolStripMenuItem.Size = new System.Drawing.Size(284, 22);
            this.cantidadDePalabrasToolStripMenuItem.Text = "Cantidad de palabras en párrafo";
            this.cantidadDePalabrasToolStripMenuItem.Click += new System.EventHandler(this.cantidadDePalabrasToolStripMenuItem_Click);
            // 
            // cantidadDeLetrasToolStripMenuItem
            // 
            this.cantidadDeLetrasToolStripMenuItem.Name = "cantidadDeLetrasToolStripMenuItem";
            this.cantidadDeLetrasToolStripMenuItem.Size = new System.Drawing.Size(284, 22);
            this.cantidadDeLetrasToolStripMenuItem.Text = "Cantidad de letras";
            this.cantidadDeLetrasToolStripMenuItem.Click += new System.EventHandler(this.cantidadDeLetrasToolStripMenuItem_Click);
            // 
            // cantidadDeLetrasEnPárrafoToolStripMenuItem
            // 
            this.cantidadDeLetrasEnPárrafoToolStripMenuItem.Name = "cantidadDeLetrasEnPárrafoToolStripMenuItem";
            this.cantidadDeLetrasEnPárrafoToolStripMenuItem.Size = new System.Drawing.Size(284, 22);
            this.cantidadDeLetrasEnPárrafoToolStripMenuItem.Text = "Cantidad de letras en párrafo";
            this.cantidadDeLetrasEnPárrafoToolStripMenuItem.Click += new System.EventHandler(this.cantidadDeLetrasEnPárrafoToolStripMenuItem_Click);
            // 
            // vecesQueSeRepiteUnaPalabraToolStripMenuItem
            // 
            this.vecesQueSeRepiteUnaPalabraToolStripMenuItem.Name = "vecesQueSeRepiteUnaPalabraToolStripMenuItem";
            this.vecesQueSeRepiteUnaPalabraToolStripMenuItem.Size = new System.Drawing.Size(284, 22);
            this.vecesQueSeRepiteUnaPalabraToolStripMenuItem.Text = "Veces que se repite una palabra";
            this.vecesQueSeRepiteUnaPalabraToolStripMenuItem.Click += new System.EventHandler(this.vecesQueSeRepiteUnaPalabraToolStripMenuItem_Click);
            // 
            // vecesQueSeRepitePalabraEnElPárrafoToolStripMenuItem
            // 
            this.vecesQueSeRepitePalabraEnElPárrafoToolStripMenuItem.Name = "vecesQueSeRepitePalabraEnElPárrafoToolStripMenuItem";
            this.vecesQueSeRepitePalabraEnElPárrafoToolStripMenuItem.Size = new System.Drawing.Size(284, 22);
            this.vecesQueSeRepitePalabraEnElPárrafoToolStripMenuItem.Text = "Veces que se repite palabra en el párrafo";
            this.vecesQueSeRepitePalabraEnElPárrafoToolStripMenuItem.Click += new System.EventHandler(this.vecesQueSeRepitePalabraEnElPárrafoToolStripMenuItem_Click);
            // 
            // lblPalabraNueva
            // 
            this.lblPalabraNueva.AutoSize = true;
            this.lblPalabraNueva.Location = new System.Drawing.Point(126, 383);
            this.lblPalabraNueva.Name = "lblPalabraNueva";
            this.lblPalabraNueva.Size = new System.Drawing.Size(79, 13);
            this.lblPalabraNueva.TabIndex = 2;
            this.lblPalabraNueva.Text = "Palabra nueva:";
            this.lblPalabraNueva.Visible = false;
            // 
            // txtPalabraNueva
            // 
            this.txtPalabraNueva.Location = new System.Drawing.Point(115, 399);
            this.txtPalabraNueva.Name = "txtPalabraNueva";
            this.txtPalabraNueva.Size = new System.Drawing.Size(100, 20);
            this.txtPalabraNueva.TabIndex = 3;
            this.txtPalabraNueva.Visible = false;
            // 
            // btnReemplazar
            // 
            this.btnReemplazar.Location = new System.Drawing.Point(130, 425);
            this.btnReemplazar.Name = "btnReemplazar";
            this.btnReemplazar.Size = new System.Drawing.Size(75, 23);
            this.btnReemplazar.TabIndex = 4;
            this.btnReemplazar.Text = "Reemplazar";
            this.btnReemplazar.UseVisualStyleBackColor = true;
            this.btnReemplazar.Visible = false;
            this.btnReemplazar.Click += new System.EventHandler(this.btnReemplazar_Click);
            // 
            // lblPalabraABuscar
            // 
            this.lblPalabraABuscar.AutoSize = true;
            this.lblPalabraABuscar.Location = new System.Drawing.Point(341, 383);
            this.lblPalabraABuscar.Name = "lblPalabraABuscar";
            this.lblPalabraABuscar.Size = new System.Drawing.Size(131, 13);
            this.lblPalabraABuscar.TabIndex = 5;
            this.lblPalabraABuscar.Text = "Palabra repetida a buscar:";
            this.lblPalabraABuscar.Visible = false;
            // 
            // txtPalabraRepetidaABuscar
            // 
            this.txtPalabraRepetidaABuscar.Location = new System.Drawing.Point(355, 399);
            this.txtPalabraRepetidaABuscar.Name = "txtPalabraRepetidaABuscar";
            this.txtPalabraRepetidaABuscar.Size = new System.Drawing.Size(100, 20);
            this.txtPalabraRepetidaABuscar.TabIndex = 6;
            this.txtPalabraRepetidaABuscar.Visible = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(368, 425);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 7;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Visible = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblPalabraABuscarEnParrafo
            // 
            this.lblPalabraABuscarEnParrafo.AutoSize = true;
            this.lblPalabraABuscarEnParrafo.Location = new System.Drawing.Point(577, 383);
            this.lblPalabraABuscarEnParrafo.Name = "lblPalabraABuscarEnParrafo";
            this.lblPalabraABuscarEnParrafo.Size = new System.Drawing.Size(182, 13);
            this.lblPalabraABuscarEnParrafo.TabIndex = 8;
            this.lblPalabraABuscarEnParrafo.Text = "Palabra repetida a buscar en párrafo:";
            this.lblPalabraABuscarEnParrafo.Visible = false;
            // 
            // txtPalabraABuscarEnElParrafo
            // 
            this.txtPalabraABuscarEnElParrafo.Location = new System.Drawing.Point(613, 399);
            this.txtPalabraABuscarEnElParrafo.Name = "txtPalabraABuscarEnElParrafo";
            this.txtPalabraABuscarEnElParrafo.Size = new System.Drawing.Size(100, 20);
            this.txtPalabraABuscarEnElParrafo.TabIndex = 9;
            this.txtPalabraABuscarEnElParrafo.Visible = false;
            // 
            // btnBuscarRepetidaEnParrafo
            // 
            this.btnBuscarRepetidaEnParrafo.Location = new System.Drawing.Point(626, 425);
            this.btnBuscarRepetidaEnParrafo.Name = "btnBuscarRepetidaEnParrafo";
            this.btnBuscarRepetidaEnParrafo.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarRepetidaEnParrafo.TabIndex = 10;
            this.btnBuscarRepetidaEnParrafo.Text = "Buscar";
            this.btnBuscarRepetidaEnParrafo.UseVisualStyleBackColor = true;
            this.btnBuscarRepetidaEnParrafo.Visible = false;
            this.btnBuscarRepetidaEnParrafo.Click += new System.EventHandler(this.btnBuscarRepetidaEnParrafo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBuscarRepetidaEnParrafo);
            this.Controls.Add(this.txtPalabraABuscarEnElParrafo);
            this.Controls.Add(this.lblPalabraABuscarEnParrafo);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtPalabraRepetidaABuscar);
            this.Controls.Add(this.lblPalabraABuscar);
            this.Controls.Add(this.btnReemplazar);
            this.Controls.Add(this.txtPalabraNueva);
            this.Controls.Add(this.lblPalabraNueva);
            this.Controls.Add(this.txtCuadroDeTexto);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Editor De Texto";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtCuadroDeTexto;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem convertirTodasLasLetrasEnMinusculasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem convertirTodoAMayusculasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem letrasDelPárrafoAMinusculasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem letrasDelPárrafoAMayúsculasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem primerLetraEnMinusculaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem primerLetraEnMayúsculaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reemplazarPalabraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reemplazarPalabraEnEspecíficoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cantidadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cantidadTotalDePalabrasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cantidadDePalabrasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cantidadDeLetrasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cantidadDeLetrasEnPárrafoToolStripMenuItem;
        private System.Windows.Forms.Label lblPalabraNueva;
        private System.Windows.Forms.TextBox txtPalabraNueva;
        private System.Windows.Forms.Button btnReemplazar;
        private System.Windows.Forms.ToolStripMenuItem vecesQueSeRepiteUnaPalabraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vecesQueSeRepitePalabraEnElPárrafoToolStripMenuItem;
        private System.Windows.Forms.Label lblPalabraABuscar;
        private System.Windows.Forms.TextBox txtPalabraRepetidaABuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblPalabraABuscarEnParrafo;
        private System.Windows.Forms.TextBox txtPalabraABuscarEnElParrafo;
        private System.Windows.Forms.Button btnBuscarRepetidaEnParrafo;
    }
}

