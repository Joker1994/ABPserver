using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace siasun.MCS.Models.TokenAuth
{
    public class AntMenuResultModel
    {
        public string path { get; set; }
        public string name { get; set; }
        public string icon { get; set; }

        public string component { get; set; }
        public string[] Routes { get; set; }
        public string[] authority { get; set; }

        public string redirect { get; set; }
        //public List<AntMenu> children { get; set; }

        //public List<AntMenu> routes { get; set; }
    }

    public class AntMenu
    {
        public string path { get; set; }
        public string name { get; set; }
        public string icon { get; set; }
        public string component { get; set; }
        public string redirect { get; set; }

        //public List<AntMenu> children { get; set; }

        //public List<AntMenu> routes { get; set; }
    }

    //public class routes2
    //{
    //    public string path { get; set; }
    //    public string name { get; set; }
    //    public string icon { get; set; }
    //    public string component { get; set; }
    //    public string redirect { get; set; }
    //}
}
