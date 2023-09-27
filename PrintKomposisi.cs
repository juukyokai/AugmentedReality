using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PrintKomposisi : MonoBehaviour
{
    [SerializeField]
    private Dictionary<string, List<int>> komposisi;
    [SerializeField]
    private Text _komposisi;
    [SerializeField]
    private Text _alergen;
    [SerializeField]
    private Text _gula;

    private string temp_komposisi;
    private string temp_alergen;
    private string temp_gula;

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
            
            "Sereal", "Maltodekstrin", 
            /* 18          19*/
        };

    public List<string> listAlergen = new List<string>(){
            "Kedelai", "Susu Sapi", "Susu Bubuk", "Dekstrosa BHA", "Lemak Susu",
            /* 0            1             2               3             4 */
            "Lesitin Kedelai", 
            /*  5  */
        };

    public List<string> listPenguatRasa = new List<string>(){
            "mononatrium glutamat", "dinatrium inosinat", "dinatrium guanilat",
            /*      0                         1                    2*/
        };

    public List<string> listGula = new List<string>(){
            "Sukrosa", "Glukosa", "Gula", 
            /*  0          1        2  */
        };

    public void getKomposisi(Dictionary<string, List<int>> produk)
    {
        temp_komposisi = "";
        temp_alergen = "";
        temp_gula = "";
        //komposisi
        foreach (int i in produk["komposisiUtama"])
        {
            temp_komposisi = string.Concat(temp_komposisi, komposisiUtama[i]);
        };
        foreach (int i in produk["listPenguatRasa"])
        {
            temp_komposisi = string.Concat(temp_komposisi, listPenguatRasa[i]);
        };
        _komposisi.text = temp_komposisi;

        // allergen
        foreach (int i in produk["listAlergen"])
        {
            temp_alergen = string.Concat(temp_alergen, listAlergen[i]);
        };
        _alergen.text = temp_alergen;

        //gula
        foreach (int i in produk["listGula"])
        {
            temp_gula = string.Concat(temp_komposisi, listGula[i]);
        };
        _gula.text = temp_gula;
    }
}
