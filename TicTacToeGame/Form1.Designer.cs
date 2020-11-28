namespace TicTacToeGame
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
            this.lbl00 = new System.Windows.Forms.Label();
            this.lbl01 = new System.Windows.Forms.Label();
            this.lbl02 = new System.Windows.Forms.Label();
            this.lbl12 = new System.Windows.Forms.Label();
            this.lbl11 = new System.Windows.Forms.Label();
            this.lbl10 = new System.Windows.Forms.Label();
            this.lbl22 = new System.Windows.Forms.Label();
            this.lbl21 = new System.Windows.Forms.Label();
            this.lbl20 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.statLabel = new System.Windows.Forms.Label();
            this.startGameBtn = new System.Windows.Forms.Button();
            this.gameStatLbl = new System.Windows.Forms.Label();
            this.gameStatBox = new System.Windows.Forms.GroupBox();
            this.gameStatBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl00
            // 
            this.lbl00.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lbl00.Font = new System.Drawing.Font("Microsoft Sans Serif", 90F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl00.Location = new System.Drawing.Point(30, 37);
            this.lbl00.Name = "lbl00";
            this.lbl00.Size = new System.Drawing.Size(174, 162);
            this.lbl00.TabIndex = 0;
            this.lbl00.Tag = "0";
            this.lbl00.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl00.Click += new System.EventHandler(this.boardClick);
            // 
            // lbl01
            // 
            this.lbl01.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lbl01.Font = new System.Drawing.Font("Microsoft Sans Serif", 90F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl01.Location = new System.Drawing.Point(210, 37);
            this.lbl01.Name = "lbl01";
            this.lbl01.Size = new System.Drawing.Size(174, 162);
            this.lbl01.TabIndex = 0;
            this.lbl01.Tag = "1";
            this.lbl01.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl01.Click += new System.EventHandler(this.boardClick);
            // 
            // lbl02
            // 
            this.lbl02.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lbl02.Font = new System.Drawing.Font("Microsoft Sans Serif", 90F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl02.Location = new System.Drawing.Point(390, 37);
            this.lbl02.Name = "lbl02";
            this.lbl02.Size = new System.Drawing.Size(174, 162);
            this.lbl02.TabIndex = 0;
            this.lbl02.Tag = "2";
            this.lbl02.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl02.Click += new System.EventHandler(this.boardClick);
            // 
            // lbl12
            // 
            this.lbl12.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lbl12.Font = new System.Drawing.Font("Microsoft Sans Serif", 90F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl12.Location = new System.Drawing.Point(390, 209);
            this.lbl12.Name = "lbl12";
            this.lbl12.Size = new System.Drawing.Size(174, 162);
            this.lbl12.TabIndex = 1;
            this.lbl12.Tag = "2";
            this.lbl12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl12.Click += new System.EventHandler(this.boardClick);
            // 
            // lbl11
            // 
            this.lbl11.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lbl11.Font = new System.Drawing.Font("Microsoft Sans Serif", 90F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl11.Location = new System.Drawing.Point(210, 209);
            this.lbl11.Name = "lbl11";
            this.lbl11.Size = new System.Drawing.Size(174, 162);
            this.lbl11.TabIndex = 1;
            this.lbl11.Tag = "1";
            this.lbl11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl11.Click += new System.EventHandler(this.boardClick);
            // 
            // lbl10
            // 
            this.lbl10.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lbl10.Font = new System.Drawing.Font("Microsoft Sans Serif", 90F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl10.Location = new System.Drawing.Point(30, 209);
            this.lbl10.Name = "lbl10";
            this.lbl10.Size = new System.Drawing.Size(174, 162);
            this.lbl10.TabIndex = 1;
            this.lbl10.Tag = "0";
            this.lbl10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl10.Click += new System.EventHandler(this.boardClick);
            // 
            // lbl22
            // 
            this.lbl22.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lbl22.Font = new System.Drawing.Font("Microsoft Sans Serif", 90F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl22.Location = new System.Drawing.Point(390, 381);
            this.lbl22.Name = "lbl22";
            this.lbl22.Size = new System.Drawing.Size(174, 162);
            this.lbl22.TabIndex = 2;
            this.lbl22.Tag = "2";
            this.lbl22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl22.Click += new System.EventHandler(this.boardClick);
            // 
            // lbl21
            // 
            this.lbl21.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lbl21.Font = new System.Drawing.Font("Microsoft Sans Serif", 90F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl21.Location = new System.Drawing.Point(210, 381);
            this.lbl21.Name = "lbl21";
            this.lbl21.Size = new System.Drawing.Size(174, 162);
            this.lbl21.TabIndex = 2;
            this.lbl21.Tag = "1";
            this.lbl21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl21.Click += new System.EventHandler(this.boardClick);
            // 
            // lbl20
            // 
            this.lbl20.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lbl20.Font = new System.Drawing.Font("Microsoft Sans Serif", 90F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl20.Location = new System.Drawing.Point(30, 381);
            this.lbl20.Name = "lbl20";
            this.lbl20.Size = new System.Drawing.Size(174, 162);
            this.lbl20.TabIndex = 2;
            this.lbl20.Tag = "0";
            this.lbl20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl20.Click += new System.EventHandler(this.boardClick);
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(379, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 506);
            this.label9.TabIndex = 9;
            this.label9.Text = "label9";
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(200, 37);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(14, 506);
            this.label10.TabIndex = 10;
            this.label10.Text = "label10";
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(29, 193);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(535, 16);
            this.label11.TabIndex = 11;
            this.label11.Text = "label11";
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(29, 365);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(535, 16);
            this.label12.TabIndex = 12;
            this.label12.Text = "label12";
            // 
            // statLabel
            // 
            this.statLabel.BackColor = System.Drawing.Color.DodgerBlue;
            this.statLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.statLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statLabel.Location = new System.Drawing.Point(628, 158);
            this.statLabel.Name = "statLabel";
            this.statLabel.Size = new System.Drawing.Size(219, 145);
            this.statLabel.TabIndex = 13;
            this.statLabel.Text = "Statistics";
            // 
            // startGameBtn
            // 
            this.startGameBtn.BackColor = System.Drawing.Color.Lime;
            this.startGameBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startGameBtn.ForeColor = System.Drawing.Color.Blue;
            this.startGameBtn.Location = new System.Drawing.Point(642, 47);
            this.startGameBtn.Name = "startGameBtn";
            this.startGameBtn.Size = new System.Drawing.Size(190, 66);
            this.startGameBtn.TabIndex = 14;
            this.startGameBtn.Text = "Start Game";
            this.startGameBtn.UseVisualStyleBackColor = false;
            this.startGameBtn.Click += new System.EventHandler(this.startGameBtn_Click);
            // 
            // gameStatLbl
            // 
            this.gameStatLbl.BackColor = System.Drawing.Color.DodgerBlue;
            this.gameStatLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gameStatLbl.Location = new System.Drawing.Point(24, 29);
            this.gameStatLbl.Name = "gameStatLbl";
            this.gameStatLbl.Size = new System.Drawing.Size(486, 79);
            this.gameStatLbl.TabIndex = 15;
            // 
            // gameStatBox
            // 
            this.gameStatBox.BackColor = System.Drawing.Color.Lime;
            this.gameStatBox.Controls.Add(this.gameStatLbl);
            this.gameStatBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameStatBox.Location = new System.Drawing.Point(32, 583);
            this.gameStatBox.Name = "gameStatBox";
            this.gameStatBox.Size = new System.Drawing.Size(532, 129);
            this.gameStatBox.TabIndex = 16;
            this.gameStatBox.TabStop = false;
            this.gameStatBox.Text = "Game Status";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(967, 797);
            this.Controls.Add(this.gameStatBox);
            this.Controls.Add(this.startGameBtn);
            this.Controls.Add(this.statLabel);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lbl22);
            this.Controls.Add(this.lbl21);
            this.Controls.Add(this.lbl20);
            this.Controls.Add(this.lbl12);
            this.Controls.Add(this.lbl11);
            this.Controls.Add(this.lbl10);
            this.Controls.Add(this.lbl02);
            this.Controls.Add(this.lbl01);
            this.Controls.Add(this.lbl00);
            this.Name = "Form1";
            this.Text = "Tic Tac Toe";
            this.gameStatBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl00;
        private System.Windows.Forms.Label lbl01;
        private System.Windows.Forms.Label lbl02;
        private System.Windows.Forms.Label lbl12;
        private System.Windows.Forms.Label lbl11;
        private System.Windows.Forms.Label lbl10;
        private System.Windows.Forms.Label lbl22;
        private System.Windows.Forms.Label lbl21;
        private System.Windows.Forms.Label lbl20;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label statLabel;
        private System.Windows.Forms.Button startGameBtn;
        private System.Windows.Forms.Label gameStatLbl;
        private System.Windows.Forms.GroupBox gameStatBox;
    }
}

