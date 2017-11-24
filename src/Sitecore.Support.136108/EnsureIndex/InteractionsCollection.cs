using Sitecore.Analytics.Data.DataAccess;
using Sitecore.Analytics.Data.DataAccess.MongoDb;
using Sitecore.Configuration;
using Sitecore.Pipelines;

namespace Sitecore.Support.EnsureIndex
{
  public class InteractionsCollection
  {
    public void Process(PipelineArgs args)
    {
      string str = DataAdapterManager.ConnectionStrings.Collection;
      string[] textArray1 = new string[] { str };
      MongoDbDriver driver = Factory.CreateObject("mongo/driver", textArray1, true) as MongoDbDriver;
      string[] strArray = new string[] { "ContactId", "_t", "StartDateTime", "_id" };
      driver.Interactions.EnsureIndex(true, strArray);
    }
  }
}
