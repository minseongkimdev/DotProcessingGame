using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WinForm = System.Windows.Forms;
using System.Drawing;
using MahApps.Metro.Controls;
using System.Threading;

namespace DotProcessing
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : MetroWindow
    {
        DotProcess DOT = new DotProcess();
        

        private readonly object thislock;

        int arraycount = 0;
        int totalscore = 0;

        Bitmap[] prob = new Bitmap[5];
        string[] na = new string[5];




        public MainWindow()
        {
            InitializeComponent();

            DOT.PlayBGM();

            nextbtnimage.Image = Properties.Resources.nextbtn;
            nextbtnimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;

    
            InputImage.Image = DOT.DOTMaking(Properties.Resources.pikachu, 101);
            InputImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;

            avatarimage.Image = Properties.Resources._1;
            avatarimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;

            prob[0] = Properties.Resources.pikachu;
            prob[1] = Properties.Resources.doraemong;
            prob[2] = Properties.Resources.dooly;
            prob[3] = Properties.Resources.jjanggu;

            na[0] = "pikachu";
            na[1] = "doraemong";
            na[2] = "dooly";
            na[3] = "jjanggu";
            
        }



        private void LoadButton_Click(object sender, RoutedEventArgs e)
        {
            WinForm.OpenFileDialog ofd = new WinForm.OpenFileDialog();
            ofd.Title = "파일 오픈 예제창";
            ofd.FileName = "test";
            ofd.Filter = "그림 파일 (*.jpg, *.gif, *.bmp *.png) | *.jpg; *.gif; *.bmp; *.png; | 모든 파일 (*.*) | *.*";

            WinForm.DialogResult dr = ofd.ShowDialog();

            //OK버튼 클릭시
            if (dr == WinForm.DialogResult.OK)
            {
                //File명과 확장자를 가지고 온다.
                string fileName = ofd.SafeFileName;
                //File경로와 File명을 모두 가지고 온다.
                string fileFullName = ofd.FileName;
                //File경로만 가지고 온다.
                string filePath = fileFullName.Replace(fileName, "");

                var img = new Bitmap(fileFullName);
                //Bitmap b = BitmapFromSource(img);
                //btest = img2;

                //b = Gaussian_Filtering(b, 11);

                //System.Drawing.Image i = (System.Drawing.Image)b;
                InputImage.Image = img;
                InputImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;

                //File경로 + 파일명 리턴
            }
            //취소버튼 클릭시 또는 ESC키로 파일창을 종료 했을경우
            else if (dr == WinForm.DialogResult.Cancel)
            {
            }
        }
        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var openFolderdlg = new WinForm.FolderBrowserDialog();

                WinForm.SaveFileDialog dlf = new WinForm.SaveFileDialog();

                dlf.Filter = "그림 파일 (*.jpg, *.gif, *.bmp *.png) | *.jpg; *.gif; *.bmp; *.png; | 모든 파일 (*.*) | *.*";
                dlf.Title = "Save an Image File";

                //System.Drawing.Imaging.ImageFormat.Jpeg
                if (dlf.ShowDialog() == WinForm.DialogResult.OK)
                {
                    OutputImage.Image.Save(dlf.FileName, OutputImage.Image.RawFormat);
                    MessageBox.Show("저장 완료!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void TransButton_Click(object sender, RoutedEventArgs e)
        {
            OutputImage.Image = null;

            try
            {
                InputImage.Image = DOT.DOTMaking(prob[arraycount], Convert.ToDecimal(slider.Value));
                InputImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            }
            catch (FormatException)
            {
                MessageBox.Show("Input MaskSize!");
            }

        }
        
        
        private void nextbtn_click(object sender, EventArgs e)
        {
            InputImage.Image = DOT.DOTMaking(prob[arraycount], 101);
            InputImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            OutputImage.Image = null;
        }

        private void answer_button(object sender, RoutedEventArgs e)
        {
            switch (arraycount)
            {
                case 0:
                    if (answertext.Text == "pikachu")
                    {
                        OutputImage.Image = prob[arraycount];
                        OutputImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                        DOT.PlayEffect(0);
                        arraycount++;
                        totalscore = totalscore + (int)slider.Value;
                        score.Content = totalscore;
                        MessageBox.Show("정답입니다!");

                    }
                    else
                    {
                        DOT.PlayEffect(1);
                        MessageBox.Show("틀렸습니다!");
                    }
                    break;
                case 1:
                    if (answertext.Text == "doraemong")
                    {
                        OutputImage.Image = prob[arraycount];
                        OutputImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                        DOT.PlayEffect(0);
                        arraycount++;
                        totalscore = totalscore + (int)slider.Value;
                        score.Content = totalscore;
                        MessageBox.Show("정답입니다!");

                    }
                    else
                    {
                        DOT.PlayEffect(1);
                        MessageBox.Show("틀렸습니다!");
                    }
                    break;
                case 2:
                    if (answertext.Text == "dooly")
                    {
                        OutputImage.Image = prob[arraycount];
                        OutputImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                        DOT.PlayEffect(0);
                        arraycount++;
                        totalscore = totalscore + (int)slider.Value;
                        score.Content = totalscore;
                        MessageBox.Show("정답입니다!");

                    }
                    else
                    {
                        DOT.PlayEffect(1);
                        MessageBox.Show("틀렸습니다!");
                    }
                    break;
                case 3:
                    if (answertext.Text == "jjanggu")
                    {
                        OutputImage.Image = prob[arraycount];
                        OutputImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                        DOT.PlayEffect(0);
                        arraycount++;
                        totalscore = totalscore + (int)slider.Value;
                        score.Content = totalscore;
                        MessageBox.Show("정답입니다!");

                    }
                    else
                    {
                        DOT.PlayEffect(1);
                        MessageBox.Show("틀렸습니다!");
                    }
                    break;
            }

            if((int)score.Content > 100 && (int)score.Content <= 200)
            {
                avatarimage.Image = Properties.Resources._2;
            }

            if((int)score.Content > 200)
            {
                avatarimage.Image = Properties.Resources._3;
            }
        }
    }
}
