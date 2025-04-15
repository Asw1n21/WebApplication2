using WebApplication2.Dtos;

namespace WebApplication2.Services.Interface
{
    public interface IAddressService
    {
        void AddAddress(InsertAddressDto AddressDto);
    }
}
