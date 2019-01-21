using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Droid.Infra.Modules.Docker.Controler
{
    public class ComposeController
    {
        public void Delete(string path)
        {
            string command = "docker-compose rm -f";
        }
        public void Start(string path)
        {
            string command = "docker-compose up --build";
        }
        public void List(string path)
        {
            string command = "docker-compose ps";
        }
    }
}
