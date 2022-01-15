using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MetripolCamera
{
    struct sFramePrams
    {
        public Size FrameSize;
        public int FrameRate;
    }

    struct sCameraParams
    {
        public List<sFramePrams> VideoParams;
        public List<sFramePrams> SnapshootParams;
    }

    struct sInitCameraParams
    {
        public sFramePrams VideoParams;
        public sFramePrams SnapshootParams;
    }

    interface ICameraDevice
    {
        sCameraParams CameraParameters { get; }

        bool Init(sInitCameraParams initParams);

        bool Connect();
        void Disconnect();

        Bitmap MakePhoto();
    }
}
