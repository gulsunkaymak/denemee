export class Model {
  categortName: string;

  orders: Array<Order>;
  constructor() {
    this.orders = [

     new Order (  2200,125,"Tuzla","Pendik",1,1,1,"Mal25","Seker","Deneme","test",true),
    ]

  }
}

export class Order {
  SistemSiparisNo: number
  MusteriSiparisNo: number;
  CikisAdresi:string;
  VarisAdresi:string;
  Miktar:number;
  MiktarBirim:MiktarBirim;
  AgirlikBirimi:AgirlikBirim;
  MalzemeKodu:string;
  MalzemeAdi:string;
  Not:string;
  SiparisDurumu:boolean;

  constructor(SistemSiparisNo: number, MusteriSiparisNo: number,CikisAdresi:string,VarisAdresi:string,Miktar:number,
    MiktarBirim:MiktarBirim,AgirlikBirimi:AgirlikBirim, MalzemeKodu:string, MalzemeAdi:string,Not:string,SiparisDurumu,boolean) {

    this.SistemSiparisNo = SistemSiparisNo;
    this.MusteriSiparisNo = MusteriSiparisNo;
    this.CikisAdresi = CikisAdresi;
    this.VarisAdresi = VarisAdresi;
    this.Miktar = Miktar;
    this.MiktarBirim = MiktarBirim;
    this.AgirlikBirimi = AgirlikBirimi;
    this.MalzemeKodu = MalzemeKodu;
    this.Not = Not;
    this.SiparisDurumu = SiparisDurumu;
  }

}

enum MiktarBirim {
  Adet = 1,
  Koli = 2,
  Paket = 3,
  Palet = 4
}

enum AgirlikBirim {
  KG = 1,
  Ton = 2
}

enum SiparisDurum {
  SiparisAlindi = 1,
  YolaCikti = 2,
  DagitimMerkezinde = 3,
  DagitimaCikti = 4,
  TeslimEdildi = 5,
  TeslimEdilemedi = 6
}
