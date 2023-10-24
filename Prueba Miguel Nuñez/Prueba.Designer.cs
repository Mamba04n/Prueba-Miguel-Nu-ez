namespace Prueba_Miguel_Nuñez
{
    partial class Prueba
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
            ListViewItem listViewItem6 = new ListViewItem(new string[] { "Placa" }, -1, Color.Empty, Color.Empty, new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point));
            ListViewItem listViewItem7 = new ListViewItem(new string[] { "Velocidad" }, -1, Color.Empty, Color.Empty, new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point));
            ListViewItem listViewItem8 = new ListViewItem(new string[] { "Fecha" }, -1, Color.Empty, Color.Empty, new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point));
            ListViewItem listViewItem9 = new ListViewItem(new string[] { "Hora" }, -1, Color.Empty, Color.Empty, new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point));
            ListViewItem listViewItem10 = new ListViewItem(new string[] { "Multa" }, -1, Color.Empty, Color.Empty, new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point));
            label1 = new Label();
            listView1 = new ListView();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            Placa = new ColumnHeader();
            Fecha = new ColumnHeader();
            Hora = new ColumnHeader();
            Velocidad = new ColumnHeader();
            Multa = new ColumnHeader();
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(221, 9);
            label1.Name = "label1";
            label1.Size = new Size(316, 42);
            label1.TabIndex = 0;
            label1.Text = "Multas de Transito";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { Fecha, Placa, Hora, Velocidad, Multa });
            listView1.Items.AddRange(new ListViewItem[] { listViewItem6, listViewItem7, listViewItem8, listViewItem9, listViewItem10 });
            listView1.Location = new Point(17, 166);
            listView1.Name = "listView1";
            listView1.Size = new Size(703, 249);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.SmallIcon;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 83);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 2;
            label2.Text = "Placa";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(127, 83);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 3;
            label3.Text = "Velocidad";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(499, 83);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 4;
            label4.Text = "Multa";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(271, 83);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 5;
            label5.Text = "Fecha";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(380, 83);
            label6.Name = "label6";
            label6.Size = new Size(33, 15);
            label6.TabIndex = 6;
            label6.Text = "Hora";
            // 
            // Placa
            // 
            Placa.DisplayIndex = 0;
            // 
            // Fecha
            // 
            Fecha.DisplayIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(607, 96);
            button1.Name = "button1";
            button1.Size = new Size(113, 31);
            button1.TabIndex = 7;
            button1.Text = "Registrar";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(2, 101);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(80, 23);
            textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(117, 101);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(80, 23);
            textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(252, 101);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(80, 23);
            textBox3.TabIndex = 10;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(356, 101);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(80, 23);
            textBox4.TabIndex = 11;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(478, 101);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(80, 23);
            textBox5.TabIndex = 12;
            // 
            // button2
            // 
            button2.Location = new Point(607, 129);
            button2.Name = "button2";
            button2.Size = new Size(113, 31);
            button2.TabIndex = 13;
            button2.Text = "Eliminar";
            button2.UseVisualStyleBackColor = true;
            // 
            // Prueba
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(listView1);
            Controls.Add(label1);
            Name = "Prueba";
            Text = "Prueba";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListView listView1;
        private ColumnHeader Fecha;
        private ColumnHeader Placa;
        private ColumnHeader Hora;
        private ColumnHeader Velocidad;
        private ColumnHeader Multa;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Button button2;
    }
}