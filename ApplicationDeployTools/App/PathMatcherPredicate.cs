using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationDeployTools.App
{
    class PathMatcherPredicate
    {
        private string m_strSpecifiedPath;
        public PathMatcherPredicate(string strSpecifiedPath)
        {
            m_strSpecifiedPath = strSpecifiedPath;
        }

        public bool MatchPath(string strTestPath)
        {
            if (String.Compare(strTestPath, m_strSpecifiedPath, true) == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        
    }
}
