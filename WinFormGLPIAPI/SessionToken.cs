using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormGLPIAPI
{
    class SessionToken
    {
        private string _session_token;

        public string session_token
        {
            get { return _session_token; }
            set { _session_token = value; }
        }
    }
}
