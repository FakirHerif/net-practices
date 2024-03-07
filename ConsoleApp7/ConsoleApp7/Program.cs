// Kullanıcıdan öğrenci sayısını isteyen her öğrenci için öğrenci adı,öğrenci soyadı,1.sınav notu,2.sınav notu,3.sınav notu isteyen ve daha sonra not ortalamasını hesaplayıp ekrana yazdıran algoritma yapınız.(For döngüsü kullanınız)

int totalStudents;
bool isNum;
double classTotalGrade = 0;

do
{
    Console.Write("Toplam Öğrenci Sayısını Giriniz: ");
    string? input = Console.ReadLine();
    isNum = int.TryParse(input, out totalStudents);

    if (!isNum)
    {
        Console.WriteLine("Geçerli öğrenci sayısı girmediniz.");
    }

} while (!isNum);


for (int i = 1; i <= totalStudents; i++)
    {
        Console.Write($"{i}. Öğrenci adını giriniz: ");
        string? studentName = Console.ReadLine();

        Console.Write($"{i}. Öğrenci soyadını giriniz: ");
        string? studentSurname = Console.ReadLine();

        int exam1Grade, exam2Grade, exam3Grade;

        do
        {
            Console.Write($"{studentName} {studentSurname} isimli öğrencinin 1. sınav notunu giriniz: ");
        } while (!int.TryParse(Console.ReadLine(), out exam1Grade) || exam1Grade < 0 || exam1Grade > 100);

        do
        {
            Console.Write($"{studentName} {studentSurname} isimli öğrencinin 2. sınav notunu giriniz: ");
        } while (!int.TryParse(Console.ReadLine(), out exam2Grade) || exam2Grade < 0 || exam2Grade > 100);

        do
        {
            Console.Write($"{studentName} {studentSurname} isimli öğrencinin 3. sınav notunu giriniz: ");
        } while (!int.TryParse(Console.ReadLine(), out exam3Grade) || exam3Grade < 0 || exam3Grade > 100);

        double averageGrade = (exam1Grade + exam2Grade + exam3Grade) / 3.0;

        Console.WriteLine($"Öğrenci: {studentName} {studentSurname}");
        Console.WriteLine($"1. Sınav Notu: {exam1Grade}");
        Console.WriteLine($"2. Sınav Notu: {exam2Grade}");
        Console.WriteLine($"3. Sınav Notu: {exam3Grade}");
        Console.WriteLine($"{studentName} {studentSurname} İsimli Öğrencinin Not Ortalaması: {averageGrade:F2}\n");

        classTotalGrade += averageGrade;
}

Console.WriteLine("***********************\n");

double classAverageGrade = classTotalGrade / totalStudents;
Console.WriteLine($"Sınıf Ortalaması: {classAverageGrade:F2}");