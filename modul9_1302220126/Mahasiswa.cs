namespace Model.mahasiswa;

public class Mahasiswa
{
    public int Id { get; set; }
    private String nama { get; set; }
    private String nim { get; set; }
    private String course { get; set; }


    public String Nama
    {
        get { return nama; }
        set { nama = value; }
    }

    public String Nim
    {
        get { return nim; }
        set { nim = value; }
    }
}
