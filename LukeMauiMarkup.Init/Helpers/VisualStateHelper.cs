namespace CommunityToolkitMarkup.HotReloadSample.Helpers
{
    public static class VisualStateHelper
    {
        public static MC.VisualStateGroupList CreateVisualStateGroupList(IEnumerable<MC.VisualStateGroup> visualStateGroups)
        {
            var visualStateGroupList = new MC.VisualStateGroupList ();

            foreach (var visualStateGroup in visualStateGroups)
            {
                visualStateGroupList.Add (visualStateGroup);
            }

            return visualStateGroupList;
        }
    }
}
