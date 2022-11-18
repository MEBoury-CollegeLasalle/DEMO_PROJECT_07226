using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO_PROJECT_07226.Business;
public interface ILoginService : IService {

    public void LogUserIn(string username, string clearPassword);

    public void LogUserOut();

    public bool IsLoggedIn();

    public void RequireLoggedInUser();
}
