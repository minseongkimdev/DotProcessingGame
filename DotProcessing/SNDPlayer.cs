using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BgmPlayer
{
    class SNDPlayer
    {
        public void PlayBGM()
        {
            SoundPlayer bgm = new SoundPlayer(DotProcessing.Properties.Resources.bgm); // bgm의 경로
            bgm.PlayLooping();
        }
        public void PlayEffect(int botton)
        {
            SoundPlayer effect;
            switch (botton)
            {
                case 0:
                    effect = new SoundPlayer(DotProcessing.Properties.Resources.correct); // correct의 경로
                    effect.PlaySync();
                    break;
                case 1:
                    effect = new SoundPlayer(DotProcessing.Properties.Resources.wrong);    // wrong의 경로
                    effect.PlaySync();
                    break;
                case 2:
                    effect = new SoundPlayer(DotProcessing.Properties.Resources.levelup);    // levelup의 경로
                    effect.PlaySync();
                    break;
            }
            PlayBGM();
        }
    }
}
