using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerApp.Models
{
    public class Order
    {
        
       public long SistemSiparisNo { get; set; }
        public long MusteriSiparisNo { get; set; }
        public string CikisAdresi { get; set; }
        public string VarisAdresi { get; set; }
        public int Miktar { get; set; }
        public MiktarBirim MiktarBirimi { get; set; }
        public AgirlikBirim AgirlikBirimi { get; set; }
        public string MalzemeKodu { get; set; }
        public string MalzemeAdi { get; set; }
        public string Not { get; set; }

        public SiparisDurum SiparisDurumu { get; set; }

    }

    public enum MiktarBirim
    {
        Adet = 1,
        Koli = 2,
        Paket = 3,
        Palet = 4
    }

    public enum AgirlikBirim
    {
        KG = 1,
        Ton = 2
    }

    public enum SiparisDurum
    {
        SiparisAlindi = 1,
        YolaCikti = 2,
        DagitimMerkezinde = 3,
        DagitimaCikti = 4,
        TeslimEdildi = 5,
        TeslimEdilemedi = 6
    }
}
