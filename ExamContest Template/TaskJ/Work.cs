class Work
{
    private int id;
    private int mark;
    public int ID => id;
    public int Mark => mark;

    public Work(int id, int mark)
    {
        this.id = id;
        this.mark = mark;
    }

    public static Work Parse(string inp)
    {
        var arr = inp.Split();
        return new Work(int.Parse(arr[0]), int.Parse(arr[1]));
    }
}