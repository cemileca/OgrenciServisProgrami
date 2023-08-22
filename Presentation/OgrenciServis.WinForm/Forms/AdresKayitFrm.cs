using Microsoft.EntityFrameworkCore;
using OgrenciServis.Domain;
using OgrenciServis.Domain.Entities;
using OgrenciServis.Domain.ViewModel;
using OgrenciServis.Persistence;
using OgrenciServis.Persistence.Contexts;
using OgrenciServis.Persistence.Repositories;
using OgrenciServis.Persistence.Services;

namespace OgrenciServis.WinForm.Forms
{
    public partial class AdresKayitFrm : Form
    {
        readonly private OgrenciServisDbContext _context;
        int IdUlkeSehirIlceID;
        int UlkId, SehirId, IlceId;
        #region YARDIMCI METODLAR

        enum UlkeSehirIlceSec
        {
            Ulke,
            Sehir,
            Ilce
        }
        void AktifPassifEt()
        {
            foreach (var item in grpBxYeniAdresEkle.Controls)
            {
                if (!(item is Label))
                {
                    (item as Control).Enabled = false;
                    if (item is TextBox)
                    {
                        (item as TextBox).Clear();
                    }
                }

            }
        }
        void CmbBxUlkeDoldurma()
        {
            CountryService cs = new CountryService();
            var query = cs.GetAllCountry();
            cmbBxUlkeAdlari.DataSource = query.ToList();
            cmbBxUlkeAdlari.DisplayMember = "CountryName";
            cmbBxUlkeAdlari.SelectedIndex = -1;
            cs = null;
        }
        void CmbBxSehirDoldurma()
        {
            CityService cityService = new CityService();
            var query = cityService.GetAllCitiesByCountry(UlkeSehirIlceIdGetir(UlkeSehirIlceSec.Ulke));
            cmbBxSehirAdlari.DataSource = query.ToList();
            cmbBxSehirAdlari.DisplayMember = "CityName";
            cmbBxSehirAdlari.SelectedIndex = -1;
            cityService = null;
        }
        void CmbBxIlceDoldurma()
        {
            DistrictService ds = new DistrictService();

            var query = ds.GetAllDistrictByCity(UlkeSehirIlceIdGetir(UlkeSehirIlceSec.Sehir));
            cmbBxIlceAdlari.DataSource = query.ToList();
            cmbBxIlceAdlari.DisplayMember = "DistrictName";
            cmbBxIlceAdlari.SelectedIndex = -1;
            ds = null;
        }
        void CmbBxlariAktifEt()
        {
            cmbBxUlkeAdlari.Enabled = true;
            cmbBxSehirAdlari.Enabled = true;
            cmbBxIlceAdlari.Enabled = true;
            btnUlkeEkle.Enabled = true;
            btnSehirEkle.Enabled = true;
            btnYeniIlceEkle.Enabled = true;
        }
        void Temizle(Control.ControlCollection controlCollection)
        {
            foreach (var item in controlCollection)
            {
                if (item is ComboBox)
                {
                    ComboBox cmbBx = (ComboBox)item;
                    cmbBx.SelectedIndex = -1;
                }
                else if (item is TextBox)
                {
                    TextBox txtBx = (TextBox)item;
                    txtBx.Text = string.Empty;
                }
            }
        }

