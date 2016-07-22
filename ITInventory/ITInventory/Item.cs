using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITInventory
{
    public class Item
    {
        private string inventoryID;
        private string serial;
        private string pcID;
        private string type;
        private string brand;
        private string location;
        private string model;
        private string os;
        private string user;
        private string assetTag;
        private bool hasMouse;
        private bool hasKeyboard;
        private bool hasScanner;
        private bool hasPSU;
        private bool hasCamera;
        private bool hasDockingStation;
        private string belongsTo;
        private string comment;

        public Item()
        {

        }

        public Item(string inventoryID, string serial, string pcID,
            string type, string brand, string location, string model,
            string os, string user, string assetTag, bool hasMouse,
            bool hasKeyboard, bool hasScanner, bool hasPSU, bool hasCamera,
            bool hasDockingStation, string belongsTo, string comment)
        {
            this.inventoryID = inventoryID;
            this.serial = serial;
            this.pcID = pcID;
            this.type = type;
            this.brand = brand;
            this.location = location;
            this.model = model;
            this.os = os;
            this.user = user;
            this.assetTag = assetTag;
            this.hasMouse = hasMouse;
            this.hasKeyboard = hasKeyboard;
            this.hasScanner = hasScanner;
            this.hasPSU = hasPSU;
            this.hasCamera = hasCamera;
            this.hasDockingStation = hasDockingStation;
            this.belongsTo = belongsTo;
            this.comment = comment;
        }

        public string InventoryID
        {
            get { return inventoryID; }
            set { inventoryID = value; }
        }

        public string Serial
        {
            get { return serial; }
            set { serial = value; }
        }

        public string AssetTag
        {
            get { return assetTag; }
            set { assetTag = value; }
        }

        public string PCID
        {
            get { return pcID; }
            set { pcID = value; }
        }

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public string Location
        {
            get { return location; }
            set { location = value; }
        }

        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public string OS
        {
            get { return os; }
            set { os = value; }
        }

        public string User
        {
            get { return user; }
            set { user = value; }
        }

        public string Comment
        {
            get { return comment; }
            set { comment = value; }
        }

        public string BelongsTo
        {
            get { return belongsTo; }
            set { belongsTo = value; }
        }

        public bool[] peripherals { get; set; }
    }
}
