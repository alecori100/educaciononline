namespace WindowsFormsApp1
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.dg_Profesor = new System.Windows.Forms.DataGridView();
            this.iDEmpleadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.curriculumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dNIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profesorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dg_Alumno = new System.Windows.Forms.DataGridView();
            this.idAlumnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarjetaCreditoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dNIDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alumnoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dg_Curso = new System.Windows.Forms.DataGridView();
            this.iDCursoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.temarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cursoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.botonGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Profesor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profesorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Alumno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Curso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dg_Profesor
            // 
            this.dg_Profesor.AutoGenerateColumns = false;
            this.dg_Profesor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Profesor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDEmpleadoDataGridViewTextBoxColumn,
            this.curriculumDataGridViewTextBoxColumn,
            this.dNIDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.telefonoDataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn});
            this.dg_Profesor.DataSource = this.profesorBindingSource;
            this.dg_Profesor.Location = new System.Drawing.Point(42, 273);
            this.dg_Profesor.Name = "dg_Profesor";
            this.dg_Profesor.Size = new System.Drawing.Size(540, 150);
            this.dg_Profesor.TabIndex = 0;
            this.dg_Profesor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_Profesor_CellContentClick);
            // 
            // iDEmpleadoDataGridViewTextBoxColumn
            // 
            this.iDEmpleadoDataGridViewTextBoxColumn.DataPropertyName = "ID_Empleado";
            this.iDEmpleadoDataGridViewTextBoxColumn.HeaderText = "ID_Empleado";
            this.iDEmpleadoDataGridViewTextBoxColumn.Name = "iDEmpleadoDataGridViewTextBoxColumn";
            // 
            // curriculumDataGridViewTextBoxColumn
            // 
            this.curriculumDataGridViewTextBoxColumn.DataPropertyName = "Curriculum";
            this.curriculumDataGridViewTextBoxColumn.HeaderText = "Curriculum";
            this.curriculumDataGridViewTextBoxColumn.Name = "curriculumDataGridViewTextBoxColumn";
            // 
            // dNIDataGridViewTextBoxColumn
            // 
            this.dNIDataGridViewTextBoxColumn.DataPropertyName = "DNI";
            this.dNIDataGridViewTextBoxColumn.HeaderText = "DNI";
            this.dNIDataGridViewTextBoxColumn.Name = "dNIDataGridViewTextBoxColumn";
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            this.telefonoDataGridViewTextBoxColumn.DataPropertyName = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.HeaderText = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            this.direccionDataGridViewTextBoxColumn.DataPropertyName = "Direccion";
            this.direccionDataGridViewTextBoxColumn.HeaderText = "Direccion";
            this.direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            // 
            // profesorBindingSource
            // 
            this.profesorBindingSource.DataSource = typeof(ModeloLogica.Profesor);
            // 
            // dg_Alumno
            // 
            this.dg_Alumno.AutoGenerateColumns = false;
            this.dg_Alumno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Alumno.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idAlumnoDataGridViewTextBoxColumn,
            this.tarjetaCreditoDataGridViewTextBoxColumn,
            this.dNIDataGridViewTextBoxColumn1,
            this.nombreDataGridViewTextBoxColumn1,
            this.emailDataGridViewTextBoxColumn1,
            this.telefonoDataGridViewTextBoxColumn1,
            this.direccionDataGridViewTextBoxColumn1});
            this.dg_Alumno.DataSource = this.alumnoBindingSource;
            this.dg_Alumno.Location = new System.Drawing.Point(109, 37);
            this.dg_Alumno.Name = "dg_Alumno";
            this.dg_Alumno.Size = new System.Drawing.Size(743, 150);
            this.dg_Alumno.TabIndex = 1;
            this.dg_Alumno.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_Alumno_CellContentClick);
            // 
            // idAlumnoDataGridViewTextBoxColumn
            // 
            this.idAlumnoDataGridViewTextBoxColumn.DataPropertyName = "idAlumno";
            this.idAlumnoDataGridViewTextBoxColumn.HeaderText = "idAlumno";
            this.idAlumnoDataGridViewTextBoxColumn.Name = "idAlumnoDataGridViewTextBoxColumn";
            // 
            // tarjetaCreditoDataGridViewTextBoxColumn
            // 
            this.tarjetaCreditoDataGridViewTextBoxColumn.DataPropertyName = "tarjetaCredito";
            this.tarjetaCreditoDataGridViewTextBoxColumn.HeaderText = "tarjetaCredito";
            this.tarjetaCreditoDataGridViewTextBoxColumn.Name = "tarjetaCreditoDataGridViewTextBoxColumn";
            // 
            // dNIDataGridViewTextBoxColumn1
            // 
            this.dNIDataGridViewTextBoxColumn1.DataPropertyName = "DNI";
            this.dNIDataGridViewTextBoxColumn1.HeaderText = "DNI";
            this.dNIDataGridViewTextBoxColumn1.Name = "dNIDataGridViewTextBoxColumn1";
            // 
            // nombreDataGridViewTextBoxColumn1
            // 
            this.nombreDataGridViewTextBoxColumn1.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn1.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn1.Name = "nombreDataGridViewTextBoxColumn1";
            // 
            // emailDataGridViewTextBoxColumn1
            // 
            this.emailDataGridViewTextBoxColumn1.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn1.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn1.Name = "emailDataGridViewTextBoxColumn1";
            // 
            // telefonoDataGridViewTextBoxColumn1
            // 
            this.telefonoDataGridViewTextBoxColumn1.DataPropertyName = "Telefono";
            this.telefonoDataGridViewTextBoxColumn1.HeaderText = "Telefono";
            this.telefonoDataGridViewTextBoxColumn1.Name = "telefonoDataGridViewTextBoxColumn1";
            // 
            // direccionDataGridViewTextBoxColumn1
            // 
            this.direccionDataGridViewTextBoxColumn1.DataPropertyName = "Direccion";
            this.direccionDataGridViewTextBoxColumn1.HeaderText = "Direccion";
            this.direccionDataGridViewTextBoxColumn1.Name = "direccionDataGridViewTextBoxColumn1";
            // 
            // alumnoBindingSource
            // 
            this.alumnoBindingSource.DataSource = typeof(ModeloLogica.Alumno);
            // 
            // dg_Curso
            // 
            this.dg_Curso.AutoGenerateColumns = false;
            this.dg_Curso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Curso.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDCursoDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn2,
            this.temarioDataGridViewTextBoxColumn});
            this.dg_Curso.DataSource = this.cursoBindingSource;
            this.dg_Curso.Location = new System.Drawing.Point(624, 255);
            this.dg_Curso.Name = "dg_Curso";
            this.dg_Curso.Size = new System.Drawing.Size(343, 150);
            this.dg_Curso.TabIndex = 2;
            // 
            // iDCursoDataGridViewTextBoxColumn
            // 
            this.iDCursoDataGridViewTextBoxColumn.DataPropertyName = "ID_Curso";
            this.iDCursoDataGridViewTextBoxColumn.HeaderText = "ID_Curso";
            this.iDCursoDataGridViewTextBoxColumn.Name = "iDCursoDataGridViewTextBoxColumn";
            // 
            // nombreDataGridViewTextBoxColumn2
            // 
            this.nombreDataGridViewTextBoxColumn2.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn2.Name = "nombreDataGridViewTextBoxColumn2";
            // 
            // temarioDataGridViewTextBoxColumn
            // 
            this.temarioDataGridViewTextBoxColumn.DataPropertyName = "Temario";
            this.temarioDataGridViewTextBoxColumn.HeaderText = "Temario";
            this.temarioDataGridViewTextBoxColumn.Name = "temarioDataGridViewTextBoxColumn";
            // 
            // cursoBindingSource
            // 
            this.cursoBindingSource.DataSource = typeof(ModeloLogica.Curso);
            // 
            // botonGuardar
            // 
            this.botonGuardar.Location = new System.Drawing.Point(360, 209);
            this.botonGuardar.Name = "botonGuardar";
            this.botonGuardar.Size = new System.Drawing.Size(75, 23);
            this.botonGuardar.TabIndex = 3;
            this.botonGuardar.Text = "guardar";
            this.botonGuardar.UseVisualStyleBackColor = true;
            this.botonGuardar.Click += new System.EventHandler(this.botonGuardar_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 450);
            this.Controls.Add(this.botonGuardar);
            this.Controls.Add(this.dg_Curso);
            this.Controls.Add(this.dg_Alumno);
            this.Controls.Add(this.dg_Profesor);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_Profesor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profesorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Alumno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Curso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dg_Profesor;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDEmpleadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn curriculumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dNIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource profesorBindingSource;
        private System.Windows.Forms.DataGridView dg_Alumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAlumnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarjetaCreditoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dNIDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource alumnoBindingSource;
        private System.Windows.Forms.DataGridView dg_Curso;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDCursoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn temarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource cursoBindingSource;
        private System.Windows.Forms.Button botonGuardar;
    }
}