using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Coupons.Models;
using Coupons.Dtos;

namespace Coupons.Application.Interfaces
{
    public interface IPurchase
    {

        List<Purchase> GetAllPurchase();

        Purchase GetById(int id);

        Purchase Create(Purchase purchase);

        Purchase Update(int id,PurchaseDto  purchase);
    }
}