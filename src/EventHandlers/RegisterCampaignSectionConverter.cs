using Umbraco.Core;

namespace Graph.Components.CampaignSection
{
	public class RegisterCampaignSectionConverter : IApplicationEventHandler
	{
		public void OnApplicationInitialized(UmbracoApplicationBase umbracoApplication, ApplicationContext applicationContext)
		{
		}

		public void OnApplicationStarting(UmbracoApplicationBase umbracoApplication, ApplicationContext applicationContext)
		{
		}

		public void OnApplicationStarted(UmbracoApplicationBase umbracoApplication, ApplicationContext applicationContext)
		{
			Skybrud.Umbraco.GridData.GridContext.Current.Converters.Add(new CampaignSectionGridConverter());
		}
	}
}
