namespace RockPaperScissors_WindowsForms
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
            this.rock = new System.Windows.Forms.Button();
            this.paper = new System.Windows.Forms.Button();
            this.scissors = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // rock
            // 
            this.rock.AutoEllipsis = true;
            this.rock.BackColor = System.Drawing.SystemColors.HotTrack;
            this.rock.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.rock.FlatAppearance.BorderSize = 3;
            this.rock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rock.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rock.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rock.Location = new System.Drawing.Point(95, 312);
            this.rock.Name = "rock";
            this.rock.Size = new System.Drawing.Size(196, 93);
            this.rock.TabIndex = 0;
            this.rock.Text = "Rock";
            this.rock.UseVisualStyleBackColor = false;
            this.rock.Click += new System.EventHandler(this.rock_Click);
            // 
            // paper
            // 
            this.paper.AutoEllipsis = true;
            this.paper.BackColor = System.Drawing.Color.DarkGreen;
            this.paper.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.paper.FlatAppearance.BorderSize = 3;
            this.paper.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.paper.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paper.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.paper.Location = new System.Drawing.Point(332, 312);
            this.paper.Name = "paper";
            this.paper.Size = new System.Drawing.Size(211, 93);
            this.paper.TabIndex = 1;
            this.paper.Text = "Paper";
            this.paper.UseVisualStyleBackColor = false;
            this.paper.Click += new System.EventHandler(this.paper_Click);
            // 
            // scissors
            // 
            this.scissors.AutoEllipsis = true;
            this.scissors.BackColor = System.Drawing.Color.Red;
            this.scissors.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.scissors.FlatAppearance.BorderSize = 3;
            this.scissors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.scissors.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scissors.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.scissors.Location = new System.Drawing.Point(589, 312);
            this.scissors.Name = "scissors";
            this.scissors.Size = new System.Drawing.Size(206, 93);
            this.scissors.TabIndex = 2;
            this.scissors.Text = "Scissors";
            this.scissors.UseVisualStyleBackColor = false;
            this.scissors.Click += new System.EventHandler(this.scissors_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 56F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(174, 55);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(545, 127);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "- - -";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(260, 221);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(336, 32);
            this.textBox2.TabIndex = 4;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 621);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.scissors);
            this.Controls.Add(this.paper);
            this.Controls.Add(this.rock);
            this.Name = "Form1";
            this.Text = "RockPaperScissors";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button rock;
        private System.Windows.Forms.Button paper;
        private System.Windows.Forms.Button scissors;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}

