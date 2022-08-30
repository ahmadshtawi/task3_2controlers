using task3_2controlers.Model;

namespace task3_2controlers.repo
{


    public interface IEmployeInterface

    {
        public Task<List<employe>> Addemploye(employe employe1);
        public Task<List<employe>> Delete(int id);
        public List<employe> Get();
        public Task<List<employe>> updatecompany(employe request);
        public employe GetbyId(int id);


    }
    public class emp : IEmployeInterface
    {
        public List<employe> emplye = new List<employe>()
            {
                new employe{Id=1,Name="messi",Age=13,CompanyID=1 },

                 new employe{Id=2,Name="madd",Age=13,CompanyID=1 }

            };

        public async Task<List<employe>> Addemploye(employe employe1)

        {
            emplye.Add(employe1);
            return emplye;
        }

        public async Task<List<employe>> Delete(int id)
        {
            employe c1 = emplye.First(x => x.Id == id);
            emplye.Remove(c1);
            return emplye;

        }

        public List<employe> Get()
        {
            return emplye;
        }

        public employe GetbyId(int id)
        {
            return emplye.FirstOrDefault(f => f.Id == id);
        }

        public async Task<List<employe>> updatecompany(employe request)
        {
            employe e1 = emplye.Find(p => p.Id == request.Id);

            e1.Name = request.Name;
            e1.Id = request.Id;
            e1.CompanyID = request.CompanyID;
            e1.Age = request.Age;

            return emplye;
        }
    }
}
