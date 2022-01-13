using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using WRR.BL;

namespace WRR.BLTest
{
    [TestClass]
    public class WeekTest
    {
        [TestMethod]
        public void IsValidValidWeek()
        {
            // Arrange
            Week week = new Week
            {
                StartDate = new DateTime(year:2022, month:1, day:1),
                EndDate = new DateTime(year: 2022, month: 1, day: 7)
            };
            // Act
            bool expected = true;
            bool actual = week.Validate();
            // Asset

            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void IsValidInValidWeek()
        {
            // Arrange
            Week week = new Week
            {
                StartDate = new DateTime(year: 2022, month: 1, day: 1),
                EndDate = new DateTime(year: 2022, month: 1, day: 6)
            };
            // Act
            bool expected = false;
            bool actual = week.Validate();
            // Asset

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GenerateDatesValidWeek()
        {
            // Arrange
            Week week = new Week
            {
                StartDate = new DateTime(year: 2022, month: 1, day: 1),
                EndDate = new DateTime(year: 2022, month: 1, day: 7)
            };
            List<DateTime> expected = new List<DateTime>();
            expected.Add(new DateTime(year: 2022, month: 1, day: 1));
            expected.Add(new DateTime(year: 2022, month: 1, day: 2));
            expected.Add(new DateTime(year: 2022, month: 1, day: 3));
            expected.Add(new DateTime(year: 2022, month: 1, day: 4));
            expected.Add(new DateTime(year: 2022, month: 1, day: 5));
            expected.Add(new DateTime(year: 2022, month: 1, day: 6));
            expected.Add(new DateTime(year: 2022, month: 1, day: 7));

            // Act
            week.GenerateDates();
            List<DateTime> actual = week.days;

            // Assert
            CollectionAssert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void GenerateDatesInValidWeek()
        {
            // Arrange
            Week week = new Week
            {
                StartDate = new DateTime(year: 2022, month: 1, day: 1),
                EndDate = new DateTime(year: 2022, month: 1, day: 6)
            };
            List<DateTime> expected = null;

            // Act
            week.GenerateDates();
            List<DateTime> actual = week.days;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TitleValidWeek()
        {
            // Arrange
            Week week = new Week(new DateTime(year: 2022, month: 1, day: 1), new DateTime(year: 2022, month: 1, day: 7));
            string expected = "January 1 - January 7";

            // Act
            string actual = week.Title;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TitleInValidWeek()
        {
            // Arrange
            Week week = new Week(new DateTime(year: 2022, month: 1, day: 1), new DateTime(year: 2022, month: 1, day: 6));
            string expected = String.Empty;

            // Act
            string actual = week.Title;

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
