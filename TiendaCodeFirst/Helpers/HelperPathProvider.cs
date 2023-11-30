namespace TiendaCodeFirst.Helpers
{
    public enum Folders { Imagenes = 0, Documentos = 1, Videos = 2 }
    public class HelperPathProvider
    {
        private IWebHostEnvironment environment;
        public HelperPathProvider(IWebHostEnvironment environment)
        {
            this.environment = environment;
        }

        public string MapPath(string fileName, Folders folder)
        {
            string carpeta = "";
            if(folder == Folders.Imagenes)
            {
                carpeta = "imagenes";
            }else if(folder == Folders.Documentos)
            {
                carpeta = "documentos";
            }else if(folder == Folders.Videos)
            {
                carpeta = "videos";
            }
            string rootPath = this.environment.WebRootPath;
            string path = Path.Combine(rootPath, carpeta, fileName);
            return path;
        }
    }
}
