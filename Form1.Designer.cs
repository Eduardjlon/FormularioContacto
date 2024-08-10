namespace FormularioContacto
{
    partial class Form1
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
            EtiquetaNombre = new Label();
            EtiquetaEmail = new Label();
            EtiquetaMensaje = new Label();
            TextBoxNombre = new TextBox();
            TextBoxEmail = new TextBox();
            TextBoxMensaje = new TextBox();
            ButtonEnviar = new Button();
            LabelEstado = new Label();
            SuspendLayout();
            // 
            // EtiquetaNombre
            // 
            EtiquetaNombre.AutoSize = true;
            EtiquetaNombre.BackColor = Color.Cornsilk;
            EtiquetaNombre.Font = new Font("Segoe UI", 12F);
            EtiquetaNombre.ForeColor = SystemColors.ControlText;
            EtiquetaNombre.Location = new Point(255, 11);
            EtiquetaNombre.Name = "EtiquetaNombre";
            EtiquetaNombre.Size = new Size(68, 21);
            EtiquetaNombre.TabIndex = 0;
            EtiquetaNombre.Text = "Nombre";
            // 
            // EtiquetaEmail
            // 
            EtiquetaEmail.AutoSize = true;
            EtiquetaEmail.BackColor = Color.Cornsilk;
            EtiquetaEmail.Font = new Font("Segoe UI", 12F);
            EtiquetaEmail.ForeColor = SystemColors.ControlText;
            EtiquetaEmail.Location = new Point(223, 63);
            EtiquetaEmail.Name = "EtiquetaEmail";
            EtiquetaEmail.Size = new Size(141, 21);
            EtiquetaEmail.TabIndex = 1;
            EtiquetaEmail.Text = "Correo Electrónico:";
            // 
            // EtiquetaMensaje
            // 
            EtiquetaMensaje.AutoSize = true;
            EtiquetaMensaje.BackColor = Color.Cornsilk;
            EtiquetaMensaje.Font = new Font("Segoe UI", 12F);
            EtiquetaMensaje.ForeColor = SystemColors.ControlText;
            EtiquetaMensaje.Location = new Point(259, 115);
            EtiquetaMensaje.Name = "EtiquetaMensaje";
            EtiquetaMensaje.Size = new Size(71, 21);
            EtiquetaMensaje.TabIndex = 2;
            EtiquetaMensaje.Text = "Mensaje:";
            // 
            // TextBoxNombre
            // 
            TextBoxNombre.Location = new Point(137, 35);
            TextBoxNombre.Name = "TextBoxNombre";
            TextBoxNombre.Size = new Size(331, 23);
            TextBoxNombre.TabIndex = 3;
            // 
            // TextBoxEmail
            // 
            TextBoxEmail.Location = new Point(137, 86);
            TextBoxEmail.Name = "TextBoxEmail";
            TextBoxEmail.Size = new Size(331, 23);
            TextBoxEmail.TabIndex = 4;
            // 
            // TextBoxMensaje
            // 
            TextBoxMensaje.Location = new Point(137, 139);
            TextBoxMensaje.Multiline = true;
            TextBoxMensaje.Name = "TextBoxMensaje";
            TextBoxMensaje.Size = new Size(331, 98);
            TextBoxMensaje.TabIndex = 7;
            // 
            // ButtonEnviar
            // 
            ButtonEnviar.BackColor = Color.Chocolate;
            ButtonEnviar.ForeColor = Color.Cornsilk;
            ButtonEnviar.Location = new Point(259, 243);
            ButtonEnviar.Name = "ButtonEnviar";
            ButtonEnviar.Size = new Size(81, 33);
            ButtonEnviar.TabIndex = 8;
            ButtonEnviar.Text = "Enviar";
            ButtonEnviar.UseVisualStyleBackColor = false;
            ButtonEnviar.Click += new EventHandler(ButtonEnviar_Click);
            // 
            // LabelEstado
            // 
            LabelEstado.AutoSize = true;
            LabelEstado.Location = new Point(227, 293);
            LabelEstado.Name = "LabelEstado";
            LabelEstado.Size = new Size(106, 15);
            LabelEstado.TabIndex = 9;
            LabelEstado.Text = "¿Mensaje enviado?";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LabelEstado);
            Controls.Add(ButtonEnviar);
            Controls.Add(TextBoxMensaje);
            Controls.Add(TextBoxEmail);
            Controls.Add(TextBoxNombre);
            Controls.Add(EtiquetaMensaje);
            Controls.Add(EtiquetaEmail);
            Controls.Add(EtiquetaNombre);
            Name = "Form1";
            Text = "Formulario de Contacto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label EtiquetaNombre;
        private Label EtiquetaEmail;
        private Label EtiquetaMensaje;
        private TextBox TextBoxNombre;
        private TextBox TextBoxEmail;
        private TextBox TextBoxMensaje;
        private Button ButtonEnviar;
        private Label LabelEstado;

        // Método que será llamado cuando se haga clic en el botón Enviar
        private void ButtonEnviar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextBoxNombre.Text) ||
                string.IsNullOrWhiteSpace(TextBoxEmail.Text) ||
                string.IsNullOrWhiteSpace(TextBoxMensaje.Text))
            {
                LabelEstado.Text = "Por favor, complete todos los campos.";
                LabelEstado.ForeColor = Color.Red;
            }
            else
            {
                LabelEstado.Text = "Formulario enviado correctamente.";
                LabelEstado.ForeColor = Color.Green;
            }
        }
    }
}
