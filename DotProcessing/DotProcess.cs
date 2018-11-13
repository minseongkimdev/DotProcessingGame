using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Media;

namespace DotProcessing
{
    class DotProcess
    {
        public Bitmap DOTMaking(Bitmap image, decimal size)
        {
            int width = image.Width;
            int height = image.Height;
            System.Drawing.Color tempcolor = new System.Drawing.Color();

            int scale = Convert.ToInt32(Math.Truncate(size / 2));
            int intsize = Convert.ToInt32(size);

            Bitmap output = new Bitmap(image);



            int red = 0;
            int green = 0;
            int blue = 0;

            for (int i = scale; i < width - scale; i = i + scale)
            {
                for (int j = scale; j < height - scale; j = j + scale)
                {
                    //for (int k = -scale; k < scale; k++)
                    //{
                    //    for (int l = -scale; l < scale; l++)
                    //    {
                    //        red = red + image.GetPixel(i + k, j + l).R;
                    //        green = green + image.GetPixel(i + k, j + l).G;
                    //        blue = blue + image.GetPixel(i + k, j + l).B;
                    //    }
                    //}
                    //red = red / (intsize * intsize);
                    //green = green / (intsize * intsize);
                    //blue = blue / (intsize * intsize);
                    //tempcolor = System.Drawing.Color.FromArgb(red, green, blue);

                    //output.SetPixel(i, j, tempcolor);

                    //for (int k = -scale; k < scale; k++)
                    //{
                    //    for (int l = -scale; l < scale; l++)
                    //    {
                    //        image.SetPixel(i + k, j + l, tempcolor);
                    //    }
                    //}

                    for (int k = -scale; k < scale; k++)
                    {
                        for (int l = -scale; l < scale; l++)
                        {
                            output.SetPixel(i + k, j + l, image.GetPixel(i, j));
                        }
                    }
                }
            }

            return output;
        }
        public Bitmap DOTMaking_better(Bitmap image, decimal size)
        {
            int width = image.Width;
            int height = image.Height;
            System.Drawing.Color tempcolor = new System.Drawing.Color();

            int scale = Convert.ToInt32(Math.Truncate(size / 2));
            int intsize = Convert.ToInt32(size);

            Bitmap output = new Bitmap(image);
            

            for (int i = scale; i < width - scale; i = i + scale)
            {
                for (int j = scale; j < height - scale; j = j + scale)
                {
                    for (int k = -scale; k < scale; k++)
                    {
                        output.SetPixel(i + k, j, image.GetPixel(i, j));
                    }
                    for (int l = -scale; l < scale; l++)
                    {
                        output.SetPixel(i, j + l, image.GetPixel(i, j));
                    }
                }
            }
            return output;
        }

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
