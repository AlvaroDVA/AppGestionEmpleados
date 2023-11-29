namespace GestionEmpleados
{
    partial class GestionEmpleadosView
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            listaDepartamentosView = new ListView();
            columnHeader1 = new ColumnHeader();
            listaEmpleadosView = new ListView();
            tableLayoutPanel2 = new TableLayoutPanel();
            label6 = new Label();
            telefonoTextBox = new TextBox();
            label4 = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            dniTextBox = new TextBox();
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            nombreTextBox = new TextBox();
            emailTextBox = new TextBox();
            label5 = new Label();
            puestoTextBox = new TextBox();
            tableLayoutPanel4 = new TableLayoutPanel();
            nuevoEmpleadoButton = new Button();
            eliminarEmpleadoButton = new Button();
            guardarEmpleadoButton = new Button();
            departamentoComboBox = new ComboBox();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.Controls.Add(listaDepartamentosView, 0, 0);
            tableLayoutPanel1.Controls.Add(listaEmpleadosView, 1, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 3, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(700, 338);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // listaDepartamentosView
            // 
            listaDepartamentosView.Columns.AddRange(new ColumnHeader[] { columnHeader1 });
            listaDepartamentosView.Dock = DockStyle.Fill;
            listaDepartamentosView.HeaderStyle = ColumnHeaderStyle.None;
            listaDepartamentosView.Location = new Point(3, 3);
            listaDepartamentosView.Name = "listaDepartamentosView";
            listaDepartamentosView.Size = new Size(134, 332);
            listaDepartamentosView.TabIndex = 4;
            listaDepartamentosView.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Departamento";
            columnHeader1.Width = -2;
            // 
            // listaEmpleadosView
            // 
            listaEmpleadosView.Dock = DockStyle.Fill;
            listaEmpleadosView.FullRowSelect = true;
            listaEmpleadosView.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listaEmpleadosView.Location = new Point(143, 2);
            listaEmpleadosView.Margin = new Padding(3, 2, 3, 2);
            listaEmpleadosView.Name = "listaEmpleadosView";
            listaEmpleadosView.Size = new Size(274, 334);
            listaEmpleadosView.TabIndex = 2;
            listaEmpleadosView.UseCompatibleStateImageBehavior = false;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(label6, 0, 9);
            tableLayoutPanel2.Controls.Add(telefonoTextBox, 0, 6);
            tableLayoutPanel2.Controls.Add(label4, 0, 5);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel2.Controls.Add(label3, 0, 3);
            tableLayoutPanel2.Controls.Add(label2, 0, 1);
            tableLayoutPanel2.Controls.Add(nombreTextBox, 0, 2);
            tableLayoutPanel2.Controls.Add(emailTextBox, 0, 4);
            tableLayoutPanel2.Controls.Add(label5, 0, 7);
            tableLayoutPanel2.Controls.Add(puestoTextBox, 0, 8);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel4, 0, 11);
            tableLayoutPanel2.Controls.Add(departamentoComboBox, 0, 10);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(423, 2);
            tableLayoutPanel2.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 12;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 8.982036F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 7.185629F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333333F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333333F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333333F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333333F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333333F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333333F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333333F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333333F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333333F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333333F));
            tableLayoutPanel2.Size = new Size(274, 334);
            tableLayoutPanel2.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Fill;
            label6.Location = new Point(13, 245);
            label6.Margin = new Padding(13, 2, 13, 2);
            label6.Name = "label6";
            label6.Size = new Size(248, 23);
            label6.TabIndex = 9;
            label6.Text = "Departamento";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // telefonoTextBox
            // 
            telefonoTextBox.Dock = DockStyle.Fill;
            telefonoTextBox.Location = new Point(13, 164);
            telefonoTextBox.Margin = new Padding(13, 2, 13, 2);
            telefonoTextBox.Name = "telefonoTextBox";
            telefonoTextBox.Size = new Size(248, 23);
            telefonoTextBox.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Location = new Point(13, 135);
            label4.Margin = new Padding(13, 0, 3, 0);
            label4.Name = "label4";
            label4.Size = new Size(258, 27);
            label4.TabIndex = 5;
            label4.Text = "Telefono";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.AutoSize = true;
            tableLayoutPanel3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 110F));
            tableLayoutPanel3.Controls.Add(dniTextBox, 0, 0);
            tableLayoutPanel3.Controls.Add(label1, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 2);
            tableLayoutPanel3.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(268, 26);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // dniTextBox
            // 
            dniTextBox.Dock = DockStyle.Fill;
            dniTextBox.Location = new Point(161, 2);
            dniTextBox.Margin = new Padding(3, 2, 3, 2);
            dniTextBox.Name = "dniTextBox";
            dniTextBox.ReadOnly = true;
            dniTextBox.Size = new Size(104, 23);
            dniTextBox.TabIndex = 2;
            dniTextBox.TextAlign = HorizontalAlignment.Right;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(152, 26);
            label1.TabIndex = 3;
            label1.Text = "DNI";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(13, 81);
            label3.Margin = new Padding(13, 0, 3, 0);
            label3.Name = "label3";
            label3.Size = new Size(258, 27);
            label3.TabIndex = 3;
            label3.Text = "Email";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(13, 30);
            label2.Margin = new Padding(13, 0, 3, 0);
            label2.Name = "label2";
            label2.Size = new Size(258, 24);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // nombreTextBox
            // 
            nombreTextBox.Dock = DockStyle.Fill;
            nombreTextBox.Location = new Point(13, 56);
            nombreTextBox.Margin = new Padding(13, 2, 13, 2);
            nombreTextBox.Name = "nombreTextBox";
            nombreTextBox.Size = new Size(248, 23);
            nombreTextBox.TabIndex = 2;
            // 
            // emailTextBox
            // 
            emailTextBox.Dock = DockStyle.Fill;
            emailTextBox.Location = new Point(13, 110);
            emailTextBox.Margin = new Padding(13, 2, 13, 2);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(248, 23);
            emailTextBox.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.Location = new Point(13, 191);
            label5.Margin = new Padding(13, 2, 13, 2);
            label5.Name = "label5";
            label5.Size = new Size(248, 23);
            label5.TabIndex = 7;
            label5.Text = "Puesto";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // puestoTextBox
            // 
            puestoTextBox.Dock = DockStyle.Fill;
            puestoTextBox.Location = new Point(13, 218);
            puestoTextBox.Margin = new Padding(13, 2, 13, 2);
            puestoTextBox.Name = "puestoTextBox";
            puestoTextBox.Size = new Size(248, 23);
            puestoTextBox.TabIndex = 8;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 3;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel4.Controls.Add(nuevoEmpleadoButton, 0, 0);
            tableLayoutPanel4.Controls.Add(eliminarEmpleadoButton, 1, 0);
            tableLayoutPanel4.Controls.Add(guardarEmpleadoButton, 2, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 299);
            tableLayoutPanel4.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(268, 33);
            tableLayoutPanel4.TabIndex = 11;
            // 
            // nuevoEmpleadoButton
            // 
            nuevoEmpleadoButton.Dock = DockStyle.Fill;
            nuevoEmpleadoButton.Location = new Point(3, 2);
            nuevoEmpleadoButton.Margin = new Padding(3, 2, 3, 2);
            nuevoEmpleadoButton.Name = "nuevoEmpleadoButton";
            nuevoEmpleadoButton.Size = new Size(83, 29);
            nuevoEmpleadoButton.TabIndex = 0;
            nuevoEmpleadoButton.Text = "Nuevo";
            nuevoEmpleadoButton.UseVisualStyleBackColor = true;
            // 
            // eliminarEmpleadoButton
            // 
            eliminarEmpleadoButton.Dock = DockStyle.Fill;
            eliminarEmpleadoButton.Enabled = false;
            eliminarEmpleadoButton.Location = new Point(92, 2);
            eliminarEmpleadoButton.Margin = new Padding(3, 2, 3, 2);
            eliminarEmpleadoButton.Name = "eliminarEmpleadoButton";
            eliminarEmpleadoButton.Size = new Size(83, 29);
            eliminarEmpleadoButton.TabIndex = 1;
            eliminarEmpleadoButton.Text = "Eliminar";
            eliminarEmpleadoButton.UseVisualStyleBackColor = true;
            // 
            // guardarEmpleadoButton
            // 
            guardarEmpleadoButton.Dock = DockStyle.Fill;
            guardarEmpleadoButton.Enabled = false;
            guardarEmpleadoButton.Location = new Point(181, 2);
            guardarEmpleadoButton.Margin = new Padding(3, 2, 3, 2);
            guardarEmpleadoButton.Name = "guardarEmpleadoButton";
            guardarEmpleadoButton.Size = new Size(84, 29);
            guardarEmpleadoButton.TabIndex = 2;
            guardarEmpleadoButton.Text = "Guardar";
            guardarEmpleadoButton.UseVisualStyleBackColor = true;
            // 
            // departamentoComboBox
            // 
            departamentoComboBox.Dock = DockStyle.Fill;
            departamentoComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            departamentoComboBox.FormattingEnabled = true;
            departamentoComboBox.Location = new Point(3, 273);
            departamentoComboBox.Name = "departamentoComboBox";
            departamentoComboBox.Size = new Size(268, 23);
            departamentoComboBox.TabIndex = 12;
            // 
            // GestionEmpleadosView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "GestionEmpleadosView";
            Text = "Form1";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private ListView listaEmpleadosView;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label3;
        private Label label2;
        private TextBox nombreTextBox;
        private Label label4;
        private TableLayoutPanel tableLayoutPanel3;
        private TextBox dniTextBox;
        private Label label1;
        private TextBox emailTextBox;
        private TextBox telefonoTextBox;
        private Label label5;
        private Label label6;
        private TextBox puestoTextBox;
        private TableLayoutPanel tableLayoutPanel4;
        private Button nuevoEmpleadoButton;
        private Button eliminarEmpleadoButton;
        private Button guardarEmpleadoButton;
        private ListView listaDepartamentosView;
        private ColumnHeader columnHeader1;
        private ComboBox departamentoComboBox;
    }
}