        async void YeniSehirEkle()
        {
            VM_CityAdd vM_CityAdd = new VM_CityAdd();
            vM_CityAdd.CityName = txtYeniSehirEkle.Text.Trim();
            vM_CityAdd.CityDescricption = txtSehirAciklama.Text.Trim();
            vM_CityAdd.CountryId = UlkeSehirIlceIdGetir(UlkeSehirIlceSec.Ulke);
            CityService _cityService = new CityService();
            await _cityService.AddCityAsync(vM_CityAdd);
            CmbBxSehirDoldurma();

            vM_CityAdd = null;

        }
        async void YeniUlkeEkle()
        {
            VM_CountryAdd vM_CountryAdd = new VM_CountryAdd();
            vM_CountryAdd.CountryName = txtYeniUlkeEkle.Text.Trim();
            vM_CountryAdd.CountryCode = txtYeniUlkeKodu.Text.Trim();
            vM_CountryAdd.CountryDescription = txtUlkeAciklama.Text.Trim();

            CountryService _countryService = new CountryService();
            await _countryService.AddCountryAsync(vM_CountryAdd);
            vM_CountryAdd = null;
        }
        private async void YeniIlceEKle()
        {
            VM_DistrictAdd vM_DistrictAdd = new VM_DistrictAdd();
            vM_DistrictAdd.DistrictName = txtYeniIlceEkle.Text.Trim();
            vM_DistrictAdd.DistrictDescription = txtYeniIlceAciklama.Text.Trim();
            vM_DistrictAdd.DistrictZipCode = txtYeniIlceZipKodu.Text.Trim();
            vM_DistrictAdd.CitiId = UlkeSehirIlceIdGetir(UlkeSehirIlceSec.Sehir);


            DistrictService ds = new DistrictService();
            await ds.AddDsitrictAsync(vM_DistrictAdd);
            CmbBxIlceDoldurma();

            vM_DistrictAdd = null;
        }
        int UlkeSehirIlceIdGetir(UlkeSehirIlceSec ulkeSehirIlceSec)
        {


            if (ulkeSehirIlceSec == UlkeSehirIlceSec.Ulke)
            {
                IdUlkeSehirIlceID = ((Country)cmbBxUlkeAdlari.SelectedItem).Id;
            }
            else if (ulkeSehirIlceSec == UlkeSehirIlceSec.Sehir)
            {
                IdUlkeSehirIlceID = ((City)cmbBxSehirAdlari.SelectedItem).Id;

            }
            else if (ulkeSehirIlceSec == UlkeSehirIlceSec.Ilce)
            {
                IdUlkeSehirIlceID = ((District)cmbBxIlceAdlari.SelectedItem).Id;
            }
            return IdUlkeSehirIlceID;

        }
        void UlkeKayitAktifPassif(bool AktPass)
        {
            txtYeniUlkeEkle.Enabled = AktPass;
            txtYeniUlkeEkle.Focus();
            txtYeniUlkeKodu.Enabled = AktPass;
            txtUlkeAciklama.Enabled = AktPass;
            btnUlkeKayitBitir.Enabled = AktPass;
        }

        void SehirKayitAktifEt(bool AktfPass)
        {
            txtYeniSehirEkle.Enabled = AktfPass;
            txtYeniSehirEkle.Focus();
            txtBxYeniSehirKodu.Enabled = AktfPass;
            txtSehirAciklama.Enabled = AktfPass;
            btnSehirKayitBitir.Enabled = AktfPass;
            cmbBxUlkeAdlari.Enabled = AktfPass;
        }
        void IlceKayitAktifEt(bool AktfPass)
        {
            txtYeniIlceEkle.Enabled = AktfPass;
            txtYeniIlceEkle.Focus();
            txtYeniIlceZipKodu.Enabled = AktfPass;
            txtYeniIlceAciklama.Enabled = AktfPass;
            btnIlceKayitBitir.Enabled = AktfPass;
            cmbBxSehirAdlari.Enabled = AktfPass;
        }

        #endregion

        public AdresKayitFrm()
        {
            InitializeComponent();
            var option = new DbContextOptionsBuilder<OgrenciServisDbContext>().UseNpgsql(Configurations.ConnectionString).Options;
            var ctx = new OgrenciServisDbContext(option);
            _context = ctx;

        }
        private async void btnEkle_Click(object sender, EventArgs e)
        {
            Temizle(grpBxYeniAdresEkle.Controls);

            VM_AdressAdd vM_AdressAdd = new VM_AdressAdd();
            vM_AdressAdd.AdressName = txtAdresAdi.Text;
            vM_AdressAdd.AdresDescription = "geçici açıklama";
            vM_AdressAdd.CountriId = UlkeSehirIlceIdGetir(UlkeSehirIlceSec.Ulke);
            vM_AdressAdd.CityId = UlkeSehirIlceIdGetir(UlkeSehirIlceSec.Sehir);
            vM_AdressAdd.DistrictId = UlkeSehirIlceIdGetir(UlkeSehirIlceSec.Ilce);

            AdressService adressService = new AdressService();
            await adressService.AddCityAsync(vM_AdressAdd);
            adressService = null;
            MessageBox.Show("Test");

        }
        private void btnUlkeEkle_Click(object sender, EventArgs e)
        {
            foreach (var item in grpBxYeniAdresEkle.Controls)
            {
                if (item is ComboBox)
                {
                    (item as ComboBox).SelectedIndex = -1;
                }
            }
            AktifPassifEt(); // Tüm kontrolleri passif et
            UlkeKayitAktifPassif(true); // Ulke yeni kayıt Copnrollerini aktif et.
            txtYeniUlkeEkle.TabIndex = 33;
            txtYeniUlkeKodu.TabIndex = 34;
            txtUlkeAciklama.TabIndex = 35;
            btnUlkeKayitBitir.TabIndex = 36;
        }

