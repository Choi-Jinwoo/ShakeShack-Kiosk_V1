using System.Windows.Controls;

namespace SheckSheck_Kiosk.CardPay
{
    /// <summary>
    /// PayCard.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class PayCard : Page
    {
        public PayCard()
        {
            InitializeComponent();
            webcam.CameraIndex = 0;
        }
        private void webcam_QrDecoded(object sender, string e) { 
            tbRecog.Text = e; 
        }

       
    }
}
