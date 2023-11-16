Tovar yabloki1 = new Tovar("Антоновка","кг.",150,500,"Фрукты",0,14);
yabloki1.PrintInfo();
/*
string fileName = "yabloki.txt";
using (StreamReader sr = new StreamReader(fileName))
{
    string line;
    while ((line = sr.ReadLine()) != null)
    {
        Console.WriteLine(line);
    }
}
*/
class Tovar
{
    string nazvanie;
    //{
        //get => nazvanie;
        //set => nazvanie = value;
    //}
    string edIzm;
    int czena;
    float kolichestvo;
    string tip;
    float skidka;
    int srokGodnosti;
    public void PrintInfo()
    {
        Console.WriteLine("Название:{0}, {1}руб. за кг, в наличии:{2}{3},тип товара:{4}, величина скидки:{5}, срок годности:{6} дней", nazvanie, czena, kolichestvo, edIzm, tip, skidka, srokGodnosti);
    }
    public Tovar(string _nazvanie, string _edIzm, int _czena, float _kolichestvo, string _tip, float _skidka, int _srokGodnosti)
    {
        nazvanie = _nazvanie;
        edIzm = _edIzm;
        czena = _czena;
        kolichestvo = _kolichestvo;
        tip = _tip;
        skidka = _skidka;
        srokGodnosti = _srokGodnosti;

    }
}