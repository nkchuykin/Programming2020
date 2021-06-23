class StudentMark
{
    private string fio;
    private int mark;
    public string FIO => fio;
    public int Mark => mark;

    public StudentMark(string fio, int mark)
    {
        this.mark = mark;
        this.fio = fio;
    }
}