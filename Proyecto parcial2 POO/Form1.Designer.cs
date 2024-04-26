namespace Proyecto_parcial2_POO
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
            btnConstruir = new Button();
            label1 = new Label();
            label2 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // btnConstruir
            // 
            btnConstruir.Location = new Point(117, 193);
            btnConstruir.Name = "btnConstruir";
            btnConstruir.Size = new Size(183, 29);
            btnConstruir.TabIndex = 0;
            btnConstruir.Text = "Colocar Bloque";
            btnConstruir.UseVisualStyleBackColor = true;
            btnConstruir.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(58, 34);
            label1.Name = "label1";
            label1.Size = new Size(169, 18);
            label1.TabIndex = 1;
            label1.Text = "Bloques colocados ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(58, 116);
            label2.Name = "label2";
            label2.Size = new Size(189, 20);
            label2.TabIndex = 3;
            label2.Text = "Tipo de bloque construido ";
            // 
            // button2
            // 
            button2.Location = new Point(451, 193);
            button2.Name = "button2";
            button2.Size = new Size(183, 29);
            button2.TabIndex = 4;
            button2.Text = "Destruir bloque\r\n";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnConstruir);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConstruir;
        private Label label1;
        private Label label2;
        private Button button2;
    }
}
