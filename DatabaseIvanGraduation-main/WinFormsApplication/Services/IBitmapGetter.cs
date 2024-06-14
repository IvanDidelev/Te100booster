namespace WinFormsApplication.Services
{
    public interface IBitmapGetter
    {
        public IEnumerable<string> GetBitmapsList();

        public Image GetBitmap(string? fileName);
    }
}
