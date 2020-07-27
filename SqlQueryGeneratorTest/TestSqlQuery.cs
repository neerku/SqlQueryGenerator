using System;
using SqlQueryGenerator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SqlQueryGeneratorTest
{
    [TestClass]
    public class TestSqlQuery
    {
        [TestMethod]
        public void TestGenerateSqlQuery()
        {
            var primaryTable = new SqlQueryGenerator.Models.PrimaryTable
            {
                Name = "Table1",
                Columns = new System.Collections.Generic.List<SqlQueryGenerator.Models.Column>() {
                    new SqlQueryGenerator.Models.Column {
                    SqlOperator="Equal",FieldName="column1",FieldValue="25"
                    } }
            };
            var queryGenerator = new QueryGenerator();

          var result=  queryGenerator.GenerateQuery(primaryTable);
            Assert.IsTrue(string.Equals("Select * From Table1 Where column1 = 25", result) == true);

        }
    }
}
