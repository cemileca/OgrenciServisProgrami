using OgrenciServis.Domain;
using OgrenciServis.Domain.Entities;
using OgrenciServis.Domain.ViewModel.Personal;
using OgrenciServis.Persistence.Services;
using OgrenciServis.Persistence.Services.PersonalServices;

namespace OgrenciServis.WinForm.Forms
{
    public partial class KisiEkleFrm : Form
    {
        public KisiEkleFrm()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        void CmbBxUlkeDoldurma()
        {
            CountryService cs = new CountryService();
            var query = cs.GetAllCountry();
            cmbBxUlke.DataSource = query.ToList();
            cmbBxUlke.DisplayMember = "CountryName";
            cmbBxUlke.SelectedIndex = -1;
            cs = null;
        }
        enum UlkeSehirIlceSec
        {
            Ulke,
            Sehir,
            Ilce
        }
        int IdUlkeSehirIlceID;

        int UlkeSehirIlceIdGetir(UlkeSehirIlceSec ulkeSehirIlceSec)
        {


            if (ulkeSehirIlceSec == UlkeSehirIlceSec.Ulke)
            {
                IdUlkeSehirIlceID = ((Country)cmbBxUlke.SelectedItem).Id;
            }
            else if (ulkeSehirIlceSec == UlkeSehirIlceSec.Sehir)
            {
                IdUlkeSehirIlceID = ((City)cmbBxSehir.SelectedItem).Id;

            }
            else if (ulkeSehirIlceSec == UlkeSehirIlceSec.Ilce)
            {
                IdUlkeSehirIlceID = ((District)cmbBxIlce.SelectedItem).Id;
            }
            return IdUlkeSehirIlceID;

        }

        void CmbBxSehirDoldurma()
        {
            CityService cityService = new CityService();
            var query = cityService.GetAllCitiesByCountry(UlkeSehirIlceIdGetir(UlkeSehirIlceSec.Ulke));
            cmbBxSehir.DataSource = query.ToList();
            cmbBxSehir.DisplayMember = "CityName";
            cmbBxSehir.SelectedIndex = -1;
            cityService = null;
        }
        void CmbBxIlceDoldurma()
        {
            DistrictService ds = new DistrictService();

            var query = ds.GetAllDistrictByCity(UlkeSehirIlceIdGetir(UlkeSehirIlceSec.Sehir));
            cmbBxIlce.DataSource = query.ToList();
            cmbBxIlce.DisplayMember = "DistrictName";
            cmbBxIlce.SelectedIndex = -1;
            ds = null;
        }
        private void KisiEkleFrm_Load(object sender, EventArgs e)
        {
            PersonalService personalService = new PersonalService();
            var query = personalService.GetAllPersonal();

            foreach (var item in query)
            {
                dgvPersonalListesi[0, 0].Value = ((Personel)item).IndivudialNo.ToString();
                dgvPersonalListesi[1, 0].Value = ((Personel)item).FirstName.ToString();
                dgvPersonalListesi[2, 0].Value = ((Personel)item).LastName.ToString();
            }
            dgvPersonalListesi.DataSource = query.ToString();
            personalService = null;
            CmbBxUlkeDoldurma();


        }



        private async void btnPersonalYenikayit_Click_1(object sender, EventArgs e)
        {
            VM_AdressAdd vM_AdressAdd = new VM_AdressAdd();
            vM_AdressAdd.CountriId = ((Country)cmbBxUlke.SelectedItem).Id;
            vM_AdressAdd.CityId = ((City)cmbBxSehir.SelectedItem).Id;
            vM_AdressAdd.DistrictId = ((District)cmbBxIlce.SelectedItem).Id;
            vM_AdressAdd.OpenAdress = txtPersonalAcikAdres.Text.Trim();
            AdressService adressService = new AdressService();

            adressService.AddAdressAsync(vM_AdressAdd);
           Adress aa=await adressService.GetAdressByOpenAdress(vM_AdressAdd.OpenAdress);
            MessageBox.Show(aa.Id.ToString());
        }

        private void cmbBxUlke_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBxUlke.SelectedIndex != -1)
            {
                CmbBxSehirDoldurma();
            }
        }

        private void cmbBxIlce_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void cmbBxSehir_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmbBxSehir.SelectedIndex != -1)
            {
                CmbBxIlceDoldurma();
            }
        }
    }
}
