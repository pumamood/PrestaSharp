using RestSharp.Serializers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Bukimedia.PrestaSharp.Entities
{
    [XmlType(Namespace = "Bukimedia/PrestaSharp/Entities")]
    [SerializeAs(Name = "prestashop")]
    public class PrestaShopEntityCollection : List<PrestaShopEntity>
    {
        public PrestaShopEntityCollection() : base()
        {

        }
        public PrestaShopEntityCollection(IEnumerable<PrestaShopEntity> collection) : base(collection)
        {

        }
    }
}
