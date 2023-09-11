namespace Ej01.App
{
    partial class MainView
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
            btnValidate = new Button();
            btnCleanFields = new Button();
            lblTitle = new Label();
            lblFirstName = new Label();
            lblLastName = new Label();
            lblDocNumber = new Label();
            lblBirthDate = new Label();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtDocNumber = new TextBox();
            fchBirthDate = new DateTimePicker();
            SuspendLayout();
            // 
            // btnValidate
            // 
            btnValidate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnValidate.Location = new Point(15, 232);
            btnValidate.Margin = new Padding(4, 4, 4, 4);
            btnValidate.Name = "btnValidate";
            btnValidate.Size = new Size(131, 76);
            btnValidate.TabIndex = 0;
            btnValidate.Text = "Validar";
            btnValidate.UseVisualStyleBackColor = true;
            btnValidate.Click += btnValidate_Click;
            // 
            // btnCleanFields
            // 
            btnCleanFields.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCleanFields.Location = new Point(256, 232);
            btnCleanFields.Margin = new Padding(4, 4, 4, 4);
            btnCleanFields.Name = "btnCleanFields";
            btnCleanFields.Size = new Size(203, 76);
            btnCleanFields.TabIndex = 1;
            btnCleanFields.Text = "Limpiar Campos";
            btnCleanFields.UseVisualStyleBackColor = true;
            btnCleanFields.Click += btnCleanFields_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitle.Location = new Point(15, 13);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(160, 30);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Validar Persona";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(15, 74);
            lblFirstName.Margin = new Padding(4, 0, 4, 0);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(68, 21);
            lblFirstName.TabIndex = 3;
            lblFirstName.Text = "Nombre";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(242, 74);
            lblLastName.Margin = new Padding(4, 0, 4, 0);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(67, 21);
            lblLastName.TabIndex = 4;
            lblLastName.Text = "Apellido";
            // 
            // lblDocNumber
            // 
            lblDocNumber.AutoSize = true;
            lblDocNumber.Location = new Point(15, 120);
            lblDocNumber.Margin = new Padding(4, 0, 4, 0);
            lblDocNumber.Name = "lblDocNumber";
            lblDocNumber.Size = new Size(125, 21);
            lblDocNumber.TabIndex = 5;
            lblDocNumber.Text = "Nro. Documento";
            // 
            // lblBirthDate
            // 
            lblBirthDate.AutoSize = true;
            lblBirthDate.Location = new Point(15, 169);
            lblBirthDate.Margin = new Padding(4, 0, 4, 0);
            lblBirthDate.Name = "lblBirthDate";
            lblBirthDate.Size = new Size(152, 21);
            lblBirthDate.TabIndex = 6;
            lblBirthDate.Text = "Fecha de nacimiento";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(93, 70);
            txtFirstName.Margin = new Padding(4, 4, 4, 4);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(127, 29);
            txtFirstName.TabIndex = 7;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(315, 70);
            txtLastName.Margin = new Padding(4, 4, 4, 4);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(152, 29);
            txtLastName.TabIndex = 8;
            // 
            // txtDocNumber
            // 
            txtDocNumber.Location = new Point(147, 116);
            txtDocNumber.Margin = new Padding(4, 4, 4, 4);
            txtDocNumber.Name = "txtDocNumber";
            txtDocNumber.Size = new Size(320, 29);
            txtDocNumber.TabIndex = 9;
            // 
            // fchBirthDate
            // 
            fchBirthDate.Location = new Point(185, 161);
            fchBirthDate.Margin = new Padding(4, 4, 4, 4);
            fchBirthDate.Name = "fchBirthDate";
            fchBirthDate.Size = new Size(282, 29);
            fchBirthDate.TabIndex = 10;
            // 
            // MainView
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(483, 325);
            Controls.Add(fchBirthDate);
            Controls.Add(txtDocNumber);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(lblBirthDate);
            Controls.Add(lblDocNumber);
            Controls.Add(lblLastName);
            Controls.Add(lblFirstName);
            Controls.Add(lblTitle);
            Controls.Add(btnCleanFields);
            Controls.Add(btnValidate);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = SystemColors.Desktop;
            Margin = new Padding(4, 4, 4, 4);
            MaximizeBox = false;
            Name = "MainView";
            Text = "Validador";
            Load += MainView_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnValidate;
        private Button btnCleanFields;
        private Label lblTitle;
        private Label lblFirstName;
        private Label lblLastName;
        private Label lblDocNumber;
        private Label lblBirthDate;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtDocNumber;
        private DateTimePicker fchBirthDate;
    }
}