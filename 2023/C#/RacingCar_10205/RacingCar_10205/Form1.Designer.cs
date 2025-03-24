
namespace RacingCar_10205
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.ldl_GameOver = new System.Windows.Forms.Label();
            this.Coin1 = new System.Windows.Forms.PictureBox();
            this.EnemyCar2 = new System.Windows.Forms.PictureBox();
            this.EnemyCar1 = new System.Windows.Forms.PictureBox();
            this.MyCar = new System.Windows.Forms.PictureBox();
            this.LLine = new System.Windows.Forms.PictureBox();
            this.RLine = new System.Windows.Forms.PictureBox();
            this.Cline3 = new System.Windows.Forms.PictureBox();
            this.Cline2 = new System.Windows.Forms.PictureBox();
            this.Cline1 = new System.Windows.Forms.PictureBox();
            this.Coin2 = new System.Windows.Forms.PictureBox();
            this.Coin3 = new System.Windows.Forms.PictureBox();
            this.lbl_coin = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Coin1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyCar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyCar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cline3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cline2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cline1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coin2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coin3)).BeginInit();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 10;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // ldl_GameOver
            // 
            this.ldl_GameOver.AutoSize = true;
            this.ldl_GameOver.Font = new System.Drawing.Font("Tw Cen MT", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ldl_GameOver.Location = new System.Drawing.Point(69, 64);
            this.ldl_GameOver.Name = "ldl_GameOver";
            this.ldl_GameOver.Size = new System.Drawing.Size(246, 55);
            this.ldl_GameOver.TabIndex = 8;
            this.ldl_GameOver.Text = "Game Over";
            this.ldl_GameOver.Visible = false;
            // 
            // Coin1
            // 
            this.Coin1.Image = global::RacingCar_10205.Properties.Resources.dollar;
            this.Coin1.Location = new System.Drawing.Point(256, 244);
            this.Coin1.Name = "Coin1";
            this.Coin1.Size = new System.Drawing.Size(35, 38);
            this.Coin1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Coin1.TabIndex = 9;
            this.Coin1.TabStop = false;
            // 
            // EnemyCar2
            // 
            this.EnemyCar2.Image = global::RacingCar_10205.Properties.Resources.enemy_car;
            this.EnemyCar2.Location = new System.Drawing.Point(224, 12);
            this.EnemyCar2.Name = "EnemyCar2";
            this.EnemyCar2.Size = new System.Drawing.Size(100, 116);
            this.EnemyCar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EnemyCar2.TabIndex = 7;
            this.EnemyCar2.TabStop = false;
            // 
            // EnemyCar1
            // 
            this.EnemyCar1.Image = global::RacingCar_10205.Properties.Resources.enemy_car;
            this.EnemyCar1.Location = new System.Drawing.Point(50, 12);
            this.EnemyCar1.Name = "EnemyCar1";
            this.EnemyCar1.Size = new System.Drawing.Size(100, 116);
            this.EnemyCar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EnemyCar1.TabIndex = 6;
            this.EnemyCar1.TabStop = false;
            // 
            // MyCar
            // 
            this.MyCar.Image = global::RacingCar_10205.Properties.Resources.car__1_;
            this.MyCar.Location = new System.Drawing.Point(256, 359);
            this.MyCar.Name = "MyCar";
            this.MyCar.Size = new System.Drawing.Size(35, 68);
            this.MyCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.MyCar.TabIndex = 5;
            this.MyCar.TabStop = false;
            // 
            // LLine
            // 
            this.LLine.BackColor = System.Drawing.Color.White;
            this.LLine.Location = new System.Drawing.Point(12, -5);
            this.LLine.Name = "LLine";
            this.LLine.Size = new System.Drawing.Size(23, 460);
            this.LLine.TabIndex = 4;
            this.LLine.TabStop = false;
            // 
            // RLine
            // 
            this.RLine.BackColor = System.Drawing.Color.White;
            this.RLine.Location = new System.Drawing.Point(347, -5);
            this.RLine.Name = "RLine";
            this.RLine.Size = new System.Drawing.Size(23, 460);
            this.RLine.TabIndex = 3;
            this.RLine.TabStop = false;
            // 
            // Cline3
            // 
            this.Cline3.BackColor = System.Drawing.Color.White;
            this.Cline3.Location = new System.Drawing.Point(171, -37);
            this.Cline3.Name = "Cline3";
            this.Cline3.Size = new System.Drawing.Size(23, 98);
            this.Cline3.TabIndex = 2;
            this.Cline3.TabStop = false;
            // 
            // Cline2
            // 
            this.Cline2.BackColor = System.Drawing.Color.White;
            this.Cline2.Location = new System.Drawing.Point(171, 146);
            this.Cline2.Name = "Cline2";
            this.Cline2.Size = new System.Drawing.Size(23, 98);
            this.Cline2.TabIndex = 1;
            this.Cline2.TabStop = false;
            // 
            // Cline1
            // 
            this.Cline1.BackColor = System.Drawing.Color.White;
            this.Cline1.Location = new System.Drawing.Point(171, 329);
            this.Cline1.Name = "Cline1";
            this.Cline1.Size = new System.Drawing.Size(23, 98);
            this.Cline1.TabIndex = 0;
            this.Cline1.TabStop = false;
            // 
            // Coin2
            // 
            this.Coin2.Image = global::RacingCar_10205.Properties.Resources.dollar;
            this.Coin2.Location = new System.Drawing.Point(79, 244);
            this.Coin2.Name = "Coin2";
            this.Coin2.Size = new System.Drawing.Size(35, 38);
            this.Coin2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Coin2.TabIndex = 10;
            this.Coin2.TabStop = false;
            // 
            // Coin3
            // 
            this.Coin3.Image = global::RacingCar_10205.Properties.Resources.dollar;
            this.Coin3.Location = new System.Drawing.Point(79, 146);
            this.Coin3.Name = "Coin3";
            this.Coin3.Size = new System.Drawing.Size(35, 38);
            this.Coin3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Coin3.TabIndex = 11;
            this.Coin3.TabStop = false;
            // 
            // lbl_coin
            // 
            this.lbl_coin.AutoSize = true;
            this.lbl_coin.Font = new System.Drawing.Font("Magneto", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_coin.Location = new System.Drawing.Point(253, 190);
            this.lbl_coin.Name = "lbl_coin";
            this.lbl_coin.Size = new System.Drawing.Size(75, 19);
            this.lbl_coin.TabIndex = 12;
            this.lbl_coin.Text = "Coin : 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(382, 453);
            this.Controls.Add(this.lbl_coin);
            this.Controls.Add(this.Coin3);
            this.Controls.Add(this.Coin2);
            this.Controls.Add(this.Coin1);
            this.Controls.Add(this.ldl_GameOver);
            this.Controls.Add(this.EnemyCar2);
            this.Controls.Add(this.EnemyCar1);
            this.Controls.Add(this.MyCar);
            this.Controls.Add(this.LLine);
            this.Controls.Add(this.RLine);
            this.Controls.Add(this.Cline3);
            this.Controls.Add(this.Cline2);
            this.Controls.Add(this.Cline1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.Coin1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyCar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyCar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cline3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cline2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cline1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coin2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coin3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Cline1;
        private System.Windows.Forms.PictureBox Cline2;
        private System.Windows.Forms.PictureBox Cline3;
        private System.Windows.Forms.PictureBox RLine;
        private System.Windows.Forms.PictureBox LLine;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.PictureBox MyCar;
        private System.Windows.Forms.PictureBox EnemyCar1;
        private System.Windows.Forms.PictureBox EnemyCar2;
        private System.Windows.Forms.Label ldl_GameOver;
        private System.Windows.Forms.PictureBox Coin1;
        private System.Windows.Forms.PictureBox Coin2;
        private System.Windows.Forms.PictureBox Coin3;
        private System.Windows.Forms.Label lbl_coin;
    }
}

