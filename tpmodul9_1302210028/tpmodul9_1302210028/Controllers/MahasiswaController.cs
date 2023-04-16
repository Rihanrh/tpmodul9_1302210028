using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace tpmodul9_1302210028.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class MahasiswaController : ControllerBase
    {
        public static List<Mahasiswa> mh = new List<Mahasiswa>
        {
            new Mahasiswa ("Rihan Hidayat", "1302210028"),
            new Mahasiswa ("Jaatsiyah Maulidina Astrianto", "1302213043"),
            new Mahasiswa ("Hilman Fariz Hirzi", "1302213092"),
            new Mahasiswa ("Putri Auliya Rahmah", "1302210033"),
            new Mahasiswa ("Liyan Made Leon WAYAN", "1302213037")
        };

        [HttpGet]
        public IEnumerable<Mahasiswa> Get()
        {
            return mh;
        }

        [HttpGet("{idx}")]
        public Mahasiswa Get(int idx)
        {
            return mh[idx];
        }

        [HttpPost]
        public void Post([FromBody]Mahasiswa newMahasiswa)
        {
            mh.Add(newMahasiswa);
        }

        [HttpPut("{idx}")]
        public void Put(int idx, [FromBody]Mahasiswa updatedMahasiswa)
        {
            mh[idx] = updatedMahasiswa;
        }

        [HttpDelete("{idx}")]
        public void Delete(int idx)
        {
            mh.RemoveAt(idx);
        }
    }
}
