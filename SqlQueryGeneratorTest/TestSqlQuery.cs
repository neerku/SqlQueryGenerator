using System;
using SqlQueryGenerator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SqlQueryGenerator.Models;

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
                    SqlOperator="Equal",FieldName="column1",FieldValue="25",FieldType="int"
                    } }
            };
            var queryGenerator = new QueryGenerator();

          var result=  queryGenerator.GenerateQuery(primaryTable);
            Assert.AreEqual("Select * From Table1 Where column1 = 25", result);

        }


        [TestMethod]
        public void TestGenerateSqlJoinQuery()
        {
            var primaryTable = new SqlQueryGenerator.Models.PrimaryTable
            {
                Name = "Table1",
                Columns = new System.Collections.Generic.List<SqlQueryGenerator.Models.Column>()
            };

            var query = new Query
            {
                PrimaryTable = primaryTable,
                Joins = new System.Collections.Generic.List<Join>()
            {
                new Join
                {
                    Type="LEFT JOIN",
                    JoinOnColumn="Column1",
                    SecondaryTableName="Table2",
                    PrimaryTableColumn="Column1"
                }
            }
            };

            var queryGenerator = new QueryGenerator();

            var result = queryGenerator.GenerateJoinQuery(query);
            Assert.AreEqual("Select * from Table1  LEFT JOIN Table2 AS Table2 ON Table1.Column1 = Table2.Column1", result);

        }
    }
}
