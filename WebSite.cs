using System;
namespace Class06._02._2023HM
{
    public class WebSite
    {
        private string Name_WebSite;
        private string Path_WebSite;
        private string Description_WebSite;
        private string IP_WebSite;

        public WebSite() { }
        public WebSite(string NW, string PW, string DW, string IPW)
        {
            Name_WebSite = NW;
            Path_WebSite = PW;
            Description_WebSite = DW;
            IP_WebSite = IPW;
        }
        public string name_website
        {
            set
            {
                Name_WebSite = value;
            }
            get
            {
                return Name_WebSite;
            }
        }
        public string path_website
        {
            set
            {
                Path_WebSite = value;
            }
            get
            {
                return Path_WebSite;
            }
        }
        public string description_webSite
        {
            set
            {
                Description_WebSite = value;
            }
            get
            {
                return Description_WebSite;
            }
        }
        public string ip_website
        {
            set
            {
                IP_WebSite = value;
            }
            get
            {
                return IP_WebSite;
            }
        }

        public void Print()
        {
            Console.WriteLine($"Name_WebSite:{Name_WebSite}\tPath_WebSite:{Path_WebSite}\tDescription_WebSite:{Description_WebSite}\tIP_WebSite:{IP_WebSite}");
        }

        public override string ToString()
        {
            return $"Name_WebSite:{Name_WebSite}\tPath_WebSite:{Path_WebSite}\tDescription_WebSite:{Description_WebSite}\tIP_WebSite:{IP_WebSite}";
        }

    }

    
}
