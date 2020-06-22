using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPMS_DLL;

namespace BPMS_BOL
{

    public class LoginDL
    {
        BPMSEntities db=new BPMSEntities();        

        public MSTR_USER check(MSTR_USER ob)
        {
            MSTR_USER user = new MSTR_USER();
            var userdetails = db.MSTR_USER.Where(x => x.USER_NAME == ob.USER_NAME && x.PASSWORD == ob.PASSWORD).FirstOrDefault();
            /*if (userdetails == null)
            {
                return null;                
            }*/
            return (user);
        }


    }



    public class LoginBL
    {
        public LogDL login;



        public LoginBL(string Usename,string Password)
        {
            var obj = new LogDL();
            obj.USER_NAME = Usename;
            obj.PASSWORD = Password;
            
            var log = new LoginDL();
            //login = log.check(obj);
        }
    }
}
