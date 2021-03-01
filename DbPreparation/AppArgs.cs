using CommandLine;

namespace DbPreparation
{
    public class AppArgs
    {
        private string _databasePath;
        private string _coversPath;
        private string _viewerAppPath;

        [Option('d', "database")]
        public string DatabasePath
        {
            get
            {
                return _databasePath;
            }
            set
            {
                _databasePath = value.Trim();
            }
        }

        [Option('c', "covers")]
        public string CoversPath
        {
            get
            {
                return _coversPath;
            }
            set
            {
                _coversPath = value.Trim();
            }
        }

        [Option('v', "viewer")]
        public string ViewerAppPath
        {
            get
            {
                return _viewerAppPath;
            }
            set
            {
                _viewerAppPath = value.Trim();
            }
        }
    }
}