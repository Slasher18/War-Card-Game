namespace War_Card_Game
{
    partial class WarCardGame
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
            this.listBoxPlayerWar = new System.Windows.Forms.ListBox();
            this.listBoxCompWar = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxPlayerDiscard = new System.Windows.Forms.ListBox();
            this.listBoxCompDiscard = new System.Windows.Forms.ListBox();
            this.listBoxPlayerWon = new System.Windows.Forms.ListBox();
            this.listBoxCompWon = new System.Windows.Forms.ListBox();
            this.PlayerWon = new System.Windows.Forms.Label();
            this.PlayerDiscard = new System.Windows.Forms.Label();
            this.CompDiscard = new System.Windows.Forms.Label();
            this.CompWon = new System.Windows.Forms.Label();
            this.buttonPlayTurn = new System.Windows.Forms.Button();
            this.buttonNewGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxPlayerWar
            // 
            this.listBoxPlayerWar.FormattingEnabled = true;
            this.listBoxPlayerWar.ItemHeight = 16;
            this.listBoxPlayerWar.Location = new System.Drawing.Point(255, 60);
            this.listBoxPlayerWar.Name = "listBoxPlayerWar";
            this.listBoxPlayerWar.Size = new System.Drawing.Size(120, 116);
            this.listBoxPlayerWar.TabIndex = 0;
            // 
            // listBoxCompWar
            // 
            this.listBoxCompWar.FormattingEnabled = true;
            this.listBoxCompWar.ItemHeight = 16;
            this.listBoxCompWar.Location = new System.Drawing.Point(400, 60);
            this.listBoxCompWar.Name = "listBoxCompWar";
            this.listBoxCompWar.Size = new System.Drawing.Size(120, 116);
            this.listBoxCompWar.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(252, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "PlayerWarPile";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(414, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "CompWarPile";
            // 
            // listBoxPlayerDiscard
            // 
            this.listBoxPlayerDiscard.FormattingEnabled = true;
            this.listBoxPlayerDiscard.ItemHeight = 16;
            this.listBoxPlayerDiscard.Location = new System.Drawing.Point(129, 60);
            this.listBoxPlayerDiscard.Name = "listBoxPlayerDiscard";
            this.listBoxPlayerDiscard.Size = new System.Drawing.Size(120, 260);
            this.listBoxPlayerDiscard.TabIndex = 4;
            // 
            // listBoxCompDiscard
            // 
            this.listBoxCompDiscard.FormattingEnabled = true;
            this.listBoxCompDiscard.ItemHeight = 16;
            this.listBoxCompDiscard.Location = new System.Drawing.Point(526, 60);
            this.listBoxCompDiscard.Name = "listBoxCompDiscard";
            this.listBoxCompDiscard.Size = new System.Drawing.Size(120, 260);
            this.listBoxCompDiscard.TabIndex = 5;
            // 
            // listBoxPlayerWon
            // 
            this.listBoxPlayerWon.FormattingEnabled = true;
            this.listBoxPlayerWon.ItemHeight = 16;
            this.listBoxPlayerWon.Location = new System.Drawing.Point(3, 60);
            this.listBoxPlayerWon.Name = "listBoxPlayerWon";
            this.listBoxPlayerWon.Size = new System.Drawing.Size(120, 260);
            this.listBoxPlayerWon.TabIndex = 6;
            // 
            // listBoxCompWon
            // 
            this.listBoxCompWon.FormattingEnabled = true;
            this.listBoxCompWon.ItemHeight = 16;
            this.listBoxCompWon.Location = new System.Drawing.Point(668, 60);
            this.listBoxCompWon.Name = "listBoxCompWon";
            this.listBoxCompWon.Size = new System.Drawing.Size(120, 260);
            this.listBoxCompWon.TabIndex = 7;
            // 
            // PlayerWon
            // 
            this.PlayerWon.AutoSize = true;
            this.PlayerWon.Location = new System.Drawing.Point(12, 41);
            this.PlayerWon.Name = "PlayerWon";
            this.PlayerWon.Size = new System.Drawing.Size(74, 16);
            this.PlayerWon.TabIndex = 8;
            this.PlayerWon.Text = "PlayerWon";
            // 
            // PlayerDiscard
            // 
            this.PlayerDiscard.AutoSize = true;
            this.PlayerDiscard.Location = new System.Drawing.Point(138, 41);
            this.PlayerDiscard.Name = "PlayerDiscard";
            this.PlayerDiscard.Size = new System.Drawing.Size(93, 16);
            this.PlayerDiscard.TabIndex = 9;
            this.PlayerDiscard.Text = "PlayerDiscard";
            // 
            // CompDiscard
            // 
            this.CompDiscard.AutoSize = true;
            this.CompDiscard.Location = new System.Drawing.Point(549, 41);
            this.CompDiscard.Name = "CompDiscard";
            this.CompDiscard.Size = new System.Drawing.Size(90, 16);
            this.CompDiscard.TabIndex = 10;
            this.CompDiscard.Text = "CompDiscard";
            // 
            // CompWon
            // 
            this.CompWon.AutoSize = true;
            this.CompWon.Location = new System.Drawing.Point(684, 41);
            this.CompWon.Name = "CompWon";
            this.CompWon.Size = new System.Drawing.Size(71, 16);
            this.CompWon.TabIndex = 11;
            this.CompWon.Text = "CompWon";
            // 
            // buttonPlayTurn
            // 
            this.buttonPlayTurn.Location = new System.Drawing.Point(351, 201);
            this.buttonPlayTurn.Name = "buttonPlayTurn";
            this.buttonPlayTurn.Size = new System.Drawing.Size(75, 23);
            this.buttonPlayTurn.TabIndex = 12;
            this.buttonPlayTurn.Text = "Play Turn";
            this.buttonPlayTurn.UseVisualStyleBackColor = true;
            this.buttonPlayTurn.Click += new System.EventHandler(this.buttonPlayTurn_Click);
            // 
            // buttonNewGame
            // 
            this.buttonNewGame.Location = new System.Drawing.Point(335, 317);
            this.buttonNewGame.Name = "buttonNewGame";
            this.buttonNewGame.Size = new System.Drawing.Size(102, 23);
            this.buttonNewGame.TabIndex = 13;
            this.buttonNewGame.Text = "New Game";
            this.buttonNewGame.UseVisualStyleBackColor = true;
            this.buttonNewGame.Click += new System.EventHandler(this.buttonNewGame_Click);
            // 
            // WarCardGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonNewGame);
            this.Controls.Add(this.buttonPlayTurn);
            this.Controls.Add(this.CompWon);
            this.Controls.Add(this.CompDiscard);
            this.Controls.Add(this.PlayerDiscard);
            this.Controls.Add(this.PlayerWon);
            this.Controls.Add(this.listBoxCompWon);
            this.Controls.Add(this.listBoxPlayerWon);
            this.Controls.Add(this.listBoxCompDiscard);
            this.Controls.Add(this.listBoxPlayerDiscard);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxCompWar);
            this.Controls.Add(this.listBoxPlayerWar);
            this.Name = "WarCardGame";
            this.Text = "WarGame";
            this.Load += new System.EventHandler(this.WarCardGame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxPlayerWar;
        private System.Windows.Forms.ListBox listBoxCompWar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxPlayerDiscard;
        private System.Windows.Forms.ListBox listBoxCompDiscard;
        private System.Windows.Forms.ListBox listBoxPlayerWon;
        private System.Windows.Forms.ListBox listBoxCompWon;
        private System.Windows.Forms.Label PlayerWon;
        private System.Windows.Forms.Label PlayerDiscard;
        private System.Windows.Forms.Label CompDiscard;
        private System.Windows.Forms.Label CompWon;
        private System.Windows.Forms.Button buttonPlayTurn;
        private System.Windows.Forms.Button buttonNewGame;
    }
}

