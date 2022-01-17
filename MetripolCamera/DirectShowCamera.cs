using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

using AForge.Video;
using AForge.Video.DirectShow;

namespace MetripolCamera
{
    struct sDirectShowDevice
    {
        public string MonikerString;
        public string Name;
    }

    class DirectShowCamera : ICameraDevice
    {
        private sCameraParams m_Params;
        private VideoCaptureDevice m_Device;
        private bool m_PrepareFlag;
        private Bitmap m_Snapshoot;

       // public CameraParams CameraParameters { get; set; }
        public sCameraParams CameraParameters
        {
            get
            {
                return m_Params;
            }
        }

        public DirectShowCamera(string MonikerDevice)
        {
            m_Params = new sCameraParams();
            m_Device = new VideoCaptureDevice(MonikerDevice);

            m_Params.SnapshootParams = new List<sFramePrams>();
            m_Params.VideoParams = new List<sFramePrams>();

            foreach (VideoCapabilities p in m_Device.SnapshotCapabilities)
            {
                sFramePrams fparams;
                fparams.FrameSize = p.FrameSize;
                fparams.FrameRate = p.AverageFrameRate;
                m_Params.SnapshootParams.Add(fparams);
            }

            foreach (VideoCapabilities p in m_Device.VideoCapabilities)
            {
                sFramePrams fparams;
                fparams.FrameSize = p.FrameSize;
                fparams.FrameRate = p.AverageFrameRate;
                m_Params.VideoParams.Add(fparams);
            }
        }

        public bool Init(sInitCameraParams initParams)
        {
            foreach (VideoCapabilities vcap in m_Device.VideoCapabilities)
            {
                if (vcap.FrameSize == initParams.VideoParams.FrameSize &&
                    vcap.AverageFrameRate == initParams.VideoParams.FrameRate)
                {
                    m_Device.VideoResolution = vcap;
                    break;
                }
            }

            foreach (VideoCapabilities vsnap in m_Device.SnapshotCapabilities)
            {
                if (vsnap.FrameSize == initParams.SnapshootParams.FrameSize &&
                    vsnap.AverageFrameRate == initParams.SnapshootParams.FrameRate)
                {
                    m_Device.SnapshotResolution = vsnap;
                    break;
                }
            }

            m_Device.NewFrame += NewFrameEvent;
            return true;
        }

        public bool Connect()
        {
            if (m_Device.IsRunning)
                return false;

            m_Device.Start();
            m_PrepareFlag = false;
            return true;
        }

        private void NewFrameEvent(object sender, NewFrameEventArgs eventArgs)
        {
            if (!m_PrepareFlag)
                return;

            if (m_Snapshoot != null)
                m_Snapshoot.Dispose();
            m_Snapshoot = (Bitmap)eventArgs.Frame.Clone();

            m_PrepareFlag = false;
        }

        public Bitmap MakePhoto()
        {
            if (m_Device != null && !m_Device.IsRunning)
                return null;
            m_PrepareFlag = true;
            while (m_PrepareFlag);

            return m_Snapshoot;
        }

        public void Disconnect()
        {
            if (m_Device != null && m_Device.IsRunning)
            {
                m_Device.SignalToStop();
                m_Device.WaitForStop();
                m_Device.NewFrame -= NewFrameEvent;
            }
            if (m_Snapshoot != null)
                m_Snapshoot.Dispose();
        }

        public static sDirectShowDevice[] GetDeviceList()
        {
            FilterInfoCollection m_VideoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (m_VideoDevices.Count == 0)
                return null;

            sDirectShowDevice[] devices = new sDirectShowDevice[m_VideoDevices.Count];

            for (int i = 0;i<devices.Length;++i)
            {
                devices[i].MonikerString = m_VideoDevices[i].MonikerString;
                devices[i].Name = m_VideoDevices[i].Name;
            }
            return devices;
        }
    }

}
