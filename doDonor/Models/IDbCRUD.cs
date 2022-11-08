using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doDonor.Models
{
    internal interface IDbCRUD
    {
        int Create(DonorRequest req);
        int Update(DonorRequest req);
        int Delete(string ID);
        DataTable Search(DataTable dt, string bloodType, string region, string name);
    }
}
