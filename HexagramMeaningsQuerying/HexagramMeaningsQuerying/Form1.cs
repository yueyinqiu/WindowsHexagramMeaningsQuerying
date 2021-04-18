using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YiJingFramework.Core;
using YiJingFramework.References.Zhouyi;

namespace HexagramMeaningsQuerying
{
    public partial class Form1 : Form
    {
        readonly Zhouyi zhouyi = new Zhouyi("zhouyi.json");
        public Form1()
        {
            this.InitializeComponent();
            this.RandomHexagram(null, null);
        }

        private void Show(ZhouyiHexagram hexagram)
        {
            this.NameBox.Text = hexagram.Name;
            this.PaintingBox.Text = hexagram.GetPainting().ToString();
            this.LowerBox.Text = hexagram.LowerTrigram.Name;
            this.UpperBox.Text = hexagram.UpperTrigram.Name;
            this.MeaningsBox.Text = hexagram.ToString();
        }
        private void GetByPainting(object sender, EventArgs e)
        {
            if (!Painting.TryParse(this.PaintingBox.Text, out var painting))
            {
                this.MeaningsBox.Text = "请正确输入。";
                return;
            }
            if (painting.Count != 6)
            {
                this.MeaningsBox.Text = "请输入六根爻。";
                return;
            }
            var hexagram = zhouyi.GetHexagram(painting);
            this.Show(hexagram);
        }

        private static string CutName(string s)
        {
            if (s.EndsWith('卦'))
                return s[0..^1];
            return s;
        }

        private void GetByName(object sender, EventArgs e)
        {
            if (!zhouyi.TryGetHexagram(CutName(this.NameBox.Text), out var hexagram))
            {
                this.MeaningsBox.Text = "未找到此卦。";
                return;
            }
            this.Show(hexagram);
        }

        private void GetByTwoTrigrams(object sender, EventArgs e)
        {
            var lname = CutName(this.LowerBox.Text);
            if (lname.Length != 1 || !zhouyi.TryGetTrigram(lname, out var l))
            {
                this.MeaningsBox.Text = "未找到指定主卦。";
                return;
            }
            var uname = CutName(this.UpperBox.Text);
            if (uname.Length != 1 || !zhouyi.TryGetTrigram(uname, out var u))
            {
                this.MeaningsBox.Text = "未找到指定客卦。";
                return;
            }
            Painting painting = new Painting(l.GetPainting().Concat(u.GetPainting()));
            this.Show(zhouyi.GetHexagram(painting));
        }

        private readonly Random random = new Random();
        private void RandomHexagram(object sender, EventArgs e)
        {
            var painting = new Painting(
                (LineAttribute)random.Next(0, 2),
                (LineAttribute)random.Next(0, 2),
                (LineAttribute)random.Next(0, 2),
                (LineAttribute)random.Next(0, 2),
                (LineAttribute)random.Next(0, 2),
                (LineAttribute)random.Next(0, 2));
            this.Show(zhouyi.GetHexagram(painting));
        }
    }
}
