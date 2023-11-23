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
            } while (Tthen.AddMilliseconds(millisecs) > DateTime.Now);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer g = new System.Media.SoundPlayer(@"c:\G.wav");
            System.Media.SoundPlayer d = new System.Media.SoundPlayer(@"c:\D.wav");
            System.Media.SoundPlayer ea = new System.Media.SoundPlayer(@"c:\E.wav");
            System.Media.SoundPlayer b = new System.Media.SoundPlayer(@"c:\B.wav");
            System.Media.SoundPlayer a = new System.Media.SoundPlayer(@"c:\A.wav");
            string voice = noVoice.Text;
            int count = voice.Length;
            int sp = 350;
            for (int ji = 0; ji < count; ji++)
            {
                switch (voice[ji])
                {
                    case ' ':
                        break;
                    case 'ა':

                        a.Play();
                        break;
                    case 'ბ':
                        b.Play();
                        break;
                    case 'გ':

                        g.Play();
                        break;
                    case 'დ':

                        d.Play();
                        break;
                    case 'ე':
                        ea.Play();
                        Thread.Sleep(150);

                        break;
                        

                }
                cooloff(sp);

            }
        }
    }

}



















/*
 /* case 'ვ':
                             System.Media.SoundPlayer v = new System.Media.SoundPlayer(@"c:\mywavfile.wav");
                             v.Play();
                             break;
                         case 'ზ':
                             System.Media.SoundPlayer z = new System.Media.SoundPlayer(@"c:\mywavfile.wav");
                             z.Play();
                             break;
                         case 'თ':
                             System.Media.SoundPlayer th = new System.Media.SoundPlayer(@"c:\mywavfile.wav");
                             th.Play();
                             break;
                         case 'ი':
                             System.Media.SoundPlayer i = new System.Media.SoundPlayer(@"c:\mywavfile.wav");
                             i.Play();
                             break;
                         case'კ':
                             System.Media.SoundPlayer k = new System.Media.SoundPlayer(@"c:\mywavfile.wav");
                             k.Play();
                             break;
                         case 'ყ':
                             System.Media.SoundPlayer ky = new System.Media.SoundPlayer(@"c:\mywavfile.wav");
                             ky.Play();
                             break;
                         case 'ლ':
                             System.Media.SoundPlayer l = new System.Media.SoundPlayer(@"c:\mywavfile.wav");
                             l.Play();
                             break;
                         case 'მ':
                             System.Media.SoundPlayer m = new System.Media.SoundPlayer(@"c:\mywavfile.wav");
                             m.Play();
                             break;
                         case 'ნ':
                             System.Media.SoundPlayer n = new System.Media.SoundPlayer(@"c:\mywavfile.wav");
                             n.Play();
                             break;
                         case 'ო':
                             System.Media.SoundPlayer o = new System.Media.SoundPlayer(@"c:\mywavfile.wav");
                             o.Play();
                             break;
                         case 'პ':
                             System.Media.SoundPlayer p = new System.Media.SoundPlayer(@"c:\mywavfile.wav");
                             p.Play();
                             break;
                         case 'ჟ':
                             System.Media.SoundPlayer zh = new System.Media.SoundPlayer(@"c:\mywavfile.wav");
                             zh.Play();
                             break;
                         case 'რ':
                             System.Media.SoundPlayer r = new System.Media.SoundPlayer(@"c:\mywavfile.wav");
                             r.Play();
                             break;
                         case 'ს':
                             System.Media.SoundPlayer s = new System.Media.SoundPlayer(@"c:\mywavfile.wav");
                             s.Play();
                             break;
                         case 'ტ':
                             System.Media.SoundPlayer t = new System.Media.SoundPlayer(@"c:\mywavfile.wav");
                             t.Play();
                             break;
                         case 'უ':
                             System.Media.SoundPlayer u = new System.Media.SoundPlayer(@"c:\mywavfile.wav");
                             u.Play();
                             break;
                         case 'ფ':
                             System.Media.SoundPlayer f = new System.Media.SoundPlayer(@"c:\mywavfile.wav");
                             f.Play();
                             break;
                         case 'ქ':
                             System.Media.SoundPlayer q = new System.Media.SoundPlayer(@"c:\mywavfile.wav");
                             q.Play();
                             break;
                         case 'ღ':
                             System.Media.SoundPlayer gh = new System.Media.SoundPlayer(@"c:\mywavfil e.wav");
                             gh.Play();
                             break;
                         case 'შ':
                             System.Media.SoundPlayer sh = new System.Media.SoundPlayer(@"c:\mywavfile.wav");
                             sh.Play();
                             break;
                         case 'ჩ':
                             System.Media.SoundPlayer ch = new System.Media.SoundPlayer(@"c:\mywavfile.wav");
                             ch.Play();
                             break;
                         case 'ც':
                             System.Media.SoundPlayer c = new System.Media.SoundPlayer(@"c:\mywavfile.wav");
                             c.Play();
                             break;
                         case 'ძ':
                             System.Media.SoundPlayer dz = new System.Media.SoundPlayer(@"c:\mywavfile.wav");
                             dz.Play();
                             break;
                         case 'წ':
                             System.Media.SoundPlayer w = new System.Media.SoundPlayer(@"c:\mywavfile.wav");
                             w.Play();
                             break;
                         case 'ჭ':
                             System.Media.SoundPlayer tch = new System.Media.SoundPlayer(@"c:\mywavfile.wav");
                             tch.Play();
                             break;
                         case 'ხ':
                             System.Media.SoundPlayer x = new System.Media.SoundPlayer(@"c:\mywavfile.wav");
                             x.Play();
                             break;
                         case 'ჯ':
                             System.Media.SoundPlayer j = new System.Media.SoundPlayer(@"c:\mywavfile.wav");
                             j.Play();
                             break;
                         case 'ჰ':
                             System.Media.SoundPlayer h = new System.Media.SoundPlayer(@"c:\mywavfile.wav");
                             h.Play();
                             break;*/
*/