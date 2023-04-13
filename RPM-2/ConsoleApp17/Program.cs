using ClassLibrary1;
class Program
{
    public static void Main()
    {
        while (true)
        {
            Console.WriteLine("Какой класс Вы хотите создать?");
            switch (Console.ReadLine())
            {

                case "Zaniatie":
                    Printeri.Print(CreateZaniatie());
                    break;
                case "Ayditoria":
                    Printeri.Print(CreateAyditoria());
                    break;
                case "Discyplina":
                    Printeri.Print(CreateDiscyplina());
                    break;
                case "Gryppa":
                    Printeri.Print(CreateGryppa());
                    break;
                case "Student":
                    Printeri.Print(CreateStudent());
                    break;
                case "Specialnost":
                    Printeri.Print(CreateSpecialnost());
                    break;
                case "Para":
                    // 7 вариант
                    break;
                case "Smena":
                case "Sotrydnik":
                    Printeri.Print(CreateSotrydnik());
                    break;
                case "Doljnost":
                    // 10 вариант
                    break;
                case "Podrazdelenie":
                case "Organizacia":
                    // 12 вариант
                    break;
                case "Korpus":
                case "VidZanyatiya":
                    Printeri.Print(CreateVidZanyatiya());
                    break;
                case "Oborudovanie":
                    // 15 вариант
                    break;
                case "KTP":
                    // 16 вариант
                    break;
                case "Tema":
                    // 17 вариант
                    break;
                case "Paragraf":
                    // 18 вариант
                    break;
                case "Tema-VidZanyatiya":
                    // 19 вариант
                    break;
                case "Material":
                    // 20 вариант
                    break;
                case "Kompetenciya":
                    // 21 вариант
                    break;
                case "ShapkaKTP":
                    // 22 вариант
                    break;
                case "Vneurochka":
                    // 23 вариант
                    break;
                default:
                    Console.WriteLine("Такого класса не существует");
                    break;

            }
        }

    }

    /// <summary>
    /// 1 вариант - занятие
    /// </summary>
    static Zaniatie CreateZaniatie()
    {
        return new Zaniatie(
            CreateDiscyplina(),
            CreateSotrydnik(),
            CreateAyditoria(),
            CreateGryppa(),
            CreatePara(),
            CreateVidZanyatiya());
    }


    /// <summary>
    /// 2 вариант - аудитория
    /// </summary>
    static Ayditoria CreateAyditoria()
    {
        Console.Write("Введите номер аудитории: ");
        var nazvanie = Console.ReadLine() ?? "Нет названия";
        Console.Write("Введите кол-во посадочных мест: ");
        var posadmesta = Convert.ToByte(Console.ReadLine() ?? "Нет названия");
        Console.Write("Введите кол-во окон: ");
        var kolvookon = Convert.ToByte(Console.ReadLine() ?? "Нет названия");
        return new Ayditoria(nazvanie, CreateSotrydnik(), posadmesta, kolvookon, CreateOborudovanie());

    }


    /// <summary>
    /// 3 вариант - дисциплина
    /// </summary>
    /// <returns></returns>
    static Discyplina CreateDiscyplina()
    {
        Console.Write("Введите полное навазние дисциплины: ");
        var name = (Console.ReadLine() ?? "Нет названия");
        Console.Write("Введите сокращение дисциплины: ");
        var shortname = (Console.ReadLine() ?? "Нет названия");
        var a = new Discyplina(name, shortname);
        return a;
    }


    /// <summary>
    /// 4 вариант - группа 
    /// </summary>
    /// <returns></returns>
    static Gryppa CreateGryppa()
    {
        Console.Write("Введите название группы: ");
        var name = Console.ReadLine() ?? "Нет названия";
        Console.Write("Введите сокращение: ");
        var shortname = Console.ReadLine() ?? "Нет названия";
        Console.Write("Введите численность: ");
        var chislennost = Convert.ToByte(Console.ReadLine() ?? "Нет названия");
        Console.Write("Введите год поступления:");
        var yearPostyp = Convert.ToInt16(Console.ReadLine() ?? "Нет названия");
        var a = new Gryppa(name, shortname, chislennost, yearPostyp, CreateSpecialnost(), CreateSotrydnik());
        return a;
    }


    /// <summary>
    /// 5 вариант - студент
    /// </summary>
    /// <returns></returns>
    static Student CreateStudent()
    {
        Console.Write("Введите имя студента: ");
        var name = (Console.ReadLine() ?? "Нет названия");
        Console.Write("Введите фамилию студента: ");
        var familia = (Console.ReadLine() ?? "Нет названия");
        Console.Write("Введите отчество студента: ");
        var otchestvo = (Console.ReadLine() ?? "Нет названия");
        Console.Write("Введите дату рождения студента: ");
        var data = Convert.ToDateTime(Console.ReadLine() ?? DateTime.Today.ToString());
        var a = new Student(name, familia, otchestvo, CreateGryppa(), data);
        return a;
    }


    /// <summary>
    /// 6 вариант - специальность
    /// </summary>
    /// <returns></returns>
    static Specialnost CreateSpecialnost()
    {
        Console.WriteLine("Введите название специальности: ");
        var Name = (Console.ReadLine() ?? "Нет названия");
        Console.WriteLine("Введите сокращение специальности: ");
        var reduction = (Console.ReadLine() ?? "Нет сокращения");
        var a = new Specialnost(Name, reduction);
        return a;
    }

    /// <summary>
    ///  7 вариант - пара
    /// </summary>
    /// <returns></returns>
    static Para CreatePara()
    {
        return new Para();
    }
    static Sotrydnik CreateSotrydnik()
    {
        Console.Write("Введите фамилию: ");
        var surname = Console.ReadLine() ?? "Нет названия";
        Console.Write("Введите имя: ");
        var name = Console.ReadLine() ?? "Нет названия";
        Console.Write("Введите отчество: ");
        var otchestvo = Console.ReadLine() ?? "Нет названия";
        var a = new Sotrydnik(surname, name, otchestvo, CreateDoljnost());
        return a;
    }


    /// <summary>
    /// 10 вариант - должность
    /// </summary>
    /// <returns></returns>
    static Doljnost CreateDoljnost()
    {
        return new Doljnost();
    }
    static VidZanyatiya CreateVidZanyatiya()
    {
        Console.Write("Введите вид занятия: ");
        var name = new VidZanyatiya(Console.ReadLine() ?? "Нет названия");
        return name;

    }


    /// <summary>
    /// 15 вариант - оборудование
    /// </summary>
    /// <returns></returns>
    static Oborudovanie CreateOborudovanie()
    {
        return new Oborudovanie();
    }


    /// <summary>
    /// 16 вариант - КТП
    /// </summary>
    /// <returns></returns>

}