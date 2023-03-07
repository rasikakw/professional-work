using System;
using System.IO;
using System.Linq;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using DataReader.Reader.Data;
using DataReader.Utility;

namespace Tests
{
    /// <summary>
    /// DataReader tests.
    /// </summary>
    [TestClass]
    public class DataReaderTests
    {
        private string _dataFilePath;

        #region Setup.

        /// <summary>
        /// Setup test environment.
        /// </summary>
        private void Setup()
        {
            _dataFilePath = Utility.GetDataFilePath();
        }

        #endregion

        #region DataReader.Utility.Utility tests.

        /// <summary>
        /// DataReader.Utility.Utility test1.
        /// </summary>
        [TestMethod]
        public void Test_Utility1()
        {
            string appPath = Utility.GetAppPath();
            Assert.IsFalse(string.IsNullOrWhiteSpace(appPath));
            Assert.IsTrue(Directory.Exists(appPath));
        }

        /// <summary>
        /// DataReader.Utility.Utility test2.
        /// </summary>
        [TestMethod]
        public void Test_Utility2()
        {
            string dataFilePath = Utility.GetDataFilePath();
            Assert.IsFalse(string.IsNullOrWhiteSpace(dataFilePath));
            Assert.IsTrue(File.Exists(dataFilePath));
        }

        #endregion

        #region DataReader.Reader.DataReader tests.

        /// <summary>
        /// DataReader.Reader.DataReader test1.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Test_DataReader1()
        {
            Setup();

            DataReader.Reader.DataReader dr = new DataReader.Reader.DataReader();
            Datas data = dr.ReadData(" ", DataReader.Constants.DataSkipRows);
        }

        /// <summary>
        /// DataReader.Reader.DataReader test2.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(FileNotFoundException))]
        public void Test_DataReader2()
        {
            Setup();

            DataReader.Reader.DataReader dr = new DataReader.Reader.DataReader();
            Datas data = dr.ReadData("file", DataReader.Constants.DataSkipRows);
        }

        /// <summary>
        /// DataReader.Reader.DataReader test3.
        /// </summary>
        [TestMethod]
        public void Test_DataReader3()
        {
            Setup();

            DataReader.Reader.DataReader dr = new DataReader.Reader.DataReader();
            Datas data = dr.ReadData(_dataFilePath, DataReader.Constants.DataSkipRows);

            Assert.IsNotNull(data);
            Assert.IsNotNull(data.Rows);

            if (data != null && data.Rows != null)
            {
                Assert.IsTrue(data.Rows.Count > 0);

                DataRow row0 = data.Rows.Where(d => d.Customer == "Test 0").FirstOrDefault();
                Assert.IsNotNull(row0);

                if (row0 != null)
                {
                    Assert.IsTrue(row0.Customer == "Test 0");
                    Assert.IsTrue(row0.Total == 234);
                    Assert.IsTrue(row0.ConcentrationRate == 30);
                    Assert.IsTrue(row0.Concentration == 164);
                    Assert.IsTrue(row0.Aged == 0);
                    Assert.IsTrue(row0.Contras == 0);
                    Assert.IsTrue(row0.CreditNotes == 0);
                    Assert.IsTrue(row0.Related == 0);
                    Assert.IsTrue(row0.NonCommercial == 0);
                    Assert.IsTrue(row0.CreditRisk == 0);
                    Assert.IsTrue(row0.International == 0);
                    Assert.IsTrue(row0.UnsuitableInvoicing == 0);
                    Assert.IsTrue(row0.FailedVerification == 0);
                    Assert.IsTrue(row0.Approved == 70);
                    Assert.IsTrue(row0.FundingRate == 80);
                    Assert.IsTrue(row0.Limit == 56);
                    Assert.IsTrue(row0.RowNo == 1);
                }
            }
        }

        #endregion
    }
}