        private void btnSehirEkle_Click(object sender, EventArgs e)
        {
            if (cmbBxUlkeAdlari.SelectedIndex != -1)
            {
                AktifPassifEt();
                SehirKayitAktifEt(true);
            }
            else
            {
                MessageBox.Show("Lütfen bir Ülke Adı giriniz..");
            }
            txtYeniSehirEkle.TabIndex = 33;
            txtBxYeniSehirKodu.TabIndex = 34;
            txtSehirAciklama.TabIndex = 35;
            btnSehirKayitBitir.TabIndex = 36;
        }


        private void btnUlkeKayitBitir_Click(object sender, EventArgs e)
        {
            if (txtYeniUlkeEkle.Text != string.Empty && txtYeniUlkeEkle.Text.Length >= 3 && txtYeniUlkeKodu.Text != string.Empty && txtYeniUlkeKodu.Text.Length >= 2)
            {
                YeniUlkeEkle();
            }
            AktifPassifEt();
            CmbBxUlkeDoldurma();
            CmbBxlariAktifEt();
            cmbBxUlkeAdlari.Focus();
        }
        private void btnSehirKayitBitir_Click(object sender, EventArgs e)
        {
            if (cmbBxUlkeAdlari.SelectedIndex != -1)
            {
                if (txtYeniSehirEkle.Text != string.Empty && txtYeniSehirEkle.Text.Length >= 3 && txtBxYeniSehirKodu.Text != string.Empty && txtBxYeniSehirKodu.Text.Length >= 2)
                {
                    YeniSehirEkle();

                }

                AktifPassifEt();
                CmbBxlariAktifEt();
            }


            cmbBxSehirAdlari.Focus();


        }
        private void btnYeniIlceEkle_Click(object sender, EventArgs e)
        {
            if (cmbBxSehirAdlari.SelectedIndex != -1)
            {
                AktifPassifEt();
                IlceKayitAktifEt(true);
                CmbBxlariAktifEt();
                txtYeniIlceEkle.TabIndex = 33;
                txtYeniIlceZipKodu.TabIndex = 34;
                txtYeniIlceAciklama.TabIndex = 35;
                btnIlceKayitBitir.TabIndex = 36;
            }
            else
            {
                MessageBox.Show("Lütfen bir Şehir Seçiniz..");
            }

        }
        private void btnIlceKayitBitir_Click(object sender, EventArgs e)
        {
            MessageBox.Show(((City)cmbBxSehirAdlari.SelectedItem).CityName);
            if (cmbBxSehirAdlari.SelectedIndex != -1)
            {
                if (txtYeniIlceEkle.Text != string.Empty && txtYeniIlceEkle.Text.Length >= 3 && txtYeniIlceZipKodu.Text != string.Empty && txtYeniIlceZipKodu.Text.Length >= 2)
                {
                    YeniIlceEKle();

                }

                AktifPassifEt();
                CmbBxlariAktifEt();
                cmbBxIlceAdlari.Focus();
            }
            else
            {
                MessageBox.Show("Test");
            }



        }



        private void AdresKayitFrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _context.Dispose();
        }
        private void AdresKayitFrm_Load(object sender, EventArgs e)
        {
            CmbBxUlkeDoldurma();
        }
        private void cmbBxUlkeAdlari_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmbBxUlkeAdlari.SelectedIndex != -1)
            {
                CmbBxSehirDoldurma();

            }
            else
            {
                cmbBxSehirAdlari.DataSource = null;
            }
        }
        private void cmbBxSehirAdlari_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBxSehirAdlari.SelectedIndex != -1)
            {
                CmbBxIlceDoldurma();
            }
            else
            {
                cmbBxIlceAdlari.DataSource = null;
            }
        }

    }
}
