using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using ZoneReplacerPlus;
using System.Xml.Linq;

namespace ZoneReplacerPlusTest
{
    [TestClass]
    public class XMLServiceTest
    {
        XDocument testDoc;
        [TestInitialize]
        public void InitializeTest()
        {
            testDoc = new XDocument(
                    new XElement("Floorplan",
                        new XElement("Zones",
                            new XElement("Count", "1"),
                            new XElement("Zone0",
                                new XElement("Top", "0"),
                                new XElement("Left", "0"),
                                new XElement("Height", "25"),
                                new XElement("Width", "160"),
                                new XElement("Rooms", "1001,1002,"),
                                new XElement("BorderStyle", "0"),
                                new XElement("ColumnCount", "1")
                                )
                            ),
                        new XElement("RoomExtZones",
                            new XElement("RoomExtZone0",
                                new XElement("Top", "0"),
                                new XElement("Left", "0"),
                                new XElement("Height", "25"),
                                new XElement("Width", "160"),
                                new XElement("ExtField", "R4"),
                                new XElement("Room", "1001,1002,"),
                                new XElement("Type", "13"),
                                new XElement("Click", "0"),
                                new XElement("DoubleClick", "0"),
                                new XElement("RightClick", "0")
                                )
                            )
                        )
                    );
        }
    }
}
