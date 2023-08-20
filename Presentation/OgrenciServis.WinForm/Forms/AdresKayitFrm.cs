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
            if (cmbBxUlkeAdlari.SelectedIndex != -1)
            {
                CityService cityService = new CityService();
                var query = cityService.GetAllCitiesByCountry(UlkId);
                cmbBxSehirAdlari.DataSource = query.ToList();
                cmbBxSehirAdlari.DisplayMember = "CityName";
                cmbBxSehirAdlari.SelectedIndex = -1;
                cityService = null;
            }
            else
            {
                MessageBox.Show("Lütfen Bir Ülke Seçiniz");
            }
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
            if (cmbBxUlkeAdlari.SelectedIndex != -1)
            {
                VM_CityAdd vM_CityAdd = new VM_CityAdd();
                vM_CityAdd.CityName = txtYeniSehirEkle.Text.Trim();
                vM_CityAdd.CityDescricption = "geçici açıklama";
                vM_CityAdd.CountryId = UlkeSehirIlceIdGetir(UlkeSehirIlceSec.Ulke);
                CityService _cityService = new CityService();
                await _cityService.AddCityAsync(vM_CityAdd);
                vM_CityAdd = null;
            }
            else
            {
                MessageBox.Show("Lütfen bir Ülke Seçiniz");

            }

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
            txtYeniUlkeKodu.Enabled = AktPass;
            txtUlkeAciklama.Enabled = AktPass;
            btnUlkeKayitBitir.Enabled = AktPass;
        }
        void SehirKayitAktifEt(bool AktfPass)
        {
            txtYeniSehirEkle.Enabled = AktfPass;
            txtBxYeniSehirKodu.Enabled = AktfPass;
            txtSehirAciklama.Enabled = AktfPass;
            btnSehirKayitBitir.Enabled = AktfPass;
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
            AktifPassifEt(); // Tüm kontrolleri passif et
            UlkeKayitAktifPassif(true); // Ulke yeni kayıt Copnrollerini aktif et.
        }
        private void btnSehirEkle_Click(object sender, EventArgs e)
        {
            if (cmbBxUlkeAdlari.SelectedIndex != -1)
            {
                UlkId = UlkeSehirIlceIdGetir(UlkeSehirIlceSec.Ulke);
                AktifPassifEt();
                SehirKayitAktifEt(true);
            }
            else
            {
                MessageBox.Show("Lütfen bir Ülke Adı giriniz..");
            }


        }

        private void btnUlkeKayitBitir_Click(object sender, EventArgs e)
        {
            YeniUlkeEkle();
            AktifPassifEt();
            CmbBxUlkeDoldurma();
        }

        private void btnSehirKayitBitir_Click(object sender, EventArgs e)
        {

            YeniSehirEkle();
            CmbBxSehirDoldurma();


        }
        private void btnYeniIlceEkle_Click(object sender, EventArgs e)
        {
        }
        private void btnIlceKayitBitir_Click(object sender, EventArgs e)
        {
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


        }
    }
}
