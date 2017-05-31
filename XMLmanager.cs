using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HotelMania
{
    class XMLmanager
    {
        public void SaveToFile(List<HotelRoom> list)
        {
            string m_filepath = "xmlDoc";

            XDocument doc = XDocument.Load(m_filepath);

            foreach (HotelRoom hot in list)
            {
                
            }

        }
    }
}
