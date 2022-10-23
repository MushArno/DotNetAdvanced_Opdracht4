namespace Opdracht4
{
    partial class TeDoenForm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tijdCheckBox = new System.Windows.Forms.CheckBox();
            this.btn_taak_toevoegen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(432, 100);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(333, 247);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(43, 100);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(300, 23);
            this.textBox2.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(43, 129);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(267, 23);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // tijdCheckBox
            // 
            this.tijdCheckBox.AutoSize = true;
            this.tijdCheckBox.Location = new System.Drawing.Point(316, 133);
            this.tijdCheckBox.Name = "tijdCheckBox";
            this.tijdCheckBox.Size = new System.Drawing.Size(45, 19);
            this.tijdCheckBox.TabIndex = 3;
            this.tijdCheckBox.Text = "Tijd";
            this.tijdCheckBox.UseVisualStyleBackColor = true;
            // 
            // btn_taak_toevoegen
            // 
            this.btn_taak_toevoegen.Location = new System.Drawing.Point(43, 309);
            this.btn_taak_toevoegen.Name = "btn_taak_toevoegen";
            this.btn_taak_toevoegen.Size = new System.Drawing.Size(109, 23);
            this.btn_taak_toevoegen.TabIndex = 4;
            this.btn_taak_toevoegen.Text = "Taak Toevoegen";
            this.btn_taak_toevoegen.UseVisualStyleBackColor = true;
            // 
            // TeDoenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_taak_toevoegen);
            this.Controls.Add(this.tijdCheckBox);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "TeDoenForm";
            this.Text = "Taak Window";
            this.Load += new System.EventHandler(this.TeDoenForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private DateTimePicker dateTimePicker1;
        private CheckBox tijdCheckBox;
        private Button btn_taak_toevoegen;
    }
}