using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SatronusNext.eventType;
using System.Drawing;
using System.Windows;

namespace SatronusNext
{
    [Serializable]
    public class Program
    {
        /*
         * User information
         */
        #region fields
        public String EMailString { get; set; }
        public String PasswordString { get; set; }
        public String NameString { get; set; }
        public String SurnameString { get; set; }

        public String ImageSource { get; set; }
        #endregion

        #region methods

        public bool TryToRegist()
        {
            return true;
        }

        public bool TryToSignIn()
        {
            return true;
        }

        public void CopyImage()
        {
            try
            {
                using (Image img = Image.FromFile(ImageSource))
                {
                    img.Save(@"Resources/Image.png", System.Drawing.Imaging.ImageFormat.Png);
                    ImageSource = @"Resources/Image.png";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

    }

}
