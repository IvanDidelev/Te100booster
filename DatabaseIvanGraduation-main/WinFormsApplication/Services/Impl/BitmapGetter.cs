
namespace WinFormsApplication.Services.Impl
{
    public class BitmapGetter : IBitmapGetter
    {
        private const string BITMAP_DIRECTORY = "Images";
        private const string DEFAULT_BITMAP_NAME = "default.png";
        private static IBitmapGetter _instance = new BitmapGetter();
        private Dictionary<string, Image> _cache = new();
        private Image _defaultBitmap;

        public static IBitmapGetter Instance => _instance;

        private BitmapGetter()
        {
            var defaultBitmapPath = GetBitmapPath(DEFAULT_BITMAP_NAME);

            _defaultBitmap = Image.FromFile(defaultBitmapPath);
        }

        private string GetBitmapPath(string? bitmapName)
        {
            return Path.Combine(Environment.CurrentDirectory, BITMAP_DIRECTORY, bitmapName ?? string.Empty);
        }

        public IEnumerable<string> GetBitmapsList()
        {
            var imagesPath = Path.Combine(Environment.CurrentDirectory, BITMAP_DIRECTORY);

            return Directory.GetFiles(imagesPath).Select(x => x.Substring(imagesPath.Length + 1));
        }

        public Image GetBitmap(string? bitmapName)
        {
            var bitmapPath = GetBitmapPath(bitmapName);

            if (_cache.ContainsKey(bitmapPath))
            {
                return _cache[bitmapPath];
            }

            if (File.Exists(bitmapPath))
            {
                var image = Image.FromFile(bitmapPath);

                _cache.Add(bitmapPath, image);

                return image;
            }

            return _defaultBitmap;
        }
    }
}
