using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    private GameObject mainProgram;

    [SerializeField]
    private GameObject loginPanel;

    [SerializeField]
    private GameObject showValuePanel;

    [SerializeField]
    private GameObject mainMenuPanel;

    [SerializeField]
    private List<TextMeshProUGUI> gridTexts;

    [SerializeField]
    private List<TextMeshPro> stationTexts;


    // Start is called before the first frame update
    void Start()
    {
        showValuePanel.transform.localScale= Vector2.zero;
        CloseAllPanel();
        loginPanel.SetActive(true);
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void OpenShowValue()
    {
        showValuePanel.SetActive(true);
        showValuePanel.LeanScale(Vector2.one,0.8f);
    }

    public void CloseShowValuePanel()
    {
        showValuePanel.LeanScale(Vector2.zero,1f).setEaseInBack().setOnComplete(()=>
        {
            showValuePanel.SetActive(false);

        });
    }

    private void WriteGridTexts(float timer)
    {
        
        timer-=Time.deltaTime;
        if(timer<=0)
        {
           //bu methodu update de timera 4 sn vererek çalıştır. WriteGridTexts(4f)
           //aynı zamanda yeni yaptığım uı ekranını butonla çalıştırıyorsun. Sen Editörden Setactivini aç bi incele.
           //Yeni eklenen kısımda ise elemanları göreceksin, SQL den çekeceğin değerleri burada gridTexts[0,1,3].text= değer; şeklinde yazdırabilirsin.
           //sonrasında yeni aldığımız stationtext[i]=gridtexts[i] şeklinde eşitleyeceksin.
        }
    }

    private void CloseAllPanel()
    {
        showValuePanel.SetActive(false);
        mainProgram.SetActive(false);
        mainMenuPanel.SetActive(false);
    }

    public void Login()
    {
        //buraya veritabanı kontrolü eklenecek;
        loginPanel.SetActive(false);
        mainProgram.SetActive(true);
        mainMenuPanel.SetActive(true);

    }

    public void Register()
    {
        //buraya veritabanına kayıt koyulacak;
    }
}
