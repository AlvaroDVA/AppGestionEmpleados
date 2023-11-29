using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEmpleados
{
    public partial class NuevoEmpleadoView
    {
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private RichTextBox dniTextBox;
        private RichTextBox nombreTextBox;
        private RichTextBox emailTextBox;
        private RichTextBox telefonoTextBox;
        private RichTextBox puestoTextBox;
        private ComboBox departamentoComboBox;
        private TableLayoutPanel tableLayoutPanel2;
        private Button guardarButton;
        private Button limpiarButton;
        private Button cancelarButton;
        private Panel panel2;

        private void InitializeComponent()
        {
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            guardarButton = new Button();
            limpiarButton = new Button();
            cancelarButton = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            dniTextBox = new RichTextBox();
            nombreTextBox = new RichTextBox();
            emailTextBox = new RichTextBox();
            telefonoTextBox = new RichTextBox();
            puestoTextBox = new RichTextBox();
            departamentoComboBox = new ComboBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(521, 35);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(521, 35);
            label1.TabIndex = 0;
            label1.Text = "Nuevo Empleado";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.Controls.Add(tableLayoutPanel2);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 271);
            panel2.Name = "panel2";
            panel2.Size = new Size(521, 42);
            panel2.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 5;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tableLayoutPanel2.Controls.Add(guardarButton, 1, 0);
            tableLayoutPanel2.Controls.Add(limpiarButton, 2, 0);
            tableLayoutPanel2.Controls.Add(cancelarButton, 3, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(521, 42);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // guardarButton
            // 
            guardarButton.Dock = DockStyle.Fill;
            guardarButton.Location = new Point(29, 3);
            guardarButton.Name = "guardarButton";
            guardarButton.Size = new Size(150, 36);
            guardarButton.TabIndex = 0;
            guardarButton.Text = "Guardar";
            guardarButton.UseVisualStyleBackColor = true;
            // 
            // limpiarButton
            // 
            limpiarButton.Dock = DockStyle.Fill;
            limpiarButton.Location = new Point(185, 3);
            limpiarButton.Name = "limpiarButton";
            limpiarButton.Size = new Size(150, 36);
            limpiarButton.TabIndex = 1;
            limpiarButton.Text = "Limpiar";
            limpiarButton.UseVisualStyleBackColor = true;
            // 
            // cancelarButton
            // 
            cancelarButton.Dock = DockStyle.Fill;
            cancelarButton.Location = new Point(341, 3);
            cancelarButton.Name = "cancelarButton";
            cancelarButton.Size = new Size(150, 36);
            cancelarButton.TabIndex = 2;
            cancelarButton.Text = "Cancelar";
            cancelarButton.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35.7142868F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 59.52381F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 4.76190472F));
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Controls.Add(label3, 0, 1);
            tableLayoutPanel1.Controls.Add(label4, 0, 2);
            tableLayoutPanel1.Controls.Add(label5, 0, 3);
            tableLayoutPanel1.Controls.Add(label6, 0, 4);
            tableLayoutPanel1.Controls.Add(label7, 0, 5);
            tableLayoutPanel1.Controls.Add(dniTextBox, 1, 0);
            tableLayoutPanel1.Controls.Add(nombreTextBox, 1, 1);
            tableLayoutPanel1.Controls.Add(emailTextBox, 1, 2);
            tableLayoutPanel1.Controls.Add(telefonoTextBox, 1, 3);
            tableLayoutPanel1.Controls.Add(puestoTextBox, 1, 4);
            tableLayoutPanel1.Controls.Add(departamentoComboBox, 1, 5);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 35);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666641F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666641F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666641F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666641F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666641F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666641F));
            tableLayoutPanel1.Size = new Size(521, 236);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(180, 39);
            label2.TabIndex = 0;
            label2.Text = "Dni";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(3, 39);
            label3.Name = "label3";
            label3.Size = new Size(180, 39);
            label3.TabIndex = 1;
            label3.Text = "Nombre";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Dock = DockStyle.Fill;
            label4.Location = new Point(3, 78);
            label4.Name = "label4";
            label4.Size = new Size(180, 39);
            label4.TabIndex = 2;
            label4.Text = "Email";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Dock = DockStyle.Fill;
            label5.Location = new Point(3, 117);
            label5.Name = "label5";
            label5.Size = new Size(180, 39);
            label5.TabIndex = 3;
            label5.Text = "Telefono";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.Dock = DockStyle.Fill;
            label6.Location = new Point(3, 156);
            label6.Name = "label6";
            label6.Size = new Size(180, 39);
            label6.TabIndex = 4;
            label6.Text = "Puesto";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.Dock = DockStyle.Fill;
            label7.Location = new Point(3, 195);
            label7.Name = "label7";
            label7.Size = new Size(180, 41);
            label7.TabIndex = 5;
            label7.Text = "Departamento";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dniTextBox
            // 
            dniTextBox.Dock = DockStyle.Fill;
            dniTextBox.Location = new Point(189, 3);
            dniTextBox.Name = "dniTextBox";
            dniTextBox.Size = new Size(304, 33);
            dniTextBox.TabIndex = 6;
            dniTextBox.Text = "";
            // 
            // nombreTextBox
            // 
            nombreTextBox.Dock = DockStyle.Fill;
            nombreTextBox.Location = new Point(189, 42);
            nombreTextBox.Name = "nombreTextBox";
            nombreTextBox.Size = new Size(304, 33);
            nombreTextBox.TabIndex = 7;
            nombreTextBox.Text = "";
            // 
            // emailTextBox
            // 
            emailTextBox.Dock = DockStyle.Fill;
            emailTextBox.Location = new Point(189, 81);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(304, 33);
            emailTextBox.TabIndex = 8;
            emailTextBox.Text = "";
            // 
            // telefonoTextBox
            // 
            telefonoTextBox.Dock = DockStyle.Fill;
            telefonoTextBox.Location = new Point(189, 120);
            telefonoTextBox.Name = "telefonoTextBox";
            telefonoTextBox.Size = new Size(304, 33);
            telefonoTextBox.TabIndex = 9;
            telefonoTextBox.Text = "";
            // 
            // puestoTextBox
            // 
            puestoTextBox.Dock = DockStyle.Fill;
            puestoTextBox.Location = new Point(189, 159);
            puestoTextBox.Name = "puestoTextBox";
            puestoTextBox.Size = new Size(304, 33);
            puestoTextBox.TabIndex = 10;
            puestoTextBox.Text = "";
            // 
            // departamentoComboBox
            // 
            departamentoComboBox.Dock = DockStyle.Fill;
            departamentoComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            departamentoComboBox.FormattingEnabled = true;
            departamentoComboBox.Location = new Point(189, 198);
            departamentoComboBox.Name = "departamentoComboBox";
            departamentoComboBox.Size = new Size(304, 23);
            departamentoComboBox.TabIndex = 11;
            // 
            // NuevoEmpleadoView
            // 
            ClientSize = new Size(521, 313);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "NuevoEmpleadoView";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }
    }


}
