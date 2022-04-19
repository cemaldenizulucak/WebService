using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormWebService
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_gönder_Click(object sender, EventArgs e)
        {


            /*
                WEB serviceler HTTP protokolünü kullanarak hzimet sağlarlar.
                İstemci yani client istek atar ve bir geri dönüş gerçekleşir.
                Bu geri dönüşte kullanılan servise göre xml,json vb. yapılar kullanılır.
                ve bilgi akışı sağlanmış olur.
                Burada textboxlar üzerinden girilen veriler alınıp sorgulama yapılır ve geri dönüş tip olarak 
                true ya da false bir değer olarak geri döndürdük.

             */


            long KimlikNo = long.Parse(txt_tc.Text);
            int yil = int.Parse(txt_yil.Text);
            bool durum;
            try
            {
                using (TcDogrula.KPSPublicSoapClient service = new TcDogrula.KPSPublicSoapClient { })
                {
                    durum = service.TCKimlikNoDogrula(KimlikNo, txt_isim.Text, txt_soyisim.Text, yil);
                }
            }
            catch (Exception)
            {

                throw;
            }
            MessageBox.Show(durum.ToString());
        }
    }
}
