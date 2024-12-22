using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using WebApi.Models;

namespace WebApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class HanghoaController : ControllerBase
    {
            CSDLBanhang dbc;
        public HanghoaController(CSDLBanhang db)
        {
            dbc = db;
        }

        // POST: api/items
        [HttpGet]
        [Route("/Hanghoa/List")]
        public IActionResult GetList()
        {
            return Ok(new {data = dbc.TblHangHoas.ToList() });
        }
        [HttpPost]
        [Route("/Hanghoa/Insert")]
        public IActionResult Themhanghoa(string ma, string ten, string donvi, float gianhap, float giaban)
        {
            TblHangHoa hh = new TblHangHoa();
            hh.Id = Guid.NewGuid();
            hh.Ma = ma;
            hh.Ten = ten;
            hh.Donvi = donvi;
            hh.Gianhap = gianhap;
            hh.Giaban = giaban;
            dbc.TblHangHoas.Add(hh);
            dbc.SaveChanges();
            return Ok(new {hh});
        }
        [HttpPut]
        [Route("/Hanghoa/Update")]
        public IActionResult Capnhathanghoa(string id, string ma, string ten, string donvi, float gianhap, float giaban)
        {
            TblHangHoa hh = new TblHangHoa();
            hh.Id = new Guid(id);
            hh.Ma = ma;
            hh.Ten = ten;
            hh.Donvi = donvi;
            hh.Gianhap = gianhap;
            hh.Giaban = giaban;
            dbc.TblHangHoas.Update(hh);
            dbc.SaveChanges();
            return Ok(new {hh});
        }
        
        [HttpDelete]
        [Route("/Hanghoa/Delete")]
        public IActionResult Xoahanghoa(string id)
        {
            TblHangHoa hh = new TblHangHoa();
            hh.Id = new Guid(id);
            dbc.TblHangHoas.Remove(hh);
            dbc.SaveChanges();
            return Ok(new {hh});
        }
    }
}