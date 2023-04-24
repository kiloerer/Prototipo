namespace Login
{
    partial class Menu_Principal
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
            labelbienvenido = new Guna.UI2.WinForms.Guna2HtmlLabel();
            SuspendLayout();
            // 
            // labelbienvenido
            // 
            labelbienvenido.BackColor = Color.Transparent;
            labelbienvenido.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            labelbienvenido.Location = new Point(105, 170);
            labelbienvenido.Name = "labelbienvenido";
            labelbienvenido.Size = new Size(201, 56);
            labelbienvenido.TabIndex = 0;
            labelbienvenido.Text = "bienvenido";
            // 
            // Menu_Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(425, 450);
            Controls.Add(labelbienvenido);
            Name = "Menu_Principal";
            Text = "Menu_Principal";
            Load += Menu_Principal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel labelbienvenido;
    }
}