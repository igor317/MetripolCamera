using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

using AForge.Video;
using AForge.Video.DirectShow;

namespace MetripolCamera
{
    public partial class Form1 : Form
    {
        FilterInfoCollection m_VideoDevices;
        private ICameraDevice m_Camera;

        private void InitVideoDevices()
        {
            m_VideoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            m_CbDevices.Items.Clear();

            if (m_VideoDevices.Count > 0)
            {
                foreach (FilterInfo it in m_VideoDevices)
                {
                    m_CbDevices.Items.Add(it.Name);
                }

                m_CbDevices.SelectedIndex = 0;

                m_Camera = new DirectShowCamera(m_VideoDevices[m_CbDevices.SelectedIndex].MonikerString);

                m_CbRes.Items.Clear();
                foreach (sFramePrams fp in m_Camera.CameraParameters.VideoParams)
                {
                    m_CbRes.Items.Add(string.Format("{0}x{1}", fp.FrameSize.Width, fp.FrameSize.Height));
                }

                m_CbRes.SelectedIndex = 0;
            }
        }

        public Form1()
        {
            InitializeComponent();
            InitVideoDevices();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sInitCameraParams initParams = new sInitCameraParams();
            initParams.VideoParams = m_Camera.CameraParameters.VideoParams[m_CbRes.SelectedIndex];
            initParams.SnapshootParams = m_Camera.CameraParameters.SnapshootParams[m_CbRes.SelectedIndex];
            m_Camera.Init(initParams);
            m_Camera.Connect();
            timer1.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            //Bitmap pic = camera.MakePhoto();
            //pictureBox1.Image = pic;
            //label1.Text = Convert.ToString(GetMeadianColorValue(pic));
            //timer1.Start();
            //camera.MakePhoto();
            //pictureBox1.Image.Save("123.png");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            m_Camera.Disconnect();
            pictureBox1.Image = null;
        }
        /// <summary>
        /// Возвращает среднее значение цвета со всех каналов изображения
        /// </summary>
        /// <param name="bmp">Изображение у которого необходимо вычислить среднее значение цвета</param>
        /// <returns></returns>
        int GetMeadianColorValue(Bitmap bmp)
        {
            BitmapData bmpData = bmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height), ImageLockMode.ReadOnly, bmp.PixelFormat);

            IntPtr ptr = bmpData.Scan0;
            int byteDataSize = Math.Abs(bmpData.Stride) * bmp.Height;

            int res = 0;
            for (int i = 0; i < byteDataSize; ++i)
           // for (int i = 0; i < byteDataSize; i += 3)
                res += Marshal.ReadByte(ptr, i);
            res /= byteDataSize;
           // res /= byteDataSize / 3;
            bmp.UnlockBits(bmpData);
            return res;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Bitmap pic = m_Camera.MakePhoto();
            if (pic != null)
            {
                pictureBox1.Image = pic;
                label1.Text = Convert.ToString(GetMeadianColorValue(pic));
            }
        }

        private void m_BtnUpdate_Click(object sender, EventArgs e)
        {
            InitVideoDevices();
        }

        private void m_CbDevices_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_Camera = new DirectShowCamera(m_VideoDevices[m_CbDevices.SelectedIndex].MonikerString);

            m_CbRes.Items.Clear();
            foreach (sFramePrams fp in m_Camera.CameraParameters.VideoParams)
            {
                m_CbRes.Items.Add(string.Format("{0}x{1}", fp.FrameSize.Width, fp.FrameSize.Height));
            }

            m_CbRes.SelectedIndex = 0;
        }
    }
}
