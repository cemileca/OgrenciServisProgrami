using Microsoft.EntityFrameworkCore;
using OgrenciServis.Business.Abstracts;
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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OgrenciServis.WinForm.Forms
{
    public partial class AdresKayitFrm : Form
    {
        readonly private OgrenciServisDbContext _context;

         private AdressWriteRepository _adressWriteRepository;



        public AdresKayitFrm()
        {
            InitializeComponent();
            var option = new DbContextOptionsBuilder<OgrenciServisDbContext>().UseNpgsql(Configurations.ConnectionString).Options;
            var ctx = new OgrenciServisDbContext(option);
            _context = ctx;
            _adressWriteRepository = new AdressWriteRepository(_context);

        }

        bool aktif = false;
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

        private async void btnEkle_Click(object sender, EventArgs e)
        {
            _adressWriteRepository = new AdressWriteRepository(_context);

            Country ctr = new Country();
            ctr.CountryName = cmbBxUlkeAdlari.Text;
            City cty = new City();
            cty.CityName= cmbBxSehirAdlari.Text;
            District dstrct= new District();
            dstrct.DistrictName=cmbBxIlceAdlari.Text;
          await  _adressWriteRepository.AddAsync(new()
            {
                AdressName = "Ev Adresi",
                Country = ctr,
                City = cty,
                District = dstrct,
                AdresDescription = txtAcikAdresEKle.Text
            }) ;
          await  _adressWriteRepository.SaveChangesAsyncc();
        }
        private void btnUlkeEkle_Click(object sender, EventArgs e)
        {
            AktifPassifEt(cmbBxUlkeAdlari, btnUlkeEkle, txtYeniUlkeEkle, txtYeniUlkeKodu, btnUlkeKayitBitir, aktif);
            IfAktif(aktif);
        }

        private void btnUlkeKayitBitir_Click(object sender, EventArgs e)
        {
            AktifPassifEt(cmbBxUlkeAdlari, btnUlkeEkle, txtYeniUlkeEkle, txtYeniUlkeKodu, btnUlkeKayitBitir, aktif);
            IfAktif(aktif);
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


    }
}
