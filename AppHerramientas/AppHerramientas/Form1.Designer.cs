namespace AppHerramientas
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
            components = new System.ComponentModel.Container();
            txtscore = new Label();
            player = new PictureBox();
            ball = new PictureBox();
            gametimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)player).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ball).BeginInit();
            SuspendLayout();
            // 
            // txtscore
            // 
            txtscore.AutoSize = true;
            txtscore.BackColor = Color.FromArgb(255, 192, 255);
            txtscore.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtscore.Location = new Point(21, 20);
            txtscore.Name = "txtscore";
            txtscore.Size = new Size(74, 18);
            txtscore.TabIndex = 0;
            txtscore.Text = "Puntos:0";
            // 
            // player
            // 
            player.BackColor = Color.FromArgb(255, 192, 255);
            player.Location = new Point(338, 366);
            player.Name = "player";
            player.Size = new Size(100, 32);
            player.TabIndex = 1;
            player.TabStop = false;
            // 
            // ball
            // 
            ball.BackColor = Color.FromArgb(255, 192, 255);
            ball.Location = new Point(376, 319);
            ball.Name = "ball";
            ball.Size = new Size(27, 25);
            ball.TabIndex = 2;
            ball.TabStop = false;
            // 
            // gametimer
            // 
            gametimer.Interval = 20;
            gametimer.Tick += mainGameTimerEvent;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(767, 449);
            Controls.Add(ball);
            Controls.Add(player);
            Controls.Add(txtscore);
            Name = "Form1";
            Text = "Break Out Game MOO ICT";
            KeyDown += keyisdown;
            KeyUp += keyisup;
            ((System.ComponentModel.ISupportInitialize)player).EndInit();
            ((System.ComponentModel.ISupportInitialize)ball).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtscore;
        private PictureBox player;
        private PictureBox ball;
        private System.Windows.Forms.Timer gametimer;
    }
}