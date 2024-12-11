namespace SDVX_Raing
{
    partial class SongControl
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

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.titleLabel = new System.Windows.Forms.Label();
            this.volforceLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rankLabel = new System.Windows.Forms.Label();
            this.difficultyLabel = new System.Windows.Forms.Label();
            this.Linelabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.Black;
            this.titleLabel.Font = new System.Drawing.Font("Pretendard ExtraBold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(28, 18);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(64, 29);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Title";
            this.titleLabel.Click += new System.EventHandler(this.titleLabel_Click);
            // 
            // volforceLabel
            // 
            this.volforceLabel.AutoSize = true;
            this.volforceLabel.BackColor = System.Drawing.Color.Black;
            this.volforceLabel.Font = new System.Drawing.Font("Noto Sans CJK KR Bold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.volforceLabel.ForeColor = System.Drawing.Color.White;
            this.volforceLabel.Location = new System.Drawing.Point(175, 61);
            this.volforceLabel.Name = "volforceLabel";
            this.volforceLabel.Size = new System.Drawing.Size(73, 59);
            this.volforceLabel.TabIndex = 1;
            this.volforceLabel.Text = "39";
            this.volforceLabel.Click += new System.EventHandler(this.volforceLabel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 18);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 18);
            this.label2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "label4";
            // 
            // rankLabel
            // 
            this.rankLabel.AutoSize = true;
            this.rankLabel.BackColor = System.Drawing.Color.Black;
            this.rankLabel.Font = new System.Drawing.Font("Pretendard ExtraBold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rankLabel.ForeColor = System.Drawing.Color.IndianRed;
            this.rankLabel.Location = new System.Drawing.Point(-1, 18);
            this.rankLabel.Name = "rankLabel";
            this.rankLabel.Size = new System.Drawing.Size(23, 24);
            this.rankLabel.TabIndex = 4;
            this.rankLabel.Text = "R";
            // 
            // difficultyLabel
            // 
            this.difficultyLabel.AutoSize = true;
            this.difficultyLabel.BackColor = System.Drawing.Color.Black;
            this.difficultyLabel.Font = new System.Drawing.Font("Pretendard ExtraBold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.difficultyLabel.ForeColor = System.Drawing.Color.LightGray;
            this.difficultyLabel.Location = new System.Drawing.Point(28, 84);
            this.difficultyLabel.Name = "difficultyLabel";
            this.difficultyLabel.Size = new System.Drawing.Size(74, 29);
            this.difficultyLabel.TabIndex = 5;
            this.difficultyLabel.Text = "Level";
            // 
            // Linelabel
            // 
            this.Linelabel.AutoSize = true;
            this.Linelabel.Font = new System.Drawing.Font("배달의민족 도현", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Linelabel.ForeColor = System.Drawing.Color.White;
            this.Linelabel.Location = new System.Drawing.Point(1, 47);
            this.Linelabel.Name = "Linelabel";
            this.Linelabel.Size = new System.Drawing.Size(316, 21);
            this.Linelabel.TabIndex = 6;
            this.Linelabel.Text = "ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ";
            // 
            // SongControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.Linelabel);
            this.Controls.Add(this.difficultyLabel);
            this.Controls.Add(this.rankLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.volforceLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.titleLabel);
            this.Name = "SongControl";
            this.Size = new System.Drawing.Size(320, 130);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label volforceLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label rankLabel;
        private System.Windows.Forms.Label difficultyLabel;
        private System.Windows.Forms.Label Linelabel;
    }
}
