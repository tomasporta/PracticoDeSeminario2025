namespace Practico.Windows
{
    partial class FrmFormasDePagoAE
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            txtDescripcion = new TextBox();
            bOK = new Button();
            bCancelar = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 44);
            label1.Name = "label1";
            label1.Size = new Size(88, 15);
            label1.TabIndex = 0;
            label1.Text = "Forma De Pago";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(134, 41);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(159, 23);
            txtDescripcion.TabIndex = 1;
            txtDescripcion.TextChanged += textBox1_TextChanged;
            // 
            // bOK
            // 
            bOK.Location = new Point(40, 95);
            bOK.Name = "bOK";
            bOK.Size = new Size(107, 45);
            bOK.TabIndex = 2;
            bOK.Text = "OK";
            bOK.UseVisualStyleBackColor = true;
            bOK.Click += bOK_Click;
            // 
            // bCancelar
            // 
            bCancelar.Location = new Point(187, 95);
            bCancelar.Name = "bCancelar";
            bCancelar.Size = new Size(106, 45);
            bCancelar.TabIndex = 3;
            bCancelar.Text = "Cancelar";
            bCancelar.UseVisualStyleBackColor = true;
            bCancelar.Click += bCancelar_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // FrmFormasDePagoAE
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(337, 170);
            Controls.Add(bCancelar);
            Controls.Add(bOK);
            Controls.Add(txtDescripcion);
            Controls.Add(label1);
            Name = "FrmFormasDePagoAE";
            Text = "FrmFormasDePagoAE";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtDescripcion;
        private Button bOK;
        private Button bCancelar;
        private ErrorProvider errorProvider1;
    }
}