using DEMO_PROJECT_07226.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO_PROJECT_07226.GUI;
public interface IDtoDisplayer : IView {

    /// <summary>
    /// 
    /// </summary>
    /// <param name="dto">An IDTO object to display.</param>
    public void DisplayDto(IDTO dto);


}
