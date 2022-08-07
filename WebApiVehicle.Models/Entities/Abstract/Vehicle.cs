using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiVehicle.Models.Enums;

namespace WebApiVehicle.Models.Entities.Abstract
{
    public abstract class Vehicle
    {
        public Guid ID { get; set; }
        private DateTime _createDate = DateTime.Now;

        public DateTime CreateDate
        {
            get { return _createDate; }
            set { _createDate = value; }
        }

        public DateTime? ModifiedDate { get; set; }
        public DateTime? RemoveDate { get; set; }
        private Statu _statu = Statu.Active;

        public Statu Statu
        {
            get { return _statu; }
            set { _statu = value; }
        }
        private Switchs _switchs=Switchs.Off;

        public Switchs Switchs
        {
            get { return _switchs; }
            set { _switchs = value; }
        }

        public string Color { get; set; }
        public string Brand { get; set; }
    }
}
