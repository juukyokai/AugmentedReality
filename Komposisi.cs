using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Komposisi : MonoBehaviour
{
    [SerializeField]
    private Text _komposisi;
    [SerializeField]
    private Text _alergen;
    [SerializeField]
    private Text _gula;
    
    public List<string> komposisiUtama = new List<string>(){
            "Kentang", "Ikan", "Gandum", "Ekstrak Daging Sapi",
            /* 0         1        2                 3*/

            "Minyak Kelapa Sawit", "Mentega", "Ragi", "Makanan Ragi",
            /*         4               5        6            7*/
            "Tepung Terigu", "Lemak Nabati", "Garam", 
            /*     8               9           10*/
        
            "Natrium Bikarbonat (Pengembang)", "Kalsium Bikarbonat (Pengembang)",
            /*                11                                12  */

            "Coklat", "Lemak Kakao", "Kakao Massa", "Perisa Coklat", "Perisa Vanili",
            /* 13          14              15             16                17*/
            
            "Sereal", "Maltodekstrin", "Pengembang", "Pengembang Nabati", "Minyak Nabati"
            /* 18            19             20                21                22*/
        };
    [SerializeField]
    public List<string> listAlergen = new List<string>(){
            "Kedelai", "Susu Sapi", "Susu Bubuk", "Dekstrosa BHA", "Lemak Susu",
            /* 0            1             2               3             4 */
            "Lesitin Kedelai", 
            /*  5  */
        };
    [SerializeField]
    public List<string> listPenguatRasa = new List<string>(){
            "mononatrium glutamat", "dinatrium inosinat", "dinatrium guanilat",
            /*      0                         1                    2*/
        };
    [SerializeField]
    public List<string> listGula = new List<string>(){
            "Sukrosa", "Glukosa", "Gula", 
            /*  0          1        2  */
        };

    IDictionary<string, List<int>> listKomposisi = new Dictionary<string, List<int>>();
    public void setKomposisi(string nama_produk){
        if (nama_produk == "chitato")
        {
            listKomposisi.Add("komposisiUtama", new List<int> { 0, 4, 1, 2, 3, });
            listKomposisi.Add("listAlergen", new List<int> { 0, 1, });
            listKomposisi.Add("listPenguatRasa", new List<int> { 0, 1, 2, });
            listKomposisi.Add("listGula", new List<int> { });
        }
        else if (nama_produk == "susu_uht")
        {
            listKomposisi.Add("komposisiUtama", new List<int> { });
            listKomposisi.Add("listAlergen", new List<int> { });
            listKomposisi.Add("listPenguatRasa", new List<int> { });
            listKomposisi.Add("listGula", new List<int> { });

            /*
            _komposisi.text = "Susu sapi segar, Sukrosa, Bubuk coklat, Pemantap nabati, Perisa coklat";
            */
        }
        else if (nama_produk == "beng-beng")
        {
            listKomposisi.Add("komposisiUtama", new List<int> { 8, 9, 14, 15, 18, 19, 10, 20});
            listKomposisi.Add("listAlergen", new List<int> { 2, 3, 4, 5 });
            listKomposisi.Add("listPenguatRasa", new List<int> { });
            listKomposisi.Add("listGula", new List<int> { 2, 1 });

            /*
            _komposisi.text = "Glukosa, Gula, Susu bubuk, Tepung terigu, Lemak nabati (mengandung dekstrosa BHA), " +
                "Lemak kakao, Kakao massa, Sereal, Maltodekstrin, Lemak susu, Dekstrosa, Pengemulsi (lesitin kedelai), " +
                "Garam, Pengembang";
            */
        }
        else if (nama_produk == "kit-kat")
        {
            listKomposisi.Add("komposisiUtama", new List<int> { 8, 2, 5, 15, 9, 22, 4, 13, 11, 12, 10, 6, 17 });
            listKomposisi.Add("listAlergen", new List<int> { 2, 5, 7 });
            listKomposisi.Add("listPenguatRasa", new List<int> { });
            listKomposisi.Add("listGula", new List<int> { 2 });

            /*
            _komposisi.text = "Gula, Susu bubuk full cream, Tepung terigu, Gandum, Mentega, " +
                "Kakao massa, Lemak dan minyak nabati, Minyak sayuran kelapa sawit, Bubuk kakao, " +
                "Pengemulsi lesitin kedelai, Makanan ragi, Pengembang natrium bikarbonat, Garam, " +
                "Pengembang kalsium karbonat, Ragi, Perisa vanilin";
            */
        }
        else
        {
            listKomposisi.Remove("komposisiUtama");
            listKomposisi.Remove("listAlergen");
            listKomposisi.Remove("listPenguatRasa");
            listKomposisi.Remove("listGula");
        }
    }
    public void getKomposisi()
    {
        string temp_komposisi = "";
        string temp_alergen = "";
        string temp_gula = "";
        //komposisi
        foreach (int i in listKomposisi["komposisiUtama"])
        {
            temp_komposisi = string.Concat(temp_komposisi, komposisiUtama[i]);
            temp_komposisi = string.Concat(temp_komposisi, ", ");
        };
        foreach (int i in listKomposisi["listPenguatRasa"])
        {
            temp_komposisi = string.Concat(temp_komposisi, listPenguatRasa[i]);
            temp_komposisi = string.Concat(temp_komposisi, ", ");
        };
        _komposisi.text = temp_komposisi;

        // allergen
        foreach (int i in listKomposisi["listAlergen"])
        {
            temp_alergen = string.Concat(temp_alergen, listAlergen[i]);
            temp_alergen = string.Concat(temp_alergen, ", ");
        };
        _alergen.text = temp_alergen;

        //gula
        foreach (int i in listKomposisi["listGula"])
        {
            temp_gula = string.Concat(temp_komposisi, listGula[i]);
            temp_gula = string.Concat(temp_komposisi, ", ");
        };
        _gula.text = temp_gula;
    }
    protected List<string> getListKomposisi() { return komposisiUtama; }
    protected List<string> getListGula() { return listGula; }
    protected List<string> getListAlergen() { return listAlergen; }
    protected List<string> getListPenguatRasa() { return listPenguatRasa; }
}
