using Microsoft.EntityFrameworkCore;
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
        private AdressWriteRepository _adressWriteRepository;
        private CountryWriteRepository _countryWriteRepository;
        private CountryReadRepository _countryReadRepository;
        private CityReadRepository _cityReadRepository;
        private CityWriteRepository _cityWriteRepository;

        #region YARDIMCI METODLAR

        bool aktif = false;
        bool IsTxtBxEmpty = true;
        void AktifPassifEt(ComboBox cmbBx1, Button btnArti, TextBox txt1, TextBox txt2, Button btn1, bool aktif)
        {
            if (!aktif)
            {
                txt1.Enabled = true;
                txt2.Enabled = true;
                btn1.Enabled = true;
                cmbBx1.Enabled = false;
                btnArti.Text = "_";
            }
            else if (aktif)
            {
                cmbBx1.Enabled = true;
                btnArti.Text = "+";
                txt1.Enabled = false;
                txt2.Enabled = false;
                btn1.Enabled = false;

            }

        }
        void IfAktif(bool aktifMi)
        {
            if (!aktif)
            {
                aktif = true;
            }
            else
            {
                aktif = false;
            }
        }

        void CmbBxUlkeDoldurma(CountryReadRepository repo, ComboBox cmbBx)
        {
            repo = new CountryReadRepository(_context);

            var query = repo.GetAll().ToList();
            cmbBx.DisplayMember = "CountryName";
            cmbBx.DataSource = query.ToList();
            cmbBx.SelectedIndex = -1;
            repo = null;
        }
        void CmbSehirDoldurma(CityReadRepository cityRepo, ComboBox cmbSehir)
        {
            cityRepo = new(_context);
            var query = cityRepo.GetAll().ToList();
            cmbBxSehirAdlari.DisplayMember = "CityName";
            cmbBxSehirAdlari.DataSource = query;
            cmbBxSehirAdlari.SelectedIndex = -1;
            cityRepo = null;

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

        bool TxtBxIsEmptyControl(bool IsEmpty, TextBox txtAd, TextBox txtKod)
        {
            if (txtAd.Text != string.Empty && txtAd.Text.Length > 1 && txtKod.Text != string.Empty && txtKod.Text.Length > 1 && txtKod.Text.Length < 6)
            {
                IsEmpty = false;
            }
            else
            {
                IsEmpty = true;
                MessageBox.Show("Ülke Adı ve Ülke Kodu Boş geçilemez. Lütfen Boşlukları doldurun.");
            }
            return IsEmpty;
        }
        async void YeniSehirEkle()
        {
            VM_CityAdd vM_CityAdd = new VM_CityAdd();
            vM_CityAdd.CityName = txtYeniSehirEkle.Text.Trim();
            vM_CityAdd.CityDescricption = "geçici açıklama";
            vM_CityAdd.CountryId = cmbBxUlkeAdlari.SelectedIndex != -1 ? ((Country)cmbBxUlkeAdlari.SelectedItem).Id : 1;
            CityService _cityService = new CityService();
            await _cityService.AddCityAsync(vM_CityAdd);
            vM_CityAdd = null;

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

            _adressWriteRepository = new AdressWriteRepository(_context);
            _countryReadRepository = new CountryReadRepository(_context);
            Country c = (Country)cmbBxUlkeAdlari.SelectedItem;

            //TxtBxTemizle(new[] { cmbBxUlkeAdlari, cmbBxSehirAdlari, cmbBxIlceAdlari }, new[] { txtAcikAdresEKle, txtYeniUlkeEkle });
        }
        private void btnUlkeEkle_Click(object sender, EventArgs e)
        {
            AktifPassifEt(cmbBxUlkeAdlari, btnUlkeEkle, txtYeniUlkeEkle, txtYeniUlkeKodu, btnUlkeKayitBitir, aktif);
            IfAktif(aktif);
        }
        private async void btnUlkeKayitBitir_Click(object sender, EventArgs e)
        {
            _countryWriteRepository = new CountryWriteRepository(_context);
            AktifPassifEt(cmbBxUlkeAdlari, btnUlkeEkle, txtYeniUlkeEkle, txtYeniUlkeKodu, btnUlkeKayitBitir, aktif);
            IfAktif(aktif);
            Country ctr = new Country();
            ctr.CountryName = txtYeniUlkeEkle.Text.Trim();
            ctr.CountryCode = txtYeniUlkeKodu.Text.Trim();
            await _countryWriteRepository.AddAsync(ctr);
            await _countryWriteRepository.SaveChangesAsyncc();
            CmbBxUlkeDoldurma(_countryReadRepository, cmbBxUlkeAdlari);


        }
        private void btnSehirEkle_Click(object sender, EventArgs e)
        {
            AktifPassifEt(cmbBxSehirAdlari, btnSehirEkle, txtYeniSehirEkle, txtBxYeniSehirKodu, btnSehirKayitBitir, aktif);
            IfAktif(aktif);
        }


        private async void btnSehirKayitBitir_Click(object sender, EventArgs e)
        {
            AktifPassifEt(cmbBxSehirAdlari, btnSehirEkle, txtYeniSehirEkle, txtBxYeniSehirKodu, btnSehirKayitBitir, aktif);
            IfAktif(aktif);
            YeniSehirEkle();

        }
        private void btnYeniIlceEkle_Click(object sender, EventArgs e)
        {
            AktifPassifEt(cmbBxIlceAdlari, btnYeniIlceEkle, txtYeniIlceEkle, txtYeniılceZipKodu, btnIlceKayitBitir, aktif);
            IfAktif(aktif);
        }
        private void btnIlceKayitBitir_Click(object sender, EventArgs e)
        {
            AktifPassifEt(cmbBxIlceAdlari, btnYeniIlceEkle, txtYeniIlceEkle, txtYeniılceZipKodu, btnIlceKayitBitir, aktif);
            IfAktif(aktif);
        }
        private void AdresKayitFrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _context.Dispose();
        }
        private void AdresKayitFrm_Load(object sender, EventArgs e)
        {
            CmbBxUlkeDoldurma(_countryReadRepository, cmbBxUlkeAdlari);

        }

        private void cmbBxUlkeAdlari_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmbSehirDoldurma(_cityReadRepository, cmbBxSehirAdlari);

        }
    }
}
