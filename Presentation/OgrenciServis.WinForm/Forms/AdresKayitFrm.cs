using Microsoft.EntityFrameworkCore;
using OgrenciServis.Business.Abstracts;
using OgrenciServis.Domain;
using OgrenciServis.Domain.Entities;
using OgrenciServis.Persistence;
using OgrenciServis.Persistence.Contexts;
using OgrenciServis.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OgrenciServis.WinForm.Forms
{
    public partial class AdresKayitFrm : Form
    {
        readonly private OgrenciServisDbContext _context;
        private AdressWriteRepository _adressWriteRepository;
        private CountryWriteRepository _countryWriteRepository;
        private CountryReadRepository _countryReadRepository;

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
        }
        void CmbSehirDoldurma(CityReadRepository cityRepo, ComboBox cmbSehir)
        {
            cityRepo = new(_context);
            var query = cityRepo.GetAll().ToList();
            cmbBxSehirAdlari.DisplayMember = "CityName";
            cmbBxSehirAdlari.DataSource = query;
            cmbBxSehirAdlari.SelectedIndex = -1;

        }
        void TxtBxTemizle(ComboBox[] cmbs, TextBox[] txtBxs)
        {
            foreach (var cmBx in cmbs)
            {
                cmBx.SelectedIndex = -1;
            }
            foreach (var txt in txtBxs)
            {
                txt.Text = string.Empty;
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
            _adressWriteRepository = new AdressWriteRepository(_context);
            _countryReadRepository = new CountryReadRepository(_context);
            Country c = (Country)cmbBxUlkeAdlari.SelectedItem;

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
            TxtBxIsEmptyControl(IsTxtBxEmpty, txtYeniUlkeEkle, txtYeniUlkeKodu);
            Country ctr = new Country();
            ctr.CountryName = txtYeniUlkeEkle.Text.Trim();
            ctr.CountryCode = txtYeniUlkeKodu.Text.Trim();
            await _countryWriteRepository.AddAsync(ctr);
            await _countryWriteRepository.SaveChangesAsyncc();

        }
        private void btnSehirEkle_Click(object sender, EventArgs e)
        {
            AktifPassifEt(cmbBxSehirAdlari, btnSehirEkle, txtYeniSehirEkle, txtBxYeniSehirKodu, btnSehirKayitBitir, aktif);
            IfAktif(aktif);
        }
        private void btnSehirKayitBitir_Click(object sender, EventArgs e)
        {
            AktifPassifEt(cmbBxSehirAdlari, btnSehirEkle, txtYeniSehirEkle, txtBxYeniSehirKodu, btnSehirKayitBitir, aktif);
            IfAktif(aktif);
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
            CmbSehirDoldurma(cityRepoo, cmbBxSehirAdlari);
        }

        private CityReadRepository cityRepoo;
    }
}
