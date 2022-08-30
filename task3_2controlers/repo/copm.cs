using task3_2controlers.Model;

namespace task3_2controlers.repo
{
    public interface ICompanyInterface

    {
        public Task<List<companys>> Addcompany(companys company1);
        public  Task<List<companys>> Delete(int id);

        public List<companys> Get();

        public companys Getbyid(int id);

        public  Task<List<companys>> updatecompany(companys request);


    }
    public class copm : ICompanyInterface
    {
        public static List<companys> company = new List<companys>()
            {
                new companys{id=1,name="messi",location="leonel"},

                 new companys{id=2,name="xavi",location="noidea"}

            };

        public async Task<List<companys>> Addcompany(companys company1)
        {
            company.Add(company1);
            return company;
        }

        public async Task<List<companys>> Delete(int id)
        {
            companys c1 = company.First(x => x.id == id);
            company.Remove(c1);
            return company;

        }

        public List<companys> Get()
        {
            return company;
        }

        public companys Getbyid(int id)
        {
            return company.FirstOrDefault(f => f.id == id);
        }

        public async Task<List<companys>> updatecompany(companys request)
        {
            companys c2 = company.Find(p => p.id == request.id);

            request.name = c2.name;
            request.id = c2.id;
            request.location = c2.location;

            return company;
        }
    }
}
