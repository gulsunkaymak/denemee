using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ServerApp.Models;

namespace ServerApp.Controllers
{     
     [ApiController]
    [Route("api/[controller]")]
    public class ProductController:ControllerBase
    {
       private static List<Order> _order;
       public ProductController( )
       {
            _order=new List<Order>();
            _order.Add(new Order{
                SiparisDurumu=SiparisDurum.SiparisAlindi,
                MusteriSiparisNo=1000,
                Not= "Sekerli olsun",
                SistemSiparisNo=9999,
                CikisAdresi="Pendik",
                VarisAdresi="Tuzla",
                Miktar=5,
                MiktarBirimi=MiktarBirim.Adet,
                AgirlikBirimi=AgirlikBirim.KG,
                MalzemeKodu="MZM25"
            });
             _order.Add(new Order{
                SiparisDurumu=SiparisDurum.SiparisAlindi,
                MusteriSiparisNo=1001,
                Not= "Sekerli olsun",
                SistemSiparisNo=9999,
                CikisAdresi="Kadikoy",
                VarisAdresi="Tuzla",
                Miktar=5,
                MiktarBirimi=MiktarBirim.Adet,
                AgirlikBirimi=AgirlikBirim.KG,
                MalzemeKodu="MZM25"
            });
             _order.Add(new Order{
                SiparisDurumu=SiparisDurum.SiparisAlindi,
                MusteriSiparisNo=10002,
                Not= "Tuzlu olsun",
                SistemSiparisNo=9999,
                CikisAdresi="Pendik",
                VarisAdresi="Tuzla",
                Miktar=5,
                MiktarBirimi=MiktarBirim.Adet,
                AgirlikBirimi=AgirlikBirim.KG,
                MalzemeKodu="MZM25"
            });
       }
        [HttpGet]
        public List<Order> GetProducts(){
            return _order;
        }

         [HttpGet("{id}")]
        public IActionResult GetProduct(int id){
            var p=_order.FirstOrDefault(i=>i.SistemSiparisNo==id);
            if(p==null){
                return NotFound();
            }
            return Ok(p);
        }
    }
}