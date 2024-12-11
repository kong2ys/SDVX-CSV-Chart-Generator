using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDVX_Raing
{
    public partial class Form1 : Form
    {
        private List<Song> songs = new List<Song>();
        public Form1()
        {
            InitializeComponent();
        }

        private void OnClick_btnLoadCSV(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    LoadData(openFileDialog.FileName);
                }
            }
        }

        private void LoadData(string filePath)
        {
            int dataLength = 11;

            songs.Clear();

            using (var reader = new StreamReader(filePath))
            {
                reader.ReadLine();
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    if (values.Length < dataLength)
                    {
                        Console.WriteLine($"데이터 부족: {line}");
                        continue;
                    }

                    var song = new Song
                    {
                        Title = values[0],
                        Difficulty = values[1],
                        Level = int.Parse(values[2]),
                        ClearRank = values[3],
                        ScoreGrade = values[4],
                        HighScore = int.Parse(values[5]),
                        ExScore = int.Parse(values[6]),
                        PlayCount = int.Parse(values[7]),
                        ClearCount = int.Parse(values[8]),
                        UltimateChain = int.Parse(values[9]),
                        Perfect = int.Parse(values[10]),
                    };

                    songs.Add(song);
                }
            }
        }

        private void OnClick_btnConfirm(object sender, EventArgs e)
        {
            // 볼포스 값 계산 및 정렬
            var volforces = songs.Select(s => new
            {
                s.Title,
                Volforce = s.CalculateVolforce(),
                s.Difficulty,
            })
            .OrderByDescending(b => b.Volforce)
            .Select((song, index) => new
            {
                song.Title,
                song.Volforce,
                song.Difficulty,
                Rank = index + 1 // 등수 추가
            })
            .Take(50) // 볼포스 상위 50곡
            .ToList();

            // FlowLayoutPanel에 곡 정보 추가
            flowLayoutPanel.Controls.Clear();
            foreach (var song in volforces)
            {
                var songControl = new SongControl();
                songControl.SetSongInfo(song.Title, song.Volforce, song.Difficulty, song.Rank);
                flowLayoutPanel.Controls.Add(songControl);
            }
        }

        public class Song
        {
            public string Title { get; set; }
            public string Difficulty { get; set; }
            public int Level { get; set; }
            public string ClearRank { get; set; }
            public string ScoreGrade { get; set; }
            public int HighScore { get; set; }
            public int ExScore { get; set; }
            public int PlayCount { get; set; }
            public int ClearCount { get; set; }
            public int UltimateChain { get; set; }
            public int Perfect { get; set; }

            public double CalculateVolforce()
            {
                double clearRankCoefficient = ClearRank switch
                {
                    "PERFECT" => 1.1,
                    "ULTIMATE CHAIN" => 1.05,
                    "EXCESSIVE COMPLETE" => 1.02,
                    "COMPLETE" => 1,
                    "PLAYED" => 0.5,
                    _ => 0
                };

                double gradeCoefficient = ScoreGrade switch
                {
                    "S" => 1.05,
                    "AAA+" => 1.02,
                    "AAA" => 1,
                    "AA+" => 0.97,
                    _ => 1
                };

                return (Level * 2 * HighScore / 10_000_000.0) * clearRankCoefficient * gradeCoefficient;
            }
        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
