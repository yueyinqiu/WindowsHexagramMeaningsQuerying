using System;
using System.Linq;
using 周易;

namespace 卦辞爻辞查询
{
    public partial class MainForm : System.Windows.Forms.Form
    {
        public MainForm()
        {
            this.InitializeComponent();
            this.RandomHexagram(null, null);
        }

        private void Show(别卦 hexagram)
        {
            this.NameBox.Text = hexagram.卦名;
            this.PaintingBox.Text = hexagram.卦画.ToString();
            this.LowerBox.Text = hexagram.主卦.卦名.ToString();
            this.UpperBox.Text = hexagram.客卦.卦名.ToString();
            this.MeaningsBox.Text = hexagram.ToString();
        }
        private void GetByPainting(object sender, EventArgs e)
        {
            if (!卦画.TryParse(this.PaintingBox.Text, out var painting))
            {
                this.MeaningsBox.Text = "请正确输入。";
                return;
            }
            if (!别卦.获取别卦(painting, out var hexagram))
            {
                this.MeaningsBox.Text = "请输入六根爻。";
                return;
            }
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
            if (!别卦.获取别卦(CutName(this.NameBox.Text), out var hexagram))
            {
                this.MeaningsBox.Text = "未找到此卦。";
                return;
            }
            this.Show(hexagram);
        }

        private void GetByTwoTrigrams(object sender, EventArgs e)
        {
            var lname = CutName(this.LowerBox.Text);
            if (lname.Length != 1 || !经卦.获取经卦(lname[0], out var l))
            {
                this.MeaningsBox.Text = "未找到指定主卦。";
                return;
            }
            var uname = CutName(this.UpperBox.Text);
            if (uname.Length != 1 || !经卦.获取经卦(uname[0], out var u))
            {
                this.MeaningsBox.Text = "未找到指定客卦。";
                return;
            }
            if (!别卦.获取别卦(l, u, out var hexagram))
            {
                this.MeaningsBox.Text = "未知错误。";
                return;
            }
            this.Show(hexagram);
        }

        private readonly Random random = new Random();
        private void RandomHexagram(object sender, EventArgs e)
        {
            this.NameBox.Text = 
                别卦.全部别卦卦名.ElementAt(this.random.Next(0, 63));
            this.GetByName(null, null);
        }
    }
}