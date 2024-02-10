namespace TTS_Beta_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void cooloff(int millisecs)
        {
            DateTime Tthen = DateTime.Now;
            do
            {
                Application.DoEvents();
            } 
            while (Tthen.AddMilliseconds(millisecs) > DateTime.Now);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer v = new System.Media.SoundPlayer(@"c:\V.wav");
            System.Media.SoundPlayer g = new System.Media.SoundPlayer(@"c:\G.wav");
            System.Media.SoundPlayer d = new System.Media.SoundPlayer(@"c:\D.wav");
            System.Media.SoundPlayer ea = new System.Media.SoundPlayer(@"c:\E.wav");
            System.Media.SoundPlayer b = new System.Media.SoundPlayer(@"c:\B.wav");
            System.Media.SoundPlayer a = new System.Media.SoundPlayer(@"c:\A.wav");
            System.Media.SoundPlayer z = new System.Media.SoundPlayer(@"c:\Z.wav");
            System.Media.SoundPlayer th = new System.Media.SoundPlayer(@"c:\T.wav");
            System.Media.SoundPlayer i = new System.Media.SoundPlayer(@"c:\I.wav");
            System.Media.SoundPlayer k = new System.Media.SoundPlayer(@"c:\K.wav");
            System.Media.SoundPlayer ky = new System.Media.SoundPlayer(@"c:\KY.wav");
            System.Media.SoundPlayer l = new System.Media.SoundPlayer(@"c:\L.wav");
            System.Media.SoundPlayer m = new System.Media.SoundPlayer(@"c:\M.wav");
            System.Media.SoundPlayer n = new System.Media.SoundPlayer(@"c:\N.wav");
            System.Media.SoundPlayer o = new System.Media.SoundPlayer(@"c:\O.wav");
            System.Media.SoundPlayer p = new System.Media.SoundPlayer(@"c:\P.wav");
            System.Media.SoundPlayer zh = new System.Media.SoundPlayer(@"c:\ZH.wav");
            System.Media.SoundPlayer r = new System.Media.SoundPlayer(@"c:\R.wav");
            System.Media.SoundPlayer s = new System.Media.SoundPlayer(@"c:\S.wav");
            System.Media.SoundPlayer t = new System.Media.SoundPlayer(@"c:\T.wav");
            System.Media.SoundPlayer u = new System.Media.SoundPlayer(@"c:\U.wav");
            System.Media.SoundPlayer f = new System.Media.SoundPlayer(@"c:\F.wav");
            System.Media.SoundPlayer q = new System.Media.SoundPlayer(@"c:\Q.wav");
            System.Media.SoundPlayer gh = new System.Media.SoundPlayer(@"c:\GH.wav");
            System.Media.SoundPlayer sh = new System.Media.SoundPlayer(@"c:\SH.wav");
            System.Media.SoundPlayer ch = new System.Media.SoundPlayer(@"c:\CH.wav");
            System.Media.SoundPlayer c = new System.Media.SoundPlayer(@"c:\C.wav");
            System.Media.SoundPlayer dz = new System.Media.SoundPlayer(@"c:\DZ.wav");
            System.Media.SoundPlayer w = new System.Media.SoundPlayer(@"c:\W.wav");
            System.Media.SoundPlayer tch = new System.Media.SoundPlayer(@"c:\TCH.wav");
            System.Media.SoundPlayer h = new System.Media.SoundPlayer(@"c:\H.wav");
            System.Media.SoundPlayer j = new System.Media.SoundPlayer(@"c:\J.wav");
            System.Media.SoundPlayer x = new System.Media.SoundPlayer(@"c:\X.wav");






            string text = noVoice.Text;
            int count = text.Length;
            int sp = 0;
            for (int ji = 0; ji < count; ji++)
            {
                switch (text[ji])
                {
                    case ' ':
                        Thread.Sleep(750);
                        break;
                    case 'ა':
                        a.PlaySync();
                        break;
                    case 'ბ':
                        b.PlaySync();
                        break;
                    case 'გ':
                        g.PlaySync();
                        break;
                    case 'დ':
                        d.PlaySync();
                        break;
                    case 'ე':
                        ea.PlaySync();
                        break;
                    case 'ვ':
                        v.PlaySync();
                        break;
                    case 'ზ':
                        z.PlaySync();
                        break;
                    case 'თ':
                        th.PlaySync();
                        break;
                    case 'ი':
                        i.PlaySync();
                        break;
                    case 'კ':
                        k.PlaySync();
                        break;
                    case 'ყ':
                        ky.PlaySync();
                        break;
                    case 'ლ':
                        l.PlaySync();
                        break;
                    case 'მ':
                        m.PlaySync();
                        break;
                    case 'ნ':
                        n.PlaySync();
                        break;
                    case 'ო':
                        o.PlaySync();
                        break;
                    case 'პ':
                        p.PlaySync();
                        break;
                    case 'ჟ':
                        zh.PlaySync();
                        break;
                    case 'რ':
                        r.PlaySync();
                        break;
                    case 'ს':
                        s.PlaySync();
                        break;
                    case 'ტ':
                        t.PlaySync();
                        break;
                    case 'უ':
                        u.PlaySync();
                        break;
                    case 'ფ':
                        f.PlaySync();
                        break;
                    case 'ქ':
                        q.PlaySync();
                        break;
                    case 'ღ':
                        gh.PlaySync();
                        break;
                    case 'შ':
                        sh.PlaySync();
                        break;
                    case 'ჩ':
                        ch.PlaySync();
                        break;
                    case 'ც':
                        c.PlaySync();
                        break;
                    case 'ძ':
                        dz.PlaySync();
                        break;
                    case 'წ':
                        w.PlaySync();
                        break;
                    case 'ჭ':
                        tch.PlaySync();
                        break;
                    case 'ხ':
                        x.PlaySync();
                        break;
                    case 'ჯ':
                        j.PlaySync();
                        break;
                    case 'ჰ':
                        h.PlaySync();
                        break;
                }
            }
        }
    }
}





















