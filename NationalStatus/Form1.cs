using DevExpress.XtraEditors.DXErrorProvider;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NationalStatus
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void simpleButton1_Click(object sender, EventArgs e)
        {
            ErrorProvider dxErrorProvider1 = new ErrorProvider();
            if (string.IsNullOrEmpty(txtad.Text))
            {
                dxErrorProvider1.SetError(txtad, "Ad alanı boş geçilemez");
                return;
            }
            if (string.IsNullOrEmpty(txtsoyad.Text))
            {
                dxErrorProvider1.SetError(txtsoyad, "Soyad alanı boş geçilemez");
                return;
            }
            if(string.IsNullOrEmpty(txttc.Text))
            {
                dxErrorProvider1.SetError(txttc, "TC alanı boş geçilemez");
                return;
            }
            if(txttc.Text.Length != 11)
            {
                dxErrorProvider1.SetError(txttc, "TC 11 haneli olmalıdır");
                return;
            }
            if (txtdate.DateTime.Year < 1900)
            {
                dxErrorProvider1.SetError(txtdate, "Geçerli bir tarih giriniz");
                return;
            }
            if (string.IsNullOrEmpty(txtdate.Text))
            {
                dxErrorProvider1.SetError(txtdate, "Doğum tarihi boş geçilemez");
                return;
            }
            progressPanel1.Visible = true;
            Citizen citizen = new Citizen();
            citizen.TC = Convert.ToInt64(txttc.Text);
            citizen.Name = txtad.Text;
            citizen.Surname = txtsoyad.Text;
            citizen.Birthday = Convert.ToInt32(txtdate.DateTime.Year);
            Task<bool> task = citizen.TCKimlikDoğrula();
            bool result = await task;
            if (result)
            {
                progressPanel1.Visible = false;
                MessageBox.Show("Vatandaşlık Doğrulandı", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                progressPanel1.Visible = false;
                MessageBox.Show("Vatandaşlık Bulunamadı", "Başarısız", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }

        }
    }
}
