using System;
using System.Collections.Generic;
using System.Text;

namespace Aculocity.ProjectName.BLL
{
    /// <summary>
    /// class to facilitate transition
    /// eliminate instantiation and fuss and thus provides a cached configuration object
    /// </summary>
    class AppConfigFacilitator
    {
        public static AppTimesheetConfig m_configuration;

        public AppConfigFacilitator()
        {
            m_configuration = new AppTimesheetConfig(true);
        }
    }
}
