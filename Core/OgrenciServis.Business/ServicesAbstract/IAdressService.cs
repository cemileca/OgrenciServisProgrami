﻿using OgrenciServis.Domain;
using OgrenciServis.Domain.Entities;
using OgrenciServis.Domain.ViewModel;

namespace OgrenciServis.Business.ServicesAbstract
{
    public interface IAdressService
    {
        Task AddAdressAsync(VM_AdressAdd vM_Adress);
        IQueryable<Adress> GetAllAdresses();
        IQueryable<Adress> GetAllAdressesById(string adressName);
        Task<Adress> GetAdressByOpenAdress(string OpenAdres);
        Task<Adress> GetAdressById(int AdressId);
        Task RemoveAdressAsync(int Id);
    }
}
