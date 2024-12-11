using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDVX_Raing
{
    public partial class SongControl : UserControl
    {
        public SongControl()
        {
            InitializeComponent();
        }

        public void SetSongInfo(string title, double bolforce, string difficulty, int rank)
        {
            titleLabel.Text = title; // 제목 표시
            volforceLabel.Text = bolforce.ToString("F3"); // 볼포스 값 표시
            difficultyLabel.Text = difficulty; // 난이도 표시
            rankLabel.Text = rank.ToString(); // 등수 표시
        }

        private void titleLabel_Click(object sender, EventArgs e)
        {

        }

        private void volforceLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
