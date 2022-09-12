namespace JogoDaForca
{
    partial class Form1
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
            this.newGameButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.inputButton = new System.Windows.Forms.Button();
            this.letterButton = new System.Windows.Forms.Button();
            this.textBoxLetter = new System.Windows.Forms.TextBox();
            this.labelForca = new System.Windows.Forms.Label();
            this.groupButton = new System.Windows.Forms.GroupBox();
            this.groupButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // newGameButton
            // 
            this.newGameButton.Location = new System.Drawing.Point(528, 12);
            this.newGameButton.Name = "newGameButton";
            this.newGameButton.Size = new System.Drawing.Size(127, 40);
            this.newGameButton.TabIndex = 0;
            this.newGameButton.Text = "New Game";
            this.newGameButton.UseVisualStyleBackColor = true;
            this.newGameButton.Click += new System.EventHandler(this.newGameButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(661, 12);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(127, 40);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Cancel";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(84, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Jogo da Forca";
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(474, 16);
            this.textBoxInput.MaxLength = 25;
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(175, 20);
            this.textBoxInput.TabIndex = 3;
            // 
            // inputButton
            // 
            this.inputButton.Location = new System.Drawing.Point(474, 42);
            this.inputButton.Name = "inputButton";
            this.inputButton.Size = new System.Drawing.Size(175, 23);
            this.inputButton.TabIndex = 4;
            this.inputButton.Text = "Chutar";
            this.inputButton.UseVisualStyleBackColor = true;
            this.inputButton.Click += new System.EventHandler(this.inputButton_Click);
            // 
            // letterButton
            // 
            this.letterButton.Location = new System.Drawing.Point(36, 42);
            this.letterButton.Name = "letterButton";
            this.letterButton.Size = new System.Drawing.Size(175, 23);
            this.letterButton.TabIndex = 6;
            this.letterButton.Text = "OK";
            this.letterButton.UseVisualStyleBackColor = true;
            this.letterButton.Click += new System.EventHandler(this.letterButton_Click);
            // 
            // textBoxLetter
            // 
            this.textBoxLetter.Location = new System.Drawing.Point(36, 16);
            this.textBoxLetter.MaxLength = 1;
            this.textBoxLetter.Name = "textBoxLetter";
            this.textBoxLetter.Size = new System.Drawing.Size(175, 20);
            this.textBoxLetter.TabIndex = 5;
            // 
            // labelForca
            // 
            this.labelForca.AutoSize = true;
            this.labelForca.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelForca.Location = new System.Drawing.Point(87, 157);
            this.labelForca.Name = "labelForca";
            this.labelForca.Size = new System.Drawing.Size(188, 42);
            this.labelForca.TabIndex = 7;
            this.labelForca.Text = "wordHere";
            this.labelForca.Visible = false;
            // 
            // groupButton
            // 
            this.groupButton.Controls.Add(this.letterButton);
            this.groupButton.Controls.Add(this.textBoxLetter);
            this.groupButton.Controls.Add(this.inputButton);
            this.groupButton.Controls.Add(this.textBoxInput);
            this.groupButton.Location = new System.Drawing.Point(54, 300);
            this.groupButton.Name = "groupButton";
            this.groupButton.Size = new System.Drawing.Size(702, 116);
            this.groupButton.TabIndex = 9;
            this.groupButton.TabStop = false;
            this.groupButton.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupButton);
            this.Controls.Add(this.labelForca);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.newGameButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupButton.ResumeLayout(false);
            this.groupButton.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button newGameButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.Button inputButton;
        private System.Windows.Forms.Button letterButton;
        private System.Windows.Forms.TextBox textBoxLetter;
        private System.Windows.Forms.Label labelForca;
        private System.Windows.Forms.GroupBox groupButton;
    }
}

