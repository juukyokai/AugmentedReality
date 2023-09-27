using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KomposisiControl : MonoBehaviour
{
    [SerializeField] 
    private Text _komposisi;

    private List<string> listKomposisi = new List<string>(){ 
            "Kentang", "Ikan", "Gandum", "Ekstrak Daging Sapi",

            "Minyak Kelapa Sawit", "Mentega", "Ragi", "Makanan Ragi",
            "Tepung Terigu", "Lemak Nabati", "Garam", 
        
            "Pengembang", "Pengembang (Natrium Bikarbonat)", "Pengembang (Kalsium Bikarbonat)",

            "Coklat", "Lemak Kakao", "Kakao Massa", "Perisa Coklat", "Perisa Vanili",

            
            "Sereal", "Maltodekstrin", 
        };
    private List<string> ListAllergen = new List<string>(){
            "Kedelai", "Susu Sapi", "Susu Bubuk", "Dekstrosa BHA", "Lemak Susu",
            "Lesitin Kedelai", 
        };
    private List<string> listPenguatRasa = new List<string>(){
            "mononatrium glutamat", "dinatrium inosinat", "dinatrium guanilat",
        };
    private List<string> listGula = new List<string>(){
            "Sukrosa", "Glukosa", "Gula", 
        };

    public void setKomposisi(string nama_produk)
    {
        if (nama_produk == "chitato"){
            _komposisi.text = listKomposisi[0]+"(65%),Minyak kelapa sawit,Bumbu rasa sapi panggang (kedelai, " +
                "susu, ikan, gandum, ekstrak daging sapi (1%), penguat rasa mononatrium glutamat, dinatrium inosinat, " +
                "dinatrium guanilat)";
        }
        else if (nama_produk == "susu_uht"){
            _komposisi.text = "Susu sapi segar, Sukrosa, Bubuk coklat, Pemantap nabati, Perisa coklat";
        }
        else if (nama_produk == "beng-beng"){
            _komposisi.text = "Glukosa, Gula, Susu bubuk, Tepung terigu, Lemak nabati (mengandung dekstrosa BHA), " +
                "Lemak kakao, Kakao massa, Sereal, Maltodekstrin, Lemak susu, Dekstrosa, Pengemulsi (lesitin kedelai), " +
                "Garam, Pengembang";
        }
        else if (nama_produk == "kit-kat")
        {
            _komposisi.text = "Gula, Susu bubuk full cream, Tepung terigu, Gandum, Mentega, " +
                "Kakao massa, Lemak dan minyak nabati, Minyak sayuran kelapa sawit, Bubuk kakao, " +
                "Pengemulsi lesitin kedelai, Makanan ragi, Pengembang natrium bikarbonat, Garam, " +
                "Pengembang kalsium karbonat, Ragi, Perisa vanilin";
        }
    }
}
