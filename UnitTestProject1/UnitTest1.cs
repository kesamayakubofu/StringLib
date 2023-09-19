using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using StringLib;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod] 

        public void StringParse_StringParses_ReturnedTrueVENGRIA()
        {
            //Arrange
            string testString = "2006.05.30";//проверка на венгрию
            //Act
            bool result = StringClass.StringParse(testString,1);
            //Assert
            Assert.IsTrue(result);

        }
        [TestMethod]

        public void StringParse_StringParses_ReturnedTruePOLSHASWICIALITVAKANADA()
        {
            //Arrange
            string testString = "2006-05-30";//проверка на нерусских
            //Act
            bool result = StringClass.StringParse(testString, 1);
            //Assert
            Assert.IsTrue(result);

        }
        [TestMethod]

        public void StringParse_StringParses_ReturnedTruJOPANIA()
        {
            //Arrange
            string testString = "2006/05/30";//проверка на узкоглазых
            //Act
            bool result = StringClass.StringParse(testString, 1);
            //Assert
            Assert.IsTrue(result);

        }
        [TestMethod]

        public void StringParse_StringParses_ReturnedTrueCHINACHINACHINA()
        {
            //Arrange
            string testString = "2006-5-30";//проверка на узкоглазых чинайцев
            //Act
            bool result = StringClass.StringParse(testString, 1);
            //Assert
            Assert.IsTrue(result);

        }
        [TestMethod]

        public void StringParse_StringParses_ReturnedTrueTAIWAN()
        {
            //Arrange
            string testString = "2006/5/30";//проверка на узкоглазых чинайцев
            //Act
            bool result = StringClass.StringParse(testString, 1);
            //Assert
            Assert.IsTrue(result);

        }
        

       
        [TestMethod]

        public void StringParse_StringParses_ReturnedTrueCZH()
        {
            //Arrange
            string testString = "30.5.2006";//проверка на узкоглазых чинайцев
            //Act
            bool result = StringClass.StringParse(testString, 1);
            //Assert
            Assert.IsTrue(result);

        }
        [TestMethod]

        public void StringParse_StringParses_ReturnedTrueNIGERLANDI()
        {
            //Arrange
            string testString = "30-5-2006";//проверка на узкоглазых чинайцев
            //Act
            bool result = StringClass.StringParse(testString, 1);
            //Assert
            Assert.IsTrue(result);

        }
        [TestMethod]

        public void StringParse_StringParses_ReturnedTrueBrazil()
        {
            //Arrange
            string testString = "30/5/2006";//проверка на узкоглазых чинайцев
            //Act
            bool result = StringClass.StringParse(testString, 1);
            //Assert
            Assert.IsTrue(result);

        }
        [TestMethod]

        public void StringParse_StringParses_ReturnedTrueNIGERMANIA()
        {
            //Arrange
            string testString = "30.05.2006";//проверка на узкоглазых чинайцев
            //Act
            bool result = StringClass.StringParse(testString, 1);
            //Assert
            Assert.IsTrue(result);

        }
        [TestMethod]

        public void StringParse_StringParses_ReturnedTrueDANYA()
        {
            //Arrange
            string testString = "30-05-2006";//проверка на узкоглазых чинайцев
            //Act
            bool result = StringClass.StringParse(testString, 1);
            //Assert
            Assert.IsTrue(result);

        }
        [TestMethod]

        public void StringParse_StringParses_ReturnedTrueVIETNAM()
        {
            //Arrange
            string testString = "30/05/2006";//проверка на узкоглазых чинайцев
            //Act
            bool result = StringClass.StringParse(testString, 1);
            //Assert
            Assert.IsTrue(result);

        }
        

       
        [TestMethod]

        public void StringParse_StringParses_ReturnedFalseprobelonly()
        {
            //Arrange
            string testString = " ";//проверка на узкоглазых чинайцев
            //Act
            bool result = StringClass.StringParse(testString, 1);
            //Assert
            Assert.IsFalse(result);

        }
        [TestMethod]

        public void StringParse_StringParses_ReturnedFalseEmptyString()
        {
            //Arrange
            string testString = "";//проверка на узкоглазых чинайцев
            //Act
            bool result = StringClass.StringParse(testString, 1);
            //Assert
            Assert.IsFalse(result);

        }
        [TestMethod]

        public void StringParse_StringParses_ReturnedTrueMAGDATA()
        {
            //Arrange
            string testString = "01.01.1900";//проверка на узкоглазых чинайцев
            //Act
            bool result = StringClass.StringParse(testString, 1);
            //Assert
            Assert.IsTrue(result);

        }
        [TestMethod]

        public void StringParse_StringParses_ReturnedFALSEDATE()
        {
            //Arrange
            string testString = "00.12.2023, 30.02.23";//проверка на узкоглазых чинайцев
            //Act
            bool result = StringClass.StringParse(testString, 1);
            //Assert
            Assert.IsFalse(result);

        }
        [TestMethod]

        public void StringParse_StringParses_ReturnedFALSEDATE1()
        {
            //Arrange
            string testString = "12.15.2023";//проверка на узкоглазых чинайцев
            //Act
            bool result = StringClass.StringParse(testString, 1);
            //Assert
            Assert.IsFalse(result);

        }
        [TestMethod]

        public void StringParse_StringParses_ReturnedFALSEDATE12()
        {
            //Arrange
            string testString = "12.15.0000 ";//проверка на узкоглазых чинайцев
            //Act
            bool result = StringClass.StringParse(testString, 1);
            //Assert
            Assert.IsFalse(result);

        }
    }
}
