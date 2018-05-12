using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MWSecurityServices
{
    class UserRecording
    {
        
        public string FileLocation()
        {
            return Directory.GetCurrentDirectory();
        }
        public string User()
        {
            return Environment.UserName;
        }
        
        public UserRecording()
        {

        }
        public void StartRecording()
        {

        }
    }
}
