class Student
{
    private int id;
    private string fio;
    public int ID => id;
    public string FIO => fio;

    public Student(int id, string fio)
    {
        this.id = id;
        this.fio = fio;
    }

    public static Student Parse(string inp)
    {
        var arr = inp.Split();
        return new Student(int.Parse(arr[0]), arr[1]);
    }
}