using Microsoft.EntityFrameworkCore;
using WebApplication2.Data;
using WebApplication2.Dtos;
using WebApplication2.Entities;
using WebApplication2.Services.Interface;

namespace WebApplication2.Services
{

    public class AddressService : IAddressService
    {
        private readonly ApplicationDbContext _context;

        public AddressService(ApplicationDbContext context)
        {
            _context = context;
        }
        public void AddAddress(InsertAddressDto AddressDto)
        {
            {
                try
                {
                    var address = new Address
                    {
                        Address1 = AddressDto.Address1,
                        Address2 = AddressDto.Address2,
                        City = AddressDto.City,
                        State = AddressDto.City,
                        Zip =AddressDto.Zip,
                        PersonId = AddressDto.PersonId
                    };

                    _context.Address.Add(address);
                    _context.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error adding address: " + ex.Message);
                }
            }
        }
    }
}

