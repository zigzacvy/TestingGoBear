using System;
using System.Collections;
using ConsoleApp3;
using NUnit.Framework;

namespace TestProject1
{
    public class Tests
    {
        [Test]
        public void CaculatorTotalPoint_WhenInputValidData_ShouldBeSuccess()
        {
            //Arrage
            ICaculator calulator = new Caculator();
            var dataCreation = calulator.Creation();
            var input = "ANH";
            var expected = 6;

            //Act
            var actutal = calulator.TotalPoints(dataCreation, input);

            //Assert
            Assert.AreEqual(expected, actutal);
        }

        [Test]
        public void CaculatorTotalPoint_WhenInputValidDataAndFailExpectation_ShouldBeFail()
        {
            //Arrage
            ICaculator calulator = new Caculator();
            var dataCreation = calulator.Creation();
            var input = "ANH";
            var expected = 10;

            //Act
            var actutal = calulator.TotalPoints(dataCreation, input);

            //Assert
            Assert.AreNotEqual(expected, actutal);
        }

        [Test]
        public void CaculatorTotalPoint_WhenDataIsNull_ShouldThrowArgumentNullException()
        {
            //Arrage
            ICaculator caculator = new Caculator();
            Hashtable dataCreation = null;
            var expectedParamName = "storedData";
            var input = "ANH";

            //Act
            try
            {
                caculator.TotalPoints(dataCreation, input);
            }
            catch (ArgumentNullException e)
            {
                //Assert
                Assert.AreEqual(expectedParamName, e.ParamName);
            }
        }

        [Test]
        public void CaculatorTotalPoint_WhenInputIsNull_ShouldThrowArgumentNullException()
        {
            //Arrage
            ICaculator caculator = new Caculator();
            var dataCreation = caculator.Creation();
            var expectedParamName = "input";
            string input = null;
            //Act
            try
            {
                caculator.TotalPoints(dataCreation, input);
            }
            catch (ArgumentNullException e)
            {
                //Assert
                Assert.AreEqual(expectedParamName, e.ParamName);
            }
        }

        [Test]
        public void CaculatorAddtionData_WhenDataKeysdIsNull_ShouldThrowArgumentNullException()
        {
            //Arrage
            ICaculator caculator = new Caculator();
            var expectedParamName = "dataKeys";
            //Act
            try
            {
                var dataCreation = caculator.AddtionData(new Hashtable(), null, 2);
            }
            catch (ArgumentNullException e)
            {
                //Assert
                Assert.AreEqual(expectedParamName, e.ParamName);
            }
        }
    }
}